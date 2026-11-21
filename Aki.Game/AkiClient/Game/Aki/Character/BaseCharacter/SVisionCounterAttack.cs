using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336F RID: 13167
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 552)]
	public class SVisionCounterAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060216F9 RID: 136953 RVA: 0x00960869 File Offset: 0x0095EA69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVisionCounterAttack._ScriptStructPtr != 0) ? SVisionCounterAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack", ref SVisionCounterAttack._ScriptStructPtr);
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x060216FA RID: 136954 RVA: 0x00960890 File Offset: 0x0095EA90
		// (set) Token: 0x060216FB RID: 136955 RVA: 0x009608D3 File Offset: 0x0095EAD3
		public SCounterAttackEffect 对策动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._对策动作效果) == null)
				{
					result = (this._对策动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_对策动作效果, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_对策动作效果, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x060216FC RID: 136956 RVA: 0x009608F4 File Offset: 0x0095EAF4
		// (set) Token: 0x060216FD RID: 136957 RVA: 0x00960904 File Offset: 0x0095EB04
		public unsafe long 被对策者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_被对策者应用BuffID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_被对策者应用BuffID) = value;
			}
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x060216FE RID: 136958 RVA: 0x00960915 File Offset: 0x0095EB15
		// (set) Token: 0x060216FF RID: 136959 RVA: 0x00960925 File Offset: 0x0095EB25
		public unsafe long 攻击者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_攻击者应用BuffID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_攻击者应用BuffID) = value;
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x06021700 RID: 136960 RVA: 0x00960936 File Offset: 0x0095EB36
		// (set) Token: 0x06021701 RID: 136961 RVA: 0x00960946 File Offset: 0x0095EB46
		public unsafe bool 广播对策事件
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_广播对策事件) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_广播对策事件) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x06021702 RID: 136962 RVA: 0x00960957 File Offset: 0x0095EB57
		// (set) Token: 0x06021703 RID: 136963 RVA: 0x00960967 File Offset: 0x0095EB67
		public unsafe int 对策事件ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_对策事件ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVisionCounterAttack.__PropertyOffset_对策事件ID) = value;
			}
		}

		// Token: 0x06021704 RID: 136964 RVA: 0x00960978 File Offset: 0x0095EB78
		public SVisionCounterAttack()
		{
		}

		// Token: 0x06021705 RID: 136965 RVA: 0x00960980 File Offset: 0x0095EB80
		protected override IntPtr GetUStructPtr()
		{
			return SVisionCounterAttack.StaticStruct();
		}

		// Token: 0x06021706 RID: 136966 RVA: 0x0096098C File Offset: 0x0095EB8C
		[NullableContext(2)]
		public SVisionCounterAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021707 RID: 136967 RVA: 0x00960996 File Offset: 0x0095EB96
		public SVisionCounterAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021708 RID: 136968 RVA: 0x009609A1 File Offset: 0x0095EBA1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVisionCounterAttack(Pointer, false, true);
		}

		// Token: 0x06021709 RID: 136969 RVA: 0x009609AB File Offset: 0x0095EBAB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVisionCounterAttack(Pointer, MemoryOwner);
		}

		// Token: 0x04012462 RID: 74850
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SVisionCounterAttack.SVisionCounterAttack";

		// Token: 0x04012463 RID: 74851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012464 RID: 74852
		internal static int __PropertyOffset_对策动作效果;

		// Token: 0x04012465 RID: 74853
		[Nullable(2)]
		private SCounterAttackEffect _对策动作效果;

		// Token: 0x04012466 RID: 74854
		internal static int __PropertyOffset_被对策者应用BuffID;

		// Token: 0x04012467 RID: 74855
		internal static int __PropertyOffset_攻击者应用BuffID;

		// Token: 0x04012468 RID: 74856
		internal static int __PropertyOffset_广播对策事件;

		// Token: 0x04012469 RID: 74857
		internal static int __PropertyOffset_对策事件ID;
	}
}
