using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000509 RID: 1289
	public class ConfigMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E41 RID: 7745 RVA: 0x0010428B File Offset: 0x0010248B
		static ConfigMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainTypeById.CreateStaticDefaultValue), new Action(ConfigMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x001042AC File Offset: 0x001024AC
		public static void CreateStaticDefaultValue()
		{
			ConfigMainTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MainType"),
				new ValueTuple<string, object>("语句", "select BinData from `MainType` where Id=?")
			});
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0010432B File Offset: 0x0010252B
		public static void ResetStaticDefaultValue()
		{
			ConfigMainTypeById.LogPair = null;
			ConfigMainTypeById.HandleId = 0;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00104339 File Offset: 0x00102539
		public static void Init()
		{
			ConfigMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMainTypeById.HandleId, "db_menu.db", "select BinData from `MainType` where Id=?");
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00104354 File Offset: 0x00102554
		public static MainType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MainType?(MainType.GetRootAsMainType(configBuffer));
				}
			}
			ConfigMainTypeById.LogPair.Clear();
			ConfigMainTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMainTypeById.HandleId, 1, p0Id, ConfigMainTypeById.LogPair) || ConfigCommon.Step(ConfigMainTypeById.HandleId, true, ConfigMainTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainTypeById.HandleId, 0, ConfigMainTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MainType rootAsMainType = MainType.GetRootAsMainType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
			return new MainType?(rootAsMainType);
		}

		// Token: 0x04002323 RID: 8995
		private const string DB = "db_menu.db";

		// Token: 0x04002324 RID: 8996
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002325 RID: 8997
		private const string TABLE = "MainType";

		// Token: 0x04002326 RID: 8998
		private const string COMMAND = "select BinData from `MainType` where Id=?";

		// Token: 0x04002327 RID: 8999
		private const string KEY_PREFIX = "MainTypeById";

		// Token: 0x04002328 RID: 9000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002329 RID: 9001
		private static int HandleId;
	}
}
