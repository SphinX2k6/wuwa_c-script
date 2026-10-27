using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000291 RID: 657
	public class ConfigExhibitWeaponTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F6B RID: 3947 RVA: 0x000B0AFC File Offset: 0x000AECFC
		static ConfigExhibitWeaponTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitWeaponTransformById.CreateStaticDefaultValue), new Action(ConfigExhibitWeaponTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000B0B1C File Offset: 0x000AED1C
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

		// Token: 0x06000F6D RID: 3949 RVA: 0x000B0B9B File Offset: 0x000AED9B
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitWeaponTransformById.LogPair = null;
			ConfigExhibitWeaponTransformById.HandleId = 0;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000B0BA9 File Offset: 0x000AEDA9
		public static void Init()
		{
			ConfigExhibitWeaponTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitWeaponTransformById.HandleId, "db_spring26.db", "select BinData from `ExhibitWeaponTransform` where Id=?");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000B0BC4 File Offset: 0x000AEDC4
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

		// Token: 0x040011DB RID: 4571
		private const string DB = "db_spring26.db";

		// Token: 0x040011DC RID: 4572
		private const string FILE = "z.展台.xlsx";

		// Token: 0x040011DD RID: 4573
		private const string TABLE = "ExhibitWeaponTransform";

		// Token: 0x040011DE RID: 4574
		private const string COMMAND = "select BinData from `ExhibitWeaponTransform` where Id=?";

		// Token: 0x040011DF RID: 4575
		private const string KEY_PREFIX = "ExhibitWeaponTransformById";

		// Token: 0x040011E0 RID: 4576
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011E1 RID: 4577
		private static int HandleId;
	}
}
