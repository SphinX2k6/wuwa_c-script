using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C8 RID: 17864
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectMaterialParameters : EffectParametersBase
	{
		// Token: 0x0602E0EB RID: 188651 RVA: 0x00A9E0AB File Offset: 0x00A9C2AB
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

		// Token: 0x0602E0EC RID: 188652 RVA: 0x00A9E0D4 File Offset: 0x00A9C2D4
		public override void CollectFloatCurve(FName name, FKuroCurveFloat value)
		{
			base.CollectFloatCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0ED RID: 188653 RVA: 0x00A9E0E5 File Offset: 0x00A9C2E5
		public override void CollectVectorCurve(FName name, FKuroCurveVector value)
		{
			base.CollectVectorCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0EE RID: 188654 RVA: 0x00A9E0F6 File Offset: 0x00A9C2F6
		public override void CollectLinearColorCurve(FName name, FKuroCurveLinearColor value)
		{
			base.CollectLinearColorCurve(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0EF RID: 188655 RVA: 0x00A9E107 File Offset: 0x00A9C307
		public override void CollectFloatConst(FName name, float value)
		{
			base.CollectFloatConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F0 RID: 188656 RVA: 0x00A9E118 File Offset: 0x00A9C318
		public override void CollectVectorConst(FName name, FVector value)
		{
			base.CollectVectorConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F1 RID: 188657 RVA: 0x00A9E129 File Offset: 0x00A9C329
		public override void CollectLinearColorConst(FName name, FLinearColor value)
		{
			base.CollectLinearColorConst(name, value);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F2 RID: 188658 RVA: 0x00A9E13A File Offset: 0x00A9C33A
		public override void RemoveFloatCurveOrConst(FName name)
		{
			base.RemoveFloatCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F3 RID: 188659 RVA: 0x00A9E14A File Offset: 0x00A9C34A
		public override void RemoveLinearColorCurveOrConst(FName name)
		{
			base.RemoveLinearColorCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F4 RID: 188660 RVA: 0x00A9E15A File Offset: 0x00A9C35A
		public override void RemoveVectorCurveOrConst(FName name)
		{
			base.RemoveVectorCurveOrConst(name);
			this.IsMaterialParameterDirty = true;
		}

		// Token: 0x0602E0F5 RID: 188661 RVA: 0x00A9E16A File Offset: 0x00A9C36A
		[NullableContext(2)]
		public void Tick(UObject target, float time)
		{
			this.Apply(target, time, this.IsMaterialParameterDirty);
			this.IsMaterialParameterDirty = false;
		}

		// Token: 0x04018ACD RID: 101069
		private bool IsMaterialParameterDirty;
	}
}
