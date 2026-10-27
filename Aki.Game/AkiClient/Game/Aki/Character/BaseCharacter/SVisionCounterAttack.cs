using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433B RID: 17211
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 552)]
	public class SVisionCounterAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA41 RID: 182849 RVA: 0x00A24AC8 File Offset: 0x00A22CC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVisionCounterAttack._ScriptStructPtr != 0) ? SVisionCounterAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack", ref SVisionCounterAttack._ScriptStructPtr);
		}

		// Token: 0x17007052 RID: 28754
		// (get) Token: 0x0602CA42 RID: 182850 RVA: 0x00A24AEC File Offset: 0x00A22CEC
		// (set) Token: 0x0602CA43 RID: 182851 RVA: 0x00A24B2F File Offset: 0x00A22D2F
		public SCounterAttackEffect 对策动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._对策动作效果) == null)
				{
					result = (this._对策动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007053 RID: 28755
		// (get) Token: 0x0602CA44 RID: 182852 RVA: 0x00A24B50 File Offset: 0x00A22D50
		// (set) Token: 0x0602CA45 RID: 182853 RVA: 0x00A24B60 File Offset: 0x00A22D60
		public unsafe long 被对策者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007054 RID: 28756
		// (get) Token: 0x0602CA46 RID: 182854 RVA: 0x00A24B71 File Offset: 0x00A22D71
		// (set) Token: 0x0602CA47 RID: 182855 RVA: 0x00A24B81 File Offset: 0x00A22D81
		public unsafe long 攻击者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007055 RID: 28757
		// (get) Token: 0x0602CA48 RID: 182856 RVA: 0x00A24B92 File Offset: 0x00A22D92
		// (set) Token: 0x0602CA49 RID: 182857 RVA: 0x00A24BA2 File Offset: 0x00A22DA2
		public unsafe bool 广播对策事件
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007056 RID: 28758
		// (get) Token: 0x0602CA4A RID: 182858 RVA: 0x00A24BB3 File Offset: 0x00A22DB3
		// (set) Token: 0x0602CA4B RID: 182859 RVA: 0x00A24BC3 File Offset: 0x00A22DC3
		public unsafe int 对策事件ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602CA4C RID: 182860 RVA: 0x00A24BD4 File Offset: 0x00A22DD4
		public SVisionCounterAttack()
		{
		}

		// Token: 0x0602CA4D RID: 182861 RVA: 0x00A24BDC File Offset: 0x00A22DDC
		public SVisionCounterAttack(SCounterAttackEffect 对策动作效果, long 被对策者应用BuffID, long 攻击者应用BuffID, bool 广播对策事件, int 对策事件ID)
		{
			this.对策动作效果 = 对策动作效果;
			this.被对策者应用BuffID = 被对策者应用BuffID;
			this.攻击者应用BuffID = 攻击者应用BuffID;
			this.广播对策事件 = 广播对策事件;
			this.对策事件ID = 对策事件ID;
		}

		// Token: 0x0602CA4E RID: 182862 RVA: 0x00A24C09 File Offset: 0x00A22E09
		protected override IntPtr GetUStructPtr()
		{
			return SVisionCounterAttack.StaticStruct();
		}

		// Token: 0x0602CA4F RID: 182863 RVA: 0x00A24C15 File Offset: 0x00A22E15
		[NullableContext(2)]
		public SVisionCounterAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA50 RID: 182864 RVA: 0x00A24C1F File Offset: 0x00A22E1F
		public SVisionCounterAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA51 RID: 182865 RVA: 0x00A24C2A File Offset: 0x00A22E2A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVisionCounterAttack(Pointer, false, true);
		}

		// Token: 0x0602CA52 RID: 182866 RVA: 0x00A24C34 File Offset: 0x00A22E34
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVisionCounterAttack(Pointer, MemoryOwner);
		}

		// Token: 0x04017881 RID: 96385
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack";

		// Token: 0x04017882 RID: 96386
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017883 RID: 96387
		internal static int __PropertyOffset_0;

		// Token: 0x04017884 RID: 96388
		[Nullable(2)]
		private SCounterAttackEffect _对策动作效果;

		// Token: 0x04017885 RID: 96389
		internal static int __PropertyOffset_1;

		// Token: 0x04017886 RID: 96390
		internal static int __PropertyOffset_2;

		// Token: 0x04017887 RID: 96391
		internal static int __PropertyOffset_3;

		// Token: 0x04017888 RID: 96392
		internal static int __PropertyOffset_4;
	}
}
