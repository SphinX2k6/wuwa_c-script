using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.NpcItem
{
	// Token: 0x02004191 RID: 16785
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NpcItem : GridProxyAbstract<GymChallengeData>
	{
		// Token: 0x0602A86A RID: 174186 RVA: 0x00BFFF2C File Offset: 0x00BFE12C
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

		// Token: 0x0602A86B RID: 174187 RVA: 0x00C00044 File Offset: 0x00BFE244
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x0602A86C RID: 174188 RVA: 0x00C00064 File Offset: 0x00BFE264
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

		// Token: 0x0602A86D RID: 174189 RVA: 0x00C00158 File Offset: 0x00BFE358
		public void SetSelected(bool isSelected)
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			GymChallengeData challengeData = this.ChallengeData;
			bool flag = instance.IsChallengeLock((challengeData != null) ? challengeData.Id : 0);
			EToggleState etoggleState = (!flag && isSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			EToggleState state = flag ? EToggleState.ETT_UnDetermined : etoggleState;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0602A86E RID: 174190 RVA: 0x00C001A6 File Offset: 0x00BFE3A6
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x0602A86F RID: 174191 RVA: 0x00C001AF File Offset: 0x00BFE3AF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x0602A870 RID: 174192 RVA: 0x00C001B8 File Offset: 0x00BFE3B8
		private void OnUndeterminedClicked()
		{
			if (this.CallbackOnClick != null && this.ChallengeData != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.ChallengeData, base.GridIndex, toggleState);
			}
		}

		// Token: 0x0602A871 RID: 174193 RVA: 0x00C001FC File Offset: 0x00BFE3FC
		private void OnClickToggle(EToggleState toggleState)
		{
			if (this.CallbackOnClick != null && this.ChallengeData != null)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.ChallengeData, base.GridIndex, toggleState2);
			}
		}

		// Token: 0x04017153 RID: 94547
		[Nullable(2)]
		public GymChallengeData ChallengeData;

		// Token: 0x04017154 RID: 94548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<GymChallengeData, int, EToggleState> CallbackOnClick;

		// Token: 0x02009D8B RID: 40331
		private static class EComponents
		{
			// Token: 0x04031006 RID: 200710
			public const int ToggleNpc = 0;

			// Token: 0x04031007 RID: 200711
			public const int TextureBgBlue = 1;

			// Token: 0x04031008 RID: 200712
			public const int TextureBgRed = 2;

			// Token: 0x04031009 RID: 200713
			public const int TextureMain = 3;

			// Token: 0x0403100A RID: 200714
			public const int TextName = 4;

			// Token: 0x0403100B RID: 200715
			public const int TextureTitle = 5;

			// Token: 0x0403100C RID: 200716
			public const int TextureMask = 6;

			// Token: 0x0403100D RID: 200717
			public const int PanelLock = 7;

			// Token: 0x0403100E RID: 200718
			public const int PanelLine = 8;

			// Token: 0x0403100F RID: 200719
			public const int PanelFinish = 9;
		}
	}
}
