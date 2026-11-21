using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBD RID: 19389
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalReChooseChoiceItem : GridProxyAbstract<ICiacconaGalReChooseChoiceParam>
	{
		// Token: 0x0603067B RID: 198267 RVA: 0x00D7D0A4 File Offset: 0x00D7B2A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggleTextureTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603067C RID: 198268 RVA: 0x00D7D16B File Offset: 0x00D7B36B
		protected override void OnBeforeDestroy()
		{
			this.RemoveProtectionTimer();
		}

		// Token: 0x0603067D RID: 198269 RVA: 0x00D7D174 File Offset: 0x00D7B374
		public override void Refresh(ICiacconaGalReChooseChoiceParam data, bool isSelected, int gridIndex)
		{
			this.AddProtectionTimer();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Text, Array.Empty<object>());
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(data.TogState, false, false, false);
			}
			this.OnClick = data.OnClick;
			this.UpdateIcon(data.IconResId);
		}

		// Token: 0x0603067E RID: 198270 RVA: 0x00D7D1D8 File Offset: 0x00D7B3D8
		public override void Clear()
		{
			this.RemoveProtectionTimer();
		}

		// Token: 0x0603067F RID: 198271 RVA: 0x00D7D1E0 File Offset: 0x00D7B3E0
		public void SetInteractive(bool isInteractive)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(isInteractive);
		}

		// Token: 0x06030680 RID: 198272 RVA: 0x00D7D1F4 File Offset: 0x00D7B3F4
		private void AddProtectionTimer()
		{
			this.CanClick = false;
			float interval = CiacconaGalUtils.GetAvgChoiceProtectingTime() * (float)TimeUtil.Instance.InverseMillisecond;
			this.ProtectionTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CanClick = true;
			}, interval, null, null, true, 1f);
		}

		// Token: 0x06030681 RID: 198273 RVA: 0x00D7D23F File Offset: 0x00D7B43F
		private void RemoveProtectionTimer()
		{
			if (this.ProtectionTimerHandle != null && TimerSystem.Instance.Has(this.ProtectionTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ProtectionTimerHandle);
				this.ProtectionTimerHandle = null;
			}
		}

		// Token: 0x06030682 RID: 198274 RVA: 0x00D7D274 File Offset: 0x00D7B474
		private UniTask UpdateIcon(string resourceName)
		{
			CiacconaGalReChooseChoiceItem.<UpdateIcon>d__11 <UpdateIcon>d__;
			<UpdateIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateIcon>d__.<>4__this = this;
			<UpdateIcon>d__.resourceName = resourceName;
			<UpdateIcon>d__.<>1__state = -1;
			<UpdateIcon>d__.<>t__builder.Start<CiacconaGalReChooseChoiceItem.<UpdateIcon>d__11>(ref <UpdateIcon>d__);
			return <UpdateIcon>d__.<>t__builder.Task;
		}

		// Token: 0x06030683 RID: 198275 RVA: 0x00D7D2BF File Offset: 0x00D7B4BF
		private void OnClickInternal(EToggleState toggleState)
		{
			if (this.OnClick != null && this.CanClick)
			{
				this.OnClick();
			}
		}

		// Token: 0x04019A47 RID: 105031
		private Action OnClick;

		// Token: 0x04019A48 RID: 105032
		private bool CanClick;

		// Token: 0x04019A49 RID: 105033
		private TimerHandle ProtectionTimerHandle;

		// Token: 0x0200A7C4 RID: 42948
		[NullableContext(0)]
		public class EChoiceItemComponentDefine
		{
			// Token: 0x04033D35 RID: 212277
			public const int TogSelf = 0;

			// Token: 0x04033D36 RID: 212278
			public const int Text = 1;

			// Token: 0x04033D37 RID: 212279
			public const int TextureIconLock = 2;
		}
	}
}
