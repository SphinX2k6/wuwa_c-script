using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.StaticSceneInteraction
{
	// Token: 0x02003E55 RID: 15957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveConfig.SInteractiveConfig")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class SInteractiveConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281AD RID: 164269 RVA: 0x009A41CF File Offset: 0x009A23CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractiveConfig._ScriptStructPtr != 0) ? SInteractiveConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveConfig.SInteractiveConfig", ref SInteractiveConfig._ScriptStructPtr);
		}

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x060281AE RID: 164270 RVA: 0x009A41F4 File Offset: 0x009A23F4
		// (set) Token: 0x060281AF RID: 164271 RVA: 0x009A4237 File Offset: 0x009A2437
		public TArray<AStaticMeshActor> ReferActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._ReferActors) == null)
				{
					result = (this._ReferActors = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferActors.CopyAssign(value);
			}
		}

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x060281B0 RID: 164272 RVA: 0x009A4245 File Offset: 0x009A2445
		// (set) Token: 0x060281B1 RID: 164273 RVA: 0x009A4255 File Offset: 0x009A2455
		public unsafe int WuYinQuState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x060281B2 RID: 164274 RVA: 0x009A4266 File Offset: 0x009A2466
		// (set) Token: 0x060281B3 RID: 164275 RVA: 0x009A4285 File Offset: 0x009A2485
		public TSoftObjectPtr<ItemMaterialControllerActorData> MaterialData
		{
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x060281B4 RID: 164276 RVA: 0x009A42AC File Offset: 0x009A24AC
		// (set) Token: 0x060281B5 RID: 164277 RVA: 0x009A42EF File Offset: 0x009A24EF
		public TArray<AActor> HideActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HideActors) == null)
				{
					result = (this._HideActors = new TArray<AActor>(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HideActors.CopyAssign(value);
			}
		}

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x060281B6 RID: 164278 RVA: 0x009A4300 File Offset: 0x009A2500
		// (set) Token: 0x060281B7 RID: 164279 RVA: 0x009A4343 File Offset: 0x009A2543
		public TArray<AActor> ShowActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ShowActors) == null)
				{
					result = (this._ShowActors = new TArray<AActor>(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShowActors.CopyAssign(value);
			}
		}

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x060281B8 RID: 164280 RVA: 0x009A4354 File Offset: 0x009A2554
		// (set) Token: 0x060281B9 RID: 164281 RVA: 0x009A4397 File Offset: 0x009A2597
		public TArray<SInteractivePPVConfig> PPVConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInteractivePPVConfig> result;
				if ((result = this._PPVConfig) == null)
				{
					result = (this._PPVConfig = new TArray<SInteractivePPVConfig>(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PPVConfig.CopyAssign(value);
			}
		}

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x060281BA RID: 164282 RVA: 0x009A43A8 File Offset: 0x009A25A8
		// (set) Token: 0x060281BB RID: 164283 RVA: 0x009A43EB File Offset: 0x009A25EB
		public SInteractiveLevelSequenceConfig LevelSequenceConfig
		{
			get
			{
				base.FastCheckIsValid();
				SInteractiveLevelSequenceConfig result;
				if ((result = this._LevelSequenceConfig) == null)
				{
					result = (this._LevelSequenceConfig = new SInteractiveLevelSequenceConfig(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SInteractiveLevelSequenceConfig.StaticStruct(), base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x060281BC RID: 164284 RVA: 0x009A440C File Offset: 0x009A260C
		// (set) Token: 0x060281BD RID: 164285 RVA: 0x009A444F File Offset: 0x009A264F
		public SSceneInteractionMaterialParameterCollection MPCParams
		{
			get
			{
				base.FastCheckIsValid();
				SSceneInteractionMaterialParameterCollection result;
				if ((result = this._MPCParams) == null)
				{
					result = (this._MPCParams = new SSceneInteractionMaterialParameterCollection(base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSceneInteractionMaterialParameterCollection.StaticStruct(), base.NativePtr + (IntPtr)SInteractiveConfig.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060281BE RID: 164286 RVA: 0x009A4470 File Offset: 0x009A2670
		public SInteractiveConfig()
		{
		}

		// Token: 0x060281BF RID: 164287 RVA: 0x009A4478 File Offset: 0x009A2678
		public SInteractiveConfig(TArray<AStaticMeshActor> ReferActors, int WuYinQuState, TSoftObjectPtr<ItemMaterialControllerActorData> MaterialData, TArray<AActor> HideActors, TArray<AActor> ShowActors, TArray<SInteractivePPVConfig> PPVConfig, SInteractiveLevelSequenceConfig LevelSequenceConfig, SSceneInteractionMaterialParameterCollection MPCParams)
		{
			this.ReferActors = ReferActors;
			this.WuYinQuState = WuYinQuState;
			this.MaterialData = MaterialData;
			this.HideActors = HideActors;
			this.ShowActors = ShowActors;
			this.PPVConfig = PPVConfig;
			this.LevelSequenceConfig = LevelSequenceConfig;
			this.MPCParams = MPCParams;
		}

		// Token: 0x060281C0 RID: 164288 RVA: 0x009A44C8 File Offset: 0x009A26C8
		protected override IntPtr GetUStructPtr()
		{
			return SInteractiveConfig.StaticStruct();
		}

		// Token: 0x060281C1 RID: 164289 RVA: 0x009A44D4 File Offset: 0x009A26D4
		[NullableContext(2)]
		public SInteractiveConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281C2 RID: 164290 RVA: 0x009A44DE File Offset: 0x009A26DE
		public SInteractiveConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281C3 RID: 164291 RVA: 0x009A44E9 File Offset: 0x009A26E9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractiveConfig(Pointer, false, true);
		}

		// Token: 0x060281C4 RID: 164292 RVA: 0x009A44F3 File Offset: 0x009A26F3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractiveConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014697 RID: 83607
		public const string __ObjectPath = "/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveConfig.SInteractiveConfig";

		// Token: 0x04014698 RID: 83608
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014699 RID: 83609
		internal static int __PropertyOffset_0;

		// Token: 0x0401469A RID: 83610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _ReferActors;

		// Token: 0x0401469B RID: 83611
		internal static int __PropertyOffset_1;

		// Token: 0x0401469C RID: 83612
		internal static int __PropertyOffset_2;

		// Token: 0x0401469D RID: 83613
		internal static int __PropertyOffset_3;

		// Token: 0x0401469E RID: 83614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HideActors;

		// Token: 0x0401469F RID: 83615
		internal static int __PropertyOffset_4;

		// Token: 0x040146A0 RID: 83616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ShowActors;

		// Token: 0x040146A1 RID: 83617
		internal static int __PropertyOffset_5;

		// Token: 0x040146A2 RID: 83618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInteractivePPVConfig> _PPVConfig;

		// Token: 0x040146A3 RID: 83619
		internal static int __PropertyOffset_6;

		// Token: 0x040146A4 RID: 83620
		[Nullable(2)]
		private SInteractiveLevelSequenceConfig _LevelSequenceConfig;

		// Token: 0x040146A5 RID: 83621
		internal static int __PropertyOffset_7;

		// Token: 0x040146A6 RID: 83622
		[Nullable(2)]
		private SSceneInteractionMaterialParameterCollection _MPCParams;
	}
}
