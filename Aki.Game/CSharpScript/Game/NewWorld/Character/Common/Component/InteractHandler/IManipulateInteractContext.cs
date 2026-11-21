using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x0200633E RID: 25406
	[NullableContext(2)]
	public interface IManipulateInteractContext
	{
		// Token: 0x170074D6 RID: 29910
		// (get) Token: 0x0603D8E6 RID: 252134
		[Nullable(1)]
		BaseTagComponent TagComp { [NullableContext(1)] get; }

		// Token: 0x170074D7 RID: 29911
		// (get) Token: 0x0603D8E7 RID: 252135
		[Nullable(1)]
		CharacterBuffComponent BuffComp { [NullableContext(1)] get; }

		// Token: 0x170074D8 RID: 29912
		// (get) Token: 0x0603D8E8 RID: 252136
		[Nullable(1)]
		CharacterActorComponent ActorComp { [NullableContext(1)] get; }

		// Token: 0x170074D9 RID: 29913
		// (get) Token: 0x0603D8E9 RID: 252137
		[Nullable(1)]
		CreatureDataComponent CreatureDataComp { [NullableContext(1)] get; }

		// Token: 0x170074DA RID: 29914
		// (get) Token: 0x0603D8EA RID: 252138
		string EffectPath { get; }

		// Token: 0x170074DB RID: 29915
		// (get) Token: 0x0603D8EB RID: 252139
		SceneItemExploreInteractComponent ChooseTargetOnStartSkill { get; }

		// Token: 0x170074DC RID: 29916
		// (get) Token: 0x0603D8EC RID: 252140
		SceneItemExploreInteractComponent BestTargetInternal { get; }

		// Token: 0x170074DD RID: 29917
		// (get) Token: 0x0603D8ED RID: 252141
		bool CurrentPointLegal { get; }

		// Token: 0x170074DE RID: 29918
		// (get) Token: 0x0603D8EE RID: 252142
		// (set) Token: 0x0603D8EF RID: 252143
		bool Interacting { get; set; }

		// Token: 0x170074DF RID: 29919
		// (get) Token: 0x0603D8F0 RID: 252144
		// (set) Token: 0x0603D8F1 RID: 252145
		SceneItemExploreInteractComponent SelectedTargetInternal { get; set; }

		// Token: 0x170074E0 RID: 29920
		// (get) Token: 0x0603D8F2 RID: 252146
		// (set) Token: 0x0603D8F3 RID: 252147
		long? CurBuffId { get; set; }

		// Token: 0x0603D8F4 RID: 252148
		bool CheckBeforeInteract(EExploreSkillInteractType type);

		// Token: 0x0603D8F5 RID: 252149
		void RequestInteractAction();

		// Token: 0x0603D8F6 RID: 252150
		void SpawnEffect();
	}
}
