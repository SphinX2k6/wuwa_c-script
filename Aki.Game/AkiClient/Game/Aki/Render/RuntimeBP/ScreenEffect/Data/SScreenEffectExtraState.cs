using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AEC RID: 15084
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/SScreenEffectExtraState.SScreenEffectExtraState")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class SScreenEffectExtraState : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020A93 RID: 133779 RVA: 0x008D94BB File Offset: 0x008D76BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SScreenEffectExtraState._ScriptStructPtr != 0) ? SScreenEffectExtraState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/SScreenEffectExtraState.SScreenEffectExtraState", ref SScreenEffectExtraState._ScriptStructPtr);
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x06020A94 RID: 133780 RVA: 0x008D94E0 File Offset: 0x008D76E0
		// (set) Token: 0x06020A95 RID: 133781 RVA: 0x008D9523 File Offset: 0x008D7723
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)SScreenEffectExtraState.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x06020A96 RID: 133782 RVA: 0x008D9534 File Offset: 0x008D7734
		// (set) Token: 0x06020A97 RID: 133783 RVA: 0x008D9577 File Offset: 0x008D7777
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)SScreenEffectExtraState.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06020A98 RID: 133784 RVA: 0x008D9585 File Offset: 0x008D7785
		public SScreenEffectExtraState()
		{
		}

		// Token: 0x06020A99 RID: 133785 RVA: 0x008D958D File Offset: 0x008D778D
		public SScreenEffectExtraState(TMap<FName, float> FloatParameters, TMap<FName, FLinearColor> ColorParameters)
		{
			this.FloatParameters = FloatParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x06020A9A RID: 133786 RVA: 0x008D95A3 File Offset: 0x008D77A3
		protected override IntPtr GetUStructPtr()
		{
			return SScreenEffectExtraState.StaticStruct();
		}

		// Token: 0x06020A9B RID: 133787 RVA: 0x008D95AF File Offset: 0x008D77AF
		[NullableContext(2)]
		public SScreenEffectExtraState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020A9C RID: 133788 RVA: 0x008D95B9 File Offset: 0x008D77B9
		public SScreenEffectExtraState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020A9D RID: 133789 RVA: 0x008D95C4 File Offset: 0x008D77C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SScreenEffectExtraState(Pointer, false, true);
		}

		// Token: 0x06020A9E RID: 133790 RVA: 0x008D95CE File Offset: 0x008D77CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SScreenEffectExtraState(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD98 RID: 64920
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/SScreenEffectExtraState.SScreenEffectExtraState";

		// Token: 0x0400FD99 RID: 64921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD9A RID: 64922
		internal static int __PropertyOffset_0;

		// Token: 0x0400FD9B RID: 64923
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x0400FD9C RID: 64924
		internal static int __PropertyOffset_1;

		// Token: 0x0400FD9D RID: 64925
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;
	}
}
