using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C5 RID: 1221
	public class ConfigKurotatoWeaponGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CA9 RID: 7337 RVA: 0x000FB26F File Offset: 0x000F946F
		static ConfigKurotatoWeaponGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponGroupById.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000FB290 File Offset: 0x000F9490
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponGroup` where Id=?")
			});
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000FB30F File Offset: 0x000F950F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupById.LogPair = null;
			ConfigKurotatoWeaponGroupById.HandleId = 0;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000FB31D File Offset: 0x000F951D
		public static void Init()
		{
			ConfigKurotatoWeaponGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponGroupById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponGroup` where Id=?");
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x000FB338 File Offset: 0x000F9538
		public static KurotatoWeaponGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWeaponGroup?(KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(configBuffer));
				}
			}
			ConfigKurotatoWeaponGroupById.LogPair.Clear();
			ConfigKurotatoWeaponGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWeaponGroupById.HandleId, 1, p0Id, ConfigKurotatoWeaponGroupById.LogPair) || ConfigCommon.Step(ConfigKurotatoWeaponGroupById.HandleId, true, ConfigKurotatoWeaponGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponGroupById.HandleId, 0, ConfigKurotatoWeaponGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWeaponGroup rootAsKurotatoWeaponGroup = KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWeaponGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponGroupById.HandleId, ConfigKurotatoWeaponGroupById.LogPair);
			return new KurotatoWeaponGroup?(rootAsKurotatoWeaponGroup);
		}

		// Token: 0x04002147 RID: 8519
		private const string DB = "db_kurotato.db";

		// Token: 0x04002148 RID: 8520
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x04002149 RID: 8521
		private const string TABLE = "KurotatoWeaponGroup";

		// Token: 0x0400214A RID: 8522
		private const string COMMAND = "select BinData from `KurotatoWeaponGroup` where Id=?";

		// Token: 0x0400214B RID: 8523
		private const string KEY_PREFIX = "KurotatoWeaponGroupById";

		// Token: 0x0400214C RID: 8524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400214D RID: 8525
		private static int HandleId;
	}
}
