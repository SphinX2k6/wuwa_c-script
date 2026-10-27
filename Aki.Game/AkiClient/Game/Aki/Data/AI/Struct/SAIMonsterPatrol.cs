using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.AI.Struct
{
	// Token: 0x02003FBF RID: 16319
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/AI/Struct/SAIMonsterPatrol.SAIMonsterPatrol")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SAIMonsterPatrol : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C7D RID: 171133 RVA: 0x009CC55C File Offset: 0x009CA75C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAIMonsterPatrol._ScriptStructPtr != 0) ? SAIMonsterPatrol._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AI/Struct/SAIMonsterPatrol.SAIMonsterPatrol", ref SAIMonsterPatrol._ScriptStructPtr);
		}

		// Token: 0x1700653D RID: 25917
		// (get) Token: 0x06029C7E RID: 171134 RVA: 0x009CC580 File Offset: 0x009CA780
		// (set) Token: 0x06029C7F RID: 171135 RVA: 0x009CC594 File Offset: 0x009CA794
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_BasePathLine_C> 样条对象
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x06029C80 RID: 171136 RVA: 0x009CC5A9 File Offset: 0x009CA7A9
		// (set) Token: 0x06029C81 RID: 171137 RVA: 0x009CC5B9 File Offset: 0x009CA7B9
		public unsafe bool 巡逻开始
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x06029C82 RID: 171138 RVA: 0x009CC5CA File Offset: 0x009CA7CA
		// (set) Token: 0x06029C83 RID: 171139 RVA: 0x009CC5DA File Offset: 0x009CA7DA
		public unsafe bool 循环巡逻
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006540 RID: 25920
		// (get) Token: 0x06029C84 RID: 171140 RVA: 0x009CC5EB File Offset: 0x009CA7EB
		// (set) Token: 0x06029C85 RID: 171141 RVA: 0x009CC5FB File Offset: 0x009CA7FB
		public unsafe bool 巡逻反向移动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006541 RID: 25921
		// (get) Token: 0x06029C86 RID: 171142 RVA: 0x009CC60C File Offset: 0x009CA80C
		// (set) Token: 0x06029C87 RID: 171143 RVA: 0x009CC61C File Offset: 0x009CA81C
		public unsafe bool 巡逻初始化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006542 RID: 25922
		// (get) Token: 0x06029C88 RID: 171144 RVA: 0x009CC62D File Offset: 0x009CA82D
		// (set) Token: 0x06029C89 RID: 171145 RVA: 0x009CC641 File Offset: 0x009CA841
		[Nullable(2)]
		public unsafe TsBaseCharacter 巡逻限制NPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SAIMonsterPatrol.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAIMonsterPatrol.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006543 RID: 25923
		// (get) Token: 0x06029C8A RID: 171146 RVA: 0x009CC656 File Offset: 0x009CA856
		// (set) Token: 0x06029C8B RID: 171147 RVA: 0x009CC666 File Offset: 0x009CA866
		public unsafe float 巡逻限制NPC距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIMonsterPatrol.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06029C8C RID: 171148 RVA: 0x009CC677 File Offset: 0x009CA877
		public SAIMonsterPatrol()
		{
		}

		// Token: 0x06029C8D RID: 171149 RVA: 0x009CC67F File Offset: 0x009CA87F
		[NullableContext(1)]
		public SAIMonsterPatrol([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<BP_BasePathLine_C> 样条对象, bool 巡逻开始, bool 循环巡逻, bool 巡逻反向移动, bool 巡逻初始化, TsBaseCharacter 巡逻限制NPC, float 巡逻限制NPC距离)
		{
			this.样条对象 = 样条对象;
			this.巡逻开始 = 巡逻开始;
			this.循环巡逻 = 循环巡逻;
			this.巡逻反向移动 = 巡逻反向移动;
			this.巡逻初始化 = 巡逻初始化;
			this.巡逻限制NPC = 巡逻限制NPC;
			this.巡逻限制NPC距离 = 巡逻限制NPC距离;
		}

		// Token: 0x06029C8E RID: 171150 RVA: 0x009CC6BC File Offset: 0x009CA8BC
		protected override IntPtr GetUStructPtr()
		{
			return SAIMonsterPatrol.StaticStruct();
		}

		// Token: 0x06029C8F RID: 171151 RVA: 0x009CC6C8 File Offset: 0x009CA8C8
		[NullableContext(2)]
		public SAIMonsterPatrol(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C90 RID: 171152 RVA: 0x009CC6D2 File Offset: 0x009CA8D2
		public SAIMonsterPatrol(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C91 RID: 171153 RVA: 0x009CC6DD File Offset: 0x009CA8DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAIMonsterPatrol(Pointer, false, true);
		}

		// Token: 0x06029C92 RID: 171154 RVA: 0x009CC6E7 File Offset: 0x009CA8E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAIMonsterPatrol(Pointer, MemoryOwner);
		}

		// Token: 0x04015747 RID: 87879
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/AI/Struct/SAIMonsterPatrol.SAIMonsterPatrol";

		// Token: 0x04015748 RID: 87880
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015749 RID: 87881
		internal static int __PropertyOffset_0;

		// Token: 0x0401574A RID: 87882
		internal static int __PropertyOffset_1;

		// Token: 0x0401574B RID: 87883
		internal static int __PropertyOffset_2;

		// Token: 0x0401574C RID: 87884
		internal static int __PropertyOffset_3;

		// Token: 0x0401574D RID: 87885
		internal static int __PropertyOffset_4;

		// Token: 0x0401574E RID: 87886
		internal static int __PropertyOffset_5;

		// Token: 0x0401574F RID: 87887
		internal static int __PropertyOffset_6;
	}
}
