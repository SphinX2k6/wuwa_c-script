using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F72 RID: 16242
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SReBullDataBase_SubStructTest.SReBullDataBase_SubStructTest")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SReBullDataBase_SubStructTest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060296D2 RID: 169682 RVA: 0x009C3DF4 File Offset: 0x009C1FF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBullDataBase_SubStructTest._ScriptStructPtr != 0) ? SReBullDataBase_SubStructTest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SReBullDataBase_SubStructTest.SReBullDataBase_SubStructTest", ref SReBullDataBase_SubStructTest._ScriptStructPtr);
		}

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x060296D3 RID: 169683 RVA: 0x009C3E18 File Offset: 0x009C2018
		// (set) Token: 0x060296D4 RID: 169684 RVA: 0x009C3E28 File Offset: 0x009C2028
		public unsafe bool 子弹新增结构布尔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x060296D5 RID: 169685 RVA: 0x009C3E39 File Offset: 0x009C2039
		// (set) Token: 0x060296D6 RID: 169686 RVA: 0x009C3E49 File Offset: 0x009C2049
		public unsafe float 子弹新增结构浮点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x060296D7 RID: 169687 RVA: 0x009C3E5C File Offset: 0x009C205C
		// (set) Token: 0x060296D8 RID: 169688 RVA: 0x009C3E9F File Offset: 0x009C209F
		public SReBulletDataScale 子弹新增结构字符串
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataScale result;
				if ((result = this._子弹新增结构字符串) == null)
				{
					result = (this._子弹新增结构字符串 = new SReBulletDataScale(base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataScale.StaticStruct(), base.NativePtr + (IntPtr)SReBullDataBase_SubStructTest.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060296D9 RID: 169689 RVA: 0x009C3EC0 File Offset: 0x009C20C0
		public SReBullDataBase_SubStructTest()
		{
		}

		// Token: 0x060296DA RID: 169690 RVA: 0x009C3EC8 File Offset: 0x009C20C8
		public SReBullDataBase_SubStructTest(bool 子弹新增结构布尔, float 子弹新增结构浮点, SReBulletDataScale 子弹新增结构字符串)
		{
			this.子弹新增结构布尔 = 子弹新增结构布尔;
			this.子弹新增结构浮点 = 子弹新增结构浮点;
			this.子弹新增结构字符串 = 子弹新增结构字符串;
		}

		// Token: 0x060296DB RID: 169691 RVA: 0x009C3EE5 File Offset: 0x009C20E5
		protected override IntPtr GetUStructPtr()
		{
			return SReBullDataBase_SubStructTest.StaticStruct();
		}

		// Token: 0x060296DC RID: 169692 RVA: 0x009C3EF1 File Offset: 0x009C20F1
		[NullableContext(2)]
		public SReBullDataBase_SubStructTest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060296DD RID: 169693 RVA: 0x009C3EFB File Offset: 0x009C20FB
		public SReBullDataBase_SubStructTest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060296DE RID: 169694 RVA: 0x009C3F06 File Offset: 0x009C2106
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBullDataBase_SubStructTest(Pointer, false, true);
		}

		// Token: 0x060296DF RID: 169695 RVA: 0x009C3F10 File Offset: 0x009C2110
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBullDataBase_SubStructTest(Pointer, MemoryOwner);
		}

		// Token: 0x0401539A RID: 86938
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SReBullDataBase_SubStructTest.SReBullDataBase_SubStructTest";

		// Token: 0x0401539B RID: 86939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401539C RID: 86940
		internal static int __PropertyOffset_0;

		// Token: 0x0401539D RID: 86941
		internal static int __PropertyOffset_1;

		// Token: 0x0401539E RID: 86942
		internal static int __PropertyOffset_2;

		// Token: 0x0401539F RID: 86943
		[Nullable(2)]
		private SReBulletDataScale _子弹新增结构字符串;
	}
}
