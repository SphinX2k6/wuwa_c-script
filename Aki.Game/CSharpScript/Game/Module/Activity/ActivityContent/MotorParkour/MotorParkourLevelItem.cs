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
	// Token: 0x020063F2 RID: 25586
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourLevelItem : GridProxyAbstract<MotorParkourLevelData>
	{
		// Token: 0x060405A7 RID: 263591 RVA: 0x00F90D0C File Offset: 0x00F8EF0C
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

		// Token: 0x060405A8 RID: 263592 RVA: 0x00F90E57 File Offset: 0x00F8F057
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x060405A9 RID: 263593 RVA: 0x00F90E68 File Offset: 0x00F8F068
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

		// Token: 0x060405AA RID: 263594 RVA: 0x00F90EB3 File Offset: 0x00F8F0B3
		private void UpdateUnlock()
		{
			if (this.Data != null && this.Data.IsUnLock)
			{
				this.RefreshAsync(this.Data, false, 0);
			}
		}

		// Token: 0x060405AB RID: 263595 RVA: 0x00F90ED9 File Offset: 0x00F8F0D9
		private void AddTimer()
		{
			this.RemoveTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.UpdateUnlock();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x060405AC RID: 263596 RVA: 0x00F90F10 File Offset: 0x00F8F110
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x060405AD RID: 263597 RVA: 0x00F90F34 File Offset: 0x00F8F134
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

		// Token: 0x060405AE RID: 263598 RVA: 0x00F90FA7 File Offset: 0x00F8F1A7
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060405AF RID: 263599 RVA: 0x00F90FBF File Offset: 0x00F8F1BF
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

		// Token: 0x060405B0 RID: 263600 RVA: 0x00F90FEB File Offset: 0x00F8F1EB
		public override object GetKey(MotorParkourLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x04021798 RID: 137112
		private MotorParkourLevelData Data;

		// Token: 0x04021799 RID: 137113
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0402179A RID: 137114
		public Action<MotorParkourLevelData> OnToggleCallback = delegate(MotorParkourLevelData data)
		{
		};

		// Token: 0x0200C60B RID: 50699
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCA9 RID: 244905
			public const int ToggleRoot = 0;

			// Token: 0x0403BCAA RID: 244906
			public const int TextureMap = 1;

			// Token: 0x0403BCAB RID: 244907
			public const int ArtTextNum = 2;

			// Token: 0x0403BCAC RID: 244908
			public const int ItemFinish = 3;

			// Token: 0x0403BCAD RID: 244909
			public const int ItemLock = 4;

			// Token: 0x0403BCAE RID: 244910
			public const int TextureTransitionMap = 5;

			// Token: 0x0403BCAF RID: 244911
			public const int ItemRedDot = 6;
		}
	}
}
