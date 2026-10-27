using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200662A RID: 26154
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechLevelUpSuccessEffectView : UiViewBase
	{
		// Token: 0x06041908 RID: 268552 RVA: 0x00FE6A17 File Offset: 0x00FE4C17
		public FishingTechLevelUpSuccessEffectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041909 RID: 268553 RVA: 0x00FE6A20 File Offset: 0x00FE4C20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604190A RID: 268554 RVA: 0x00FE6B6D File Offset: 0x00FE4D6D
		protected override void OnBeforeCreate()
		{
			if (this.OpenParam == null)
			{
				return;
			}
			this.Data = (this.OpenParam as LevelUpSuccessEffectData);
			this.SetAudio();
		}

		// Token: 0x0604190B RID: 268555 RVA: 0x00FE6B90 File Offset: 0x00FE4D90
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			this.EffectTextLayout = new GenericScrollViewNew<SuccessDescriptionItem, SingleText>(base.GetScrollViewWithScrollbar(0), new Func<SuccessDescriptionItem>(this.CreateTextItem), item.GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0604190C RID: 268556 RVA: 0x00FE6BD0 File Offset: 0x00FE4DD0
		protected override void OnBeforeShow()
		{
			this.SetTitle();
			this.SetViewContent();
			this.SetTipsText();
		}

		// Token: 0x0604190D RID: 268557 RVA: 0x00FE6BE4 File Offset: 0x00FE4DE4
		private void SetAudio()
		{
			LevelUpSuccessEffectData data = this.Data;
			string text = (data != null) ? data.AudioId : null;
			if (!StringUtils.IsEmpty(text))
			{
				Audio? audio;
				string audioEvent = (AudioConfig.Instance.GetAudioPath(text) != null) ? audio.GetValueOrDefault().Path : null;
				base.SetAudioEvent(audioEvent);
			}
		}

		// Token: 0x0604190E RID: 268558 RVA: 0x00FE6C3C File Offset: 0x00FE4E3C
		private void OnClickButton()
		{
			LevelUpSuccessEffectData data = this.Data;
			Action action = (data != null) ? data.ClickFunction : null;
			if (action != null)
			{
				action();
			}
			base.CloseMe(null);
		}

		// Token: 0x0604190F RID: 268559 RVA: 0x00FE6C6C File Offset: 0x00FE4E6C
		private SuccessDescriptionItem CreateTextItem()
		{
			return new SuccessDescriptionItem();
		}

		// Token: 0x06041910 RID: 268560 RVA: 0x00FE6C74 File Offset: 0x00FE4E74
		private void SetTipsText()
		{
			LevelUpSuccessEffectData data = this.Data;
			string key = ((data != null) ? data.ClickText : null) ?? "Text_BackToView_Text";
			base.GetText(3).ShowTextNew(key);
		}

		// Token: 0x06041911 RID: 268561 RVA: 0x00FE6CAC File Offset: 0x00FE4EAC
		private void SetTitle()
		{
			LevelUpSuccessEffectData data = this.Data;
			string key = ((data != null) ? data.Title : null) ?? "Text_ActivedSucceed_Text";
			base.GetText(2).ShowTextNew(key);
		}

		// Token: 0x06041912 RID: 268562 RVA: 0x00FE6CE4 File Offset: 0x00FE4EE4
		private void SetViewContent()
		{
			if (this.EffectTextLayout != null)
			{
				LevelUpSuccessEffectData data = this.Data;
				List<SingleText> list = (data != null) ? data.TextList : null;
				if (list != null)
				{
					base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(true);
					this.EffectTextLayout.RefreshByData(list, null, false);
					return;
				}
				base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(false);
			}
		}

		// Token: 0x040221CA RID: 139722
		private LevelUpSuccessEffectData Data;

		// Token: 0x040221CB RID: 139723
		private GenericScrollViewNew<SuccessDescriptionItem, SingleText> EffectTextLayout;

		// Token: 0x0200C844 RID: 51268
		[NullableContext(0)]
		private class ERoleSuccessEffectNode
		{
			// Token: 0x0403C7F0 RID: 247792
			public const int TextScrollLayout = 0;

			// Token: 0x0403C7F1 RID: 247793
			public const int TextItem = 1;

			// Token: 0x0403C7F2 RID: 247794
			public const int Title = 2;

			// Token: 0x0403C7F3 RID: 247795
			public const int TipsText = 3;

			// Token: 0x0403C7F4 RID: 247796
			public const int TipsButton = 4;

			// Token: 0x0403C7F5 RID: 247797
			public const int TipsButton2 = 5;
		}
	}
}
