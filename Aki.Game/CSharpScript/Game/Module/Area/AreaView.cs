using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02004E89 RID: 20105
	public class AreaView : UiTickViewBase
	{
		// Token: 0x06032A08 RID: 207368 RVA: 0x00E34CE4 File Offset: 0x00E32EE4
		[NullableContext(1)]
		public AreaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032A09 RID: 207369 RVA: 0x00E34CF0 File Offset: 0x00E32EF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032A0A RID: 207370 RVA: 0x00E34D59 File Offset: 0x00E32F59
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				this.IsCanClose = true;
			}, false);
		}

		// Token: 0x06032A0B RID: 207371 RVA: 0x00E34D78 File Offset: 0x00E32F78
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdateAreaView, new Action(this.UpdateAreaView));
		}

		// Token: 0x06032A0C RID: 207372 RVA: 0x00E34D96 File Offset: 0x00E32F96
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdateAreaView, new Action(this.UpdateAreaView));
		}

		// Token: 0x06032A0D RID: 207373 RVA: 0x00E34DB4 File Offset: 0x00E32FB4
		private void SetName()
		{
			if (base.GetText(0) != null && !string.IsNullOrEmpty(AreaModel.Instance.AreaHintName))
			{
				base.GetText(0).SetText(AreaModel.Instance.AreaHintName, true);
			}
		}

		// Token: 0x06032A0E RID: 207374 RVA: 0x00E34DE7 File Offset: 0x00E32FE7
		protected override void OnBeforeShow()
		{
			this.SetName();
		}

		// Token: 0x06032A0F RID: 207375 RVA: 0x00E34DEF File Offset: 0x00E32FEF
		protected override void OnTick(float delta)
		{
			if (this.IsCanClose && base.IsShow)
			{
				this.IsCanClose = false;
				base.CloseMe(null);
			}
		}

		// Token: 0x06032A10 RID: 207376 RVA: 0x00E34E0F File Offset: 0x00E3300F
		private void UpdateAreaView()
		{
			this.UiViewSequence.ReplaySequence("Start");
			this.SetName();
		}

		// Token: 0x0401AD61 RID: 109921
		private bool IsCanClose;

		// Token: 0x0200AC23 RID: 44067
		private enum EChildCom
		{
			// Token: 0x0403543B RID: 218171
			AreaNameText,
			// Token: 0x0403543C RID: 218172
			Bg
		}
	}
}
