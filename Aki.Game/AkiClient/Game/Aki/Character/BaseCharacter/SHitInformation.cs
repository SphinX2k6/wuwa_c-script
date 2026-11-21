using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003353 RID: 13139
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation")]
	[UnrealStructLayout(2272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2272)]
	public class SHitInformation : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021431 RID: 136241 RVA: 0x0095CBCC File Offset: 0x0095ADCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitInformation._ScriptStructPtr != 0) ? SHitInformation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation", ref SHitInformation._ScriptStructPtr);
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x06021432 RID: 136242 RVA: 0x0095CBF0 File Offset: 0x0095ADF0
		// (set) Token: 0x06021433 RID: 136243 RVA: 0x0095CC04 File Offset: 0x0095AE04
		[Nullable(2)]
		public unsafe TsBaseCharacter 攻击者
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_攻击者);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_攻击者, value);
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x06021434 RID: 136244 RVA: 0x0095CC19 File Offset: 0x0095AE19
		// (set) Token: 0x06021435 RID: 136245 RVA: 0x0095CC2D File Offset: 0x0095AE2D
		[Nullable(2)]
		public unsafe TsBaseCharacter 受击者
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_受击者);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_受击者, value);
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x06021436 RID: 136246 RVA: 0x0095CC44 File Offset: 0x0095AE44
		// (set) Token: 0x06021437 RID: 136247 RVA: 0x0095CC87 File Offset: 0x0095AE87
		public SHitEffect 被击效果
		{
			get
			{
				base.FastCheckIsValid();
				SHitEffect result;
				if ((result = this._被击效果) == null)
				{
					result = (this._被击效果 = new SHitEffect(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_被击效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_被击效果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x06021438 RID: 136248 RVA: 0x0095CCA8 File Offset: 0x0095AEA8
		// (set) Token: 0x06021439 RID: 136249 RVA: 0x0095CCB8 File Offset: 0x0095AEB8
		public unsafe int 子弹ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_子弹ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_子弹ID) = value;
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x0602143A RID: 136250 RVA: 0x0095CCC9 File Offset: 0x0095AEC9
		// (set) Token: 0x0602143B RID: 136251 RVA: 0x0095CCDD File Offset: 0x0095AEDD
		public unsafe FVector 受击特效位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击特效位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击特效位置) = value;
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x0602143C RID: 136252 RVA: 0x0095CCF2 File Offset: 0x0095AEF2
		// (set) Token: 0x0602143D RID: 136253 RVA: 0x0095CD06 File Offset: 0x0095AF06
		public unsafe FRotator 受击特效旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击特效旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击特效旋转) = value;
			}
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x0602143E RID: 136254 RVA: 0x0095CD1B File Offset: 0x0095AF1B
		// (set) Token: 0x0602143F RID: 136255 RVA: 0x0095CD2B File Offset: 0x0095AF2B
		public unsafe bool 是否震动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_是否震动) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_是否震动) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x06021440 RID: 136256 RVA: 0x0095CD3C File Offset: 0x0095AF3C
		// (set) Token: 0x06021441 RID: 136257 RVA: 0x0095CD50 File Offset: 0x0095AF50
		public unsafe FName 受击部位
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击部位);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击部位) = value;
			}
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x06021442 RID: 136258 RVA: 0x0095CD65 File Offset: 0x0095AF65
		// (set) Token: 0x06021443 RID: 136259 RVA: 0x0095CD79 File Offset: 0x0095AF79
		public unsafe FVector 受击位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_受击位置) = value;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x06021444 RID: 136260 RVA: 0x0095CD8E File Offset: 0x0095AF8E
		// (set) Token: 0x06021445 RID: 136261 RVA: 0x0095CD9E File Offset: 0x0095AF9E
		public unsafe int 技能等级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_技能等级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_技能等级) = value;
			}
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x06021446 RID: 136262 RVA: 0x0095CDB0 File Offset: 0x0095AFB0
		// (set) Token: 0x06021447 RID: 136263 RVA: 0x0095CDF3 File Offset: 0x0095AFF3
		public SReBulletDataMain 重构子弹数据
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataMain result;
				if ((result = this._重构子弹数据) == null)
				{
					result = (this._重构子弹数据 = new SReBulletDataMain(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_重构子弹数据, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_重构子弹数据, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x06021448 RID: 136264 RVA: 0x0095CE14 File Offset: 0x0095B014
		// (set) Token: 0x06021449 RID: 136265 RVA: 0x0095CE28 File Offset: 0x0095B028
		[Nullable(2)]
		public unsafe BulletLogicType_C 子弹逻辑预设
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BulletLogicType_C>(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_子弹逻辑预设);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHitInformation.__PropertyOffset_子弹逻辑预设, value);
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x0602144A RID: 136266 RVA: 0x0095CE3D File Offset: 0x0095B03D
		// (set) Token: 0x0602144B RID: 136267 RVA: 0x0095CE51 File Offset: 0x0095B051
		public unsafe string 子弹表ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SHitInformation.__PropertyOffset_子弹表ID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SHitInformation.__PropertyOffset_子弹表ID)), value);
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x0602144C RID: 136268 RVA: 0x0095CE66 File Offset: 0x0095B066
		// (set) Token: 0x0602144D RID: 136269 RVA: 0x0095CE76 File Offset: 0x0095B076
		public unsafe int 伤害类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_伤害类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_伤害类型) = value;
			}
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x0602144E RID: 136270 RVA: 0x0095CE87 File Offset: 0x0095B087
		// (set) Token: 0x0602144F RID: 136271 RVA: 0x0095CE97 File Offset: 0x0095B097
		public unsafe long 伤害ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_伤害ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitInformation.__PropertyOffset_伤害ID) = value;
			}
		}

		// Token: 0x06021450 RID: 136272 RVA: 0x0095CEA8 File Offset: 0x0095B0A8
		public SHitInformation()
		{
		}

		// Token: 0x06021451 RID: 136273 RVA: 0x0095CEB0 File Offset: 0x0095B0B0
		protected override IntPtr GetUStructPtr()
		{
			return SHitInformation.StaticStruct();
		}

		// Token: 0x06021452 RID: 136274 RVA: 0x0095CEBC File Offset: 0x0095B0BC
		[NullableContext(2)]
		public SHitInformation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021453 RID: 136275 RVA: 0x0095CEC6 File Offset: 0x0095B0C6
		public SHitInformation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021454 RID: 136276 RVA: 0x0095CED1 File Offset: 0x0095B0D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitInformation(Pointer, false, true);
		}

		// Token: 0x06021455 RID: 136277 RVA: 0x0095CEDB File Offset: 0x0095B0DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitInformation(Pointer, MemoryOwner);
		}

		// Token: 0x040122EB RID: 74475
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitInformation.SHitInformation";

		// Token: 0x040122EC RID: 74476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122ED RID: 74477
		internal static int __PropertyOffset_攻击者;

		// Token: 0x040122EE RID: 74478
		internal static int __PropertyOffset_受击者;

		// Token: 0x040122EF RID: 74479
		internal static int __PropertyOffset_被击效果;

		// Token: 0x040122F0 RID: 74480
		[Nullable(2)]
		private SHitEffect _被击效果;

		// Token: 0x040122F1 RID: 74481
		internal static int __PropertyOffset_子弹ID;

		// Token: 0x040122F2 RID: 74482
		internal static int __PropertyOffset_受击特效位置;

		// Token: 0x040122F3 RID: 74483
		internal static int __PropertyOffset_受击特效旋转;

		// Token: 0x040122F4 RID: 74484
		internal static int __PropertyOffset_是否震动;

		// Token: 0x040122F5 RID: 74485
		internal static int __PropertyOffset_受击部位;

		// Token: 0x040122F6 RID: 74486
		internal static int __PropertyOffset_受击位置;

		// Token: 0x040122F7 RID: 74487
		internal static int __PropertyOffset_技能等级;

		// Token: 0x040122F8 RID: 74488
		internal static int __PropertyOffset_重构子弹数据;

		// Token: 0x040122F9 RID: 74489
		[Nullable(2)]
		private SReBulletDataMain _重构子弹数据;

		// Token: 0x040122FA RID: 74490
		internal static int __PropertyOffset_子弹逻辑预设;

		// Token: 0x040122FB RID: 74491
		internal static int __PropertyOffset_子弹表ID;

		// Token: 0x040122FC RID: 74492
		internal static int __PropertyOffset_伤害类型;

		// Token: 0x040122FD RID: 74493
		internal static int __PropertyOffset_伤害ID;
	}
}
