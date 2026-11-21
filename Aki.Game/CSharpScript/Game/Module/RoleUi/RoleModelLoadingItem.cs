using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C8B RID: 15499
	public class RoleModelLoadingItem : UiPanelBase
	{
		// Token: 0x06027A4A RID: 162378 RVA: 0x00B1A4C0 File Offset: 0x00B186C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027A4B RID: 162379 RVA: 0x00B1A508 File Offset: 0x00B18708
		protected override void OnStart()
		{
			this.RefreshLoadingActive();
		}

		// Token: 0x06027A4C RID: 162380 RVA: 0x00B1A510 File Offset: 0x00B18710
		protected override void OnBeforeDestroy()
		{
			this.ClearTimerHandle();
		}

		// Token: 0x06027A4D RID: 162381 RVA: 0x00B1A518 File Offset: 0x00B18718
		private void ClearTimerHandle()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06027A4E RID: 162382 RVA: 0x00B1A53A File Offset: 0x00B1873A
		private void RefreshLoadingActive()
		{
			this.SetActive(this.CacheActiveState && this.IsOpen);
		}

		// Token: 0x06027A4F RID: 162383 RVA: 0x00B1A553 File Offset: 0x00B18753
		public void SetLoadingOpen(bool value)
		{
			this.IsOpen = value;
		}

		// Token: 0x06027A50 RID: 162384 RVA: 0x00B1A55C File Offset: 0x00B1875C
		public void SetLoadingActive(bool value)
		{
			if (this.CacheActiveState == value)
			{
				return;
			}
			this.CacheActiveState = value;
			if (value)
			{
				this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.ClearTimerHandle();
					this.RefreshLoadingActive();
				}, 300f, null, null, true, 1f);
				return;
			}
			this.ClearTimerHandle();
			this.RefreshLoadingActive();
		}

		// Token: 0x06027A51 RID: 162385 RVA: 0x00B1A5B3 File Offset: 0x00B187B3
		public void SetIconPosition(FVector2D position)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffset(position);
		}

		// Token: 0x04015A02 RID: 88578
		private bool CacheActiveState = true;

		// Token: 0x04015A03 RID: 88579
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x04015A04 RID: 88580
		private bool IsOpen = true;

		// Token: 0x02009870 RID: 39024
		private class EComponent
		{
			// Token: 0x0402F884 RID: 194692
			public const int IconItem = 0;
		}
	}
}
