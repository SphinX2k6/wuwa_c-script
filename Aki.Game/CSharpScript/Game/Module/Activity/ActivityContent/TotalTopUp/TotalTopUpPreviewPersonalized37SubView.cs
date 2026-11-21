using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F8C RID: 20364
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPreviewPersonalized37SubView : TotalTopUpPreviewSubViewBase
	{
		// Token: 0x0603311D RID: 209181 RVA: 0x00E50668 File Offset: 0x00E4E868
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickMagnifier1)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickMagnifier2)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickMagnifier3))
			};
		}

		// Token: 0x0603311E RID: 209182 RVA: 0x00E5072C File Offset: 0x00E4E92C
		public UniTask ShowPreviewAsync(ITotalTopUpPreviewViewParam param)
		{
			TotalTopUpPreviewPersonalized37SubView.<ShowPreviewAsync>d__4 <ShowPreviewAsync>d__;
			<ShowPreviewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowPreviewAsync>d__.<>4__this = this;
			<ShowPreviewAsync>d__.param = param;
			<ShowPreviewAsync>d__.<>1__state = -1;
			<ShowPreviewAsync>d__.<>t__builder.Start<TotalTopUpPreviewPersonalized37SubView.<ShowPreviewAsync>d__4>(ref <ShowPreviewAsync>d__);
			return <ShowPreviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603311F RID: 209183 RVA: 0x00E50777 File Offset: 0x00E4E977
		public override void ShowPreview(ITotalTopUpPreviewViewParam param)
		{
			this.ShowPreviewAsync(param).Forget();
		}

		// Token: 0x06033120 RID: 209184 RVA: 0x00E50785 File Offset: 0x00E4E985
		private void OnClickMagnifier1()
		{
			this.OpenItemTips(0);
		}

		// Token: 0x06033121 RID: 209185 RVA: 0x00E5078E File Offset: 0x00E4E98E
		private void OnClickMagnifier2()
		{
			this.OpenItemTips(1);
		}

		// Token: 0x06033122 RID: 209186 RVA: 0x00E50797 File Offset: 0x00E4E997
		private void OnClickMagnifier3()
		{
			this.OpenItemTips(2);
		}

		// Token: 0x06033123 RID: 209187 RVA: 0x00E507A0 File Offset: 0x00E4E9A0
		private void OpenItemTips(int index)
		{
			if (index >= this.ItemIdList.Count)
			{
				return;
			}
			int num = this.ItemIdList[index];
			if (num == 0)
			{
				return;
			}
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

		// Token: 0x0401B1CE RID: 111054
		[StaticVariableRuleIgnore]
		private static readonly int[] MAGNIFIER_NODES = new int[]
		{
			1,
			2,
			3
		};

		// Token: 0x0401B1CF RID: 111055
		[Nullable(2)]
		private TotalTopUpRecharge37InfoItem RechargeInfo;

		// Token: 0x0401B1D0 RID: 111056
		private List<int> ItemIdList = new List<int>();
	}
}
