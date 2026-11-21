using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x02003037 RID: 12343
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class BvbCardItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D47E RID: 119934 RVA: 0x008EFC38 File Offset: 0x008EDE38
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbCardItemData._ScriptStructPtr != 0) ? BvbCardItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData", ref BvbCardItemData._ScriptStructPtr);
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0601D47F RID: 119935 RVA: 0x008EFC5C File Offset: 0x008EDE5C
		// (set) Token: 0x0601D480 RID: 119936 RVA: 0x008EFC70 File Offset: 0x008EDE70
		public unsafe string CardName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_CardName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_CardName)), value);
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0601D481 RID: 119937 RVA: 0x008EFC85 File Offset: 0x008EDE85
		// (set) Token: 0x0601D482 RID: 119938 RVA: 0x008EFC99 File Offset: 0x008EDE99
		public unsafe string Cost
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Cost)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Cost)), value);
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0601D483 RID: 119939 RVA: 0x008EFCAE File Offset: 0x008EDEAE
		// (set) Token: 0x0601D484 RID: 119940 RVA: 0x008EFCC2 File Offset: 0x008EDEC2
		public unsafe string Element
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Element)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Element)), value);
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0601D485 RID: 119941 RVA: 0x008EFCD7 File Offset: 0x008EDED7
		// (set) Token: 0x0601D486 RID: 119942 RVA: 0x008EFCEB File Offset: 0x008EDEEB
		public unsafe string Power
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Power)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_Power)), value);
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0601D487 RID: 119943 RVA: 0x008EFD00 File Offset: 0x008EDF00
		// (set) Token: 0x0601D488 RID: 119944 RVA: 0x008EFD14 File Offset: 0x008EDF14
		public unsafe string CardDesc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_CardDesc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BvbCardItemData.__PropertyOffset_CardDesc)), value);
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0601D489 RID: 119945 RVA: 0x008EFD2C File Offset: 0x008EDF2C
		// (set) Token: 0x0601D48A RID: 119946 RVA: 0x008EFD6F File Offset: 0x008EDF6F
		public TArray<BvbEffectItemData> EffectList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbEffectItemData> result;
				if ((result = this._EffectList) == null)
				{
					result = (this._EffectList = new TArray<BvbEffectItemData>(base.NativePtr + (IntPtr)BvbCardItemData.__PropertyOffset_EffectList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectList.CopyAssign(value);
			}
		}

		// Token: 0x0601D48B RID: 119947 RVA: 0x008EFD7D File Offset: 0x008EDF7D
		public BvbCardItemData()
		{
		}

		// Token: 0x0601D48C RID: 119948 RVA: 0x008EFD85 File Offset: 0x008EDF85
		protected override IntPtr GetUStructPtr()
		{
			return BvbCardItemData.StaticStruct();
		}

		// Token: 0x0601D48D RID: 119949 RVA: 0x008EFD91 File Offset: 0x008EDF91
		[NullableContext(2)]
		public BvbCardItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D48E RID: 119950 RVA: 0x008EFD9B File Offset: 0x008EDF9B
		public BvbCardItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D48F RID: 119951 RVA: 0x008EFDA6 File Offset: 0x008EDFA6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbCardItemData(Pointer, false, true);
		}

		// Token: 0x0601D490 RID: 119952 RVA: 0x008EFDB0 File Offset: 0x008EDFB0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbCardItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F6AA RID: 63146
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbCardItemData.BvbCardItemData";

		// Token: 0x0400F6AB RID: 63147
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F6AC RID: 63148
		internal static int __PropertyOffset_CardName;

		// Token: 0x0400F6AD RID: 63149
		internal static int __PropertyOffset_Cost;

		// Token: 0x0400F6AE RID: 63150
		internal static int __PropertyOffset_Element;

		// Token: 0x0400F6AF RID: 63151
		internal static int __PropertyOffset_Power;

		// Token: 0x0400F6B0 RID: 63152
		internal static int __PropertyOffset_CardDesc;

		// Token: 0x0400F6B1 RID: 63153
		internal static int __PropertyOffset_EffectList;

		// Token: 0x0400F6B2 RID: 63154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbEffectItemData> _EffectList;
	}
}
