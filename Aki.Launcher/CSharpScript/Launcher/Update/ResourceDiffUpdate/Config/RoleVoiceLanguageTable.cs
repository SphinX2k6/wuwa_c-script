using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define.SimpleTabel;
using Google.FlatBuffers;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate.Config
{
	// Token: 0x020000C3 RID: 195
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleVoiceLanguageTable : TableReader<RoleVoiceLanguageTableRow>
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x00038C5E File Offset: 0x00036E5E
		protected override string GetTableName()
		{
			return "RoleVoiceLanguage";
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00038C65 File Offset: 0x00036E65
		protected override string GetDbFile()
		{
			return "db_menu.db";
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00038C6C File Offset: 0x00036E6C
		protected override string GetIdString()
		{
			return "LanguageId";
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00038C74 File Offset: 0x00036E74
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
