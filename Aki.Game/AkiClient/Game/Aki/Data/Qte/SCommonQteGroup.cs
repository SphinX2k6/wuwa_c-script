using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319B RID: 12699
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 116)]
	public class SCommonQteGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4F5 RID: 128245 RVA: 0x0092AF28 File Offset: 0x00929128
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQteGroup._ScriptStructPtr != 0) ? SCommonQteGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup", ref SCommonQteGroup._ScriptStructPtr);
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0601F4F6 RID: 128246 RVA: 0x0092AF4C File Offset: 0x0092914C
		// (set) Token: 0x0601F4F7 RID: 128247 RVA: 0x0092AF60 File Offset: 0x00929160
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteGroup.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteGroup.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0601F4F8 RID: 128248 RVA: 0x0092AF78 File Offset: 0x00929178
		// (set) Token: 0x0601F4F9 RID: 128249 RVA: 0x0092AFBB File Offset: 0x009291BB
		public TSet<int> CommonQteIdSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CommonQteIdSet) == null)
				{
					result = (this._CommonQteIdSet = new TSet<int>(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_CommonQteIdSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CommonQteIdSet.CopyAssign(value);
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0601F4FA RID: 128250 RVA: 0x0092AFC9 File Offset: 0x009291C9
		// (set) Token: 0x0601F4FB RID: 128251 RVA: 0x0092AFD9 File Offset: 0x009291D9
		public unsafe int MainQteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_MainQteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_MainQteId) = value;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0601F4FC RID: 128252 RVA: 0x0092AFEA File Offset: 0x009291EA
		// (set) Token: 0x0601F4FD RID: 128253 RVA: 0x0092AFFA File Offset: 0x009291FA
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0601F4FE RID: 128254 RVA: 0x0092B00B File Offset: 0x0092920B
		// (set) Token: 0x0601F4FF RID: 128255 RVA: 0x0092B01B File Offset: 0x0092921B
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_LeastDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_LeastDuration) = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0601F500 RID: 128256 RVA: 0x0092B02C File Offset: 0x0092922C
		// (set) Token: 0x0601F501 RID: 128257 RVA: 0x0092B03C File Offset: 0x0092923C
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0601F502 RID: 128258 RVA: 0x0092B04D File Offset: 0x0092924D
		// (set) Token: 0x0601F503 RID: 128259 RVA: 0x0092B05D File Offset: 0x0092925D
		public unsafe float ToleranceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_ToleranceTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_ToleranceTime) = value;
			}
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x0092B06E File Offset: 0x0092926E
		public SCommonQteGroup()
		{
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x0092B076 File Offset: 0x00929276
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQteGroup.StaticStruct();
		}

		// Token: 0x0601F506 RID: 128262 RVA: 0x0092B082 File Offset: 0x00929282
		[NullableContext(2)]
		public SCommonQteGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F507 RID: 128263 RVA: 0x0092B08C File Offset: 0x0092928C
		public SCommonQteGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F508 RID: 128264 RVA: 0x0092B097 File Offset: 0x00929297
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQteGroup(Pointer, false, true);
		}

		// Token: 0x0601F509 RID: 128265 RVA: 0x0092B0A1 File Offset: 0x009292A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQteGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04010C8A RID: 68746
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup";

		// Token: 0x04010C8B RID: 68747
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C8C RID: 68748
		internal static int __PropertyOffset_Desc;

		// Token: 0x04010C8D RID: 68749
		internal static int __PropertyOffset_CommonQteIdSet;

		// Token: 0x04010C8E RID: 68750
		[Nullable(2)]
		private TSet<int> _CommonQteIdSet;

		// Token: 0x04010C8F RID: 68751
		internal static int __PropertyOffset_MainQteId;

		// Token: 0x04010C90 RID: 68752
		internal static int __PropertyOffset_Duration;

		// Token: 0x04010C91 RID: 68753
		internal static int __PropertyOffset_LeastDuration;

		// Token: 0x04010C92 RID: 68754
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04010C93 RID: 68755
		internal static int __PropertyOffset_ToleranceTime;
	}
}
