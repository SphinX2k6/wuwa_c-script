using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AI.Struct
{
	// Token: 0x02003FBE RID: 16318
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/AI/Struct/SAIConfig.SAIConfig")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SAIConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C69 RID: 171113 RVA: 0x009CC3CE File Offset: 0x009CA5CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAIConfig._ScriptStructPtr != 0) ? SAIConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AI/Struct/SAIConfig.SAIConfig", ref SAIConfig._ScriptStructPtr);
		}

		// Token: 0x17006537 RID: 25911
		// (get) Token: 0x06029C6A RID: 171114 RVA: 0x009CC3F2 File Offset: 0x009CA5F2
		// (set) Token: 0x06029C6B RID: 171115 RVA: 0x009CC411 File Offset: 0x009CA611
		public TSoftClassPtr<AAIController> AIController
		{
			get
			{
				return new TSoftClassPtr<AAIController>(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006538 RID: 25912
		// (get) Token: 0x06029C6C RID: 171116 RVA: 0x009CC436 File Offset: 0x009CA636
		// (set) Token: 0x06029C6D RID: 171117 RVA: 0x009CC44A File Offset: 0x009CA64A
		[Nullable(0)]
		public unsafe TEnumAsByte<EActionPlan> 计划任务
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x06029C6E RID: 171118 RVA: 0x009CC45F File Offset: 0x009CA65F
		// (set) Token: 0x06029C6F RID: 171119 RVA: 0x009CC46F File Offset: 0x009CA66F
		public unsafe int 鸣萤寻路样条ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x06029C70 RID: 171120 RVA: 0x009CC480 File Offset: 0x009CA680
		// (set) Token: 0x06029C71 RID: 171121 RVA: 0x009CC490 File Offset: 0x009CA690
		public unsafe int 巡逻样条ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700653B RID: 25915
		// (get) Token: 0x06029C72 RID: 171122 RVA: 0x009CC4A1 File Offset: 0x009CA6A1
		// (set) Token: 0x06029C73 RID: 171123 RVA: 0x009CC4B1 File Offset: 0x009CA6B1
		public unsafe int PathPointList
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700653C RID: 25916
		// (get) Token: 0x06029C74 RID: 171124 RVA: 0x009CC4C2 File Offset: 0x009CA6C2
		// (set) Token: 0x06029C75 RID: 171125 RVA: 0x009CC4D6 File Offset: 0x009CA6D6
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAIConfig.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAIConfig.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x06029C76 RID: 171126 RVA: 0x009CC4EB File Offset: 0x009CA6EB
		public SAIConfig()
		{
		}

		// Token: 0x06029C77 RID: 171127 RVA: 0x009CC4F3 File Offset: 0x009CA6F3
		public SAIConfig(TSoftClassPtr<AAIController> AIController, [Nullable(0)] TEnumAsByte<EActionPlan> 计划任务, int 鸣萤寻路样条ID, int 巡逻样条ID, int PathPointList, string 备注)
		{
			this.AIController = AIController;
			this.计划任务 = 计划任务;
			this.鸣萤寻路样条ID = 鸣萤寻路样条ID;
			this.巡逻样条ID = 巡逻样条ID;
			this.PathPointList = PathPointList;
			this.备注 = 备注;
		}

		// Token: 0x06029C78 RID: 171128 RVA: 0x009CC528 File Offset: 0x009CA728
		protected override IntPtr GetUStructPtr()
		{
			return SAIConfig.StaticStruct();
		}

		// Token: 0x06029C79 RID: 171129 RVA: 0x009CC534 File Offset: 0x009CA734
		[NullableContext(2)]
		public SAIConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C7A RID: 171130 RVA: 0x009CC53E File Offset: 0x009CA73E
		public SAIConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C7B RID: 171131 RVA: 0x009CC549 File Offset: 0x009CA749
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAIConfig(Pointer, false, true);
		}

		// Token: 0x06029C7C RID: 171132 RVA: 0x009CC553 File Offset: 0x009CA753
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAIConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401573F RID: 87871
		public const string __ObjectPath = "/Game/Aki/Data/AI/Struct/SAIConfig.SAIConfig";

		// Token: 0x04015740 RID: 87872
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015741 RID: 87873
		internal static int __PropertyOffset_0;

		// Token: 0x04015742 RID: 87874
		internal static int __PropertyOffset_1;

		// Token: 0x04015743 RID: 87875
		internal static int __PropertyOffset_2;

		// Token: 0x04015744 RID: 87876
		internal static int __PropertyOffset_3;

		// Token: 0x04015745 RID: 87877
		internal static int __PropertyOffset_4;

		// Token: 0x04015746 RID: 87878
		internal static int __PropertyOffset_5;
	}
}
