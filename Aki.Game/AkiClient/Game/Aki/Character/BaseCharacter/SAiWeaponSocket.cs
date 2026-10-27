using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042EB RID: 17131
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SAiWeaponSocket : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C3A9 RID: 181161 RVA: 0x00A1AA06 File Offset: 0x00A18C06
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiWeaponSocket._ScriptStructPtr != 0) ? SAiWeaponSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket", ref SAiWeaponSocket._ScriptStructPtr);
		}

		// Token: 0x17006E40 RID: 28224
		// (get) Token: 0x0602C3AA RID: 181162 RVA: 0x00A1AA2C File Offset: 0x00A18C2C
		// (set) Token: 0x0602C3AB RID: 181163 RVA: 0x00A1AA6F File Offset: 0x00A18C6F
		public TMap<int, SWeaponSocket> AiModelConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SWeaponSocket> result;
				if ((result = this._AiModelConfig) == null)
				{
					result = (this._AiModelConfig = new TMap<int, SWeaponSocket>(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AiModelConfig.CopyAssign(value);
			}
		}

		// Token: 0x17006E41 RID: 28225
		// (get) Token: 0x0602C3AC RID: 181164 RVA: 0x00A1AA7D File Offset: 0x00A18C7D
		// (set) Token: 0x0602C3AD RID: 181165 RVA: 0x00A1AA8D File Offset: 0x00A18C8D
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E42 RID: 28226
		// (get) Token: 0x0602C3AE RID: 181166 RVA: 0x00A1AA9E File Offset: 0x00A18C9E
		// (set) Token: 0x0602C3AF RID: 181167 RVA: 0x00A1AAAE File Offset: 0x00A18CAE
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602C3B0 RID: 181168 RVA: 0x00A1AABF File Offset: 0x00A18CBF
		public SAiWeaponSocket()
		{
		}

		// Token: 0x0602C3B1 RID: 181169 RVA: 0x00A1AAC7 File Offset: 0x00A18CC7
		public SAiWeaponSocket(TMap<int, SWeaponSocket> AiModelConfig, float CollisionRadius, float Mass)
		{
			this.AiModelConfig = AiModelConfig;
			this.CollisionRadius = CollisionRadius;
			this.Mass = Mass;
		}

		// Token: 0x0602C3B2 RID: 181170 RVA: 0x00A1AAE4 File Offset: 0x00A18CE4
		protected override IntPtr GetUStructPtr()
		{
			return SAiWeaponSocket.StaticStruct();
		}

		// Token: 0x0602C3B3 RID: 181171 RVA: 0x00A1AAF0 File Offset: 0x00A18CF0
		[NullableContext(2)]
		public SAiWeaponSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C3B4 RID: 181172 RVA: 0x00A1AAFA File Offset: 0x00A18CFA
		public SAiWeaponSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C3B5 RID: 181173 RVA: 0x00A1AB05 File Offset: 0x00A18D05
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiWeaponSocket(Pointer, false, true);
		}

		// Token: 0x0602C3B6 RID: 181174 RVA: 0x00A1AB0F File Offset: 0x00A18D0F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiWeaponSocket(Pointer, MemoryOwner);
		}

		// Token: 0x0401751E RID: 95518
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket";

		// Token: 0x0401751F RID: 95519
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017520 RID: 95520
		internal static int __PropertyOffset_0;

		// Token: 0x04017521 RID: 95521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SWeaponSocket> _AiModelConfig;

		// Token: 0x04017522 RID: 95522
		internal static int __PropertyOffset_1;

		// Token: 0x04017523 RID: 95523
		internal static int __PropertyOffset_2;
	}
}
