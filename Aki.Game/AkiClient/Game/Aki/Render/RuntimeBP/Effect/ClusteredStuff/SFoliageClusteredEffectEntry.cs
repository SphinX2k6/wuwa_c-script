using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff
{
	// Token: 0x02003115 RID: 12565
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SFoliageClusteredEffectEntry : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EC81 RID: 126081 RVA: 0x0091D2F5 File Offset: 0x0091B4F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFoliageClusteredEffectEntry._ScriptStructPtr != 0) ? SFoliageClusteredEffectEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry", ref SFoliageClusteredEffectEntry._ScriptStructPtr);
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0601EC82 RID: 126082 RVA: 0x0091D319 File Offset: 0x0091B519
		// (set) Token: 0x0601EC83 RID: 126083 RVA: 0x0091D32D File Offset: 0x0091B52D
		public unsafe UFoliageType FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType>(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_FoliageType);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_FoliageType, value);
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0601EC84 RID: 126084 RVA: 0x0091D342 File Offset: 0x0091B542
		// (set) Token: 0x0601EC85 RID: 126085 RVA: 0x0091D356 File Offset: 0x0091B556
		public unsafe EffectClusteredStuffSettings EffectSetting
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectClusteredStuffSettings>(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_EffectSetting);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFoliageClusteredEffectEntry.__PropertyOffset_EffectSetting, value);
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0601EC86 RID: 126086 RVA: 0x0091D36B File Offset: 0x0091B56B
		// (set) Token: 0x0601EC87 RID: 126087 RVA: 0x0091D37B File Offset: 0x0091B57B
		public unsafe int NumMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_NumMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_NumMin) = value;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0601EC88 RID: 126088 RVA: 0x0091D38C File Offset: 0x0091B58C
		// (set) Token: 0x0601EC89 RID: 126089 RVA: 0x0091D39C File Offset: 0x0091B59C
		public unsafe int NumMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_NumMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoliageClusteredEffectEntry.__PropertyOffset_NumMax) = value;
			}
		}

		// Token: 0x0601EC8A RID: 126090 RVA: 0x0091D3AD File Offset: 0x0091B5AD
		public SFoliageClusteredEffectEntry()
		{
		}

		// Token: 0x0601EC8B RID: 126091 RVA: 0x0091D3B5 File Offset: 0x0091B5B5
		protected override IntPtr GetUStructPtr()
		{
			return SFoliageClusteredEffectEntry.StaticStruct();
		}

		// Token: 0x0601EC8C RID: 126092 RVA: 0x0091D3C1 File Offset: 0x0091B5C1
		public SFoliageClusteredEffectEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EC8D RID: 126093 RVA: 0x0091D3CB File Offset: 0x0091B5CB
		public SFoliageClusteredEffectEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EC8E RID: 126094 RVA: 0x0091D3D6 File Offset: 0x0091B5D6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFoliageClusteredEffectEntry(Pointer, false, true);
		}

		// Token: 0x0601EC8F RID: 126095 RVA: 0x0091D3E0 File Offset: 0x0091B5E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFoliageClusteredEffectEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040105A5 RID: 66981
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/SFoliageClusteredEffectEntry.SFoliageClusteredEffectEntry";

		// Token: 0x040105A6 RID: 66982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040105A7 RID: 66983
		internal static int __PropertyOffset_FoliageType;

		// Token: 0x040105A8 RID: 66984
		internal static int __PropertyOffset_EffectSetting;

		// Token: 0x040105A9 RID: 66985
		internal static int __PropertyOffset_NumMin;

		// Token: 0x040105AA RID: 66986
		internal static int __PropertyOffset_NumMax;
	}
}
