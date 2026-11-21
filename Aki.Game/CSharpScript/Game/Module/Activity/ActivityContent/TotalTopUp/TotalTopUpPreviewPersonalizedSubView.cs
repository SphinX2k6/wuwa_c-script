using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F8E RID: 20366
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewPersonalizedSubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x06033126 RID: 209190 RVA: 0x00E508A4 File Offset: 0x00E4EAA4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x06033127 RID: 209191 RVA: 0x00E50900 File Offset: 0x00E4EB00
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			IEnumerable<int> enumerable;
			if (param == null)
			{
				enumerable = null;
			}
			else
			{
				TotalTopUpRewardData rewardData = param.RewardData;
				enumerable = ((rewardData != null) ? rewardData.ItemIdList : null);
			}
			this.ItemIdList = new List<int>(enumerable ?? new List<int>());
			for (int i = 0; i < TotalTopUpPreviewPersonalizedSubView.BUTTON_NODES.Length; i++)
			{
				int name = TotalTopUpPreviewPersonalizedSubView.BUTTON_NODES[i];
				bool flag = i < this.ItemIdList.Count;
				base.SetButtonUiActive(name, flag);
				if (flag)
				{
					UUIButtonComponent button = base.GetButton(name);
					if (button != null)
					{
						int capturedI = i;
						button.OnClickCallBack.Bind(delegate()
						{
							this.OnClick(capturedI);
						});
					}
				}
			}
		}

		// Token: 0x06033128 RID: 209192 RVA: 0x00E509A8 File Offset: 0x00E4EBA8
		private void OnClick(int index)
		{
			int num = this.ItemIdList[index];
			InventoryConfig instance = InventoryConfig.Instance;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(num) : null;
			if (itemConfig == null)
			{
				string message = "未找到个性化饰品道具配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", num);
				TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (ValueTuple<Func<int, CSharpScript.Game.Module.Inventory.ItemConfig, bool>, Action<int, CSharpScript.Game.Module.Inventory.ItemConfig>> valueTuple2 in TotalTopUpDefine.itemTipsFunctionList)
			{
				Func<int, CSharpScript.Game.Module.Inventory.ItemConfig, bool> item = valueTuple2.Item1;
				Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> item2 = valueTuple2.Item2;
				if (item(num, itemConfig))
				{
					item2(num, itemConfig);
					return;
				}
			}
			ItemController.Instance.OpenItemTipsByItemId(num, false, null, false);
		}

		// Token: 0x0401B1D5 RID: 111061
		[StaticVariableRuleIgnore]
		private static readonly int[] BUTTON_NODES = new int[]
		{
			0,
			1,
			2
		};

		// Token: 0x0401B1D6 RID: 111062
		private List<int> ItemIdList = new List<int>();
	}
}
