using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333F RID: 13119
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 364)]
	public class SCharacterPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021295 RID: 135829 RVA: 0x0095A957 File Offset: 0x00958B57
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterPart._ScriptStructPtr != 0) ? SCharacterPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart", ref SCharacterPart._ScriptStructPtr);
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x06021296 RID: 135830 RVA: 0x0095A97B File Offset: 0x00958B7B
		// (set) Token: 0x06021297 RID: 135831 RVA: 0x0095A98F File Offset: 0x00958B8F
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x06021298 RID: 135832 RVA: 0x0095A9A4 File Offset: 0x00958BA4
		// (set) Token: 0x06021299 RID: 135833 RVA: 0x0095A9E7 File Offset: 0x00958BE7
		public TArray<string> 骨骼名
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._骨骼名) == null)
				{
					result = (this._骨骼名 = new TArray<string>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_骨骼名, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.骨骼名.CopyAssign(value);
			}
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x0602129A RID: 135834 RVA: 0x0095A9F5 File Offset: 0x00958BF5
		// (set) Token: 0x0602129B RID: 135835 RVA: 0x0095AA05 File Offset: 0x00958C05
		public unsafe bool 是否独立承伤
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否独立承伤) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否独立承伤) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x0602129C RID: 135836 RVA: 0x0095AA16 File Offset: 0x00958C16
		// (set) Token: 0x0602129D RID: 135837 RVA: 0x0095AA26 File Offset: 0x00958C26
		public unsafe bool 是否出生激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否出生激活) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否出生激活) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x0602129E RID: 135838 RVA: 0x0095AA37 File Offset: 0x00958C37
		// (set) Token: 0x0602129F RID: 135839 RVA: 0x0095AA4B File Offset: 0x00958C4B
		public unsafe FGameplayTag 部位标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位标签) = value;
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x060212A0 RID: 135840 RVA: 0x0095AA60 File Offset: 0x00958C60
		// (set) Token: 0x060212A1 RID: 135841 RVA: 0x0095AA74 File Offset: 0x00958C74
		public unsafe FGameplayTag 部位激活标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位激活标签);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位激活标签) = value;
			}
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x060212A2 RID: 135842 RVA: 0x0095AA89 File Offset: 0x00958C89
		// (set) Token: 0x060212A3 RID: 135843 RVA: 0x0095AA99 File Offset: 0x00958C99
		public unsafe float 继承生命值比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_继承生命值比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_继承生命值比例) = value;
			}
		}

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x060212A4 RID: 135844 RVA: 0x0095AAAA File Offset: 0x00958CAA
		// (set) Token: 0x060212A5 RID: 135845 RVA: 0x0095AABA File Offset: 0x00958CBA
		public unsafe bool 是否弱点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否弱点) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否弱点) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x060212A6 RID: 135846 RVA: 0x0095AACC File Offset: 0x00958CCC
		// (set) Token: 0x060212A7 RID: 135847 RVA: 0x0095AB0F File Offset: 0x00958D0F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TSet<TEnumAsByte<EBulletType>> 弱点攻击类型
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TEnumAsByte<EBulletType>> result;
				if ((result = this._弱点攻击类型) == null)
				{
					result = (this._弱点攻击类型 = new TSet<TEnumAsByte<EBulletType>>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_弱点攻击类型, base.MemoryOwner ?? this));
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
				this.弱点攻击类型.CopyAssign(value);
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x060212A8 RID: 135848 RVA: 0x0095AB1D File Offset: 0x00958D1D
		// (set) Token: 0x060212A9 RID: 135849 RVA: 0x0095AB2D File Offset: 0x00958D2D
		public unsafe float 弱点受击角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_弱点受击角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_弱点受击角度) = value;
			}
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x060212AA RID: 135850 RVA: 0x0095AB3E File Offset: 0x00958D3E
		// (set) Token: 0x060212AB RID: 135851 RVA: 0x0095AB4E File Offset: 0x00958D4E
		public unsafe bool 精准弱点受击角度判定
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_精准弱点受击角度判定) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_精准弱点受击角度判定) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x060212AC RID: 135852 RVA: 0x0095AB60 File Offset: 0x00958D60
		// (set) Token: 0x060212AD RID: 135853 RVA: 0x0095ABA3 File Offset: 0x00958DA3
		public TMap<string, string> 碰撞框朝向
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._碰撞框朝向) == null)
				{
					result = (this._碰撞框朝向 = new TMap<string, string>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_碰撞框朝向, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.碰撞框朝向.CopyAssign(value);
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x060212AE RID: 135854 RVA: 0x0095ABB1 File Offset: 0x00958DB1
		// (set) Token: 0x060212AF RID: 135855 RVA: 0x0095ABC1 File Offset: 0x00958DC1
		public unsafe bool 是否盾牌
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否盾牌) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否盾牌) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x060212B0 RID: 135856 RVA: 0x0095ABD2 File Offset: 0x00958DD2
		// (set) Token: 0x060212B1 RID: 135857 RVA: 0x0095ABE2 File Offset: 0x00958DE2
		public unsafe float 格挡判定角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_格挡判定角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_格挡判定角度) = value;
			}
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x060212B2 RID: 135858 RVA: 0x0095ABF3 File Offset: 0x00958DF3
		// (set) Token: 0x060212B3 RID: 135859 RVA: 0x0095AC03 File Offset: 0x00958E03
		public unsafe bool 是否传递伤害
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否传递伤害) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否传递伤害) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x060212B4 RID: 135860 RVA: 0x0095AC14 File Offset: 0x00958E14
		// (set) Token: 0x060212B5 RID: 135861 RVA: 0x0095AC24 File Offset: 0x00958E24
		public unsafe bool 是否在目标创建时显示部位状态条
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否在目标创建时显示部位状态条) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_是否在目标创建时显示部位状态条) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x060212B6 RID: 135862 RVA: 0x0095AC35 File Offset: 0x00958E35
		// (set) Token: 0x060212B7 RID: 135863 RVA: 0x0095AC49 File Offset: 0x00958E49
		public unsafe FName 部位状态条骨骼插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位状态条骨骼插槽);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_部位状态条骨骼插槽) = value;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x060212B8 RID: 135864 RVA: 0x0095AC5E File Offset: 0x00958E5E
		// (set) Token: 0x060212B9 RID: 135865 RVA: 0x0095AC6E File Offset: 0x00958E6E
		public unsafe float 受击后血条显示时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_受击后血条显示时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_受击后血条显示时长) = value;
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x060212BA RID: 135866 RVA: 0x0095AC80 File Offset: 0x00958E80
		// (set) Token: 0x060212BB RID: 135867 RVA: 0x0095ACC3 File Offset: 0x00958EC3
		public TArray<long> 属性快照Buff列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._属性快照Buff列表) == null)
				{
					result = (this._属性快照Buff列表 = new TArray<long>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_属性快照Buff列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.属性快照Buff列表.CopyAssign(value);
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x060212BC RID: 135868 RVA: 0x0095ACD1 File Offset: 0x00958ED1
		// (set) Token: 0x060212BD RID: 135869 RVA: 0x0095ACE5 File Offset: 0x00958EE5
		[Nullable(2)]
		public unsafe UEffectModelBase 扫描特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_扫描特效);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_扫描特效, value);
			}
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x060212BE RID: 135870 RVA: 0x0095ACFC File Offset: 0x00958EFC
		// (set) Token: 0x060212BF RID: 135871 RVA: 0x0095AD3F File Offset: 0x00958F3F
		public FSoftObjectPath 被扫描播放特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._被扫描播放特效) == null)
				{
					result = (this._被扫描播放特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_被扫描播放特效, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_被扫描播放特效, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x060212C0 RID: 135872 RVA: 0x0095AD60 File Offset: 0x00958F60
		// (set) Token: 0x060212C1 RID: 135873 RVA: 0x0095AD74 File Offset: 0x00958F74
		public unsafe string 扫描特效绑定骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_扫描特效绑定骨骼名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_扫描特效绑定骨骼名)), value);
			}
		}

		// Token: 0x170042FC RID: 17148
		// (get) Token: 0x060212C2 RID: 135874 RVA: 0x0095AD89 File Offset: 0x00958F89
		// (set) Token: 0x060212C3 RID: 135875 RVA: 0x0095AD9D File Offset: 0x00958F9D
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C 扫描材质特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_扫描材质特效);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_扫描材质特效, value);
			}
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x060212C4 RID: 135876 RVA: 0x0095ADB2 File Offset: 0x00958FB2
		// (set) Token: 0x060212C5 RID: 135877 RVA: 0x0095ADC6 File Offset: 0x00958FC6
		public unsafe FName 合体骨骼名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_合体骨骼名);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_合体骨骼名) = value;
			}
		}

		// Token: 0x060212C6 RID: 135878 RVA: 0x0095ADDB File Offset: 0x00958FDB
		public SCharacterPart()
		{
		}

		// Token: 0x060212C7 RID: 135879 RVA: 0x0095ADE3 File Offset: 0x00958FE3
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterPart.StaticStruct();
		}

		// Token: 0x060212C8 RID: 135880 RVA: 0x0095ADEF File Offset: 0x00958FEF
		[NullableContext(2)]
		public SCharacterPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212C9 RID: 135881 RVA: 0x0095ADF9 File Offset: 0x00958FF9
		public SCharacterPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212CA RID: 135882 RVA: 0x0095AE04 File Offset: 0x00959004
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterPart(Pointer, false, true);
		}

		// Token: 0x060212CB RID: 135883 RVA: 0x0095AE0E File Offset: 0x0095900E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterPart(Pointer, MemoryOwner);
		}

		// Token: 0x04012215 RID: 74261
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart";

		// Token: 0x04012216 RID: 74262
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012217 RID: 74263
		internal static int __PropertyOffset_部位名;

		// Token: 0x04012218 RID: 74264
		internal static int __PropertyOffset_骨骼名;

		// Token: 0x04012219 RID: 74265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _骨骼名;

		// Token: 0x0401221A RID: 74266
		internal static int __PropertyOffset_是否独立承伤;

		// Token: 0x0401221B RID: 74267
		internal static int __PropertyOffset_是否出生激活;

		// Token: 0x0401221C RID: 74268
		internal static int __PropertyOffset_部位标签;

		// Token: 0x0401221D RID: 74269
		internal static int __PropertyOffset_部位激活标签;

		// Token: 0x0401221E RID: 74270
		internal static int __PropertyOffset_继承生命值比例;

		// Token: 0x0401221F RID: 74271
		internal static int __PropertyOffset_是否弱点;

		// Token: 0x04012220 RID: 74272
		internal static int __PropertyOffset_弱点攻击类型;

		// Token: 0x04012221 RID: 74273
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<EBulletType>> _弱点攻击类型;

		// Token: 0x04012222 RID: 74274
		internal static int __PropertyOffset_弱点受击角度;

		// Token: 0x04012223 RID: 74275
		internal static int __PropertyOffset_精准弱点受击角度判定;

		// Token: 0x04012224 RID: 74276
		internal static int __PropertyOffset_碰撞框朝向;

		// Token: 0x04012225 RID: 74277
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _碰撞框朝向;

		// Token: 0x04012226 RID: 74278
		internal static int __PropertyOffset_是否盾牌;

		// Token: 0x04012227 RID: 74279
		internal static int __PropertyOffset_格挡判定角度;

		// Token: 0x04012228 RID: 74280
		internal static int __PropertyOffset_是否传递伤害;

		// Token: 0x04012229 RID: 74281
		internal static int __PropertyOffset_是否在目标创建时显示部位状态条;

		// Token: 0x0401222A RID: 74282
		internal static int __PropertyOffset_部位状态条骨骼插槽;

		// Token: 0x0401222B RID: 74283
		internal static int __PropertyOffset_受击后血条显示时长;

		// Token: 0x0401222C RID: 74284
		internal static int __PropertyOffset_属性快照Buff列表;

		// Token: 0x0401222D RID: 74285
		[Nullable(2)]
		private TArray<long> _属性快照Buff列表;

		// Token: 0x0401222E RID: 74286
		internal static int __PropertyOffset_扫描特效;

		// Token: 0x0401222F RID: 74287
		internal static int __PropertyOffset_被扫描播放特效;

		// Token: 0x04012230 RID: 74288
		[Nullable(2)]
		private FSoftObjectPath _被扫描播放特效;

		// Token: 0x04012231 RID: 74289
		internal static int __PropertyOffset_扫描特效绑定骨骼名;

		// Token: 0x04012232 RID: 74290
		internal static int __PropertyOffset_扫描材质特效;

		// Token: 0x04012233 RID: 74291
		internal static int __PropertyOffset_合体骨骼名;
	}
}
