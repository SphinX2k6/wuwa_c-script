using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A3E RID: 14910
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopDetailInfoItem : UiPanelBase
	{
		// Token: 0x06026577 RID: 157047 RVA: 0x00ABCCB6 File Offset: 0x00ABAEB6
		public TrapDefenseBuildingDevelopDetailInfoItem(bool IsNeedResetBtn)
		{
			this.IsNeedResetBtn = IsNeedResetBtn;
		}

		// Token: 0x06026578 RID: 157048 RVA: 0x00ABCCCC File Offset: 0x00ABAECC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedReset));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026579 RID: 157049 RVA: 0x00ABCE38 File Offset: 0x00ABB038
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopDetailInfoItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailInfoItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602657A RID: 157050 RVA: 0x00ABCE7C File Offset: 0x00ABB07C
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.IsNeedResetBtn);
			}
			this.Layout = new GenericLayout<TrapDefenseBuildingDevelopAttrItem, ITrapDefenseBuildingDevelopAttrInfo>(base.GetVerticalLayout(5), new Func<TrapDefenseBuildingDevelopAttrItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x0602657B RID: 157051 RVA: 0x00ABCECF File Offset: 0x00ABB0CF
		protected override void OnBeforeDestroy()
		{
			this.Layout = null;
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer != null)
			{
				mediaPlayer.Clear();
			}
			this.MediaPlayer = null;
			this.CancelLoad();
		}

		// Token: 0x0602657C RID: 157052 RVA: 0x00ABCEF8 File Offset: 0x00ABB0F8
		private UniTask LoadMaterial()
		{
			TrapDefenseBuildingDevelopDetailInfoItem.<LoadMaterial>d__11 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailInfoItem.<LoadMaterial>d__11>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0602657D RID: 157053 RVA: 0x00ABCF3B File Offset: 0x00ABB13B
		private void CancelLoad()
		{
			if (this.HandleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
				this.HandleId = -1;
			}
		}

		// Token: 0x0602657E RID: 157054 RVA: 0x00ABCF60 File Offset: 0x00ABB160
		public void UpdateDetail(TrapDefenseBuildingDevelopItemData data)
		{
			bool flag = data != this.Data;
			this.Data = data;
			bool uiactive = this.IsNeedResetBtn && data.GetLevel() > 1;
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetName(), Array.Empty<object>());
			ValueTuple<string, string[]> desc = data.GetDesc();
			string item = desc.Item1;
			string[] item2 = desc.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), item, item2);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerDefense_BuildingLv_Text", new <>z__ReadOnlySingleElementList<object>(data.GetLevel()));
			ValueTuple<string, string> video = data.GetVideo();
			string item3 = video.Item1;
			string item4 = video.Item2;
			if (flag)
			{
				this.MediaPlayer.PlayVideo(item3, item4, true);
			}
			this.RefreshAttrList();
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseBuildingDevelopDetailInfoItemUpdate, this.IsNeedResetBtn);
		}

		// Token: 0x0602657F RID: 157055 RVA: 0x00ABD060 File Offset: 0x00ABB260
		protected void RefreshAttrList()
		{
			List<ITrapDefenseBuildingDevelopAttrInfo> attrItem = this.Data.GetAttrItem();
			this.Layout.RefreshByData(attrItem, null, true);
		}

		// Token: 0x06026580 RID: 157056 RVA: 0x00ABD088 File Offset: 0x00ABB288
		private void OnClickedReset()
		{
			if (!this.IsNeedResetBtn)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrapDefenseOrganReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				TrapDefenseController.Instance.RequestTrapDefenseDevelopResetOne(this.Data.Id);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06026581 RID: 157057 RVA: 0x00ABD0CD File Offset: 0x00ABB2CD
		private TrapDefenseBuildingDevelopAttrItem InitGridItem()
		{
			return new TrapDefenseBuildingDevelopAttrItem();
		}

		// Token: 0x040150AF RID: 86191
		protected GenericLayout<TrapDefenseBuildingDevelopAttrItem, ITrapDefenseBuildingDevelopAttrInfo> Layout;

		// Token: 0x040150B0 RID: 86192
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x040150B1 RID: 86193
		private MediaPlayer MediaPlayer;

		// Token: 0x040150B2 RID: 86194
		private int HandleId = -1;

		// Token: 0x040150B3 RID: 86195
		protected bool IsNeedResetBtn;

		// Token: 0x0200960C RID: 38412
		[NullableContext(0)]
		private class EItemDefine
		{
			// Token: 0x0402ED97 RID: 191895
			public const int Title = 0;

			// Token: 0x0402ED98 RID: 191896
			public const int Level = 1;

			// Token: 0x0402ED99 RID: 191897
			public const int BtnFunctionA = 2;

			// Token: 0x0402ED9A RID: 191898
			public const int AttrInfoScroll = 3;

			// Token: 0x0402ED9B RID: 191899
			public const int TxtDesc = 4;

			// Token: 0x0402ED9C RID: 191900
			public const int PanelAttrItemLayout = 5;

			// Token: 0x0402ED9D RID: 191901
			public const int BuildingAttrItem = 6;

			// Token: 0x0402ED9E RID: 191902
			public const int CG = 7;
		}
	}
}
