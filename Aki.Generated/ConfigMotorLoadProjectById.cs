using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AF RID: 1455
	public class ConfigMotorLoadProjectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x0011AA6B File Offset: 0x00118C6B
		static ConfigMotorLoadProjectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLoadProjectById.CreateStaticDefaultValue), new Action(ConfigMotorLoadProjectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0011AA8C File Offset: 0x00118C8C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLoadProjectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLoadProjectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLoadProject"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLoadProject` where Id=?")
			});
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0011AB0B File Offset: 0x00118D0B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLoadProjectById.LogPair = null;
			ConfigMotorLoadProjectById.HandleId = 0;
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0011AB19 File Offset: 0x00118D19
		public static void Init()
		{
			ConfigMotorLoadProjectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLoadProjectById.HandleId, "db_motordiy.db", "select BinData from `MotorLoadProject` where Id=?");
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0011AB34 File Offset: 0x00118D34
		public static MotorLoadProject? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLoadProjectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLoadProject?(MotorLoadProject.GetRootAsMotorLoadProject(configBuffer));
				}
			}
			ConfigMotorLoadProjectById.LogPair.Clear();
			ConfigMotorLoadProjectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorLoadProjectById.HandleId, 1, p0Id, ConfigMotorLoadProjectById.LogPair) || ConfigCommon.Step(ConfigMotorLoadProjectById.HandleId, true, ConfigMotorLoadProjectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLoadProjectById.HandleId, 0, ConfigMotorLoadProjectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLoadProject rootAsMotorLoadProject = MotorLoadProject.GetRootAsMotorLoadProject(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLoadProjectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
			return new MotorLoadProject?(rootAsMotorLoadProject);
		}

		// Token: 0x040027AD RID: 10157
		private const string DB = "db_motordiy.db";

		// Token: 0x040027AE RID: 10158
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040027AF RID: 10159
		private const string TABLE = "MotorLoadProject";

		// Token: 0x040027B0 RID: 10160
		private const string COMMAND = "select BinData from `MotorLoadProject` where Id=?";

		// Token: 0x040027B1 RID: 10161
		private const string KEY_PREFIX = "MotorLoadProjectById";

		// Token: 0x040027B2 RID: 10162
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027B3 RID: 10163
		private static int HandleId;
	}
}
