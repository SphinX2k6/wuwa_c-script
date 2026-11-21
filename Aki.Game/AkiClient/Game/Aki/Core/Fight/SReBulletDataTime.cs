using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200327B RID: 12923
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 133)]
	public class SReBulletDataTime : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060204D0 RID: 132304 RVA: 0x00942488 File Offset: 0x00940688
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataTime._ScriptStructPtr != 0) ? SReBulletDataTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime", ref SReBulletDataTime._ScriptStructPtr);
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x060204D1 RID: 132305 RVA: 0x009424AC File Offset: 0x009406AC
		// (set) Token: 0x060204D2 RID: 132306 RVA: 0x009424BC File Offset: 0x009406BC
		public unsafe bool 是否跟随攻击者顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_是否跟随攻击者顿帧) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_是否跟随攻击者顿帧) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x060204D3 RID: 132307 RVA: 0x009424CD File Offset: 0x009406CD
		// (set) Token: 0x060204D4 RID: 132308 RVA: 0x009424DD File Offset: 0x009406DD
		public unsafe bool 攻击顿帧忽略攻击者
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_攻击顿帧忽略攻击者) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_攻击顿帧忽略攻击者) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x060204D5 RID: 132309 RVA: 0x009424F0 File Offset: 0x009406F0
		// (set) Token: 0x060204D6 RID: 132310 RVA: 0x00942533 File Offset: 0x00940733
		public STimeScale 攻击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._攻击顿帧) == null)
				{
					result = (this._攻击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_攻击顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_攻击顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x060204D7 RID: 132311 RVA: 0x00942554 File Offset: 0x00940754
		// (set) Token: 0x060204D8 RID: 132312 RVA: 0x00942597 File Offset: 0x00940797
		public STimeScale 受击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._受击顿帧) == null)
				{
					result = (this._受击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_受击顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_受击顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x060204D9 RID: 132313 RVA: 0x009425B8 File Offset: 0x009407B8
		// (set) Token: 0x060204DA RID: 132314 RVA: 0x009425FB File Offset: 0x009407FB
		public STimeScale 命中弱点攻击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._命中弱点攻击者顿帧) == null)
				{
					result = (this._命中弱点攻击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_命中弱点攻击者顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_命中弱点攻击者顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x060204DB RID: 132315 RVA: 0x0094261C File Offset: 0x0094081C
		// (set) Token: 0x060204DC RID: 132316 RVA: 0x0094265F File Offset: 0x0094085F
		public STimeScale 命中弱点受击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._命中弱点受击者顿帧) == null)
				{
					result = (this._命中弱点受击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_命中弱点受击者顿帧, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_命中弱点受击者顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x060204DD RID: 132317 RVA: 0x00942680 File Offset: 0x00940880
		// (set) Token: 0x060204DE RID: 132318 RVA: 0x00942690 File Offset: 0x00940890
		public unsafe bool 强制影响区域内子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_强制影响区域内子弹) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_强制影响区域内子弹) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x060204DF RID: 132319 RVA: 0x009426A1 File Offset: 0x009408A1
		// (set) Token: 0x060204E0 RID: 132320 RVA: 0x009426B1 File Offset: 0x009408B1
		public unsafe bool 区域受击者时间膨胀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_区域受击者时间膨胀) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_区域受击者时间膨胀) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x060204E1 RID: 132321 RVA: 0x009426C2 File Offset: 0x009408C2
		// (set) Token: 0x060204E2 RID: 132322 RVA: 0x009426D6 File Offset: 0x009408D6
		public unsafe string 自定义连携顿帧单位key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataTime.__PropertyOffset_自定义连携顿帧单位key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataTime.__PropertyOffset_自定义连携顿帧单位key)), value);
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x060204E3 RID: 132323 RVA: 0x009426EB File Offset: 0x009408EB
		// (set) Token: 0x060204E4 RID: 132324 RVA: 0x009426FB File Offset: 0x009408FB
		public unsafe float 时间膨胀失效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_时间膨胀失效);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_时间膨胀失效) = value;
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x060204E5 RID: 132325 RVA: 0x0094270C File Offset: 0x0094090C
		// (set) Token: 0x060204E6 RID: 132326 RVA: 0x0094271C File Offset: 0x0094091C
		public unsafe bool 子弹销毁时移除受击顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_子弹销毁时移除受击顿帧) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataTime.__PropertyOffset_子弹销毁时移除受击顿帧) = (value ? 1 : 0);
			}
		}

		// Token: 0x060204E7 RID: 132327 RVA: 0x0094272D File Offset: 0x0094092D
		public SReBulletDataTime()
		{
		}

		// Token: 0x060204E8 RID: 132328 RVA: 0x00942735 File Offset: 0x00940935
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataTime.StaticStruct();
		}

		// Token: 0x060204E9 RID: 132329 RVA: 0x00942741 File Offset: 0x00940941
		[NullableContext(2)]
		public SReBulletDataTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060204EA RID: 132330 RVA: 0x0094274B File Offset: 0x0094094B
		public SReBulletDataTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060204EB RID: 132331 RVA: 0x00942756 File Offset: 0x00940956
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataTime(Pointer, false, true);
		}

		// Token: 0x060204EC RID: 132332 RVA: 0x00942760 File Offset: 0x00940960
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataTime(Pointer, MemoryOwner);
		}

		// Token: 0x040116FE RID: 71422
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataTime.SReBulletDataTime";

		// Token: 0x040116FF RID: 71423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011700 RID: 71424
		internal static int __PropertyOffset_是否跟随攻击者顿帧;

		// Token: 0x04011701 RID: 71425
		internal static int __PropertyOffset_攻击顿帧忽略攻击者;

		// Token: 0x04011702 RID: 71426
		internal static int __PropertyOffset_攻击顿帧;

		// Token: 0x04011703 RID: 71427
		[Nullable(2)]
		private STimeScale _攻击顿帧;

		// Token: 0x04011704 RID: 71428
		internal static int __PropertyOffset_受击顿帧;

		// Token: 0x04011705 RID: 71429
		[Nullable(2)]
		private STimeScale _受击顿帧;

		// Token: 0x04011706 RID: 71430
		internal static int __PropertyOffset_命中弱点攻击者顿帧;

		// Token: 0x04011707 RID: 71431
		[Nullable(2)]
		private STimeScale _命中弱点攻击者顿帧;

		// Token: 0x04011708 RID: 71432
		internal static int __PropertyOffset_命中弱点受击者顿帧;

		// Token: 0x04011709 RID: 71433
		[Nullable(2)]
		private STimeScale _命中弱点受击者顿帧;

		// Token: 0x0401170A RID: 71434
		internal static int __PropertyOffset_强制影响区域内子弹;

		// Token: 0x0401170B RID: 71435
		internal static int __PropertyOffset_区域受击者时间膨胀;

		// Token: 0x0401170C RID: 71436
		internal static int __PropertyOffset_自定义连携顿帧单位key;

		// Token: 0x0401170D RID: 71437
		internal static int __PropertyOffset_时间膨胀失效;

		// Token: 0x0401170E RID: 71438
		internal static int __PropertyOffset_子弹销毁时移除受击顿帧;
	}
}
