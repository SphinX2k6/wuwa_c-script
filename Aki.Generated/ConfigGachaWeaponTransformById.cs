using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000379 RID: 889
	public class ConfigGachaWeaponTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x000CF8B0 File Offset: 0x000CDAB0
		static ConfigGachaWeaponTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaWeaponTransformById.CreateStaticDefaultValue), new Action(ConfigGachaWeaponTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000CF8D0 File Offset: 0x000CDAD0
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaWeaponTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaWeaponTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaWeaponTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaWeaponTransform` where Id=?")
			});
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000CF94F File Offset: 0x000CDB4F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaWeaponTransformById.LogPair = null;
			ConfigGachaWeaponTransformById.HandleId = 0;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000CF95D File Offset: 0x000CDB5D
		public static void Init()
		{
			ConfigGachaWeaponTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaWeaponTransformById.HandleId, "db_gacha.db", "select BinData from `GachaWeaponTransform` where Id=?");
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000CF978 File Offset: 0x000CDB78
		public static GachaWeaponTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaWeaponTransform?(GachaWeaponTransform.GetRootAsGachaWeaponTransform(configBuffer));
				}
			}
			ConfigGachaWeaponTransformById.LogPair.Clear();
			ConfigGachaWeaponTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaWeaponTransformById.HandleId, 1, p0Id, ConfigGachaWeaponTransformById.LogPair) || ConfigCommon.Step(ConfigGachaWeaponTransformById.HandleId, true, ConfigGachaWeaponTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaWeaponTransformById.HandleId, 0, ConfigGachaWeaponTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaWeaponTransform rootAsGachaWeaponTransform = GachaWeaponTransform.GetRootAsGachaWeaponTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
			return new GachaWeaponTransform?(rootAsGachaWeaponTransform);
		}

		// Token: 0x04001833 RID: 6195
		private const string DB = "db_gacha.db";

		// Token: 0x04001834 RID: 6196
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001835 RID: 6197
		private const string TABLE = "GachaWeaponTransform";

		// Token: 0x04001836 RID: 6198
		private const string COMMAND = "select BinData from `GachaWeaponTransform` where Id=?";

		// Token: 0x04001837 RID: 6199
		private const string KEY_PREFIX = "GachaWeaponTransformById";

		// Token: 0x04001838 RID: 6200
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001839 RID: 6201
		private static int HandleId;
	}
}
