using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003158 RID: 12632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SPlayerElementalFieldConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F15E RID: 127326 RVA: 0x0092603A File Offset: 0x0092423A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPlayerElementalFieldConfig._ScriptStructPtr != 0) ? SPlayerElementalFieldConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig", ref SPlayerElementalFieldConfig._ScriptStructPtr);
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0601F15F RID: 127327 RVA: 0x00926060 File Offset: 0x00924260
		// (set) Token: 0x0601F160 RID: 127328 RVA: 0x009260A3 File Offset: 0x009242A3
		public TArray<long> UnopenedGameplayCueList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._UnopenedGameplayCueList) == null)
				{
					result = (this._UnopenedGameplayCueList = new TArray<long>(base.NativePtr + (IntPtr)SPlayerElementalFieldConfig.__PropertyOffset_UnopenedGameplayCueList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnopenedGameplayCueList.CopyAssign(value);
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0601F161 RID: 127329 RVA: 0x009260B4 File Offset: 0x009242B4
		// (set) Token: 0x0601F162 RID: 127330 RVA: 0x009260F7 File Offset: 0x009242F7
		public TArray<long> OpenedFieldGameplayCueList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._OpenedFieldGameplayCueList) == null)
				{
					result = (this._OpenedFieldGameplayCueList = new TArray<long>(base.NativePtr + (IntPtr)SPlayerElementalFieldConfig.__PropertyOffset_OpenedFieldGameplayCueList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OpenedFieldGameplayCueList.CopyAssign(value);
			}
		}

		// Token: 0x0601F163 RID: 127331 RVA: 0x00926105 File Offset: 0x00924305
		public SPlayerElementalFieldConfig()
		{
		}

		// Token: 0x0601F164 RID: 127332 RVA: 0x0092610D File Offset: 0x0092430D
		protected override IntPtr GetUStructPtr()
		{
			return SPlayerElementalFieldConfig.StaticStruct();
		}

		// Token: 0x0601F165 RID: 127333 RVA: 0x00926119 File Offset: 0x00924319
		[NullableContext(2)]
		public SPlayerElementalFieldConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F166 RID: 127334 RVA: 0x00926123 File Offset: 0x00924323
		public SPlayerElementalFieldConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F167 RID: 127335 RVA: 0x0092612E File Offset: 0x0092432E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPlayerElementalFieldConfig(Pointer, false, true);
		}

		// Token: 0x0601F168 RID: 127336 RVA: 0x00926138 File Offset: 0x00924338
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPlayerElementalFieldConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040109C3 RID: 68035
		public const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig";

		// Token: 0x040109C4 RID: 68036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109C5 RID: 68037
		internal static int __PropertyOffset_UnopenedGameplayCueList;

		// Token: 0x040109C6 RID: 68038
		[Nullable(2)]
		private TArray<long> _UnopenedGameplayCueList;

		// Token: 0x040109C7 RID: 68039
		internal static int __PropertyOffset_OpenedFieldGameplayCueList;

		// Token: 0x040109C8 RID: 68040
		[Nullable(2)]
		private TArray<long> _OpenedFieldGameplayCueList;
	}
}
