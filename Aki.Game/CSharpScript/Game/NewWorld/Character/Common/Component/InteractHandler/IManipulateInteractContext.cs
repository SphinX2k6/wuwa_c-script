using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007110 RID: 28944
	[NullableContext(2)]
	public interface IManipulateInteractContext
	{
		// Token: 0x17009D10 RID: 40208
		// (get) Token: 0x06046AA1 RID: 289441
		[Nullable(1)]
		BaseTagComponent TagComp { [NullableContext(1)] get; }

		// Token: 0x17009D11 RID: 40209
		// (get) Token: 0x06046AA2 RID: 289442
		[Nullable(1)]
		CharacterBuffComponent BuffComp { [NullableContext(1)] get; }

		// Token: 0x17009D12 RID: 40210
		// (get) Token: 0x06046AA3 RID: 289443
		[Nullable(1)]
		CharacterActorComponent ActorComp { [NullableContext(1)] get; }

		// Token: 0x17009D13 RID: 40211
		// (get) Token: 0x06046AA4 RID: 289444
		[Nullable(1)]
		CreatureDataComponent CreatureDataComp { [NullableContext(1)] get; }

		// Token: 0x17009D14 RID: 40212
		// (get) Token: 0x06046AA5 RID: 289445
		string EffectPath { get; }

		// Token: 0x17009D15 RID: 40213
		// (get) Token: 0x06046AA6 RID: 289446
		SceneItemExploreInteractComponent ChooseTargetOnStartSkill { get; }

		// Token: 0x17009D16 RID: 40214
		// (get) Token: 0x06046AA7 RID: 289447
		SceneItemExploreInteractComponent BestTargetInternal { get; }

		// Token: 0x17009D17 RID: 40215
		// (get) Token: 0x06046AA8 RID: 289448
		bool CurrentPointLegal { get; }

		// Token: 0x17009D18 RID: 40216
		// (get) Token: 0x06046AA9 RID: 289449
		// (set) Token: 0x06046AAA RID: 289450
		bool Interacting { get; set; }

		// Token: 0x17009D19 RID: 40217
		// (get) Token: 0x06046AAB RID: 289451
		// (set) Token: 0x06046AAC RID: 289452
		SceneItemExploreInteractComponent SelectedTargetInternal { get; set; }

		// Token: 0x17009D1A RID: 40218
		// (get) Token: 0x06046AAD RID: 289453
		// (set) Token: 0x06046AAE RID: 289454
		long? CurBuffId { get; set; }

		// Token: 0x06046AAF RID: 289455
		bool CheckBeforeInteract(EExploreSkillInteractType type);

		// Token: 0x06046AB0 RID: 289456
		void RequestInteractAction();

		// Token: 0x06046AB1 RID: 289457
		void SpawnEffect();
	}
}
