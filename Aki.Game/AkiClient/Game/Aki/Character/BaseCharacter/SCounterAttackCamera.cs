using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003344 RID: 13124
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class SCounterAttackCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021302 RID: 135938 RVA: 0x0095B384 File Offset: 0x00959584
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackCamera._ScriptStructPtr != 0) ? SCounterAttackCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera", ref SCounterAttackCamera._ScriptStructPtr);
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x06021303 RID: 135939 RVA: 0x0095B3A8 File Offset: 0x009595A8
		// (set) Token: 0x06021304 RID: 135940 RVA: 0x0095B3BC File Offset: 0x009595BC
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x06021305 RID: 135941 RVA: 0x0095B3D1 File Offset: 0x009595D1
		// (set) Token: 0x06021306 RID: 135942 RVA: 0x0095B3E1 File Offset: 0x009595E1
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_持续时间) = value;
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x06021307 RID: 135943 RVA: 0x0095B3F2 File Offset: 0x009595F2
		// (set) Token: 0x06021308 RID: 135944 RVA: 0x0095B402 File Offset: 0x00959602
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_淡入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_淡入时间) = value;
			}
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x06021309 RID: 135945 RVA: 0x0095B413 File Offset: 0x00959613
		// (set) Token: 0x0602130A RID: 135946 RVA: 0x0095B423 File Offset: 0x00959623
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_淡出时间) = value;
			}
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0602130B RID: 135947 RVA: 0x0095B434 File Offset: 0x00959634
		// (set) Token: 0x0602130C RID: 135948 RVA: 0x0095B444 File Offset: 0x00959644
		public unsafe float 打断淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_打断淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_打断淡出时间) = value;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x0602130D RID: 135949 RVA: 0x0095B455 File Offset: 0x00959655
		// (set) Token: 0x0602130E RID: 135950 RVA: 0x0095B469 File Offset: 0x00959669
		public unsafe string CameraAttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCounterAttackCamera.__PropertyOffset_CameraAttachSocket)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCounterAttackCamera.__PropertyOffset_CameraAttachSocket)), value);
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0602130F RID: 135951 RVA: 0x0095B480 File Offset: 0x00959680
		// (set) Token: 0x06021310 RID: 135952 RVA: 0x0095B4C3 File Offset: 0x009596C3
		public SCameraModifier_Settings 摄像机配置
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._摄像机配置) == null)
				{
					result = (this._摄像机配置 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_摄像机配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_摄像机配置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021311 RID: 135953 RVA: 0x0095B4E4 File Offset: 0x009596E4
		public SCounterAttackCamera()
		{
		}

		// Token: 0x06021312 RID: 135954 RVA: 0x0095B4EC File Offset: 0x009596EC
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttackCamera.StaticStruct();
		}

		// Token: 0x06021313 RID: 135955 RVA: 0x0095B4F8 File Offset: 0x009596F8
		[NullableContext(2)]
		public SCounterAttackCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021314 RID: 135956 RVA: 0x0095B502 File Offset: 0x00959702
		public SCounterAttackCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021315 RID: 135957 RVA: 0x0095B50D File Offset: 0x0095970D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttackCamera(Pointer, false, true);
		}

		// Token: 0x06021316 RID: 135958 RVA: 0x0095B517 File Offset: 0x00959717
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttackCamera(Pointer, MemoryOwner);
		}

		// Token: 0x04012256 RID: 74326
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera";

		// Token: 0x04012257 RID: 74327
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012258 RID: 74328
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012259 RID: 74329
		internal static int __PropertyOffset_持续时间;

		// Token: 0x0401225A RID: 74330
		internal static int __PropertyOffset_淡入时间;

		// Token: 0x0401225B RID: 74331
		internal static int __PropertyOffset_淡出时间;

		// Token: 0x0401225C RID: 74332
		internal static int __PropertyOffset_打断淡出时间;

		// Token: 0x0401225D RID: 74333
		internal static int __PropertyOffset_CameraAttachSocket;

		// Token: 0x0401225E RID: 74334
		internal static int __PropertyOffset_摄像机配置;

		// Token: 0x0401225F RID: 74335
		[Nullable(2)]
		private SCameraModifier_Settings _摄像机配置;
	}
}
