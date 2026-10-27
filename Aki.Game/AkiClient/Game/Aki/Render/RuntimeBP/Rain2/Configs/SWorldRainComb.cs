using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs
{
	// Token: 0x02003BCA RID: 15306
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/Configs/SWorldRainComb.SWorldRainComb")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SWorldRainComb : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022518 RID: 140568 RVA: 0x00905A9D File Offset: 0x00903C9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWorldRainComb._ScriptStructPtr != 0) ? SWorldRainComb._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Rain2/Configs/SWorldRainComb.SWorldRainComb", ref SWorldRainComb._ScriptStructPtr);
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x06022519 RID: 140569 RVA: 0x00905AC1 File Offset: 0x00903CC1
		// (set) Token: 0x0602251A RID: 140570 RVA: 0x00905AD5 File Offset: 0x00903CD5
		public unsafe UKuroWorldRainComponentSpawnConfig SpawnConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentSpawnConfig>(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0602251B RID: 140571 RVA: 0x00905AEA File Offset: 0x00903CEA
		// (set) Token: 0x0602251C RID: 140572 RVA: 0x00905AFE File Offset: 0x00903CFE
		public unsafe UKuroWorldRainComponentPhysicsConfig PhysicsConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentPhysicsConfig>(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0602251D RID: 140573 RVA: 0x00905B13 File Offset: 0x00903D13
		// (set) Token: 0x0602251E RID: 140574 RVA: 0x00905B27 File Offset: 0x00903D27
		public unsafe UKuroWorldRainComponentCustomDataConfig CustomDataConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentCustomDataConfig>(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0602251F RID: 140575 RVA: 0x00905B3C File Offset: 0x00903D3C
		// (set) Token: 0x06022520 RID: 140576 RVA: 0x00905B50 File Offset: 0x00903D50
		public unsafe UClusteredStuffDataAsset ClusteredStuff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x06022521 RID: 140577 RVA: 0x00905B65 File Offset: 0x00903D65
		// (set) Token: 0x06022522 RID: 140578 RVA: 0x00905B79 File Offset: 0x00903D79
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SWorldRainComb.__PropertyOffset_4, value);
			}
		}

		// Token: 0x06022523 RID: 140579 RVA: 0x00905B8E File Offset: 0x00903D8E
		public SWorldRainComb()
		{
		}

		// Token: 0x06022524 RID: 140580 RVA: 0x00905B96 File Offset: 0x00903D96
		[NullableContext(1)]
		public SWorldRainComb(UKuroWorldRainComponentSpawnConfig SpawnConfig, UKuroWorldRainComponentPhysicsConfig PhysicsConfig, UKuroWorldRainComponentCustomDataConfig CustomDataConfig, UClusteredStuffDataAsset ClusteredStuff, UAkAudioEvent AudioEvent)
		{
			this.SpawnConfig = SpawnConfig;
			this.PhysicsConfig = PhysicsConfig;
			this.CustomDataConfig = CustomDataConfig;
			this.ClusteredStuff = ClusteredStuff;
			this.AudioEvent = AudioEvent;
		}

		// Token: 0x06022525 RID: 140581 RVA: 0x00905BC3 File Offset: 0x00903DC3
		protected override IntPtr GetUStructPtr()
		{
			return SWorldRainComb.StaticStruct();
		}

		// Token: 0x06022526 RID: 140582 RVA: 0x00905BCF File Offset: 0x00903DCF
		public SWorldRainComb(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022527 RID: 140583 RVA: 0x00905BD9 File Offset: 0x00903DD9
		public SWorldRainComb(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022528 RID: 140584 RVA: 0x00905BE4 File Offset: 0x00903DE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWorldRainComb(Pointer, false, true);
		}

		// Token: 0x06022529 RID: 140585 RVA: 0x00905BEE File Offset: 0x00903DEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWorldRainComb(Pointer, MemoryOwner);
		}

		// Token: 0x04010D5D RID: 68957
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/Configs/SWorldRainComb.SWorldRainComb";

		// Token: 0x04010D5E RID: 68958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D5F RID: 68959
		internal static int __PropertyOffset_0;

		// Token: 0x04010D60 RID: 68960
		internal static int __PropertyOffset_1;

		// Token: 0x04010D61 RID: 68961
		internal static int __PropertyOffset_2;

		// Token: 0x04010D62 RID: 68962
		internal static int __PropertyOffset_3;

		// Token: 0x04010D63 RID: 68963
		internal static int __PropertyOffset_4;
	}
}
