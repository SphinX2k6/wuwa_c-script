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
	// Token: 0x02004A96 RID: 19094
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopDetailInfoItem : UiPanelBase
	{
		// Token: 0x060317E7 RID: 202727 RVA: 0x00B78D02 File Offset: 0x00B76F02
		public TrapDefenseBuildingDevelopDetailInfoItem(bool IsNeedResetBtn)
		{
			this.IsNeedResetBtn = IsNeedResetBtn;
		}

		// Token: 0x060317E8 RID: 202728 RVA: 0x00B78D18 File Offset: 0x00B76F18
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

		// Token: 0x060317E9 RID: 202729 RVA: 0x00B78E84 File Offset: 0x00B77084
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopDetailInfoItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailInfoItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317EA RID: 202730 RVA: 0x00B78EC8 File Offset: 0x00B770C8
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.IsNeedResetBtn);
			}
			this.Layout = new GenericLayout<TrapDefenseBuildingDevelopAttrItem, ITrapDefenseBuildingDevelopAttrInfo>(base.GetVerticalLayout(5), new Func<TrapDefenseBuildingDevelopAttrItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060317EB RID: 202731 RVA: 0x00B78F1B File Offset: 0x00B7711B
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

		// Token: 0x060317EC RID: 202732 RVA: 0x00B78F44 File Offset: 0x00B77144
		private UniTask LoadMaterial()
		{
			TrapDefenseBuildingDevelopDetailInfoItem.<LoadMaterial>d__11 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<TrapDefenseBuildingDevelopDetailInfoItem.<LoadMaterial>d__11>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x060317ED RID: 202733 RVA: 0x00B78F87 File Offset: 0x00B77187
		private void CancelLoad()
		{
			if (this.HandleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
				this.HandleId = -1;
			}
		}

		// Token: 0x060317EE RID: 202734 RVA: 0x00B78FAC File Offset: 0x00B771AC
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

		// Token: 0x060317EF RID: 202735 RVA: 0x00B790AC File Offset: 0x00B772AC
		protected void RefreshAttrList()
		{
			List<ITrapDefenseBuildingDevelopAttrInfo> attrItem = this.Data.GetAttrItem();
			this.Layout.RefreshByData(attrItem, null, true);
		}

		// Token: 0x060317F0 RID: 202736 RVA: 0x00B790D4 File Offset: 0x00B772D4
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

		// Token: 0x060317F1 RID: 202737 RVA: 0x00B79119 File Offset: 0x00B77319
		private TrapDefenseBuildingDevelopAttrItem InitGridItem()
		{
			return new TrapDefenseBuildingDevelopAttrItem();
		}

		// Token: 0x0401A75D RID: 108381
		protected GenericLayout<TrapDefenseBuildingDevelopAttrItem, ITrapDefenseBuildingDevelopAttrInfo> Layout;

		// Token: 0x0401A75E RID: 108382
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x0401A75F RID: 108383
		private MediaPlayer MediaPlayer;

		// Token: 0x0401A760 RID: 108384
		private int HandleId = -1;

		// Token: 0x0401A761 RID: 108385
		protected bool IsNeedResetBtn;

		// Token: 0x0200ABEC RID: 44012
		[NullableContext(0)]
		private class EItemDefine
		{
			// Token: 0x040343E6 RID: 213990
			public const int Title = 0;

			// Token: 0x040343E7 RID: 213991
			public const int Level = 1;

			// Token: 0x040343E8 RID: 213992
			public const int BtnFunctionA = 2;

			// Token: 0x040343E9 RID: 213993
			public const int AttrInfoScroll = 3;

			// Token: 0x040343EA RID: 213994
			public const int TxtDesc = 4;

			// Token: 0x040343EB RID: 213995
			public const int PanelAttrItemLayout = 5;

			// Token: 0x040343EC RID: 213996
			public const int BuildingAttrItem = 6;

			// Token: 0x040343ED RID: 213997
			public const int CG = 7;
		}
	}
}
