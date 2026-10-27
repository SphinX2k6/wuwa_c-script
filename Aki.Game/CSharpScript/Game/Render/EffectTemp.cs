using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045C4 RID: 17860
	public class EffectTemp : IStaticVariableResetter
	{
		// Token: 0x0602E0DF RID: 188639 RVA: 0x00A9DDFD File Offset: 0x00A9BFFD
		static EffectTemp()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectTemp.CreateStaticDefaultValue), new Action(EffectTemp.ResetStaticDefaultValue));
		}

		// Token: 0x0602E0E0 RID: 188640 RVA: 0x00A9DE1C File Offset: 0x00A9C01C
		public static void CreateStaticDefaultValue()
		{
			EffectTemp.FloatRef = 0.0;
			EffectTemp.FloatXRef = 0.0;
			EffectTemp.FloatYRef = 0.0;
			EffectTemp.FloatZRef = 0.0;
			EffectTemp.VectorRef = new FVector();
			EffectTemp.Vector2dRef = new FVector2D();
			EffectTemp.ColorRef = new FLinearColor();
			EffectTemp.Transform = new FTransform();
			EffectTemp.TsVector = Vector.Create(0.0, 0.0, 0.0);
			EffectTemp.Rotator = new FRotator();
			EffectTemp.Index = 0.0;
			EffectTemp.Number = 0.0;
			EffectTemp.Key = null;
		}

		// Token: 0x0602E0E1 RID: 188641 RVA: 0x00A9DEDC File Offset: 0x00A9C0DC
		public static void ResetStaticDefaultValue()
		{
			EffectTemp.FloatRef = 0.0;
			EffectTemp.FloatXRef = 0.0;
			EffectTemp.FloatYRef = 0.0;
			EffectTemp.FloatZRef = 0.0;
			EffectTemp.VectorRef = default(FVector);
			EffectTemp.Vector2dRef = default(FVector2D);
			EffectTemp.ColorRef = default(FLinearColor);
			EffectTemp.Transform = default(FTransform);
			EffectTemp.TsVector = null;
			EffectTemp.Rotator = default(FRotator);
			EffectTemp.Index = 0.0;
			EffectTemp.Number = 0.0;
			EffectTemp.Key = null;
		}

		// Token: 0x0602E0E2 RID: 188642 RVA: 0x00A9DF80 File Offset: 0x00A9C180
		public static void Initialize()
		{
		}

		// Token: 0x0602E0E3 RID: 188643 RVA: 0x00A9DF82 File Offset: 0x00A9C182
		public static void StartStat()
		{
		}

		// Token: 0x0602E0E4 RID: 188644 RVA: 0x00A9DF84 File Offset: 0x00A9C184
		public static void StopStat()
		{
		}

		// Token: 0x04018ABC RID: 101052
		public static double FloatRef;

		// Token: 0x04018ABD RID: 101053
		public static double FloatXRef;

		// Token: 0x04018ABE RID: 101054
		public static double FloatYRef;

		// Token: 0x04018ABF RID: 101055
		public static double FloatZRef;

		// Token: 0x04018AC0 RID: 101056
		public static FVector VectorRef;

		// Token: 0x04018AC1 RID: 101057
		public static FVector2D Vector2dRef;

		// Token: 0x04018AC2 RID: 101058
		public static FLinearColor ColorRef;

		// Token: 0x04018AC3 RID: 101059
		public static FTransform Transform;

		// Token: 0x04018AC4 RID: 101060
		[Nullable(1)]
		public static Vector TsVector;

		// Token: 0x04018AC5 RID: 101061
		public static FRotator Rotator;

		// Token: 0x04018AC6 RID: 101062
		public static double Index;

		// Token: 0x04018AC7 RID: 101063
		public static double Number;

		// Token: 0x04018AC8 RID: 101064
		[Nullable(1)]
		public static string Key;
	}
}
