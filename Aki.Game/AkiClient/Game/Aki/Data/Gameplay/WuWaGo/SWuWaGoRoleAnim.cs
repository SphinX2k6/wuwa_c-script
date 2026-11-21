using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x020031D9 RID: 12761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SWuWaGoRoleAnim : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FAB7 RID: 129719 RVA: 0x00932F6D File Offset: 0x0093116D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWuWaGoRoleAnim._ScriptStructPtr != 0) ? SWuWaGoRoleAnim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim", ref SWuWaGoRoleAnim._ScriptStructPtr);
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0601FAB8 RID: 129720 RVA: 0x00932F94 File Offset: 0x00931194
		// (set) Token: 0x0601FAB9 RID: 129721 RVA: 0x00932FD7 File Offset: 0x009311D7
		public TArray<TSoftObjectPtr<UAnimMontage>> Attack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._Attack) == null)
				{
					result = (this._Attack = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_Attack, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Attack.CopyAssign(value);
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0601FABA RID: 129722 RVA: 0x00932FE8 File Offset: 0x009311E8
		// (set) Token: 0x0601FABB RID: 129723 RVA: 0x0093302B File Offset: 0x0093122B
		public TArray<TSoftObjectPtr<UAnimMontage>> Death
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._Death) == null)
				{
					result = (this._Death = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_Death, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Death.CopyAssign(value);
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0601FABC RID: 129724 RVA: 0x0093303C File Offset: 0x0093123C
		// (set) Token: 0x0601FABD RID: 129725 RVA: 0x0093307F File Offset: 0x0093127F
		public TArray<TSoftObjectPtr<UAnimMontage>> BeHit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._BeHit) == null)
				{
					result = (this._BeHit = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_BeHit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BeHit.CopyAssign(value);
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0601FABE RID: 129726 RVA: 0x00933090 File Offset: 0x00931290
		// (set) Token: 0x0601FABF RID: 129727 RVA: 0x009330D3 File Offset: 0x009312D3
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>> Climb
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._Climb) == null)
				{
					result = (this._Climb = new TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_Climb, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.Climb.CopyAssign(value);
			}
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x009330E1 File Offset: 0x009312E1
		public SWuWaGoRoleAnim()
		{
		}

		// Token: 0x0601FAC1 RID: 129729 RVA: 0x009330E9 File Offset: 0x009312E9
		protected override IntPtr GetUStructPtr()
		{
			return SWuWaGoRoleAnim.StaticStruct();
		}

		// Token: 0x0601FAC2 RID: 129730 RVA: 0x009330F5 File Offset: 0x009312F5
		[NullableContext(2)]
		public SWuWaGoRoleAnim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FAC3 RID: 129731 RVA: 0x009330FF File Offset: 0x009312FF
		public SWuWaGoRoleAnim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FAC4 RID: 129732 RVA: 0x0093310A File Offset: 0x0093130A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWuWaGoRoleAnim(Pointer, false, true);
		}

		// Token: 0x0601FAC5 RID: 129733 RVA: 0x00933114 File Offset: 0x00931314
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWuWaGoRoleAnim(Pointer, MemoryOwner);
		}

		// Token: 0x04010FD9 RID: 69593
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim";

		// Token: 0x04010FDA RID: 69594
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010FDB RID: 69595
		internal static int __PropertyOffset_Attack;

		// Token: 0x04010FDC RID: 69596
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _Attack;

		// Token: 0x04010FDD RID: 69597
		internal static int __PropertyOffset_Death;

		// Token: 0x04010FDE RID: 69598
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _Death;

		// Token: 0x04010FDF RID: 69599
		internal static int __PropertyOffset_BeHit;

		// Token: 0x04010FE0 RID: 69600
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _BeHit;

		// Token: 0x04010FE1 RID: 69601
		internal static int __PropertyOffset_Climb;

		// Token: 0x04010FE2 RID: 69602
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>> _Climb;
	}
}
