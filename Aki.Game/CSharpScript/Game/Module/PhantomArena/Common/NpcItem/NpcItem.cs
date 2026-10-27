using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.NpcItem
{
	// Token: 0x020051C1 RID: 20929
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NpcItem : GridProxyAbstract<GymChallengeData>
	{
		// Token: 0x0603596F RID: 219503 RVA: 0x00CB28F0 File Offset: 0x00CB0AF0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x06035970 RID: 219504 RVA: 0x00CB2A08 File Offset: 0x00CB0C08
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x06035971 RID: 219505 RVA: 0x00CB2A28 File Offset: 0x00CB0C28
		[NullableContext(1)]
		public override void Refresh(GymChallengeData data, bool isSelected, int gridIndex)
		{
			this.ChallengeData = data;
			EChallengeState challengeStateById = PhantomArenaModel.Instance.GetChallengeStateById(data.Id);
			bool flag = challengeStateById == EChallengeState.Lock;
			bool uiactive = challengeStateById == EChallengeState.Finish;
			PhantomBattleChallenge phantomBattleChallengeConfig = PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(data.Id);
			this.SetSelected(isSelected);
			base.GetTexture(5).SetUIActive(data.IsLast);
			base.GetTexture(2).SetUIActive(data.IsLast);
			base.GetTexture(1).SetUIActive(!data.IsLast);
			base.GetItem(7).SetUIActive(flag && data.IsLast);
			base.GetItem(8).SetUIActive(!data.IsLast);
			base.GetItem(9).SetUIActive(uiactive);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), phantomBattleChallengeConfig.NpcName, Array.Empty<object>());
			base.TrySetTextureByPath(phantomBattleChallengeConfig.NpcIcon, base.GetTexture(3), null, null);
		}

		// Token: 0x06035972 RID: 219506 RVA: 0x00CB2B1C File Offset: 0x00CB0D1C
		public void SetSelected(bool isSelected)
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			GymChallengeData challengeData = this.ChallengeData;
			bool flag = instance.IsChallengeLock((challengeData != null) ? challengeData.Id : 0);
			EToggleState etoggleState = (!flag && isSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			EToggleState state = flag ? EToggleState.ETT_UnDetermined : etoggleState;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x06035973 RID: 219507 RVA: 0x00CB2B6A File Offset: 0x00CB0D6A
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x06035974 RID: 219508 RVA: 0x00CB2B73 File Offset: 0x00CB0D73
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x06035975 RID: 219509 RVA: 0x00CB2B7C File Offset: 0x00CB0D7C
		private void OnUndeterminedClicked()
		{
			if (this.CallbackOnClick != null && this.ChallengeData != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.ChallengeData, base.GridIndex, toggleState);
			}
		}

		// Token: 0x06035976 RID: 219510 RVA: 0x00CB2BC0 File Offset: 0x00CB0DC0
		private void OnClickToggle(EToggleState toggleState)
		{
			if (this.CallbackOnClick != null && this.ChallengeData != null)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.ChallengeData, base.GridIndex, toggleState2);
			}
		}

		// Token: 0x0401C71E RID: 116510
		[Nullable(2)]
		public GymChallengeData ChallengeData;

		// Token: 0x0401C71F RID: 116511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<GymChallengeData, int, EToggleState> CallbackOnClick;

		// Token: 0x0200B353 RID: 45907
		private static class EComponents
		{
			// Token: 0x040365B3 RID: 222643
			public const int ToggleNpc = 0;

			// Token: 0x040365B4 RID: 222644
			public const int TextureBgBlue = 1;

			// Token: 0x040365B5 RID: 222645
			public const int TextureBgRed = 2;

			// Token: 0x040365B6 RID: 222646
			public const int TextureMain = 3;

			// Token: 0x040365B7 RID: 222647
			public const int TextName = 4;

			// Token: 0x040365B8 RID: 222648
			public const int TextureTitle = 5;

			// Token: 0x040365B9 RID: 222649
			public const int TextureMask = 6;

			// Token: 0x040365BA RID: 222650
			public const int PanelLock = 7;

			// Token: 0x040365BB RID: 222651
			public const int PanelLine = 8;

			// Token: 0x040365BC RID: 222652
			public const int PanelFinish = 9;
		}
	}
}
