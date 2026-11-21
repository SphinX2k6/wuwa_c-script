using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C6 RID: 454
	public class ConfigCustomSequenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00099590 File Offset: 0x00097790
		static ConfigCustomSequenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomSequenceById.CreateStaticDefaultValue), new Action(ConfigCustomSequenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000995B0 File Offset: 0x000977B0
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

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0009962F File Offset: 0x0009782F
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomSequenceById.LogPair = null;
			ConfigCustomSequenceById.HandleId = 0;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0009963D File Offset: 0x0009783D
		public static void Init()
		{
			ConfigCustomSequenceById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomSequenceById.HandleId, "db_custom_sequence.db", "select BinData from `CustomSequence` where Id=?");
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00099658 File Offset: 0x00097858
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

		// Token: 0x04000C4E RID: 3150
		private const string DB = "db_custom_sequence.db";

		// Token: 0x04000C4F RID: 3151
		private const string FILE = "k.可视化编辑/c.Csv/z.自定义序列/*.csv*";

		// Token: 0x04000C50 RID: 3152
		private const string TABLE = "CustomSequence";

		// Token: 0x04000C51 RID: 3153
		private const string COMMAND = "select BinData from `CustomSequence` where Id=?";

		// Token: 0x04000C52 RID: 3154
		private const string KEY_PREFIX = "CustomSequenceById";

		// Token: 0x04000C53 RID: 3155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C54 RID: 3156
		private static int HandleId;
	}
}
