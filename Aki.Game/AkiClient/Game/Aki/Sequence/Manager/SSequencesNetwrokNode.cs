using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Manager.Enum;
using AkiClient.Game.Aki.Sequence.Manager.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A32 RID: 14898
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/SSequencesNetwrokNode.SSequencesNetwrokNode")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class SSequencesNetwrokNode : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5EE RID: 128494 RVA: 0x008B6ADA File Offset: 0x008B4CDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequencesNetwrokNode._ScriptStructPtr != 0) ? SSequencesNetwrokNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/SSequencesNetwrokNode.SSequencesNetwrokNode", ref SSequencesNetwrokNode._ScriptStructPtr);
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0601F5EF RID: 128495 RVA: 0x008B6AFE File Offset: 0x008B4CFE
		// (set) Token: 0x0601F5F0 RID: 128496 RVA: 0x008B6B12 File Offset: 0x008B4D12
		public unsafe FName SeqNodeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0601F5F1 RID: 128497 RVA: 0x008B6B27 File Offset: 0x008B4D27
		// (set) Token: 0x0601F5F2 RID: 128498 RVA: 0x008B6B3B File Offset: 0x008B4D3B
		public unsafe FName PreSeqNodeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0601F5F3 RID: 128499 RVA: 0x008B6B50 File Offset: 0x008B4D50
		// (set) Token: 0x0601F5F4 RID: 128500 RVA: 0x008B6B93 File Offset: 0x008B4D93
		[Nullable(1)]
		public FSoftObjectPath SeqNodeData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SeqNodeData) == null)
				{
					result = (this._SeqNodeData = new FSoftObjectPath(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0601F5F5 RID: 128501 RVA: 0x008B6BB4 File Offset: 0x008B4DB4
		// (set) Token: 0x0601F5F6 RID: 128502 RVA: 0x008B6BC4 File Offset: 0x008B4DC4
		public unsafe bool 是否禁止输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0601F5F7 RID: 128503 RVA: 0x008B6BD5 File Offset: 0x008B4DD5
		// (set) Token: 0x0601F5F8 RID: 128504 RVA: 0x008B6BE5 File Offset: 0x008B4DE5
		public unsafe bool 是否禁止视角控制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0601F5F9 RID: 128505 RVA: 0x008B6BF6 File Offset: 0x008B4DF6
		// (set) Token: 0x0601F5FA RID: 128506 RVA: 0x008B6C06 File Offset: 0x008B4E06
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0601F5FB RID: 128507 RVA: 0x008B6C17 File Offset: 0x008B4E17
		// (set) Token: 0x0601F5FC RID: 128508 RVA: 0x008B6C27 File Offset: 0x008B4E27
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0601F5FD RID: 128509 RVA: 0x008B6C38 File Offset: 0x008B4E38
		// (set) Token: 0x0601F5FE RID: 128510 RVA: 0x008B6C4C File Offset: 0x008B4E4C
		public unsafe TEnumAsByte<ESeqSwtichType> 跳转类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0601F5FF RID: 128511 RVA: 0x008B6C64 File Offset: 0x008B4E64
		// (set) Token: 0x0601F600 RID: 128512 RVA: 0x008B6CA7 File Offset: 0x008B4EA7
		[Nullable(1)]
		public TArray<SSeqOptionJumpGroup> 选项跳转组
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SSeqOptionJumpGroup> result;
				if ((result = this._选项跳转组) == null)
				{
					result = (this._选项跳转组 = new TArray<SSeqOptionJumpGroup>(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.选项跳转组.CopyAssign(value);
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0601F601 RID: 128513 RVA: 0x008B6CB5 File Offset: 0x008B4EB5
		// (set) Token: 0x0601F602 RID: 128514 RVA: 0x008B6CC9 File Offset: 0x008B4EC9
		public unsafe TEnumAsByte<SeqCameraMode> 相机模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0601F603 RID: 128515 RVA: 0x008B6CDE File Offset: 0x008B4EDE
		// (set) Token: 0x0601F604 RID: 128516 RVA: 0x008B6CEE File Offset: 0x008B4EEE
		public unsafe bool 是否隐藏其他UI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0601F605 RID: 128517 RVA: 0x008B6CFF File Offset: 0x008B4EFF
		// (set) Token: 0x0601F606 RID: 128518 RVA: 0x008B6D0F File Offset: 0x008B4F0F
		public unsafe bool 是否可跳过
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0601F607 RID: 128519 RVA: 0x008B6D20 File Offset: 0x008B4F20
		// (set) Token: 0x0601F608 RID: 128520 RVA: 0x008B6D30 File Offset: 0x008B4F30
		public unsafe bool 是否可交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequencesNetwrokNode.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F609 RID: 128521 RVA: 0x008B6D41 File Offset: 0x008B4F41
		public SSequencesNetwrokNode()
		{
		}

		// Token: 0x0601F60A RID: 128522 RVA: 0x008B6D4C File Offset: 0x008B4F4C
		public SSequencesNetwrokNode(FName SeqNodeID, FName PreSeqNodeID, [Nullable(1)] FSoftObjectPath SeqNodeData, bool 是否禁止输入, bool 是否禁止视角控制, float BlendInTime, float BlendOutTime, TEnumAsByte<ESeqSwtichType> 跳转类型, [Nullable(1)] TArray<SSeqOptionJumpGroup> 选项跳转组, TEnumAsByte<SeqCameraMode> 相机模式, bool 是否隐藏其他UI, bool 是否可跳过, bool 是否可交互)
		{
			this.SeqNodeID = SeqNodeID;
			this.PreSeqNodeID = PreSeqNodeID;
			this.SeqNodeData = SeqNodeData;
			this.是否禁止输入 = 是否禁止输入;
			this.是否禁止视角控制 = 是否禁止视角控制;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.跳转类型 = 跳转类型;
			this.选项跳转组 = 选项跳转组;
			this.相机模式 = 相机模式;
			this.是否隐藏其他UI = 是否隐藏其他UI;
			this.是否可跳过 = 是否可跳过;
			this.是否可交互 = 是否可交互;
		}

		// Token: 0x0601F60B RID: 128523 RVA: 0x008B6DC4 File Offset: 0x008B4FC4
		protected override IntPtr GetUStructPtr()
		{
			return SSequencesNetwrokNode.StaticStruct();
		}

		// Token: 0x0601F60C RID: 128524 RVA: 0x008B6DD0 File Offset: 0x008B4FD0
		[NullableContext(2)]
		public SSequencesNetwrokNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F60D RID: 128525 RVA: 0x008B6DDA File Offset: 0x008B4FDA
		public SSequencesNetwrokNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F60E RID: 128526 RVA: 0x008B6DE5 File Offset: 0x008B4FE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequencesNetwrokNode(Pointer, false, true);
		}

		// Token: 0x0601F60F RID: 128527 RVA: 0x008B6DEF File Offset: 0x008B4FEF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequencesNetwrokNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400F103 RID: 61699
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/SSequencesNetwrokNode.SSequencesNetwrokNode";

		// Token: 0x0400F104 RID: 61700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F105 RID: 61701
		internal static int __PropertyOffset_0;

		// Token: 0x0400F106 RID: 61702
		internal static int __PropertyOffset_1;

		// Token: 0x0400F107 RID: 61703
		internal static int __PropertyOffset_2;

		// Token: 0x0400F108 RID: 61704
		[Nullable(2)]
		private FSoftObjectPath _SeqNodeData;

		// Token: 0x0400F109 RID: 61705
		internal static int __PropertyOffset_3;

		// Token: 0x0400F10A RID: 61706
		internal static int __PropertyOffset_4;

		// Token: 0x0400F10B RID: 61707
		internal static int __PropertyOffset_5;

		// Token: 0x0400F10C RID: 61708
		internal static int __PropertyOffset_6;

		// Token: 0x0400F10D RID: 61709
		internal static int __PropertyOffset_7;

		// Token: 0x0400F10E RID: 61710
		internal static int __PropertyOffset_8;

		// Token: 0x0400F10F RID: 61711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSeqOptionJumpGroup> _选项跳转组;

		// Token: 0x0400F110 RID: 61712
		internal static int __PropertyOffset_9;

		// Token: 0x0400F111 RID: 61713
		internal static int __PropertyOffset_10;

		// Token: 0x0400F112 RID: 61714
		internal static int __PropertyOffset_11;

		// Token: 0x0400F113 RID: 61715
		internal static int __PropertyOffset_12;
	}
}
