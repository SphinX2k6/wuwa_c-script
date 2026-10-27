using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Manipulate
{
	// Token: 0x02003EF8 RID: 16120
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SManipulateConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028D2F RID: 167215 RVA: 0x009B56C4 File Offset: 0x009B38C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SManipulateConfig._ScriptStructPtr != 0) ? SManipulateConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig", ref SManipulateConfig._ScriptStructPtr);
		}

		// Token: 0x17005FC2 RID: 24514
		// (get) Token: 0x06028D30 RID: 167216 RVA: 0x009B56E8 File Offset: 0x009B38E8
		// (set) Token: 0x06028D31 RID: 167217 RVA: 0x009B56FC File Offset: 0x009B38FC
		public unsafe FName ConfigName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x06028D32 RID: 167218 RVA: 0x009B5714 File Offset: 0x009B3914
		// (set) Token: 0x06028D33 RID: 167219 RVA: 0x009B5757 File Offset: 0x009B3957
		public TArray<SManipulatePointInfo> ManipulatePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SManipulatePointInfo> result;
				if ((result = this._ManipulatePoints) == null)
				{
					result = (this._ManipulatePoints = new TArray<SManipulatePointInfo>(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ManipulatePoints.CopyAssign(value);
			}
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x06028D34 RID: 167220 RVA: 0x009B5765 File Offset: 0x009B3965
		// (set) Token: 0x06028D35 RID: 167221 RVA: 0x009B5775 File Offset: 0x009B3975
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SManipulateConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06028D36 RID: 167222 RVA: 0x009B5786 File Offset: 0x009B3986
		public SManipulateConfig()
		{
		}

		// Token: 0x06028D37 RID: 167223 RVA: 0x009B578E File Offset: 0x009B398E
		public SManipulateConfig(FName ConfigName, TArray<SManipulatePointInfo> ManipulatePoints, float Duration)
		{
			this.ConfigName = ConfigName;
			this.ManipulatePoints = ManipulatePoints;
			this.Duration = Duration;
		}

		// Token: 0x06028D38 RID: 167224 RVA: 0x009B57AB File Offset: 0x009B39AB
		protected override IntPtr GetUStructPtr()
		{
			return SManipulateConfig.StaticStruct();
		}

		// Token: 0x06028D39 RID: 167225 RVA: 0x009B57B7 File Offset: 0x009B39B7
		[NullableContext(2)]
		public SManipulateConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028D3A RID: 167226 RVA: 0x009B57C1 File Offset: 0x009B39C1
		public SManipulateConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028D3B RID: 167227 RVA: 0x009B57CC File Offset: 0x009B39CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SManipulateConfig(Pointer, false, true);
		}

		// Token: 0x06028D3C RID: 167228 RVA: 0x009B57D6 File Offset: 0x009B39D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SManipulateConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014DFA RID: 85498
		public const string __ObjectPath = "/Game/Aki/Data/Manipulate/SManipulateConfig.SManipulateConfig";

		// Token: 0x04014DFB RID: 85499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DFC RID: 85500
		internal static int __PropertyOffset_0;

		// Token: 0x04014DFD RID: 85501
		internal static int __PropertyOffset_1;

		// Token: 0x04014DFE RID: 85502
		[Nullable(2)]
		private TArray<SManipulatePointInfo> _ManipulatePoints;

		// Token: 0x04014DFF RID: 85503
		internal static int __PropertyOffset_2;
	}
}
