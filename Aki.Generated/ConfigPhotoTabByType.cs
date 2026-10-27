using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006FE RID: 1790
	public class ConfigPhotoTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x00146E0C File Offset: 0x0014500C
		static ConfigPhotoTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabByType.CreateStaticDefaultValue), new Action(ConfigPhotoTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00146E2C File Offset: 0x0014502C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoTabByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoTabByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoTab` where Type=?")
			});
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00146EAB File Offset: 0x001450AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabByType.LogPair = null;
			ConfigPhotoTabByType.HandleId = 0;
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00146EB9 File Offset: 0x001450B9
		public static void Init()
		{
			ConfigPhotoTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabByType.HandleId, "db_photonew.db", "select BinData from `PhotoTab` where Type=?");
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00146ED4 File Offset: 0x001450D4
		public static PhotoTab? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoTabByType.HandleId, ConfigPhotoTabByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoTab?(PhotoTab.GetRootAsPhotoTab(configBuffer));
				}
			}
			ConfigPhotoTabByType.LogPair.Clear();
			ConfigPhotoTabByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhotoTabByType.HandleId, 1, p0Type, ConfigPhotoTabByType.LogPair) || ConfigCommon.Step(ConfigPhotoTabByType.HandleId, true, ConfigPhotoTabByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoTabByType.HandleId, ConfigPhotoTabByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoTabByType.HandleId, 0, ConfigPhotoTabByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoTabByType.HandleId, ConfigPhotoTabByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoTab rootAsPhotoTab = PhotoTab.GetRootAsPhotoTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoTabByType.HandleId, ConfigPhotoTabByType.LogPair);
			return new PhotoTab?(rootAsPhotoTab);
		}

		// Token: 0x040030D8 RID: 12504
		private const string DB = "db_photonew.db";

		// Token: 0x040030D9 RID: 12505
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030DA RID: 12506
		private const string TABLE = "PhotoTab";

		// Token: 0x040030DB RID: 12507
		private const string COMMAND = "select BinData from `PhotoTab` where Type=?";

		// Token: 0x040030DC RID: 12508
		private const string KEY_PREFIX = "PhotoTabByType";

		// Token: 0x040030DD RID: 12509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030DE RID: 12510
		private static int HandleId;
	}
}
