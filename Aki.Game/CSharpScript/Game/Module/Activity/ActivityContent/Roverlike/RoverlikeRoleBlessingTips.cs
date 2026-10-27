using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200614E RID: 24910
	public class RoverlikeRoleBlessingTips : UiViewBase
	{
		// Token: 0x0603EF83 RID: 257923 RVA: 0x00F36B85 File Offset: 0x00F34D85
		[NullableContext(1)]
		public RoverlikeRoleBlessingTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF84 RID: 257924 RVA: 0x00F36B90 File Offset: 0x00F34D90
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

		// Token: 0x0603EF85 RID: 257925 RVA: 0x00F36C3C File Offset: 0x00F34E3C
		protected override void OnBeforeShow()
		{
			RoverlikeGainEntry roverlikeGainEntry = this.OpenParam as RoverlikeGainEntry;
			if (roverlikeGainEntry == null)
			{
				return;
			}
			this.RefreshTips(roverlikeGainEntry);
		}

		// Token: 0x0603EF86 RID: 257926 RVA: 0x00F36C60 File Offset: 0x00F34E60
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

		// Token: 0x0603EF87 RID: 257927 RVA: 0x00F36CF0 File Offset: 0x00F34EF0
		protected override void OnBeforeDestroy()
		{
			this.ClearCloseTimer();
		}

		// Token: 0x0603EF88 RID: 257928 RVA: 0x00F36CF8 File Offset: 0x00F34EF8
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

		// Token: 0x0603EF89 RID: 257929 RVA: 0x00F36DAA File Offset: 0x00F34FAA
		private void ClearCloseTimer()
		{
			if (this.CloseTimer != null && TimerSystem.Instance.Has(this.CloseTimer))
			{
				TimerSystem.Instance.Remove(this.CloseTimer);
			}
			this.CloseTimer = null;
		}

		// Token: 0x04020DCD RID: 134605
		[Nullable(2)]
		private TimerHandle CloseTimer;

		// Token: 0x0200C3B1 RID: 50097
		private class EComponents
		{
			// Token: 0x0403B0D8 RID: 241880
			public const int PanelSelf = 0;

			// Token: 0x0403B0D9 RID: 241881
			public const int TexHeadIcon = 1;

			// Token: 0x0403B0DA RID: 241882
			public const int TxtName = 2;

			// Token: 0x0403B0DB RID: 241883
			public const int TxtInfo = 3;
		}
	}
}
