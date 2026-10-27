using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AAD RID: 15021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailLandPair.STrailLandPair")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class STrailLandPair : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202CD RID: 131789 RVA: 0x008CBCE1 File Offset: 0x008C9EE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STrailLandPair._ScriptStructPtr != 0) ? STrailLandPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailLandPair.STrailLandPair", ref STrailLandPair._ScriptStructPtr);
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x060202CE RID: 131790 RVA: 0x008CBD08 File Offset: 0x008C9F08
		// (set) Token: 0x060202CF RID: 131791 RVA: 0x008CBD4B File Offset: 0x008C9F4B
		public TArray<int> Index
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Index) == null)
				{
					result = (this._Index = new TArray<int>(base.NativePtr + (IntPtr)STrailLandPair.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Index.CopyAssign(value);
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x060202D0 RID: 131792 RVA: 0x008CBD5C File Offset: 0x008C9F5C
		// (set) Token: 0x060202D1 RID: 131793 RVA: 0x008CBD9F File Offset: 0x008C9F9F
		public TArray<bool> Show
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._Show) == null)
				{
					result = (this._Show = new TArray<bool>(base.NativePtr + (IntPtr)STrailLandPair.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Show.CopyAssign(value);
			}
		}

		// Token: 0x060202D2 RID: 131794 RVA: 0x008CBDAD File Offset: 0x008C9FAD
		public STrailLandPair()
		{
		}

		// Token: 0x060202D3 RID: 131795 RVA: 0x008CBDB5 File Offset: 0x008C9FB5
		public STrailLandPair(TArray<int> Index, TArray<bool> Show)
		{
			this.Index = Index;
			this.Show = Show;
		}

		// Token: 0x060202D4 RID: 131796 RVA: 0x008CBDCB File Offset: 0x008C9FCB
		protected override IntPtr GetUStructPtr()
		{
			return STrailLandPair.StaticStruct();
		}

		// Token: 0x060202D5 RID: 131797 RVA: 0x008CBDD7 File Offset: 0x008C9FD7
		[NullableContext(2)]
		public STrailLandPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202D6 RID: 131798 RVA: 0x008CBDE1 File Offset: 0x008C9FE1
		public STrailLandPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202D7 RID: 131799 RVA: 0x008CBDEC File Offset: 0x008C9FEC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STrailLandPair(Pointer, false, true);
		}

		// Token: 0x060202D8 RID: 131800 RVA: 0x008CBDF6 File Offset: 0x008C9FF6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STrailLandPair(Pointer, MemoryOwner);
		}

		// Token: 0x0400F8CD RID: 63693
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailLandPair.STrailLandPair";

		// Token: 0x0400F8CE RID: 63694
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F8CF RID: 63695
		internal static int __PropertyOffset_0;

		// Token: 0x0400F8D0 RID: 63696
		[Nullable(2)]
		private TArray<int> _Index;

		// Token: 0x0400F8D1 RID: 63697
		internal static int __PropertyOffset_1;

		// Token: 0x0400F8D2 RID: 63698
		[Nullable(2)]
		private TArray<bool> _Show;
	}
}
