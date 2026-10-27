using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004018 RID: 16408
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 584)]
	public class SReBulletDataPerformance : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A0F4 RID: 172276 RVA: 0x009D4948 File Offset: 0x009D2B48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataPerformance._ScriptStructPtr != 0) ? SReBulletDataPerformance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance", ref SReBulletDataPerformance._ScriptStructPtr);
		}

		// Token: 0x1700668B RID: 26251
		// (get) Token: 0x0602A0F5 RID: 172277 RVA: 0x009D496C File Offset: 0x009D2B6C
		// (set) Token: 0x0602A0F6 RID: 172278 RVA: 0x009D497C File Offset: 0x009D2B7C
		public unsafe bool 接手父子弹的特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700668C RID: 26252
		// (get) Token: 0x0602A0F7 RID: 172279 RVA: 0x009D498D File Offset: 0x009D2B8D
		// (set) Token: 0x0602A0F8 RID: 172280 RVA: 0x009D49AC File Offset: 0x009D2BAC
		public TSoftObjectPtr<UEffectModelBase> 子弹特效DA
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x0602A0F9 RID: 172281 RVA: 0x009D49D4 File Offset: 0x009D2BD4
		// (set) Token: 0x0602A0FA RID: 172282 RVA: 0x009D4A17 File Offset: 0x009D2C17
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EBulletEffectParam>, string> 子弹特效DA参数
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
				TMap<TEnumAsByte<EBulletEffectParam>, string> result;
				if ((result = this._子弹特效DA参数) == null)
				{
					result = (this._子弹特效DA参数 = new TMap<TEnumAsByte<EBulletEffectParam>, string>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_2, base.MemoryOwner ?? this));
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
				this.子弹特效DA参数.CopyAssign(value);
			}
		}

		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x0602A0FB RID: 172283 RVA: 0x009D4A28 File Offset: 0x009D2C28
		// (set) Token: 0x0602A0FC RID: 172284 RVA: 0x009D4A6B File Offset: 0x009D2C6B
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> 特殊特效DA
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
				TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> result;
				if ((result = this._特殊特效DA) == null)
				{
					result = (this._特殊特效DA = new TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_3, base.MemoryOwner ?? this));
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
				this.特殊特效DA.CopyAssign(value);
			}
		}

		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x0602A0FD RID: 172285 RVA: 0x009D4A79 File Offset: 0x009D2C79
		// (set) Token: 0x0602A0FE RID: 172286 RVA: 0x009D4A89 File Offset: 0x009D2C89
		public unsafe bool 子弹销毁调用子弹停止特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x0602A0FF RID: 172287 RVA: 0x009D4A9C File Offset: 0x009D2C9C
		// (set) Token: 0x0602A100 RID: 172288 RVA: 0x009D4ADF File Offset: 0x009D2CDF
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> 命中特效DA
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
				TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> result;
				if ((result = this._命中特效DA) == null)
				{
					result = (this._命中特效DA = new TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_5, base.MemoryOwner ?? this));
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
				this.命中特效DA.CopyAssign(value);
			}
		}

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x0602A101 RID: 172289 RVA: 0x009D4AED File Offset: 0x009D2CED
		// (set) Token: 0x0602A102 RID: 172290 RVA: 0x009D4B01 File Offset: 0x009D2D01
		public unsafe string 命中音效
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataPerformance.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataPerformance.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x17006692 RID: 26258
		// (get) Token: 0x0602A103 RID: 172291 RVA: 0x009D4B16 File Offset: 0x009D2D16
		// (set) Token: 0x0602A104 RID: 172292 RVA: 0x009D4B35 File Offset: 0x009D2D35
		public TSoftClassPtr<UMatineeCameraShake> 生成时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_7, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x0602A105 RID: 172293 RVA: 0x009D4B5A File Offset: 0x009D2D5A
		// (set) Token: 0x0602A106 RID: 172294 RVA: 0x009D4B79 File Offset: 0x009D2D79
		public TSoftClassPtr<UMatineeCameraShake> 命中时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_8, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x0602A107 RID: 172295 RVA: 0x009D4B9E File Offset: 0x009D2D9E
		// (set) Token: 0x0602A108 RID: 172296 RVA: 0x009D4BBD File Offset: 0x009D2DBD
		public TSoftClassPtr<UMatineeCameraShake> 命中时受击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_9, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_9, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006695 RID: 26261
		// (get) Token: 0x0602A109 RID: 172297 RVA: 0x009D4BE2 File Offset: 0x009D2DE2
		// (set) Token: 0x0602A10A RID: 172298 RVA: 0x009D4C01 File Offset: 0x009D2E01
		public TSoftClassPtr<UMatineeCameraShake> 命中弱点时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_10, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006696 RID: 26262
		// (get) Token: 0x0602A10B RID: 172299 RVA: 0x009D4C26 File Offset: 0x009D2E26
		// (set) Token: 0x0602A10C RID: 172300 RVA: 0x009D4C36 File Offset: 0x009D2E36
		public unsafe int 最大震动次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006697 RID: 26263
		// (get) Token: 0x0602A10D RID: 172301 RVA: 0x009D4C47 File Offset: 0x009D2E47
		// (set) Token: 0x0602A10E RID: 172302 RVA: 0x009D4C57 File Offset: 0x009D2E57
		public unsafe bool 震屏关联到召唤兽主人
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006698 RID: 26264
		// (get) Token: 0x0602A10F RID: 172303 RVA: 0x009D4C68 File Offset: 0x009D2E68
		// (set) Token: 0x0602A110 RID: 172304 RVA: 0x009D4CAB File Offset: 0x009D2EAB
		public TArray<SBulletEffectOnHitConf> 命中特效配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletEffectOnHitConf> result;
				if ((result = this._命中特效配置) == null)
				{
					result = (this._命中特效配置 = new TArray<SBulletEffectOnHitConf>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中特效配置.CopyAssign(value);
			}
		}

		// Token: 0x17006699 RID: 26265
		// (get) Token: 0x0602A111 RID: 172305 RVA: 0x009D4CB9 File Offset: 0x009D2EB9
		// (set) Token: 0x0602A112 RID: 172306 RVA: 0x009D4CD8 File Offset: 0x009D2ED8
		public TSoftObjectPtr<PD_CharacterControllerData_C> 受击闪白
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_14, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_14, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602A113 RID: 172307 RVA: 0x009D4CFD File Offset: 0x009D2EFD
		public SReBulletDataPerformance()
		{
		}

		// Token: 0x0602A114 RID: 172308 RVA: 0x009D4D08 File Offset: 0x009D2F08
		public SReBulletDataPerformance(bool 接手父子弹的特效, TSoftObjectPtr<UEffectModelBase> 子弹特效DA, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EBulletEffectParam>, string> 子弹特效DA参数, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> 特殊特效DA, bool 子弹销毁调用子弹停止特效, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> 命中特效DA, string 命中音效, TSoftClassPtr<UMatineeCameraShake> 生成时攻击者震屏, TSoftClassPtr<UMatineeCameraShake> 命中时攻击者震屏, TSoftClassPtr<UMatineeCameraShake> 命中时受击者震屏, TSoftClassPtr<UMatineeCameraShake> 命中弱点时攻击者震屏, int 最大震动次数, bool 震屏关联到召唤兽主人, TArray<SBulletEffectOnHitConf> 命中特效配置, TSoftObjectPtr<PD_CharacterControllerData_C> 受击闪白)
		{
			this.接手父子弹的特效 = 接手父子弹的特效;
			this.子弹特效DA = 子弹特效DA;
			this.子弹特效DA参数 = 子弹特效DA参数;
			this.特殊特效DA = 特殊特效DA;
			this.子弹销毁调用子弹停止特效 = 子弹销毁调用子弹停止特效;
			this.命中特效DA = 命中特效DA;
			this.命中音效 = 命中音效;
			this.生成时攻击者震屏 = 生成时攻击者震屏;
			this.命中时攻击者震屏 = 命中时攻击者震屏;
			this.命中时受击者震屏 = 命中时受击者震屏;
			this.命中弱点时攻击者震屏 = 命中弱点时攻击者震屏;
			this.最大震动次数 = 最大震动次数;
			this.震屏关联到召唤兽主人 = 震屏关联到召唤兽主人;
			this.命中特效配置 = 命中特效配置;
			this.受击闪白 = 受击闪白;
		}

		// Token: 0x0602A115 RID: 172309 RVA: 0x009D4D90 File Offset: 0x009D2F90
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataPerformance.StaticStruct();
		}

		// Token: 0x0602A116 RID: 172310 RVA: 0x009D4D9C File Offset: 0x009D2F9C
		[NullableContext(2)]
		public SReBulletDataPerformance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A117 RID: 172311 RVA: 0x009D4DA6 File Offset: 0x009D2FA6
		public SReBulletDataPerformance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A118 RID: 172312 RVA: 0x009D4DB1 File Offset: 0x009D2FB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataPerformance(Pointer, false, true);
		}

		// Token: 0x0602A119 RID: 172313 RVA: 0x009D4DBB File Offset: 0x009D2FBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataPerformance(Pointer, MemoryOwner);
		}

		// Token: 0x04015A92 RID: 88722
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance";

		// Token: 0x04015A93 RID: 88723
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A94 RID: 88724
		internal static int __PropertyOffset_0;

		// Token: 0x04015A95 RID: 88725
		internal static int __PropertyOffset_1;

		// Token: 0x04015A96 RID: 88726
		internal static int __PropertyOffset_2;

		// Token: 0x04015A97 RID: 88727
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EBulletEffectParam>, string> _子弹特效DA参数;

		// Token: 0x04015A98 RID: 88728
		internal static int __PropertyOffset_3;

		// Token: 0x04015A99 RID: 88729
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> _特殊特效DA;

		// Token: 0x04015A9A RID: 88730
		internal static int __PropertyOffset_4;

		// Token: 0x04015A9B RID: 88731
		internal static int __PropertyOffset_5;

		// Token: 0x04015A9C RID: 88732
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> _命中特效DA;

		// Token: 0x04015A9D RID: 88733
		internal static int __PropertyOffset_6;

		// Token: 0x04015A9E RID: 88734
		internal static int __PropertyOffset_7;

		// Token: 0x04015A9F RID: 88735
		internal static int __PropertyOffset_8;

		// Token: 0x04015AA0 RID: 88736
		internal static int __PropertyOffset_9;

		// Token: 0x04015AA1 RID: 88737
		internal static int __PropertyOffset_10;

		// Token: 0x04015AA2 RID: 88738
		internal static int __PropertyOffset_11;

		// Token: 0x04015AA3 RID: 88739
		internal static int __PropertyOffset_12;

		// Token: 0x04015AA4 RID: 88740
		internal static int __PropertyOffset_13;

		// Token: 0x04015AA5 RID: 88741
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletEffectOnHitConf> _命中特效配置;

		// Token: 0x04015AA6 RID: 88742
		internal static int __PropertyOffset_14;
	}
}
