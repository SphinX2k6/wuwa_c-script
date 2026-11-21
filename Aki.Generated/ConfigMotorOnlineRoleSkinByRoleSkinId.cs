using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CB RID: 1483
	public class ConfigMotorOnlineRoleSkinByRoleSkinId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022CF RID: 8911 RVA: 0x00121E08 File Offset: 0x00120008
		static ConfigMotorOnlineRoleSkinByRoleSkinId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorOnlineRoleSkinByRoleSkinId.CreateStaticDefaultValue), new Action(ConfigMotorOnlineRoleSkinByRoleSkinId.ResetStaticDefaultValue));
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00121E28 File Offset: 0x00120028
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

		// Token: 0x060022D1 RID: 8913 RVA: 0x00121EA7 File Offset: 0x001200A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorOnlineRoleSkinByRoleSkinId.LogPair = null;
			ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId = 0;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00121EB5 File Offset: 0x001200B5
		public static void Init()
		{
			ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorOnlineRoleSkinByRoleSkinId.HandleId, "db.onlinemotor.db", "select BinData from `MotorOnlineRoleSkin` where RoleSkinId=?");
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00121ED0 File Offset: 0x001200D0
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

		// Token: 0x04002871 RID: 10353
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002872 RID: 10354
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002873 RID: 10355
		private const string TABLE = "MotorOnlineRoleSkin";

		// Token: 0x04002874 RID: 10356
		private const string COMMAND = "select BinData from `MotorOnlineRoleSkin` where RoleSkinId=?";

		// Token: 0x04002875 RID: 10357
		private const string KEY_PREFIX = "MotorOnlineRoleSkinByRoleSkinId";

		// Token: 0x04002876 RID: 10358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002877 RID: 10359
		private static int HandleId;
	}
}
