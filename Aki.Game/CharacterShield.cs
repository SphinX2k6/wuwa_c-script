using System;
using Aki.Config;

// Token: 0x020025DC RID: 9692
public class CharacterShield
{
	// Token: 0x0601826D RID: 98925 RVA: 0x00740D10 File Offset: 0x0073EF10
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

	// Token: 0x0400CFB1 RID: 53169
	public readonly int Priority;

	// Token: 0x0400CFB2 RID: 53170
	public float ShieldValue;

	// Token: 0x0400CFB3 RID: 53171
	public int HandleId;

	// Token: 0x0400CFB4 RID: 53172
	public readonly int Id;

	// Token: 0x0400CFB5 RID: 53173
	public readonly int TemplateId;

	// Token: 0x0400CFB6 RID: 53174
	public readonly float Value;
}
