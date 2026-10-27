using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff
{
	// Token: 0x02003DE1 RID: 15841
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SFoliageClusteredEffectEntry : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060277FC RID: 161788 RVA: 0x00993251 File Offset: 0x00991451
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFoliageClusteredEffectEntry._ScriptStructPtr != 0) ? SFoliageClusteredEffectEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry", ref SFoliageClusteredEffectEntry._ScriptStructPtr);
		}

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x060277FD RID: 161789 RVA: 0x00993275 File Offset: 0x00991475
		// (set) Token: 0x060277FE RID: 161790 RVA: 0x00993289 File Offset: 0x00991489
		public unsafe UFoliageType FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType>(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x060277FF RID: 161791 RVA: 0x0099329E File Offset: 0x0099149E
		// (set) Token: 0x06027800 RID: 161792 RVA: 0x009932B2 File Offset: 0x009914B2
		public unsafe EffectClusteredStuffSettings EffectSetting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectClusteredStuffSettings>(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x06027801 RID: 161793 RVA: 0x009932C7 File Offset: 0x009914C7
		// (set) Token: 0x06027802 RID: 161794 RVA: 0x009932D7 File Offset: 0x009914D7
		public unsafe int NumMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x06027803 RID: 161795 RVA: 0x009932E8 File Offset: 0x009914E8
		// (set) Token: 0x06027804 RID: 161796 RVA: 0x009932F8 File Offset: 0x009914F8
		public unsafe int NumMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06027805 RID: 161797 RVA: 0x00993309 File Offset: 0x00991509
		public SFoliageClusteredEffectEntry()
		{
		}

		// Token: 0x06027806 RID: 161798 RVA: 0x00993311 File Offset: 0x00991511
		[NullableContext(1)]
		public SFoliageClusteredEffectEntry(UFoliageType FoliageType, EffectClusteredStuffSettings EffectSetting, int NumMin, int NumMax)
		{
			this.FoliageType = FoliageType;
			this.EffectSetting = EffectSetting;
			this.NumMin = NumMin;
			this.NumMax = NumMax;
		}

		// Token: 0x06027807 RID: 161799 RVA: 0x00993336 File Offset: 0x00991536
		protected override IntPtr GetUStructPtr()
		{
			return SFoliageClusteredEffectEntry.StaticStruct();
		}

		// Token: 0x06027808 RID: 161800 RVA: 0x00993342 File Offset: 0x00991542
		public SFoliageClusteredEffectEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027809 RID: 161801 RVA: 0x0099334C File Offset: 0x0099154C
		public SFoliageClusteredEffectEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602780A RID: 161802 RVA: 0x00993357 File Offset: 0x00991557
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFoliageClusteredEffectEntry(Pointer, false, true);
		}

		// Token: 0x0602780B RID: 161803 RVA: 0x00993361 File Offset: 0x00991561
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFoliageClusteredEffectEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04013F75 RID: 81781
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry";

		// Token: 0x04013F76 RID: 81782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F77 RID: 81783
		internal static int __PropertyOffset_0;

		// Token: 0x04013F78 RID: 81784
		internal static int __PropertyOffset_1;

		// Token: 0x04013F79 RID: 81785
		internal static int __PropertyOffset_2;

		// Token: 0x04013F7A RID: 81786
		internal static int __PropertyOffset_3;
	}
}
