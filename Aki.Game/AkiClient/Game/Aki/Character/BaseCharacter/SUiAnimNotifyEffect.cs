using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004338 RID: 17208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SUiAnimNotifyEffect.SUiAnimNotifyEffect")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 81)]
	public class SUiAnimNotifyEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA14 RID: 182804 RVA: 0x00A246AB File Offset: 0x00A228AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiAnimNotifyEffect._ScriptStructPtr != 0) ? SUiAnimNotifyEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SUiAnimNotifyEffect.SUiAnimNotifyEffect", ref SUiAnimNotifyEffect._ScriptStructPtr);
		}

		// Token: 0x17007047 RID: 28743
		// (get) Token: 0x0602CA15 RID: 182805 RVA: 0x00A246CF File Offset: 0x00A228CF
		// (set) Token: 0x0602CA16 RID: 182806 RVA: 0x00A246E3 File Offset: 0x00A228E3
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyEffect.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiAnimNotifyEffect.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17007048 RID: 28744
		// (get) Token: 0x0602CA17 RID: 182807 RVA: 0x00A246F8 File Offset: 0x00A228F8
		// (set) Token: 0x0602CA18 RID: 182808 RVA: 0x00A2470C File Offset: 0x00A2290C
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiAnimNotifyEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiAnimNotifyEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007049 RID: 28745
		// (get) Token: 0x0602CA19 RID: 182809 RVA: 0x00A24724 File Offset: 0x00A22924
		// (set) Token: 0x0602CA1A RID: 182810 RVA: 0x00A24767 File Offset: 0x00A22967
		public TArray<TSoftObjectPtr<UObject>> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SUiAnimNotifyEffect.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x1700704A RID: 28746
		// (get) Token: 0x0602CA1B RID: 182811 RVA: 0x00A24775 File Offset: 0x00A22975
		// (set) Token: 0x0602CA1C RID: 182812 RVA: 0x00A24789 File Offset: 0x00A22989
		[Nullable(0)]
		public unsafe TEnumAsByte<EPerformanceRoleState> AnimState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SUiAnimNotifyEffect.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SUiAnimNotifyEffect.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602CA1D RID: 182813 RVA: 0x00A2479E File Offset: 0x00A2299E
		public SUiAnimNotifyEffect()
		{
		}

		// Token: 0x0602CA1E RID: 182814 RVA: 0x00A247A6 File Offset: 0x00A229A6
		public SUiAnimNotifyEffect(string SocketName, FTransform Transform, TArray<TSoftObjectPtr<UObject>> Effects, [Nullable(0)] TEnumAsByte<EPerformanceRoleState> AnimState)
		{
			this.SocketName = SocketName;
			this.Transform = Transform;
			this.Effects = Effects;
			this.AnimState = AnimState;
		}

		// Token: 0x0602CA1F RID: 182815 RVA: 0x00A247CB File Offset: 0x00A229CB
		protected override IntPtr GetUStructPtr()
		{
			return SUiAnimNotifyEffect.StaticStruct();
		}

		// Token: 0x0602CA20 RID: 182816 RVA: 0x00A247D7 File Offset: 0x00A229D7
		[NullableContext(2)]
		public SUiAnimNotifyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA21 RID: 182817 RVA: 0x00A247E1 File Offset: 0x00A229E1
		public SUiAnimNotifyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA22 RID: 182818 RVA: 0x00A247EC File Offset: 0x00A229EC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiAnimNotifyEffect(Pointer, false, true);
		}

		// Token: 0x0602CA23 RID: 182819 RVA: 0x00A247F6 File Offset: 0x00A229F6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiAnimNotifyEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0401786B RID: 96363
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SUiAnimNotifyEffect.SUiAnimNotifyEffect";

		// Token: 0x0401786C RID: 96364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401786D RID: 96365
		internal static int __PropertyOffset_0;

		// Token: 0x0401786E RID: 96366
		internal static int __PropertyOffset_1;

		// Token: 0x0401786F RID: 96367
		internal static int __PropertyOffset_2;

		// Token: 0x04017870 RID: 96368
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _Effects;

		// Token: 0x04017871 RID: 96369
		internal static int __PropertyOffset_3;
	}
}
