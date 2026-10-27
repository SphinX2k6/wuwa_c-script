using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000521 RID: 1313
	public class ConfigMapNoteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ED1 RID: 7889 RVA: 0x00107674 File Offset: 0x00105874
		static ConfigMapNoteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapNoteById.CreateStaticDefaultValue), new Action(ConfigMapNoteById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00107694 File Offset: 0x00105894
		public static void CreateStaticDefaultValue()
		{
			ConfigMapNoteById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapNoteById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapnote.db"),
				new ValueTuple<string, object>("文件", "d.地图便签.xlsx"),
				new ValueTuple<string, object>("表名", "MapNote"),
				new ValueTuple<string, object>("语句", "select BinData from `MapNote` where Id=?")
			});
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00107713 File Offset: 0x00105913
		public static void ResetStaticDefaultValue()
		{
			ConfigMapNoteById.LogPair = null;
			ConfigMapNoteById.HandleId = 0;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00107721 File Offset: 0x00105921
		public static void Init()
		{
			ConfigMapNoteById.HandleId = ConfigCommon.InitDataStatement(ConfigMapNoteById.HandleId, "db_mapnote.db", "select BinData from `MapNote` where Id=?");
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0010773C File Offset: 0x0010593C
		public static MapNote? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapNoteById.HandleId, ConfigMapNoteById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapNoteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapNote?(MapNote.GetRootAsMapNote(configBuffer));
				}
			}
			ConfigMapNoteById.LogPair.Clear();
			ConfigMapNoteById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapNoteById.HandleId, 1, p0Id, ConfigMapNoteById.LogPair) || ConfigCommon.Step(ConfigMapNoteById.HandleId, true, ConfigMapNoteById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapNoteById.HandleId, ConfigMapNoteById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapNoteById.HandleId, 0, ConfigMapNoteById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapNoteById.HandleId, ConfigMapNoteById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapNote rootAsMapNote = MapNote.GetRootAsMapNote(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapNoteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapNoteById.HandleId, ConfigMapNoteById.LogPair);
			return new MapNote?(rootAsMapNote);
		}

		// Token: 0x040023CB RID: 9163
		private const string DB = "db_mapnote.db";

		// Token: 0x040023CC RID: 9164
		private const string FILE = "d.地图便签.xlsx";

		// Token: 0x040023CD RID: 9165
		private const string TABLE = "MapNote";

		// Token: 0x040023CE RID: 9166
		private const string COMMAND = "select BinData from `MapNote` where Id=?";

		// Token: 0x040023CF RID: 9167
		private const string KEY_PREFIX = "MapNoteById";

		// Token: 0x040023D0 RID: 9168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023D1 RID: 9169
		private static int HandleId;
	}
}
