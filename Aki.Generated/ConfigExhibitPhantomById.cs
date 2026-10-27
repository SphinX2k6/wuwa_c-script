using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000290 RID: 656
	public class ConfigExhibitPhantomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x000B08B3 File Offset: 0x000AEAB3
		static ConfigExhibitPhantomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitPhantomById.CreateStaticDefaultValue), new Action(ConfigExhibitPhantomById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000B08D4 File Offset: 0x000AEAD4
		public static void CreateStaticDefaultValue()
		{
			ConfigExhibitPhantomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExhibitPhantomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "z.展台.xlsx"),
				new ValueTuple<string, object>("表名", "ExhibitPhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `ExhibitPhantom` where Id=?")
			});
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000B0953 File Offset: 0x000AEB53
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitPhantomById.LogPair = null;
			ConfigExhibitPhantomById.HandleId = 0;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000B0961 File Offset: 0x000AEB61
		public static void Init()
		{
			ConfigExhibitPhantomById.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitPhantomById.HandleId, "db_spring26.db", "select BinData from `ExhibitPhantom` where Id=?");
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000B097C File Offset: 0x000AEB7C
		public static ExhibitPhantom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExhibitPhantom?(ExhibitPhantom.GetRootAsExhibitPhantom(configBuffer));
				}
			}
			ConfigExhibitPhantomById.LogPair.Clear();
			ConfigExhibitPhantomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExhibitPhantomById.HandleId, 1, p0Id, ConfigExhibitPhantomById.LogPair) || ConfigCommon.Step(ConfigExhibitPhantomById.HandleId, true, ConfigExhibitPhantomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExhibitPhantomById.HandleId, 0, ConfigExhibitPhantomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExhibitPhantom rootAsExhibitPhantom = ExhibitPhantom.GetRootAsExhibitPhantom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExhibitPhantomById.HandleId, ConfigExhibitPhantomById.LogPair);
			return new ExhibitPhantom?(rootAsExhibitPhantom);
		}

		// Token: 0x040011D4 RID: 4564
		private const string DB = "db_spring26.db";

		// Token: 0x040011D5 RID: 4565
		private const string FILE = "z.展台.xlsx";

		// Token: 0x040011D6 RID: 4566
		private const string TABLE = "ExhibitPhantom";

		// Token: 0x040011D7 RID: 4567
		private const string COMMAND = "select BinData from `ExhibitPhantom` where Id=?";

		// Token: 0x040011D8 RID: 4568
		private const string KEY_PREFIX = "ExhibitPhantomById";

		// Token: 0x040011D9 RID: 4569
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011DA RID: 4570
		private static int HandleId;
	}
}
