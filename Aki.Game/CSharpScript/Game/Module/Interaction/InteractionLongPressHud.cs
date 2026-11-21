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
	// Token: 0x02004834 RID: 18484
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressHud : UiPanelBase
	{
		// Token: 0x0602E73D RID: 190269 RVA: 0x00CF6120 File Offset: 0x00CF4320
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

		// Token: 0x0602E73E RID: 190270 RVA: 0x00CF6189 File Offset: 0x00CF4389
		protected override void OnStart()
		{
			this.ProgressSprite = base.GetSprite(0);
			this.TidContentText = base.GetText(1);
			this.SetActive(false);
		}

		// Token: 0x0602E73F RID: 190271 RVA: 0x00CF61AC File Offset: 0x00CF43AC
		protected override void OnBeforeDestroy()
		{
			this.UnbindEntity();
			this.ProgressSprite = null;
			this.TidContentText = null;
		}

		// Token: 0x0602E740 RID: 190272 RVA: 0x00CF61C4 File Offset: 0x00CF43C4
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

		// Token: 0x0602E741 RID: 190273 RVA: 0x00CF61F7 File Offset: 0x00CF43F7
		public void SetStartProgress(float? startProgress)
		{
			this.StartProgress = startProgress;
		}

		// Token: 0x0602E742 RID: 190274 RVA: 0x00CF6200 File Offset: 0x00CF4400
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

		// Token: 0x0602E743 RID: 190275 RVA: 0x00CF6280 File Offset: 0x00CF4480
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

		// Token: 0x0602E744 RID: 190276 RVA: 0x00CF62E8 File Offset: 0x00CF44E8
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

		// Token: 0x04018BAB RID: 101291
		private UUISprite ProgressSprite;

		// Token: 0x04018BAC RID: 101292
		private UUIText TidContentText;

		// Token: 0x04018BAD RID: 101293
		private Entity BoundEntity;

		// Token: 0x04018BAE RID: 101294
		private float? StartProgress;

		// Token: 0x0200A49C RID: 42140
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403300B RID: 208907
			public const int ProgressSprite = 0;

			// Token: 0x0403300C RID: 208908
			public const int TidContentText = 1;
		}
	}
}
