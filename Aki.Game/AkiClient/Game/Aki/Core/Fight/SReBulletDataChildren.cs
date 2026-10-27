using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004010 RID: 16400
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 22)]
	public class SReBulletDataChildren : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A044 RID: 172100 RVA: 0x009D36D8 File Offset: 0x009D18D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataChildren._ScriptStructPtr != 0) ? SReBulletDataChildren._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren", ref SReBulletDataChildren._ScriptStructPtr);
		}

		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x0602A045 RID: 172101 RVA: 0x009D36FC File Offset: 0x009D18FC
		// (set) Token: 0x0602A046 RID: 172102 RVA: 0x009D370C File Offset: 0x009D190C
		public unsafe long 召唤子弹ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x0602A047 RID: 172103 RVA: 0x009D371D File Offset: 0x009D191D
		// (set) Token: 0x0602A048 RID: 172104 RVA: 0x009D372D File Offset: 0x009D192D
		public unsafe float 召唤子弹延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x0602A049 RID: 172105 RVA: 0x009D373E File Offset: 0x009D193E
		// (set) Token: 0x0602A04A RID: 172106 RVA: 0x009D374E File Offset: 0x009D194E
		public unsafe int 召唤子弹数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x0602A04B RID: 172107 RVA: 0x009D375F File Offset: 0x009D195F
		// (set) Token: 0x0602A04C RID: 172108 RVA: 0x009D376F File Offset: 0x009D196F
		public unsafe float 召唤子弹间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x0602A04D RID: 172109 RVA: 0x009D3780 File Offset: 0x009D1980
		// (set) Token: 0x0602A04E RID: 172110 RVA: 0x009D3794 File Offset: 0x009D1994
		public unsafe TEnumAsByte<EBulletChildrenType> 召唤触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x0602A04F RID: 172111 RVA: 0x009D37A9 File Offset: 0x009D19A9
		// (set) Token: 0x0602A050 RID: 172112 RVA: 0x009D37B9 File Offset: 0x009D19B9
		public unsafe bool 失败是否停止
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataChildren.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A051 RID: 172113 RVA: 0x009D37CA File Offset: 0x009D19CA
		public SReBulletDataChildren()
		{
		}

		// Token: 0x0602A052 RID: 172114 RVA: 0x009D37D2 File Offset: 0x009D19D2
		public SReBulletDataChildren(long 召唤子弹ID, float 召唤子弹延迟, int 召唤子弹数量, float 召唤子弹间隔, TEnumAsByte<EBulletChildrenType> 召唤触发, bool 失败是否停止)
		{
			this.召唤子弹ID = 召唤子弹ID;
			this.召唤子弹延迟 = 召唤子弹延迟;
			this.召唤子弹数量 = 召唤子弹数量;
			this.召唤子弹间隔 = 召唤子弹间隔;
			this.召唤触发 = 召唤触发;
			this.失败是否停止 = 失败是否停止;
		}

		// Token: 0x0602A053 RID: 172115 RVA: 0x009D3807 File Offset: 0x009D1A07
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataChildren.StaticStruct();
		}

		// Token: 0x0602A054 RID: 172116 RVA: 0x009D3813 File Offset: 0x009D1A13
		[NullableContext(2)]
		public SReBulletDataChildren(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A055 RID: 172117 RVA: 0x009D381D File Offset: 0x009D1A1D
		public SReBulletDataChildren(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A056 RID: 172118 RVA: 0x009D3828 File Offset: 0x009D1A28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataChildren(Pointer, false, true);
		}

		// Token: 0x0602A057 RID: 172119 RVA: 0x009D3832 File Offset: 0x009D1A32
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataChildren(Pointer, MemoryOwner);
		}

		// Token: 0x04015A33 RID: 88627
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataChildren.SReBulletDataChildren";

		// Token: 0x04015A34 RID: 88628
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A35 RID: 88629
		internal static int __PropertyOffset_0;

		// Token: 0x04015A36 RID: 88630
		internal static int __PropertyOffset_1;

		// Token: 0x04015A37 RID: 88631
		internal static int __PropertyOffset_2;

		// Token: 0x04015A38 RID: 88632
		internal static int __PropertyOffset_3;

		// Token: 0x04015A39 RID: 88633
		internal static int __PropertyOffset_4;

		// Token: 0x04015A3A RID: 88634
		internal static int __PropertyOffset_5;
	}
}
