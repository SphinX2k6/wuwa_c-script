using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003345 RID: 13125
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 524)]
	public class SCounterAttackEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021317 RID: 135959 RVA: 0x0095B520 File Offset: 0x00959720
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackEffect._ScriptStructPtr != 0) ? SCounterAttackEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect", ref SCounterAttackEffect._ScriptStructPtr);
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x06021318 RID: 135960 RVA: 0x0095B544 File Offset: 0x00959744
		// (set) Token: 0x06021319 RID: 135961 RVA: 0x0095B558 File Offset: 0x00959758
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCameraShakeBase> 震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_震屏);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_震屏) = value;
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0602131A RID: 135962 RVA: 0x0095B570 File Offset: 0x00959770
		// (set) Token: 0x0602131B RID: 135963 RVA: 0x0095B5B3 File Offset: 0x009597B3
		public FSoftObjectPath 特效DA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._特效DA) == null)
				{
					result = (this._特效DA = new FSoftObjectPath(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效DA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效DA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x0602131C RID: 135964 RVA: 0x0095B5D4 File Offset: 0x009597D4
		// (set) Token: 0x0602131D RID: 135965 RVA: 0x0095B617 File Offset: 0x00959817
		public STimeScale 攻击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._攻击者顿帧) == null)
				{
					result = (this._攻击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_攻击者顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_攻击者顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x0602131E RID: 135966 RVA: 0x0095B638 File Offset: 0x00959838
		// (set) Token: 0x0602131F RID: 135967 RVA: 0x0095B67B File Offset: 0x0095987B
		public STimeScale 被击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._被击者顿帧) == null)
				{
					result = (this._被击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_被击者顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_被击者顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x06021320 RID: 135968 RVA: 0x0095B69C File Offset: 0x0095989C
		// (set) Token: 0x06021321 RID: 135969 RVA: 0x0095B6DF File Offset: 0x009598DF
		public SCounterAttackCamera 摄像机设置
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackCamera result;
				if ((result = this._摄像机设置) == null)
				{
					result = (this._摄像机设置 = new SCounterAttackCamera(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_摄像机设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackCamera.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_摄像机设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x06021322 RID: 135970 RVA: 0x0095B700 File Offset: 0x00959900
		// (set) Token: 0x06021323 RID: 135971 RVA: 0x0095B714 File Offset: 0x00959914
		public unsafe FVector 特效Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效Offset) = value;
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x06021324 RID: 135972 RVA: 0x0095B729 File Offset: 0x00959929
		// (set) Token: 0x06021325 RID: 135973 RVA: 0x0095B73D File Offset: 0x0095993D
		public unsafe FVector 特效Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效Scale) = value;
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x06021326 RID: 135974 RVA: 0x0095B752 File Offset: 0x00959952
		// (set) Token: 0x06021327 RID: 135975 RVA: 0x0095B762 File Offset: 0x00959962
		public unsafe float 特效位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_特效位置) = value;
			}
		}

		// Token: 0x06021328 RID: 135976 RVA: 0x0095B773 File Offset: 0x00959973
		public SCounterAttackEffect()
		{
		}

		// Token: 0x06021329 RID: 135977 RVA: 0x0095B77B File Offset: 0x0095997B
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttackEffect.StaticStruct();
		}

		// Token: 0x0602132A RID: 135978 RVA: 0x0095B787 File Offset: 0x00959987
		[NullableContext(2)]
		public SCounterAttackEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602132B RID: 135979 RVA: 0x0095B791 File Offset: 0x00959991
		public SCounterAttackEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602132C RID: 135980 RVA: 0x0095B79C File Offset: 0x0095999C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttackEffect(Pointer, false, true);
		}

		// Token: 0x0602132D RID: 135981 RVA: 0x0095B7A6 File Offset: 0x009599A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttackEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04012260 RID: 74336
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect";

		// Token: 0x04012261 RID: 74337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012262 RID: 74338
		internal static int __PropertyOffset_震屏;

		// Token: 0x04012263 RID: 74339
		internal static int __PropertyOffset_特效DA;

		// Token: 0x04012264 RID: 74340
		[Nullable(2)]
		private FSoftObjectPath _特效DA;

		// Token: 0x04012265 RID: 74341
		internal static int __PropertyOffset_攻击者顿帧;

		// Token: 0x04012266 RID: 74342
		[Nullable(2)]
		private STimeScale _攻击者顿帧;

		// Token: 0x04012267 RID: 74343
		internal static int __PropertyOffset_被击者顿帧;

		// Token: 0x04012268 RID: 74344
		[Nullable(2)]
		private STimeScale _被击者顿帧;

		// Token: 0x04012269 RID: 74345
		internal static int __PropertyOffset_摄像机设置;

		// Token: 0x0401226A RID: 74346
		[Nullable(2)]
		private SCounterAttackCamera _摄像机设置;

		// Token: 0x0401226B RID: 74347
		internal static int __PropertyOffset_特效Offset;

		// Token: 0x0401226C RID: 74348
		internal static int __PropertyOffset_特效Scale;

		// Token: 0x0401226D RID: 74349
		internal static int __PropertyOffset_特效位置;
	}
}
