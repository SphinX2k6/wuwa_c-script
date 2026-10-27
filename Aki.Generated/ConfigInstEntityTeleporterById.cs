using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044D RID: 1101
	public class ConfigInstEntityTeleporterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019D8 RID: 6616 RVA: 0x000EB8FF File Offset: 0x000E9AFF
		static ConfigInstEntityTeleporterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstEntityTeleporterById.CreateStaticDefaultValue), new Action(ConfigInstEntityTeleporterById.ResetStaticDefaultValue));
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000EB920 File Offset: 0x000E9B20
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

		// Token: 0x060019DA RID: 6618 RVA: 0x000EB99F File Offset: 0x000E9B9F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstEntityTeleporterById.LogPair = null;
			ConfigInstEntityTeleporterById.HandleId = 0;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000EB9AD File Offset: 0x000E9BAD
		public static void Init()
		{
			ConfigInstEntityTeleporterById.HandleId = ConfigCommon.InitDataStatement(ConfigInstEntityTeleporterById.HandleId, "db_teleporter.db", "select BinData from `InstEntityTeleporter` where Id = ?");
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000EB9C8 File Offset: 0x000E9BC8
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

		// Token: 0x04001DFF RID: 7679
		private const string DB = "db_teleporter.db";

		// Token: 0x04001E00 RID: 7680
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04001E01 RID: 7681
		private const string TABLE = "InstEntityTeleporter";

		// Token: 0x04001E02 RID: 7682
		private const string COMMAND = "select BinData from `InstEntityTeleporter` where Id = ?";

		// Token: 0x04001E03 RID: 7683
		private const string KEY_PREFIX = "InstEntityTeleporterById";

		// Token: 0x04001E04 RID: 7684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E05 RID: 7685
		private static int HandleId;
	}
}
