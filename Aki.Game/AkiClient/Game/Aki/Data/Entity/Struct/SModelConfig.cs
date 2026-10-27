using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using AkiClient.Game.Aki.Data.Entity.Enum;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8F RID: 16271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1156)]
	public class SModelConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029905 RID: 170245 RVA: 0x009C748B File Offset: 0x009C568B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelConfig._ScriptStructPtr != 0) ? SModelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig", ref SModelConfig._ScriptStructPtr);
		}

		// Token: 0x170063F2 RID: 25586
		// (get) Token: 0x06029906 RID: 170246 RVA: 0x009C74AF File Offset: 0x009C56AF
		// (set) Token: 0x06029907 RID: 170247 RVA: 0x009C74BF File Offset: 0x009C56BF
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170063F3 RID: 25587
		// (get) Token: 0x06029908 RID: 170248 RVA: 0x009C74D0 File Offset: 0x009C56D0
		// (set) Token: 0x06029909 RID: 170249 RVA: 0x009C74EF File Offset: 0x009C56EF
		public TSoftClassPtr<AActor> 蓝图
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063F4 RID: 25588
		// (get) Token: 0x0602990A RID: 170250 RVA: 0x009C7514 File Offset: 0x009C5714
		// (set) Token: 0x0602990B RID: 170251 RVA: 0x009C7533 File Offset: 0x009C5733
		public TSoftObjectPtr<USkeletalMesh> 网格体
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063F5 RID: 25589
		// (get) Token: 0x0602990C RID: 170252 RVA: 0x009C7558 File Offset: 0x009C5758
		// (set) Token: 0x0602990D RID: 170253 RVA: 0x009C759B File Offset: 0x009C579B
		public TArray<TSoftObjectPtr<USkeletalMesh>> 子网格体
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<USkeletalMesh>> result;
				if ((result = this._子网格体) == null)
				{
					result = (this._子网格体 = new TArray<TSoftObjectPtr<USkeletalMesh>>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子网格体.CopyAssign(value);
			}
		}

		// Token: 0x170063F6 RID: 25590
		// (get) Token: 0x0602990E RID: 170254 RVA: 0x009C75AC File Offset: 0x009C57AC
		// (set) Token: 0x0602990F RID: 170255 RVA: 0x009C75EF File Offset: 0x009C57EF
		public TArray<SModelChildMeshConfig> UI用子网格体
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SModelChildMeshConfig> result;
				if ((result = this._UI用子网格体) == null)
				{
					result = (this._UI用子网格体 = new TArray<SModelChildMeshConfig>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UI用子网格体.CopyAssign(value);
			}
		}

		// Token: 0x170063F7 RID: 25591
		// (get) Token: 0x06029910 RID: 170256 RVA: 0x009C7600 File Offset: 0x009C5800
		// (set) Token: 0x06029911 RID: 170257 RVA: 0x009C7643 File Offset: 0x009C5843
		public FSoftObjectPath DA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DA) == null)
				{
					result = (this._DA = new FSoftObjectPath(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063F8 RID: 25592
		// (get) Token: 0x06029912 RID: 170258 RVA: 0x009C7664 File Offset: 0x009C5864
		// (set) Token: 0x06029913 RID: 170259 RVA: 0x009C7683 File Offset: 0x009C5883
		public TSoftClassPtr<UAnimInstance> 动画蓝图
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063F9 RID: 25593
		// (get) Token: 0x06029914 RID: 170260 RVA: 0x009C76A8 File Offset: 0x009C58A8
		// (set) Token: 0x06029915 RID: 170261 RVA: 0x009C76BC File Offset: 0x009C58BC
		public unsafe string 描述
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelConfig.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelConfig.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x170063FA RID: 25594
		// (get) Token: 0x06029916 RID: 170262 RVA: 0x009C76D4 File Offset: 0x009C58D4
		// (set) Token: 0x06029917 RID: 170263 RVA: 0x009C7717 File Offset: 0x009C5917
		public TMap<FGameplayTag, FSoftObjectPath> 动画列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._动画列表) == null)
				{
					result = (this._动画列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画列表.CopyAssign(value);
			}
		}

		// Token: 0x170063FB RID: 25595
		// (get) Token: 0x06029918 RID: 170264 RVA: 0x009C7728 File Offset: 0x009C5928
		// (set) Token: 0x06029919 RID: 170265 RVA: 0x009C776B File Offset: 0x009C596B
		public TArray<string> BattleSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BattleSockets) == null)
				{
					result = (this._BattleSockets = new TArray<string>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BattleSockets.CopyAssign(value);
			}
		}

		// Token: 0x170063FC RID: 25596
		// (get) Token: 0x0602991A RID: 170266 RVA: 0x009C777C File Offset: 0x009C597C
		// (set) Token: 0x0602991B RID: 170267 RVA: 0x009C77BF File Offset: 0x009C59BF
		public TArray<string> NormalSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NormalSockets) == null)
				{
					result = (this._NormalSockets = new TArray<string>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NormalSockets.CopyAssign(value);
			}
		}

		// Token: 0x170063FD RID: 25597
		// (get) Token: 0x0602991C RID: 170268 RVA: 0x009C77D0 File Offset: 0x009C59D0
		// (set) Token: 0x0602991D RID: 170269 RVA: 0x009C7813 File Offset: 0x009C5A13
		public TMap<FGameplayTag, FSoftObjectPath> 静态网格体列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._静态网格体列表) == null)
				{
					result = (this._静态网格体列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.静态网格体列表.CopyAssign(value);
			}
		}

		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x0602991E RID: 170270 RVA: 0x009C7824 File Offset: 0x009C5A24
		// (set) Token: 0x0602991F RID: 170271 RVA: 0x009C7867 File Offset: 0x009C5A67
		public TMap<FGameplayTag, FSoftObjectPath> 常驻特效列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._常驻特效列表) == null)
				{
					result = (this._常驻特效列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.常驻特效列表.CopyAssign(value);
			}
		}

		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x06029920 RID: 170272 RVA: 0x009C7878 File Offset: 0x009C5A78
		// (set) Token: 0x06029921 RID: 170273 RVA: 0x009C78BB File Offset: 0x009C5ABB
		public TMap<FGameplayTag, FSoftObjectPath> 变化特效列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._变化特效列表) == null)
				{
					result = (this._变化特效列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.变化特效列表.CopyAssign(value);
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x06029922 RID: 170274 RVA: 0x009C78CC File Offset: 0x009C5ACC
		// (set) Token: 0x06029923 RID: 170275 RVA: 0x009C790F File Offset: 0x009C5B0F
		public TMap<FGameplayTag, SNiagaraParam> 通用特效常驻参数
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SNiagaraParam> result;
				if ((result = this._通用特效常驻参数) == null)
				{
					result = (this._通用特效常驻参数 = new TMap<FGameplayTag, SNiagaraParam>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_14, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.通用特效常驻参数.CopyAssign(value);
			}
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x06029924 RID: 170276 RVA: 0x009C7920 File Offset: 0x009C5B20
		// (set) Token: 0x06029925 RID: 170277 RVA: 0x009C7963 File Offset: 0x009C5B63
		public TMap<FGameplayTag, SNiagaraParam> 通用特效变化参数
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SNiagaraParam> result;
				if ((result = this._通用特效变化参数) == null)
				{
					result = (this._通用特效变化参数 = new TMap<FGameplayTag, SNiagaraParam>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_15, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.通用特效变化参数.CopyAssign(value);
			}
		}

		// Token: 0x17006402 RID: 25602
		// (get) Token: 0x06029926 RID: 170278 RVA: 0x009C7974 File Offset: 0x009C5B74
		// (set) Token: 0x06029927 RID: 170279 RVA: 0x009C79B7 File Offset: 0x009C5BB7
		public FSoftObjectPath 场景交互物
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._场景交互物) == null)
				{
					result = (this._场景交互物 = new FSoftObjectPath(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006403 RID: 25603
		// (get) Token: 0x06029928 RID: 170280 RVA: 0x009C79D8 File Offset: 0x009C5BD8
		// (set) Token: 0x06029929 RID: 170281 RVA: 0x009C7A1B File Offset: 0x009C5C1B
		public TMap<FGameplayTag, EKuroSceneInteractionState> 场景交互物状态列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, EKuroSceneInteractionState> result;
				if ((result = this._场景交互物状态列表) == null)
				{
					result = (this._场景交互物状态列表 = new TMap<FGameplayTag, EKuroSceneInteractionState>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.场景交互物状态列表.CopyAssign(value);
			}
		}

		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x0602992A RID: 170282 RVA: 0x009C7A2C File Offset: 0x009C5C2C
		// (set) Token: 0x0602992B RID: 170283 RVA: 0x009C7A6F File Offset: 0x009C5C6F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>> 场景交互物特效列表
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>> result;
				if ((result = this._场景交互物特效列表) == null)
				{
					result = (this._场景交互物特效列表 = new TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.场景交互物特效列表.CopyAssign(value);
			}
		}

		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x0602992C RID: 170284 RVA: 0x009C7A7D File Offset: 0x009C5C7D
		// (set) Token: 0x0602992D RID: 170285 RVA: 0x009C7A8D File Offset: 0x009C5C8D
		public unsafe bool IsHiddenWithCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x0602992E RID: 170286 RVA: 0x009C7A9E File Offset: 0x009C5C9E
		// (set) Token: 0x0602992F RID: 170287 RVA: 0x009C7AAE File Offset: 0x009C5CAE
		public unsafe float ModelAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x06029930 RID: 170288 RVA: 0x009C7ABF File Offset: 0x009C5CBF
		// (set) Token: 0x06029931 RID: 170289 RVA: 0x009C7ACF File Offset: 0x009C5CCF
		public unsafe int 名字Z偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x06029932 RID: 170290 RVA: 0x009C7AE0 File Offset: 0x009C5CE0
		// (set) Token: 0x06029933 RID: 170291 RVA: 0x009C7AF0 File Offset: 0x009C5CF0
		public unsafe float 注释时的抬升角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x06029934 RID: 170292 RVA: 0x009C7B01 File Offset: 0x009C5D01
		// (set) Token: 0x06029935 RID: 170293 RVA: 0x009C7B15 File Offset: 0x009C5D15
		[Nullable(0)]
		public unsafe TEnumAsByte<EBodyType> 体型类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_23);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x06029936 RID: 170294 RVA: 0x009C7B2A File Offset: 0x009C5D2A
		// (set) Token: 0x06029937 RID: 170295 RVA: 0x009C7B3A File Offset: 0x009C5D3A
		public unsafe bool 主角蓝透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x06029938 RID: 170296 RVA: 0x009C7B4B File Offset: 0x009C5D4B
		// (set) Token: 0x06029939 RID: 170297 RVA: 0x009C7B6A File Offset: 0x009C5D6A
		public TSoftObjectPtr<UDataTable> 特效替换表
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_25, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_25, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x0602993A RID: 170298 RVA: 0x009C7B8F File Offset: 0x009C5D8F
		// (set) Token: 0x0602993B RID: 170299 RVA: 0x009C7BAE File Offset: 0x009C5DAE
		public TSoftObjectPtr<UDataTable> 蒙太奇替换表
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_26, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_26, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x0602993C RID: 170300 RVA: 0x009C7BD3 File Offset: 0x009C5DD3
		// (set) Token: 0x0602993D RID: 170301 RVA: 0x009C7BF2 File Offset: 0x009C5DF2
		public TSoftObjectPtr<USkeletalMesh> 声骸掉落替换模型
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_27, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_27, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x0602993E RID: 170302 RVA: 0x009C7C17 File Offset: 0x009C5E17
		// (set) Token: 0x0602993F RID: 170303 RVA: 0x009C7C27 File Offset: 0x009C5E27
		public unsafe bool 隐藏葫芦
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x06029940 RID: 170304 RVA: 0x009C7C38 File Offset: 0x009C5E38
		// (set) Token: 0x06029941 RID: 170305 RVA: 0x009C7C7B File Offset: 0x009C5E7B
		public TArray<SModelDecorationConfig> UiModelDecorationArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SModelDecorationConfig> result;
				if ((result = this._UiModelDecorationArray) == null)
				{
					result = (this._UiModelDecorationArray = new TArray<SModelDecorationConfig>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_29, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UiModelDecorationArray.CopyAssign(value);
			}
		}

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x06029942 RID: 170306 RVA: 0x009C7C89 File Offset: 0x009C5E89
		// (set) Token: 0x06029943 RID: 170307 RVA: 0x009C7C9D File Offset: 0x009C5E9D
		public unsafe FVectorDouble 骑摩托位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x06029944 RID: 170308 RVA: 0x009C7CB2 File Offset: 0x009C5EB2
		// (set) Token: 0x06029945 RID: 170309 RVA: 0x009C7CC2 File Offset: 0x009C5EC2
		public unsafe int ToonCustomStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06029946 RID: 170310 RVA: 0x009C7CD3 File Offset: 0x009C5ED3
		public SModelConfig()
		{
		}

		// Token: 0x06029947 RID: 170311 RVA: 0x009C7CDC File Offset: 0x009C5EDC
		public SModelConfig(int ID, TSoftClassPtr<AActor> 蓝图, TSoftObjectPtr<USkeletalMesh> 网格体, TArray<TSoftObjectPtr<USkeletalMesh>> 子网格体, TArray<SModelChildMeshConfig> UI用子网格体, FSoftObjectPath DA, TSoftClassPtr<UAnimInstance> 动画蓝图, string 描述, TMap<FGameplayTag, FSoftObjectPath> 动画列表, TArray<string> BattleSockets, TArray<string> NormalSockets, TMap<FGameplayTag, FSoftObjectPath> 静态网格体列表, TMap<FGameplayTag, FSoftObjectPath> 常驻特效列表, TMap<FGameplayTag, FSoftObjectPath> 变化特效列表, TMap<FGameplayTag, SNiagaraParam> 通用特效常驻参数, TMap<FGameplayTag, SNiagaraParam> 通用特效变化参数, FSoftObjectPath 场景交互物, TMap<FGameplayTag, EKuroSceneInteractionState> 场景交互物状态列表, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>> 场景交互物特效列表, bool IsHiddenWithCamera, float ModelAlpha, int 名字Z偏移, float 注释时的抬升角度, [Nullable(0)] TEnumAsByte<EBodyType> 体型类型, bool 主角蓝透, TSoftObjectPtr<UDataTable> 特效替换表, TSoftObjectPtr<UDataTable> 蒙太奇替换表, TSoftObjectPtr<USkeletalMesh> 声骸掉落替换模型, bool 隐藏葫芦, TArray<SModelDecorationConfig> UiModelDecorationArray, FVectorDouble 骑摩托位置偏移, int ToonCustomStencilValue)
		{
			this.ID = ID;
			this.蓝图 = 蓝图;
			this.网格体 = 网格体;
			this.子网格体 = 子网格体;
			this.UI用子网格体 = UI用子网格体;
			this.DA = DA;
			this.动画蓝图 = 动画蓝图;
			this.描述 = 描述;
			this.动画列表 = 动画列表;
			this.BattleSockets = BattleSockets;
			this.NormalSockets = NormalSockets;
			this.静态网格体列表 = 静态网格体列表;
			this.常驻特效列表 = 常驻特效列表;
			this.变化特效列表 = 变化特效列表;
			this.通用特效常驻参数 = 通用特效常驻参数;
			this.通用特效变化参数 = 通用特效变化参数;
			this.场景交互物 = 场景交互物;
			this.场景交互物状态列表 = 场景交互物状态列表;
			this.场景交互物特效列表 = 场景交互物特效列表;
			this.IsHiddenWithCamera = IsHiddenWithCamera;
			this.ModelAlpha = ModelAlpha;
			this.名字Z偏移 = 名字Z偏移;
			this.注释时的抬升角度 = 注释时的抬升角度;
			this.体型类型 = 体型类型;
			this.主角蓝透 = 主角蓝透;
			this.特效替换表 = 特效替换表;
			this.蒙太奇替换表 = 蒙太奇替换表;
			this.声骸掉落替换模型 = 声骸掉落替换模型;
			this.隐藏葫芦 = 隐藏葫芦;
			this.UiModelDecorationArray = UiModelDecorationArray;
			this.骑摩托位置偏移 = 骑摩托位置偏移;
			this.ToonCustomStencilValue = ToonCustomStencilValue;
		}

		// Token: 0x06029948 RID: 170312 RVA: 0x009C7DEC File Offset: 0x009C5FEC
		protected override IntPtr GetUStructPtr()
		{
			return SModelConfig.StaticStruct();
		}

		// Token: 0x06029949 RID: 170313 RVA: 0x009C7DF8 File Offset: 0x009C5FF8
		[NullableContext(2)]
		public SModelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602994A RID: 170314 RVA: 0x009C7E02 File Offset: 0x009C6002
		public SModelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602994B RID: 170315 RVA: 0x009C7E0D File Offset: 0x009C600D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelConfig(Pointer, false, true);
		}

		// Token: 0x0602994C RID: 170316 RVA: 0x009C7E17 File Offset: 0x009C6017
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040154EC RID: 87276
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig";

		// Token: 0x040154ED RID: 87277
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154EE RID: 87278
		internal static int __PropertyOffset_0;

		// Token: 0x040154EF RID: 87279
		internal static int __PropertyOffset_1;

		// Token: 0x040154F0 RID: 87280
		internal static int __PropertyOffset_2;

		// Token: 0x040154F1 RID: 87281
		internal static int __PropertyOffset_3;

		// Token: 0x040154F2 RID: 87282
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USkeletalMesh>> _子网格体;

		// Token: 0x040154F3 RID: 87283
		internal static int __PropertyOffset_4;

		// Token: 0x040154F4 RID: 87284
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SModelChildMeshConfig> _UI用子网格体;

		// Token: 0x040154F5 RID: 87285
		internal static int __PropertyOffset_5;

		// Token: 0x040154F6 RID: 87286
		[Nullable(2)]
		private FSoftObjectPath _DA;

		// Token: 0x040154F7 RID: 87287
		internal static int __PropertyOffset_6;

		// Token: 0x040154F8 RID: 87288
		internal static int __PropertyOffset_7;

		// Token: 0x040154F9 RID: 87289
		internal static int __PropertyOffset_8;

		// Token: 0x040154FA RID: 87290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _动画列表;

		// Token: 0x040154FB RID: 87291
		internal static int __PropertyOffset_9;

		// Token: 0x040154FC RID: 87292
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BattleSockets;

		// Token: 0x040154FD RID: 87293
		internal static int __PropertyOffset_10;

		// Token: 0x040154FE RID: 87294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NormalSockets;

		// Token: 0x040154FF RID: 87295
		internal static int __PropertyOffset_11;

		// Token: 0x04015500 RID: 87296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _静态网格体列表;

		// Token: 0x04015501 RID: 87297
		internal static int __PropertyOffset_12;

		// Token: 0x04015502 RID: 87298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _常驻特效列表;

		// Token: 0x04015503 RID: 87299
		internal static int __PropertyOffset_13;

		// Token: 0x04015504 RID: 87300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _变化特效列表;

		// Token: 0x04015505 RID: 87301
		internal static int __PropertyOffset_14;

		// Token: 0x04015506 RID: 87302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SNiagaraParam> _通用特效常驻参数;

		// Token: 0x04015507 RID: 87303
		internal static int __PropertyOffset_15;

		// Token: 0x04015508 RID: 87304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SNiagaraParam> _通用特效变化参数;

		// Token: 0x04015509 RID: 87305
		internal static int __PropertyOffset_16;

		// Token: 0x0401550A RID: 87306
		[Nullable(2)]
		private FSoftObjectPath _场景交互物;

		// Token: 0x0401550B RID: 87307
		internal static int __PropertyOffset_17;

		// Token: 0x0401550C RID: 87308
		[Nullable(2)]
		private TMap<FGameplayTag, EKuroSceneInteractionState> _场景交互物状态列表;

		// Token: 0x0401550D RID: 87309
		internal static int __PropertyOffset_18;

		// Token: 0x0401550E RID: 87310
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>> _场景交互物特效列表;

		// Token: 0x0401550F RID: 87311
		internal static int __PropertyOffset_19;

		// Token: 0x04015510 RID: 87312
		internal static int __PropertyOffset_20;

		// Token: 0x04015511 RID: 87313
		internal static int __PropertyOffset_21;

		// Token: 0x04015512 RID: 87314
		internal static int __PropertyOffset_22;

		// Token: 0x04015513 RID: 87315
		internal static int __PropertyOffset_23;

		// Token: 0x04015514 RID: 87316
		internal static int __PropertyOffset_24;

		// Token: 0x04015515 RID: 87317
		internal static int __PropertyOffset_25;

		// Token: 0x04015516 RID: 87318
		internal static int __PropertyOffset_26;

		// Token: 0x04015517 RID: 87319
		internal static int __PropertyOffset_27;

		// Token: 0x04015518 RID: 87320
		internal static int __PropertyOffset_28;

		// Token: 0x04015519 RID: 87321
		internal static int __PropertyOffset_29;

		// Token: 0x0401551A RID: 87322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SModelDecorationConfig> _UiModelDecorationArray;

		// Token: 0x0401551B RID: 87323
		internal static int __PropertyOffset_30;

		// Token: 0x0401551C RID: 87324
		internal static int __PropertyOffset_31;
	}
}
