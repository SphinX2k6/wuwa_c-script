using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E2 RID: 1762
	public class ConfigPhotoDropDownById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x00146C44 File Offset: 0x00144E44
		static ConfigPhotoDropDownById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoDropDownById.CreateStaticDefaultValue), new Action(ConfigPhotoDropDownById.ResetStaticDefaultValue));
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00146C64 File Offset: 0x00144E64
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoDropDownById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoDropDownById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoDropDown"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoDropDown` where Id=?")
			});
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00146CE3 File Offset: 0x00144EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoDropDownById.LogPair = null;
			ConfigPhotoDropDownById.HandleId = 0;
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00146CF1 File Offset: 0x00144EF1
		public static void Init()
		{
			ConfigPhotoDropDownById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoDropDownById.HandleId, "db_photograph.db", "select BinData from `PhotoDropDown` where Id=?");
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00146D0C File Offset: 0x00144F0C
		public static PhotoDropDown? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoDropDown?(PhotoDropDown.GetRootAsPhotoDropDown(configBuffer));
				}
			}
			ConfigPhotoDropDownById.LogPair.Clear();
			ConfigPhotoDropDownById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoDropDownById.HandleId, 1, p0Id, ConfigPhotoDropDownById.LogPair) || ConfigCommon.Step(ConfigPhotoDropDownById.HandleId, true, ConfigPhotoDropDownById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoDropDownById.HandleId, 0, ConfigPhotoDropDownById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoDropDown rootAsPhotoDropDown = PhotoDropDown.GetRootAsPhotoDropDown(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoDropDownById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoDropDownById.HandleId, ConfigPhotoDropDownById.LogPair);
			return new PhotoDropDown?(rootAsPhotoDropDown);
		}

		// Token: 0x04003014 RID: 12308
		private const string DB = "db_photograph.db";

		// Token: 0x04003015 RID: 12309
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x04003016 RID: 12310
		private const string TABLE = "PhotoDropDown";

		// Token: 0x04003017 RID: 12311
		private const string COMMAND = "select BinData from `PhotoDropDown` where Id=?";

		// Token: 0x04003018 RID: 12312
		private const string KEY_PREFIX = "PhotoDropDownById";

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
