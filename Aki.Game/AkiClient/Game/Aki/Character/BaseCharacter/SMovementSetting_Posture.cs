using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335F RID: 13151
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SMovementSetting_Posture : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021535 RID: 136501 RVA: 0x0095DFB8 File Offset: 0x0095C1B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting_Posture._ScriptStructPtr != 0) ? SMovementSetting_Posture._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture", ref SMovementSetting_Posture._ScriptStructPtr);
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x06021536 RID: 136502 RVA: 0x0095DFDC File Offset: 0x0095C1DC
		// (set) Token: 0x06021537 RID: 136503 RVA: 0x0095E01F File Offset: 0x0095C21F
		public SMovementSetting Standing
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting result;
				if ((result = this._Standing) == null)
				{
					result = (this._Standing = new SMovementSetting(base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_Standing, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_Standing, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x06021538 RID: 136504 RVA: 0x0095E040 File Offset: 0x0095C240
		// (set) Token: 0x06021539 RID: 136505 RVA: 0x0095E083 File Offset: 0x0095C283
		public SMovementSetting Crouching
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting result;
				if ((result = this._Crouching) == null)
				{
					result = (this._Crouching = new SMovementSetting(base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_Crouching, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_Crouching, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602153A RID: 136506 RVA: 0x0095E0A4 File Offset: 0x0095C2A4
		public SMovementSetting_Posture()
		{
		}

		// Token: 0x0602153B RID: 136507 RVA: 0x0095E0AC File Offset: 0x0095C2AC
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting_Posture.StaticStruct();
		}

		// Token: 0x0602153C RID: 136508 RVA: 0x0095E0B8 File Offset: 0x0095C2B8
		[NullableContext(2)]
		public SMovementSetting_Posture(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602153D RID: 136509 RVA: 0x0095E0C2 File Offset: 0x0095C2C2
		public SMovementSetting_Posture(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602153E RID: 136510 RVA: 0x0095E0CD File Offset: 0x0095C2CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting_Posture(Pointer, false, true);
		}

		// Token: 0x0602153F RID: 136511 RVA: 0x0095E0D7 File Offset: 0x0095C2D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting_Posture(Pointer, MemoryOwner);
		}

		// Token: 0x04012368 RID: 74600
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture";

		// Token: 0x04012369 RID: 74601
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401236A RID: 74602
		internal static int __PropertyOffset_Standing;

		// Token: 0x0401236B RID: 74603
		[Nullable(2)]
		private SMovementSetting _Standing;

		// Token: 0x0401236C RID: 74604
		internal static int __PropertyOffset_Crouching;

		// Token: 0x0401236D RID: 74605
		[Nullable(2)]
		private SMovementSetting _Crouching;
	}
}
