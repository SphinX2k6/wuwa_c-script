using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EF RID: 1775
	public class ConfigPhotoRoleBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029AA RID: 10666 RVA: 0x00144F13 File Offset: 0x00143113
		static ConfigPhotoRoleBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoRoleBodyById.CreateStaticDefaultValue), new Action(ConfigPhotoRoleBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00144F34 File Offset: 0x00143134
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

		// Token: 0x060029AC RID: 10668 RVA: 0x00144FB3 File Offset: 0x001431B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoRoleBodyById.LogPair = null;
			ConfigPhotoRoleBodyById.HandleId = 0;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00144FC1 File Offset: 0x001431C1
		public static void Init()
		{
			ConfigPhotoRoleBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoRoleBodyById.HandleId, "db_photonew.db", "select BinData from `PhotoRoleBody` where Id=?");
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00144FDC File Offset: 0x001431DC
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

		// Token: 0x0400306F RID: 12399
		private const string DB = "db_photonew.db";

		// Token: 0x04003070 RID: 12400
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003071 RID: 12401
		private const string TABLE = "PhotoRoleBody";

		// Token: 0x04003072 RID: 12402
		private const string COMMAND = "select BinData from `PhotoRoleBody` where Id=?";

		// Token: 0x04003073 RID: 12403
		private const string KEY_PREFIX = "PhotoRoleBodyById";

		// Token: 0x04003074 RID: 12404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003075 RID: 12405
		private static int HandleId;
	}
}
