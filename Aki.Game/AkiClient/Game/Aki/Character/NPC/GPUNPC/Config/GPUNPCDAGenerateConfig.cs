using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.Config
{
	// Token: 0x02004192 RID: 16786
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCDAGenerateConfig.GPUNPCDAGenerateConfig")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class GPUNPCDAGenerateConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B8BC RID: 178364 RVA: 0x00A03A7D File Offset: 0x00A01C7D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GPUNPCDAGenerateConfig._ScriptStructPtr != 0) ? GPUNPCDAGenerateConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCDAGenerateConfig.GPUNPCDAGenerateConfig", ref GPUNPCDAGenerateConfig._ScriptStructPtr);
		}

		// Token: 0x17006BC4 RID: 27588
		// (get) Token: 0x0602B8BD RID: 178365 RVA: 0x00A03AA1 File Offset: 0x00A01CA1
		// (set) Token: 0x0602B8BE RID: 178366 RVA: 0x00A03AB5 File Offset: 0x00A01CB5
		[Nullable(2)]
		public unsafe USkeletalMesh 单个网格体_这个设置了NpcSetupData就无效_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCDAGenerateConfig.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCDAGenerateConfig.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006BC5 RID: 27589
		// (get) Token: 0x0602B8BF RID: 178367 RVA: 0x00A03ACA File Offset: 0x00A01CCA
		// (set) Token: 0x0602B8C0 RID: 178368 RVA: 0x00A03ADE File Offset: 0x00A01CDE
		[Nullable(2)]
		public unsafe PD_NpcSetupData_C NpcSetupData配置
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCDAGenerateConfig.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCDAGenerateConfig.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006BC6 RID: 27590
		// (get) Token: 0x0602B8C1 RID: 178369 RVA: 0x00A03AF4 File Offset: 0x00A01CF4
		// (set) Token: 0x0602B8C2 RID: 178370 RVA: 0x00A03B37 File Offset: 0x00A01D37
		public TArray<UBakedBoneTexture2D> 动画烘焙贴图
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBakedBoneTexture2D> result;
				if ((result = this._动画烘焙贴图) == null)
				{
					result = (this._动画烘焙贴图 = new TArray<UBakedBoneTexture2D>(base.NativePtr + (IntPtr)GPUNPCDAGenerateConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画烘焙贴图.CopyAssign(value);
			}
		}

		// Token: 0x17006BC7 RID: 27591
		// (get) Token: 0x0602B8C3 RID: 178371 RVA: 0x00A03B48 File Offset: 0x00A01D48
		// (set) Token: 0x0602B8C4 RID: 178372 RVA: 0x00A03B8B File Offset: 0x00A01D8B
		public TArray<UTexture2D> 动画起始时间噪声贴图
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._动画起始时间噪声贴图) == null)
				{
					result = (this._动画起始时间噪声贴图 = new TArray<UTexture2D>(base.NativePtr + (IntPtr)GPUNPCDAGenerateConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画起始时间噪声贴图.CopyAssign(value);
			}
		}

		// Token: 0x0602B8C5 RID: 178373 RVA: 0x00A03B99 File Offset: 0x00A01D99
		public GPUNPCDAGenerateConfig()
		{
		}

		// Token: 0x0602B8C6 RID: 178374 RVA: 0x00A03BA1 File Offset: 0x00A01DA1
		public GPUNPCDAGenerateConfig(USkeletalMesh 单个网格体_这个设置了NpcSetupData就无效_, PD_NpcSetupData_C NpcSetupData配置, TArray<UBakedBoneTexture2D> 动画烘焙贴图, TArray<UTexture2D> 动画起始时间噪声贴图)
		{
			this.单个网格体_这个设置了NpcSetupData就无效_ = 单个网格体_这个设置了NpcSetupData就无效_;
			this.NpcSetupData配置 = NpcSetupData配置;
			this.动画烘焙贴图 = 动画烘焙贴图;
			this.动画起始时间噪声贴图 = 动画起始时间噪声贴图;
		}

		// Token: 0x0602B8C7 RID: 178375 RVA: 0x00A03BC6 File Offset: 0x00A01DC6
		protected override IntPtr GetUStructPtr()
		{
			return GPUNPCDAGenerateConfig.StaticStruct();
		}

		// Token: 0x0602B8C8 RID: 178376 RVA: 0x00A03BD2 File Offset: 0x00A01DD2
		[NullableContext(2)]
		public GPUNPCDAGenerateConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B8C9 RID: 178377 RVA: 0x00A03BDC File Offset: 0x00A01DDC
		public GPUNPCDAGenerateConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B8CA RID: 178378 RVA: 0x00A03BE7 File Offset: 0x00A01DE7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GPUNPCDAGenerateConfig(Pointer, false, true);
		}

		// Token: 0x0602B8CB RID: 178379 RVA: 0x00A03BF1 File Offset: 0x00A01DF1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GPUNPCDAGenerateConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04016AC1 RID: 92865
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCDAGenerateConfig.GPUNPCDAGenerateConfig";

		// Token: 0x04016AC2 RID: 92866
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016AC3 RID: 92867
		internal static int __PropertyOffset_0;

		// Token: 0x04016AC4 RID: 92868
		internal static int __PropertyOffset_1;

		// Token: 0x04016AC5 RID: 92869
		internal static int __PropertyOffset_2;

		// Token: 0x04016AC6 RID: 92870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBakedBoneTexture2D> _动画烘焙贴图;

		// Token: 0x04016AC7 RID: 92871
		internal static int __PropertyOffset_3;

		// Token: 0x04016AC8 RID: 92872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _动画起始时间噪声贴图;
	}
}
