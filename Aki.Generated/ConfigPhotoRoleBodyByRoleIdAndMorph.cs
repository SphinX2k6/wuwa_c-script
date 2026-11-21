using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000708 RID: 1800
	public class ConfigPhotoRoleBodyByRoleIdAndMorph : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A40 RID: 10816 RVA: 0x0014BBD8 File Offset: 0x00149DD8
		static ConfigPhotoRoleBodyByRoleIdAndMorph()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoRoleBodyByRoleIdAndMorph.CreateStaticDefaultValue), new Action(ConfigPhotoRoleBodyByRoleIdAndMorph.ResetStaticDefaultValue));
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x0014BBF8 File Offset: 0x00149DF8
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

		// Token: 0x06002A42 RID: 10818 RVA: 0x0014BC77 File Offset: 0x00149E77
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoRoleBodyByRoleIdAndMorph.LogPair = null;
			ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId = 0;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0014BC85 File Offset: 0x00149E85
		public static void Init()
		{
			ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoRoleBodyByRoleIdAndMorph.HandleId, "db_photonew.db", "select BinData from `PhotoRoleBody` where RoleId=? AND Morph=?");
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0014BCA0 File Offset: 0x00149EA0
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

		// Token: 0x0400311E RID: 12574
		private const string DB = "db_photonew.db";

		// Token: 0x0400311F RID: 12575
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003120 RID: 12576
		private const string TABLE = "PhotoRoleBody";

		// Token: 0x04003121 RID: 12577
		private const string COMMAND = "select BinData from `PhotoRoleBody` where RoleId=? AND Morph=?";

		// Token: 0x04003122 RID: 12578
		private const string KEY_PREFIX = "PhotoRoleBodyByRoleIdAndMorph";

		// Token: 0x04003123 RID: 12579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003124 RID: 12580
		private static int HandleId;
	}
}
