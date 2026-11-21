using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050CC RID: 20684
	public class RoverlikeRoleBlessingTips : UiViewBase
	{
		// Token: 0x06033C43 RID: 212035 RVA: 0x00E7DA59 File Offset: 0x00E7BC59
		[NullableContext(1)]
		public RoverlikeRoleBlessingTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033C44 RID: 212036 RVA: 0x00E7DA64 File Offset: 0x00E7BC64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033C45 RID: 212037 RVA: 0x00E7DB10 File Offset: 0x00E7BD10
		protected override void OnBeforeShow()
		{
			RoverlikeGainEntry roverlikeGainEntry = this.OpenParam as RoverlikeGainEntry;
			if (roverlikeGainEntry == null)
			{
				return;
			}
			this.RefreshTips(roverlikeGainEntry);
		}

		// Token: 0x06033C46 RID: 212038 RVA: 0x00E7DB34 File Offset: 0x00E7BD34
		protected override void OnFinishShow()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				num = ((currentActivityData != null) ? new int?(currentActivityData.GetParamConfig().Value.BlessRoleInfoShowTime) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (valueOrDefault <= 0)
			{
				base.CloseMe(null);
				return;
			}
			this.ClearCloseTimer();
			this.CloseTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CloseTimer = null;
				base.CloseMe(null);
			}, (float)valueOrDefault, null, null, true, 1f);
		}

		// Token: 0x06033C47 RID: 212039 RVA: 0x00E7DBC4 File Offset: 0x00E7BDC4
		protected override void OnBeforeDestroy()
		{
			this.ClearCloseTimer();
		}

		// Token: 0x06033C48 RID: 212040 RVA: 0x00E7DBCC File Offset: 0x00E7BDCC
		[NullableContext(1)]
		private void RefreshTips(RoverlikeGainEntry entry)
		{
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(entry.ConfigId);
			if (blessConfig == null)
			{
				return;
			}
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(blessConfig.Value.BlessRoleId);
			if (blessRoleConfig != null)
			{
				base.SetTextureShowUntilLoaded(blessRoleConfig.Value.RoleIcon, base.GetTexture(1), null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), blessRoleConfig.Value.BlessRoleName, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), blessConfig.Value.TriggerRoleInfo, Array.Empty<object>());
		}

		// Token: 0x06033C49 RID: 212041 RVA: 0x00E7DC7E File Offset: 0x00E7BE7E
		private void ClearCloseTimer()
		{
			if (this.CloseTimer != null && TimerSystem.Instance.Has(this.CloseTimer))
			{
				TimerSystem.Instance.Remove(this.CloseTimer);
			}
			this.CloseTimer = null;
		}

		// Token: 0x0401B6FA RID: 112378
		[Nullable(2)]
		private TimerHandle CloseTimer;

		// Token: 0x0200AD98 RID: 44440
		private class EComponents
		{
			// Token: 0x04035A39 RID: 219705
			public const int PanelSelf = 0;

			// Token: 0x04035A3A RID: 219706
			public const int TexHeadIcon = 1;

			// Token: 0x04035A3B RID: 219707
			public const int TxtName = 2;

			// Token: 0x04035A3C RID: 219708
			public const int TxtInfo = 3;
		}
	}
}
