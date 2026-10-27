using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02003254 RID: 12884
public class RoleTagComponent : BaseTagComponent
{
	// Token: 0x0601BCC4 RID: 113860 RVA: 0x007ACA7E File Offset: 0x007AAC7E
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoaded));
		return true;
	}

	// Token: 0x0601BCC5 RID: 113861 RVA: 0x007ACA9D File Offset: 0x007AAC9D
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoaded));
		return true;
	}

	// Token: 0x0601BCC6 RID: 113862 RVA: 0x007ACABC File Offset: 0x007AACBC
	private unsafe void OnFormationLoaded()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		int playerId = component.GetPlayerId();
		List<SceneTeamItem> teamItemsByPlayer = SceneTeamModel.Instance.GetTeamItemsByPlayer(playerId);
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		BaseTagComponent baseTagComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "RoleTagComponent初始化时找不到对应的PlayerTag组件";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", (component != null) ? new int?(component.GetPlayerId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Entity", base.Entity.Id);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		bool flag = teamItemsByPlayer.Exists(delegate(SceneTeamItem formationIns)
		{
			EntityHandle entityHandle = formationIns.EntityHandle;
			return ((entityHandle != null) ? entityHandle.Entity : null) == base.Entity;
		}) && baseTagComponent != null;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		if (flag)
		{
			TagContainer tagContainer = this.TagContainer;
			TagContainer tagContainer2 = baseTagComponent.TagContainer;
			foreach (int num in this.TagContainer.GetAllExactTags())
			{
				dictionary[num] = tagContainer2.GetExactTagCount(num) - tagContainer.GetRawTagCount(ETagChannel.Player, num);
			}
			using (IEnumerator<int> enumerator = baseTagComponent.TagContainer.GetAllExactTags().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int num2 = enumerator.Current;
					if (!dictionary.ContainsKey(num2))
					{
						dictionary[num2] = tagContainer2.GetExactTagCount(num2) - tagContainer.GetRawTagCount(ETagChannel.Player, num2);
					}
				}
				goto IL_1EE;
			}
		}
		foreach (int num3 in this.TagContainer.GetAllExactTags())
		{
			dictionary[num3] = -this.TagContainer.GetRawTagCount(ETagChannel.Player, num3);
		}
		IL_1EE:
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			this.TagContainer.UpdateExactTag(ETagChannel.Player, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x0601BCC7 RID: 113863 RVA: 0x007ACD34 File Offset: 0x007AAF34
	protected override void OnAnyTagChanged(int tagId, int newCount, int oldCount, int exactTagId)
	{
		if (tagId == 0 || oldCount == newCount)
		{
			return;
		}
		if ((tagId == GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台"] || tagId == GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.后台"] || tagId == GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]) && ((newCount > 0 && oldCount <= 0) || (newCount <= 0 && oldCount > 0)))
		{
			GameplayTagPush gameplayTagPush = GameplayTagPush.Create();
			gameplayTagPush.TagId = tagId;
			gameplayTagPush.TagCount = newCount;
			CombatNet.Instance.Send(EPushMessageId.GameplayTagPush, base.Entity, gameplayTagPush, null, null, null);
		}
		base.OnAnyTagChanged(tagId, newCount, oldCount, exactTagId);
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		int? num = (component != null) ? new int?(component.GetPlayerId()) : null;
		if (num != null)
		{
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(num.Value);
			PlayerBuffComponent playerBuffComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerBuffComponent>() : null;
			if (playerBuffComponent == null)
			{
				return;
			}
			playerBuffComponent.OnTagChanged(tagId);
		}
	}

	// Token: 0x0601BCC8 RID: 113864 RVA: 0x007ACE37 File Offset: 0x007AB037
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleTagComponent roleTagComponent = (RoleTagComponent)componentTemplate;
		return true;
	}
}
