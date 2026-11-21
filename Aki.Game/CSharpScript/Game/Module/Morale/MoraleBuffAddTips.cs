using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200438E RID: 17294
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddTips : UiViewBase
	{
		// Token: 0x0602BAF5 RID: 178933 RVA: 0x00C42E14 File Offset: 0x00C41014
		public MoraleBuffAddTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BAF6 RID: 178934 RVA: 0x00C42E20 File Offset: 0x00C41020
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602BAF7 RID: 178935 RVA: 0x00C42F29 File Offset: 0x00C41129
		private void InitDataParam()
		{
			object openParam = this.OpenParam;
		}

		// Token: 0x0602BAF8 RID: 178936 RVA: 0x00C42F34 File Offset: 0x00C41134
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffAddTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffAddTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BAF9 RID: 178937 RVA: 0x00C42F77 File Offset: 0x00C41177
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x0602BAFA RID: 178938 RVA: 0x00C42F7F File Offset: 0x00C4117F
		private void OnBtnMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BAFB RID: 178939 RVA: 0x00C42F88 File Offset: 0x00C41188
		private MoraleBuffAddItem CreateItem()
		{
			return new MoraleBuffAddItem();
		}

		// Token: 0x0602BAFC RID: 178940 RVA: 0x00C42F8F File Offset: 0x00C4118F
		public void UpdateData()
		{
			this.UpdatePos();
			this.UpdateTitle();
			this.UpdateList();
		}

		// Token: 0x0602BAFD RID: 178941 RVA: 0x00C42FA4 File Offset: 0x00C411A4
		public void UpdatePos()
		{
			MoraleBuffAddTipsParams moraleBuffAddTipsParams = this.OpenParam as MoraleBuffAddTipsParams;
			UUIItem uuiitem = (moraleBuffAddTipsParams != null) ? moraleBuffAddTipsParams.ItemForLocation : null;
			if (uuiitem == null)
			{
				return;
			}
			base.GetItem(3).SetUIRelativeLocation(uuiitem.RelativeLocation);
		}

		// Token: 0x0602BAFE RID: 178942 RVA: 0x00C42FE0 File Offset: 0x00C411E0
		public void UpdateTitle()
		{
			MoraleBuffAddTipsParams moraleBuffAddTipsParams = this.OpenParam as MoraleBuffAddTipsParams;
			string key = ((moraleBuffAddTipsParams != null) ? moraleBuffAddTipsParams.TitleKey : null) ?? "Morale_title_22";
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x0602BAFF RID: 178943 RVA: 0x00C43020 File Offset: 0x00C41220
		public void UpdateList()
		{
			MoraleBuffAddTipsParams moraleBuffAddTipsParams = this.OpenParam as MoraleBuffAddTipsParams;
			List<IMoraleBuffAddItemData> data = ((moraleBuffAddTipsParams != null) ? moraleBuffAddTipsParams.DataList : null) ?? MoraleModel.Instance.GetAllRoleAttrAddList();
			this.ItemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x040178F5 RID: 96501
		public GenericLayout<MoraleBuffAddItem, IMoraleBuffAddItemData> ItemLayout;

		// Token: 0x0200A074 RID: 41076
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D97 RID: 204183
			public const int BtnMask = 0;

			// Token: 0x04031D98 RID: 204184
			public const int LayoutContainer = 1;

			// Token: 0x04031D99 RID: 204185
			public const int ItemInfoTemplate = 2;

			// Token: 0x04031D9A RID: 204186
			public const int ItemRoot = 3;

			// Token: 0x04031D9B RID: 204187
			public const int TextTitle = 4;
		}
	}
}
