using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003342 RID: 13122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1149)]
	public class SCounterAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212DA RID: 135898 RVA: 0x0095AFDA File Offset: 0x009591DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttack._ScriptStructPtr != 0) ? SCounterAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack", ref SCounterAttack._ScriptStructPtr);
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x060212DB RID: 135899 RVA: 0x0095B000 File Offset: 0x00959200
		// (set) Token: 0x060212DC RID: 135900 RVA: 0x0095B043 File Offset: 0x00959243
		public TArray<FName> 弹反部位
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._弹反部位) == null)
				{
					result = (this._弹反部位 = new TArray<FName>(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_弹反部位, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.弹反部位.CopyAssign(value);
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x060212DD RID: 135901 RVA: 0x0095B054 File Offset: 0x00959254
		// (set) Token: 0x060212DE RID: 135902 RVA: 0x0095B097 File Offset: 0x00959297
		public SCounterAttackEffect 无弹反动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._无弹反动作效果) == null)
				{
					result = (this._无弹反动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_无弹反动作效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_无弹反动作效果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x060212DF RID: 135903 RVA: 0x0095B0B8 File Offset: 0x009592B8
		// (set) Token: 0x060212E0 RID: 135904 RVA: 0x0095B0FB File Offset: 0x009592FB
		public SCounterAttackEffect 有弹反动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._有弹反动作效果) == null)
				{
					result = (this._有弹反动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_有弹反动作效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_有弹反动作效果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x060212E1 RID: 135905 RVA: 0x0095B11C File Offset: 0x0095931C
		// (set) Token: 0x060212E2 RID: 135906 RVA: 0x0095B12C File Offset: 0x0095932C
		public unsafe float 削韧倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_削韧倍率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_削韧倍率) = value;
			}
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x060212E3 RID: 135907 RVA: 0x0095B13D File Offset: 0x0095933D
		// (set) Token: 0x060212E4 RID: 135908 RVA: 0x0095B14D File Offset: 0x0095934D
		public unsafe float 最大触发距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_最大触发距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_最大触发距离) = value;
			}
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x060212E5 RID: 135909 RVA: 0x0095B15E File Offset: 0x0095935E
		// (set) Token: 0x060212E6 RID: 135910 RVA: 0x0095B16E File Offset: 0x0095936E
		public unsafe float 最大触发夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_最大触发夹角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_最大触发夹角) = value;
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x060212E7 RID: 135911 RVA: 0x0095B17F File Offset: 0x0095937F
		// (set) Token: 0x060212E8 RID: 135912 RVA: 0x0095B18F File Offset: 0x0095938F
		public unsafe long 被弹反者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_被弹反者应用BuffID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_被弹反者应用BuffID) = value;
			}
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x060212E9 RID: 135913 RVA: 0x0095B1A0 File Offset: 0x009593A0
		// (set) Token: 0x060212EA RID: 135914 RVA: 0x0095B1B0 File Offset: 0x009593B0
		public unsafe long 攻击者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_攻击者应用BuffID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_攻击者应用BuffID) = value;
			}
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x060212EB RID: 135915 RVA: 0x0095B1C1 File Offset: 0x009593C1
		// (set) Token: 0x060212EC RID: 135916 RVA: 0x0095B1D1 File Offset: 0x009593D1
		public unsafe bool 受击动画忽略Buff检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_受击动画忽略Buff检测) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_受击动画忽略Buff检测) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x060212ED RID: 135917 RVA: 0x0095B1E4 File Offset: 0x009593E4
		// (set) Token: 0x060212EE RID: 135918 RVA: 0x0095B227 File Offset: 0x00959427
		public TArray<SCounterAttackBuff> 检测Buff列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCounterAttackBuff> result;
				if ((result = this._检测Buff列表) == null)
				{
					result = (this._检测Buff列表 = new TArray<SCounterAttackBuff>(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_检测Buff列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.检测Buff列表.CopyAssign(value);
			}
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x060212EF RID: 135919 RVA: 0x0095B235 File Offset: 0x00959435
		// (set) Token: 0x060212F0 RID: 135920 RVA: 0x0095B245 File Offset: 0x00959445
		public unsafe long ANS期间被弹反者生效的BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_ANS期间被弹反者生效的BuffID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_ANS期间被弹反者生效的BuffID) = value;
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x060212F1 RID: 135921 RVA: 0x0095B256 File Offset: 0x00959456
		// (set) Token: 0x060212F2 RID: 135922 RVA: 0x0095B26A File Offset: 0x0095946A
		public unsafe FGameplayTag 结束事件Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_结束事件Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_结束事件Tag) = value;
			}
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x060212F3 RID: 135923 RVA: 0x0095B27F File Offset: 0x0095947F
		// (set) Token: 0x060212F4 RID: 135924 RVA: 0x0095B28F File Offset: 0x0095948F
		public unsafe bool QTE弹刀忽略角度距离检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_QTE弹刀忽略角度距离检测) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_QTE弹刀忽略角度距离检测) = (value ? 1 : 0);
			}
		}

		// Token: 0x060212F5 RID: 135925 RVA: 0x0095B2A0 File Offset: 0x009594A0
		public SCounterAttack()
		{
		}

		// Token: 0x060212F6 RID: 135926 RVA: 0x0095B2A8 File Offset: 0x009594A8
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttack.StaticStruct();
		}

		// Token: 0x060212F7 RID: 135927 RVA: 0x0095B2B4 File Offset: 0x009594B4
		[NullableContext(2)]
		public SCounterAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212F8 RID: 135928 RVA: 0x0095B2BE File Offset: 0x009594BE
		public SCounterAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212F9 RID: 135929 RVA: 0x0095B2C9 File Offset: 0x009594C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttack(Pointer, false, true);
		}

		// Token: 0x060212FA RID: 135930 RVA: 0x0095B2D3 File Offset: 0x009594D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttack(Pointer, MemoryOwner);
		}

		// Token: 0x0401223F RID: 74303
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack";

		// Token: 0x04012240 RID: 74304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012241 RID: 74305
		internal static int __PropertyOffset_弹反部位;

		// Token: 0x04012242 RID: 74306
		[Nullable(2)]
		private TArray<FName> _弹反部位;

		// Token: 0x04012243 RID: 74307
		internal static int __PropertyOffset_无弹反动作效果;

		// Token: 0x04012244 RID: 74308
		[Nullable(2)]
		private SCounterAttackEffect _无弹反动作效果;

		// Token: 0x04012245 RID: 74309
		internal static int __PropertyOffset_有弹反动作效果;

		// Token: 0x04012246 RID: 74310
		[Nullable(2)]
		private SCounterAttackEffect _有弹反动作效果;

		// Token: 0x04012247 RID: 74311
		internal static int __PropertyOffset_削韧倍率;

		// Token: 0x04012248 RID: 74312
		internal static int __PropertyOffset_最大触发距离;

		// Token: 0x04012249 RID: 74313
		internal static int __PropertyOffset_最大触发夹角;

		// Token: 0x0401224A RID: 74314
		internal static int __PropertyOffset_被弹反者应用BuffID;

		// Token: 0x0401224B RID: 74315
		internal static int __PropertyOffset_攻击者应用BuffID;

		// Token: 0x0401224C RID: 74316
		internal static int __PropertyOffset_受击动画忽略Buff检测;

		// Token: 0x0401224D RID: 74317
		internal static int __PropertyOffset_检测Buff列表;

		// Token: 0x0401224E RID: 74318
		[Nullable(2)]
		private TArray<SCounterAttackBuff> _检测Buff列表;

		// Token: 0x0401224F RID: 74319
		internal static int __PropertyOffset_ANS期间被弹反者生效的BuffID;

		// Token: 0x04012250 RID: 74320
		internal static int __PropertyOffset_结束事件Tag;

		// Token: 0x04012251 RID: 74321
		internal static int __PropertyOffset_QTE弹刀忽略角度距离检测;
	}
}
