using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004333 RID: 17203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillIKInfo.SSkillIKInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SSkillIKInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C974 RID: 182644 RVA: 0x00A235F4 File Offset: 0x00A217F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillIKInfo._ScriptStructPtr != 0) ? SSkillIKInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillIKInfo.SSkillIKInfo", ref SSkillIKInfo._ScriptStructPtr);
		}

		// Token: 0x1700700B RID: 28683
		// (get) Token: 0x0602C975 RID: 182645 RVA: 0x00A23618 File Offset: 0x00A21818
		// (set) Token: 0x0602C976 RID: 182646 RVA: 0x00A2365B File Offset: 0x00A2185B
		public TArray<FName> IK曲线名
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._IK曲线名) == null)
				{
					result = (this._IK曲线名 = new TArray<FName>(base.NativePtr + (IntPtr)SSkillIKInfo.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IK曲线名.CopyAssign(value);
			}
		}

		// Token: 0x1700700C RID: 28684
		// (get) Token: 0x0602C977 RID: 182647 RVA: 0x00A2366C File Offset: 0x00A2186C
		// (set) Token: 0x0602C978 RID: 182648 RVA: 0x00A236AF File Offset: 0x00A218AF
		public TArray<FVector> IK点的骨骼位置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._IK点的骨骼位置) == null)
				{
					result = (this._IK点的骨骼位置 = new TArray<FVector>(base.NativePtr + (IntPtr)SSkillIKInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IK点的骨骼位置.CopyAssign(value);
			}
		}

		// Token: 0x1700700D RID: 28685
		// (get) Token: 0x0602C979 RID: 182649 RVA: 0x00A236C0 File Offset: 0x00A218C0
		// (set) Token: 0x0602C97A RID: 182650 RVA: 0x00A23703 File Offset: 0x00A21903
		public TArray<FVector> IK点的相对位置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._IK点的相对位置) == null)
				{
					result = (this._IK点的相对位置 = new TArray<FVector>(base.NativePtr + (IntPtr)SSkillIKInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IK点的相对位置.CopyAssign(value);
			}
		}

		// Token: 0x1700700E RID: 28686
		// (get) Token: 0x0602C97B RID: 182651 RVA: 0x00A23714 File Offset: 0x00A21914
		// (set) Token: 0x0602C97C RID: 182652 RVA: 0x00A23757 File Offset: 0x00A21957
		public TArray<float> IK范围
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._IK范围) == null)
				{
					result = (this._IK范围 = new TArray<float>(base.NativePtr + (IntPtr)SSkillIKInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IK范围.CopyAssign(value);
			}
		}

		// Token: 0x0602C97D RID: 182653 RVA: 0x00A23765 File Offset: 0x00A21965
		public SSkillIKInfo()
		{
		}

		// Token: 0x0602C97E RID: 182654 RVA: 0x00A2376D File Offset: 0x00A2196D
		public SSkillIKInfo(TArray<FName> IK曲线名, TArray<FVector> IK点的骨骼位置, TArray<FVector> IK点的相对位置, TArray<float> IK范围)
		{
			this.IK曲线名 = IK曲线名;
			this.IK点的骨骼位置 = IK点的骨骼位置;
			this.IK点的相对位置 = IK点的相对位置;
			this.IK范围 = IK范围;
		}

		// Token: 0x0602C97F RID: 182655 RVA: 0x00A23792 File Offset: 0x00A21992
		protected override IntPtr GetUStructPtr()
		{
			return SSkillIKInfo.StaticStruct();
		}

		// Token: 0x0602C980 RID: 182656 RVA: 0x00A2379E File Offset: 0x00A2199E
		[NullableContext(2)]
		public SSkillIKInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C981 RID: 182657 RVA: 0x00A237A8 File Offset: 0x00A219A8
		public SSkillIKInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C982 RID: 182658 RVA: 0x00A237B3 File Offset: 0x00A219B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillIKInfo(Pointer, false, true);
		}

		// Token: 0x0602C983 RID: 182659 RVA: 0x00A237BD File Offset: 0x00A219BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillIKInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401780F RID: 96271
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillIKInfo.SSkillIKInfo";

		// Token: 0x04017810 RID: 96272
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017811 RID: 96273
		internal static int __PropertyOffset_0;

		// Token: 0x04017812 RID: 96274
		[Nullable(2)]
		private TArray<FName> _IK曲线名;

		// Token: 0x04017813 RID: 96275
		internal static int __PropertyOffset_1;

		// Token: 0x04017814 RID: 96276
		[Nullable(2)]
		private TArray<FVector> _IK点的骨骼位置;

		// Token: 0x04017815 RID: 96277
		internal static int __PropertyOffset_2;

		// Token: 0x04017816 RID: 96278
		[Nullable(2)]
		private TArray<FVector> _IK点的相对位置;

		// Token: 0x04017817 RID: 96279
		internal static int __PropertyOffset_3;

		// Token: 0x04017818 RID: 96280
		[Nullable(2)]
		private TArray<float> _IK范围;
	}
}
