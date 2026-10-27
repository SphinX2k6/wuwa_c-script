using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x0200685E RID: 26718
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBuffEffectManager
	{
		// Token: 0x06042B76 RID: 273270 RVA: 0x0103A051 File Offset: 0x01038251
		public void Init()
		{
		}

		// Token: 0x06042B77 RID: 273271 RVA: 0x0103A054 File Offset: 0x01038254
		public void PlayEffectByDelta(BuffVisualDelta delta)
		{
			EDangoBrawlBuffVisualOp op = delta.Op;
			if (op == EDangoBrawlBuffVisualOp.Add)
			{
				this.SpawnBuffEffect(delta);
				return;
			}
			if (op != EDangoBrawlBuffVisualOp.Remove)
			{
				return;
			}
			this.RemoveBuffEffect(delta.BuffUId);
		}

		// Token: 0x06042B78 RID: 273272 RVA: 0x0103A088 File Offset: 0x01038288
		public void ClearAllEffects()
		{
			foreach (DangoBrawlBattleBuffEffectManager.BuffEffectHandle buffEffectHandle in this.EffectMap.Values.ToArray<DangoBrawlBattleBuffEffectManager.BuffEffectHandle>())
			{
				this.RemoveBuffEffect(buffEffectHandle.ConfigId);
			}
		}

		// Token: 0x06042B79 RID: 273273 RVA: 0x0103A0C4 File Offset: 0x010382C4
		public void Destroy()
		{
			this.ClearAllEffects();
		}

		// Token: 0x06042B7A RID: 273274 RVA: 0x0103A0CC File Offset: 0x010382CC
		private unsafe void SpawnBuffEffect(BuffVisualDelta delta)
		{
			DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(delta.BuffConfigId);
			if (buffConfigById == null)
			{
				return;
			}
			string effectDA = buffConfigById.Value.EffectDA;
			if (string.IsNullOrEmpty(effectDA))
			{
				return;
			}
			this.RemoveBuffEffect(delta.BuffUId);
			AActor aactor = this.ResolveTargetActor(delta.TargetFighterUId);
			if (aactor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[BuffEffectManager] SpawnBuffEffect 目标 Actor 未就绪, 跳过挂接";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TargetFighterUId", delta.TargetFighterUId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffUId", delta.BuffUId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BuffConfigId", delta.BuffConfigId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			EffectSystem instance2 = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = null;
			int num = instance2.SpawnEffect(world, ftransformDouble, effectDA, "DangoBrawlBuff", new EffectContext(), EEffectType.Scene, null, null, null, false, false);
			if (num <= 0)
			{
				return;
			}
			EffectSystem instance3 = EffectSystem.Instance;
			int id = num;
			AActor attachActor = aactor;
			FName? fname = null;
			instance3.AttachToEffectSkeletalMesh(id, attachActor, fname, EAttachmentRule.KeepRelative);
			DangoBrawlBattleBuffEffectManager.BuffEffectHandle buffEffectHandle = new DangoBrawlBattleBuffEffectManager.BuffEffectHandle
			{
				ConfigId = delta.BuffConfigId
			};
			buffEffectHandle.Handles.Add(num);
			this.EffectMap[delta.BuffUId] = buffEffectHandle;
		}

		// Token: 0x06042B7B RID: 273275 RVA: 0x0103A234 File Offset: 0x01038434
		private void RemoveBuffEffect(int buffUId)
		{
			DangoBrawlBattleBuffEffectManager.BuffEffectHandle effectHandle;
			if (!this.EffectMap.Remove(buffUId, out effectHandle))
			{
				return;
			}
			this.StopEffect(effectHandle);
		}

		// Token: 0x06042B7C RID: 273276 RVA: 0x0103A25C File Offset: 0x0103845C
		private void StopEffect(DangoBrawlBattleBuffEffectManager.BuffEffectHandle effectHandle)
		{
			foreach (int num in effectHandle.Handles)
			{
				if (EffectSystem.Instance.IsValid(num))
				{
					EffectSystem.Instance.StopEffectById(num, "DangoBrawlBuff", false, null);
				}
			}
			effectHandle.Handles.Clear();
		}

		// Token: 0x06042B7D RID: 273277 RVA: 0x0103A2DC File Offset: 0x010384DC
		[NullableContext(2)]
		private AActor ResolveTargetActor(int targetFighterUId)
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return null;
			}
			bool isSelfByFighterUid = battleManager.GetIsSelfByFighterUid(targetFighterUId);
			ActivityGameplayEntity entity = battleManager.GetEntity(isSelfByFighterUid);
			if (entity == null)
			{
				return null;
			}
			DangoBrawlActorComponent component = entity.GetComponent<DangoBrawlActorComponent>();
			if (component == null)
			{
				return null;
			}
			return component.SpawnedActor;
		}

		// Token: 0x04022BAE RID: 142254
		private const string EFFECT_REASON = "DangoBrawlBuff";

		// Token: 0x04022BAF RID: 142255
		private readonly Dictionary<int, DangoBrawlBattleBuffEffectManager.BuffEffectHandle> EffectMap = new Dictionary<int, DangoBrawlBattleBuffEffectManager.BuffEffectHandle>();

		// Token: 0x0200CA32 RID: 51762
		[NullableContext(0)]
		private class BuffEffectHandle
		{
			// Token: 0x0403D1DC RID: 250332
			public int ConfigId;

			// Token: 0x0403D1DD RID: 250333
			[Nullable(1)]
			public HashSet<int> Handles = new HashSet<int>();
		}
	}
}
