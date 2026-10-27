using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E2 RID: 1762
	public class ConfigPhotoMemoryCollectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x001431D4 File Offset: 0x001413D4
		static ConfigPhotoMemoryCollectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryCollectById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryCollectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x001431F4 File Offset: 0x001413F4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryCollectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryCollect"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryCollect` where Id=?")
			});
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00143273 File Offset: 0x00141473
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectById.LogPair = null;
			ConfigPhotoMemoryCollectById.HandleId = 0;
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00143281 File Offset: 0x00141481
		public static void Init()
		{
			ConfigPhotoMemoryCollectById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryCollectById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryCollect` where Id=?");
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0014329C File Offset: 0x0014149C
		public static PhotoMemoryCollect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryCollectById.HandleId, ConfigPhotoMemoryCollectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryCollectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMemoryCollect?(PhotoMemoryCollect.GetRootAsPhotoMemoryCollect(configBuffer));
				}
			}
			ConfigPhotoMemoryCollectById.LogPair.Clear();
			ConfigPhotoMemoryCollectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoMemoryCollectById.HandleId, 1, p0Id, ConfigPhotoMemoryCollectById.LogPair) || ConfigCommon.Step(ConfigPhotoMemoryCollectById.HandleId, true, ConfigPhotoMemoryCollectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryCollectById.HandleId, ConfigPhotoMemoryCollectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryCollectById.HandleId, 0, ConfigPhotoMemoryCollectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryCollectById.HandleId, ConfigPhotoMemoryCollectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMemoryCollect rootAsPhotoMemoryCollect = PhotoMemoryCollect.GetRootAsPhotoMemoryCollect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryCollectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryCollectById.HandleId, ConfigPhotoMemoryCollectById.LogPair);
			return new PhotoMemoryCollect?(rootAsPhotoMemoryCollect);
		}

		// Token: 0x04003014 RID: 12308
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x04003015 RID: 12309
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x04003016 RID: 12310
		private const string TABLE = "PhotoMemoryCollect";

		// Token: 0x04003017 RID: 12311
		private const string COMMAND = "select BinData from `PhotoMemoryCollect` where Id=?";

		// Token: 0x04003018 RID: 12312
		private const string KEY_PREFIX = "PhotoMemoryCollectById";

		// Token: 0x04003019 RID: 12313
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400301A RID: 12314
		private static int HandleId;
	}
}
