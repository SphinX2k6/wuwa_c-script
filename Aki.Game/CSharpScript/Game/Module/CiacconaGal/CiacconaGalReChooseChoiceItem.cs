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
	// Token: 0x02005BDD RID: 23517
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalReChooseChoiceItem : GridProxyAbstract<ICiacconaGalReChooseChoiceParam>
	{
		// Token: 0x0603B730 RID: 243504 RVA: 0x00E2CD9C File Offset: 0x00E2AF9C
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

		// Token: 0x0603B731 RID: 243505 RVA: 0x00E2CE63 File Offset: 0x00E2B063
		protected override void OnBeforeDestroy()
		{
			this.RemoveProtectionTimer();
		}

		// Token: 0x0603B732 RID: 243506 RVA: 0x00E2CE6C File Offset: 0x00E2B06C
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

		// Token: 0x0603B733 RID: 243507 RVA: 0x00E2CED0 File Offset: 0x00E2B0D0
		public override void Clear()
		{
			this.RemoveProtectionTimer();
		}

		// Token: 0x0603B734 RID: 243508 RVA: 0x00E2CED8 File Offset: 0x00E2B0D8
		public void SetInteractive(bool isInteractive)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(isInteractive);
		}

		// Token: 0x0603B735 RID: 243509 RVA: 0x00E2CEEC File Offset: 0x00E2B0EC
		private void AddProtectionTimer()
		{
			this.CanClick = false;
			float interval = CiacconaGalUtils.GetAvgChoiceProtectingTime() * (float)TimeUtil.Instance.InverseMillisecond;
			this.ProtectionTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CanClick = true;
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0603B736 RID: 243510 RVA: 0x00E2CF37 File Offset: 0x00E2B137
		private void RemoveProtectionTimer()
		{
			if (this.ProtectionTimerHandle != null && TimerSystem.Instance.Has(this.ProtectionTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ProtectionTimerHandle);
				this.ProtectionTimerHandle = null;
			}
		}

		// Token: 0x0603B737 RID: 243511 RVA: 0x00E2CF6C File Offset: 0x00E2B16C
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

		// Token: 0x0603B738 RID: 243512 RVA: 0x00E2CFB7 File Offset: 0x00E2B1B7
		private void OnClickInternal(EToggleState toggleState)
		{
			if (this.OnClick != null && this.CanClick)
			{
				this.OnClick();
			}
		}

		// Token: 0x0401EF96 RID: 126870
		private Action OnClick;

		// Token: 0x0401EF97 RID: 126871
		private bool CanClick;

		// Token: 0x0401EF98 RID: 126872
		private TimerHandle ProtectionTimerHandle;

		// Token: 0x0200BDBB RID: 48571
		[NullableContext(0)]
		public class EChoiceItemComponentDefine
		{
			// Token: 0x04039370 RID: 234352
			public const int TogSelf = 0;

			// Token: 0x04039371 RID: 234353
			public const int Text = 1;

			// Token: 0x04039372 RID: 234354
			public const int TextureIconLock = 2;
		}
	}
}
