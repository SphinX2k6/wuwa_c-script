using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.RailSlide
{
	// Token: 0x02003F09 RID: 16137
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct SRailSlideControlConfig : IEqualityOperators<SRailSlideControlConfig, SRailSlideControlConfig, bool>, IEquatable<SRailSlideControlConfig>, IUnrealScriptStruct
	{
		// Token: 0x06028F05 RID: 167685 RVA: 0x009B7EB6 File Offset: 0x009B60B6
		public SRailSlideControlConfig(float 阻尼, float 最大角速度, float 最大线速度, float 回归强度, float 输入系数)
		{
			this.阻尼 = 阻尼;
			this.最大角速度 = 最大角速度;
			this.最大线速度 = 最大线速度;
			this.回归强度 = 回归强度;
			this.输入系数 = 输入系数;
		}

		// Token: 0x06028F06 RID: 167686 RVA: 0x009B7EE0 File Offset: 0x009B60E0
		public static bool operator ==(SRailSlideControlConfig left, SRailSlideControlConfig right)
		{
			return left.阻尼 == right.阻尼 && left.最大角速度 == right.最大角速度 && left.最大线速度 == right.最大线速度 && left.回归强度 == right.回归强度 && left.输入系数 == right.输入系数;
		}

		// Token: 0x06028F07 RID: 167687 RVA: 0x009B7F35 File Offset: 0x009B6135
		public static bool operator !=(SRailSlideControlConfig left, SRailSlideControlConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06028F08 RID: 167688 RVA: 0x009B7F41 File Offset: 0x009B6141
		public bool Equals(SRailSlideControlConfig other)
		{
			return this == other;
		}

		// Token: 0x06028F09 RID: 167689 RVA: 0x009B7F50 File Offset: 0x009B6150
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

		// Token: 0x06028F0A RID: 167690 RVA: 0x009B7F75 File Offset: 0x009B6175
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.阻尼, this.最大角速度, this.最大线速度, this.回归强度, this.输入系数);
		}

		// Token: 0x06028F0B RID: 167691 RVA: 0x009B7F9A File Offset: 0x009B619A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRailSlideControlConfig._ScriptStructPtr != 0) ? SRailSlideControlConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig", ref SRailSlideControlConfig._ScriptStructPtr);
		}

		// Token: 0x04014F08 RID: 85768
		[FieldOffset(0)]
		public float 阻尼;

		// Token: 0x04014F09 RID: 85769
		[FieldOffset(4)]
		public float 最大角速度;

		// Token: 0x04014F0A RID: 85770
		[FieldOffset(8)]
		public float 最大线速度;

		// Token: 0x04014F0B RID: 85771
		[FieldOffset(12)]
		public float 回归强度;

		// Token: 0x04014F0C RID: 85772
		[FieldOffset(16)]
		public float 输入系数;

		// Token: 0x04014F0D RID: 85773
		public const string __ObjectPath = "/Game/Aki/Data/Level/RailSlide/SRailSlideControlConfig.SRailSlideControlConfig";

		// Token: 0x04014F0E RID: 85774
		private static IntPtr _ScriptStructPtr;
	}
}
