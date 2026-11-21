using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FA RID: 1786
	public class ConfigPhotoMemoryCollectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x00149C50 File Offset: 0x00147E50
		static ConfigPhotoMemoryCollectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryCollectById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryCollectById.ResetStaticDefaultValue));
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00149C70 File Offset: 0x00147E70
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

		// Token: 0x060029EE RID: 10734 RVA: 0x00149CEF File Offset: 0x00147EEF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryCollectById.LogPair = null;
			ConfigPhotoMemoryCollectById.HandleId = 0;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00149CFD File Offset: 0x00147EFD
		public static void Init()
		{
			ConfigPhotoMemoryCollectById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryCollectById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryCollect` where Id=?");
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00149D18 File Offset: 0x00147F18
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

		// Token: 0x040030BC RID: 12476
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x040030BD RID: 12477
		private const string FILE = "j.记忆手册.xlsx";

		// Token: 0x040030BE RID: 12478
		private const string TABLE = "PhotoMemoryCollect";

		// Token: 0x040030BF RID: 12479
		private const string COMMAND = "select BinData from `PhotoMemoryCollect` where Id=?";

		// Token: 0x040030C0 RID: 12480
		private const string KEY_PREFIX = "PhotoMemoryCollectById";

		// Token: 0x040030C1 RID: 12481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030C2 RID: 12482
		private static int HandleId;
	}
}
