using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B4 RID: 1460
	public class ConfigMotorOnlineRoleSkinByRoleSkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0011B520 File Offset: 0x00119720
		static ConfigMotorOnlineRoleSkinByRoleSkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorOnlineRoleSkinByRoleSkinId.CreateStaticDefaultValue), new Action(ConfigMotorOnlineRoleSkinByRoleSkinId.ResetStaticDefaultValue));
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0011B540 File Offset: 0x00119740
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorOnlineRoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorOnlineRoleSkin` where RoleSkinId=?")
			});
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0011B5BF File Offset: 0x001197BF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair = null;
			ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId = 0;
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0011B5CD File Offset: 0x001197CD
		public static void Init()
		{
			ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, "db.onlinemotor.db", "select BinData from `MotorOnlineRoleSkin` where RoleSkinId=?");
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0011B5E8 File Offset: 0x001197E8
		public static MotorOnlineRoleSkin? GetConfig(int p0RoleSkinId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorOnlineRoleSkinByRoleSkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleSkinId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorOnlineRoleSkin?(MotorOnlineRoleSkin.GetRootAsMotorOnlineRoleSkin(configBuffer));
				}
			}
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair.Clear();
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair.Add(new ValueTuple<string, object>("RoleSkinId", p0RoleSkinId));
			if (!ConfigCommon.BindInt(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, 1, p0RoleSkinId, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair) || ConfigCommon.Step(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, true, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, 0, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorOnlineRoleSkin rootAsMotorOnlineRoleSkin = MotorOnlineRoleSkin.GetRootAsMotorOnlineRoleSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorOnlineRoleSkinByRoleSkinId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleSkinId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair);
			return new MotorOnlineRoleSkin?(rootAsMotorOnlineRoleSkin);
		}

		// Token: 0x040027D0 RID: 10192
		private const string DB = "db.onlinemotor.db";

		// Token: 0x040027D1 RID: 10193
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x040027D2 RID: 10194
		private const string TABLE = "MotorOnlineRoleSkin";

		// Token: 0x040027D3 RID: 10195
		private const string COMMAND = "select BinData from `MotorOnlineRoleSkin` where RoleSkinId=?";

		// Token: 0x040027D4 RID: 10196
		private const string KEY_PREFIX = "MotorOnlineRoleSkinByRoleSkinId";

		// Token: 0x040027D5 RID: 10197
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027D6 RID: 10198
		private static int HandleId;
	}
}
