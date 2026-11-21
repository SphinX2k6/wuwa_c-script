using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050EE RID: 20718
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeRoleUnlockView : UiViewBase
	{
		// Token: 0x1700651E RID: 25886
		// (get) Token: 0x06033DA7 RID: 212391 RVA: 0x00E83B73 File Offset: 0x00E81D73
		private RoverlikeRoleUnlockViewParam Param
		{
			get
			{
				return this.OpenParam as RoverlikeRoleUnlockViewParam;
			}
		}

		// Token: 0x06033DA8 RID: 212392 RVA: 0x00E83B80 File Offset: 0x00E81D80
		[NullableContext(1)]
		public RoverlikeRoleUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033DA9 RID: 212393 RVA: 0x00E83B8C File Offset: 0x00E81D8C
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

		// Token: 0x06033DAA RID: 212394 RVA: 0x00E83C95 File Offset: 0x00E81E95
		protected override void OnStart()
		{
			RoverlikeRoleUnlockViewParam param = this.Param;
			this.OnClosed = ((param != null) ? param.OnClosed : null);
			RoverlikeRoleUnlockViewParam param2 = this.Param;
			this.RefreshByBlessRole((param2 != null) ? param2.BlessRoleId : 0);
		}

		// Token: 0x06033DAB RID: 212395 RVA: 0x00E83CC7 File Offset: 0x00E81EC7
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

		// Token: 0x06033DAC RID: 212396 RVA: 0x00E83CE0 File Offset: 0x00E81EE0
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

		// Token: 0x06033DAD RID: 212397 RVA: 0x00E83D6A File Offset: 0x00E81F6A
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B75D RID: 112477
		private Action OnClosed;

		// Token: 0x0200ADC1 RID: 44481
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035AF5 RID: 219893
			public const int SprClose = 0;

			// Token: 0x04035AF6 RID: 219894
			public const int PnlRole = 1;

			// Token: 0x04035AF7 RID: 219895
			public const int TexRole = 2;

			// Token: 0x04035AF8 RID: 219896
			public const int TxtName1 = 3;

			// Token: 0x04035AF9 RID: 219897
			public const int TxtName2 = 4;
		}
	}
}
