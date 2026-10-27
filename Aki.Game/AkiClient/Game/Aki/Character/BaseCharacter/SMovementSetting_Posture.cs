using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004326 RID: 17190
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SMovementSetting_Posture : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C82E RID: 182318 RVA: 0x00A215EC File Offset: 0x00A1F7EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementSetting_Posture._ScriptStructPtr != 0) ? SMovementSetting_Posture._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture", ref SMovementSetting_Posture._ScriptStructPtr);
		}

		// Token: 0x17006F9B RID: 28571
		// (get) Token: 0x0602C82F RID: 182319 RVA: 0x00A21610 File Offset: 0x00A1F810
		// (set) Token: 0x0602C830 RID: 182320 RVA: 0x00A21653 File Offset: 0x00A1F853
		public SMovementSetting Standing
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting result;
				if ((result = this._Standing) == null)
				{
					result = (this._Standing = new SMovementSetting(base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006F9C RID: 28572
		// (get) Token: 0x0602C831 RID: 182321 RVA: 0x00A21674 File Offset: 0x00A1F874
		// (set) Token: 0x0602C832 RID: 182322 RVA: 0x00A216B7 File Offset: 0x00A1F8B7
		public SMovementSetting Crouching
		{
			get
			{
				base.FastCheckIsValid();
				SMovementSetting result;
				if ((result = this._Crouching) == null)
				{
					result = (this._Crouching = new SMovementSetting(base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovementSetting_Posture.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C833 RID: 182323 RVA: 0x00A216D8 File Offset: 0x00A1F8D8
		public SMovementSetting_Posture()
		{
		}

		// Token: 0x0602C834 RID: 182324 RVA: 0x00A216E0 File Offset: 0x00A1F8E0
		public SMovementSetting_Posture(SMovementSetting Standing, SMovementSetting Crouching)
		{
			this.Standing = Standing;
			this.Crouching = Crouching;
		}

		// Token: 0x0602C835 RID: 182325 RVA: 0x00A216F6 File Offset: 0x00A1F8F6
		protected override IntPtr GetUStructPtr()
		{
			return SMovementSetting_Posture.StaticStruct();
		}

		// Token: 0x0602C836 RID: 182326 RVA: 0x00A21702 File Offset: 0x00A1F902
		[NullableContext(2)]
		public SMovementSetting_Posture(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C837 RID: 182327 RVA: 0x00A2170C File Offset: 0x00A1F90C
		public SMovementSetting_Posture(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C838 RID: 182328 RVA: 0x00A21717 File Offset: 0x00A1F917
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementSetting_Posture(Pointer, false, true);
		}

		// Token: 0x0602C839 RID: 182329 RVA: 0x00A21721 File Offset: 0x00A1F921
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementSetting_Posture(Pointer, MemoryOwner);
		}

		// Token: 0x04017764 RID: 96100
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementSetting_Posture.SMovementSetting_Posture";

		// Token: 0x04017765 RID: 96101
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017766 RID: 96102
		internal static int __PropertyOffset_0;

		// Token: 0x04017767 RID: 96103
		[Nullable(2)]
		private SMovementSetting _Standing;

		// Token: 0x04017768 RID: 96104
		internal static int __PropertyOffset_1;

		// Token: 0x04017769 RID: 96105
		[Nullable(2)]
		private SMovementSetting _Crouching;
	}
}
