using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE9 RID: 2793
	public class ConfigTrailPhantomPropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x001CF547 File Offset: 0x001CD747
		static ConfigTrailPhantomPropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrailPhantomPropById.CreateStaticDefaultValue), new Action(ConfigTrailPhantomPropById.ResetStaticDefaultValue));
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x001CF568 File Offset: 0x001CD768
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

		// Token: 0x0600418C RID: 16780 RVA: 0x001CF5E7 File Offset: 0x001CD7E7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrailPhantomPropById.LogPair = null;
			ConfigTrailPhantomPropById.HandleId = 0;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x001CF5F5 File Offset: 0x001CD7F5
		public static void Init()
		{
			ConfigTrailPhantomPropById.HandleId = ConfigCommon.InitDataStatement(ConfigTrailPhantomPropById.HandleId, "db_trial_role.db", "select BinData from `TrailPhantomProp` where Id = ?");
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x001CF610 File Offset: 0x001CD810
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

		// Token: 0x04004C45 RID: 19525
		private const string DB = "db_trial_role.db";

		// Token: 0x04004C46 RID: 19526
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004C47 RID: 19527
		private const string TABLE = "TrailPhantomProp";

		// Token: 0x04004C48 RID: 19528
		private const string COMMAND = "select BinData from `TrailPhantomProp` where Id = ?";

		// Token: 0x04004C49 RID: 19529
		private const string KEY_PREFIX = "TrailPhantomPropById";

		// Token: 0x04004C4A RID: 19530
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C4B RID: 19531
		private static int HandleId;
	}
}
