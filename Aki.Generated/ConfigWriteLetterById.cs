using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B74 RID: 2932
	public class ConfigWriteLetterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044CD RID: 17613 RVA: 0x001E2610 File Offset: 0x001E0810
		static ConfigWriteLetterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWriteLetterById.CreateStaticDefaultValue), new Action(ConfigWriteLetterById.ResetStaticDefaultValue));
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001E2630 File Offset: 0x001E0830
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

		// Token: 0x060044CF RID: 17615 RVA: 0x001E26AF File Offset: 0x001E08AF
		public static void ResetStaticDefaultValue()
		{
			ConfigWriteLetterById.LogPair = null;
			ConfigWriteLetterById.HandleId = 0;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x001E26BD File Offset: 0x001E08BD
		public static void Init()
		{
			ConfigWriteLetterById.HandleId = ConfigCommon.InitDataStatement(ConfigWriteLetterById.HandleId, "db_writeletter.db", "select BinData from `WriteLetter` where Id=?");
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001E26D8 File Offset: 0x001E08D8
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

		// Token: 0x04005012 RID: 20498
		private const string DB = "db_writeletter.db";

		// Token: 0x04005013 RID: 20499
		private const string FILE = "k.可视化编辑/c.Csv/y.秧秧写信玩法/*.csv*";

		// Token: 0x04005014 RID: 20500
		private const string TABLE = "WriteLetter";

		// Token: 0x04005015 RID: 20501
		private const string COMMAND = "select BinData from `WriteLetter` where Id=?";

		// Token: 0x04005016 RID: 20502
		private const string KEY_PREFIX = "WriteLetterById";

		// Token: 0x04005017 RID: 20503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005018 RID: 20504
		private static int HandleId;
	}
}
