using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003346 RID: 13126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class SCounterWindupAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602132E RID: 135982 RVA: 0x0095B7AF File Offset: 0x009599AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterWindupAttack._ScriptStructPtr != 0) ? SCounterWindupAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack", ref SCounterWindupAttack._ScriptStructPtr);
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x0602132F RID: 135983 RVA: 0x0095B7D3 File Offset: 0x009599D3
		// (set) Token: 0x06021330 RID: 135984 RVA: 0x0095B7F2 File Offset: 0x009599F2
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_Effect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_Effect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x06021331 RID: 135985 RVA: 0x0095B817 File Offset: 0x00959A17
		// (set) Token: 0x06021332 RID: 135986 RVA: 0x0095B82B File Offset: 0x00959A2B
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x06021333 RID: 135987 RVA: 0x0095B840 File Offset: 0x00959A40
		// (set) Token: 0x06021334 RID: 135988 RVA: 0x0095B883 File Offset: 0x00959A83
		public TArray<long> Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Buff) == null)
				{
					result = (this._Buff = new TArray<long>(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_Buff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buff.CopyAssign(value);
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x06021335 RID: 135989 RVA: 0x0095B891 File Offset: 0x00959A91
		// (set) Token: 0x06021336 RID: 135990 RVA: 0x0095B8A5 File Offset: 0x00959AA5
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x06021337 RID: 135991 RVA: 0x0095B8BA File Offset: 0x00959ABA
		// (set) Token: 0x06021338 RID: 135992 RVA: 0x0095B8CA File Offset: 0x00959ACA
		public unsafe bool EffectAttach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_EffectAttach) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_EffectAttach) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x06021339 RID: 135993 RVA: 0x0095B8DB File Offset: 0x00959ADB
		// (set) Token: 0x0602133A RID: 135994 RVA: 0x0095B8EF File Offset: 0x00959AEF
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x0602133B RID: 135995 RVA: 0x0095B904 File Offset: 0x00959B04
		public SCounterWindupAttack()
		{
		}

		// Token: 0x0602133C RID: 135996 RVA: 0x0095B90C File Offset: 0x00959B0C
		protected override IntPtr GetUStructPtr()
		{
			return SCounterWindupAttack.StaticStruct();
		}

		// Token: 0x0602133D RID: 135997 RVA: 0x0095B918 File Offset: 0x00959B18
		[NullableContext(2)]
		public SCounterWindupAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602133E RID: 135998 RVA: 0x0095B922 File Offset: 0x00959B22
		public SCounterWindupAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602133F RID: 135999 RVA: 0x0095B92D File Offset: 0x00959B2D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterWindupAttack(Pointer, false, true);
		}

		// Token: 0x06021340 RID: 136000 RVA: 0x0095B937 File Offset: 0x00959B37
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterWindupAttack(Pointer, MemoryOwner);
		}

		// Token: 0x0401226E RID: 74350
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack";

		// Token: 0x0401226F RID: 74351
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012270 RID: 74352
		internal static int __PropertyOffset_Effect;

		// Token: 0x04012271 RID: 74353
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012272 RID: 74354
		internal static int __PropertyOffset_Buff;

		// Token: 0x04012273 RID: 74355
		[Nullable(2)]
		private TArray<long> _Buff;

		// Token: 0x04012274 RID: 74356
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04012275 RID: 74357
		internal static int __PropertyOffset_EffectAttach;

		// Token: 0x04012276 RID: 74358
		internal static int __PropertyOffset_RelativeTransform;
	}
}
