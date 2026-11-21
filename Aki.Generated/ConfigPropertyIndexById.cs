using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077F RID: 1919
	public class ConfigPropertyIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x0015B573 File Offset: 0x00159773
		static ConfigPropertyIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropertyIndexById.CreateStaticDefaultValue), new Action(ConfigPropertyIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0015B594 File Offset: 0x00159794
		public static void CreateStaticDefaultValue()
		{
			ConfigPropertyIndexById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPropertyIndexById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "PropertyIndex"),
				new ValueTuple<string, object>("语句", "select BinData from `PropertyIndex` where Id=?")
			});
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x0015B613 File Offset: 0x00159813
		public static void ResetStaticDefaultValue()
		{
			ConfigPropertyIndexById.LogPair = null;
			ConfigPropertyIndexById.HandleId = 0;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0015B621 File Offset: 0x00159821
		public static void Init()
		{
			ConfigPropertyIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigPropertyIndexById.HandleId, "db_property.db", "select BinData from `PropertyIndex` where Id=?");
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0015B63C File Offset: 0x0015983C
		public static PropertyIndex? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPropertyIndexById.HandleId, ConfigPropertyIndexById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PropertyIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PropertyIndex?(PropertyIndex.GetRootAsPropertyIndex(configBuffer));
				}
			}
			ConfigPropertyIndexById.LogPair.Clear();
			ConfigPropertyIndexById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPropertyIndexById.HandleId, 1, p0Id, ConfigPropertyIndexById.LogPair) || ConfigCommon.Step(ConfigPropertyIndexById.HandleId, true, ConfigPropertyIndexById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPropertyIndexById.HandleId, ConfigPropertyIndexById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPropertyIndexById.HandleId, 0, ConfigPropertyIndexById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPropertyIndexById.HandleId, ConfigPropertyIndexById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PropertyIndex rootAsPropertyIndex = PropertyIndex.GetRootAsPropertyIndex(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PropertyIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPropertyIndexById.HandleId, ConfigPropertyIndexById.LogPair);
			return new PropertyIndex?(rootAsPropertyIndex);
		}

		// Token: 0x0400345F RID: 13407
		private const string DB = "db_property.db";

		// Token: 0x04003460 RID: 13408
		private const string FILE = "s.属性.xlsx";

		// Token: 0x04003461 RID: 13409
		private const string TABLE = "PropertyIndex";

		// Token: 0x04003462 RID: 13410
		private const string COMMAND = "select BinData from `PropertyIndex` where Id=?";

		// Token: 0x04003463 RID: 13411
		private const string KEY_PREFIX = "PropertyIndexById";

		// Token: 0x04003464 RID: 13412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003465 RID: 13413
		private static int HandleId;
	}
}
