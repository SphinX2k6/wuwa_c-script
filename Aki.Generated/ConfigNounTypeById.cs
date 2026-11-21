using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000630 RID: 1584
	public class ConfigNounTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002530 RID: 9520 RVA: 0x0012F4CB File Offset: 0x0012D6CB
		static ConfigNounTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounTypeById.CreateStaticDefaultValue), new Action(ConfigNounTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0012F4EC File Offset: 0x0012D6EC
		public static void CreateStaticDefaultValue()
		{
			ConfigNounTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounType"),
				new ValueTuple<string, object>("语句", "select BinData from `NounType` where Id=?")
			});
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0012F56B File Offset: 0x0012D76B
		public static void ResetStaticDefaultValue()
		{
			ConfigNounTypeById.LogPair = null;
			ConfigNounTypeById.HandleId = 0;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0012F579 File Offset: 0x0012D779
		public static void Init()
		{
			ConfigNounTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigNounTypeById.HandleId, "db_handbook.db", "select BinData from `NounType` where Id=?");
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0012F594 File Offset: 0x0012D794
		public static NounType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NounType?(NounType.GetRootAsNounType(configBuffer));
				}
			}
			ConfigNounTypeById.LogPair.Clear();
			ConfigNounTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNounTypeById.HandleId, 1, p0Id, ConfigNounTypeById.LogPair) || ConfigCommon.Step(ConfigNounTypeById.HandleId, true, ConfigNounTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounTypeById.HandleId, 0, ConfigNounTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NounType rootAsNounType = NounType.GetRootAsNounType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
			return new NounType?(rootAsNounType);
		}

		// Token: 0x04002B36 RID: 11062
		private const string DB = "db_handbook.db";

		// Token: 0x04002B37 RID: 11063
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002B38 RID: 11064
		private const string TABLE = "NounType";

		// Token: 0x04002B39 RID: 11065
		private const string COMMAND = "select BinData from `NounType` where Id=?";

		// Token: 0x04002B3A RID: 11066
		private const string KEY_PREFIX = "NounTypeById";

		// Token: 0x04002B3B RID: 11067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B3C RID: 11068
		private static int HandleId;
	}
}
