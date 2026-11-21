using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003134 RID: 12596
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SMaterialControllerLoopTime : IEqualityOperators<SMaterialControllerLoopTime, SMaterialControllerLoopTime, bool>, IEquatable<SMaterialControllerLoopTime>, IUnrealScriptStruct
	{
		// Token: 0x0601EFC6 RID: 126918 RVA: 0x00922DB8 File Offset: 0x00920FB8
		public SMaterialControllerLoopTime(float Start, float Loop, float End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x0601EFC7 RID: 126919 RVA: 0x00922DCF File Offset: 0x00920FCF
		public static bool operator ==(SMaterialControllerLoopTime left, SMaterialControllerLoopTime right)
		{
			return left.Start == right.Start && left.Loop == right.Loop && left.End == right.End;
		}

		// Token: 0x0601EFC8 RID: 126920 RVA: 0x00922DFD File Offset: 0x00920FFD
		public static bool operator !=(SMaterialControllerLoopTime left, SMaterialControllerLoopTime right)
		{
			return !(left == right);
		}

		// Token: 0x0601EFC9 RID: 126921 RVA: 0x00922E09 File Offset: 0x00921009
		public bool Equals(SMaterialControllerLoopTime other)
		{
			return this == other;
		}

		// Token: 0x0601EFCA RID: 126922 RVA: 0x00922E18 File Offset: 0x00921018
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMaterialControllerLoopTime)
			{
				SMaterialControllerLoopTime other = (SMaterialControllerLoopTime)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601EFCB RID: 126923 RVA: 0x00922E3D File Offset: 0x0092103D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.Start, this.Loop, this.End);
		}

		// Token: 0x0601EFCC RID: 126924 RVA: 0x00922E56 File Offset: 0x00921056
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerLoopTime._ScriptStructPtr != 0) ? SMaterialControllerLoopTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime", ref SMaterialControllerLoopTime._ScriptStructPtr);
		}

		// Token: 0x040107F7 RID: 67575
		[FieldOffset(0)]
		public float Start;

		// Token: 0x040107F8 RID: 67576
		[FieldOffset(4)]
		public float Loop;

		// Token: 0x040107F9 RID: 67577
		[FieldOffset(8)]
		public float End;

		// Token: 0x040107FA RID: 67578
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime";

		// Token: 0x040107FB RID: 67579
		private static IntPtr _ScriptStructPtr;
	}
}
