using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003273 RID: 12915
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class SReBulletDataExe : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020410 RID: 132112 RVA: 0x00941178 File Offset: 0x0093F378
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataExe._ScriptStructPtr != 0) ? SReBulletDataExe._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe", ref SReBulletDataExe._ScriptStructPtr);
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x06020411 RID: 132113 RVA: 0x0094119C File Offset: 0x0093F39C
		// (set) Token: 0x06020412 RID: 132114 RVA: 0x009411B0 File Offset: 0x0093F3B0
		public unsafe FGameplayTag 生成时对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_生成时对攻击者发射GameplayEvent标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_生成时对攻击者发射GameplayEvent标签) = value;
			}
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x06020413 RID: 132115 RVA: 0x009411C5 File Offset: 0x0093F3C5
		// (set) Token: 0x06020414 RID: 132116 RVA: 0x009411D9 File Offset: 0x0093F3D9
		public unsafe FGameplayTag 命中后对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对攻击者发射GameplayEvent标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对攻击者发射GameplayEvent标签) = value;
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x06020415 RID: 132117 RVA: 0x009411EE File Offset: 0x0093F3EE
		// (set) Token: 0x06020416 RID: 132118 RVA: 0x00941202 File Offset: 0x0093F402
		public unsafe FGameplayTag 命中后对受击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对受击者发射GameplayEvent标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对受击者发射GameplayEvent标签) = value;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x06020417 RID: 132119 RVA: 0x00941217 File Offset: 0x0093F417
		// (set) Token: 0x06020418 RID: 132120 RVA: 0x0094122B File Offset: 0x0093F42B
		public unsafe FGameplayTag 结束时对攻击者发射GameplayEvent标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_结束时对攻击者发射GameplayEvent标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_结束时对攻击者发射GameplayEvent标签) = value;
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x06020419 RID: 132121 RVA: 0x00941240 File Offset: 0x0093F440
		// (set) Token: 0x0602041A RID: 132122 RVA: 0x00941283 File Offset: 0x0093F483
		public TArray<long> 命中后对攻击者应用GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对攻击者应用GE的Id) == null)
				{
					result = (this._命中后对攻击者应用GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对攻击者应用GE的Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对攻击者应用GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0602041B RID: 132123 RVA: 0x00941294 File Offset: 0x0093F494
		// (set) Token: 0x0602041C RID: 132124 RVA: 0x009412D7 File Offset: 0x0093F4D7
		public TArray<long> 命中后对受击者应用GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对受击者应用GE的Id) == null)
				{
					result = (this._命中后对受击者应用GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对受击者应用GE的Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对受击者应用GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0602041D RID: 132125 RVA: 0x009412E8 File Offset: 0x0093F4E8
		// (set) Token: 0x0602041E RID: 132126 RVA: 0x0094132B File Offset: 0x0093F52B
		public TArray<long> 能量恢复类GE数组的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._能量恢复类GE数组的Id) == null)
				{
					result = (this._能量恢复类GE数组的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_能量恢复类GE数组的Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.能量恢复类GE数组的Id.CopyAssign(value);
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0602041F RID: 132127 RVA: 0x0094133C File Offset: 0x0093F53C
		// (set) Token: 0x06020420 RID: 132128 RVA: 0x0094137F File Offset: 0x0093F57F
		public TArray<long> 命中后对在场上角色应用的GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._命中后对在场上角色应用的GE的Id) == null)
				{
					result = (this._命中后对在场上角色应用的GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_命中后对在场上角色应用的GE的Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对在场上角色应用的GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x06020421 RID: 132129 RVA: 0x00941390 File Offset: 0x0093F590
		// (set) Token: 0x06020422 RID: 132130 RVA: 0x009413D3 File Offset: 0x0093F5D3
		public TArray<long> 受击对象进入应用的GE的Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._受击对象进入应用的GE的Id) == null)
				{
					result = (this._受击对象进入应用的GE的Id = new TArray<long>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_受击对象进入应用的GE的Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.受击对象进入应用的GE的Id.CopyAssign(value);
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x06020423 RID: 132131 RVA: 0x009413E1 File Offset: 0x0093F5E1
		// (set) Token: 0x06020424 RID: 132132 RVA: 0x009413F1 File Offset: 0x0093F5F1
		public unsafe bool 等待回包过程中不重复触发进入GE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_等待回包过程中不重复触发进入GE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_等待回包过程中不重复触发进入GE) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x06020425 RID: 132133 RVA: 0x00941404 File Offset: 0x0093F604
		// (set) Token: 0x06020426 RID: 132134 RVA: 0x00941447 File Offset: 0x0093F647
		public FGameplayTagContainer 受击对象进入添加Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._受击对象进入添加Tag) == null)
				{
					result = (this._受击对象进入添加Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_受击对象进入添加Tag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_受击对象进入添加Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x06020427 RID: 132135 RVA: 0x00941468 File Offset: 0x0093F668
		// (set) Token: 0x06020428 RID: 132136 RVA: 0x00941487 File Offset: 0x0093F687
		public TSoftObjectPtr<UKuroBpDataAssetGroup> GB组
		{
			get
			{
				return new TSoftObjectPtr<UKuroBpDataAssetGroup>(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_GB组, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataExe.__PropertyOffset_GB组, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06020429 RID: 132137 RVA: 0x009414AC File Offset: 0x0093F6AC
		public SReBulletDataExe()
		{
		}

		// Token: 0x0602042A RID: 132138 RVA: 0x009414B4 File Offset: 0x0093F6B4
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataExe.StaticStruct();
		}

		// Token: 0x0602042B RID: 132139 RVA: 0x009414C0 File Offset: 0x0093F6C0
		[NullableContext(2)]
		public SReBulletDataExe(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602042C RID: 132140 RVA: 0x009414CA File Offset: 0x0093F6CA
		public SReBulletDataExe(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602042D RID: 132141 RVA: 0x009414D5 File Offset: 0x0093F6D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataExe(Pointer, false, true);
		}

		// Token: 0x0602042E RID: 132142 RVA: 0x009414DF File Offset: 0x0093F6DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataExe(Pointer, MemoryOwner);
		}

		// Token: 0x04011692 RID: 71314
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataExe.SReBulletDataExe";

		// Token: 0x04011693 RID: 71315
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011694 RID: 71316
		internal static int __PropertyOffset_生成时对攻击者发射GameplayEvent标签;

		// Token: 0x04011695 RID: 71317
		internal static int __PropertyOffset_命中后对攻击者发射GameplayEvent标签;

		// Token: 0x04011696 RID: 71318
		internal static int __PropertyOffset_命中后对受击者发射GameplayEvent标签;

		// Token: 0x04011697 RID: 71319
		internal static int __PropertyOffset_结束时对攻击者发射GameplayEvent标签;

		// Token: 0x04011698 RID: 71320
		internal static int __PropertyOffset_命中后对攻击者应用GE的Id;

		// Token: 0x04011699 RID: 71321
		[Nullable(2)]
		private TArray<long> _命中后对攻击者应用GE的Id;

		// Token: 0x0401169A RID: 71322
		internal static int __PropertyOffset_命中后对受击者应用GE的Id;

		// Token: 0x0401169B RID: 71323
		[Nullable(2)]
		private TArray<long> _命中后对受击者应用GE的Id;

		// Token: 0x0401169C RID: 71324
		internal static int __PropertyOffset_能量恢复类GE数组的Id;

		// Token: 0x0401169D RID: 71325
		[Nullable(2)]
		private TArray<long> _能量恢复类GE数组的Id;

		// Token: 0x0401169E RID: 71326
		internal static int __PropertyOffset_命中后对在场上角色应用的GE的Id;

		// Token: 0x0401169F RID: 71327
		[Nullable(2)]
		private TArray<long> _命中后对在场上角色应用的GE的Id;

		// Token: 0x040116A0 RID: 71328
		internal static int __PropertyOffset_受击对象进入应用的GE的Id;

		// Token: 0x040116A1 RID: 71329
		[Nullable(2)]
		private TArray<long> _受击对象进入应用的GE的Id;

		// Token: 0x040116A2 RID: 71330
		internal static int __PropertyOffset_等待回包过程中不重复触发进入GE;

		// Token: 0x040116A3 RID: 71331
		internal static int __PropertyOffset_受击对象进入添加Tag;

		// Token: 0x040116A4 RID: 71332
		[Nullable(2)]
		private FGameplayTagContainer _受击对象进入添加Tag;

		// Token: 0x040116A5 RID: 71333
		internal static int __PropertyOffset_GB组;
	}
}
