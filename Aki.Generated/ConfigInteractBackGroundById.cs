using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000465 RID: 1125
	public class ConfigInteractBackGroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x000F2495 File Offset: 0x000F0695
		static ConfigInteractBackGroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractBackGroundById.CreateStaticDefaultValue), new Action(ConfigInteractBackGroundById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x000F24B4 File Offset: 0x000F06B4
		public static void CreateStaticDefaultValue()
		{
			ConfigInteractBackGroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInteractBackGroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "InteractBackGround"),
				new ValueTuple<string, object>("语句", "select BinData from `InteractBackGround` where Id=?")
			});
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x000F2533 File Offset: 0x000F0733
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractBackGroundById.LogPair = null;
			ConfigInteractBackGroundById.HandleId = 0;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000F2541 File Offset: 0x000F0741
		public static void Init()
		{
			ConfigInteractBackGroundById.HandleId = ConfigCommon.InitDataStatement(ConfigInteractBackGroundById.HandleId, "db_commonbackground.db", "select BinData from `InteractBackGround` where Id=?");
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000F255C File Offset: 0x000F075C
		public static InteractBackGround? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InteractBackGroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InteractBackGround?(InteractBackGround.GetRootAsInteractBackGround(configBuffer));
				}
			}
			ConfigInteractBackGroundById.LogPair.Clear();
			ConfigInteractBackGroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInteractBackGroundById.HandleId, 1, p0Id, ConfigInteractBackGroundById.LogPair) || ConfigCommon.Step(ConfigInteractBackGroundById.HandleId, true, ConfigInteractBackGroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInteractBackGroundById.HandleId, 0, ConfigInteractBackGroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InteractBackGround rootAsInteractBackGround = InteractBackGround.GetRootAsInteractBackGround(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InteractBackGroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
			return new InteractBackGround?(rootAsInteractBackGround);
		}

		// Token: 0x04001EA7 RID: 7847
		private const string DB = "db_commonbackground.db";

		// Token: 0x04001EA8 RID: 7848
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04001EA9 RID: 7849
		private const string TABLE = "InteractBackGround";

		// Token: 0x04001EAA RID: 7850
		private const string COMMAND = "select BinData from `InteractBackGround` where Id=?";

		// Token: 0x04001EAB RID: 7851
		private const string KEY_PREFIX = "InteractBackGroundById";

		// Token: 0x04001EAC RID: 7852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EAD RID: 7853
		private static int HandleId;
	}
}
