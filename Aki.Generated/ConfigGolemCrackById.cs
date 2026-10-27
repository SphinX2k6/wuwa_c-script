using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A9 RID: 937
	public class ConfigGolemCrackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015FD RID: 5629 RVA: 0x000D5CA8 File Offset: 0x000D3EA8
		static ConfigGolemCrackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGolemCrackById.CreateStaticDefaultValue), new Action(ConfigGolemCrackById.ResetStaticDefaultValue));
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000D5CC8 File Offset: 0x000D3EC8
		public static void CreateStaticDefaultValue()
		{
			ConfigGolemCrackById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGolemCrackById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_golemcrack.db"),
				new ValueTuple<string, object>("文件", "m.魔偶骇入.xlsx"),
				new ValueTuple<string, object>("表名", "GolemCrack"),
				new ValueTuple<string, object>("语句", "select BinData from `GolemCrack` where Id=?")
			});
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000D5D47 File Offset: 0x000D3F47
		public static void ResetStaticDefaultValue()
		{
			ConfigGolemCrackById.LogPair = null;
			ConfigGolemCrackById.HandleId = 0;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000D5D55 File Offset: 0x000D3F55
		public static void Init()
		{
			ConfigGolemCrackById.HandleId = ConfigCommon.InitDataStatement(ConfigGolemCrackById.HandleId, "db_golemcrack.db", "select BinData from `GolemCrack` where Id=?");
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000D5D70 File Offset: 0x000D3F70
		public static GolemCrack? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGolemCrackById.HandleId, ConfigGolemCrackById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GolemCrackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GolemCrack?(GolemCrack.GetRootAsGolemCrack(configBuffer));
				}
			}
			ConfigGolemCrackById.LogPair.Clear();
			ConfigGolemCrackById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGolemCrackById.HandleId, 1, p0Id, ConfigGolemCrackById.LogPair) || ConfigCommon.Step(ConfigGolemCrackById.HandleId, true, ConfigGolemCrackById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGolemCrackById.HandleId, ConfigGolemCrackById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGolemCrackById.HandleId, 0, ConfigGolemCrackById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGolemCrackById.HandleId, ConfigGolemCrackById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GolemCrack rootAsGolemCrack = GolemCrack.GetRootAsGolemCrack(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GolemCrackById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGolemCrackById.HandleId, ConfigGolemCrackById.LogPair);
			return new GolemCrack?(rootAsGolemCrack);
		}

		// Token: 0x04001983 RID: 6531
		private const string DB = "db_golemcrack.db";

		// Token: 0x04001984 RID: 6532
		private const string FILE = "m.魔偶骇入.xlsx";

		// Token: 0x04001985 RID: 6533
		private const string TABLE = "GolemCrack";

		// Token: 0x04001986 RID: 6534
		private const string COMMAND = "select BinData from `GolemCrack` where Id=?";

		// Token: 0x04001987 RID: 6535
		private const string KEY_PREFIX = "GolemCrackById";

		// Token: 0x04001988 RID: 6536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001989 RID: 6537
		private static int HandleId;
	}
}
