using System;
using System.Runtime.CompilerServices;

// Token: 0x02003294 RID: 12948
[NullableContext(2)]
[Nullable(0)]
public class PlayerTagComponent : BaseTagComponent
{
	// Token: 0x0601C092 RID: 114834 RVA: 0x007CB729 File Offset: 0x007C9929
	protected override bool OnCreate(IEntityArgs args = null)
	{
		this.TagContainer.AddAnyExactTagListener(new TAnyTagChangeCallback(this.OnAnyExactTagChanged));
		return true;
	}

	// Token: 0x0601C093 RID: 114835 RVA: 0x007CB744 File Offset: 0x007C9944
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x0601C094 RID: 114836 RVA: 0x007CB770 File Offset: 0x007C9970
	protected override bool OnClear()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.ZQR;
		string message = "清理编队tag";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayerId", this.PlayerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (int tagId in this.TagContainer.GetAllExactTags())
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItemsByPlayer(this.PlayerId))
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				if (entityHandle != null)
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity != null)
					{
						BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
						if (component != null)
						{
							component.TagContainer.RemoveExactTag(ETagChannel.Player, tagId);
						}
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0601C095 RID: 114837 RVA: 0x007CB860 File Offset: 0x007C9A60
	public Entity GetEntity()
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)this.PlayerId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.PlayerId,
			IsControl = new bool?(true)
		});
		if (teamItem == null)
		{
			return null;
		}
		EntityHandle entityHandle = teamItem.EntityHandle;
		if (entityHandle == null)
		{
			return null;
		}
		return entityHandle.Entity;
	}

	// Token: 0x0601C096 RID: 114838 RVA: 0x007CB8AC File Offset: 0x007C9AAC
	public BaseTagComponent GetCurrentTagComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseTagComponent>();
	}

	// Token: 0x0601C097 RID: 114839 RVA: 0x007CB8BF File Offset: 0x007C9ABF
	public bool TagContainerHasTag(int tagId)
	{
		return base.HasTag(tagId);
	}

	// Token: 0x0601C098 RID: 114840 RVA: 0x007CB8C8 File Offset: 0x007C9AC8
	public override bool HasTag(int tagId)
	{
		BaseTagComponent currentTagComponent = this.GetCurrentTagComponent();
		return currentTagComponent != null && currentTagComponent.HasTag(tagId);
	}

	// Token: 0x0601C099 RID: 114841 RVA: 0x007CB8DC File Offset: 0x007C9ADC
	protected void OnAnyExactTagChanged(int tagId, int newCount, int oldCount, int exactTagId)
	{
		if (tagId == 0 || oldCount == newCount)
		{
			return;
		}
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItemsByPlayer(this.PlayerId))
		{
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			if (entityHandle != null)
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity != null)
				{
					BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
					if (component != null)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.Player, tagId, newCount - oldCount);
					}
				}
			}
		}
	}

	// Token: 0x0601C09A RID: 114842 RVA: 0x007CB96C File Offset: 0x007C9B6C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerTagComponent playerTagComponent = (PlayerTagComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = playerTagComponent.PlayerId;
		}
		return true;
	}

	// Token: 0x0400DD95 RID: 56725
	public int PlayerId;

	// Token: 0x0400DD96 RID: 56726
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyExactTagChangedStat = Stat.Create("PlayerTagComponent.OnAnyExactTagChanged", "", "");
}
