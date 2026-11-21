using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F9 RID: 1785
	public class ConfigPhotoMemoryActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029E6 RID: 10726 RVA: 0x00149A08 File Offset: 0x00147C08
		static ConfigPhotoMemoryActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoMemoryActivityById.CreateStaticDefaultValue), new Action(ConfigPhotoMemoryActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00149A28 File Offset: 0x00147C28
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoMemoryActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoMemoryActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fragmentmemory.db"),
				new ValueTuple<string, object>("文件", "j.记忆手册活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMemoryActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMemoryActivity` where Id=?")
			});
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00149AA7 File Offset: 0x00147CA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoMemoryActivityById.LogPair = null;
			ConfigPhotoMemoryActivityById.HandleId = 0;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00149AB5 File Offset: 0x00147CB5
		public static void Init()
		{
			ConfigPhotoMemoryActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoMemoryActivityById.HandleId, "db_fragmentmemory.db", "select BinData from `PhotoMemoryActivity` where Id=?");
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00149AD0 File Offset: 0x00147CD0
		public static PhotoMemoryActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMemoryActivity?(PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(configBuffer));
				}
			}
			ConfigPhotoMemoryActivityById.LogPair.Clear();
			ConfigPhotoMemoryActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoMemoryActivityById.HandleId, 1, p0Id, ConfigPhotoMemoryActivityById.LogPair) || ConfigCommon.Step(ConfigPhotoMemoryActivityById.HandleId, true, ConfigPhotoMemoryActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoMemoryActivityById.HandleId, 0, ConfigPhotoMemoryActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMemoryActivity rootAsPhotoMemoryActivity = PhotoMemoryActivity.GetRootAsPhotoMemoryActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoMemoryActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoMemoryActivityById.HandleId, ConfigPhotoMemoryActivityById.LogPair);
			return new PhotoMemoryActivity?(rootAsPhotoMemoryActivity);
		}

		// Token: 0x040030B5 RID: 12469
		private const string DB = "db_fragmentmemory.db";

		// Token: 0x040030B6 RID: 12470
		private const string FILE = "j.记忆手册活动.xlsx";

		// Token: 0x040030B7 RID: 12471
		private const string TABLE = "PhotoMemoryActivity";

		// Token: 0x040030B8 RID: 12472
		private const string COMMAND = "select BinData from `PhotoMemoryActivity` where Id=?";

		// Token: 0x040030B9 RID: 12473
		private const string KEY_PREFIX = "PhotoMemoryActivityById";

		// Token: 0x040030BA RID: 12474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030BB RID: 12475
		private static int HandleId;
	}
}
