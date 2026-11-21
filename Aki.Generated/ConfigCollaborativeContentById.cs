using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000189 RID: 393
	public class ConfigCollaborativeContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x000911DF File Offset: 0x0008F3DF
		static ConfigCollaborativeContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCollaborativeContentById.CreateStaticDefaultValue), new Action(ConfigCollaborativeContentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00091200 File Offset: 0x0008F400
		public static void CreateStaticDefaultValue()
		{
			ConfigCollaborativeContentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCollaborativeContentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_collaborativecontent.db"),
				new ValueTuple<string, object>("文件", "l.联动内容.xlsx"),
				new ValueTuple<string, object>("表名", "CollaborativeContent"),
				new ValueTuple<string, object>("语句", "select BinData from `CollaborativeContent` where Id=?")
			});
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0009127F File Offset: 0x0008F47F
		public static void ResetStaticDefaultValue()
		{
			ConfigCollaborativeContentById.LogPair = null;
			ConfigCollaborativeContentById.HandleId = 0;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0009128D File Offset: 0x0008F48D
		public static void Init()
		{
			ConfigCollaborativeContentById.HandleId = ConfigCommon.InitDataStatement(ConfigCollaborativeContentById.HandleId, "db_collaborativecontent.db", "select BinData from `CollaborativeContent` where Id=?");
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000912A8 File Offset: 0x0008F4A8
		public static CollaborativeContent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCollaborativeContentById.HandleId, ConfigCollaborativeContentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CollaborativeContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CollaborativeContent?(CollaborativeContent.GetRootAsCollaborativeContent(configBuffer));
				}
			}
			ConfigCollaborativeContentById.LogPair.Clear();
			ConfigCollaborativeContentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCollaborativeContentById.HandleId, 1, p0Id, ConfigCollaborativeContentById.LogPair) || ConfigCommon.Step(ConfigCollaborativeContentById.HandleId, true, ConfigCollaborativeContentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCollaborativeContentById.HandleId, ConfigCollaborativeContentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCollaborativeContentById.HandleId, 0, ConfigCollaborativeContentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCollaborativeContentById.HandleId, ConfigCollaborativeContentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CollaborativeContent rootAsCollaborativeContent = CollaborativeContent.GetRootAsCollaborativeContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CollaborativeContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCollaborativeContentById.HandleId, ConfigCollaborativeContentById.LogPair);
			return new CollaborativeContent?(rootAsCollaborativeContent);
		}

		// Token: 0x04000AA3 RID: 2723
		private const string DB = "db_collaborativecontent.db";

		// Token: 0x04000AA4 RID: 2724
		private const string FILE = "l.联动内容.xlsx";

		// Token: 0x04000AA5 RID: 2725
		private const string TABLE = "CollaborativeContent";

		// Token: 0x04000AA6 RID: 2726
		private const string COMMAND = "select BinData from `CollaborativeContent` where Id=?";

		// Token: 0x04000AA7 RID: 2727
		private const string KEY_PREFIX = "CollaborativeContentById";

		// Token: 0x04000AA8 RID: 2728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AA9 RID: 2729
		private static int HandleId;
	}
}
