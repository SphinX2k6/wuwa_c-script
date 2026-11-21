using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000922 RID: 2338
	public class ConfigRougeMiraclecreationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036DF RID: 14047 RVA: 0x00192B78 File Offset: 0x00190D78
		static ConfigRougeMiraclecreationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeMiraclecreationById.CreateStaticDefaultValue), new Action(ConfigRougeMiraclecreationById.ResetStaticDefaultValue));
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00192B98 File Offset: 0x00190D98
		public static void CreateStaticDefaultValue()
		{
			ConfigRougeMiraclecreationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougeMiraclecreationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougeMiraclecreation"),
				new ValueTuple<string, object>("语句", "select BinData from `RougeMiraclecreation` where Id=?")
			});
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00192C17 File Offset: 0x00190E17
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeMiraclecreationById.LogPair = null;
			ConfigRougeMiraclecreationById.HandleId = 0;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00192C25 File Offset: 0x00190E25
		public static void Init()
		{
			ConfigRougeMiraclecreationById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeMiraclecreationById.HandleId, "db_rogue.db", "select BinData from `RougeMiraclecreation` where Id=?");
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00192C40 File Offset: 0x00190E40
		public static RougeMiraclecreation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougeMiraclecreation?(RougeMiraclecreation.GetRootAsRougeMiraclecreation(configBuffer));
				}
			}
			ConfigRougeMiraclecreationById.LogPair.Clear();
			ConfigRougeMiraclecreationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougeMiraclecreationById.HandleId, 1, p0Id, ConfigRougeMiraclecreationById.LogPair) || ConfigCommon.Step(ConfigRougeMiraclecreationById.HandleId, true, ConfigRougeMiraclecreationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougeMiraclecreationById.HandleId, 0, ConfigRougeMiraclecreationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougeMiraclecreation rootAsRougeMiraclecreation = RougeMiraclecreation.GetRootAsRougeMiraclecreation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougeMiraclecreationById.HandleId, ConfigRougeMiraclecreationById.LogPair);
			return new RougeMiraclecreation?(rootAsRougeMiraclecreation);
		}

		// Token: 0x04003FD4 RID: 16340
		private const string DB = "db_rogue.db";

		// Token: 0x04003FD5 RID: 16341
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003FD6 RID: 16342
		private const string TABLE = "RougeMiraclecreation";

		// Token: 0x04003FD7 RID: 16343
		private const string COMMAND = "select BinData from `RougeMiraclecreation` where Id=?";

		// Token: 0x04003FD8 RID: 16344
		private const string KEY_PREFIX = "RougeMiraclecreationById";

		// Token: 0x04003FD9 RID: 16345
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FDA RID: 16346
		private static int HandleId;
	}
}
