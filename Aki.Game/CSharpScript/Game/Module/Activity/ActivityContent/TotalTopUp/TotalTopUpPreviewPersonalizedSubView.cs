using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FA7 RID: 24487
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewPersonalizedSubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603E18C RID: 254348 RVA: 0x00EFEBE8 File Offset: 0x00EFCDE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0603E18D RID: 254349 RVA: 0x00EFEC44 File Offset: 0x00EFCE44
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

		// Token: 0x0603E18E RID: 254350 RVA: 0x00EFECEC File Offset: 0x00EFCEEC
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
			ItemController.Instance.OpenItemTipsByItemId(num, false, null);
		}

		// Token: 0x04020703 RID: 132867
		[StaticVariableRuleIgnore]
		private static readonly int[] BUTTON_NODES = new int[]
		{
			0,
			1,
			2
		};

		// Token: 0x04020704 RID: 132868
		private List<int> ItemIdList = new List<int>();
	}
}
