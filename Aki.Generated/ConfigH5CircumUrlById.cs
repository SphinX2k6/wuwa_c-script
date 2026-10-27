using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C9 RID: 969
	public class ConfigH5CircumUrlById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x000DA0FC File Offset: 0x000D82FC
		static ConfigH5CircumUrlById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigH5CircumUrlById.CreateStaticDefaultValue), new Action(ConfigH5CircumUrlById.ResetStaticDefaultValue));
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000DA11C File Offset: 0x000D831C
		public static void CreateStaticDefaultValue()
		{
			ConfigH5CircumUrlById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigH5CircumUrlById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_h5circum.db"),
				new ValueTuple<string, object>("文件", "h.H5拉人活动.xlsx"),
				new ValueTuple<string, object>("表名", "H5CircumUrl"),
				new ValueTuple<string, object>("语句", "select BinData from `H5CircumUrl` where Id=?")
			});
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000DA19B File Offset: 0x000D839B
		public static void ResetStaticDefaultValue()
		{
			ConfigH5CircumUrlById.LogPair = null;
			ConfigH5CircumUrlById.HandleId = 0;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000DA1A9 File Offset: 0x000D83A9
		public static void Init()
		{
			ConfigH5CircumUrlById.HandleId = ConfigCommon.InitDataStatement(ConfigH5CircumUrlById.HandleId, "db_h5circum.db", "select BinData from `H5CircumUrl` where Id=?");
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000DA1C4 File Offset: 0x000D83C4
		public static H5CircumUrl? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigH5CircumUrlById.HandleId, ConfigH5CircumUrlById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5CircumUrlById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new H5CircumUrl?(H5CircumUrl.GetRootAsH5CircumUrl(configBuffer));
				}
			}
			ConfigH5CircumUrlById.LogPair.Clear();
			ConfigH5CircumUrlById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigH5CircumUrlById.HandleId, 1, p0Id, ConfigH5CircumUrlById.LogPair) || ConfigCommon.Step(ConfigH5CircumUrlById.HandleId, true, ConfigH5CircumUrlById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigH5CircumUrlById.HandleId, ConfigH5CircumUrlById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigH5CircumUrlById.HandleId, 0, ConfigH5CircumUrlById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigH5CircumUrlById.HandleId, ConfigH5CircumUrlById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			H5CircumUrl rootAsH5CircumUrl = H5CircumUrl.GetRootAsH5CircumUrl(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5CircumUrlById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigH5CircumUrlById.HandleId, ConfigH5CircumUrlById.LogPair);
			return new H5CircumUrl?(rootAsH5CircumUrl);
		}

		// Token: 0x04001A63 RID: 6755
		private const string DB = "db_h5circum.db";

		// Token: 0x04001A64 RID: 6756
		private const string FILE = "h.H5拉人活动.xlsx";

		// Token: 0x04001A65 RID: 6757
		private const string TABLE = "H5CircumUrl";

		// Token: 0x04001A66 RID: 6758
		private const string COMMAND = "select BinData from `H5CircumUrl` where Id=?";

		// Token: 0x04001A67 RID: 6759
		private const string KEY_PREFIX = "H5CircumUrlById";

		// Token: 0x04001A68 RID: 6760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A69 RID: 6761
		private static int HandleId;
	}
}
