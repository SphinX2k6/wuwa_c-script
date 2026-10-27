using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D2 RID: 978
	public class ConfigHeadIconEnergyBarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016F3 RID: 5875 RVA: 0x000DB367 File Offset: 0x000D9567
		static ConfigHeadIconEnergyBarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHeadIconEnergyBarById.CreateStaticDefaultValue), new Action(ConfigHeadIconEnergyBarById.ResetStaticDefaultValue));
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000DB388 File Offset: 0x000D9588
		public static void CreateStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHeadIconEnergyBarById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battleheadicon.db"),
				new ValueTuple<string, object>("文件", "j.角色战斗界面头像.xlsx"),
				new ValueTuple<string, object>("表名", "HeadIconEnergyBar"),
				new ValueTuple<string, object>("语句", "select BinData from `HeadIconEnergyBar` where Id=?")
			});
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000DB407 File Offset: 0x000D9607
		public static void ResetStaticDefaultValue()
		{
			ConfigHeadIconEnergyBarById.LogPair = null;
			ConfigHeadIconEnergyBarById.HandleId = 0;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x000DB415 File Offset: 0x000D9615
		public static void Init()
		{
			ConfigHeadIconEnergyBarById.HandleId = ConfigCommon.InitDataStatement(ConfigHeadIconEnergyBarById.HandleId, "db_battleheadicon.db", "select BinData from `HeadIconEnergyBar` where Id=?");
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000DB430 File Offset: 0x000D9630
		public static HeadIconEnergyBar? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHeadIconEnergyBarById.HandleId, ConfigHeadIconEnergyBarById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconEnergyBarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HeadIconEnergyBar?(HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(configBuffer));
				}
			}
			ConfigHeadIconEnergyBarById.LogPair.Clear();
			ConfigHeadIconEnergyBarById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHeadIconEnergyBarById.HandleId, 1, p0Id, ConfigHeadIconEnergyBarById.LogPair) || ConfigCommon.Step(ConfigHeadIconEnergyBarById.HandleId, true, ConfigHeadIconEnergyBarById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHeadIconEnergyBarById.HandleId, ConfigHeadIconEnergyBarById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHeadIconEnergyBarById.HandleId, 0, ConfigHeadIconEnergyBarById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHeadIconEnergyBarById.HandleId, ConfigHeadIconEnergyBarById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HeadIconEnergyBar rootAsHeadIconEnergyBar = HeadIconEnergyBar.GetRootAsHeadIconEnergyBar(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconEnergyBarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHeadIconEnergyBarById.HandleId, ConfigHeadIconEnergyBarById.LogPair);
			return new HeadIconEnergyBar?(rootAsHeadIconEnergyBar);
		}

		// Token: 0x04001AA2 RID: 6818
		private const string DB = "db_battleheadicon.db";

		// Token: 0x04001AA3 RID: 6819
		private const string FILE = "j.角色战斗界面头像.xlsx";

		// Token: 0x04001AA4 RID: 6820
		private const string TABLE = "HeadIconEnergyBar";

		// Token: 0x04001AA5 RID: 6821
		private const string COMMAND = "select BinData from `HeadIconEnergyBar` where Id=?";

		// Token: 0x04001AA6 RID: 6822
		private const string KEY_PREFIX = "HeadIconEnergyBarById";

		// Token: 0x04001AA7 RID: 6823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AA8 RID: 6824
		private static int HandleId;
	}
}
