using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006170 RID: 24944
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeRoleUnlockView : UiViewBase
	{
		// Token: 0x170091BC RID: 37308
		// (get) Token: 0x0603F0E7 RID: 258279 RVA: 0x00F3CC9F File Offset: 0x00F3AE9F
		private RoverlikeRoleUnlockViewParam Param
		{
			get
			{
				return this.OpenParam as RoverlikeRoleUnlockViewParam;
			}
		}

		// Token: 0x0603F0E8 RID: 258280 RVA: 0x00F3CCAC File Offset: 0x00F3AEAC
		[NullableContext(1)]
		public RoverlikeRoleUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F0E9 RID: 258281 RVA: 0x00F3CCB8 File Offset: 0x00F3AEB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F0EA RID: 258282 RVA: 0x00F3CDC1 File Offset: 0x00F3AFC1
		protected override void OnStart()
		{
			RoverlikeRoleUnlockViewParam param = this.Param;
			this.OnClosed = ((param != null) ? param.OnClosed : null);
			RoverlikeRoleUnlockViewParam param2 = this.Param;
			this.RefreshByBlessRole((param2 != null) ? param2.BlessRoleId : 0);
		}

		// Token: 0x0603F0EB RID: 258283 RVA: 0x00F3CDF3 File Offset: 0x00F3AFF3
		protected override void OnBeforeDestroy()
		{
			Action onClosed = this.OnClosed;
			this.OnClosed = null;
			if (onClosed == null)
			{
				return;
			}
			onClosed();
		}

		// Token: 0x0603F0EC RID: 258284 RVA: 0x00F3CE0C File Offset: 0x00F3B00C
		private void RefreshByBlessRole(int blessRoleId)
		{
			RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(blessRoleId);
			if (blessRoleConfig == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(blessRoleConfig.Value.UnlockStand, base.GetTexture(2), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), blessRoleConfig.Value.BlessRoleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), blessRoleConfig.Value.SkillDesc, Array.Empty<object>());
		}

		// Token: 0x0603F0ED RID: 258285 RVA: 0x00F3CE96 File Offset: 0x00F3B096
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020E30 RID: 134704
		private Action OnClosed;

		// Token: 0x0200C3DA RID: 50138
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B194 RID: 242068
			public const int SprClose = 0;

			// Token: 0x0403B195 RID: 242069
			public const int PnlRole = 1;

			// Token: 0x0403B196 RID: 242070
			public const int TexRole = 2;

			// Token: 0x0403B197 RID: 242071
			public const int TxtName1 = 3;

			// Token: 0x0403B198 RID: 242072
			public const int TxtName2 = 4;
		}
	}
}
