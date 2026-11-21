using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiModel.Struct
{
	// Token: 0x02003164 RID: 12644
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SUiModelRotateSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F257 RID: 127575 RVA: 0x009276F0 File Offset: 0x009258F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiModelRotateSetting._ScriptStructPtr != 0) ? SUiModelRotateSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting", ref SUiModelRotateSetting._ScriptStructPtr);
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0601F258 RID: 127576 RVA: 0x00927714 File Offset: 0x00925914
		// (set) Token: 0x0601F259 RID: 127577 RVA: 0x00927728 File Offset: 0x00925928
		public unsafe string 旋转中轴
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiModelRotateSetting.__PropertyOffset_旋转中轴)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiModelRotateSetting.__PropertyOffset_旋转中轴)), value);
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0601F25A RID: 127578 RVA: 0x0092773D File Offset: 0x0092593D
		// (set) Token: 0x0601F25B RID: 127579 RVA: 0x0092774D File Offset: 0x0092594D
		public unsafe float 旋转偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_旋转偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_旋转偏移) = value;
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0601F25C RID: 127580 RVA: 0x0092775E File Offset: 0x0092595E
		// (set) Token: 0x0601F25D RID: 127581 RVA: 0x0092776E File Offset: 0x0092596E
		public unsafe float 模型Yaw灵敏度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_模型Yaw灵敏度系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_模型Yaw灵敏度系数) = value;
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0601F25E RID: 127582 RVA: 0x0092777F File Offset: 0x0092597F
		// (set) Token: 0x0601F25F RID: 127583 RVA: 0x0092778F File Offset: 0x0092598F
		public unsafe float 模型Pitch灵敏度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_模型Pitch灵敏度系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_模型Pitch灵敏度系数) = value;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0601F260 RID: 127584 RVA: 0x009277A0 File Offset: 0x009259A0
		// (set) Token: 0x0601F261 RID: 127585 RVA: 0x009277B0 File Offset: 0x009259B0
		public unsafe float Yaw限制Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Yaw限制Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Yaw限制Min) = value;
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0601F262 RID: 127586 RVA: 0x009277C1 File Offset: 0x009259C1
		// (set) Token: 0x0601F263 RID: 127587 RVA: 0x009277D1 File Offset: 0x009259D1
		public unsafe float Yaw限制Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Yaw限制Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Yaw限制Max) = value;
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0601F264 RID: 127588 RVA: 0x009277E2 File Offset: 0x009259E2
		// (set) Token: 0x0601F265 RID: 127589 RVA: 0x009277F2 File Offset: 0x009259F2
		public unsafe float Pitch限制Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Pitch限制Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Pitch限制Min) = value;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0601F266 RID: 127590 RVA: 0x00927803 File Offset: 0x00925A03
		// (set) Token: 0x0601F267 RID: 127591 RVA: 0x00927813 File Offset: 0x00925A13
		public unsafe float Pitch限制Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Pitch限制Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_Pitch限制Max) = value;
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0601F268 RID: 127592 RVA: 0x00927824 File Offset: 0x00925A24
		// (set) Token: 0x0601F269 RID: 127593 RVA: 0x00927834 File Offset: 0x00925A34
		public unsafe float 最小臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_最小臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_最小臂长) = value;
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0601F26A RID: 127594 RVA: 0x00927845 File Offset: 0x00925A45
		// (set) Token: 0x0601F26B RID: 127595 RVA: 0x00927855 File Offset: 0x00925A55
		public unsafe float 最大臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_最大臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_最大臂长) = value;
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0601F26C RID: 127596 RVA: 0x00927866 File Offset: 0x00925A66
		// (set) Token: 0x0601F26D RID: 127597 RVA: 0x00927876 File Offset: 0x00925A76
		public unsafe float 倍化手柄输入倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_倍化手柄输入倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_倍化手柄输入倍率) = value;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0601F26E RID: 127598 RVA: 0x00927887 File Offset: 0x00925A87
		// (set) Token: 0x0601F26F RID: 127599 RVA: 0x00927897 File Offset: 0x00925A97
		public unsafe float 移动端旋转输入倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_移动端旋转输入倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_移动端旋转输入倍率) = value;
			}
		}

		// Token: 0x0601F270 RID: 127600 RVA: 0x009278A8 File Offset: 0x00925AA8
		public SUiModelRotateSetting()
		{
		}

		// Token: 0x0601F271 RID: 127601 RVA: 0x009278B0 File Offset: 0x00925AB0
		protected override IntPtr GetUStructPtr()
		{
			return SUiModelRotateSetting.StaticStruct();
		}

		// Token: 0x0601F272 RID: 127602 RVA: 0x009278BC File Offset: 0x00925ABC
		[NullableContext(2)]
		public SUiModelRotateSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F273 RID: 127603 RVA: 0x009278C6 File Offset: 0x00925AC6
		public SUiModelRotateSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F274 RID: 127604 RVA: 0x009278D1 File Offset: 0x00925AD1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiModelRotateSetting(Pointer, false, true);
		}

		// Token: 0x0601F275 RID: 127605 RVA: 0x009278DB File Offset: 0x00925ADB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiModelRotateSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04010A60 RID: 68192
		public const string __ObjectPath = "/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting";

		// Token: 0x04010A61 RID: 68193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A62 RID: 68194
		internal static int __PropertyOffset_旋转中轴;

		// Token: 0x04010A63 RID: 68195
		internal static int __PropertyOffset_旋转偏移;

		// Token: 0x04010A64 RID: 68196
		internal static int __PropertyOffset_模型Yaw灵敏度系数;

		// Token: 0x04010A65 RID: 68197
		internal static int __PropertyOffset_模型Pitch灵敏度系数;

		// Token: 0x04010A66 RID: 68198
		internal static int __PropertyOffset_Yaw限制Min;

		// Token: 0x04010A67 RID: 68199
		internal static int __PropertyOffset_Yaw限制Max;

		// Token: 0x04010A68 RID: 68200
		internal static int __PropertyOffset_Pitch限制Min;

		// Token: 0x04010A69 RID: 68201
		internal static int __PropertyOffset_Pitch限制Max;

		// Token: 0x04010A6A RID: 68202
		internal static int __PropertyOffset_最小臂长;

		// Token: 0x04010A6B RID: 68203
		internal static int __PropertyOffset_最大臂长;

		// Token: 0x04010A6C RID: 68204
		internal static int __PropertyOffset_倍化手柄输入倍率;

		// Token: 0x04010A6D RID: 68205
		internal static int __PropertyOffset_移动端旋转输入倍率;
	}
}
