using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.RailSlide
{
	// Token: 0x020031C5 RID: 12741
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SRailSlideControlConfig : IEqualityOperators<SRailSlideControlConfig, SRailSlideControlConfig, bool>, IEquatable<SRailSlideControlConfig>, IUnrealScriptStruct
	{
		// Token: 0x0601F898 RID: 129176 RVA: 0x0092FE8A File Offset: 0x0092E08A
		public SRailSlideControlConfig(float 阻尼, float 最大角速度, float 最大线速度, float 回归强度, float 输入系数)
		{
			this.阻尼 = 阻尼;
			this.最大角速度 = 最大角速度;
			this.最大线速度 = 最大线速度;
			this.回归强度 = 回归强度;
			this.输入系数 = 输入系数;
		}

		// Token: 0x0601F899 RID: 129177 RVA: 0x0092FEB4 File Offset: 0x0092E0B4
		public static bool operator ==(SRailSlideControlConfig left, SRailSlideControlConfig right)
		{
			return left.阻尼 == right.阻尼 && left.最大角速度 == right.最大角速度 && left.最大线速度 == right.最大线速度 && left.回归强度 == right.回归强度 && left.输入系数 == right.输入系数;
		}

		// Token: 0x0601F89A RID: 129178 RVA: 0x0092FF09 File Offset: 0x0092E109
		public static bool operator !=(SRailSlideControlConfig left, SRailSlideControlConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601F89B RID: 129179 RVA: 0x0092FF15 File Offset: 0x0092E115
		public bool Equals(SRailSlideControlConfig other)
		{
			return this == other;
		}

		// Token: 0x0601F89C RID: 129180 RVA: 0x0092FF24 File Offset: 0x0092E124
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SRailSlideControlConfig)
			{
				SRailSlideControlConfig other = (SRailSlideControlConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F89D RID: 129181 RVA: 0x0092FF49 File Offset: 0x0092E149
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.阻尼, this.最大角速度, this.最大线速度, this.回归强度, this.输入系数);
		}

		// Token: 0x0601F89E RID: 129182 RVA: 0x0092FF6E File Offset: 0x0092E16E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRailSlideControlConfig._ScriptStructPtr != 0) ? SRailSlideControlConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig", ref SRailSlideControlConfig._ScriptStructPtr);
		}

		// Token: 0x04010EA8 RID: 69288
		[FieldOffset(0)]
		public float 阻尼;

		// Token: 0x04010EA9 RID: 69289
		[FieldOffset(4)]
		public float 最大角速度;

		// Token: 0x04010EAA RID: 69290
		[FieldOffset(8)]
		public float 最大线速度;

		// Token: 0x04010EAB RID: 69291
		[FieldOffset(12)]
		public float 回归强度;

		// Token: 0x04010EAC RID: 69292
		[FieldOffset(16)]
		public float 输入系数;

		// Token: 0x04010EAD RID: 69293
		public const string __ObjectPath = "/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig";

		// Token: 0x04010EAE RID: 69294
		private static IntPtr _ScriptStructPtr;
	}
}
