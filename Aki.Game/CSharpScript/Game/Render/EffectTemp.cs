using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034EC RID: 13548
	public class EffectTemp : IStaticVariableResetter
	{
		// Token: 0x060227CA RID: 141258 RVA: 0x009CA0C5 File Offset: 0x009C82C5
		static EffectTemp()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EffectTemp.CreateStaticDefaultValue), new Action(EffectTemp.ResetStaticDefaultValue));
		}

		// Token: 0x060227CB RID: 141259 RVA: 0x009CA0E4 File Offset: 0x009C82E4
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

		// Token: 0x060227CC RID: 141260 RVA: 0x009CA1A4 File Offset: 0x009C83A4
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

		// Token: 0x060227CD RID: 141261 RVA: 0x009CA248 File Offset: 0x009C8448
		public static void Initialize()
		{
		}

		// Token: 0x060227CE RID: 141262 RVA: 0x009CA24A File Offset: 0x009C844A
		public static void StartStat()
		{
		}

		// Token: 0x060227CF RID: 141263 RVA: 0x009CA24C File Offset: 0x009C844C
		public static void StopStat()
		{
		}

		// Token: 0x040130F7 RID: 78071
		public static double FloatRef;

		// Token: 0x040130F8 RID: 78072
		public static double FloatXRef;

		// Token: 0x040130F9 RID: 78073
		public static double FloatYRef;

		// Token: 0x040130FA RID: 78074
		public static double FloatZRef;

		// Token: 0x040130FB RID: 78075
		public static FVector VectorRef;

		// Token: 0x040130FC RID: 78076
		public static FVector2D Vector2dRef;

		// Token: 0x040130FD RID: 78077
		public static FLinearColor ColorRef;

		// Token: 0x040130FE RID: 78078
		public static FTransform Transform;

		// Token: 0x040130FF RID: 78079
		[Nullable(1)]
		public static Vector TsVector;

		// Token: 0x04013100 RID: 78080
		public static FRotator Rotator;

		// Token: 0x04013101 RID: 78081
		public static double Index;

		// Token: 0x04013102 RID: 78082
		public static double Number;

		// Token: 0x04013103 RID: 78083
		[Nullable(1)]
		public static string Key;
	}
}
