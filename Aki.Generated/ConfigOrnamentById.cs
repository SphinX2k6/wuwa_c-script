using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000631 RID: 1585
	public class ConfigOrnamentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x0012C093 File Offset: 0x0012A293
		static ConfigOrnamentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOrnamentById.CreateStaticDefaultValue), new Action(ConfigOrnamentById.ResetStaticDefaultValue));
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0012C0B4 File Offset: 0x0012A2B4
		public static void CreateStaticDefaultValue()
		{
			ConfigOrnamentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOrnamentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ornament.db"),
				new ValueTuple<string, object>("文件", "s.饰品.xlsx"),
				new ValueTuple<string, object>("表名", "Ornament"),
				new ValueTuple<string, object>("语句", "select BinData from `Ornament` where Id=?")
			});
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0012C133 File Offset: 0x0012A333
		public static void ResetStaticDefaultValue()
		{
			ConfigOrnamentById.LogPair = null;
			ConfigOrnamentById.HandleId = 0;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0012C141 File Offset: 0x0012A341
		public static void Init()
		{
			ConfigOrnamentById.HandleId = ConfigCommon.InitDataStatement(ConfigOrnamentById.HandleId, "db_ornament.db", "select BinData from `Ornament` where Id=?");
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0012C15C File Offset: 0x0012A35C
		public static Ornament? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Ornament?(Ornament.GetRootAsOrnament(configBuffer));
				}
			}
			ConfigOrnamentById.LogPair.Clear();
			ConfigOrnamentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOrnamentById.HandleId, 1, p0Id, ConfigOrnamentById.LogPair) || ConfigCommon.Step(ConfigOrnamentById.HandleId, true, ConfigOrnamentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOrnamentById.HandleId, 0, ConfigOrnamentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Ornament rootAsOrnament = Ornament.GetRootAsOrnament(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
			return new Ornament?(rootAsOrnament);
		}

		// Token: 0x04002B3D RID: 11069
		private const string DB = "db_ornament.db";

		// Token: 0x04002B3E RID: 11070
		private const string FILE = "s.饰品.xlsx";

		// Token: 0x04002B3F RID: 11071
		private const string TABLE = "Ornament";

		// Token: 0x04002B40 RID: 11072
		private const string COMMAND = "select BinData from `Ornament` where Id=?";

		// Token: 0x04002B41 RID: 11073
		private const string KEY_PREFIX = "OrnamentById";

		// Token: 0x04002B42 RID: 11074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B43 RID: 11075
		private static int HandleId;
	}
}
