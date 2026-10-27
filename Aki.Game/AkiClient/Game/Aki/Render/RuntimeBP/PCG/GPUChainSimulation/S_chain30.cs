using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUChainSimulation
{
	// Token: 0x02003CB1 RID: 15537
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 29)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/S_chain30.S_chain30")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct S_chain30 : IEqualityOperators<S_chain30, S_chain30, bool>, IEquatable<S_chain30>, IUnrealScriptStruct
	{
		// Token: 0x06024904 RID: 149764 RVA: 0x009422E8 File Offset: 0x009404E8
		public S_chain30(int left_index, int right_index, FVector Pos, float pos_left, float pos_right, bool isPinned)
		{
			this.left_index = left_index;
			this.right_index = right_index;
			this.Pos = Pos;
			this.pos_left = pos_left;
			this.pos_right = pos_right;
			this.isPinned = isPinned;
		}

		// Token: 0x06024905 RID: 149765 RVA: 0x00942318 File Offset: 0x00940518
		public static bool operator ==(S_chain30 left, S_chain30 right)
		{
			return left.left_index == right.left_index && left.right_index == right.right_index && left.Pos == right.Pos && left.pos_left == right.pos_left && left.pos_right == right.pos_right && left.isPinned == right.isPinned;
		}

		// Token: 0x06024906 RID: 149766 RVA: 0x00942380 File Offset: 0x00940580
		public static bool operator !=(S_chain30 left, S_chain30 right)
		{
			return !(left == right);
		}

		// Token: 0x06024907 RID: 149767 RVA: 0x0094238C File Offset: 0x0094058C
		public bool Equals(S_chain30 other)
		{
			return this == other;
		}

		// Token: 0x06024908 RID: 149768 RVA: 0x0094239C File Offset: 0x0094059C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is S_chain30)
			{
				S_chain30 other = (S_chain30)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024909 RID: 149769 RVA: 0x009423C1 File Offset: 0x009405C1
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, FVector, float, float, bool>(this.left_index, this.right_index, this.Pos, this.pos_left, this.pos_right, this.isPinned);
		}

		// Token: 0x0602490A RID: 149770 RVA: 0x009423EC File Offset: 0x009405EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_chain30._ScriptStructPtr != 0) ? S_chain30._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/S_chain30.S_chain30", ref S_chain30._ScriptStructPtr);
		}

		// Token: 0x04012283 RID: 74371
		[FieldOffset(0)]
		public int left_index;

		// Token: 0x04012284 RID: 74372
		[FieldOffset(4)]
		public int right_index;

		// Token: 0x04012285 RID: 74373
		[FieldOffset(8)]
		public FVector Pos;

		// Token: 0x04012286 RID: 74374
		[FieldOffset(20)]
		public float pos_left;

		// Token: 0x04012287 RID: 74375
		[FieldOffset(24)]
		public float pos_right;

		// Token: 0x04012288 RID: 74376
		[FieldOffset(28)]
		public bool isPinned;

		// Token: 0x04012289 RID: 74377
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/S_chain30.S_chain30";

		// Token: 0x0401228A RID: 74378
		private static IntPtr _ScriptStructPtr;
	}
}
