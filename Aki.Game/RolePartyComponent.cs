using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200324D RID: 12877
public class RolePartyComponent : EntityComponent
{
	// Token: 0x0601BC90 RID: 113808 RVA: 0x007AA628 File Offset: 0x007A8828
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

	// Token: 0x0601BC91 RID: 113809 RVA: 0x007AA6E8 File Offset: 0x007A88E8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RolePartyComponent rolePartyComponent = (RolePartyComponent)componentTemplate;
		return true;
	}
}
