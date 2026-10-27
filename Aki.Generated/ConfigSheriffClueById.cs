using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000913 RID: 2323
	public class ConfigSheriffClueById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x0018D863 File Offset: 0x0018BA63
		static ConfigSheriffClueById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffClueById.CreateStaticDefaultValue), new Action(ConfigSheriffClueById.ResetStaticDefaultValue));
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0018D884 File Offset: 0x0018BA84
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffClueById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffClueById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffClue"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffClue` where Id=?")
			});
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x0018D903 File Offset: 0x0018BB03
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffClueById.LogPair = null;
			ConfigSheriffClueById.HandleId = 0;
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0018D911 File Offset: 0x0018BB11
		public static void Init()
		{
			ConfigSheriffClueById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffClueById.HandleId, "db_sheriff.db", "select BinData from `SheriffClue` where Id=?");
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x0018D92C File Offset: 0x0018BB2C
		public static SheriffClue? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffClueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffClue?(SheriffClue.GetRootAsSheriffClue(configBuffer));
				}
			}
			ConfigSheriffClueById.LogPair.Clear();
			ConfigSheriffClueById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffClueById.HandleId, 1, p0Id, ConfigSheriffClueById.LogPair) || ConfigCommon.Step(ConfigSheriffClueById.HandleId, true, ConfigSheriffClueById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffClueById.HandleId, 0, ConfigSheriffClueById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffClue rootAsSheriffClue = SheriffClue.GetRootAsSheriffClue(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffClueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
			return new SheriffClue?(rootAsSheriffClue);
		}

		// Token: 0x04003F6B RID: 16235
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F6C RID: 16236
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F6D RID: 16237
		private const string TABLE = "SheriffClue";

		// Token: 0x04003F6E RID: 16238
		private const string COMMAND = "select BinData from `SheriffClue` where Id=?";

		// Token: 0x04003F6F RID: 16239
		private const string KEY_PREFIX = "SheriffClueById";

		// Token: 0x04003F70 RID: 16240
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F71 RID: 16241
		private static int HandleId;
	}
}
