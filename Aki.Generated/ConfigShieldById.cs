using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000923 RID: 2339
	public class ConfigShieldById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036E5 RID: 14053 RVA: 0x0018FB4C File Offset: 0x0018DD4C
		static ConfigShieldById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShieldById.CreateStaticDefaultValue), new Action(ConfigShieldById.ResetStaticDefaultValue));
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x0018FB6C File Offset: 0x0018DD6C
		public static void CreateStaticDefaultValue()
		{
			ConfigShieldById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShieldById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shield.db"),
				new ValueTuple<string, object>("文件", "h.护盾.xlsx"),
				new ValueTuple<string, object>("表名", "Shield"),
				new ValueTuple<string, object>("语句", "select BinData from `Shield` where Id = ?")
			});
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x0018FBEB File Offset: 0x0018DDEB
		public static void ResetStaticDefaultValue()
		{
			ConfigShieldById.LogPair = null;
			ConfigShieldById.HandleId = 0;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0018FBF9 File Offset: 0x0018DDF9
		public static void Init()
		{
			ConfigShieldById.HandleId = ConfigCommon.InitDataStatement(ConfigShieldById.HandleId, "db_shield.db", "select BinData from `Shield` where Id = ?");
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0018FC14 File Offset: 0x0018DE14
		public static Shield? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShieldById.HandleId, ConfigShieldById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShieldById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Shield?(Shield.GetRootAsShield(configBuffer));
				}
			}
			ConfigShieldById.LogPair.Clear();
			ConfigShieldById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShieldById.HandleId, 1, p0Id, ConfigShieldById.LogPair) || ConfigCommon.Step(ConfigShieldById.HandleId, true, ConfigShieldById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShieldById.HandleId, 0, ConfigShieldById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Shield rootAsShield = Shield.GetRootAsShield(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShieldById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
			return new Shield?(rootAsShield);
		}

		// Token: 0x04003FDB RID: 16347
		private const string DB = "db_shield.db";

		// Token: 0x04003FDC RID: 16348
		private const string FILE = "h.护盾.xlsx";

		// Token: 0x04003FDD RID: 16349
		private const string TABLE = "Shield";

		// Token: 0x04003FDE RID: 16350
		private const string COMMAND = "select BinData from `Shield` where Id = ?";

		// Token: 0x04003FDF RID: 16351
		private const string KEY_PREFIX = "ShieldById";

		// Token: 0x04003FE0 RID: 16352
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FE1 RID: 16353
		private static int HandleId;
	}
}
