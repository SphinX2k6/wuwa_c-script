using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000330 RID: 816
	public class ConfigFloroRanchFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001325 RID: 4901 RVA: 0x000C92DF File Offset: 0x000C74DF
		static ConfigFloroRanchFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchFilterTypeById.CreateStaticDefaultValue), new Action(ConfigFloroRanchFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000C9300 File Offset: 0x000C7500
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchFilterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchFilterType` where Id=?")
			});
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000C937F File Offset: 0x000C757F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeById.LogPair = null;
			ConfigFloroRanchFilterTypeById.HandleId = 0;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000C938D File Offset: 0x000C758D
		public static void Init()
		{
			ConfigFloroRanchFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchFilterTypeById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchFilterType` where Id=?");
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000C93A8 File Offset: 0x000C75A8
		public static FloroRanchFilterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchFilterType?(FloroRanchFilterType.GetRootAsFloroRanchFilterType(configBuffer));
				}
			}
			ConfigFloroRanchFilterTypeById.LogPair.Clear();
			ConfigFloroRanchFilterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchFilterTypeById.HandleId, 1, p0Id, ConfigFloroRanchFilterTypeById.LogPair) || ConfigCommon.Step(ConfigFloroRanchFilterTypeById.HandleId, true, ConfigFloroRanchFilterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchFilterTypeById.HandleId, 0, ConfigFloroRanchFilterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchFilterType rootAsFloroRanchFilterType = FloroRanchFilterType.GetRootAsFloroRanchFilterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchFilterTypeById.HandleId, ConfigFloroRanchFilterTypeById.LogPair);
			return new FloroRanchFilterType?(rootAsFloroRanchFilterType);
		}

		// Token: 0x04001634 RID: 5684
		private const string DB = "db_flororanch.db";

		// Token: 0x04001635 RID: 5685
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001636 RID: 5686
		private const string TABLE = "FloroRanchFilterType";

		// Token: 0x04001637 RID: 5687
		private const string COMMAND = "select BinData from `FloroRanchFilterType` where Id=?";

		// Token: 0x04001638 RID: 5688
		private const string KEY_PREFIX = "FloroRanchFilterTypeById";

		// Token: 0x04001639 RID: 5689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400163A RID: 5690
		private static int HandleId;
	}
}
