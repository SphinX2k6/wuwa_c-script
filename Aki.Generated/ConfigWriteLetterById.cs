using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9F RID: 2719
	public class ConfigWriteLetterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FCF RID: 16335 RVA: 0x001C327C File Offset: 0x001C147C
		static ConfigWriteLetterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWriteLetterById.CreateStaticDefaultValue), new Action(ConfigWriteLetterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x001C329C File Offset: 0x001C149C
		public static void CreateStaticDefaultValue()
		{
			ConfigWriteLetterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWriteLetterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_writeletter.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.秧秧写信玩法/*.csv*"),
				new ValueTuple<string, object>("表名", "WriteLetter"),
				new ValueTuple<string, object>("语句", "select BinData from `WriteLetter` where Id=?")
			});
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x001C331B File Offset: 0x001C151B
		public static void ResetStaticDefaultValue()
		{
			ConfigWriteLetterById.LogPair = null;
			ConfigWriteLetterById.HandleId = 0;
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x001C3329 File Offset: 0x001C1529
		public static void Init()
		{
			ConfigWriteLetterById.HandleId = ConfigCommon.InitDataStatement(ConfigWriteLetterById.HandleId, "db_writeletter.db", "select BinData from `WriteLetter` where Id=?");
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x001C3344 File Offset: 0x001C1544
		public static WriteLetter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWriteLetterById.HandleId, ConfigWriteLetterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WriteLetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WriteLetter?(WriteLetter.GetRootAsWriteLetter(configBuffer));
				}
			}
			ConfigWriteLetterById.LogPair.Clear();
			ConfigWriteLetterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWriteLetterById.HandleId, 1, p0Id, ConfigWriteLetterById.LogPair) || ConfigCommon.Step(ConfigWriteLetterById.HandleId, true, ConfigWriteLetterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWriteLetterById.HandleId, ConfigWriteLetterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWriteLetterById.HandleId, 0, ConfigWriteLetterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWriteLetterById.HandleId, ConfigWriteLetterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WriteLetter rootAsWriteLetter = WriteLetter.GetRootAsWriteLetter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WriteLetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWriteLetterById.HandleId, ConfigWriteLetterById.LogPair);
			return new WriteLetter?(rootAsWriteLetter);
		}

		// Token: 0x04004A3F RID: 19007
		private const string DB = "db_writeletter.db";

		// Token: 0x04004A40 RID: 19008
		private const string FILE = "k.可视化编辑/c.Csv/y.秧秧写信玩法/*.csv*";

		// Token: 0x04004A41 RID: 19009
		private const string TABLE = "WriteLetter";

		// Token: 0x04004A42 RID: 19010
		private const string COMMAND = "select BinData from `WriteLetter` where Id=?";

		// Token: 0x04004A43 RID: 19011
		private const string KEY_PREFIX = "WriteLetterById";

		// Token: 0x04004A44 RID: 19012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A45 RID: 19013
		private static int HandleId;
	}
}
