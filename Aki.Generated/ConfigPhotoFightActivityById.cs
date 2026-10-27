using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D0 RID: 1744
	public class ConfigPhotoFightActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028F0 RID: 10480 RVA: 0x00140DEF File Offset: 0x0013EFEF
		static ConfigPhotoFightActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityById.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00140E10 File Offset: 0x0013F010
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivity` where Id=?")
			});
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00140E8F File Offset: 0x0013F08F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityById.LogPair = null;
			ConfigPhotoFightActivityById.HandleId = 0;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00140E9D File Offset: 0x0013F09D
		public static void Init()
		{
			ConfigPhotoFightActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityById.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity` where Id=?");
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00140EB8 File Offset: 0x0013F0B8
		public static PhotoFightActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFightActivity?(PhotoFightActivity.GetRootAsPhotoFightActivity(configBuffer));
				}
			}
			ConfigPhotoFightActivityById.LogPair.Clear();
			ConfigPhotoFightActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFightActivityById.HandleId, 1, p0Id, ConfigPhotoFightActivityById.LogPair) || ConfigCommon.Step(ConfigPhotoFightActivityById.HandleId, true, ConfigPhotoFightActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityById.HandleId, 0, ConfigPhotoFightActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFightActivity rootAsPhotoFightActivity = PhotoFightActivity.GetRootAsPhotoFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
			return new PhotoFightActivity?(rootAsPhotoFightActivity);
		}

		// Token: 0x04002F96 RID: 12182
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002F97 RID: 12183
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002F98 RID: 12184
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x04002F99 RID: 12185
		private const string COMMAND = "select BinData from `PhotoFightActivity` where Id=?";

		// Token: 0x04002F9A RID: 12186
		private const string KEY_PREFIX = "PhotoFightActivityById";

		// Token: 0x04002F9B RID: 12187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F9C RID: 12188
		private static int HandleId;
	}
}
