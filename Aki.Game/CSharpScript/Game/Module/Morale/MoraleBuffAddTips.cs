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
	// Token: 0x020053AB RID: 21419
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddTips : UiViewBase
	{
		// Token: 0x06036BAF RID: 224175 RVA: 0x00CF3D6C File Offset: 0x00CF1F6C
		public MoraleBuffAddTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036BB0 RID: 224176 RVA: 0x00CF3D78 File Offset: 0x00CF1F78
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

		// Token: 0x06036BB1 RID: 224177 RVA: 0x00CF3E81 File Offset: 0x00CF2081
		private void InitDataParam()
		{
			object openParam = this.OpenParam;
		}

		// Token: 0x06036BB2 RID: 224178 RVA: 0x00CF3E8C File Offset: 0x00CF208C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffAddTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffAddTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036BB3 RID: 224179 RVA: 0x00CF3ECF File Offset: 0x00CF20CF
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06036BB4 RID: 224180 RVA: 0x00CF3ED7 File Offset: 0x00CF20D7
		private void OnBtnMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036BB5 RID: 224181 RVA: 0x00CF3EE0 File Offset: 0x00CF20E0
		private MoraleBuffAddItem CreateItem()
		{
			return new MoraleBuffAddItem();
		}

		// Token: 0x06036BB6 RID: 224182 RVA: 0x00CF3EE7 File Offset: 0x00CF20E7
		public void UpdateData()
		{
			this.UpdatePos();
			this.UpdateTitle();
			this.UpdateList();
		}

		// Token: 0x06036BB7 RID: 224183 RVA: 0x00CF3EFC File Offset: 0x00CF20FC
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

		// Token: 0x06036BB8 RID: 224184 RVA: 0x00CF3F38 File Offset: 0x00CF2138
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

		// Token: 0x06036BB9 RID: 224185 RVA: 0x00CF3F78 File Offset: 0x00CF2178
		public void UpdateList()
		{
			MoraleBuffAddTipsParams moraleBuffAddTipsParams = this.OpenParam as MoraleBuffAddTipsParams;
			List<IMoraleBuffAddItemData> data = ((moraleBuffAddTipsParams != null) ? moraleBuffAddTipsParams.DataList : null) ?? MoraleModel.Instance.GetAllRoleAttrAddList();
			this.ItemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0401CE5D RID: 118365
		public GenericLayout<MoraleBuffAddItem, IMoraleBuffAddItemData> ItemLayout;

		// Token: 0x0200B63C RID: 46652
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04037342 RID: 226114
			public const int BtnMask = 0;

			// Token: 0x04037343 RID: 226115
			public const int LayoutContainer = 1;

			// Token: 0x04037344 RID: 226116
			public const int ItemInfoTemplate = 2;

			// Token: 0x04037345 RID: 226117
			public const int ItemRoot = 3;

			// Token: 0x04037346 RID: 226118
			public const int TextTitle = 4;
		}
	}
}
