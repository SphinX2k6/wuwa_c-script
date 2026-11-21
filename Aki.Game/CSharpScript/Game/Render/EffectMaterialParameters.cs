using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034F0 RID: 13552
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectMaterialParameters : EffectParametersBase
	{
		// Token: 0x060227D6 RID: 141270 RVA: 0x009CA373 File Offset: 0x009C8573
		public EffectMaterialParameters([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<FName, FKuroCurveFloat> floats = null, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<FName, FKuroCurveLinearColor> colors = null)
		{
			if (floats != null)
			{
				this.FloatCurveMap = floats;
			}
			if (colors != null)
			{
				this.LinearColorCurveMap = colors;
			}
			if (floats != null || colors != null)
			{
				this.HasCurveParameters = true;
			}
		}

		// Token: 0x060227D7 RID: 141271 RVA: 0x009CA39C File Offset: 0x009C859C
		public override void CollectFloatCurve(FName name, FKuroCurveFloat value)
		{
			base.CollectFloatCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227D8 RID: 141272 RVA: 0x009CA3AD File Offset: 0x009C85AD
		public override void CollectVectorCurve(FName name, FKuroCurveVector value)
		{
			base.CollectVectorCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227D9 RID: 141273 RVA: 0x009CA3BE File Offset: 0x009C85BE
		public override void CollectLinearColorCurve(FName name, FKuroCurveLinearColor value)
		{
			base.CollectLinearColorCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DA RID: 141274 RVA: 0x009CA3CF File Offset: 0x009C85CF
		public override void CollectFloatConst(FName name, float value)
		{
			base.CollectFloatConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DB RID: 141275 RVA: 0x009CA3E0 File Offset: 0x009C85E0
		public override void CollectVectorConst(FName name, FVector value)
		{
			base.CollectVectorConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DC RID: 141276 RVA: 0x009CA3F1 File Offset: 0x009C85F1
		public override void CollectLinearColorConst(FName name, FLinearColor value)
		{
			base.CollectLinearColorConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DD RID: 141277 RVA: 0x009CA402 File Offset: 0x009C8602
		public override void RemoveFloatCurveOrConst(FName name)
		{
			base.RemoveFloatCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DE RID: 141278 RVA: 0x009CA412 File Offset: 0x009C8612
		public override void RemoveLinearColorCurveOrConst(FName name)
		{
			base.RemoveLinearColorCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227DF RID: 141279 RVA: 0x009CA422 File Offset: 0x009C8622
		public override void RemoveVectorCurveOrConst(FName name)
		{
			base.RemoveVectorCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x060227E0 RID: 141280 RVA: 0x009CA432 File Offset: 0x009C8632
		[NullableContext(2)]
		public void Tick(UObject target, float time)
		{
			this.Apply(target, time, this.IsMaterialParameterDirty);
			this.IsMaterialParameterDirty = false;
		}

		// Token: 0x04013108 RID: 78088
		private bool IsMaterialParameterDirty;
	}
}
