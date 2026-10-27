using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200401A RID: 16410
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 133)]
	public class SReBulletDataTime : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A128 RID: 172328 RVA: 0x009D4EB4 File Offset: 0x009D30B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataTime._ScriptStructPtr != 0) ? SReBulletDataTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime", ref SReBulletDataTime._ScriptStructPtr);
		}

		// Token: 0x1700669D RID: 26269
		// (get) Token: 0x0602A129 RID: 172329 RVA: 0x009D4ED8 File Offset: 0x009D30D8
		// (set) Token: 0x0602A12A RID: 172330 RVA: 0x009D4EE8 File Offset: 0x009D30E8
		public unsafe bool 是否跟随攻击者顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700669E RID: 26270
		// (get) Token: 0x0602A12B RID: 172331 RVA: 0x009D4EF9 File Offset: 0x009D30F9
		// (set) Token: 0x0602A12C RID: 172332 RVA: 0x009D4F09 File Offset: 0x009D3109
		public unsafe bool 攻击顿帧忽略攻击者
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700669F RID: 26271
		// (get) Token: 0x0602A12D RID: 172333 RVA: 0x009D4F1C File Offset: 0x009D311C
		// (set) Token: 0x0602A12E RID: 172334 RVA: 0x009D4F5F File Offset: 0x009D315F
		public STimeScale 攻击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._攻击顿帧) == null)
				{
					result = (this._攻击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x0602A12F RID: 172335 RVA: 0x009D4F80 File Offset: 0x009D3180
		// (set) Token: 0x0602A130 RID: 172336 RVA: 0x009D4FC3 File Offset: 0x009D31C3
		public STimeScale 受击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._受击顿帧) == null)
				{
					result = (this._受击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x0602A131 RID: 172337 RVA: 0x009D4FE4 File Offset: 0x009D31E4
		// (set) Token: 0x0602A132 RID: 172338 RVA: 0x009D5027 File Offset: 0x009D3227
		public STimeScale 命中弱点攻击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._命中弱点攻击者顿帧) == null)
				{
					result = (this._命中弱点攻击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x0602A133 RID: 172339 RVA: 0x009D5048 File Offset: 0x009D3248
		// (set) Token: 0x0602A134 RID: 172340 RVA: 0x009D508B File Offset: 0x009D328B
		public STimeScale 命中弱点受击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._命中弱点受击者顿帧) == null)
				{
					result = (this._命中弱点受击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x0602A135 RID: 172341 RVA: 0x009D50AC File Offset: 0x009D32AC
		// (set) Token: 0x0602A136 RID: 172342 RVA: 0x009D50BC File Offset: 0x009D32BC
		public unsafe bool 强制影响区域内子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x0602A137 RID: 172343 RVA: 0x009D50CD File Offset: 0x009D32CD
		// (set) Token: 0x0602A138 RID: 172344 RVA: 0x009D50DD File Offset: 0x009D32DD
		public unsafe bool 区域受击者时间膨胀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x0602A139 RID: 172345 RVA: 0x009D50EE File Offset: 0x009D32EE
		// (set) Token: 0x0602A13A RID: 172346 RVA: 0x009D5102 File Offset: 0x009D3302
		public unsafe string 自定义连携顿帧单位key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataTime.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataTime.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x0602A13B RID: 172347 RVA: 0x009D5117 File Offset: 0x009D3317
		// (set) Token: 0x0602A13C RID: 172348 RVA: 0x009D5127 File Offset: 0x009D3327
		public unsafe float 时间膨胀失效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x0602A13D RID: 172349 RVA: 0x009D5138 File Offset: 0x009D3338
		// (set) Token: 0x0602A13E RID: 172350 RVA: 0x009D5148 File Offset: 0x009D3348
		public unsafe bool 子弹销毁时移除受击顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A13F RID: 172351 RVA: 0x009D5159 File Offset: 0x009D3359
		public SReBulletDataTime()
		{
		}

		// Token: 0x0602A140 RID: 172352 RVA: 0x009D5164 File Offset: 0x009D3364
		public SReBulletDataTime(bool 是否跟随攻击者顿帧, bool 攻击顿帧忽略攻击者, STimeScale 攻击顿帧, STimeScale 受击顿帧, STimeScale 命中弱点攻击者顿帧, STimeScale 命中弱点受击者顿帧, bool 强制影响区域内子弹, bool 区域受击者时间膨胀, string 自定义连携顿帧单位key, float 时间膨胀失效, bool 子弹销毁时移除受击顿帧)
		{
			this.是否跟随攻击者顿帧 = 是否跟随攻击者顿帧;
			this.攻击顿帧忽略攻击者 = 攻击顿帧忽略攻击者;
			this.攻击顿帧 = 攻击顿帧;
			this.受击顿帧 = 受击顿帧;
			this.命中弱点攻击者顿帧 = 命中弱点攻击者顿帧;
			this.命中弱点受击者顿帧 = 命中弱点受击者顿帧;
			this.强制影响区域内子弹 = 强制影响区域内子弹;
			this.区域受击者时间膨胀 = 区域受击者时间膨胀;
			this.自定义连携顿帧单位key = 自定义连携顿帧单位key;
			this.时间膨胀失效 = 时间膨胀失效;
			this.子弹销毁时移除受击顿帧 = 子弹销毁时移除受击顿帧;
		}

		// Token: 0x0602A141 RID: 172353 RVA: 0x009D51CC File Offset: 0x009D33CC
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataTime.StaticStruct();
		}

		// Token: 0x0602A142 RID: 172354 RVA: 0x009D51D8 File Offset: 0x009D33D8
		[NullableContext(2)]
		public SReBulletDataTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A143 RID: 172355 RVA: 0x009D51E2 File Offset: 0x009D33E2
		public SReBulletDataTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A144 RID: 172356 RVA: 0x009D51ED File Offset: 0x009D33ED
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataTime(Pointer, false, true);
		}

		// Token: 0x0602A145 RID: 172357 RVA: 0x009D51F7 File Offset: 0x009D33F7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataTime(Pointer, MemoryOwner);
		}

		// Token: 0x04015AAC RID: 88748
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime";

		// Token: 0x04015AAD RID: 88749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015AAE RID: 88750
		internal static int __PropertyOffset_0;

		// Token: 0x04015AAF RID: 88751
		internal static int __PropertyOffset_1;

		// Token: 0x04015AB0 RID: 88752
		internal static int __PropertyOffset_2;

		// Token: 0x04015AB1 RID: 88753
		[Nullable(2)]
		private STimeScale _攻击顿帧;

		// Token: 0x04015AB2 RID: 88754
		internal static int __PropertyOffset_3;

		// Token: 0x04015AB3 RID: 88755
		[Nullable(2)]
		private STimeScale _受击顿帧;

		// Token: 0x04015AB4 RID: 88756
		internal static int __PropertyOffset_4;

		// Token: 0x04015AB5 RID: 88757
		[Nullable(2)]
		private STimeScale _命中弱点攻击者顿帧;

		// Token: 0x04015AB6 RID: 88758
		internal static int __PropertyOffset_5;

		// Token: 0x04015AB7 RID: 88759
		[Nullable(2)]
		private STimeScale _命中弱点受击者顿帧;

		// Token: 0x04015AB8 RID: 88760
		internal static int __PropertyOffset_6;

		// Token: 0x04015AB9 RID: 88761
		internal static int __PropertyOffset_7;

		// Token: 0x04015ABA RID: 88762
		internal static int __PropertyOffset_8;

		// Token: 0x04015ABB RID: 88763
		internal static int __PropertyOffset_9;

		// Token: 0x04015ABC RID: 88764
		internal static int __PropertyOffset_10;
	}
}
