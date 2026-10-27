using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E8 RID: 1768
	public class ConfigPhotoModeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x00143E0C File Offset: 0x0014200C
		static ConfigPhotoModeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoModeByType.CreateStaticDefaultValue), new Action(ConfigPhotoModeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00143E2C File Offset: 0x0014202C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoModeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoModeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoMode"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoMode` where Type=?")
			});
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00143EAB File Offset: 0x001420AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoModeByType.LogPair = null;
			ConfigPhotoModeByType.HandleId = 0;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00143EB9 File Offset: 0x001420B9
		public static void Init()
		{
			ConfigPhotoModeByType.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoModeByType.HandleId, "db_photonew.db", "select BinData from `PhotoMode` where Type=?");
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00143ED4 File Offset: 0x001420D4
		public static PhotoMode? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoMode?(PhotoMode.GetRootAsPhotoMode(configBuffer));
				}
			}
			ConfigPhotoModeByType.LogPair.Clear();
			ConfigPhotoModeByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigPhotoModeByType.HandleId, 1, p0Type, ConfigPhotoModeByType.LogPair) || ConfigCommon.Step(ConfigPhotoModeByType.HandleId, true, ConfigPhotoModeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoModeByType.HandleId, 0, ConfigPhotoModeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoMode rootAsPhotoMode = PhotoMode.GetRootAsPhotoMode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoModeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoModeByType.HandleId, ConfigPhotoModeByType.LogPair);
			return new PhotoMode?(rootAsPhotoMode);
		}

		// Token: 0x0400303E RID: 12350
		private const string DB = "db_photonew.db";

		// Token: 0x0400303F RID: 12351
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003040 RID: 12352
		private const string TABLE = "PhotoMode";

		// Token: 0x04003041 RID: 12353
		private const string COMMAND = "select BinData from `PhotoMode` where Type=?";

		// Token: 0x04003042 RID: 12354
		private const string KEY_PREFIX = "PhotoModeByType";

		// Token: 0x04003043 RID: 12355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003044 RID: 12356
		private static int HandleId;
	}
}
