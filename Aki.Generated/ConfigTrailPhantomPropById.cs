using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A14 RID: 2580
	public class ConfigTrailPhantomPropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C8C RID: 15500 RVA: 0x001B01B3 File Offset: 0x001AE3B3
		static ConfigTrailPhantomPropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrailPhantomPropById.CreateStaticDefaultValue), new Action(ConfigTrailPhantomPropById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x001B01D4 File Offset: 0x001AE3D4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrailPhantomPropById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrailPhantomPropById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrailPhantomProp"),
				new ValueTuple<string, object>("语句", "select BinData from `TrailPhantomProp` where Id = ?")
			});
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x001B0253 File Offset: 0x001AE453
		public static void ResetStaticDefaultValue()
		{
			ConfigTrailPhantomPropById.LogPair = null;
			ConfigTrailPhantomPropById.HandleId = 0;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001B0261 File Offset: 0x001AE461
		public static void Init()
		{
			ConfigTrailPhantomPropById.HandleId = ConfigCommon.InitDataStatement(ConfigTrailPhantomPropById.HandleId, "db_trial_role.db", "select BinData from `TrailPhantomProp` where Id = ?");
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x001B027C File Offset: 0x001AE47C
		public static TrailPhantomProp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrailPhantomPropById.HandleId, ConfigTrailPhantomPropById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrailPhantomPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrailPhantomProp?(TrailPhantomProp.GetRootAsTrailPhantomProp(configBuffer));
				}
			}
			ConfigTrailPhantomPropById.LogPair.Clear();
			ConfigTrailPhantomPropById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrailPhantomPropById.HandleId, 1, p0Id, ConfigTrailPhantomPropById.LogPair) || ConfigCommon.Step(ConfigTrailPhantomPropById.HandleId, true, ConfigTrailPhantomPropById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrailPhantomPropById.HandleId, ConfigTrailPhantomPropById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrailPhantomPropById.HandleId, 0, ConfigTrailPhantomPropById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrailPhantomPropById.HandleId, ConfigTrailPhantomPropById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrailPhantomProp rootAsTrailPhantomProp = TrailPhantomProp.GetRootAsTrailPhantomProp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrailPhantomPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrailPhantomPropById.HandleId, ConfigTrailPhantomPropById.LogPair);
			return new TrailPhantomProp?(rootAsTrailPhantomProp);
		}

		// Token: 0x04004672 RID: 18034
		private const string DB = "db_trial_role.db";

		// Token: 0x04004673 RID: 18035
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004674 RID: 18036
		private const string TABLE = "TrailPhantomProp";

		// Token: 0x04004675 RID: 18037
		private const string COMMAND = "select BinData from `TrailPhantomProp` where Id = ?";

		// Token: 0x04004676 RID: 18038
		private const string KEY_PREFIX = "TrailPhantomPropById";

		// Token: 0x04004677 RID: 18039
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004678 RID: 18040
		private static int HandleId;
	}
}
