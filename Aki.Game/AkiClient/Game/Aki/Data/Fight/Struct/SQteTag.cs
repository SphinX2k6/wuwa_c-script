using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003211 RID: 12817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 91)]
	public class SQteTag : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FF2C RID: 130860 RVA: 0x00939947 File Offset: 0x00937B47
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQteTag._ScriptStructPtr != 0) ? SQteTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag", ref SQteTag._ScriptStructPtr);
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0601FF2D RID: 130861 RVA: 0x0093996B File Offset: 0x00937B6B
		// (set) Token: 0x0601FF2E RID: 130862 RVA: 0x0093997F File Offset: 0x00937B7F
		public unsafe FGameplayTag QteTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_QteTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_QteTag) = value;
			}
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0601FF2F RID: 130863 RVA: 0x00939994 File Offset: 0x00937B94
		// (set) Token: 0x0601FF30 RID: 130864 RVA: 0x009399A8 File Offset: 0x00937BA8
		public unsafe FGameplayTag NoTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_NoTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_NoTag) = value;
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0601FF31 RID: 130865 RVA: 0x009399BD File Offset: 0x00937BBD
		// (set) Token: 0x0601FF32 RID: 130866 RVA: 0x009399D1 File Offset: 0x00937BD1
		public unsafe FGameplayTag QteTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_QteTrigger);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_QteTrigger) = value;
			}
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0601FF33 RID: 130867 RVA: 0x009399E6 File Offset: 0x00937BE6
		// (set) Token: 0x0601FF34 RID: 130868 RVA: 0x009399FA File Offset: 0x00937BFA
		public unsafe FGameplayTag ExitSkillTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ExitSkillTrigger);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ExitSkillTrigger) = value;
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0601FF35 RID: 130869 RVA: 0x00939A0F File Offset: 0x00937C0F
		// (set) Token: 0x0601FF36 RID: 130870 RVA: 0x00939A1F File Offset: 0x00937C1F
		public unsafe int Energy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_Energy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_Energy) = value;
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0601FF37 RID: 130871 RVA: 0x00939A30 File Offset: 0x00937C30
		// (set) Token: 0x0601FF38 RID: 130872 RVA: 0x00939A73 File Offset: 0x00937C73
		public TArray<long> QteBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._QteBuffs) == null)
				{
					result = (this._QteBuffs = new TArray<long>(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_QteBuffs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QteBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0601FF39 RID: 130873 RVA: 0x00939A84 File Offset: 0x00937C84
		// (set) Token: 0x0601FF3A RID: 130874 RVA: 0x00939AC7 File Offset: 0x00937CC7
		public TArray<long> ConsumeBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._ConsumeBuffs) == null)
				{
					result = (this._ConsumeBuffs = new TArray<long>(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ConsumeBuffs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConsumeBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0601FF3B RID: 130875 RVA: 0x00939AD5 File Offset: 0x00937CD5
		// (set) Token: 0x0601FF3C RID: 130876 RVA: 0x00939AE5 File Offset: 0x00937CE5
		public unsafe bool ChangeRoleOnQte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ChangeRoleOnQte) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ChangeRoleOnQte) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0601FF3D RID: 130877 RVA: 0x00939AF6 File Offset: 0x00937CF6
		// (set) Token: 0x0601FF3E RID: 130878 RVA: 0x00939B06 File Offset: 0x00937D06
		public unsafe bool ChangeRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ChangeRole) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_ChangeRole) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0601FF3F RID: 130879 RVA: 0x00939B17 File Offset: 0x00937D17
		// (set) Token: 0x0601FF40 RID: 130880 RVA: 0x00939B27 File Offset: 0x00937D27
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x0601FF41 RID: 130881 RVA: 0x00939B38 File Offset: 0x00937D38
		public SQteTag()
		{
		}

		// Token: 0x0601FF42 RID: 130882 RVA: 0x00939B40 File Offset: 0x00937D40
		protected override IntPtr GetUStructPtr()
		{
			return SQteTag.StaticStruct();
		}

		// Token: 0x0601FF43 RID: 130883 RVA: 0x00939B4C File Offset: 0x00937D4C
		[NullableContext(2)]
		public SQteTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FF44 RID: 130884 RVA: 0x00939B56 File Offset: 0x00937D56
		public SQteTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FF45 RID: 130885 RVA: 0x00939B61 File Offset: 0x00937D61
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQteTag(Pointer, false, true);
		}

		// Token: 0x0601FF46 RID: 130886 RVA: 0x00939B6B File Offset: 0x00937D6B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQteTag(Pointer, MemoryOwner);
		}

		// Token: 0x0401127D RID: 70269
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag";

		// Token: 0x0401127E RID: 70270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401127F RID: 70271
		internal static int __PropertyOffset_QteTag;

		// Token: 0x04011280 RID: 70272
		internal static int __PropertyOffset_NoTag;

		// Token: 0x04011281 RID: 70273
		internal static int __PropertyOffset_QteTrigger;

		// Token: 0x04011282 RID: 70274
		internal static int __PropertyOffset_ExitSkillTrigger;

		// Token: 0x04011283 RID: 70275
		internal static int __PropertyOffset_Energy;

		// Token: 0x04011284 RID: 70276
		internal static int __PropertyOffset_QteBuffs;

		// Token: 0x04011285 RID: 70277
		[Nullable(2)]
		private TArray<long> _QteBuffs;

		// Token: 0x04011286 RID: 70278
		internal static int __PropertyOffset_ConsumeBuffs;

		// Token: 0x04011287 RID: 70279
		[Nullable(2)]
		private TArray<long> _ConsumeBuffs;

		// Token: 0x04011288 RID: 70280
		internal static int __PropertyOffset_ChangeRoleOnQte;

		// Token: 0x04011289 RID: 70281
		internal static int __PropertyOffset_ChangeRole;

		// Token: 0x0401128A RID: 70282
		internal static int __PropertyOffset_Priority;
	}
}
