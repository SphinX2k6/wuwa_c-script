using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.FemaleM.YinLin.Abilities
{
	// Token: 0x02004098 RID: 16536
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/YinLin/Abilities/SYinlin_MeshSocket.SYinlin_MeshSocket")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SYinlin_MeshSocket : IEqualityOperators<SYinlin_MeshSocket, SYinlin_MeshSocket, bool>, IEquatable<SYinlin_MeshSocket>, IUnrealScriptStruct
	{
		// Token: 0x0602A96B RID: 174443 RVA: 0x009E5538 File Offset: 0x009E3738
		public SYinlin_MeshSocket(TEnumAsByte<EYinlin_Type> Type, FName SocketName)
		{
			this.Type = Type;
			this.SocketName = SocketName;
		}

		// Token: 0x0602A96C RID: 174444 RVA: 0x009E5548 File Offset: 0x009E3748
		public static bool operator ==(SYinlin_MeshSocket left, SYinlin_MeshSocket right)
		{
			return left.Type == right.Type && left.SocketName == right.SocketName;
		}

		// Token: 0x0602A96D RID: 174445 RVA: 0x009E5570 File Offset: 0x009E3770
		public static bool operator !=(SYinlin_MeshSocket left, SYinlin_MeshSocket right)
		{
			return !(left == right);
		}

		// Token: 0x0602A96E RID: 174446 RVA: 0x009E557C File Offset: 0x009E377C
		public bool Equals(SYinlin_MeshSocket other)
		{
			return this == other;
		}

		// Token: 0x0602A96F RID: 174447 RVA: 0x009E558C File Offset: 0x009E378C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SYinlin_MeshSocket)
			{
				SYinlin_MeshSocket other = (SYinlin_MeshSocket)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A970 RID: 174448 RVA: 0x009E55B1 File Offset: 0x009E37B1
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EYinlin_Type>, FName>(this.Type, this.SocketName);
		}

		// Token: 0x0602A971 RID: 174449 RVA: 0x009E55C4 File Offset: 0x009E37C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SYinlin_MeshSocket._ScriptStructPtr != 0) ? SYinlin_MeshSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/FemaleM/YinLin/Abilities/SYinlin_MeshSocket.SYinlin_MeshSocket", ref SYinlin_MeshSocket._ScriptStructPtr);
		}

		// Token: 0x0401606A RID: 90218
		[FieldOffset(0)]
		public TEnumAsByte<EYinlin_Type> Type;

		// Token: 0x0401606B RID: 90219
		[FieldOffset(4)]
		public FName SocketName;

		// Token: 0x0401606C RID: 90220
		public const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/YinLin/Abilities/SYinlin_MeshSocket.SYinlin_MeshSocket";

		// Token: 0x0401606D RID: 90221
		private static IntPtr _ScriptStructPtr;
	}
}
