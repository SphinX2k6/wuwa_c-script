using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053BC RID: 21436
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleSumLvInfoPanel : UiPanelBase
	{
		// Token: 0x06036C5E RID: 224350 RVA: 0x00CF6BD0 File Offset: 0x00CF4DD0
		public UniTask Init(UUIItem item)
		{
			MoraleSumLvInfoPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleSumLvInfoPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036C5F RID: 224351 RVA: 0x00CF6C1C File Offset: 0x00CF4E1C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnBuffSum))
			};
		}

		// Token: 0x06036C60 RID: 224352 RVA: 0x00CF6CB0 File Offset: 0x00CF4EB0
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleSumLvInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleSumLvInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C61 RID: 224353 RVA: 0x00CF6CF3 File Offset: 0x00CF4EF3
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06036C62 RID: 224354 RVA: 0x00CF6CF5 File Offset: 0x00CF4EF5
		private void OnBtnBuffSum()
		{
			UiManager.Instance.OpenView(EUiViewName.MoraleBuffView, null, null);
		}

		// Token: 0x06036C63 RID: 224355 RVA: 0x00CF6D08 File Offset: 0x00CF4F08
		public void UpdateData()
		{
			MoraleModel instance = MoraleModel.Instance;
			bool? flag = (instance != null) ? new bool?(instance.IsMoraleGameOver()) : null;
			this.SetActive(!flag.GetValueOrDefault());
			if (flag.GetValueOrDefault())
			{
				return;
			}
			this.ItemMoraleLv.UpdateData();
			this.ItemUnbreakableLv.UpdateData();
			this.UpdateRedDot();
		}

		// Token: 0x06036C64 RID: 224356 RVA: 0x00CF6D6C File Offset: 0x00CF4F6C
		public void UpdateRedDot()
		{
			bool uiactive = MoraleModel.Instance.RedDotAreaBuff();
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0401CE7F RID: 118399
		public MoraleLvInfoItem ItemMoraleLv;

		// Token: 0x0401CE80 RID: 118400
		public MoraleUnbreakableLvInfoItem ItemUnbreakableLv;

		// Token: 0x0200B665 RID: 46693
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04037420 RID: 226336
			public const int ItemMoraleLv = 0;

			// Token: 0x04037421 RID: 226337
			public const int ItemUnbreakableLv = 1;

			// Token: 0x04037422 RID: 226338
			public const int BtnBuffSum = 2;

			// Token: 0x04037423 RID: 226339
			public const int ItemBuffSumRedDot = 3;
		}
	}
}
