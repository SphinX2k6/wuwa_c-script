using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334C RID: 13132
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SEntityProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021398 RID: 136088 RVA: 0x0095C001 File Offset: 0x0095A201
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityProperty._ScriptStructPtr != 0) ? SEntityProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty", ref SEntityProperty._ScriptStructPtr);
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x06021399 RID: 136089 RVA: 0x0095C025 File Offset: 0x0095A225
		// (set) Token: 0x0602139A RID: 136090 RVA: 0x0095C039 File Offset: 0x0095A239
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEntityProperty.__PropertyOffset_备注)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEntityProperty.__PropertyOffset_备注)), value);
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x0602139B RID: 136091 RVA: 0x0095C04E File Offset: 0x0095A24E
		// (set) Token: 0x0602139C RID: 136092 RVA: 0x0095C05E File Offset: 0x0095A25E
		public unsafe int 碰撞优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_碰撞优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_碰撞优先级) = value;
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x0602139D RID: 136093 RVA: 0x0095C06F File Offset: 0x0095A26F
		// (set) Token: 0x0602139E RID: 136094 RVA: 0x0095C07F File Offset: 0x0095A27F
		public unsafe int 穿透优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_穿透优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_穿透优先级) = value;
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x0602139F RID: 136095 RVA: 0x0095C090 File Offset: 0x0095A290
		// (set) Token: 0x060213A0 RID: 136096 RVA: 0x0095C0A0 File Offset: 0x0095A2A0
		public unsafe int 受击映射索引ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_受击映射索引ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_受击映射索引ID) = value;
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x060213A1 RID: 136097 RVA: 0x0095C0B1 File Offset: 0x0095A2B1
		// (set) Token: 0x060213A2 RID: 136098 RVA: 0x0095C0C1 File Offset: 0x0095A2C1
		public unsafe int 重量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_重量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_重量) = value;
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x060213A3 RID: 136099 RVA: 0x0095C0D2 File Offset: 0x0095A2D2
		// (set) Token: 0x060213A4 RID: 136100 RVA: 0x0095C0E2 File Offset: 0x0095A2E2
		public unsafe int CaughtLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_CaughtLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_CaughtLevel) = value;
			}
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x060213A5 RID: 136101 RVA: 0x0095C0F3 File Offset: 0x0095A2F3
		// (set) Token: 0x060213A6 RID: 136102 RVA: 0x0095C103 File Offset: 0x0095A303
		public unsafe int 子弹受击顿帧时长比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_子弹受击顿帧时长比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SEntityProperty.__PropertyOffset_子弹受击顿帧时长比例) = value;
			}
		}

		// Token: 0x060213A7 RID: 136103 RVA: 0x0095C114 File Offset: 0x0095A314
		public SEntityProperty()
		{
		}

		// Token: 0x060213A8 RID: 136104 RVA: 0x0095C11C File Offset: 0x0095A31C
		protected override IntPtr GetUStructPtr()
		{
			return SEntityProperty.StaticStruct();
		}

		// Token: 0x060213A9 RID: 136105 RVA: 0x0095C128 File Offset: 0x0095A328
		[NullableContext(2)]
		public SEntityProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213AA RID: 136106 RVA: 0x0095C132 File Offset: 0x0095A332
		public SEntityProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213AB RID: 136107 RVA: 0x0095C13D File Offset: 0x0095A33D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEntityProperty(Pointer, false, true);
		}

		// Token: 0x060213AC RID: 136108 RVA: 0x0095C147 File Offset: 0x0095A347
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEntityProperty(Pointer, MemoryOwner);
		}

		// Token: 0x040122A0 RID: 74400
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SEntityProperty.SEntityProperty";

		// Token: 0x040122A1 RID: 74401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122A2 RID: 74402
		internal static int __PropertyOffset_备注;

		// Token: 0x040122A3 RID: 74403
		internal static int __PropertyOffset_碰撞优先级;

		// Token: 0x040122A4 RID: 74404
		internal static int __PropertyOffset_穿透优先级;

		// Token: 0x040122A5 RID: 74405
		internal static int __PropertyOffset_受击映射索引ID;

		// Token: 0x040122A6 RID: 74406
		internal static int __PropertyOffset_重量;

		// Token: 0x040122A7 RID: 74407
		internal static int __PropertyOffset_CaughtLevel;

		// Token: 0x040122A8 RID: 74408
		internal static int __PropertyOffset_子弹受击顿帧时长比例;
	}
}
