using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED6 RID: 16086
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 116)]
	public class SCommonQteGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028AC4 RID: 166596 RVA: 0x009B1E18 File Offset: 0x009B0018
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQteGroup._ScriptStructPtr != 0) ? SCommonQteGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup", ref SCommonQteGroup._ScriptStructPtr);
		}

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x06028AC5 RID: 166597 RVA: 0x009B1E3C File Offset: 0x009B003C
		// (set) Token: 0x06028AC6 RID: 166598 RVA: 0x009B1E50 File Offset: 0x009B0050
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteGroup.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQteGroup.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x06028AC7 RID: 166599 RVA: 0x009B1E68 File Offset: 0x009B0068
		// (set) Token: 0x06028AC8 RID: 166600 RVA: 0x009B1EAB File Offset: 0x009B00AB
		public TSet<int> CommonQteIdSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._CommonQteIdSet) == null)
				{
					result = (this._CommonQteIdSet = new TSet<int>(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CommonQteIdSet.CopyAssign(value);
			}
		}

		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x06028AC9 RID: 166601 RVA: 0x009B1EB9 File Offset: 0x009B00B9
		// (set) Token: 0x06028ACA RID: 166602 RVA: 0x009B1EC9 File Offset: 0x009B00C9
		public unsafe int MainQteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F0A RID: 24330
		// (get) Token: 0x06028ACB RID: 166603 RVA: 0x009B1EDA File Offset: 0x009B00DA
		// (set) Token: 0x06028ACC RID: 166604 RVA: 0x009B1EEA File Offset: 0x009B00EA
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x06028ACD RID: 166605 RVA: 0x009B1EFB File Offset: 0x009B00FB
		// (set) Token: 0x06028ACE RID: 166606 RVA: 0x009B1F0B File Offset: 0x009B010B
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x06028ACF RID: 166607 RVA: 0x009B1F1C File Offset: 0x009B011C
		// (set) Token: 0x06028AD0 RID: 166608 RVA: 0x009B1F2C File Offset: 0x009B012C
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x06028AD1 RID: 166609 RVA: 0x009B1F3D File Offset: 0x009B013D
		// (set) Token: 0x06028AD2 RID: 166610 RVA: 0x009B1F4D File Offset: 0x009B014D
		public unsafe float ToleranceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQteGroup.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06028AD3 RID: 166611 RVA: 0x009B1F5E File Offset: 0x009B015E
		public SCommonQteGroup()
		{
		}

		// Token: 0x06028AD4 RID: 166612 RVA: 0x009B1F66 File Offset: 0x009B0166
		public SCommonQteGroup(string Desc, TSet<int> CommonQteIdSet, int MainQteId, float Duration, float LeastDuration, float TimeDilation, float ToleranceTime)
		{
			this.Desc = Desc;
			this.CommonQteIdSet = CommonQteIdSet;
			this.MainQteId = MainQteId;
			this.Duration = Duration;
			this.LeastDuration = LeastDuration;
			this.TimeDilation = TimeDilation;
			this.ToleranceTime = ToleranceTime;
		}

		// Token: 0x06028AD5 RID: 166613 RVA: 0x009B1FA3 File Offset: 0x009B01A3
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQteGroup.StaticStruct();
		}

		// Token: 0x06028AD6 RID: 166614 RVA: 0x009B1FAF File Offset: 0x009B01AF
		[NullableContext(2)]
		public SCommonQteGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028AD7 RID: 166615 RVA: 0x009B1FB9 File Offset: 0x009B01B9
		public SCommonQteGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028AD8 RID: 166616 RVA: 0x009B1FC4 File Offset: 0x009B01C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQteGroup(Pointer, false, true);
		}

		// Token: 0x06028AD9 RID: 166617 RVA: 0x009B1FCE File Offset: 0x009B01CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQteGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04014CA3 RID: 85155
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQteGroup.SCommonQteGroup";

		// Token: 0x04014CA4 RID: 85156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CA5 RID: 85157
		internal static int __PropertyOffset_0;

		// Token: 0x04014CA6 RID: 85158
		internal static int __PropertyOffset_1;

		// Token: 0x04014CA7 RID: 85159
		[Nullable(2)]
		private TSet<int> _CommonQteIdSet;

		// Token: 0x04014CA8 RID: 85160
		internal static int __PropertyOffset_2;

		// Token: 0x04014CA9 RID: 85161
		internal static int __PropertyOffset_3;

		// Token: 0x04014CAA RID: 85162
		internal static int __PropertyOffset_4;

		// Token: 0x04014CAB RID: 85163
		internal static int __PropertyOffset_5;

		// Token: 0x04014CAC RID: 85164
		internal static int __PropertyOffset_6;
	}
}
