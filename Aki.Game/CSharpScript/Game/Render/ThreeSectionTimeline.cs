using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045EF RID: 17903
	[NullableContext(1)]
	[Nullable(0)]
	public class ThreeSectionTimeline
	{
		// Token: 0x0602E2C6 RID: 189126 RVA: 0x00AAC6A4 File Offset: 0x00AAA8A4
		public void Setup(double start, double loop, double end, bool enableLoop = true, bool ignoreTimeDilation = false)
		{
			this.Start = start;
			this.Loop = loop;
			this.End = end;
			this.WholeTime = start + loop + end;
			this.EnableLoop = enableLoop;
			this.CurrTime = 0.0;
			this.Ending = false;
			this.Dead = false;
			this.IgnoreTimeDilation = ignoreTimeDilation;
			this.CurrState = new EThreeSectionTimelineSection?(EThreeSectionTimelineSection.Start);
			this.CurrFactor = 0.0;
			double value = 0.001;
			if (MathUtils.Instance.IsNearlyEqual(loop, 0.0, new double?(value)))
			{
				this.LoopAsZero = true;
			}
			else
			{
				this.LoopAsZero = false;
			}
			if (MathUtils.Instance.IsNearlyEqual(end, 0.0, new double?(value)))
			{
				this.EndAsZero = true;
				return;
			}
			this.EndAsZero = false;
		}

		// Token: 0x0602E2C7 RID: 189127 RVA: 0x00AAC77C File Offset: 0x00AAA97C
		public void Update(double delta)
		{
			if (this.Dead)
			{
				return;
			}
			double timeDelta = this.GetTimeDelta(delta);
			this.CurrTime += timeDelta;
			if (this.Ending)
			{
				if (this.CurrTime >= this.WholeTime)
				{
					this.Dead = true;
				}
			}
			else if (this.CurrTime >= this.Start + this.Loop)
			{
				if (this.EnableLoop)
				{
					if (this.LoopAsZero)
					{
						this.CurrTime = this.Start;
					}
					else
					{
						double num = this.CurrTime - this.Start;
						this.CurrTime = this.Start + (num - Math.Floor(num / this.Loop) * this.Loop);
					}
				}
				else
				{
					this.Ending = true;
					if (this.EndAsZero || this.CurrTime >= this.WholeTime)
					{
						this.Dead = true;
					}
				}
			}
			this.UpdateStateAndFactor();
		}

		// Token: 0x0602E2C8 RID: 189128 RVA: 0x00AAC85D File Offset: 0x00AAAA5D
		public void TriggerEnd()
		{
			this.Ending = true;
			this.CurrTime = this.Start + this.Loop;
			if (this.EndAsZero)
			{
				this.Dead = true;
			}
			this.UpdateStateAndFactor();
		}

		// Token: 0x0602E2C9 RID: 189129 RVA: 0x00AAC88E File Offset: 0x00AAAA8E
		public void SetLoop(bool enableLoop)
		{
			this.EnableLoop = enableLoop;
		}

		// Token: 0x0602E2CA RID: 189130 RVA: 0x00AAC897 File Offset: 0x00AAAA97
		public EThreeSectionTimelineSection? GetCurrState()
		{
			return this.CurrState;
		}

		// Token: 0x0602E2CB RID: 189131 RVA: 0x00AAC89F File Offset: 0x00AAAA9F
		public bool IsDead()
		{
			return this.Dead;
		}

		// Token: 0x0602E2CC RID: 189132 RVA: 0x00AAC8A7 File Offset: 0x00AAAAA7
		public double GetCurrFactor()
		{
			return this.CurrFactor;
		}

		// Token: 0x0602E2CD RID: 189133 RVA: 0x00AAC8B0 File Offset: 0x00AAAAB0
		public float GetFloatFromGroup(SMaterialControllerFloatGroup floatGroup)
		{
			EThreeSectionTimelineSection? currState = this.CurrState;
			FKuroCurveFloat fkuroCurveFloat;
			if (currState != null)
			{
				EThreeSectionTimelineSection valueOrDefault = currState.GetValueOrDefault();
				if (valueOrDefault == EThreeSectionTimelineSection.Start)
				{
					fkuroCurveFloat = floatGroup.Start;
					return UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, (float)this.GetCurrFactor());
				}
				if (valueOrDefault == EThreeSectionTimelineSection.Loop)
				{
					fkuroCurveFloat = floatGroup.Loop;
					return UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, (float)this.GetCurrFactor());
				}
			}
			fkuroCurveFloat = floatGroup.End;
			return UKuroCurveLibrary.GetValue_Float(fkuroCurveFloat, (float)this.GetCurrFactor());
		}

		// Token: 0x0602E2CE RID: 189134 RVA: 0x00AAC920 File Offset: 0x00AAAB20
		public FLinearColor GetColorFromGroup(SMaterialControllerColorGroup colorGroup)
		{
			EThreeSectionTimelineSection? currState = this.CurrState;
			FKuroCurveLinearColor fkuroCurveLinearColor;
			if (currState != null)
			{
				EThreeSectionTimelineSection valueOrDefault = currState.GetValueOrDefault();
				if (valueOrDefault == EThreeSectionTimelineSection.Start)
				{
					fkuroCurveLinearColor = colorGroup.Start;
					return UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, (float)this.GetCurrFactor());
				}
				if (valueOrDefault == EThreeSectionTimelineSection.Loop)
				{
					fkuroCurveLinearColor = colorGroup.Loop;
					return UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, (float)this.GetCurrFactor());
				}
			}
			fkuroCurveLinearColor = colorGroup.End;
			return UKuroCurveLibrary.GetValue_LinearColor(fkuroCurveLinearColor, (float)this.GetCurrFactor());
		}

		// Token: 0x0602E2CF RID: 189135 RVA: 0x00AAC990 File Offset: 0x00AAAB90
		private double GetTimeDelta(double delta)
		{
			if (!this.IgnoreTimeDilation && RenderModuleController.Instance.IsGamePaused)
			{
				return 0.0;
			}
			if (this.IgnoreTimeDilation)
			{
				float globalTimeDilation = RenderModuleController.Instance.GlobalTimeDilation;
				if (!MathUtils.Instance.IsNearlyEqual((double)globalTimeDilation, 1.0, null))
				{
					return delta * (double)(1f / globalTimeDilation);
				}
			}
			return delta;
		}

		// Token: 0x0602E2D0 RID: 189136 RVA: 0x00AAC9FC File Offset: 0x00AAABFC
		private void UpdateStateAndFactor()
		{
			if (this.Dead)
			{
				this.CurrState = new EThreeSectionTimelineSection?(EThreeSectionTimelineSection.Dead);
				this.CurrFactor = 1.0;
				return;
			}
			if (this.Ending)
			{
				this.CurrState = new EThreeSectionTimelineSection?(EThreeSectionTimelineSection.End);
				this.CurrFactor = (this.CurrTime - this.Start - this.Loop) / this.End;
				return;
			}
			if (this.CurrTime < this.Start)
			{
				this.CurrState = new EThreeSectionTimelineSection?(EThreeSectionTimelineSection.Start);
				this.CurrFactor = this.CurrTime / this.Start;
				return;
			}
			this.CurrState = new EThreeSectionTimelineSection?(EThreeSectionTimelineSection.Loop);
			if (this.LoopAsZero)
			{
				this.CurrFactor = 1.0;
			}
			this.CurrFactor = (this.CurrTime - this.Start) / this.Loop;
		}

		// Token: 0x04018C6A RID: 101482
		private double Start;

		// Token: 0x04018C6B RID: 101483
		private double Loop;

		// Token: 0x04018C6C RID: 101484
		private double End;

		// Token: 0x04018C6D RID: 101485
		private bool LoopAsZero;

		// Token: 0x04018C6E RID: 101486
		private bool EndAsZero;

		// Token: 0x04018C6F RID: 101487
		private double WholeTime;

		// Token: 0x04018C70 RID: 101488
		private bool EnableLoop;

		// Token: 0x04018C71 RID: 101489
		private double CurrTime;

		// Token: 0x04018C72 RID: 101490
		private bool Ending;

		// Token: 0x04018C73 RID: 101491
		private bool Dead = true;

		// Token: 0x04018C74 RID: 101492
		private bool IgnoreTimeDilation;

		// Token: 0x04018C75 RID: 101493
		private EThreeSectionTimelineSection? CurrState;

		// Token: 0x04018C76 RID: 101494
		private double CurrFactor;
	}
}
