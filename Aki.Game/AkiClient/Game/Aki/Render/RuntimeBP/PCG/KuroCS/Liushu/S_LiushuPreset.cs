using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Liushu
{
	// Token: 0x02003C8C RID: 15500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_LiushuPreset.S_LiushuPreset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 77)]
	public class S_LiushuPreset : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602434A RID: 148298 RVA: 0x00937E22 File Offset: 0x00936022
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_LiushuPreset._ScriptStructPtr != 0) ? S_LiushuPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_LiushuPreset.S_LiushuPreset", ref S_LiushuPreset._ScriptStructPtr);
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x0602434B RID: 148299 RVA: 0x00937E46 File Offset: 0x00936046
		// (set) Token: 0x0602434C RID: 148300 RVA: 0x00937E5A File Offset: 0x0093605A
		[Nullable(2)]
		public unsafe UDataTable DT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + S_LiushuPreset.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_LiushuPreset.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x0602434D RID: 148301 RVA: 0x00937E70 File Offset: 0x00936070
		// (set) Token: 0x0602434E RID: 148302 RVA: 0x00937EB3 File Offset: 0x009360B3
		public TArray<int> SectionNeedToSwitch
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SectionNeedToSwitch) == null)
				{
					result = (this._SectionNeedToSwitch = new TArray<int>(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionNeedToSwitch.CopyAssign(value);
			}
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x0602434F RID: 148303 RVA: 0x00937EC4 File Offset: 0x009360C4
		// (set) Token: 0x06024350 RID: 148304 RVA: 0x00937F07 File Offset: 0x00936107
		public TArray<UMaterialInstanceConstant> HighQualityMats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._HighQualityMats) == null)
				{
					result = (this._HighQualityMats = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HighQualityMats.CopyAssign(value);
			}
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x06024351 RID: 148305 RVA: 0x00937F18 File Offset: 0x00936118
		// (set) Token: 0x06024352 RID: 148306 RVA: 0x00937F5B File Offset: 0x0093615B
		public TArray<UMaterialInstanceConstant> MiddleQualityMats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._MiddleQualityMats) == null)
				{
					result = (this._MiddleQualityMats = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MiddleQualityMats.CopyAssign(value);
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x06024353 RID: 148307 RVA: 0x00937F6C File Offset: 0x0093616C
		// (set) Token: 0x06024354 RID: 148308 RVA: 0x00937FAF File Offset: 0x009361AF
		public TArray<UMaterialInstanceConstant> LowQualityMats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._LowQualityMats) == null)
				{
					result = (this._LowQualityMats = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LowQualityMats.CopyAssign(value);
			}
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x06024355 RID: 148309 RVA: 0x00937FBD File Offset: 0x009361BD
		// (set) Token: 0x06024356 RID: 148310 RVA: 0x00937FCD File Offset: 0x009361CD
		public unsafe float BoundScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x06024357 RID: 148311 RVA: 0x00937FDE File Offset: 0x009361DE
		// (set) Token: 0x06024358 RID: 148312 RVA: 0x00937FEE File Offset: 0x009361EE
		public unsafe bool bAutoSetCenterBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_LiushuPreset.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024359 RID: 148313 RVA: 0x00937FFF File Offset: 0x009361FF
		public S_LiushuPreset()
		{
		}

		// Token: 0x0602435A RID: 148314 RVA: 0x00938007 File Offset: 0x00936207
		public S_LiushuPreset(UDataTable DT, TArray<int> SectionNeedToSwitch, TArray<UMaterialInstanceConstant> HighQualityMats, TArray<UMaterialInstanceConstant> MiddleQualityMats, TArray<UMaterialInstanceConstant> LowQualityMats, float BoundScale, bool bAutoSetCenterBox)
		{
			this.DT = DT;
			this.SectionNeedToSwitch = SectionNeedToSwitch;
			this.HighQualityMats = HighQualityMats;
			this.MiddleQualityMats = MiddleQualityMats;
			this.LowQualityMats = LowQualityMats;
			this.BoundScale = BoundScale;
			this.bAutoSetCenterBox = bAutoSetCenterBox;
		}

		// Token: 0x0602435B RID: 148315 RVA: 0x00938044 File Offset: 0x00936244
		protected override IntPtr GetUStructPtr()
		{
			return S_LiushuPreset.StaticStruct();
		}

		// Token: 0x0602435C RID: 148316 RVA: 0x00938050 File Offset: 0x00936250
		[NullableContext(2)]
		public S_LiushuPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602435D RID: 148317 RVA: 0x0093805A File Offset: 0x0093625A
		public S_LiushuPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602435E RID: 148318 RVA: 0x00938065 File Offset: 0x00936265
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_LiushuPreset(Pointer, false, true);
		}

		// Token: 0x0602435F RID: 148319 RVA: 0x0093806F File Offset: 0x0093626F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_LiushuPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04011F00 RID: 73472
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Liushu/S_LiushuPreset.S_LiushuPreset";

		// Token: 0x04011F01 RID: 73473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F02 RID: 73474
		internal static int __PropertyOffset_0;

		// Token: 0x04011F03 RID: 73475
		internal static int __PropertyOffset_1;

		// Token: 0x04011F04 RID: 73476
		[Nullable(2)]
		private TArray<int> _SectionNeedToSwitch;

		// Token: 0x04011F05 RID: 73477
		internal static int __PropertyOffset_2;

		// Token: 0x04011F06 RID: 73478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _HighQualityMats;

		// Token: 0x04011F07 RID: 73479
		internal static int __PropertyOffset_3;

		// Token: 0x04011F08 RID: 73480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _MiddleQualityMats;

		// Token: 0x04011F09 RID: 73481
		internal static int __PropertyOffset_4;

		// Token: 0x04011F0A RID: 73482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _LowQualityMats;

		// Token: 0x04011F0B RID: 73483
		internal static int __PropertyOffset_5;

		// Token: 0x04011F0C RID: 73484
		internal static int __PropertyOffset_6;
	}
}
