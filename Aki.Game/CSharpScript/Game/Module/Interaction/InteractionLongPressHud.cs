using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200585C RID: 22620
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressHud : UiPanelBase
	{
		// Token: 0x06039820 RID: 235552 RVA: 0x00DA73F8 File Offset: 0x00DA55F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039821 RID: 235553 RVA: 0x00DA7461 File Offset: 0x00DA5661
		protected override void OnStart()
		{
			this.ProgressSprite = base.GetSprite(0);
			this.TidContentText = base.GetText(1);
			this.SetActive(false);
		}

		// Token: 0x06039822 RID: 235554 RVA: 0x00DA7484 File Offset: 0x00DA5684
		protected override void OnBeforeDestroy()
		{
			this.UnbindEntity();
			this.ProgressSprite = null;
			this.TidContentText = null;
		}

		// Token: 0x06039823 RID: 235555 RVA: 0x00DA749C File Offset: 0x00DA569C
		public void SetContentTid(string tid)
		{
			if (string.IsNullOrEmpty(tid))
			{
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(tid, null);
			if (localTextNew != null)
			{
				UUIText tidContentText = this.TidContentText;
				if (tidContentText == null)
				{
					return;
				}
				tidContentText.SetText(localTextNew, true);
			}
		}

		// Token: 0x06039824 RID: 235556 RVA: 0x00DA74CF File Offset: 0x00DA56CF
		public void SetStartProgress(float? startProgress)
		{
			this.StartProgress = startProgress;
		}

		// Token: 0x06039825 RID: 235557 RVA: 0x00DA74D8 File Offset: 0x00DA56D8
		public void BindEntity(Entity entity)
		{
			if (this.BoundEntity == entity)
			{
				return;
			}
			this.UnbindEntity();
			if (entity == null || !entity.Valid)
			{
				return;
			}
			this.BoundEntity = entity;
			EventSystem.Instance.AddWithTarget<float>(entity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			UUISprite progressSprite = this.ProgressSprite;
			if (progressSprite != null)
			{
				progressSprite.SetFillAmount(0f);
			}
			this.SetActive(this.StartProgress == null);
		}

		// Token: 0x06039826 RID: 235558 RVA: 0x00DA7558 File Offset: 0x00DA5758
		public void UnbindEntity()
		{
			if (this.BoundEntity != null)
			{
				if (EventSystem.Instance.HasWithTarget(this.BoundEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange)))
				{
					EventSystem.Instance.RemoveWithTarget(this.BoundEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
				}
				this.BoundEntity = null;
			}
			this.SetActive(false);
		}

		// Token: 0x06039827 RID: 235559 RVA: 0x00DA75C0 File Offset: 0x00DA57C0
		private void OnInteractionLongPressProgressChange(float progress)
		{
			if (this.StartProgress != null && progress < this.StartProgress.Value)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			UUISprite progressSprite = this.ProgressSprite;
			if (progressSprite == null)
			{
				return;
			}
			progressSprite.SetFillAmount(progress);
		}

		// Token: 0x0401E10E RID: 123150
		private UUISprite ProgressSprite;

		// Token: 0x0401E10F RID: 123151
		private UUIText TidContentText;

		// Token: 0x0401E110 RID: 123152
		private Entity BoundEntity;

		// Token: 0x0401E111 RID: 123153
		private float? StartProgress;

		// Token: 0x0200BA85 RID: 47749
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038614 RID: 230932
			public const int ProgressSprite = 0;

			// Token: 0x04038615 RID: 230933
			public const int TidContentText = 1;
		}
	}
}
