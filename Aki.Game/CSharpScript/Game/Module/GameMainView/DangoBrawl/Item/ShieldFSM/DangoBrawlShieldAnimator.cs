using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item.ShieldFSM
{
	// Token: 0x02005A15 RID: 23061
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShieldAnimator
	{
		// Token: 0x0603A7A4 RID: 239524 RVA: 0x00DEA900 File Offset: 0x00DE8B00
		[NullableContext(2)]
		public DangoBrawlShieldAnimator([Nullable(1)] UUIItem sequenceOwner, UUIItem panelShield, UUIText txtShield, int delay)
		{
			this.Player = new LevelSequencePlayer(sequenceOwner);
			this.Player.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
			this.PanelShield = panelShield;
			this.TxtShield = txtShield;
			this.Delay = delay;
		}

		// Token: 0x0603A7A5 RID: 239525 RVA: 0x00DEA950 File Offset: 0x00DE8B50
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

		// Token: 0x0603A7A6 RID: 239526 RVA: 0x00DEA9BC File Offset: 0x00DE8BBC
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

		// Token: 0x0603A7A7 RID: 239527 RVA: 0x00DEAA00 File Offset: 0x00DE8C00
		public void Tick()
		{
			this.Drive();
		}

		// Token: 0x0603A7A8 RID: 239528 RVA: 0x00DEAA08 File Offset: 0x00DE8C08
		public void Clear()
		{
			this.Player.Clear();
		}

		// Token: 0x0603A7A9 RID: 239529 RVA: 0x00DEAA18 File Offset: 0x00DE8C18
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

		// Token: 0x0603A7AA RID: 239530 RVA: 0x00DEAAE0 File Offset: 0x00DE8CE0
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

		// Token: 0x0603A7AB RID: 239531 RVA: 0x00DEAB71 File Offset: 0x00DE8D71
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

		// Token: 0x0603A7AC RID: 239532 RVA: 0x00DEABB1 File Offset: 0x00DE8DB1
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

		// Token: 0x0603A7AD RID: 239533 RVA: 0x00DEABC4 File Offset: 0x00DE8DC4
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

		// Token: 0x0401E784 RID: 124804
		private const string SeqStart = "ShieldStart";

		// Token: 0x0401E785 RID: 124805
		private const string SeqClose = "ShieldClose";

		// Token: 0x0401E786 RID: 124806
		private const string SeqUp = "ShieldUp";

		// Token: 0x0401E787 RID: 124807
		private const string SeqDown = "ShieldDown";

		// Token: 0x0401E788 RID: 124808
		private readonly LevelSequencePlayer Player;

		// Token: 0x0401E789 RID: 124809
		[Nullable(2)]
		private readonly UUIItem PanelShield;

		// Token: 0x0401E78A RID: 124810
		[Nullable(2)]
		private readonly UUIText TxtShield;

		// Token: 0x0401E78B RID: 124811
		private readonly int Delay;

		// Token: 0x0401E78C RID: 124812
		private int Current;

		// Token: 0x0401E78D RID: 124813
		private int Target;

		// Token: 0x0401E78E RID: 124814
		private EShieldAnimState State;

		// Token: 0x0401E78F RID: 124815
		private double AnimStartTime;

		// Token: 0x0401E790 RID: 124816
		[Nullable(2)]
		private string PlayingSeqName;
	}
}
