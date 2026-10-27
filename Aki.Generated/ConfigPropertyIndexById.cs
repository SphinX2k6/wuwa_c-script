using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000765 RID: 1893
	public class ConfigPropertyIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x00154667 File Offset: 0x00152867
		static ConfigPropertyIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPropertyIndexById.CreateStaticDefaultValue), new Action(ConfigPropertyIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00154688 File Offset: 0x00152888
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

		// Token: 0x06002C71 RID: 11377 RVA: 0x00154707 File Offset: 0x00152907
		public static void ResetStaticDefaultValue()
		{
			ConfigPropertyIndexById.LogPair = null;
			ConfigPropertyIndexById.HandleId = 0;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00154715 File Offset: 0x00152915
		public static void Init()
		{
			ConfigPropertyIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigPropertyIndexById.HandleId, "db_property.db", "select BinData from `PropertyIndex` where Id=?");
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00154730 File Offset: 0x00152930
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

		// Token: 0x040033A9 RID: 13225
		private const string DB = "db_property.db";

		// Token: 0x040033AA RID: 13226
		private const string FILE = "s.属性.xlsx";

		// Token: 0x040033AB RID: 13227
		private const string TABLE = "PropertyIndex";

		// Token: 0x040033AC RID: 13228
		private const string COMMAND = "select BinData from `PropertyIndex` where Id=?";

		// Token: 0x040033AD RID: 13229
		private const string KEY_PREFIX = "PropertyIndexById";

		// Token: 0x040033AE RID: 13230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033AF RID: 13231
		private static int HandleId;
	}
}
