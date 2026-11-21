using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E0 RID: 992
	public class ConfigH5JumpActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x000E0A98 File Offset: 0x000DEC98
		static ConfigH5JumpActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigH5JumpActivityById.CreateStaticDefaultValue), new Action(ConfigH5JumpActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000E0AB8 File Offset: 0x000DECB8
		public static void CreateStaticDefaultValue()
		{
			ConfigH5JumpActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigH5JumpActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_h5activity.db"),
				new ValueTuple<string, object>("文件", "h.h5活动.xlsx"),
				new ValueTuple<string, object>("表名", "H5JumpActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `H5JumpActivity` where Id=?")
			});
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000E0B37 File Offset: 0x000DED37
		public static void ResetStaticDefaultValue()
		{
			ConfigH5JumpActivityById.LogPair = null;
			ConfigH5JumpActivityById.HandleId = 0;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000E0B45 File Offset: 0x000DED45
		public static void Init()
		{
			ConfigH5JumpActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigH5JumpActivityById.HandleId, "db_h5activity.db", "select BinData from `H5JumpActivity` where Id=?");
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000E0B60 File Offset: 0x000DED60
		public static H5JumpActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5JumpActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new H5JumpActivity?(H5JumpActivity.GetRootAsH5JumpActivity(configBuffer));
				}
			}
			ConfigH5JumpActivityById.LogPair.Clear();
			ConfigH5JumpActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigH5JumpActivityById.HandleId, 1, p0Id, ConfigH5JumpActivityById.LogPair) || ConfigCommon.Step(ConfigH5JumpActivityById.HandleId, true, ConfigH5JumpActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigH5JumpActivityById.HandleId, 0, ConfigH5JumpActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			H5JumpActivity rootAsH5JumpActivity = H5JumpActivity.GetRootAsH5JumpActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5JumpActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
			return new H5JumpActivity?(rootAsH5JumpActivity);
		}

		// Token: 0x04001B04 RID: 6916
		private const string DB = "db_h5activity.db";

		// Token: 0x04001B05 RID: 6917
		private const string FILE = "h.h5活动.xlsx";

		// Token: 0x04001B06 RID: 6918
		private const string TABLE = "H5JumpActivity";

		// Token: 0x04001B07 RID: 6919
		private const string COMMAND = "select BinData from `H5JumpActivity` where Id=?";

		// Token: 0x04001B08 RID: 6920
		private const string KEY_PREFIX = "H5JumpActivityById";

		// Token: 0x04001B09 RID: 6921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B0A RID: 6922
		private static int HandleId;
	}
}
