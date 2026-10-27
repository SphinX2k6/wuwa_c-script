using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D9 RID: 1753
	public class ConfigPhotoFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x00141F77 File Offset: 0x00140177
		static ConfigPhotoFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFilterById.CreateStaticDefaultValue), new Action(ConfigPhotoFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00141F98 File Offset: 0x00140198
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFilter` where Id=?")
			});
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00142017 File Offset: 0x00140217
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFilterById.LogPair = null;
			ConfigPhotoFilterById.HandleId = 0;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00142025 File Offset: 0x00140225
		public static void Init()
		{
			ConfigPhotoFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFilterById.HandleId, "db_photograph.db", "select BinData from `PhotoFilter` where Id=?");
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00142040 File Offset: 0x00140240
		public static PhotoFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFilter?(PhotoFilter.GetRootAsPhotoFilter(configBuffer));
				}
			}
			ConfigPhotoFilterById.LogPair.Clear();
			ConfigPhotoFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFilterById.HandleId, 1, p0Id, ConfigPhotoFilterById.LogPair) || ConfigCommon.Step(ConfigPhotoFilterById.HandleId, true, ConfigPhotoFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFilterById.HandleId, 0, ConfigPhotoFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFilter rootAsPhotoFilter = PhotoFilter.GetRootAsPhotoFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
			return new PhotoFilter?(rootAsPhotoFilter);
		}

		// Token: 0x04002FD5 RID: 12245
		private const string DB = "db_photograph.db";

		// Token: 0x04002FD6 RID: 12246
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04002FD7 RID: 12247
		private const string TABLE = "PhotoFilter";

		// Token: 0x04002FD8 RID: 12248
		private const string COMMAND = "select BinData from `PhotoFilter` where Id=?";

		// Token: 0x04002FD9 RID: 12249
		private const string KEY_PREFIX = "PhotoFilterById";

		// Token: 0x04002FDA RID: 12250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FDB RID: 12251
		private static int HandleId;
	}
}
