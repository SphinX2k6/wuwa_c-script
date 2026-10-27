using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004012 RID: 16402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class SReBulletDataExe : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A05F RID: 172127 RVA: 0x009D38E4 File Offset: 0x009D1AE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataExe._ScriptStructPtr != 0) ? SReBulletDataExe._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe", ref SReBulletDataExe._ScriptStructPtr);
		}

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x0602A060 RID: 172128 RVA: 0x009D3908 File Offset: 0x009D1B08
		// (set) Token: 0x0602A061 RID: 172129 RVA: 0x009D391C File Offset: 0x009D1B1C
		public unsafe FGameplayTag 生成时对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x0602A062 RID: 172130 RVA: 0x009D3931 File Offset: 0x009D1B31
		// (set) Token: 0x0602A063 RID: 172131 RVA: 0x009D3945 File Offset: 0x009D1B45
		public unsafe FGameplayTag 命中后对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x0602A064 RID: 172132 RVA: 0x009D395A File Offset: 0x009D1B5A
		// (set) Token: 0x0602A065 RID: 172133 RVA: 0x009D396E File Offset: 0x009D1B6E
		public unsafe FGameplayTag 命中后对受击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x0602A066 RID: 172134 RVA: 0x009D3983 File Offset: 0x009D1B83
		// (set) Token: 0x0602A067 RID: 172135 RVA: 0x009D3997 File Offset: 0x009D1B97
		public unsafe FGameplayTag 结束时对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x0602A068 RID: 172136 RVA: 0x009D39AC File Offset: 0x009D1BAC
		// (set) Token: 0x0602A069 RID: 172137 RVA: 0x009D39EF File Offset: 0x009D1BEF
		public TArray<long> 命中后对攻击者应用GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对攻击者应用GE的Id) == null)
				{
					result = (this._命中后对攻击者应用GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对攻击者应用GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x0602A06A RID: 172138 RVA: 0x009D3A00 File Offset: 0x009D1C00
		// (set) Token: 0x0602A06B RID: 172139 RVA: 0x009D3A43 File Offset: 0x009D1C43
		public TArray<long> 命中后对受击者应用GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对受击者应用GE的Id) == null)
				{
					result = (this._命中后对受击者应用GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对受击者应用GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x0602A06C RID: 172140 RVA: 0x009D3A54 File Offset: 0x009D1C54
		// (set) Token: 0x0602A06D RID: 172141 RVA: 0x009D3A97 File Offset: 0x009D1C97
		public TArray<long> 能量恢复类GE数组的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._能量恢复类GE数组的Id) == null)
				{
					result = (this._能量恢复类GE数组的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.能量恢复类GE数组的Id.CopyAssign(value);
			}
		}

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x0602A06E RID: 172142 RVA: 0x009D3AA8 File Offset: 0x009D1CA8
		// (set) Token: 0x0602A06F RID: 172143 RVA: 0x009D3AEB File Offset: 0x009D1CEB
		public TArray<long> 命中后对在场上角色应用的GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对在场上角色应用的GE的Id) == null)
				{
					result = (this._命中后对在场上角色应用的GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对在场上角色应用的GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x0602A070 RID: 172144 RVA: 0x009D3AFC File Offset: 0x009D1CFC
		// (set) Token: 0x0602A071 RID: 172145 RVA: 0x009D3B3F File Offset: 0x009D1D3F
		public TArray<long> 受击对象进入应用的GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._受击对象进入应用的GE的Id) == null)
				{
					result = (this._受击对象进入应用的GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.受击对象进入应用的GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x0602A072 RID: 172146 RVA: 0x009D3B4D File Offset: 0x009D1D4D
		// (set) Token: 0x0602A073 RID: 172147 RVA: 0x009D3B5D File Offset: 0x009D1D5D
		public unsafe bool 等待回包过程中不重复触发进入GE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x0602A074 RID: 172148 RVA: 0x009D3B70 File Offset: 0x009D1D70
		// (set) Token: 0x0602A075 RID: 172149 RVA: 0x009D3BB3 File Offset: 0x009D1DB3
		public FGameplayTagContainer 受击对象进入添加Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._受击对象进入添加Tag) == null)
				{
					result = (this._受击对象进入添加Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x0602A076 RID: 172150 RVA: 0x009D3BD4 File Offset: 0x009D1DD4
		// (set) Token: 0x0602A077 RID: 172151 RVA: 0x009D3BF3 File Offset: 0x009D1DF3
		public TSoftObjectPtr<UKuroBpDataAssetGroup> GB组
		{
			get
			{
				return new TSoftObjectPtr<UKuroBpDataAssetGroup>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602A078 RID: 172152 RVA: 0x009D3C18 File Offset: 0x009D1E18
		public SReBulletDataExe()
		{
		}

		// Token: 0x0602A079 RID: 172153 RVA: 0x009D3C20 File Offset: 0x009D1E20
		public SReBulletDataExe(FGameplayTag 生成时对攻击者发射GameplayEvent标签, FGameplayTag 命中后对攻击者发射GameplayEvent标签, FGameplayTag 命中后对受击者发射GameplayEvent标签, FGameplayTag 结束时对攻击者发射GameplayEvent标签, TArray<long> 命中后对攻击者应用GE的Id, TArray<long> 命中后对受击者应用GE的Id, TArray<long> 能量恢复类GE数组的Id, TArray<long> 命中后对在场上角色应用的GE的Id, TArray<long> 受击对象进入应用的GE的Id, bool 等待回包过程中不重复触发进入GE, FGameplayTagContainer 受击对象进入添加Tag, TSoftObjectPtr<UKuroBpDataAssetGroup> GB组)
		{
			this.生成时对攻击者发射GameplayEvent标签 = 生成时对攻击者发射GameplayEvent标签;
			this.命中后对攻击者发射GameplayEvent标签 = 命中后对攻击者发射GameplayEvent标签;
			this.命中后对受击者发射GameplayEvent标签 = 命中后对受击者发射GameplayEvent标签;
			this.结束时对攻击者发射GameplayEvent标签 = 结束时对攻击者发射GameplayEvent标签;
			this.命中后对攻击者应用GE的Id = 命中后对攻击者应用GE的Id;
			this.命中后对受击者应用GE的Id = 命中后对受击者应用GE的Id;
			this.能量恢复类GE数组的Id = 能量恢复类GE数组的Id;
			this.命中后对在场上角色应用的GE的Id = 命中后对在场上角色应用的GE的Id;
			this.受击对象进入应用的GE的Id = 受击对象进入应用的GE的Id;
			this.等待回包过程中不重复触发进入GE = 等待回包过程中不重复触发进入GE;
			this.受击对象进入添加Tag = 受击对象进入添加Tag;
			this.GB组 = GB组;
		}

		// Token: 0x0602A07A RID: 172154 RVA: 0x009D3C90 File Offset: 0x009D1E90
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataExe.StaticStruct();
		}

		// Token: 0x0602A07B RID: 172155 RVA: 0x009D3C9C File Offset: 0x009D1E9C
		[NullableContext(2)]
		public SReBulletDataExe(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A07C RID: 172156 RVA: 0x009D3CA6 File Offset: 0x009D1EA6
		public SReBulletDataExe(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A07D RID: 172157 RVA: 0x009D3CB1 File Offset: 0x009D1EB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataExe(Pointer, false, true);
		}

		// Token: 0x0602A07E RID: 172158 RVA: 0x009D3CBB File Offset: 0x009D1EBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataExe(Pointer, MemoryOwner);
		}

		// Token: 0x04015A3F RID: 88639
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe";

		// Token: 0x04015A40 RID: 88640
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A41 RID: 88641
		internal static int __PropertyOffset_0;

		// Token: 0x04015A42 RID: 88642
		internal static int __PropertyOffset_1;

		// Token: 0x04015A43 RID: 88643
		internal static int __PropertyOffset_2;

		// Token: 0x04015A44 RID: 88644
		internal static int __PropertyOffset_3;

		// Token: 0x04015A45 RID: 88645
		internal static int __PropertyOffset_4;

		// Token: 0x04015A46 RID: 88646
		[Nullable(2)]
		private TArray<long> _命中后对攻击者应用GE的Id;

		// Token: 0x04015A47 RID: 88647
		internal static int __PropertyOffset_5;

		// Token: 0x04015A48 RID: 88648
		[Nullable(2)]
		private TArray<long> _命中后对受击者应用GE的Id;

		// Token: 0x04015A49 RID: 88649
		internal static int __PropertyOffset_6;

		// Token: 0x04015A4A RID: 88650
		[Nullable(2)]
		private TArray<long> _能量恢复类GE数组的Id;

		// Token: 0x04015A4B RID: 88651
		internal static int __PropertyOffset_7;

		// Token: 0x04015A4C RID: 88652
		[Nullable(2)]
		private TArray<long> _命中后对在场上角色应用的GE的Id;

		// Token: 0x04015A4D RID: 88653
		internal static int __PropertyOffset_8;

		// Token: 0x04015A4E RID: 88654
		[Nullable(2)]
		private TArray<long> _受击对象进入应用的GE的Id;

		// Token: 0x04015A4F RID: 88655
		internal static int __PropertyOffset_9;

		// Token: 0x04015A50 RID: 88656
		internal static int __PropertyOffset_10;

		// Token: 0x04015A51 RID: 88657
		[Nullable(2)]
		private FGameplayTagContainer _受击对象进入添加Tag;

		// Token: 0x04015A52 RID: 88658
		internal static int __PropertyOffset_11;
	}
}
