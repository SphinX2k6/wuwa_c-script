using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003518 RID: 13592
	[NullableContext(1)]
	[Nullable(0)]
	public class ThreeSectionTimeline
	{
		// Token: 0x060229BB RID: 141755 RVA: 0x009D8E40 File Offset: 0x009D7040
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

		// Token: 0x060229BC RID: 141756 RVA: 0x009D8F18 File Offset: 0x009D7118
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

		// Token: 0x060229BD RID: 141757 RVA: 0x009D8FF9 File Offset: 0x009D71F9
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

		// Token: 0x060229BE RID: 141758 RVA: 0x009D902A File Offset: 0x009D722A
		public void SetLoop(bool enableLoop)
		{
			this.EnableLoop = enableLoop;
		}

		// Token: 0x060229BF RID: 141759 RVA: 0x009D9033 File Offset: 0x009D7233
		public EThreeSectionTimelineSection? GetCurrState()
		{
			return this.CurrState;
		}

		// Token: 0x060229C0 RID: 141760 RVA: 0x009D903B File Offset: 0x009D723B
		public bool IsDead()
		{
			return this.Dead;
		}

		// Token: 0x060229C1 RID: 141761 RVA: 0x009D9043 File Offset: 0x009D7243
		public double GetCurrFactor()
		{
			return this.CurrFactor;
		}

		// Token: 0x060229C2 RID: 141762 RVA: 0x009D904C File Offset: 0x009D724C
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

		// Token: 0x060229C3 RID: 141763 RVA: 0x009D90BC File Offset: 0x009D72BC
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

		// Token: 0x060229C4 RID: 141764 RVA: 0x009D912C File Offset: 0x009D732C
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

		// Token: 0x060229C5 RID: 141765 RVA: 0x009D9198 File Offset: 0x009D7398
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

		// Token: 0x040132A9 RID: 78505
		private double Start;

		// Token: 0x040132AA RID: 78506
		private double Loop;

		// Token: 0x040132AB RID: 78507
		private double End;

		// Token: 0x040132AC RID: 78508
		private bool LoopAsZero;

		// Token: 0x040132AD RID: 78509
		private bool EndAsZero;

		// Token: 0x040132AE RID: 78510
		private double WholeTime;

		// Token: 0x040132AF RID: 78511
		private bool EnableLoop;

		// Token: 0x040132B0 RID: 78512
		private double CurrTime;

		// Token: 0x040132B1 RID: 78513
		private bool Ending;

		// Token: 0x040132B2 RID: 78514
		private bool Dead = true;

		// Token: 0x040132B3 RID: 78515
		private bool IgnoreTimeDilation;

		// Token: 0x040132B4 RID: 78516
		private EThreeSectionTimelineSection? CurrState;

		// Token: 0x040132B5 RID: 78517
		private double CurrFactor;
	}
}
