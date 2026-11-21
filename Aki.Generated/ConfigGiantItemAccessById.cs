using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AA RID: 938
	public class ConfigGiantItemAccessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001602 RID: 5634 RVA: 0x000D989B File Offset: 0x000D7A9B
		static ConfigGiantItemAccessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemAccessById.CreateStaticDefaultValue), new Action(ConfigGiantItemAccessById.ResetStaticDefaultValue));
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000D98BC File Offset: 0x000D7ABC
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantItemAccessById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantItemAccessById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantItemAccess"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantItemAccess` where Id=?")
			});
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000D993B File Offset: 0x000D7B3B
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemAccessById.LogPair = null;
			ConfigGiantItemAccessById.HandleId = 0;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000D9949 File Offset: 0x000D7B49
		public static void Init()
		{
			ConfigGiantItemAccessById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemAccessById.HandleId, "db_giant.db", "select BinData from `GiantItemAccess` where Id=?");
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000D9964 File Offset: 0x000D7B64
		public static GiantItemAccess? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemAccessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantItemAccess?(GiantItemAccess.GetRootAsGiantItemAccess(configBuffer));
				}
			}
			ConfigGiantItemAccessById.LogPair.Clear();
			ConfigGiantItemAccessById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantItemAccessById.HandleId, 1, p0Id, ConfigGiantItemAccessById.LogPair) || ConfigCommon.Step(ConfigGiantItemAccessById.HandleId, true, ConfigGiantItemAccessById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantItemAccessById.HandleId, 0, ConfigGiantItemAccessById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantItemAccess rootAsGiantItemAccess = GiantItemAccess.GetRootAsGiantItemAccess(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemAccessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
			return new GiantItemAccess?(rootAsGiantItemAccess);
		}

		// Token: 0x0400198A RID: 6538
		private const string DB = "db_giant.db";

		// Token: 0x0400198B RID: 6539
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x0400198C RID: 6540
		private const string TABLE = "GiantItemAccess";

		// Token: 0x0400198D RID: 6541
		private const string COMMAND = "select BinData from `GiantItemAccess` where Id=?";

		// Token: 0x0400198E RID: 6542
		private const string KEY_PREFIX = "GiantItemAccessById";

		// Token: 0x0400198F RID: 6543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001990 RID: 6544
		private static int HandleId;
	}
}
