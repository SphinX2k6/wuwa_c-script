using System;
using Aki.Config;

// Token: 0x02003085 RID: 12421
public class CharacterShield
{
	// Token: 0x0601A88A RID: 108682 RVA: 0x0071A87C File Offset: 0x00718A7C
	public CharacterShield(int id, int templateId, float value)
	{
		this.Id = id;
		this.TemplateId = templateId;
		this.Value = value;
		this.HandleId = id;
		Shield? config = ConfigShieldById.GetConfig(templateId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "护盾添加失败，护盾Id不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", templateId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Priority = config.Value.Priority;
		this.ShieldValue = value;
	}

	// Token: 0x0400CBCE RID: 52174
	public readonly int Priority;

	// Token: 0x0400CBCF RID: 52175
	public float ShieldValue;

	// Token: 0x0400CBD0 RID: 52176
	public int HandleId;

	// Token: 0x0400CBD1 RID: 52177
	public readonly int Id;

	// Token: 0x0400CBD2 RID: 52178
	public readonly int TemplateId;

	// Token: 0x0400CBD3 RID: 52179
	public readonly float Value;
}
