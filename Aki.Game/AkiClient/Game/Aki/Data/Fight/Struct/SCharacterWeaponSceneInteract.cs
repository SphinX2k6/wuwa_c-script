using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F63 RID: 16227
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCharacterWeaponSceneInteract.SCharacterWeaponSceneInteract")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SCharacterWeaponSceneInteract : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029596 RID: 169366 RVA: 0x009C211C File Offset: 0x009C031C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterWeaponSceneInteract._ScriptStructPtr != 0) ? SCharacterWeaponSceneInteract._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCharacterWeaponSceneInteract.SCharacterWeaponSceneInteract", ref SCharacterWeaponSceneInteract._ScriptStructPtr);
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x06029597 RID: 169367 RVA: 0x009C2140 File Offset: 0x009C0340
		// (set) Token: 0x06029598 RID: 169368 RVA: 0x009C215F File Offset: 0x009C035F
		public TSoftClassPtr<AActor> RoleBp
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x06029599 RID: 169369 RVA: 0x009C2184 File Offset: 0x009C0384
		// (set) Token: 0x0602959A RID: 169370 RVA: 0x009C21C7 File Offset: 0x009C03C7
		public TArray<TSoftObjectPtr<UObject>> ObjectArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._ObjectArray) == null)
				{
					result = (this._ObjectArray = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x0602959B RID: 169371 RVA: 0x009C21D8 File Offset: 0x009C03D8
		// (set) Token: 0x0602959C RID: 169372 RVA: 0x009C221B File Offset: 0x009C041B
		public TArray<TSoftObjectPtr<BP_SceneBattleInteract_C>> DaArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<BP_SceneBattleInteract_C>> result;
				if ((result = this._DaArray) == null)
				{
					result = (this._DaArray = new TArray<TSoftObjectPtr<BP_SceneBattleInteract_C>>(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DaArray.CopyAssign(value);
			}
		}

		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x0602959D RID: 169373 RVA: 0x009C222C File Offset: 0x009C042C
		// (set) Token: 0x0602959E RID: 169374 RVA: 0x009C226F File Offset: 0x009C046F
		public TMap<string, int> OtherCaseMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._OtherCaseMap) == null)
				{
					result = (this._OtherCaseMap = new TMap<string, int>(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherCaseMap.CopyAssign(value);
			}
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x0602959F RID: 169375 RVA: 0x009C2280 File Offset: 0x009C0480
		// (set) Token: 0x060295A0 RID: 169376 RVA: 0x009C22C3 File Offset: 0x009C04C3
		public TMap<string, FName> OtherCaseParentMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FName> result;
				if ((result = this._OtherCaseParentMap) == null)
				{
					result = (this._OtherCaseParentMap = new TMap<string, FName>(base.NativePtr + (IntPtr)SCharacterWeaponSceneInteract.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherCaseParentMap.CopyAssign(value);
			}
		}

		// Token: 0x060295A1 RID: 169377 RVA: 0x009C22D1 File Offset: 0x009C04D1
		public SCharacterWeaponSceneInteract()
		{
		}

		// Token: 0x060295A2 RID: 169378 RVA: 0x009C22D9 File Offset: 0x009C04D9
		public SCharacterWeaponSceneInteract(TSoftClassPtr<AActor> RoleBp, TArray<TSoftObjectPtr<UObject>> ObjectArray, TArray<TSoftObjectPtr<BP_SceneBattleInteract_C>> DaArray, TMap<string, int> OtherCaseMap, TMap<string, FName> OtherCaseParentMap)
		{
			this.RoleBp = RoleBp;
			this.ObjectArray = ObjectArray;
			this.DaArray = DaArray;
			this.OtherCaseMap = OtherCaseMap;
			this.OtherCaseParentMap = OtherCaseParentMap;
		}

		// Token: 0x060295A3 RID: 169379 RVA: 0x009C2306 File Offset: 0x009C0506
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterWeaponSceneInteract.StaticStruct();
		}

		// Token: 0x060295A4 RID: 169380 RVA: 0x009C2312 File Offset: 0x009C0512
		[NullableContext(2)]
		public SCharacterWeaponSceneInteract(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060295A5 RID: 169381 RVA: 0x009C231C File Offset: 0x009C051C
		public SCharacterWeaponSceneInteract(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060295A6 RID: 169382 RVA: 0x009C2327 File Offset: 0x009C0527
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterWeaponSceneInteract(Pointer, false, true);
		}

		// Token: 0x060295A7 RID: 169383 RVA: 0x009C2331 File Offset: 0x009C0531
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterWeaponSceneInteract(Pointer, MemoryOwner);
		}

		// Token: 0x04015300 RID: 86784
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCharacterWeaponSceneInteract.SCharacterWeaponSceneInteract";

		// Token: 0x04015301 RID: 86785
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015302 RID: 86786
		internal static int __PropertyOffset_0;

		// Token: 0x04015303 RID: 86787
		internal static int __PropertyOffset_1;

		// Token: 0x04015304 RID: 86788
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _ObjectArray;

		// Token: 0x04015305 RID: 86789
		internal static int __PropertyOffset_2;

		// Token: 0x04015306 RID: 86790
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<BP_SceneBattleInteract_C>> _DaArray;

		// Token: 0x04015307 RID: 86791
		internal static int __PropertyOffset_3;

		// Token: 0x04015308 RID: 86792
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _OtherCaseMap;

		// Token: 0x04015309 RID: 86793
		internal static int __PropertyOffset_4;

		// Token: 0x0401530A RID: 86794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FName> _OtherCaseParentMap;
	}
}
