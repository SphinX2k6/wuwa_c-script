using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003E9C RID: 16028
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleGrowthInfo.SRoleGrowthInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SRoleGrowthInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028879 RID: 166009 RVA: 0x009AE740 File Offset: 0x009AC940
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleGrowthInfo._ScriptStructPtr != 0) ? SRoleGrowthInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleGrowthInfo.SRoleGrowthInfo", ref SRoleGrowthInfo._ScriptStructPtr);
		}

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x0602887A RID: 166010 RVA: 0x009AE764 File Offset: 0x009AC964
		// (set) Token: 0x0602887B RID: 166011 RVA: 0x009AE774 File Offset: 0x009AC974
		public unsafe int 增幅组Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x0602887C RID: 166012 RVA: 0x009AE785 File Offset: 0x009AC985
		// (set) Token: 0x0602887D RID: 166013 RVA: 0x009AE799 File Offset: 0x009AC999
		public unsafe FName 增幅名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x0602887E RID: 166014 RVA: 0x009AE7AE File Offset: 0x009AC9AE
		// (set) Token: 0x0602887F RID: 166015 RVA: 0x009AE7BE File Offset: 0x009AC9BE
		public unsafe int 增幅等级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x06028880 RID: 166016 RVA: 0x009AE7D0 File Offset: 0x009AC9D0
		// (set) Token: 0x06028881 RID: 166017 RVA: 0x009AE813 File Offset: 0x009ACA13
		public TArray<int> 增幅效果Id列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._增幅效果Id列表) == null)
				{
					result = (this._增幅效果Id列表 = new TArray<int>(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.增幅效果Id列表.CopyAssign(value);
			}
		}

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x06028882 RID: 166018 RVA: 0x009AE821 File Offset: 0x009ACA21
		// (set) Token: 0x06028883 RID: 166019 RVA: 0x009AE835 File Offset: 0x009ACA35
		public unsafe FName 增幅效果描述
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x06028884 RID: 166020 RVA: 0x009AE84A File Offset: 0x009ACA4A
		// (set) Token: 0x06028885 RID: 166021 RVA: 0x009AE85A File Offset: 0x009ACA5A
		public unsafe int 增幅消耗Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleGrowthInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06028886 RID: 166022 RVA: 0x009AE86B File Offset: 0x009ACA6B
		public SRoleGrowthInfo()
		{
		}

		// Token: 0x06028887 RID: 166023 RVA: 0x009AE873 File Offset: 0x009ACA73
		public SRoleGrowthInfo(int 增幅组Id, FName 增幅名称, int 增幅等级, TArray<int> 增幅效果Id列表, FName 增幅效果描述, int 增幅消耗Id)
		{
			this.增幅组Id = 增幅组Id;
			this.增幅名称 = 增幅名称;
			this.增幅等级 = 增幅等级;
			this.增幅效果Id列表 = 增幅效果Id列表;
			this.增幅效果描述 = 增幅效果描述;
			this.增幅消耗Id = 增幅消耗Id;
		}

		// Token: 0x06028888 RID: 166024 RVA: 0x009AE8A8 File Offset: 0x009ACAA8
		protected override IntPtr GetUStructPtr()
		{
			return SRoleGrowthInfo.StaticStruct();
		}

		// Token: 0x06028889 RID: 166025 RVA: 0x009AE8B4 File Offset: 0x009ACAB4
		[NullableContext(2)]
		public SRoleGrowthInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602888A RID: 166026 RVA: 0x009AE8BE File Offset: 0x009ACABE
		public SRoleGrowthInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602888B RID: 166027 RVA: 0x009AE8C9 File Offset: 0x009ACAC9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleGrowthInfo(Pointer, false, true);
		}

		// Token: 0x0602888C RID: 166028 RVA: 0x009AE8D3 File Offset: 0x009ACAD3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleGrowthInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014ABF RID: 84671
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleGrowthInfo.SRoleGrowthInfo";

		// Token: 0x04014AC0 RID: 84672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AC1 RID: 84673
		internal static int __PropertyOffset_0;

		// Token: 0x04014AC2 RID: 84674
		internal static int __PropertyOffset_1;

		// Token: 0x04014AC3 RID: 84675
		internal static int __PropertyOffset_2;

		// Token: 0x04014AC4 RID: 84676
		internal static int __PropertyOffset_3;

		// Token: 0x04014AC5 RID: 84677
		[Nullable(2)]
		private TArray<int> _增幅效果Id列表;

		// Token: 0x04014AC6 RID: 84678
		internal static int __PropertyOffset_4;

		// Token: 0x04014AC7 RID: 84679
		internal static int __PropertyOffset_5;
	}
}
