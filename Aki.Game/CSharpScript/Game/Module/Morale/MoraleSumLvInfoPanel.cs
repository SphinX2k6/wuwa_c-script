using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200439F RID: 17311
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleSumLvInfoPanel : UiPanelBase
	{
		// Token: 0x0602BBA4 RID: 179108 RVA: 0x00C45C78 File Offset: 0x00C43E78
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

		// Token: 0x0602BBA5 RID: 179109 RVA: 0x00C45CC4 File Offset: 0x00C43EC4
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

		// Token: 0x0602BBA6 RID: 179110 RVA: 0x00C45D58 File Offset: 0x00C43F58
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleSumLvInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleSumLvInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BBA7 RID: 179111 RVA: 0x00C45D9B File Offset: 0x00C43F9B
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602BBA8 RID: 179112 RVA: 0x00C45D9D File Offset: 0x00C43F9D
		private void OnBtnBuffSum()
		{
			UiManager.Instance.OpenView(EUiViewName.MoraleBuffView, null, null);
		}

		// Token: 0x0602BBA9 RID: 179113 RVA: 0x00C45DB0 File Offset: 0x00C43FB0
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

		// Token: 0x0602BBAA RID: 179114 RVA: 0x00C45E14 File Offset: 0x00C44014
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

		// Token: 0x04017917 RID: 96535
		public MoraleLvInfoItem ItemMoraleLv;

		// Token: 0x04017918 RID: 96536
		public MoraleUnbreakableLvInfoItem ItemUnbreakableLv;

		// Token: 0x0200A09D RID: 41117
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E75 RID: 204405
			public const int ItemMoraleLv = 0;

			// Token: 0x04031E76 RID: 204406
			public const int ItemUnbreakableLv = 1;

			// Token: 0x04031E77 RID: 204407
			public const int BtnBuffSum = 2;

			// Token: 0x04031E78 RID: 204408
			public const int ItemBuffSumRedDot = 3;
		}
	}
}
