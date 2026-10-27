using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090C RID: 2316
	public class ConfigSharePlatformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600365B RID: 13915 RVA: 0x0018C91F File Offset: 0x0018AB1F
		static ConfigSharePlatformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSharePlatformById.CreateStaticDefaultValue), new Action(ConfigSharePlatformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0018C940 File Offset: 0x0018AB40
		public static void CreateStaticDefaultValue()
		{
			ConfigSharePlatformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSharePlatformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "SharePlatform"),
				new ValueTuple<string, object>("语句", "select BinData from `SharePlatform` where Id=?")
			});
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0018C9BF File Offset: 0x0018ABBF
		public static void ResetStaticDefaultValue()
		{
			ConfigSharePlatformById.LogPair = null;
			ConfigSharePlatformById.HandleId = 0;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0018C9CD File Offset: 0x0018ABCD
		public static void Init()
		{
			ConfigSharePlatformById.HandleId = ConfigCommon.InitDataStatement(ConfigSharePlatformById.HandleId, "db_platformchannel.db", "select BinData from `SharePlatform` where Id=?");
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0018C9E8 File Offset: 0x0018ABE8
		public static SharePlatform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SharePlatform?(SharePlatform.GetRootAsSharePlatform(configBuffer));
				}
			}
			ConfigSharePlatformById.LogPair.Clear();
			ConfigSharePlatformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSharePlatformById.HandleId, 1, p0Id, ConfigSharePlatformById.LogPair) || ConfigCommon.Step(ConfigSharePlatformById.HandleId, true, ConfigSharePlatformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSharePlatformById.HandleId, 0, ConfigSharePlatformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SharePlatform rootAsSharePlatform = SharePlatform.GetRootAsSharePlatform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
			return new SharePlatform?(rootAsSharePlatform);
		}

		// Token: 0x04003F3A RID: 16186
		private const string DB = "db_platformchannel.db";

		// Token: 0x04003F3B RID: 16187
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04003F3C RID: 16188
		private const string TABLE = "SharePlatform";

		// Token: 0x04003F3D RID: 16189
		private const string COMMAND = "select BinData from `SharePlatform` where Id=?";

		// Token: 0x04003F3E RID: 16190
		private const string KEY_PREFIX = "SharePlatformById";

		// Token: 0x04003F3F RID: 16191
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F40 RID: 16192
		private static int HandleId;
	}
}
