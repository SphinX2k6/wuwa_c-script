using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003279 RID: 12921
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 584)]
	public class SReBulletDataPerformance : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602049E RID: 132254 RVA: 0x00941FC4 File Offset: 0x009401C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataPerformance._ScriptStructPtr != 0) ? SReBulletDataPerformance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance", ref SReBulletDataPerformance._ScriptStructPtr);
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0602049F RID: 132255 RVA: 0x00941FE8 File Offset: 0x009401E8
		// (set) Token: 0x060204A0 RID: 132256 RVA: 0x00941FF8 File Offset: 0x009401F8
		public unsafe bool 接手父子弹的特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_接手父子弹的特效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_接手父子弹的特效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x060204A1 RID: 132257 RVA: 0x00942009 File Offset: 0x00940209
		// (set) Token: 0x060204A2 RID: 132258 RVA: 0x00942028 File Offset: 0x00940228
		public TSoftObjectPtr<UEffectModelBase> 子弹特效DA
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_子弹特效DA, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_子弹特效DA, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x060204A3 RID: 132259 RVA: 0x00942050 File Offset: 0x00940250
		// (set) Token: 0x060204A4 RID: 132260 RVA: 0x00942093 File Offset: 0x00940293
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
					result = (this._子弹特效DA参数 = new TMap<TEnumAsByte<EBulletEffectParam>, string>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_子弹特效DA参数, base.MemoryOwner ?? this));
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

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x060204A5 RID: 132261 RVA: 0x009420A4 File Offset: 0x009402A4
		// (set) Token: 0x060204A6 RID: 132262 RVA: 0x009420E7 File Offset: 0x009402E7
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
					result = (this._特殊特效DA = new TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_特殊特效DA, base.MemoryOwner ?? this));
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

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x060204A7 RID: 132263 RVA: 0x009420F5 File Offset: 0x009402F5
		// (set) Token: 0x060204A8 RID: 132264 RVA: 0x00942105 File Offset: 0x00940305
		public unsafe bool 子弹销毁调用子弹停止特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_子弹销毁调用子弹停止特效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_子弹销毁调用子弹停止特效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x060204A9 RID: 132265 RVA: 0x00942118 File Offset: 0x00940318
		// (set) Token: 0x060204AA RID: 132266 RVA: 0x0094215B File Offset: 0x0094035B
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
					result = (this._命中特效DA = new TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中特效DA, base.MemoryOwner ?? this));
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

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x060204AB RID: 132267 RVA: 0x00942169 File Offset: 0x00940369
		// (set) Token: 0x060204AC RID: 132268 RVA: 0x0094217D File Offset: 0x0094037D
		public unsafe string 命中音效
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataPerformance.__PropertyOffset_命中音效)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataPerformance.__PropertyOffset_命中音效)), value);
			}
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x060204AD RID: 132269 RVA: 0x00942192 File Offset: 0x00940392
		// (set) Token: 0x060204AE RID: 132270 RVA: 0x009421B1 File Offset: 0x009403B1
		public TSoftClassPtr<UMatineeCameraShake> 生成时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_生成时攻击者震屏, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_生成时攻击者震屏, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x060204AF RID: 132271 RVA: 0x009421D6 File Offset: 0x009403D6
		// (set) Token: 0x060204B0 RID: 132272 RVA: 0x009421F5 File Offset: 0x009403F5
		public TSoftClassPtr<UMatineeCameraShake> 命中时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中时攻击者震屏, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中时攻击者震屏, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x060204B1 RID: 132273 RVA: 0x0094221A File Offset: 0x0094041A
		// (set) Token: 0x060204B2 RID: 132274 RVA: 0x00942239 File Offset: 0x00940439
		public TSoftClassPtr<UMatineeCameraShake> 命中时受击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中时受击者震屏, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中时受击者震屏, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x060204B3 RID: 132275 RVA: 0x0094225E File Offset: 0x0094045E
		// (set) Token: 0x060204B4 RID: 132276 RVA: 0x0094227D File Offset: 0x0094047D
		public TSoftClassPtr<UMatineeCameraShake> 命中弱点时攻击者震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中弱点时攻击者震屏, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中弱点时攻击者震屏, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x060204B5 RID: 132277 RVA: 0x009422A2 File Offset: 0x009404A2
		// (set) Token: 0x060204B6 RID: 132278 RVA: 0x009422B2 File Offset: 0x009404B2
		public unsafe int 最大震动次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_最大震动次数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_最大震动次数) = value;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x060204B7 RID: 132279 RVA: 0x009422C3 File Offset: 0x009404C3
		// (set) Token: 0x060204B8 RID: 132280 RVA: 0x009422D3 File Offset: 0x009404D3
		public unsafe bool 震屏关联到召唤兽主人
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_震屏关联到召唤兽主人) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_震屏关联到召唤兽主人) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x060204B9 RID: 132281 RVA: 0x009422E4 File Offset: 0x009404E4
		// (set) Token: 0x060204BA RID: 132282 RVA: 0x00942327 File Offset: 0x00940527
		public TArray<SBulletEffectOnHitConf> 命中特效配置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletEffectOnHitConf> result;
				if ((result = this._命中特效配置) == null)
				{
					result = (this._命中特效配置 = new TArray<SBulletEffectOnHitConf>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_命中特效配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.命中特效配置.CopyAssign(value);
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x060204BB RID: 132283 RVA: 0x00942335 File Offset: 0x00940535
		// (set) Token: 0x060204BC RID: 132284 RVA: 0x00942354 File Offset: 0x00940554
		public TSoftObjectPtr<PD_CharacterControllerData_C> 受击闪白
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_受击闪白, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataPerformance.__PropertyOffset_受击闪白, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060204BD RID: 132285 RVA: 0x00942379 File Offset: 0x00940579
		public SReBulletDataPerformance()
		{
		}

		// Token: 0x060204BE RID: 132286 RVA: 0x00942381 File Offset: 0x00940581
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataPerformance.StaticStruct();
		}

		// Token: 0x060204BF RID: 132287 RVA: 0x0094238D File Offset: 0x0094058D
		[NullableContext(2)]
		public SReBulletDataPerformance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060204C0 RID: 132288 RVA: 0x00942397 File Offset: 0x00940597
		public SReBulletDataPerformance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060204C1 RID: 132289 RVA: 0x009423A2 File Offset: 0x009405A2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataPerformance(Pointer, false, true);
		}

		// Token: 0x060204C2 RID: 132290 RVA: 0x009423AC File Offset: 0x009405AC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataPerformance(Pointer, MemoryOwner);
		}

		// Token: 0x040116E4 RID: 71396
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataPerformance.SReBulletDataPerformance";

		// Token: 0x040116E5 RID: 71397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116E6 RID: 71398
		internal static int __PropertyOffset_接手父子弹的特效;

		// Token: 0x040116E7 RID: 71399
		internal static int __PropertyOffset_子弹特效DA;

		// Token: 0x040116E8 RID: 71400
		internal static int __PropertyOffset_子弹特效DA参数;

		// Token: 0x040116E9 RID: 71401
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EBulletEffectParam>, string> _子弹特效DA参数;

		// Token: 0x040116EA RID: 71402
		internal static int __PropertyOffset_特殊特效DA;

		// Token: 0x040116EB RID: 71403
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> _特殊特效DA;

		// Token: 0x040116EC RID: 71404
		internal static int __PropertyOffset_子弹销毁调用子弹停止特效;

		// Token: 0x040116ED RID: 71405
		internal static int __PropertyOffset_命中特效DA;

		// Token: 0x040116EE RID: 71406
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> _命中特效DA;

		// Token: 0x040116EF RID: 71407
		internal static int __PropertyOffset_命中音效;

		// Token: 0x040116F0 RID: 71408
		internal static int __PropertyOffset_生成时攻击者震屏;

		// Token: 0x040116F1 RID: 71409
		internal static int __PropertyOffset_命中时攻击者震屏;

		// Token: 0x040116F2 RID: 71410
		internal static int __PropertyOffset_命中时受击者震屏;

		// Token: 0x040116F3 RID: 71411
		internal static int __PropertyOffset_命中弱点时攻击者震屏;

		// Token: 0x040116F4 RID: 71412
		internal static int __PropertyOffset_最大震动次数;

		// Token: 0x040116F5 RID: 71413
		internal static int __PropertyOffset_震屏关联到召唤兽主人;

		// Token: 0x040116F6 RID: 71414
		internal static int __PropertyOffset_命中特效配置;

		// Token: 0x040116F7 RID: 71415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletEffectOnHitConf> _命中特效配置;

		// Token: 0x040116F8 RID: 71416
		internal static int __PropertyOffset_受击闪白;
	}
}
