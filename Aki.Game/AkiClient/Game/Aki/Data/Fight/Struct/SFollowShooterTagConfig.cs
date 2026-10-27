using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F66 RID: 16230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SFollowShooterTagConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060295C7 RID: 169415 RVA: 0x009C25EC File Offset: 0x009C07EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowShooterTagConfig._ScriptStructPtr != 0) ? SFollowShooterTagConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig", ref SFollowShooterTagConfig._ScriptStructPtr);
		}

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x060295C8 RID: 169416 RVA: 0x009C2610 File Offset: 0x009C0810
		// (set) Token: 0x060295C9 RID: 169417 RVA: 0x009C2653 File Offset: 0x009C0853
		public FGameplayTagContainer AddTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x060295CA RID: 169418 RVA: 0x009C2674 File Offset: 0x009C0874
		// (set) Token: 0x060295CB RID: 169419 RVA: 0x009C26B7 File Offset: 0x009C08B7
		public FGameplayTagContainer CheckTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CheckTags) == null)
				{
					result = (this._CheckTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x060295CC RID: 169420 RVA: 0x009C26D8 File Offset: 0x009C08D8
		// (set) Token: 0x060295CD RID: 169421 RVA: 0x009C26E8 File Offset: 0x009C08E8
		public unsafe bool CheckHasTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x060295CE RID: 169422 RVA: 0x009C26F9 File Offset: 0x009C08F9
		// (set) Token: 0x060295CF RID: 169423 RVA: 0x009C270D File Offset: 0x009C090D
		[Nullable(0)]
		public unsafe TEnumAsByte<ETagLogicType> LogicType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060295D0 RID: 169424 RVA: 0x009C2722 File Offset: 0x009C0922
		public SFollowShooterTagConfig()
		{
		}

		// Token: 0x060295D1 RID: 169425 RVA: 0x009C272A File Offset: 0x009C092A
		public SFollowShooterTagConfig(FGameplayTagContainer AddTags, FGameplayTagContainer CheckTags, bool CheckHasTag, [Nullable(0)] TEnumAsByte<ETagLogicType> LogicType)
		{
			this.AddTags = AddTags;
			this.CheckTags = CheckTags;
			this.CheckHasTag = CheckHasTag;
			this.LogicType = LogicType;
		}

		// Token: 0x060295D2 RID: 169426 RVA: 0x009C274F File Offset: 0x009C094F
		protected override IntPtr GetUStructPtr()
		{
			return SFollowShooterTagConfig.StaticStruct();
		}

		// Token: 0x060295D3 RID: 169427 RVA: 0x009C275B File Offset: 0x009C095B
		[NullableContext(2)]
		public SFollowShooterTagConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060295D4 RID: 169428 RVA: 0x009C2765 File Offset: 0x009C0965
		public SFollowShooterTagConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060295D5 RID: 169429 RVA: 0x009C2770 File Offset: 0x009C0970
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowShooterTagConfig(Pointer, false, true);
		}

		// Token: 0x060295D6 RID: 169430 RVA: 0x009C277A File Offset: 0x009C097A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowShooterTagConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401531B RID: 86811
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig";

		// Token: 0x0401531C RID: 86812
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401531D RID: 86813
		internal static int __PropertyOffset_0;

		// Token: 0x0401531E RID: 86814
		[Nullable(2)]
		private FGameplayTagContainer _AddTags;

		// Token: 0x0401531F RID: 86815
		internal static int __PropertyOffset_1;

		// Token: 0x04015320 RID: 86816
		[Nullable(2)]
		private FGameplayTagContainer _CheckTags;

		// Token: 0x04015321 RID: 86817
		internal static int __PropertyOffset_2;

		// Token: 0x04015322 RID: 86818
		internal static int __PropertyOffset_3;
	}
}
