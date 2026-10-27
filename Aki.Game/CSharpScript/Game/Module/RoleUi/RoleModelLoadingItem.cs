using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CDA RID: 19674
	public class RoleModelLoadingItem : UiPanelBase
	{
		// Token: 0x06032C96 RID: 208022 RVA: 0x00BD5728 File Offset: 0x00BD3928
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

		// Token: 0x06032C97 RID: 208023 RVA: 0x00BD5770 File Offset: 0x00BD3970
		protected override void OnStart()
		{
			this.RefreshLoadingActive();
		}

		// Token: 0x06032C98 RID: 208024 RVA: 0x00BD5778 File Offset: 0x00BD3978
		protected override void OnBeforeDestroy()
		{
			this.ClearTimerHandle();
		}

		// Token: 0x06032C99 RID: 208025 RVA: 0x00BD5780 File Offset: 0x00BD3980
		private void ClearTimerHandle()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06032C9A RID: 208026 RVA: 0x00BD57A2 File Offset: 0x00BD39A2
		private void RefreshLoadingActive()
		{
			this.SetActive(this.CacheActiveState && this.IsOpen);
		}

		// Token: 0x06032C9B RID: 208027 RVA: 0x00BD57BB File Offset: 0x00BD39BB
		public void SetLoadingOpen(bool value)
		{
			this.IsOpen = value;
		}

		// Token: 0x06032C9C RID: 208028 RVA: 0x00BD57C4 File Offset: 0x00BD39C4
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

		// Token: 0x06032C9D RID: 208029 RVA: 0x00BD581B File Offset: 0x00BD3A1B
		public void SetIconPosition(FVector2D position)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffset(position);
		}

		// Token: 0x0401B0A1 RID: 110753
		private bool CacheActiveState = true;

		// Token: 0x0401B0A2 RID: 110754
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401B0A3 RID: 110755
		private bool IsOpen = true;

		// Token: 0x0200AE52 RID: 44626
		private class EComponent
		{
			// Token: 0x04034EDF RID: 216799
			public const int IconItem = 0;
		}
	}
}
