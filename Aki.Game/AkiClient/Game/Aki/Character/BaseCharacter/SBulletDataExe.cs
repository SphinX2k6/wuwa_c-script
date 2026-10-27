using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GB;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F7 RID: 17143
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataExe.SBulletDataExe")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class SBulletDataExe : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C49E RID: 181406 RVA: 0x00A1C312 File Offset: 0x00A1A512
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataExe._ScriptStructPtr != 0) ? SBulletDataExe._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataExe.SBulletDataExe", ref SBulletDataExe._ScriptStructPtr);
		}

		// Token: 0x17006E8B RID: 28299
		// (get) Token: 0x0602C49F RID: 181407 RVA: 0x00A1C336 File Offset: 0x00A1A536
		// (set) Token: 0x0602C4A0 RID: 181408 RVA: 0x00A1C355 File Offset: 0x00A1A555
		public TSoftClassPtr<BP_BulletLogicBase_C> 命中执行逻辑
		{
			get
			{
				return new TSoftClassPtr<BP_BulletLogicBase_C>(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E8C RID: 28300
		// (get) Token: 0x0602C4A1 RID: 181409 RVA: 0x00A1C37A File Offset: 0x00A1A57A
		// (set) Token: 0x0602C4A2 RID: 181410 RVA: 0x00A1C399 File Offset: 0x00A1A599
		public TSoftClassPtr<BP_BulletLogicBase_C> 更新执行逻辑
		{
			get
			{
				return new TSoftClassPtr<BP_BulletLogicBase_C>(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E8D RID: 28301
		// (get) Token: 0x0602C4A3 RID: 181411 RVA: 0x00A1C3C0 File Offset: 0x00A1A5C0
		// (set) Token: 0x0602C4A4 RID: 181412 RVA: 0x00A1C403 File Offset: 0x00A1A603
		public TArray<SBulletGE> 命中后对攻击者应用GE类数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletGE> result;
				if ((result = this._命中后对攻击者应用GE类数组) == null)
				{
					result = (this._命中后对攻击者应用GE类数组 = new TArray<SBulletGE>(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对攻击者应用GE类数组.CopyAssign(value);
			}
		}

		// Token: 0x17006E8E RID: 28302
		// (get) Token: 0x0602C4A5 RID: 181413 RVA: 0x00A1C414 File Offset: 0x00A1A614
		// (set) Token: 0x0602C4A6 RID: 181414 RVA: 0x00A1C457 File Offset: 0x00A1A657
		public TArray<SBulletGE> 命中后对受击者应用GE类数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletGE> result;
				if ((result = this._命中后对受击者应用GE类数组) == null)
				{
					result = (this._命中后对受击者应用GE类数组 = new TArray<SBulletGE>(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中后对受击者应用GE类数组.CopyAssign(value);
			}
		}

		// Token: 0x17006E8F RID: 28303
		// (get) Token: 0x0602C4A7 RID: 181415 RVA: 0x00A1C468 File Offset: 0x00A1A668
		// (set) Token: 0x0602C4A8 RID: 181416 RVA: 0x00A1C4AB File Offset: 0x00A1A6AB
		public TArray<SBulletGE> 能量恢复类GE数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletGE> result;
				if ((result = this._能量恢复类GE数组) == null)
				{
					result = (this._能量恢复类GE数组 = new TArray<SBulletGE>(base.NativePtr + (IntPtr)SBulletDataExe.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.能量恢复类GE数组.CopyAssign(value);
			}
		}

		// Token: 0x0602C4A9 RID: 181417 RVA: 0x00A1C4B9 File Offset: 0x00A1A6B9
		public SBulletDataExe()
		{
		}

		// Token: 0x0602C4AA RID: 181418 RVA: 0x00A1C4C1 File Offset: 0x00A1A6C1
		public SBulletDataExe(TSoftClassPtr<BP_BulletLogicBase_C> 命中执行逻辑, TSoftClassPtr<BP_BulletLogicBase_C> 更新执行逻辑, TArray<SBulletGE> 命中后对攻击者应用GE类数组, TArray<SBulletGE> 命中后对受击者应用GE类数组, TArray<SBulletGE> 能量恢复类GE数组)
		{
			this.命中执行逻辑 = 命中执行逻辑;
			this.更新执行逻辑 = 更新执行逻辑;
			this.命中后对攻击者应用GE类数组 = 命中后对攻击者应用GE类数组;
			this.命中后对受击者应用GE类数组 = 命中后对受击者应用GE类数组;
			this.能量恢复类GE数组 = 能量恢复类GE数组;
		}

		// Token: 0x0602C4AB RID: 181419 RVA: 0x00A1C4EE File Offset: 0x00A1A6EE
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataExe.StaticStruct();
		}

		// Token: 0x0602C4AC RID: 181420 RVA: 0x00A1C4FA File Offset: 0x00A1A6FA
		[NullableContext(2)]
		public SBulletDataExe(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C4AD RID: 181421 RVA: 0x00A1C504 File Offset: 0x00A1A704
		public SBulletDataExe(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C4AE RID: 181422 RVA: 0x00A1C50F File Offset: 0x00A1A70F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataExe(Pointer, false, true);
		}

		// Token: 0x0602C4AF RID: 181423 RVA: 0x00A1C519 File Offset: 0x00A1A719
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataExe(Pointer, MemoryOwner);
		}

		// Token: 0x040175A7 RID: 95655
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataExe.SBulletDataExe";

		// Token: 0x040175A8 RID: 95656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175A9 RID: 95657
		internal static int __PropertyOffset_0;

		// Token: 0x040175AA RID: 95658
		internal static int __PropertyOffset_1;

		// Token: 0x040175AB RID: 95659
		internal static int __PropertyOffset_2;

		// Token: 0x040175AC RID: 95660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletGE> _命中后对攻击者应用GE类数组;

		// Token: 0x040175AD RID: 95661
		internal static int __PropertyOffset_3;

		// Token: 0x040175AE RID: 95662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletGE> _命中后对受击者应用GE类数组;

		// Token: 0x040175AF RID: 95663
		internal static int __PropertyOffset_4;

		// Token: 0x040175B0 RID: 95664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletGE> _能量恢复类GE数组;
	}
}
