using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000723 RID: 1827
	public class ConfigPinballAvgStyleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AE2 RID: 10978 RVA: 0x0014F3F0 File Offset: 0x0014D5F0
		static ConfigPinballAvgStyleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballAvgStyleConfigById.CreateStaticDefaultValue), new Action(ConfigPinballAvgStyleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0014F410 File Offset: 0x0014D610
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballAvgStyleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballAvgStyleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballAvgStyleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballAvgStyleConfig` where Id=?")
			});
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0014F48F File Offset: 0x0014D68F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballAvgStyleConfigById.LogPair = null;
			ConfigPinballAvgStyleConfigById.HandleId = 0;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0014F49D File Offset: 0x0014D69D
		public static void Init()
		{
			ConfigPinballAvgStyleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballAvgStyleConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballAvgStyleConfig` where Id=?");
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0014F4B8 File Offset: 0x0014D6B8
		public static PinballAvgStyleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAvgStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballAvgStyleConfig?(PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(configBuffer));
				}
			}
			ConfigPinballAvgStyleConfigById.LogPair.Clear();
			ConfigPinballAvgStyleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballAvgStyleConfigById.HandleId, 1, p0Id, ConfigPinballAvgStyleConfigById.LogPair) || ConfigCommon.Step(ConfigPinballAvgStyleConfigById.HandleId, true, ConfigPinballAvgStyleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballAvgStyleConfigById.HandleId, 0, ConfigPinballAvgStyleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballAvgStyleConfig rootAsPinballAvgStyleConfig = PinballAvgStyleConfig.GetRootAsPinballAvgStyleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballAvgStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballAvgStyleConfigById.HandleId, ConfigPinballAvgStyleConfigById.LogPair);
			return new PinballAvgStyleConfig?(rootAsPinballAvgStyleConfig);
		}

		// Token: 0x040031DB RID: 12763
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031DC RID: 12764
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031DD RID: 12765
		private const string TABLE = "PinballAvgStyleConfig";

		// Token: 0x040031DE RID: 12766
		private const string COMMAND = "select BinData from `PinballAvgStyleConfig` where Id=?";

		// Token: 0x040031DF RID: 12767
		private const string KEY_PREFIX = "PinballAvgStyleConfigById";

		// Token: 0x040031E0 RID: 12768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031E1 RID: 12769
		private static int HandleId;
	}
}
