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
	// Token: 0x020055A8 RID: 21928
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechLevelUpSuccessEffectView : UiViewBase
	{
		// Token: 0x060365CD RID: 222669 RVA: 0x00F2DACC File Offset: 0x00F2BCCC
		public FishingTechLevelUpSuccessEffectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060365CE RID: 222670 RVA: 0x00F2DAD8 File Offset: 0x00F2BCD8
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

		// Token: 0x060365CF RID: 222671 RVA: 0x00F2DC25 File Offset: 0x00F2BE25
		protected override void OnBeforeCreate()
		{
			if (this.OpenParam == null)
			{
				return;
			}
			this.Data = (this.OpenParam as LevelUpSuccessEffectData);
			this.SetAudio();
		}

		// Token: 0x060365D0 RID: 222672 RVA: 0x00F2DC48 File Offset: 0x00F2BE48
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			this.EffectTextLayout = new GenericScrollViewNew<SuccessDescriptionItem, SingleText>(base.GetScrollViewWithScrollbar(0), new Func<SuccessDescriptionItem>(this.CreateTextItem), item.GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x060365D1 RID: 222673 RVA: 0x00F2DC88 File Offset: 0x00F2BE88
		protected override void OnBeforeShow()
		{
			this.SetTitle();
			this.SetViewContent();
			this.SetTipsText();
		}

		// Token: 0x060365D2 RID: 222674 RVA: 0x00F2DC9C File Offset: 0x00F2BE9C
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

		// Token: 0x060365D3 RID: 222675 RVA: 0x00F2DCF4 File Offset: 0x00F2BEF4
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

		// Token: 0x060365D4 RID: 222676 RVA: 0x00F2DD24 File Offset: 0x00F2BF24
		private SuccessDescriptionItem CreateTextItem()
		{
			return new SuccessDescriptionItem();
		}

		// Token: 0x060365D5 RID: 222677 RVA: 0x00F2DD2C File Offset: 0x00F2BF2C
		private void SetTipsText()
		{
			LevelUpSuccessEffectData data = this.Data;
			string key = ((data != null) ? data.ClickText : null) ?? "Text_BackToView_Text";
			base.GetText(3).ShowTextNew(key);
		}

		// Token: 0x060365D6 RID: 222678 RVA: 0x00F2DD64 File Offset: 0x00F2BF64
		private void SetTitle()
		{
			LevelUpSuccessEffectData data = this.Data;
			string key = ((data != null) ? data.Title : null) ?? "Text_ActivedSucceed_Text";
			base.GetText(2).ShowTextNew(key);
		}

		// Token: 0x060365D7 RID: 222679 RVA: 0x00F2DD9C File Offset: 0x00F2BF9C
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

		// Token: 0x0401CAFB RID: 117499
		private LevelUpSuccessEffectData Data;

		// Token: 0x0401CAFC RID: 117500
		private GenericScrollViewNew<SuccessDescriptionItem, SingleText> EffectTextLayout;

		// Token: 0x0200B226 RID: 45606
		[NullableContext(0)]
		private class ERoleSuccessEffectNode
		{
			// Token: 0x04037135 RID: 225589
			public const int TextScrollLayout = 0;

			// Token: 0x04037136 RID: 225590
			public const int TextItem = 1;

			// Token: 0x04037137 RID: 225591
			public const int Title = 2;

			// Token: 0x04037138 RID: 225592
			public const int TipsText = 3;

			// Token: 0x04037139 RID: 225593
			public const int TipsButton = 4;

			// Token: 0x0403713A RID: 225594
			public const int TipsButton2 = 5;
		}
	}
}
