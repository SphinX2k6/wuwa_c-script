using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200070D RID: 1805
	public class ConfigPhotoSetupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A5E RID: 10846 RVA: 0x0014C61B File Offset: 0x0014A81B
		static ConfigPhotoSetupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupById.CreateStaticDefaultValue), new Action(ConfigPhotoSetupById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x0014C63C File Offset: 0x0014A83C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSetupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSetupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSetup` where Id=?")
			});
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x0014C6BB File Offset: 0x0014A8BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupById.LogPair = null;
			ConfigPhotoSetupById.HandleId = 0;
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x0014C6C9 File Offset: 0x0014A8C9
		public static void Init()
		{
			ConfigPhotoSetupById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupById.HandleId, "db_photograph.db", "select BinData from `PhotoSetup` where Id=?");
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x0014C6E4 File Offset: 0x0014A8E4
		public static PhotoSetup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSetup?(PhotoSetup.GetRootAsPhotoSetup(configBuffer));
				}
			}
			ConfigPhotoSetupById.LogPair.Clear();
			ConfigPhotoSetupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoSetupById.HandleId, 1, p0Id, ConfigPhotoSetupById.LogPair) || ConfigCommon.Step(ConfigPhotoSetupById.HandleId, true, ConfigPhotoSetupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSetupById.HandleId, 0, ConfigPhotoSetupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSetup rootAsPhotoSetup = PhotoSetup.GetRootAsPhotoSetup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
			return new PhotoSetup?(rootAsPhotoSetup);
		}

		// Token: 0x04003141 RID: 12609
		private const string DB = "db_photograph.db";

		// Token: 0x04003142 RID: 12610
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003143 RID: 12611
		private const string TABLE = "PhotoSetup";

		// Token: 0x04003144 RID: 12612
		private const string COMMAND = "select BinData from `PhotoSetup` where Id=?";

		// Token: 0x04003145 RID: 12613
		private const string KEY_PREFIX = "PhotoSetupById";

		// Token: 0x04003146 RID: 12614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003147 RID: 12615
		private static int HandleId;
	}
}
