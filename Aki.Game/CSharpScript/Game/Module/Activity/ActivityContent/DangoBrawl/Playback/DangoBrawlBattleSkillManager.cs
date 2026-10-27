using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.DangoBrawl.Structure;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006865 RID: 26725
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleSkillManager
	{
		// Token: 0x06042BD1 RID: 273361 RVA: 0x0103D86E File Offset: 0x0103BA6E
		public void Init()
		{
			this.LoadSkillEffectConfig();
		}

		// Token: 0x06042BD2 RID: 273362 RVA: 0x0103D878 File Offset: 0x0103BA78
		public void OnActivateGroup(IBattleActionGroup group)
		{
			foreach (IDangoBrawlBattleAction dangoBrawlBattleAction in group.Actions)
			{
				DangoBrawlFightActionSkillCastInfo skillCast = dangoBrawlBattleAction.SkillCast;
				if (skillCast != null)
				{
					EventSystem.Instance.Emit<int, int>(EEventName.OnDangoBrawlItemCdUpdate, skillCast.WeaponItemUId, skillCast.NextReadyMs);
					if (DangoBrawlUtil.ShouldTriggerItemUIEffect(skillCast.WeaponItemUId, EDangoBrawlUIEffectSource.Skill))
					{
						EventSystem.Instance.Emit<DangoBrawlItemUIEffectData>(EEventName.OnDangoBrawlItemUIEffectShow, new DangoBrawlItemUIEffectData
						{
							ItemUId = skillCast.WeaponItemUId,
							IsTriggerLimit = false
						});
					}
					SDangoBrawlSkillEffectInfo effectConfigBySkillId = this.GetEffectConfigBySkillId(skillCast.SkillConfigId);
					if (!(effectConfigBySkillId == null))
					{
						DangoBrawlSkillPerformer dangoBrawlSkillPerformer = new DangoBrawlSkillPerformer(this, effectConfigBySkillId, skillCast);
						this.ActivePerformers.Add(dangoBrawlSkillPerformer);
						dangoBrawlSkillPerformer.Start();
					}
				}
			}
		}

		// Token: 0x06042BD3 RID: 273363 RVA: 0x0103D960 File Offset: 0x0103BB60
		public void Destroy()
		{
			DangoBrawlSkillPerformer[] array = this.ActivePerformers.ToArray();
			this.ActivePerformers.Clear();
			DangoBrawlSkillPerformer[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Destroy();
			}
			this.RowMap.Clear();
			this.OffsetOriginOccupied.Clear();
			this.OffsetActiveList.Clear();
		}

		// Token: 0x06042BD4 RID: 273364 RVA: 0x0103D9BB File Offset: 0x0103BBBB
		public void Unregister(DangoBrawlSkillPerformer performer)
		{
			this.ActivePerformers.Remove(performer);
		}

		// Token: 0x06042BD5 RID: 273365 RVA: 0x0103D9CC File Offset: 0x0103BBCC
		[NullableContext(2)]
		public bool TryClaimOffsetOrigin(string groupName)
		{
			string key = groupName ?? string.Empty;
			bool flag;
			this.OffsetOriginOccupied.TryGetValue(key, out flag);
			if (flag)
			{
				return false;
			}
			this.OffsetOriginOccupied[key] = true;
			return true;
		}

		// Token: 0x06042BD6 RID: 273366 RVA: 0x0103DA08 File Offset: 0x0103BC08
		[NullableContext(2)]
		public void ReleaseOffsetOrigin(string groupName)
		{
			string key = groupName ?? string.Empty;
			this.OffsetOriginOccupied.Remove(key);
		}

		// Token: 0x06042BD7 RID: 273367 RVA: 0x0103DA30 File Offset: 0x0103BC30
		public void RegisterOffset([Nullable(2)] string groupName, global::Vector offset)
		{
			string key = groupName ?? string.Empty;
			List<global::Vector> list;
			if (!this.OffsetActiveList.TryGetValue(key, out list))
			{
				list = new List<global::Vector>();
				this.OffsetActiveList[key] = list;
			}
			list.Add(offset);
		}

		// Token: 0x06042BD8 RID: 273368 RVA: 0x0103DA74 File Offset: 0x0103BC74
		public void UnregisterOffset([Nullable(2)] string groupName, global::Vector offset)
		{
			string key = groupName ?? string.Empty;
			List<global::Vector> list;
			if (this.OffsetActiveList.TryGetValue(key, out list))
			{
				list.Remove(offset);
			}
		}

		// Token: 0x06042BD9 RID: 273369 RVA: 0x0103DAA4 File Offset: 0x0103BCA4
		public List<global::Vector> GetActiveOffsets([Nullable(2)] string groupName)
		{
			string key = groupName ?? string.Empty;
			List<global::Vector> result;
			if (!this.OffsetActiveList.TryGetValue(key, out result))
			{
				return new List<global::Vector>();
			}
			return result;
		}

		// Token: 0x1700978C RID: 38796
		// (get) Token: 0x06042BDA RID: 273370 RVA: 0x0103DAD3 File Offset: 0x0103BCD3
		public bool HasActivePerformer
		{
			get
			{
				return this.ActivePerformers.Count > 0;
			}
		}

		// Token: 0x06042BDB RID: 273371 RVA: 0x0103DAE4 File Offset: 0x0103BCE4
		public void Tick(float delta)
		{
			for (int i = this.ActivePerformers.Count - 1; i >= 0; i--)
			{
				this.ActivePerformers[i].Tick(delta);
			}
		}

		// Token: 0x06042BDC RID: 273372 RVA: 0x0103DB1C File Offset: 0x0103BD1C
		public int GetSegmentHitDelayMs(int skillConfigId, int segmentIndex)
		{
			SDangoBrawlSkillEffectInfo effectConfigBySkillId = this.GetEffectConfigBySkillId(skillConfigId);
			if (effectConfigBySkillId == null)
			{
				return 0;
			}
			TArray<float> damageHitDelay = effectConfigBySkillId.DamageHitDelay;
			if (damageHitDelay == null || damageHitDelay.Num() == 0)
			{
				return 0;
			}
			int num = segmentIndex;
			if (num < 0)
			{
				num = 0;
			}
			else if (num >= damageHitDelay.Num())
			{
				num = damageHitDelay.Num() - 1;
			}
			return (int)(damageHitDelay.Get(num) * 1000f);
		}

		// Token: 0x06042BDD RID: 273373 RVA: 0x0103DB7C File Offset: 0x0103BD7C
		public int GetMontageLoopTimeMs(int skillConfigId)
		{
			SDangoBrawlSkillEffectInfo effectConfigBySkillId = this.GetEffectConfigBySkillId(skillConfigId);
			if (effectConfigBySkillId == null)
			{
				return 0;
			}
			return (int)(effectConfigBySkillId.MontageLoopTime * 1000f);
		}

		// Token: 0x06042BDE RID: 273374 RVA: 0x0103DBAC File Offset: 0x0103BDAC
		[NullableContext(2)]
		private unsafe SDangoBrawlSkillEffectInfo GetEffectConfigBySkillId(int skillConfigId)
		{
			DangoBrawlSkill? skillConfigById = DangoBrawlConfig.Instance.GetSkillConfigById(skillConfigId);
			if (skillConfigById == null)
			{
				return null;
			}
			int playEffectId = skillConfigById.Value.PlayEffectId;
			SDangoBrawlSkillEffectInfo result;
			if (!this.RowMap.TryGetValue(playEffectId, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[SkillManager] DangoBrawlSkillEffectConfig 查不到 playEffectId, 跳过表现";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillConfigId", skillConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("playEffectId", playEffectId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			return result;
		}

		// Token: 0x06042BDF RID: 273375 RVA: 0x0103DC54 File Offset: 0x0103BE54
		private unsafe void LoadSkillEffectConfig()
		{
			this.RowMap.Clear();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("DangoBrawlSkillEffectConfig");
			if (string.IsNullOrEmpty(resourcePath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "[SkillManager] UiResourceConfig 缺 DangoBrawlSkillEffectConfig 资源 id 配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("resourceId", "DangoBrawlSkillEffectConfig");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(resourcePath, "js_undefined");
			if (udataTable == null || !udataTable.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.DangoBrawl;
				ELogAuthor author2 = ELogAuthor.WHJ;
				string message2 = "[SkillManager] 加载 DangoBrawlSkillEffectConfig 失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("resourceId", "DangoBrawlSkillEffectConfig");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("path", resourcePath);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			foreach (SDangoBrawlSkillEffectInfo sdangoBrawlSkillEffectInfo in DataTableUtil.GetDataTableAllRowFromTable<SDangoBrawlSkillEffectInfo>(udataTable))
			{
				this.RowMap[sdangoBrawlSkillEffectInfo.Id] = sdangoBrawlSkillEffectInfo;
			}
		}

		// Token: 0x04022BD2 RID: 142290
		private const string SkillEffectConfigResourceId = "DangoBrawlSkillEffectConfig";

		// Token: 0x04022BD3 RID: 142291
		private readonly Dictionary<int, SDangoBrawlSkillEffectInfo> RowMap = new Dictionary<int, SDangoBrawlSkillEffectInfo>();

		// Token: 0x04022BD4 RID: 142292
		private readonly List<DangoBrawlSkillPerformer> ActivePerformers = new List<DangoBrawlSkillPerformer>();

		// Token: 0x04022BD5 RID: 142293
		private readonly Dictionary<string, bool> OffsetOriginOccupied = new Dictionary<string, bool>();

		// Token: 0x04022BD6 RID: 142294
		private readonly Dictionary<string, List<global::Vector>> OffsetActiveList = new Dictionary<string, List<global::Vector>>();
	}
}
