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
	// Token: 0x020057AE RID: 22446
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBuffEffectManager
	{
		// Token: 0x060376CB RID: 227019 RVA: 0x00F7B59D File Offset: 0x00F7979D
		public void Init()
		{
		}

		// Token: 0x060376CC RID: 227020 RVA: 0x00F7B5A0 File Offset: 0x00F797A0
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

		// Token: 0x060376CD RID: 227021 RVA: 0x00F7B5D4 File Offset: 0x00F797D4
		public void ClearAllEffects()
		{
			foreach (DangoBrawlBattleBuffEffectManager.BuffEffectHandle buffEffectHandle in this.EffectMap.Values.ToArray<DangoBrawlBattleBuffEffectManager.BuffEffectHandle>())
			{
				this.RemoveBuffEffect(buffEffectHandle.ConfigId);
			}
		}

		// Token: 0x060376CE RID: 227022 RVA: 0x00F7B610 File Offset: 0x00F79810
		public void Destroy()
		{
			this.ClearAllEffects();
		}

		// Token: 0x060376CF RID: 227023 RVA: 0x00F7B618 File Offset: 0x00F79818
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

		// Token: 0x060376D0 RID: 227024 RVA: 0x00F7B780 File Offset: 0x00F79980
		private void RemoveBuffEffect(int buffUId)
		{
			DangoBrawlBattleBuffEffectManager.BuffEffectHandle effectHandle;
			if (!this.EffectMap.Remove(buffUId, out effectHandle))
			{
				return;
			}
			this.StopEffect(effectHandle);
		}

		// Token: 0x060376D1 RID: 227025 RVA: 0x00F7B7A8 File Offset: 0x00F799A8
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

		// Token: 0x060376D2 RID: 227026 RVA: 0x00F7B828 File Offset: 0x00F79A28
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

		// Token: 0x0401D40B RID: 119819
		private const string EFFECT_REASON = "DangoBrawlBuff";

		// Token: 0x0401D40C RID: 119820
		private readonly Dictionary<int, DangoBrawlBattleBuffEffectManager.BuffEffectHandle> EffectMap = new Dictionary<int, DangoBrawlBattleBuffEffectManager.BuffEffectHandle>();

		// Token: 0x0200B3FC RID: 46076
		[NullableContext(0)]
		private class BuffEffectHandle
		{
			// Token: 0x04037AC1 RID: 228033
			public int ConfigId;

			// Token: 0x04037AC2 RID: 228034
			[Nullable(1)]
			public HashSet<int> Handles = new HashSet<int>();
		}
	}
}
