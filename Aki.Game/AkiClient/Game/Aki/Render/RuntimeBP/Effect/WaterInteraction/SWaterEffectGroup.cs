using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction
{
	// Token: 0x02003DBA RID: 15802
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SWaterEffectGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027476 RID: 160886 RVA: 0x0098D200 File Offset: 0x0098B400
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWaterEffectGroup._ScriptStructPtr != 0) ? SWaterEffectGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup", ref SWaterEffectGroup._ScriptStructPtr);
		}

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x06027477 RID: 160887 RVA: 0x0098D224 File Offset: 0x0098B424
		// (set) Token: 0x06027478 RID: 160888 RVA: 0x0098D234 File Offset: 0x0098B434
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x06027479 RID: 160889 RVA: 0x0098D248 File Offset: 0x0098B448
		// (set) Token: 0x0602747A RID: 160890 RVA: 0x0098D28B File Offset: 0x0098B48B
		public TArray<SWaterEffectItem> EffectConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWaterEffectItem> result;
				if ((result = this._EffectConfig) == null)
				{
					result = (this._EffectConfig = new TArray<SWaterEffectItem>(base.NativePtr + (IntPtr)SWaterEffectGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectConfig.CopyAssign(value);
			}
		}

		// Token: 0x0602747B RID: 160891 RVA: 0x0098D299 File Offset: 0x0098B499
		public SWaterEffectGroup()
		{
		}

		// Token: 0x0602747C RID: 160892 RVA: 0x0098D2A1 File Offset: 0x0098B4A1
		public SWaterEffectGroup(float WaterDepth, TArray<SWaterEffectItem> EffectConfig)
		{
			this.WaterDepth = WaterDepth;
			this.EffectConfig = EffectConfig;
		}

		// Token: 0x0602747D RID: 160893 RVA: 0x0098D2B7 File Offset: 0x0098B4B7
		protected override IntPtr GetUStructPtr()
		{
			return SWaterEffectGroup.StaticStruct();
		}

		// Token: 0x0602747E RID: 160894 RVA: 0x0098D2C3 File Offset: 0x0098B4C3
		[NullableContext(2)]
		public SWaterEffectGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602747F RID: 160895 RVA: 0x0098D2CD File Offset: 0x0098B4CD
		public SWaterEffectGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027480 RID: 160896 RVA: 0x0098D2D8 File Offset: 0x0098B4D8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWaterEffectGroup(Pointer, false, true);
		}

		// Token: 0x06027481 RID: 160897 RVA: 0x0098D2E2 File Offset: 0x0098B4E2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWaterEffectGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04013D20 RID: 81184
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/WaterInteraction/SWaterEffectGroup.SWaterEffectGroup";

		// Token: 0x04013D21 RID: 81185
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013D22 RID: 81186
		internal static int __PropertyOffset_0;

		// Token: 0x04013D23 RID: 81187
		internal static int __PropertyOffset_1;

		// Token: 0x04013D24 RID: 81188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWaterEffectItem> _EffectConfig;
	}
}
