using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item.ShieldFSM
{
	// Token: 0x020049F1 RID: 18929
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShieldAnimator
	{
		// Token: 0x0602F6ED RID: 194285 RVA: 0x00D3AE98 File Offset: 0x00D39098
		[NullableContext(2)]
		public DangoBrawlShieldAnimator([Nullable(1)] UUIItem sequenceOwner, UUIItem panelShield, UUIText txtShield, int delay)
		{
			this.Player = new LevelSequencePlayer(sequenceOwner);
			this.Player.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
			this.PanelShield = panelShield;
			this.TxtShield = txtShield;
			this.Delay = delay;
		}

		// Token: 0x0602F6EE RID: 194286 RVA: 0x00D3AEE8 File Offset: 0x00D390E8
		public void Init(int shield)
		{
			this.Target = shield;
			this.Current = shield;
			this.State = EShieldAnimState.Idle;
			this.PlayingSeqName = null;
			UUIText txtShield = this.TxtShield;
			if (txtShield != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(shield);
				txtShield.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIItem panelShield = this.PanelShield;
			if (panelShield == null)
			{
				return;
			}
			panelShield.SetUIActive(shield != 0);
		}

		// Token: 0x0602F6EF RID: 194287 RVA: 0x00D3AF54 File Offset: 0x00D39154
		public void SetShield(int shield)
		{
			this.Target = shield;
			UUIText txtShield = this.TxtShield;
			if (txtShield != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(shield);
				txtShield.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			this.Drive();
		}

		// Token: 0x0602F6F0 RID: 194288 RVA: 0x00D3AF98 File Offset: 0x00D39198
		public void Tick()
		{
			this.Drive();
		}

		// Token: 0x0602F6F1 RID: 194289 RVA: 0x00D3AFA0 File Offset: 0x00D391A0
		public void Clear()
		{
			this.Player.Clear();
		}

		// Token: 0x0602F6F2 RID: 194290 RVA: 0x00D3AFB0 File Offset: 0x00D391B0
		private void Drive()
		{
			if (this.Target == this.Current)
			{
				return;
			}
			double now = Time.Instance.Now;
			EShieldAnimState eshieldAnimState = DangoBrawlShieldAnimator.Decide(this.Current, this.Target);
			switch (this.State)
			{
			case EShieldAnimState.Idle:
				this.Play(eshieldAnimState, now);
				return;
			case EShieldAnimState.Start:
				if (eshieldAnimState != EShieldAnimState.Close)
				{
					this.Current = this.Target;
					return;
				}
				if (now - this.AnimStartTime >= (double)this.Delay)
				{
					this.Play(EShieldAnimState.Close, now);
					return;
				}
				break;
			case EShieldAnimState.Up:
			case EShieldAnimState.Down:
				if (eshieldAnimState == this.State)
				{
					this.Current = this.Target;
					return;
				}
				this.Play(eshieldAnimState, now);
				return;
			case EShieldAnimState.Close:
				if (now - this.AnimStartTime >= (double)this.Delay)
				{
					this.Play(eshieldAnimState, now);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0602F6F3 RID: 194291 RVA: 0x00D3B078 File Offset: 0x00D39278
		private void Play(EShieldAnimState next, double now)
		{
			if (this.PlayingSeqName != null)
			{
				this.Player.StopSequenceByKey(this.PlayingSeqName, false, false);
			}
			this.State = next;
			this.Current = ((next == EShieldAnimState.Close) ? 0 : this.Target);
			if (next == EShieldAnimState.Start || next == EShieldAnimState.Close)
			{
				this.AnimStartTime = now;
			}
			if (next == EShieldAnimState.Start)
			{
				UUIItem panelShield = this.PanelShield;
				if (panelShield != null)
				{
					panelShield.SetUIActive(true);
				}
			}
			this.PlayingSeqName = DangoBrawlShieldAnimator.SeqName(next);
			this.Player.PlaySequencePurely(this.PlayingSeqName, false, false, null, null, false);
		}

		// Token: 0x0602F6F4 RID: 194292 RVA: 0x00D3B109 File Offset: 0x00D39309
		private void OnSeqEnd(string sequenceName)
		{
			if (sequenceName != this.PlayingSeqName)
			{
				return;
			}
			this.PlayingSeqName = null;
			if (this.State == EShieldAnimState.Close)
			{
				UUIItem panelShield = this.PanelShield;
				if (panelShield != null)
				{
					panelShield.SetUIActive(false);
				}
			}
			this.State = EShieldAnimState.Idle;
			this.Drive();
		}

		// Token: 0x0602F6F5 RID: 194293 RVA: 0x00D3B149 File Offset: 0x00D39349
		private static EShieldAnimState Decide(int current, int target)
		{
			if (current == 0)
			{
				return EShieldAnimState.Start;
			}
			if (target == 0)
			{
				return EShieldAnimState.Close;
			}
			if (target <= current)
			{
				return EShieldAnimState.Down;
			}
			return EShieldAnimState.Up;
		}

		// Token: 0x0602F6F6 RID: 194294 RVA: 0x00D3B15C File Offset: 0x00D3935C
		private static string SeqName(EShieldAnimState state)
		{
			string result;
			switch (state)
			{
			case EShieldAnimState.Start:
				result = "ShieldStart";
				break;
			case EShieldAnimState.Up:
				result = "ShieldUp";
				break;
			case EShieldAnimState.Down:
				result = "ShieldDown";
				break;
			case EShieldAnimState.Close:
				result = "ShieldClose";
				break;
			default:
				result = "";
				break;
			}
			return result;
		}

		// Token: 0x0401922B RID: 102955
		private const string SeqStart = "ShieldStart";

		// Token: 0x0401922C RID: 102956
		private const string SeqClose = "ShieldClose";

		// Token: 0x0401922D RID: 102957
		private const string SeqUp = "ShieldUp";

		// Token: 0x0401922E RID: 102958
		private const string SeqDown = "ShieldDown";

		// Token: 0x0401922F RID: 102959
		private readonly LevelSequencePlayer Player;

		// Token: 0x04019230 RID: 102960
		[Nullable(2)]
		private readonly UUIItem PanelShield;

		// Token: 0x04019231 RID: 102961
		[Nullable(2)]
		private readonly UUIText TxtShield;

		// Token: 0x04019232 RID: 102962
		private readonly int Delay;

		// Token: 0x04019233 RID: 102963
		private int Current;

		// Token: 0x04019234 RID: 102964
		private int Target;

		// Token: 0x04019235 RID: 102965
		private EShieldAnimState State;

		// Token: 0x04019236 RID: 102966
		private double AnimStartTime;

		// Token: 0x04019237 RID: 102967
		[Nullable(2)]
		private string PlayingSeqName;
	}
}
