using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.DT
{
	// Token: 0x020040B7 RID: 16567
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/DT/SPerformanceRoleInfo.SPerformanceRoleInfo")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SPerformanceRoleInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602ACA6 RID: 175270 RVA: 0x009EB6BD File Offset: 0x009E98BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPerformanceRoleInfo._ScriptStructPtr != 0) ? SPerformanceRoleInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/DT/SPerformanceRoleInfo.SPerformanceRoleInfo", ref SPerformanceRoleInfo._ScriptStructPtr);
		}

		// Token: 0x17006986 RID: 27014
		// (get) Token: 0x0602ACA7 RID: 175271 RVA: 0x009EB6E1 File Offset: 0x009E98E1
		// (set) Token: 0x0602ACA8 RID: 175272 RVA: 0x009EB6F1 File Offset: 0x009E98F1
		public unsafe float SkillRotateIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPerformanceRoleInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPerformanceRoleInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006987 RID: 27015
		// (get) Token: 0x0602ACA9 RID: 175273 RVA: 0x009EB702 File Offset: 0x009E9902
		// (set) Token: 0x0602ACAA RID: 175274 RVA: 0x009EB712 File Offset: 0x009E9912
		public unsafe float SkillRotateOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPerformanceRoleInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPerformanceRoleInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602ACAB RID: 175275 RVA: 0x009EB723 File Offset: 0x009E9923
		public SPerformanceRoleInfo()
		{
		}

		// Token: 0x0602ACAC RID: 175276 RVA: 0x009EB72B File Offset: 0x009E992B
		public SPerformanceRoleInfo(float SkillRotateIn, float SkillRotateOut)
		{
			this.SkillRotateIn = SkillRotateIn;
			this.SkillRotateOut = SkillRotateOut;
		}

		// Token: 0x0602ACAD RID: 175277 RVA: 0x009EB741 File Offset: 0x009E9941
		protected override IntPtr GetUStructPtr()
		{
			return SPerformanceRoleInfo.StaticStruct();
		}

		// Token: 0x0602ACAE RID: 175278 RVA: 0x009EB74D File Offset: 0x009E994D
		[NullableContext(2)]
		public SPerformanceRoleInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602ACAF RID: 175279 RVA: 0x009EB757 File Offset: 0x009E9957
		public SPerformanceRoleInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602ACB0 RID: 175280 RVA: 0x009EB762 File Offset: 0x009E9962
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPerformanceRoleInfo(Pointer, false, true);
		}

		// Token: 0x0602ACB1 RID: 175281 RVA: 0x009EB76C File Offset: 0x009E996C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPerformanceRoleInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04016284 RID: 90756
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/DT/SPerformanceRoleInfo.SPerformanceRoleInfo";

		// Token: 0x04016285 RID: 90757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016286 RID: 90758
		internal static int __PropertyOffset_0;

		// Token: 0x04016287 RID: 90759
		internal static int __PropertyOffset_1;
	}
}
