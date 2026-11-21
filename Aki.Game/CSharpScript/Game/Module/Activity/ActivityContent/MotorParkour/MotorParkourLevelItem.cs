using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005370 RID: 21360
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourLevelItem : GridProxyAbstract<MotorParkourLevelData>
	{
		// Token: 0x06035268 RID: 217704 RVA: 0x00ED7CF4 File Offset: 0x00ED5EF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035269 RID: 217705 RVA: 0x00ED7E3F File Offset: 0x00ED603F
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x0603526A RID: 217706 RVA: 0x00ED7E50 File Offset: 0x00ED6050
		public override UniTask RefreshAsync(MotorParkourLevelData data, bool isSelected, int gridIndex)
		{
			MotorParkourLevelItem.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<MotorParkourLevelItem.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603526B RID: 217707 RVA: 0x00ED7E9B File Offset: 0x00ED609B
		private void UpdateUnlock()
		{
			if (this.Data != null && this.Data.IsUnLock)
			{
				this.RefreshAsync(this.Data, false, 0);
			}
		}

		// Token: 0x0603526C RID: 217708 RVA: 0x00ED7EC1 File Offset: 0x00ED60C1
		private void AddTimer()
		{
			this.RemoveTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.UpdateUnlock();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0603526D RID: 217709 RVA: 0x00ED7EF8 File Offset: 0x00ED60F8
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603526E RID: 217710 RVA: 0x00ED7F1C File Offset: 0x00ED611C
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			if (this.Data.HasLevelRedDot)
			{
				this.Data.ReadLevelRedDot();
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.ActivityId);
			}
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.Data.HasLevelRedDot);
		}

		// Token: 0x0603526F RID: 217711 RVA: 0x00ED7F8F File Offset: 0x00ED618F
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06035270 RID: 217712 RVA: 0x00ED7FA7 File Offset: 0x00ED61A7
		private void OnToggleClick(EToggleState _)
		{
			if (!this.Data.IsUnLock)
			{
				this.OnDeselected(false);
			}
			Action<MotorParkourLevelData> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(this.Data);
		}

		// Token: 0x06035271 RID: 217713 RVA: 0x00ED7FD3 File Offset: 0x00ED61D3
		public override object GetKey(MotorParkourLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401C0C7 RID: 114887
		private MotorParkourLevelData Data;

		// Token: 0x0401C0C8 RID: 114888
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401C0C9 RID: 114889
		public Action<MotorParkourLevelData> OnToggleCallback = delegate(MotorParkourLevelData data)
		{
		};

		// Token: 0x0200AFF2 RID: 45042
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036608 RID: 222728
			public const int ToggleRoot = 0;

			// Token: 0x04036609 RID: 222729
			public const int TextureMap = 1;

			// Token: 0x0403660A RID: 222730
			public const int ArtTextNum = 2;

			// Token: 0x0403660B RID: 222731
			public const int ItemFinish = 3;

			// Token: 0x0403660C RID: 222732
			public const int ItemLock = 4;

			// Token: 0x0403660D RID: 222733
			public const int TextureTransitionMap = 5;

			// Token: 0x0403660E RID: 222734
			public const int ItemRedDot = 6;
		}
	}
}
