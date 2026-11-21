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
	// Token: 0x020057B5 RID: 22453
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleSkillManager
	{
		// Token: 0x06037728 RID: 227112 RVA: 0x00F7ED4E File Offset: 0x00F7CF4E
		public void Init()
		{
			this.LoadSkillEffectConfig();
		}

		// Token: 0x06037729 RID: 227113 RVA: 0x00F7ED58 File Offset: 0x00F7CF58
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

		// Token: 0x0603772A RID: 227114 RVA: 0x00F7EE40 File Offset: 0x00F7D040
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

		// Token: 0x0603772B RID: 227115 RVA: 0x00F7EE9B File Offset: 0x00F7D09B
		public void Unregister(DangoBrawlSkillPerformer performer)
		{
			this.ActivePerformers.Remove(performer);
		}

		// Token: 0x0603772C RID: 227116 RVA: 0x00F7EEAC File Offset: 0x00F7D0AC
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

		// Token: 0x0603772D RID: 227117 RVA: 0x00F7EEE8 File Offset: 0x00F7D0E8
		[NullableContext(2)]
		public void ReleaseOffsetOrigin(string groupName)
		{
			string key = groupName ?? string.Empty;
			this.OffsetOriginOccupied.Remove(key);
		}

		// Token: 0x0603772E RID: 227118 RVA: 0x00F7EF10 File Offset: 0x00F7D110
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

		// Token: 0x0603772F RID: 227119 RVA: 0x00F7EF54 File Offset: 0x00F7D154
		public void UnregisterOffset([Nullable(2)] string groupName, global::Vector offset)
		{
			string key = groupName ?? string.Empty;
			List<global::Vector> list;
			if (this.OffsetActiveList.TryGetValue(key, out list))
			{
				list.Remove(offset);
			}
		}

		// Token: 0x06037730 RID: 227120 RVA: 0x00F7EF84 File Offset: 0x00F7D184
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

		// Token: 0x17006ACD RID: 27341
		// (get) Token: 0x06037731 RID: 227121 RVA: 0x00F7EFB3 File Offset: 0x00F7D1B3
		public bool HasActivePerformer
		{
			get
			{
				return this.ActivePerformers.Count > 0;
			}
		}

		// Token: 0x06037732 RID: 227122 RVA: 0x00F7EFC4 File Offset: 0x00F7D1C4
		public void Tick(float delta)
		{
			for (int i = this.ActivePerformers.Count - 1; i >= 0; i--)
			{
				this.ActivePerformers[i].Tick(delta);
			}
		}

		// Token: 0x06037733 RID: 227123 RVA: 0x00F7EFFC File Offset: 0x00F7D1FC
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

		// Token: 0x06037734 RID: 227124 RVA: 0x00F7F05C File Offset: 0x00F7D25C
		public int GetMontageLoopTimeMs(int skillConfigId)
		{
			SDangoBrawlSkillEffectInfo effectConfigBySkillId = this.GetEffectConfigBySkillId(skillConfigId);
			if (effectConfigBySkillId == null)
			{
				return 0;
			}
			return (int)(effectConfigBySkillId.MontageLoopTime * 1000f);
		}

		// Token: 0x06037735 RID: 227125 RVA: 0x00F7F08C File Offset: 0x00F7D28C
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

		// Token: 0x06037736 RID: 227126 RVA: 0x00F7F134 File Offset: 0x00F7D334
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

		// Token: 0x0401D42F RID: 119855
		private const string SkillEffectConfigResourceId = "DangoBrawlSkillEffectConfig";

		// Token: 0x0401D430 RID: 119856
		private readonly Dictionary<int, SDangoBrawlSkillEffectInfo> RowMap = new Dictionary<int, SDangoBrawlSkillEffectInfo>();

		// Token: 0x0401D431 RID: 119857
		private readonly List<DangoBrawlSkillPerformer> ActivePerformers = new List<DangoBrawlSkillPerformer>();

		// Token: 0x0401D432 RID: 119858
		private readonly Dictionary<string, bool> OffsetOriginOccupied = new Dictionary<string, bool>();

		// Token: 0x0401D433 RID: 119859
		private readonly Dictionary<string, List<global::Vector>> OffsetActiveList = new Dictionary<string, List<global::Vector>>();
	}
}
