using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1C RID: 15900
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SMaterialControllerLoopTime : IEqualityOperators<SMaterialControllerLoopTime, SMaterialControllerLoopTime, bool>, IEquatable<SMaterialControllerLoopTime>, IUnrealScriptStruct
	{
		// Token: 0x06027DBB RID: 163259 RVA: 0x0099D1F2 File Offset: 0x0099B3F2
		public SMaterialControllerLoopTime(float Start, float Loop, float End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x06027DBC RID: 163260 RVA: 0x0099D209 File Offset: 0x0099B409
		public static bool operator ==(SMaterialControllerLoopTime left, SMaterialControllerLoopTime right)
		{
			return left.Start == right.Start && left.Loop == right.Loop && left.End == right.End;
		}

		// Token: 0x06027DBD RID: 163261 RVA: 0x0099D237 File Offset: 0x0099B437
		public static bool operator !=(SMaterialControllerLoopTime left, SMaterialControllerLoopTime right)
		{
			return !(left == right);
		}

		// Token: 0x06027DBE RID: 163262 RVA: 0x0099D243 File Offset: 0x0099B443
		public bool Equals(SMaterialControllerLoopTime other)
		{
			return this == other;
		}

		// Token: 0x06027DBF RID: 163263 RVA: 0x0099D254 File Offset: 0x0099B454
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

		// Token: 0x06027DC0 RID: 163264 RVA: 0x0099D279 File Offset: 0x0099B479
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.Start, this.Loop, this.End);
		}

		// Token: 0x06027DC1 RID: 163265 RVA: 0x0099D292 File Offset: 0x0099B492
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerLoopTime._ScriptStructPtr != 0) ? SMaterialControllerLoopTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime", ref SMaterialControllerLoopTime._ScriptStructPtr);
		}

		// Token: 0x0401434C RID: 82764
		[FieldOffset(0)]
		public float Start;

		// Token: 0x0401434D RID: 82765
		[FieldOffset(4)]
		public float Loop;

		// Token: 0x0401434E RID: 82766
		[FieldOffset(8)]
		public float End;

		// Token: 0x0401434F RID: 82767
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerLoopTime.SMaterialControllerLoopTime";

		// Token: 0x04014350 RID: 82768
		private static IntPtr _ScriptStructPtr;
	}
}
