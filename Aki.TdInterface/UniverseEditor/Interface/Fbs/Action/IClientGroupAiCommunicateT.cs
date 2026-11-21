using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4B RID: 27211
	public class IClientGroupAiCommunicateT
	{
		// Token: 0x1700C7ED RID: 51181
		// (get) Token: 0x0602EAD4 RID: 191188 RVA: 0x0065CD3D File Offset: 0x0065AF3D
		// (set) Token: 0x0602EAD5 RID: 191189 RVA: 0x0065CD45 File Offset: 0x0065AF45
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C7EE RID: 51182
		// (get) Token: 0x0602EAD6 RID: 191190 RVA: 0x0065CD4E File Offset: 0x0065AF4E
		// (set) Token: 0x0602EAD7 RID: 191191 RVA: 0x0065CD56 File Offset: 0x0065AF56
		public int GroupEntityId { get; set; }

		// Token: 0x1700C7EF RID: 51183
		// (get) Token: 0x0602EAD8 RID: 191192 RVA: 0x0065CD5F File Offset: 0x0065AF5F
		// (set) Token: 0x0602EAD9 RID: 191193 RVA: 0x0065CD67 File Offset: 0x0065AF67
		public TGroupAiCommunicateOptionUnion Option { get; set; }

		// Token: 0x0602EADA RID: 191194 RVA: 0x0065CD70 File Offset: 0x0065AF70
		public IClientGroupAiCommunicateT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.GroupEntityId = 0;
			this.Option = null;
		}
	}
}
