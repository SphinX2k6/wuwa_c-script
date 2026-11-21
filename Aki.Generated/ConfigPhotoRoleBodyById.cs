using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000707 RID: 1799
	public class ConfigPhotoRoleBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A3A RID: 10810 RVA: 0x0014B98F File Offset: 0x00149B8F
		static ConfigPhotoRoleBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoRoleBodyById.CreateStaticDefaultValue), new Action(ConfigPhotoRoleBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x0014B9B0 File Offset: 0x00149BB0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoRoleBodyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoRoleBodyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoRoleBody"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoRoleBody` where Id=?")
			});
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x0014BA2F File Offset: 0x00149C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoRoleBodyById.LogPair = null;
			ConfigPhotoRoleBodyById.HandleId = 0;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0014BA3D File Offset: 0x00149C3D
		public static void Init()
		{
			ConfigPhotoRoleBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoRoleBodyById.HandleId, "db_photonew.db", "select BinData from `PhotoRoleBody` where Id=?");
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0014BA58 File Offset: 0x00149C58
		public static PhotoRoleBody? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoRoleBodyById.HandleId, ConfigPhotoRoleBodyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoRoleBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoRoleBody?(PhotoRoleBody.GetRootAsPhotoRoleBody(configBuffer));
				}
			}
			ConfigPhotoRoleBodyById.LogPair.Clear();
			ConfigPhotoRoleBodyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoRoleBodyById.HandleId, 1, p0Id, ConfigPhotoRoleBodyById.LogPair) || ConfigCommon.Step(ConfigPhotoRoleBodyById.HandleId, true, ConfigPhotoRoleBodyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoRoleBodyById.HandleId, ConfigPhotoRoleBodyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoRoleBodyById.HandleId, 0, ConfigPhotoRoleBodyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoRoleBodyById.HandleId, ConfigPhotoRoleBodyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoRoleBody rootAsPhotoRoleBody = PhotoRoleBody.GetRootAsPhotoRoleBody(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoRoleBodyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoRoleBodyById.HandleId, ConfigPhotoRoleBodyById.LogPair);
			return new PhotoRoleBody?(rootAsPhotoRoleBody);
		}

		// Token: 0x04003117 RID: 12567
		private const string DB = "db_photonew.db";

		// Token: 0x04003118 RID: 12568
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003119 RID: 12569
		private const string TABLE = "PhotoRoleBody";

		// Token: 0x0400311A RID: 12570
		private const string COMMAND = "select BinData from `PhotoRoleBody` where Id=?";

		// Token: 0x0400311B RID: 12571
		private const string KEY_PREFIX = "PhotoRoleBodyById";

		// Token: 0x0400311C RID: 12572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400311D RID: 12573
		private static int HandleId;
	}
}
