using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000716 RID: 1814
	public class ConfigPhotoTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x0014D888 File Offset: 0x0014BA88
		static ConfigPhotoTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoTabByType.CreateStaticDefaultValue), new Action(ConfigPhotoTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0014D8A8 File Offset: 0x0014BAA8
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

		// Token: 0x06002A96 RID: 10902 RVA: 0x0014D927 File Offset: 0x0014BB27
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoTabByType.LogPair = null;
			ConfigPhotoTabByType.HandleId = 0;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0014D935 File Offset: 0x0014BB35
		public static void Init()
		{
			ConfigPhotoTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoTabByType.HandleId, "db_photonew.db", "select BinData from `PhotoTab` where Type=?");
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0014D950 File Offset: 0x0014BB50
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

		// Token: 0x04003180 RID: 12672
		private const string DB = "db_photonew.db";

		// Token: 0x04003181 RID: 12673
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003182 RID: 12674
		private const string TABLE = "PhotoTab";

		// Token: 0x04003183 RID: 12675
		private const string COMMAND = "select BinData from `PhotoTab` where Type=?";

		// Token: 0x04003184 RID: 12676
		private const string KEY_PREFIX = "PhotoTabByType";

		// Token: 0x04003185 RID: 12677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003186 RID: 12678
		private static int HandleId;
	}
}
