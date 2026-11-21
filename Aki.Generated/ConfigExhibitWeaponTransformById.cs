using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A5 RID: 677
	public class ConfigExhibitWeaponTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x000B6DC0 File Offset: 0x000B4FC0
		static ConfigExhibitWeaponTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitWeaponTransformById.CreateStaticDefaultValue), new Action(ConfigExhibitWeaponTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000B6DE0 File Offset: 0x000B4FE0
		public static void CreateStaticDefaultValue()
		{
			ConfigExhibitWeaponTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExhibitWeaponTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "z.展台.xlsx"),
				new ValueTuple<string, object>("表名", "ExhibitWeaponTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `ExhibitWeaponTransform` where Id=?")
			});
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000B6E5F File Offset: 0x000B505F
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitWeaponTransformById.LogPair = null;
			ConfigExhibitWeaponTransformById.HandleId = 0;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000B6E6D File Offset: 0x000B506D
		public static void Init()
		{
			ConfigExhibitWeaponTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitWeaponTransformById.HandleId, "db_spring26.db", "select BinData from `ExhibitWeaponTransform` where Id=?");
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000B6E88 File Offset: 0x000B5088
		public static ExhibitWeaponTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExhibitWeaponTransformById.HandleId, ConfigExhibitWeaponTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExhibitWeaponTransform?(ExhibitWeaponTransform.GetRootAsExhibitWeaponTransform(configBuffer));
				}
			}
			ConfigExhibitWeaponTransformById.LogPair.Clear();
			ConfigExhibitWeaponTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExhibitWeaponTransformById.HandleId, 1, p0Id, ConfigExhibitWeaponTransformById.LogPair) || ConfigCommon.Step(ConfigExhibitWeaponTransformById.HandleId, true, ConfigExhibitWeaponTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExhibitWeaponTransformById.HandleId, ConfigExhibitWeaponTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExhibitWeaponTransformById.HandleId, 0, ConfigExhibitWeaponTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExhibitWeaponTransformById.HandleId, ConfigExhibitWeaponTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExhibitWeaponTransform rootAsExhibitWeaponTransform = ExhibitWeaponTransform.GetRootAsExhibitWeaponTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExhibitWeaponTransformById.HandleId, ConfigExhibitWeaponTransformById.LogPair);
			return new ExhibitWeaponTransform?(rootAsExhibitWeaponTransform);
		}

		// Token: 0x04001267 RID: 4711
		private const string DB = "db_spring26.db";

		// Token: 0x04001268 RID: 4712
		private const string FILE = "z.展台.xlsx";

		// Token: 0x04001269 RID: 4713
		private const string TABLE = "ExhibitWeaponTransform";

		// Token: 0x0400126A RID: 4714
		private const string COMMAND = "select BinData from `ExhibitWeaponTransform` where Id=?";

		// Token: 0x0400126B RID: 4715
		private const string KEY_PREFIX = "ExhibitWeaponTransformById";

		// Token: 0x0400126C RID: 4716
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400126D RID: 4717
		private static int HandleId;
	}
}
