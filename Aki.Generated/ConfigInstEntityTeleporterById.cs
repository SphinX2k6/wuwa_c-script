using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000463 RID: 1123
	public class ConfigInstEntityTeleporterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x000F2053 File Offset: 0x000F0253
		static ConfigInstEntityTeleporterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstEntityTeleporterById.CreateStaticDefaultValue), new Action(ConfigInstEntityTeleporterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000F2074 File Offset: 0x000F0274
		public static void CreateStaticDefaultValue()
		{
			ConfigInstEntityTeleporterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstEntityTeleporterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teleporter.db"),
				new ValueTuple<string, object>("文件", "c.传送.xlsx"),
				new ValueTuple<string, object>("表名", "InstEntityTeleporter"),
				new ValueTuple<string, object>("语句", "select BinData from `InstEntityTeleporter` where Id = ?")
			});
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000F20F3 File Offset: 0x000F02F3
		public static void ResetStaticDefaultValue()
		{
			ConfigInstEntityTeleporterById.LogPair = null;
			ConfigInstEntityTeleporterById.HandleId = 0;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000F2101 File Offset: 0x000F0301
		public static void Init()
		{
			ConfigInstEntityTeleporterById.HandleId = ConfigCommon.InitDataStatement(ConfigInstEntityTeleporterById.HandleId, "db_teleporter.db", "select BinData from `InstEntityTeleporter` where Id = ?");
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000F211C File Offset: 0x000F031C
		public static InstEntityTeleporter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstEntityTeleporterById.HandleId, ConfigInstEntityTeleporterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstEntityTeleporterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstEntityTeleporter?(InstEntityTeleporter.GetRootAsInstEntityTeleporter(configBuffer));
				}
			}
			ConfigInstEntityTeleporterById.LogPair.Clear();
			ConfigInstEntityTeleporterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstEntityTeleporterById.HandleId, 1, p0Id, ConfigInstEntityTeleporterById.LogPair) || ConfigCommon.Step(ConfigInstEntityTeleporterById.HandleId, true, ConfigInstEntityTeleporterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstEntityTeleporterById.HandleId, ConfigInstEntityTeleporterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstEntityTeleporterById.HandleId, 0, ConfigInstEntityTeleporterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstEntityTeleporterById.HandleId, ConfigInstEntityTeleporterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstEntityTeleporter rootAsInstEntityTeleporter = InstEntityTeleporter.GetRootAsInstEntityTeleporter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstEntityTeleporterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstEntityTeleporterById.HandleId, ConfigInstEntityTeleporterById.LogPair);
			return new InstEntityTeleporter?(rootAsInstEntityTeleporter);
		}

		// Token: 0x04001E99 RID: 7833
		private const string DB = "db_teleporter.db";

		// Token: 0x04001E9A RID: 7834
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04001E9B RID: 7835
		private const string TABLE = "InstEntityTeleporter";

		// Token: 0x04001E9C RID: 7836
		private const string COMMAND = "select BinData from `InstEntityTeleporter` where Id = ?";

		// Token: 0x04001E9D RID: 7837
		private const string KEY_PREFIX = "InstEntityTeleporterById";

		// Token: 0x04001E9E RID: 7838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E9F RID: 7839
		private static int HandleId;
	}
}
