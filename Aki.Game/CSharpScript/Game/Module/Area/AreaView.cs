using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02005EA4 RID: 24228
	public class AreaView : UiTickViewBase
	{
		// Token: 0x0603DA78 RID: 252536 RVA: 0x00EE3798 File Offset: 0x00EE1998
		[NullableContext(1)]
		public AreaView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603DA79 RID: 252537 RVA: 0x00EE37A4 File Offset: 0x00EE19A4
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

		// Token: 0x0603DA7A RID: 252538 RVA: 0x00EE380D File Offset: 0x00EE1A0D
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
			{
				this.IsCanClose = true;
			}, false);
		}

		// Token: 0x0603DA7B RID: 252539 RVA: 0x00EE382C File Offset: 0x00EE1A2C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdateAreaView, new Action(this.UpdateAreaView));
		}

		// Token: 0x0603DA7C RID: 252540 RVA: 0x00EE384A File Offset: 0x00EE1A4A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdateAreaView, new Action(this.UpdateAreaView));
		}

		// Token: 0x0603DA7D RID: 252541 RVA: 0x00EE3868 File Offset: 0x00EE1A68
		private void SetName()
		{
			if (base.GetText(0) != null && !string.IsNullOrEmpty(AreaModel.Instance.AreaHintName))
			{
				base.GetText(0).SetText(AreaModel.Instance.AreaHintName, true);
			}
		}

		// Token: 0x0603DA7E RID: 252542 RVA: 0x00EE389B File Offset: 0x00EE1A9B
		protected override void OnBeforeShow()
		{
			this.SetName();
		}

		// Token: 0x0603DA7F RID: 252543 RVA: 0x00EE38A3 File Offset: 0x00EE1AA3
		protected override void OnTick(float delta)
		{
			if (this.IsCanClose && base.IsShow)
			{
				this.IsCanClose = false;
				base.CloseMe(null);
			}
		}

		// Token: 0x0603DA80 RID: 252544 RVA: 0x00EE38C3 File Offset: 0x00EE1AC3
		private void UpdateAreaView()
		{
			this.UiViewSequence.ReplaySequence("Start");
			this.SetName();
		}

		// Token: 0x0402029A RID: 131738
		private bool IsCanClose;

		// Token: 0x0200C214 RID: 49684
		private enum EChildCom
		{
			// Token: 0x0403AA49 RID: 240201
			AreaNameText,
			// Token: 0x0403AA4A RID: 240202
			Bg
		}
	}
}
