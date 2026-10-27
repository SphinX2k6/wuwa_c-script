using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045E0 RID: 17888
	[NullableContext(1)]
	[Nullable(0)]
	public class WaterEffectSubConfig
	{
		// Token: 0x0602E1FB RID: 188923 RVA: 0x00AA5874 File Offset: 0x00AA3A74
		public bool ShouldUseShallowFootSplashes(double depth)
		{
			return this.ShallowMoveEffects.Count > 0 && depth < (double)this.ShallowMoveDepthThreshold;
		}

		// Token: 0x0602E1FC RID: 188924 RVA: 0x00AA5890 File Offset: 0x00AA3A90
		[NullableContext(2)]
		public WaterEffectItem FindShallowMoveEffect(double depth, double speed)
		{
			if (!this.ShouldUseShallowFootSplashes(depth))
			{
				return null;
			}
			return this.FindMoveEffectInGroups(this.ShallowMoveEffects, depth, speed);
		}

		// Token: 0x0602E1FD RID: 188925 RVA: 0x00AA58AB File Offset: 0x00AA3AAB
		[NullableContext(2)]
		public WaterEffectItem FindWadeMoveEffect(double depth, double speed, bool useShallowFootSplashes)
		{
			if (useShallowFootSplashes)
			{
				return null;
			}
			return this.FindMoveEffectInGroups(this.MoveEffects, depth, speed);
		}

		// Token: 0x0602E1FE RID: 188926 RVA: 0x00AA58C0 File Offset: 0x00AA3AC0
		[NullableContext(2)]
		public WaterEffectItem FindMoveEffect(double depth, double speed)
		{
			return this.FindMoveEffectInGroups(this.MoveEffects, depth, speed);
		}

		// Token: 0x0602E1FF RID: 188927 RVA: 0x00AA58D0 File Offset: 0x00AA3AD0
		[return: Nullable(2)]
		private WaterEffectItem FindMoveEffectInGroups(List<WaterEffectGroup> groups, double depth, double speed)
		{
			int num = 0;
			while (num < groups.Count && depth >= groups[num].WaterDepthThreshold)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			return groups[num - 1].FindEffectAtSpeed(speed);
		}

		// Token: 0x0602E200 RID: 188928 RVA: 0x00AA5914 File Offset: 0x00AA3B14
		[NullableContext(2)]
		public WaterEffectItem FindFallEffectAtSpeed(float speed)
		{
			int num = 0;
			while (num < this.FallEffects.Count && (double)speed >= this.FallEffects[num].SpeedThreshold)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			return this.FallEffects[num - 1];
		}

		// Token: 0x0602E201 RID: 188929 RVA: 0x00AA5960 File Offset: 0x00AA3B60
		[NullableContext(2)]
		public WaterEffectItem FindJumpEffectAtSpeed(float speed)
		{
			int num = 0;
			while (num < this.JumpEffects.Count && (double)speed >= this.JumpEffects[num].SpeedThreshold)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			return this.JumpEffects[num - 1];
		}

		// Token: 0x0602E202 RID: 188930 RVA: 0x00AA59AC File Offset: 0x00AA3BAC
		[NullableContext(2)]
		public WaterEffectItem FindFlyEffectAtSpeed(float speed)
		{
			int num = 0;
			while (num < this.FlyEffects.Count && (double)speed >= this.FlyEffects[num].SpeedThreshold)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			return this.FlyEffects[num - 1];
		}

		// Token: 0x0602E203 RID: 188931 RVA: 0x00AA59F8 File Offset: 0x00AA3BF8
		public void Init(SWaterEffectSubConfig configData)
		{
			this.MoveEffects.Clear();
			this.ShallowMoveEffects.Clear();
			this.FallEffects.Clear();
			this.JumpEffects.Clear();
			this.FlyEffects.Clear();
			int num = configData.MoveEffects.Num();
			for (int i = 0; i < num; i++)
			{
				WaterEffectGroup waterEffectGroup = new WaterEffectGroup();
				waterEffectGroup.Init(configData.MoveEffects.Get(i));
				this.MoveEffects.Add(waterEffectGroup);
			}
			int num2 = configData.ShallowMoveEffects.Num();
			for (int j = 0; j < num2; j++)
			{
				WaterEffectGroup waterEffectGroup2 = new WaterEffectGroup();
				waterEffectGroup2.Init(configData.ShallowMoveEffects.Get(j));
				this.ShallowMoveEffects.Add(waterEffectGroup2);
			}
			this.ShallowMoveDepthThreshold = configData.ShallowMoveDepthThreshold;
			this.ShallowFallbackTag = configData.ShallowFallbackTag;
			int num3 = configData.FallEffects.Num();
			for (int k = 0; k < num3; k++)
			{
				WaterEffectItem waterEffectItem = new WaterEffectItem();
				waterEffectItem.Init(configData.FallEffects.Get(k));
				this.FallEffects.Add(waterEffectItem);
			}
			int num4 = configData.JumpEffects.Num();
			for (int l = 0; l < num4; l++)
			{
				WaterEffectItem waterEffectItem2 = new WaterEffectItem();
				waterEffectItem2.Init(configData.JumpEffects.Get(l));
				this.JumpEffects.Add(waterEffectItem2);
			}
			int num5 = configData.FlyEffects.Num();
			for (int m = 0; m < num5; m++)
			{
				WaterEffectItem waterEffectItem3 = new WaterEffectItem();
				waterEffectItem3.Init(configData.FlyEffects.Get(m));
				this.FlyEffects.Add(waterEffectItem3);
			}
			this.FallJumpDepthThreshold = configData.FallJumpDepthThreshold;
			this.TriggerInGrass = configData.TriggerInGrass;
			this.FlyEffectHeightThreshold = configData.FlyEffectTriggerHeight;
		}

		// Token: 0x04018BCB RID: 101323
		public List<WaterEffectGroup> MoveEffects = new List<WaterEffectGroup>();

		// Token: 0x04018BCC RID: 101324
		public List<WaterEffectGroup> ShallowMoveEffects = new List<WaterEffectGroup>();

		// Token: 0x04018BCD RID: 101325
		public float ShallowMoveDepthThreshold;

		// Token: 0x04018BCE RID: 101326
		[Nullable(2)]
		public FGameplayTagContainer ShallowFallbackTag;

		// Token: 0x04018BCF RID: 101327
		public List<WaterEffectItem> FallEffects = new List<WaterEffectItem>();

		// Token: 0x04018BD0 RID: 101328
		public List<WaterEffectItem> JumpEffects = new List<WaterEffectItem>();

		// Token: 0x04018BD1 RID: 101329
		public List<WaterEffectItem> FlyEffects = new List<WaterEffectItem>();

		// Token: 0x04018BD2 RID: 101330
		public float FallJumpDepthThreshold;

		// Token: 0x04018BD3 RID: 101331
		public bool TriggerInGrass;

		// Token: 0x04018BD4 RID: 101332
		public float FlyEffectHeightThreshold;
	}
}
