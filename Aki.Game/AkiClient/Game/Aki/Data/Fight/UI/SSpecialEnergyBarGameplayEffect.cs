using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F5A RID: 16218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarGameplayEffect.SSpecialEnergyBarGameplayEffect")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SSpecialEnergyBarGameplayEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029502 RID: 169218 RVA: 0x009C1096 File Offset: 0x009BF296
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBarGameplayEffect._ScriptStructPtr != 0) ? SSpecialEnergyBarGameplayEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarGameplayEffect.SSpecialEnergyBarGameplayEffect", ref SSpecialEnergyBarGameplayEffect._ScriptStructPtr);
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x06029503 RID: 169219 RVA: 0x009C10BA File Offset: 0x009BF2BA
		// (set) Token: 0x06029504 RID: 169220 RVA: 0x009C10CE File Offset: 0x009BF2CE
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarGameplayEffect.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarGameplayEffect.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x06029505 RID: 169221 RVA: 0x009C10E3 File Offset: 0x009BF2E3
		// (set) Token: 0x06029506 RID: 169222 RVA: 0x009C10F3 File Offset: 0x009BF2F3
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialEnergyBarGameplayEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialEnergyBarGameplayEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x06029507 RID: 169223 RVA: 0x009C1104 File Offset: 0x009BF304
		// (set) Token: 0x06029508 RID: 169224 RVA: 0x009C1147 File Offset: 0x009BF347
		public TMap<int, SIntArray> SizeMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SIntArray> result;
				if ((result = this._SizeMap) == null)
				{
					result = (this._SizeMap = new TMap<int, SIntArray>(base.NativePtr + (IntPtr)SSpecialEnergyBarGameplayEffect.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SizeMap.CopyAssign(value);
			}
		}

		// Token: 0x06029509 RID: 169225 RVA: 0x009C1155 File Offset: 0x009BF355
		public SSpecialEnergyBarGameplayEffect()
		{
		}

		// Token: 0x0602950A RID: 169226 RVA: 0x009C115D File Offset: 0x009BF35D
		public SSpecialEnergyBarGameplayEffect(FGameplayTag Tag, long BuffId, TMap<int, SIntArray> SizeMap)
		{
			this.Tag = Tag;
			this.BuffId = BuffId;
			this.SizeMap = SizeMap;
		}

		// Token: 0x0602950B RID: 169227 RVA: 0x009C117A File Offset: 0x009BF37A
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialEnergyBarGameplayEffect.StaticStruct();
		}

		// Token: 0x0602950C RID: 169228 RVA: 0x009C1186 File Offset: 0x009BF386
		[NullableContext(2)]
		public SSpecialEnergyBarGameplayEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602950D RID: 169229 RVA: 0x009C1190 File Offset: 0x009BF390
		public SSpecialEnergyBarGameplayEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602950E RID: 169230 RVA: 0x009C119B File Offset: 0x009BF39B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialEnergyBarGameplayEffect(Pointer, false, true);
		}

		// Token: 0x0602950F RID: 169231 RVA: 0x009C11A5 File Offset: 0x009BF3A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialEnergyBarGameplayEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040152A8 RID: 86696
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBarGameplayEffect.SSpecialEnergyBarGameplayEffect";

		// Token: 0x040152A9 RID: 86697
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152AA RID: 86698
		internal static int __PropertyOffset_0;

		// Token: 0x040152AB RID: 86699
		internal static int __PropertyOffset_1;

		// Token: 0x040152AC RID: 86700
		internal static int __PropertyOffset_2;

		// Token: 0x040152AD RID: 86701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SIntArray> _SizeMap;
	}
}
