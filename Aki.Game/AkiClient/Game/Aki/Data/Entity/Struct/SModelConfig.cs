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
	// Token: 0x02003223 RID: 12835
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1156)]
	public class SModelConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020087 RID: 131207 RVA: 0x0093B8D6 File Offset: 0x00939AD6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelConfig._ScriptStructPtr != 0) ? SModelConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig", ref SModelConfig._ScriptStructPtr);
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x06020088 RID: 131208 RVA: 0x0093B8FA File Offset: 0x00939AFA
		// (set) Token: 0x06020089 RID: 131209 RVA: 0x0093B90A File Offset: 0x00939B0A
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0602008A RID: 131210 RVA: 0x0093B91B File Offset: 0x00939B1B
		// (set) Token: 0x0602008B RID: 131211 RVA: 0x0093B93A File Offset: 0x00939B3A
		public TSoftClassPtr<AActor> 蓝图
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_蓝图, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_蓝图, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0602008C RID: 131212 RVA: 0x0093B95F File Offset: 0x00939B5F
		// (set) Token: 0x0602008D RID: 131213 RVA: 0x0093B97E File Offset: 0x00939B7E
		public TSoftObjectPtr<USkeletalMesh> 网格体
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_网格体, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_网格体, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0602008E RID: 131214 RVA: 0x0093B9A4 File Offset: 0x00939BA4
		// (set) Token: 0x0602008F RID: 131215 RVA: 0x0093B9E7 File Offset: 0x00939BE7
		public TArray<TSoftObjectPtr<USkeletalMesh>> 子网格体
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<USkeletalMesh>> result;
				if ((result = this._子网格体) == null)
				{
					result = (this._子网格体 = new TArray<TSoftObjectPtr<USkeletalMesh>>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_子网格体, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子网格体.CopyAssign(value);
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x06020090 RID: 131216 RVA: 0x0093B9F8 File Offset: 0x00939BF8
		// (set) Token: 0x06020091 RID: 131217 RVA: 0x0093BA3B File Offset: 0x00939C3B
		public TArray<SModelChildMeshConfig> UI用子网格体
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SModelChildMeshConfig> result;
				if ((result = this._UI用子网格体) == null)
				{
					result = (this._UI用子网格体 = new TArray<SModelChildMeshConfig>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_UI用子网格体, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UI用子网格体.CopyAssign(value);
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x06020092 RID: 131218 RVA: 0x0093BA4C File Offset: 0x00939C4C
		// (set) Token: 0x06020093 RID: 131219 RVA: 0x0093BA8F File Offset: 0x00939C8F
		public FSoftObjectPath DA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DA) == null)
				{
					result = (this._DA = new FSoftObjectPath(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_DA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_DA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x06020094 RID: 131220 RVA: 0x0093BAB0 File Offset: 0x00939CB0
		// (set) Token: 0x06020095 RID: 131221 RVA: 0x0093BACF File Offset: 0x00939CCF
		public TSoftClassPtr<UAnimInstance> 动画蓝图
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_动画蓝图, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_动画蓝图, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x06020096 RID: 131222 RVA: 0x0093BAF4 File Offset: 0x00939CF4
		// (set) Token: 0x06020097 RID: 131223 RVA: 0x0093BB08 File Offset: 0x00939D08
		public unsafe string 描述
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelConfig.__PropertyOffset_描述)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelConfig.__PropertyOffset_描述)), value);
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x06020098 RID: 131224 RVA: 0x0093BB20 File Offset: 0x00939D20
		// (set) Token: 0x06020099 RID: 131225 RVA: 0x0093BB63 File Offset: 0x00939D63
		public TMap<FGameplayTag, FSoftObjectPath> 动画列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._动画列表) == null)
				{
					result = (this._动画列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_动画列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.动画列表.CopyAssign(value);
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0602009A RID: 131226 RVA: 0x0093BB74 File Offset: 0x00939D74
		// (set) Token: 0x0602009B RID: 131227 RVA: 0x0093BBB7 File Offset: 0x00939DB7
		public TArray<string> BattleSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BattleSockets) == null)
				{
					result = (this._BattleSockets = new TArray<string>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_BattleSockets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BattleSockets.CopyAssign(value);
			}
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0602009C RID: 131228 RVA: 0x0093BBC8 File Offset: 0x00939DC8
		// (set) Token: 0x0602009D RID: 131229 RVA: 0x0093BC0B File Offset: 0x00939E0B
		public TArray<string> NormalSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NormalSockets) == null)
				{
					result = (this._NormalSockets = new TArray<string>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_NormalSockets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NormalSockets.CopyAssign(value);
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0602009E RID: 131230 RVA: 0x0093BC1C File Offset: 0x00939E1C
		// (set) Token: 0x0602009F RID: 131231 RVA: 0x0093BC5F File Offset: 0x00939E5F
		public TMap<FGameplayTag, FSoftObjectPath> 静态网格体列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._静态网格体列表) == null)
				{
					result = (this._静态网格体列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_静态网格体列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.静态网格体列表.CopyAssign(value);
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x060200A0 RID: 131232 RVA: 0x0093BC70 File Offset: 0x00939E70
		// (set) Token: 0x060200A1 RID: 131233 RVA: 0x0093BCB3 File Offset: 0x00939EB3
		public TMap<FGameplayTag, FSoftObjectPath> 常驻特效列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._常驻特效列表) == null)
				{
					result = (this._常驻特效列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_常驻特效列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.常驻特效列表.CopyAssign(value);
			}
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x060200A2 RID: 131234 RVA: 0x0093BCC4 File Offset: 0x00939EC4
		// (set) Token: 0x060200A3 RID: 131235 RVA: 0x0093BD07 File Offset: 0x00939F07
		public TMap<FGameplayTag, FSoftObjectPath> 变化特效列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FSoftObjectPath> result;
				if ((result = this._变化特效列表) == null)
				{
					result = (this._变化特效列表 = new TMap<FGameplayTag, FSoftObjectPath>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_变化特效列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.变化特效列表.CopyAssign(value);
			}
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x060200A4 RID: 131236 RVA: 0x0093BD18 File Offset: 0x00939F18
		// (set) Token: 0x060200A5 RID: 131237 RVA: 0x0093BD5B File Offset: 0x00939F5B
		public TMap<FGameplayTag, SNiagaraParam> 通用特效常驻参数
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SNiagaraParam> result;
				if ((result = this._通用特效常驻参数) == null)
				{
					result = (this._通用特效常驻参数 = new TMap<FGameplayTag, SNiagaraParam>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_通用特效常驻参数, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.通用特效常驻参数.CopyAssign(value);
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x060200A6 RID: 131238 RVA: 0x0093BD6C File Offset: 0x00939F6C
		// (set) Token: 0x060200A7 RID: 131239 RVA: 0x0093BDAF File Offset: 0x00939FAF
		public TMap<FGameplayTag, SNiagaraParam> 通用特效变化参数
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SNiagaraParam> result;
				if ((result = this._通用特效变化参数) == null)
				{
					result = (this._通用特效变化参数 = new TMap<FGameplayTag, SNiagaraParam>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_通用特效变化参数, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.通用特效变化参数.CopyAssign(value);
			}
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x060200A8 RID: 131240 RVA: 0x0093BDC0 File Offset: 0x00939FC0
		// (set) Token: 0x060200A9 RID: 131241 RVA: 0x0093BE03 File Offset: 0x0093A003
		public FSoftObjectPath 场景交互物
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._场景交互物) == null)
				{
					result = (this._场景交互物 = new FSoftObjectPath(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_场景交互物, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_场景交互物, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x060200AA RID: 131242 RVA: 0x0093BE24 File Offset: 0x0093A024
		// (set) Token: 0x060200AB RID: 131243 RVA: 0x0093BE67 File Offset: 0x0093A067
		public TMap<FGameplayTag, EKuroSceneInteractionState> 场景交互物状态列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, EKuroSceneInteractionState> result;
				if ((result = this._场景交互物状态列表) == null)
				{
					result = (this._场景交互物状态列表 = new TMap<FGameplayTag, EKuroSceneInteractionState>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_场景交互物状态列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.场景交互物状态列表.CopyAssign(value);
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x060200AC RID: 131244 RVA: 0x0093BE78 File Offset: 0x0093A078
		// (set) Token: 0x060200AD RID: 131245 RVA: 0x0093BEBB File Offset: 0x0093A0BB
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
					result = (this._场景交互物特效列表 = new TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_场景交互物特效列表, base.MemoryOwner ?? this));
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

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x060200AE RID: 131246 RVA: 0x0093BEC9 File Offset: 0x0093A0C9
		// (set) Token: 0x060200AF RID: 131247 RVA: 0x0093BED9 File Offset: 0x0093A0D9
		public unsafe bool IsHiddenWithCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_IsHiddenWithCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_IsHiddenWithCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x060200B0 RID: 131248 RVA: 0x0093BEEA File Offset: 0x0093A0EA
		// (set) Token: 0x060200B1 RID: 131249 RVA: 0x0093BEFA File Offset: 0x0093A0FA
		public unsafe float ModelAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ModelAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ModelAlpha) = value;
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x060200B2 RID: 131250 RVA: 0x0093BF0B File Offset: 0x0093A10B
		// (set) Token: 0x060200B3 RID: 131251 RVA: 0x0093BF1B File Offset: 0x0093A11B
		public unsafe int 名字Z偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_名字Z偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_名字Z偏移) = value;
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x060200B4 RID: 131252 RVA: 0x0093BF2C File Offset: 0x0093A12C
		// (set) Token: 0x060200B5 RID: 131253 RVA: 0x0093BF3C File Offset: 0x0093A13C
		public unsafe float 注释时的抬升角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_注释时的抬升角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_注释时的抬升角度) = value;
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x060200B6 RID: 131254 RVA: 0x0093BF4D File Offset: 0x0093A14D
		// (set) Token: 0x060200B7 RID: 131255 RVA: 0x0093BF61 File Offset: 0x0093A161
		[Nullable(0)]
		public unsafe TEnumAsByte<EBodyType> 体型类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_体型类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_体型类型) = value;
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x060200B8 RID: 131256 RVA: 0x0093BF76 File Offset: 0x0093A176
		// (set) Token: 0x060200B9 RID: 131257 RVA: 0x0093BF86 File Offset: 0x0093A186
		public unsafe bool 主角蓝透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_主角蓝透) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_主角蓝透) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x060200BA RID: 131258 RVA: 0x0093BF97 File Offset: 0x0093A197
		// (set) Token: 0x060200BB RID: 131259 RVA: 0x0093BFB6 File Offset: 0x0093A1B6
		public TSoftObjectPtr<UDataTable> 特效替换表
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_特效替换表, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_特效替换表, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x060200BC RID: 131260 RVA: 0x0093BFDB File Offset: 0x0093A1DB
		// (set) Token: 0x060200BD RID: 131261 RVA: 0x0093BFFA File Offset: 0x0093A1FA
		public TSoftObjectPtr<UDataTable> 蒙太奇替换表
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_蒙太奇替换表, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_蒙太奇替换表, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x060200BE RID: 131262 RVA: 0x0093C01F File Offset: 0x0093A21F
		// (set) Token: 0x060200BF RID: 131263 RVA: 0x0093C03E File Offset: 0x0093A23E
		public TSoftObjectPtr<USkeletalMesh> 声骸掉落替换模型
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_声骸掉落替换模型, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_声骸掉落替换模型, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x060200C0 RID: 131264 RVA: 0x0093C063 File Offset: 0x0093A263
		// (set) Token: 0x060200C1 RID: 131265 RVA: 0x0093C073 File Offset: 0x0093A273
		public unsafe bool 隐藏葫芦
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_隐藏葫芦) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_隐藏葫芦) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x060200C2 RID: 131266 RVA: 0x0093C084 File Offset: 0x0093A284
		// (set) Token: 0x060200C3 RID: 131267 RVA: 0x0093C0C7 File Offset: 0x0093A2C7
		public TArray<SModelDecorationConfig> UiModelDecorationArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SModelDecorationConfig> result;
				if ((result = this._UiModelDecorationArray) == null)
				{
					result = (this._UiModelDecorationArray = new TArray<SModelDecorationConfig>(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_UiModelDecorationArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UiModelDecorationArray.CopyAssign(value);
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x060200C4 RID: 131268 RVA: 0x0093C0D5 File Offset: 0x0093A2D5
		// (set) Token: 0x060200C5 RID: 131269 RVA: 0x0093C0E9 File Offset: 0x0093A2E9
		public unsafe FVectorDouble 骑摩托位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_骑摩托位置偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_骑摩托位置偏移) = value;
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x060200C6 RID: 131270 RVA: 0x0093C0FE File Offset: 0x0093A2FE
		// (set) Token: 0x060200C7 RID: 131271 RVA: 0x0093C10E File Offset: 0x0093A30E
		public unsafe int ToonCustomStencilValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ToonCustomStencilValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelConfig.__PropertyOffset_ToonCustomStencilValue) = value;
			}
		}

		// Token: 0x060200C8 RID: 131272 RVA: 0x0093C11F File Offset: 0x0093A31F
		public SModelConfig()
		{
		}

		// Token: 0x060200C9 RID: 131273 RVA: 0x0093C127 File Offset: 0x0093A327
		protected override IntPtr GetUStructPtr()
		{
			return SModelConfig.StaticStruct();
		}

		// Token: 0x060200CA RID: 131274 RVA: 0x0093C133 File Offset: 0x0093A333
		[NullableContext(2)]
		public SModelConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060200CB RID: 131275 RVA: 0x0093C13D File Offset: 0x0093A33D
		public SModelConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060200CC RID: 131276 RVA: 0x0093C148 File Offset: 0x0093A348
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelConfig(Pointer, false, true);
		}

		// Token: 0x060200CD RID: 131277 RVA: 0x0093C152 File Offset: 0x0093A352
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011362 RID: 70498
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelConfig.SModelConfig";

		// Token: 0x04011363 RID: 70499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011364 RID: 70500
		internal static int __PropertyOffset_ID;

		// Token: 0x04011365 RID: 70501
		internal static int __PropertyOffset_蓝图;

		// Token: 0x04011366 RID: 70502
		internal static int __PropertyOffset_网格体;

		// Token: 0x04011367 RID: 70503
		internal static int __PropertyOffset_子网格体;

		// Token: 0x04011368 RID: 70504
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USkeletalMesh>> _子网格体;

		// Token: 0x04011369 RID: 70505
		internal static int __PropertyOffset_UI用子网格体;

		// Token: 0x0401136A RID: 70506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SModelChildMeshConfig> _UI用子网格体;

		// Token: 0x0401136B RID: 70507
		internal static int __PropertyOffset_DA;

		// Token: 0x0401136C RID: 70508
		[Nullable(2)]
		private FSoftObjectPath _DA;

		// Token: 0x0401136D RID: 70509
		internal static int __PropertyOffset_动画蓝图;

		// Token: 0x0401136E RID: 70510
		internal static int __PropertyOffset_描述;

		// Token: 0x0401136F RID: 70511
		internal static int __PropertyOffset_动画列表;

		// Token: 0x04011370 RID: 70512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _动画列表;

		// Token: 0x04011371 RID: 70513
		internal static int __PropertyOffset_BattleSockets;

		// Token: 0x04011372 RID: 70514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BattleSockets;

		// Token: 0x04011373 RID: 70515
		internal static int __PropertyOffset_NormalSockets;

		// Token: 0x04011374 RID: 70516
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NormalSockets;

		// Token: 0x04011375 RID: 70517
		internal static int __PropertyOffset_静态网格体列表;

		// Token: 0x04011376 RID: 70518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _静态网格体列表;

		// Token: 0x04011377 RID: 70519
		internal static int __PropertyOffset_常驻特效列表;

		// Token: 0x04011378 RID: 70520
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _常驻特效列表;

		// Token: 0x04011379 RID: 70521
		internal static int __PropertyOffset_变化特效列表;

		// Token: 0x0401137A RID: 70522
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FSoftObjectPath> _变化特效列表;

		// Token: 0x0401137B RID: 70523
		internal static int __PropertyOffset_通用特效常驻参数;

		// Token: 0x0401137C RID: 70524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SNiagaraParam> _通用特效常驻参数;

		// Token: 0x0401137D RID: 70525
		internal static int __PropertyOffset_通用特效变化参数;

		// Token: 0x0401137E RID: 70526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SNiagaraParam> _通用特效变化参数;

		// Token: 0x0401137F RID: 70527
		internal static int __PropertyOffset_场景交互物;

		// Token: 0x04011380 RID: 70528
		[Nullable(2)]
		private FSoftObjectPath _场景交互物;

		// Token: 0x04011381 RID: 70529
		internal static int __PropertyOffset_场景交互物状态列表;

		// Token: 0x04011382 RID: 70530
		[Nullable(2)]
		private TMap<FGameplayTag, EKuroSceneInteractionState> _场景交互物状态列表;

		// Token: 0x04011383 RID: 70531
		internal static int __PropertyOffset_场景交互物特效列表;

		// Token: 0x04011384 RID: 70532
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<FGameplayTag, TEnumAsByte<ESceneInteractionEffect>> _场景交互物特效列表;

		// Token: 0x04011385 RID: 70533
		internal static int __PropertyOffset_IsHiddenWithCamera;

		// Token: 0x04011386 RID: 70534
		internal static int __PropertyOffset_ModelAlpha;

		// Token: 0x04011387 RID: 70535
		internal static int __PropertyOffset_名字Z偏移;

		// Token: 0x04011388 RID: 70536
		internal static int __PropertyOffset_注释时的抬升角度;

		// Token: 0x04011389 RID: 70537
		internal static int __PropertyOffset_体型类型;

		// Token: 0x0401138A RID: 70538
		internal static int __PropertyOffset_主角蓝透;

		// Token: 0x0401138B RID: 70539
		internal static int __PropertyOffset_特效替换表;

		// Token: 0x0401138C RID: 70540
		internal static int __PropertyOffset_蒙太奇替换表;

		// Token: 0x0401138D RID: 70541
		internal static int __PropertyOffset_声骸掉落替换模型;

		// Token: 0x0401138E RID: 70542
		internal static int __PropertyOffset_隐藏葫芦;

		// Token: 0x0401138F RID: 70543
		internal static int __PropertyOffset_UiModelDecorationArray;

		// Token: 0x04011390 RID: 70544
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SModelDecorationConfig> _UiModelDecorationArray;

		// Token: 0x04011391 RID: 70545
		internal static int __PropertyOffset_骑摩托位置偏移;

		// Token: 0x04011392 RID: 70546
		internal static int __PropertyOffset_ToonCustomStencilValue;
	}
}
