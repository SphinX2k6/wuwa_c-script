using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042EE RID: 17134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAudioEventProbabilityCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C3CE RID: 181198 RVA: 0x00A1B1F8 File Offset: 0x00A193F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAudioEventProbabilityCooldownInfo._ScriptStructPtr != 0) ? SAudioEventProbabilityCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo", ref SAudioEventProbabilityCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x17006E47 RID: 28231
		// (get) Token: 0x0602C3CF RID: 181199 RVA: 0x00A1B21C File Offset: 0x00A1941C
		// (set) Token: 0x0602C3D0 RID: 181200 RVA: 0x00A1B22C File Offset: 0x00A1942C
		public unsafe float DefaultProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E48 RID: 28232
		// (get) Token: 0x0602C3D1 RID: 181201 RVA: 0x00A1B23D File Offset: 0x00A1943D
		// (set) Token: 0x0602C3D2 RID: 181202 RVA: 0x00A1B24D File Offset: 0x00A1944D
		public unsafe int DefaultCooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E49 RID: 28233
		// (get) Token: 0x0602C3D3 RID: 181203 RVA: 0x00A1B260 File Offset: 0x00A19460
		// (set) Token: 0x0602C3D4 RID: 181204 RVA: 0x00A1B2A3 File Offset: 0x00A194A3
		public TArray<SGameplayTagProbabilityCooldownInfo> TagProbability
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SGameplayTagProbabilityCooldownInfo> result;
				if ((result = this._TagProbability) == null)
				{
					result = (this._TagProbability = new TArray<SGameplayTagProbabilityCooldownInfo>(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagProbability.CopyAssign(value);
			}
		}

		// Token: 0x0602C3D5 RID: 181205 RVA: 0x00A1B2B1 File Offset: 0x00A194B1
		public SAudioEventProbabilityCooldownInfo()
		{
		}

		// Token: 0x0602C3D6 RID: 181206 RVA: 0x00A1B2B9 File Offset: 0x00A194B9
		public SAudioEventProbabilityCooldownInfo(float DefaultProbability, int DefaultCooldownTime, TArray<SGameplayTagProbabilityCooldownInfo> TagProbability)
		{
			this.DefaultProbability = DefaultProbability;
			this.DefaultCooldownTime = DefaultCooldownTime;
			this.TagProbability = TagProbability;
		}

		// Token: 0x0602C3D7 RID: 181207 RVA: 0x00A1B2D6 File Offset: 0x00A194D6
		protected override IntPtr GetUStructPtr()
		{
			return SAudioEventProbabilityCooldownInfo.StaticStruct();
		}

		// Token: 0x0602C3D8 RID: 181208 RVA: 0x00A1B2E2 File Offset: 0x00A194E2
		[NullableContext(2)]
		public SAudioEventProbabilityCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C3D9 RID: 181209 RVA: 0x00A1B2EC File Offset: 0x00A194EC
		public SAudioEventProbabilityCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C3DA RID: 181210 RVA: 0x00A1B2F7 File Offset: 0x00A194F7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAudioEventProbabilityCooldownInfo(Pointer, false, true);
		}

		// Token: 0x0602C3DB RID: 181211 RVA: 0x00A1B301 File Offset: 0x00A19501
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAudioEventProbabilityCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401754D RID: 95565
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo";

		// Token: 0x0401754E RID: 95566
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401754F RID: 95567
		internal static int __PropertyOffset_0;

		// Token: 0x04017550 RID: 95568
		internal static int __PropertyOffset_1;

		// Token: 0x04017551 RID: 95569
		internal static int __PropertyOffset_2;

		// Token: 0x04017552 RID: 95570
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SGameplayTagProbabilityCooldownInfo> _TagProbability;
	}
}
