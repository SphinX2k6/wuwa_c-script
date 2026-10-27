using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004308 RID: 17160
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class SCounterWindupAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C605 RID: 181765 RVA: 0x00A1E6F4 File Offset: 0x00A1C8F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterWindupAttack._ScriptStructPtr != 0) ? SCounterWindupAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack", ref SCounterWindupAttack._ScriptStructPtr);
		}

		// Token: 0x17006EFC RID: 28412
		// (get) Token: 0x0602C606 RID: 181766 RVA: 0x00A1E718 File Offset: 0x00A1C918
		// (set) Token: 0x0602C607 RID: 181767 RVA: 0x00A1E737 File Offset: 0x00A1C937
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006EFD RID: 28413
		// (get) Token: 0x0602C608 RID: 181768 RVA: 0x00A1E75C File Offset: 0x00A1C95C
		// (set) Token: 0x0602C609 RID: 181769 RVA: 0x00A1E770 File Offset: 0x00A1C970
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006EFE RID: 28414
		// (get) Token: 0x0602C60A RID: 181770 RVA: 0x00A1E788 File Offset: 0x00A1C988
		// (set) Token: 0x0602C60B RID: 181771 RVA: 0x00A1E7CB File Offset: 0x00A1C9CB
		public TArray<long> Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Buff) == null)
				{
					result = (this._Buff = new TArray<long>(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Buff.CopyAssign(value);
			}
		}

		// Token: 0x17006EFF RID: 28415
		// (get) Token: 0x0602C60C RID: 181772 RVA: 0x00A1E7D9 File Offset: 0x00A1C9D9
		// (set) Token: 0x0602C60D RID: 181773 RVA: 0x00A1E7ED File Offset: 0x00A1C9ED
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F00 RID: 28416
		// (get) Token: 0x0602C60E RID: 181774 RVA: 0x00A1E802 File Offset: 0x00A1CA02
		// (set) Token: 0x0602C60F RID: 181775 RVA: 0x00A1E812 File Offset: 0x00A1CA12
		public unsafe bool EffectAttach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F01 RID: 28417
		// (get) Token: 0x0602C610 RID: 181776 RVA: 0x00A1E823 File Offset: 0x00A1CA23
		// (set) Token: 0x0602C611 RID: 181777 RVA: 0x00A1E837 File Offset: 0x00A1CA37
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterWindupAttack.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602C612 RID: 181778 RVA: 0x00A1E84C File Offset: 0x00A1CA4C
		public SCounterWindupAttack()
		{
		}

		// Token: 0x0602C613 RID: 181779 RVA: 0x00A1E854 File Offset: 0x00A1CA54
		public SCounterWindupAttack(TSoftObjectPtr<UEffectModelBase> Effect, FGameplayTag Tag, TArray<long> Buff, FName SocketName, bool EffectAttach, FTransform RelativeTransform)
		{
			this.Effect = Effect;
			this.Tag = Tag;
			this.Buff = Buff;
			this.SocketName = SocketName;
			this.EffectAttach = EffectAttach;
			this.RelativeTransform = RelativeTransform;
		}

		// Token: 0x0602C614 RID: 181780 RVA: 0x00A1E889 File Offset: 0x00A1CA89
		protected override IntPtr GetUStructPtr()
		{
			return SCounterWindupAttack.StaticStruct();
		}

		// Token: 0x0602C615 RID: 181781 RVA: 0x00A1E895 File Offset: 0x00A1CA95
		[NullableContext(2)]
		public SCounterWindupAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C616 RID: 181782 RVA: 0x00A1E89F File Offset: 0x00A1CA9F
		public SCounterWindupAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C617 RID: 181783 RVA: 0x00A1E8AA File Offset: 0x00A1CAAA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterWindupAttack(Pointer, false, true);
		}

		// Token: 0x0602C618 RID: 181784 RVA: 0x00A1E8B4 File Offset: 0x00A1CAB4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterWindupAttack(Pointer, MemoryOwner);
		}

		// Token: 0x04017665 RID: 95845
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterWindupAttack.SCounterWindupAttack";

		// Token: 0x04017666 RID: 95846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017667 RID: 95847
		internal static int __PropertyOffset_0;

		// Token: 0x04017668 RID: 95848
		internal static int __PropertyOffset_1;

		// Token: 0x04017669 RID: 95849
		internal static int __PropertyOffset_2;

		// Token: 0x0401766A RID: 95850
		[Nullable(2)]
		private TArray<long> _Buff;

		// Token: 0x0401766B RID: 95851
		internal static int __PropertyOffset_3;

		// Token: 0x0401766C RID: 95852
		internal static int __PropertyOffset_4;

		// Token: 0x0401766D RID: 95853
		internal static int __PropertyOffset_5;
	}
}
