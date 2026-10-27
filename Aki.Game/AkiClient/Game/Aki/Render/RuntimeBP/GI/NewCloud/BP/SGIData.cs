using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D67 RID: 15719
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SGIData.SGIData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct SGIData : IEqualityOperators<SGIData, SGIData, bool>, IEquatable<SGIData>, IUnrealScriptStruct
	{
		// Token: 0x0602690F RID: 157967 RVA: 0x00978838 File Offset: 0x00976A38
		public SGIData(float Time)
		{
			this.Time = Time;
		}

		// Token: 0x06026910 RID: 157968 RVA: 0x00978841 File Offset: 0x00976A41
		public static bool operator ==(SGIData left, SGIData right)
		{
			return left.Time == right.Time;
		}

		// Token: 0x06026911 RID: 157969 RVA: 0x00978851 File Offset: 0x00976A51
		public static bool operator !=(SGIData left, SGIData right)
		{
			return !(left == right);
		}

		// Token: 0x06026912 RID: 157970 RVA: 0x0097885D File Offset: 0x00976A5D
		public bool Equals(SGIData other)
		{
			return this == other;
		}

		// Token: 0x06026913 RID: 157971 RVA: 0x0097886C File Offset: 0x00976A6C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SGIData)
			{
				SGIData other = (SGIData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06026914 RID: 157972 RVA: 0x00978891 File Offset: 0x00976A91
		public override int GetHashCode()
		{
			return HashCode.Combine<float>(this.Time);
		}

		// Token: 0x06026915 RID: 157973 RVA: 0x0097889E File Offset: 0x00976A9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGIData._ScriptStructPtr != 0) ? SGIData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SGIData.SGIData", ref SGIData._ScriptStructPtr);
		}

		// Token: 0x0401361B RID: 79387
		[FieldOffset(0)]
		public float Time;

		// Token: 0x0401361C RID: 79388
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SGIData.SGIData";

		// Token: 0x0401361D RID: 79389
		private static IntPtr _ScriptStructPtr;
	}
}
