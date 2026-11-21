using System;
using System.Runtime.CompilerServices;

// Token: 0x02002805 RID: 10245
[NullableContext(2)]
[Nullable(0)]
public class PlayerTagComponent : BaseTagComponent
{
	// Token: 0x06019CBB RID: 105659 RVA: 0x007F29E5 File Offset: 0x007F0BE5
	protected override bool OnCreate(IEntityArgs args = null)
	{
		this.TagContainer.AddAnyExactTagListener(new TAnyTagChangeCallback(this.OnAnyExactTagChanged));
		return true;
	}

	// Token: 0x06019CBC RID: 105660 RVA: 0x007F2A00 File Offset: 0x007F0C00
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x06019CBD RID: 105661 RVA: 0x007F2A2C File Offset: 0x007F0C2C
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

	// Token: 0x06019CBE RID: 105662 RVA: 0x007F2B1C File Offset: 0x007F0D1C
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

	// Token: 0x06019CBF RID: 105663 RVA: 0x007F2B68 File Offset: 0x007F0D68
	public BaseTagComponent GetCurrentTagComponent()
	{
		Entity entity = this.GetEntity();
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseTagComponent>();
	}

	// Token: 0x06019CC0 RID: 105664 RVA: 0x007F2B7B File Offset: 0x007F0D7B
	public bool TagContainerHasTag(int tagId)
	{
		return base.HasTag(tagId);
	}

	// Token: 0x06019CC1 RID: 105665 RVA: 0x007F2B84 File Offset: 0x007F0D84
	public override bool HasTag(int tagId)
	{
		BaseTagComponent currentTagComponent = this.GetCurrentTagComponent();
		return currentTagComponent != null && currentTagComponent.HasTag(tagId);
	}

	// Token: 0x06019CC2 RID: 105666 RVA: 0x007F2B98 File Offset: 0x007F0D98
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

	// Token: 0x06019CC3 RID: 105667 RVA: 0x007F2C28 File Offset: 0x007F0E28
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerTagComponent playerTagComponent = (PlayerTagComponent)componentTemplate;
		this.PlayerId = playerTagComponent.PlayerId;
		return true;
	}

	// Token: 0x17002991 RID: 10641
	// (get) Token: 0x06019CC4 RID: 105668 RVA: 0x007F2C54 File Offset: 0x007F0E54
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002992 RID: 10642
	// (get) Token: 0x06019CC5 RID: 105669 RVA: 0x007F2C57 File Offset: 0x007F0E57
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002993 RID: 10643
	// (get) Token: 0x06019CC6 RID: 105670 RVA: 0x007F2C5A File Offset: 0x007F0E5A
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002994 RID: 10644
	// (get) Token: 0x06019CC7 RID: 105671 RVA: 0x007F2C5D File Offset: 0x007F0E5D
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002995 RID: 10645
	// (get) Token: 0x06019CC8 RID: 105672 RVA: 0x007F2C60 File Offset: 0x007F0E60
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E23C RID: 57916
	public int PlayerId;

	// Token: 0x0400E23D RID: 57917
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat OnAnyExactTagChangedStat = Stat.Create("PlayerTagComponent.OnAnyExactTagChanged", "", "");
}
