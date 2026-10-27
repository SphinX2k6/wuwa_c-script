using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE3 RID: 15587
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BakedBalloonSet.S_BakedBalloonSet")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class S_BakedBalloonSet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060250F5 RID: 151797 RVA: 0x0094FECC File Offset: 0x0094E0CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BakedBalloonSet._ScriptStructPtr != 0) ? S_BakedBalloonSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BakedBalloonSet.S_BakedBalloonSet", ref S_BakedBalloonSet._ScriptStructPtr);
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x060250F6 RID: 151798 RVA: 0x0094FEF0 File Offset: 0x0094E0F0
		// (set) Token: 0x060250F7 RID: 151799 RVA: 0x0094FF33 File Offset: 0x0094E133
		[Nullable(1)]
		public TArray<UStaticMesh> SMarr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._SMarr) == null)
				{
					result = (this._SMarr = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)S_BakedBalloonSet.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMarr.CopyAssign(value);
			}
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x060250F8 RID: 151800 RVA: 0x0094FF41 File Offset: 0x0094E141
		// (set) Token: 0x060250F9 RID: 151801 RVA: 0x0094FF55 File Offset: 0x0094E155
		public unsafe UDataTable BakedDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x060250FA RID: 151802 RVA: 0x0094FF6A File Offset: 0x0094E16A
		// (set) Token: 0x060250FB RID: 151803 RVA: 0x0094FF7E File Offset: 0x0094E17E
		public unsafe UTexture2D Tex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x060250FC RID: 151804 RVA: 0x0094FF93 File Offset: 0x0094E193
		// (set) Token: 0x060250FD RID: 151805 RVA: 0x0094FFA7 File Offset: 0x0094E1A7
		public unsafe UTexture2D Tex_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_BakedBalloonSet.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060250FE RID: 151806 RVA: 0x0094FFBC File Offset: 0x0094E1BC
		public S_BakedBalloonSet()
		{
		}

		// Token: 0x060250FF RID: 151807 RVA: 0x0094FFC4 File Offset: 0x0094E1C4
		[NullableContext(1)]
		public S_BakedBalloonSet(TArray<UStaticMesh> SMarr, UDataTable BakedDA, UTexture2D Tex, UTexture2D Tex_N)
		{
			this.SMarr = SMarr;
			this.BakedDA = BakedDA;
			this.Tex = Tex;
			this.Tex_N = Tex_N;
		}

		// Token: 0x06025100 RID: 151808 RVA: 0x0094FFE9 File Offset: 0x0094E1E9
		protected override IntPtr GetUStructPtr()
		{
			return S_BakedBalloonSet.StaticStruct();
		}

		// Token: 0x06025101 RID: 151809 RVA: 0x0094FFF5 File Offset: 0x0094E1F5
		public S_BakedBalloonSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025102 RID: 151810 RVA: 0x0094FFFF File Offset: 0x0094E1FF
		public S_BakedBalloonSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025103 RID: 151811 RVA: 0x0095000A File Offset: 0x0094E20A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_BakedBalloonSet(Pointer, false, true);
		}

		// Token: 0x06025104 RID: 151812 RVA: 0x00950014 File Offset: 0x0094E214
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_BakedBalloonSet(Pointer, MemoryOwner);
		}

		// Token: 0x040126FA RID: 75514
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/S_BakedBalloonSet.S_BakedBalloonSet";

		// Token: 0x040126FB RID: 75515
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040126FC RID: 75516
		internal static int __PropertyOffset_0;

		// Token: 0x040126FD RID: 75517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _SMarr;

		// Token: 0x040126FE RID: 75518
		internal static int __PropertyOffset_1;

		// Token: 0x040126FF RID: 75519
		internal static int __PropertyOffset_2;

		// Token: 0x04012700 RID: 75520
		internal static int __PropertyOffset_3;
	}
}
