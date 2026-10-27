using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F0 RID: 1776
	public class ConfigPhotoRoleBodyByRoleIdAndMorph : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029B0 RID: 10672 RVA: 0x0014515C File Offset: 0x0014335C
		static ConfigPhotoRoleBodyByRoleIdAndMorph()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoRoleBodyByRoleIdAndMorph.CreateStaticDefaultValue), new Action(ConfigPhotoRoleBodyByRoleIdAndMorph.ResetStaticDefaultValue));
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0014517C File Offset: 0x0014337C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoRoleBody"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoRoleBody` where RoleId=? AND Morph=?")
			});
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x001451FB File Offset: 0x001433FB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair = null;
			ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId = 0;
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x00145209 File Offset: 0x00143409
		public static void Init()
		{
			ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, "db_photonew.db", "select BinData from `PhotoRoleBody` where RoleId=? AND Morph=?");
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00145224 File Offset: 0x00143424
		public static PhotoRoleBody? GetConfig(int p0RoleId, int p1Morph, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoRoleBodyByRoleIdAndMorph");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Morph);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoRoleBody?(PhotoRoleBody.GetRootAsPhotoRoleBody(configBuffer));
				}
			}
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair.Clear();
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair.Add(new ValueTuple<string, object>("Morph", p1Morph));
			if (!ConfigCommon.BindInt(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, 1, p0RoleId, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair) || !ConfigCommon.BindInt(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, 2, p1Morph, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair) || ConfigCommon.Step(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, true, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, 0, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoRoleBody rootAsPhotoRoleBody = PhotoRoleBody.GetRootAsPhotoRoleBody(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoRoleBodyByRoleIdAndMorph");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Morph);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair);
			return new PhotoRoleBody?(rootAsPhotoRoleBody);
		}

		// Token: 0x04003076 RID: 12406
		private const string DB = "db_photonew.db";

		// Token: 0x04003077 RID: 12407
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003078 RID: 12408
		private const string TABLE = "PhotoRoleBody";

		// Token: 0x04003079 RID: 12409
		private const string COMMAND = "select BinData from `PhotoRoleBody` where RoleId=? AND Morph=?";

		// Token: 0x0400307A RID: 12410
		private const string KEY_PREFIX = "PhotoRoleBodyByRoleIdAndMorph";

		// Token: 0x0400307B RID: 12411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400307C RID: 12412
		private static int HandleId;
	}
}
