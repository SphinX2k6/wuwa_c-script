using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B4 RID: 436
	public class ConfigCustomSequenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A3B RID: 2619 RVA: 0x00093658 File Offset: 0x00091858
		static ConfigCustomSequenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomSequenceById.CreateStaticDefaultValue), new Action(ConfigCustomSequenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00093678 File Offset: 0x00091878
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomSequenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomSequenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_custom_sequence.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/z.自定义序列/*.csv*"),
				new ValueTuple<string, object>("表名", "CustomSequence"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomSequence` where Id=?")
			});
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000936F7 File Offset: 0x000918F7
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomSequenceById.LogPair = null;
			ConfigCustomSequenceById.HandleId = 0;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00093705 File Offset: 0x00091905
		public static void Init()
		{
			ConfigCustomSequenceById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomSequenceById.HandleId, "db_custom_sequence.db", "select BinData from `CustomSequence` where Id=?");
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00093720 File Offset: 0x00091920
		public static CustomSequence? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomSequenceById.HandleId, ConfigCustomSequenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomSequenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CustomSequence?(CustomSequence.GetRootAsCustomSequence(configBuffer));
				}
			}
			ConfigCustomSequenceById.LogPair.Clear();
			ConfigCustomSequenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCustomSequenceById.HandleId, 1, p0Id, ConfigCustomSequenceById.LogPair) || ConfigCommon.Step(ConfigCustomSequenceById.HandleId, true, ConfigCustomSequenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCustomSequenceById.HandleId, ConfigCustomSequenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomSequenceById.HandleId, 0, ConfigCustomSequenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCustomSequenceById.HandleId, ConfigCustomSequenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CustomSequence rootAsCustomSequence = CustomSequence.GetRootAsCustomSequence(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomSequenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCustomSequenceById.HandleId, ConfigCustomSequenceById.LogPair);
			return new CustomSequence?(rootAsCustomSequence);
		}

		// Token: 0x04000BD0 RID: 3024
		private const string DB = "db_custom_sequence.db";

		// Token: 0x04000BD1 RID: 3025
		private const string FILE = "k.可视化编辑/c.Csv/z.自定义序列/*.csv*";

		// Token: 0x04000BD2 RID: 3026
		private const string TABLE = "CustomSequence";

		// Token: 0x04000BD3 RID: 3027
		private const string COMMAND = "select BinData from `CustomSequence` where Id=?";

		// Token: 0x04000BD4 RID: 3028
		private const string KEY_PREFIX = "CustomSequenceById";

		// Token: 0x04000BD5 RID: 3029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BD6 RID: 3030
		private static int HandleId;
	}
}
