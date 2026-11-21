using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000537 RID: 1335
	public class ConfigMapNoteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x0010DDC8 File Offset: 0x0010BFC8
		static ConfigMapNoteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapNoteById.CreateStaticDefaultValue), new Action(ConfigMapNoteById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0010DDE8 File Offset: 0x0010BFE8
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

		// Token: 0x06001F57 RID: 8023 RVA: 0x0010DE67 File Offset: 0x0010C067
		public static void ResetStaticDefaultValue()
		{
			ConfigMapNoteById.LogPair = null;
			ConfigMapNoteById.HandleId = 0;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0010DE75 File Offset: 0x0010C075
		public static void Init()
		{
			ConfigMapNoteById.HandleId = ConfigCommon.InitDataStatement(ConfigMapNoteById.HandleId, "db_mapnote.db", "select BinData from `MapNote` where Id=?");
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0010DE90 File Offset: 0x0010C090
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

		// Token: 0x04002465 RID: 9317
		private const string DB = "db_mapnote.db";

		// Token: 0x04002466 RID: 9318
		private const string FILE = "d.地图便签.xlsx";

		// Token: 0x04002467 RID: 9319
		private const string TABLE = "MapNote";

		// Token: 0x04002468 RID: 9320
		private const string COMMAND = "select BinData from `MapNote` where Id=?";

		// Token: 0x04002469 RID: 9321
		private const string KEY_PREFIX = "MapNoteById";

		// Token: 0x0400246A RID: 9322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400246B RID: 9323
		private static int HandleId;
	}
}
