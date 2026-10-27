using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DB RID: 2267
	public class ConfigRougeResMiraclecreationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003535 RID: 13621 RVA: 0x001861C4 File Offset: 0x001843C4
		static ConfigRougeResMiraclecreationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeResMiraclecreationById.CreateStaticDefaultValue), new Action(ConfigRougeResMiraclecreationById.ResetStaticDefaultValue));
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x001861E4 File Offset: 0x001843E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRougeResMiraclecreationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougeResMiraclecreationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougeResMiraclecreation"),
				new ValueTuple<string, object>("语句", "select BinData from `RougeResMiraclecreation` where Id=?")
			});
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00186263 File Offset: 0x00184463
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeResMiraclecreationById.LogPair = null;
			ConfigRougeResMiraclecreationById.HandleId = 0;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00186271 File Offset: 0x00184471
		public static void Init()
		{
			ConfigRougeResMiraclecreationById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeResMiraclecreationById.HandleId, "db_permanentrogue.db", "select BinData from `RougeResMiraclecreation` where Id=?");
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0018628C File Offset: 0x0018448C
		public static RougeResMiraclecreation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeResMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougeResMiraclecreation?(RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(configBuffer));
				}
			}
			ConfigRougeResMiraclecreationById.LogPair.Clear();
			ConfigRougeResMiraclecreationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougeResMiraclecreationById.HandleId, 1, p0Id, ConfigRougeResMiraclecreationById.LogPair) || ConfigCommon.Step(ConfigRougeResMiraclecreationById.HandleId, true, ConfigRougeResMiraclecreationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougeResMiraclecreationById.HandleId, 0, ConfigRougeResMiraclecreationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougeResMiraclecreation rootAsRougeResMiraclecreation = RougeResMiraclecreation.GetRootAsRougeResMiraclecreation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeResMiraclecreationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougeResMiraclecreationById.HandleId, ConfigRougeResMiraclecreationById.LogPair);
			return new RougeResMiraclecreation?(rootAsRougeResMiraclecreation);
		}

		// Token: 0x04003DE3 RID: 15843
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003DE4 RID: 15844
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003DE5 RID: 15845
		private const string TABLE = "RougeResMiraclecreation";

		// Token: 0x04003DE6 RID: 15846
		private const string COMMAND = "select BinData from `RougeResMiraclecreation` where Id=?";

		// Token: 0x04003DE7 RID: 15847
		private const string KEY_PREFIX = "RougeResMiraclecreationById";

		// Token: 0x04003DE8 RID: 15848
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DE9 RID: 15849
		private static int HandleId;
	}
}
