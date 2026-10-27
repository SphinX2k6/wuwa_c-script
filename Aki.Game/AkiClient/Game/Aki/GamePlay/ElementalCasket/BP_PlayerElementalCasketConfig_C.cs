using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003E66 RID: 15974
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class BP_PlayerElementalCasketConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060282DD RID: 164573 RVA: 0x009A5FF0 File Offset: 0x009A41F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlayerElementalCasketConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C");
			}
			return BP_PlayerElementalCasketConfig_C._ClassPtr;
		}

		// Token: 0x060282DE RID: 164574 RVA: 0x009A6014 File Offset: 0x009A4214
		public BP_PlayerElementalCasketConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlayerElementalCasketConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060282DF RID: 164575 RVA: 0x009A603C File Offset: 0x009A423C
		public BP_PlayerElementalCasketConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlayerElementalCasketConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x060282E0 RID: 164576 RVA: 0x009A6070 File Offset: 0x009A4270
		// (set) Token: 0x060282E1 RID: 164577 RVA: 0x009A60A9 File Offset: 0x009A42A9
		public FSoftObjectPath 匣子核心路径
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._匣子核心路径) == null)
				{
					result = (this._匣子核心路径 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C28 RID: 23592
		// (get) Token: 0x060282E2 RID: 164578 RVA: 0x009A60CA File Offset: 0x009A42CA
		// (set) Token: 0x060282E3 RID: 164579 RVA: 0x009A60DA File Offset: 0x009A42DA
		public unsafe float 领域半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005C29 RID: 23593
		// (get) Token: 0x060282E4 RID: 164580 RVA: 0x009A60EC File Offset: 0x009A42EC
		// (set) Token: 0x060282E5 RID: 164581 RVA: 0x009A6125 File Offset: 0x009A4325
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> 领域元素配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> result;
				if ((result = this._领域元素配置) == null)
				{
					result = (this._领域元素配置 = new TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.领域元素配置.CopyAssign(value);
			}
		}

		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x060282E6 RID: 164582 RVA: 0x009A6134 File Offset: 0x009A4334
		// (set) Token: 0x060282E7 RID: 164583 RVA: 0x009A616D File Offset: 0x009A436D
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> 重置核心特效
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> result;
				if ((result = this._重置核心特效) == null)
				{
					result = (this._重置核心特效 = new TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.重置核心特效.CopyAssign(value);
			}
		}

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x060282E8 RID: 164584 RVA: 0x009A617B File Offset: 0x009A437B
		// (set) Token: 0x060282E9 RID: 164585 RVA: 0x009A618F File Offset: 0x009A438F
		public unsafe FVector 核心位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x060282EA RID: 164586 RVA: 0x009A61A4 File Offset: 0x009A43A4
		// (set) Token: 0x060282EB RID: 164587 RVA: 0x009A61B8 File Offset: 0x009A43B8
		public unsafe FRotator 核心基础旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x060282EC RID: 164588 RVA: 0x009A61CD File Offset: 0x009A43CD
		// (set) Token: 0x060282ED RID: 164589 RVA: 0x009A61DD File Offset: 0x009A43DD
		public unsafe float 拉取时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x060282EE RID: 164590 RVA: 0x009A61EE File Offset: 0x009A43EE
		// (set) Token: 0x060282EF RID: 164591 RVA: 0x009A61FE File Offset: 0x009A43FE
		public unsafe float 拉取延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x060282F0 RID: 164592 RVA: 0x009A620F File Offset: 0x009A440F
		// (set) Token: 0x060282F1 RID: 164593 RVA: 0x009A621F File Offset: 0x009A441F
		public unsafe float 牵引时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x060282F2 RID: 164594 RVA: 0x009A6230 File Offset: 0x009A4430
		// (set) Token: 0x060282F3 RID: 164595 RVA: 0x009A6240 File Offset: 0x009A4440
		public unsafe int 牵引高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x060282F4 RID: 164596 RVA: 0x009A6251 File Offset: 0x009A4451
		// (set) Token: 0x060282F5 RID: 164597 RVA: 0x009A6261 File Offset: 0x009A4461
		public unsafe float 归还时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x060282F6 RID: 164598 RVA: 0x009A6272 File Offset: 0x009A4472
		// (set) Token: 0x060282F7 RID: 164599 RVA: 0x009A6282 File Offset: 0x009A4482
		public unsafe float 归还延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x060282F8 RID: 164600 RVA: 0x009A6293 File Offset: 0x009A4493
		// (set) Token: 0x060282F9 RID: 164601 RVA: 0x009A62A3 File Offset: 0x009A44A3
		public unsafe float 下落时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x060282FA RID: 164602 RVA: 0x009A62B4 File Offset: 0x009A44B4
		// (set) Token: 0x060282FB RID: 164603 RVA: 0x009A62C4 File Offset: 0x009A44C4
		public unsafe int 下落高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x060282FC RID: 164604 RVA: 0x009A62D5 File Offset: 0x009A44D5
		// (set) Token: 0x060282FD RID: 164605 RVA: 0x009A62E5 File Offset: 0x009A44E5
		public unsafe int 位置插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x060282FE RID: 164606 RVA: 0x009A62F6 File Offset: 0x009A44F6
		// (set) Token: 0x060282FF RID: 164607 RVA: 0x009A6306 File Offset: 0x009A4506
		public unsafe int 旋转插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x06028300 RID: 164608 RVA: 0x009A6317 File Offset: 0x009A4517
		// (set) Token: 0x06028301 RID: 164609 RVA: 0x009A6327 File Offset: 0x009A4527
		public unsafe int 插值距离上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005C38 RID: 23608
		// (get) Token: 0x06028302 RID: 164610 RVA: 0x009A6338 File Offset: 0x009A4538
		// (set) Token: 0x06028303 RID: 164611 RVA: 0x009A6348 File Offset: 0x009A4548
		public unsafe float 匹配延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005C39 RID: 23609
		// (get) Token: 0x06028304 RID: 164612 RVA: 0x009A6359 File Offset: 0x009A4559
		// (set) Token: 0x06028305 RID: 164613 RVA: 0x009A6369 File Offset: 0x009A4569
		public unsafe float 匹配移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x06028306 RID: 164614 RVA: 0x009A637A File Offset: 0x009A457A
		// (set) Token: 0x06028307 RID: 164615 RVA: 0x009A638A File Offset: 0x009A458A
		public unsafe float 取消匹配延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x06028308 RID: 164616 RVA: 0x009A639B File Offset: 0x009A459B
		// (set) Token: 0x06028309 RID: 164617 RVA: 0x009A63AB File Offset: 0x009A45AB
		public unsafe float 取消匹配移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0602830A RID: 164618 RVA: 0x009A63BC File Offset: 0x009A45BC
		// (set) Token: 0x0602830B RID: 164619 RVA: 0x009A63F5 File Offset: 0x009A45F5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> 匣子核心音频
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> result;
				if ((result = this._匣子核心音频) == null)
				{
					result = (this._匣子核心音频 = new TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.匣子核心音频.CopyAssign(value);
			}
		}

		// Token: 0x0602830C RID: 164620 RVA: 0x009A6403 File Offset: 0x009A4603
		protected BP_PlayerElementalCasketConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401473C RID: 83772
		public new const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C";

		// Token: 0x0401473D RID: 83773
		private static IntPtr _ClassPtr;

		// Token: 0x0401473E RID: 83774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401473F RID: 83775
		internal static int __PropertyOffset_0;

		// Token: 0x04014740 RID: 83776
		[Nullable(2)]
		private FSoftObjectPath _匣子核心路径;

		// Token: 0x04014741 RID: 83777
		internal static int __PropertyOffset_1;

		// Token: 0x04014742 RID: 83778
		internal static int __PropertyOffset_2;

		// Token: 0x04014743 RID: 83779
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> _领域元素配置;

		// Token: 0x04014744 RID: 83780
		internal static int __PropertyOffset_3;

		// Token: 0x04014745 RID: 83781
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> _重置核心特效;

		// Token: 0x04014746 RID: 83782
		internal static int __PropertyOffset_4;

		// Token: 0x04014747 RID: 83783
		internal static int __PropertyOffset_5;

		// Token: 0x04014748 RID: 83784
		internal static int __PropertyOffset_6;

		// Token: 0x04014749 RID: 83785
		internal static int __PropertyOffset_7;

		// Token: 0x0401474A RID: 83786
		internal static int __PropertyOffset_8;

		// Token: 0x0401474B RID: 83787
		internal static int __PropertyOffset_9;

		// Token: 0x0401474C RID: 83788
		internal static int __PropertyOffset_10;

		// Token: 0x0401474D RID: 83789
		internal static int __PropertyOffset_11;

		// Token: 0x0401474E RID: 83790
		internal static int __PropertyOffset_12;

		// Token: 0x0401474F RID: 83791
		internal static int __PropertyOffset_13;

		// Token: 0x04014750 RID: 83792
		internal static int __PropertyOffset_14;

		// Token: 0x04014751 RID: 83793
		internal static int __PropertyOffset_15;

		// Token: 0x04014752 RID: 83794
		internal static int __PropertyOffset_16;

		// Token: 0x04014753 RID: 83795
		internal static int __PropertyOffset_17;

		// Token: 0x04014754 RID: 83796
		internal static int __PropertyOffset_18;

		// Token: 0x04014755 RID: 83797
		internal static int __PropertyOffset_19;

		// Token: 0x04014756 RID: 83798
		internal static int __PropertyOffset_20;

		// Token: 0x04014757 RID: 83799
		internal static int __PropertyOffset_21;

		// Token: 0x04014758 RID: 83800
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> _匣子核心音频;
	}
}
