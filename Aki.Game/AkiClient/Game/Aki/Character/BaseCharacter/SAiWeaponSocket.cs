using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003335 RID: 13109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SAiWeaponSocket : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060211D9 RID: 135641 RVA: 0x00959A60 File Offset: 0x00957C60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiWeaponSocket._ScriptStructPtr != 0) ? SAiWeaponSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket", ref SAiWeaponSocket._ScriptStructPtr);
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x060211DA RID: 135642 RVA: 0x00959A84 File Offset: 0x00957C84
		// (set) Token: 0x060211DB RID: 135643 RVA: 0x00959AC7 File Offset: 0x00957CC7
		public TMap<int, SWeaponSocket> AiModelConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SWeaponSocket> result;
				if ((result = this._AiModelConfig) == null)
				{
					result = (this._AiModelConfig = new TMap<int, SWeaponSocket>(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_AiModelConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AiModelConfig.CopyAssign(value);
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x060211DC RID: 135644 RVA: 0x00959AD5 File Offset: 0x00957CD5
		// (set) Token: 0x060211DD RID: 135645 RVA: 0x00959AE5 File Offset: 0x00957CE5
		public unsafe float CollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_CollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_CollisionRadius) = value;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x060211DE RID: 135646 RVA: 0x00959AF6 File Offset: 0x00957CF6
		// (set) Token: 0x060211DF RID: 135647 RVA: 0x00959B06 File Offset: 0x00957D06
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiWeaponSocket.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x060211E0 RID: 135648 RVA: 0x00959B17 File Offset: 0x00957D17
		public SAiWeaponSocket()
		{
		}

		// Token: 0x060211E1 RID: 135649 RVA: 0x00959B1F File Offset: 0x00957D1F
		protected override IntPtr GetUStructPtr()
		{
			return SAiWeaponSocket.StaticStruct();
		}

		// Token: 0x060211E2 RID: 135650 RVA: 0x00959B2B File Offset: 0x00957D2B
		[NullableContext(2)]
		public SAiWeaponSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060211E3 RID: 135651 RVA: 0x00959B35 File Offset: 0x00957D35
		public SAiWeaponSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060211E4 RID: 135652 RVA: 0x00959B40 File Offset: 0x00957D40
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiWeaponSocket(Pointer, false, true);
		}

		// Token: 0x060211E5 RID: 135653 RVA: 0x00959B4A File Offset: 0x00957D4A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiWeaponSocket(Pointer, MemoryOwner);
		}

		// Token: 0x040121BB RID: 74171
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAiWeaponSocket.SAiWeaponSocket";

		// Token: 0x040121BC RID: 74172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121BD RID: 74173
		internal static int __PropertyOffset_AiModelConfig;

		// Token: 0x040121BE RID: 74174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SWeaponSocket> _AiModelConfig;

		// Token: 0x040121BF RID: 74175
		internal static int __PropertyOffset_CollisionRadius;

		// Token: 0x040121C0 RID: 74176
		internal static int __PropertyOffset_Mass;
	}
}
