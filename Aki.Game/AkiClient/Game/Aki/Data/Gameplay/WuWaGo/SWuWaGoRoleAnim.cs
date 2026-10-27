using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x02003F2D RID: 16173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SWuWaGoRoleAnim : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060291A4 RID: 168356 RVA: 0x009BBDEB File Offset: 0x009B9FEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWuWaGoRoleAnim._ScriptStructPtr != 0) ? SWuWaGoRoleAnim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim", ref SWuWaGoRoleAnim._ScriptStructPtr);
		}

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x060291A5 RID: 168357 RVA: 0x009BBE10 File Offset: 0x009BA010
		// (set) Token: 0x060291A6 RID: 168358 RVA: 0x009BBE53 File Offset: 0x009BA053
		public TArray<TSoftObjectPtr<UAnimMontage>> Attack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._Attack) == null)
				{
					result = (this._Attack = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Attack.CopyAssign(value);
			}
		}

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x060291A7 RID: 168359 RVA: 0x009BBE64 File Offset: 0x009BA064
		// (set) Token: 0x060291A8 RID: 168360 RVA: 0x009BBEA7 File Offset: 0x009BA0A7
		public TArray<TSoftObjectPtr<UAnimMontage>> Death
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._Death) == null)
				{
					result = (this._Death = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Death.CopyAssign(value);
			}
		}

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x060291A9 RID: 168361 RVA: 0x009BBEB8 File Offset: 0x009BA0B8
		// (set) Token: 0x060291AA RID: 168362 RVA: 0x009BBEFB File Offset: 0x009BA0FB
		public TArray<TSoftObjectPtr<UAnimMontage>> BeHit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UAnimMontage>> result;
				if ((result = this._BeHit) == null)
				{
					result = (this._BeHit = new TArray<TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BeHit.CopyAssign(value);
			}
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x060291AB RID: 168363 RVA: 0x009BBF0C File Offset: 0x009BA10C
		// (set) Token: 0x060291AC RID: 168364 RVA: 0x009BBF4F File Offset: 0x009BA14F
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
					result = (this._Climb = new TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>>(base.NativePtr + (IntPtr)SWuWaGoRoleAnim.__PropertyOffset_3, base.MemoryOwner ?? this));
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

		// Token: 0x060291AD RID: 168365 RVA: 0x009BBF5D File Offset: 0x009BA15D
		public SWuWaGoRoleAnim()
		{
		}

		// Token: 0x060291AE RID: 168366 RVA: 0x009BBF65 File Offset: 0x009BA165
		public SWuWaGoRoleAnim(TArray<TSoftObjectPtr<UAnimMontage>> Attack, TArray<TSoftObjectPtr<UAnimMontage>> Death, TArray<TSoftObjectPtr<UAnimMontage>> BeHit, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>> Climb)
		{
			this.Attack = Attack;
			this.Death = Death;
			this.BeHit = BeHit;
			this.Climb = Climb;
		}

		// Token: 0x060291AF RID: 168367 RVA: 0x009BBF8A File Offset: 0x009BA18A
		protected override IntPtr GetUStructPtr()
		{
			return SWuWaGoRoleAnim.StaticStruct();
		}

		// Token: 0x060291B0 RID: 168368 RVA: 0x009BBF96 File Offset: 0x009BA196
		[NullableContext(2)]
		public SWuWaGoRoleAnim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060291B1 RID: 168369 RVA: 0x009BBFA0 File Offset: 0x009BA1A0
		public SWuWaGoRoleAnim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060291B2 RID: 168370 RVA: 0x009BBFAB File Offset: 0x009BA1AB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWuWaGoRoleAnim(Pointer, false, true);
		}

		// Token: 0x060291B3 RID: 168371 RVA: 0x009BBFB5 File Offset: 0x009BA1B5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWuWaGoRoleAnim(Pointer, MemoryOwner);
		}

		// Token: 0x040150A9 RID: 86185
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/SWuWaGoRoleAnim.SWuWaGoRoleAnim";

		// Token: 0x040150AA RID: 86186
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150AB RID: 86187
		internal static int __PropertyOffset_0;

		// Token: 0x040150AC RID: 86188
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _Attack;

		// Token: 0x040150AD RID: 86189
		internal static int __PropertyOffset_1;

		// Token: 0x040150AE RID: 86190
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _Death;

		// Token: 0x040150AF RID: 86191
		internal static int __PropertyOffset_2;

		// Token: 0x040150B0 RID: 86192
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UAnimMontage>> _BeHit;

		// Token: 0x040150B1 RID: 86193
		internal static int __PropertyOffset_3;

		// Token: 0x040150B2 RID: 86194
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
