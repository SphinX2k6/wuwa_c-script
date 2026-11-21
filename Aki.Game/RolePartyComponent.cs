using System;
using Aki.Config;

// Token: 0x020027BC RID: 10172
public class RolePartyComponent : EntityComponent
{
	// Token: 0x0601984B RID: 104523 RVA: 0x007D2C04 File Offset: 0x007D0E04
	protected override bool OnStart()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		BaseTagComponent baseTagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		RoleInfo? roleConfig = component.GetRoleConfig();
		Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(roleConfig.Value.PartyId);
		if (influenceConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "势力.xlsx配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", component.GetRoleId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		for (int i = 0; i < influenceConfig.Value.PartyTagsLength; i++)
		{
			baseTagComponent.AddTag(new int?(influenceConfig.Value.PartyTags(i)));
		}
		return true;
	}

	// Token: 0x170028BB RID: 10427
	// (get) Token: 0x0601984C RID: 104524 RVA: 0x007D2CC4 File Offset: 0x007D0EC4
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}
}
