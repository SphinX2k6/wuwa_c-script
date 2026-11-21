using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BF RID: 959
	public class ConfigGolemCrackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x000DC3FC File Offset: 0x000DA5FC
		static ConfigGolemCrackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGolemCrackById.CreateStaticDefaultValue), new Action(ConfigGolemCrackById.ResetStaticDefaultValue));
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000DC41C File Offset: 0x000DA61C
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

		// Token: 0x06001683 RID: 5763 RVA: 0x000DC49B File Offset: 0x000DA69B
		public static void ResetStaticDefaultValue()
		{
			ConfigGolemCrackById.LogPair = null;
			ConfigGolemCrackById.HandleId = 0;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000DC4A9 File Offset: 0x000DA6A9
		public static void Init()
		{
			ConfigGolemCrackById.HandleId = ConfigCommon.InitDataStatement(ConfigGolemCrackById.HandleId, "db_golemcrack.db", "select BinData from `GolemCrack` where Id=?");
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000DC4C4 File Offset: 0x000DA6C4
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

		// Token: 0x04001A1D RID: 6685
		private const string DB = "db_golemcrack.db";

		// Token: 0x04001A1E RID: 6686
		private const string FILE = "m.魔偶骇入.xlsx";

		// Token: 0x04001A1F RID: 6687
		private const string TABLE = "GolemCrack";

		// Token: 0x04001A20 RID: 6688
		private const string COMMAND = "select BinData from `GolemCrack` where Id=?";

		// Token: 0x04001A21 RID: 6689
		private const string KEY_PREFIX = "GolemCrackById";

		// Token: 0x04001A22 RID: 6690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A23 RID: 6691
		private static int HandleId;
	}
}
