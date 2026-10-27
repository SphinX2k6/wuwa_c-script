using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleVoiceLanguageTable : TableReader<RoleVoiceLanguageTableRow>
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0003715E File Offset: 0x0003535E
		protected override string GetTableName()
		{
			return "RoleVoiceLanguage";
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00037165 File Offset: 0x00035365
		protected override string GetDbFile()
		{
			return "db_menu.db";
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0003716C File Offset: 0x0003536C
		protected override string GetIdString()
		{
			return "LanguageId";
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00037174 File Offset: 0x00035374
		public override RoleVoiceLanguageTableRow Parse(ByteBuffer byteBuffer)
		{
			RoleVoiceLanguageTableRow roleVoiceLanguageTableRow = new RoleVoiceLanguageTableRow();
			int num = byteBuffer.GetInt(byteBuffer.Position) + byteBuffer.Position;
			Table table = new Table(num, byteBuffer);
			int num2 = table.__offset(4);
			roleVoiceLanguageTableRow.LanguageId = ((num2 != 0) ? byteBuffer.GetInt(num + num2) : 0);
			num2 = table.__offset(6);
			roleVoiceLanguageTableRow.Text = ((num2 != 0) ? (table.__string(num + num2) ?? "") : "");
			return roleVoiceLanguageTableRow;
		}
	}
}
