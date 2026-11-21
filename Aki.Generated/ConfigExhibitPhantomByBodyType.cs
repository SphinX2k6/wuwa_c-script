using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A3 RID: 675
	public class ConfigExhibitPhantomByBodyType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x000B6940 File Offset: 0x000B4B40
		static ConfigExhibitPhantomByBodyType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitPhantomByBodyType.CreateStaticDefaultValue), new Action(ConfigExhibitPhantomByBodyType.ResetStaticDefaultValue));
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000B6960 File Offset: 0x000B4B60
		public static void CreateStaticDefaultValue()
		{
			ConfigExhibitPhantomByBodyType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExhibitPhantomByBodyType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "z.展台.xlsx"),
				new ValueTuple<string, object>("表名", "ExhibitPhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `ExhibitPhantom` where BodyType=?")
			});
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000B69DF File Offset: 0x000B4BDF
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitPhantomByBodyType.LogPair = null;
			ConfigExhibitPhantomByBodyType.HandleId = 0;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000B69ED File Offset: 0x000B4BED
		public static void Init()
		{
			ConfigExhibitPhantomByBodyType.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitPhantomByBodyType.HandleId, "db_spring26.db", "select BinData from `ExhibitPhantom` where BodyType=?");
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000B6A08 File Offset: 0x000B4C08
		[NullableContext(2)]
		public static IReadOnlyList<ExhibitPhantom> GetConfigList(int p0BodyType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExhibitPhantomByBodyType.HandleId, ConfigExhibitPhantomByBodyType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomByBodyType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BodyType);
				IReadOnlyList<ExhibitPhantom> readOnlyList = (IReadOnlyList<ExhibitPhantom>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigExhibitPhantomByBodyType.LogPair.Clear();
			ConfigExhibitPhantomByBodyType.LogPair.Add(new ValueTuple<string, object>("BodyType", p0BodyType));
			if (!ConfigCommon.BindInt(ConfigExhibitPhantomByBodyType.HandleId, 1, p0BodyType, ConfigExhibitPhantomByBodyType.LogPair))
			{
				ConfigCommon.Reset(ConfigExhibitPhantomByBodyType.HandleId, ConfigExhibitPhantomByBodyType.LogPair);
				return null;
			}
			List<ExhibitPhantom> list = new List<ExhibitPhantom>();
			while (ConfigCommon.Step(ConfigExhibitPhantomByBodyType.HandleId, false, ConfigExhibitPhantomByBodyType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExhibitPhantomByBodyType.HandleId, 0, ConfigExhibitPhantomByBodyType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExhibitPhantomByBodyType.HandleId, ConfigExhibitPhantomByBodyType.LogPair);
					return null;
				}
				ExhibitPhantom rootAsExhibitPhantom = ExhibitPhantom.GetRootAsExhibitPhantom(new ByteBuffer(item2));
				list.Add(rootAsExhibitPhantom);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExhibitPhantomByBodyType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BodyType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigExhibitPhantomByBodyType.HandleId, ConfigExhibitPhantomByBodyType.LogPair);
			return list;
		}

		// Token: 0x04001259 RID: 4697
		private const string DB = "db_spring26.db";

		// Token: 0x0400125A RID: 4698
		private const string FILE = "z.展台.xlsx";

		// Token: 0x0400125B RID: 4699
		private const string TABLE = "ExhibitPhantom";

		// Token: 0x0400125C RID: 4700
		private const string COMMAND = "select BinData from `ExhibitPhantom` where BodyType=?";

		// Token: 0x0400125D RID: 4701
		private const string KEY_PREFIX = "ExhibitPhantomByBodyType";

		// Token: 0x0400125E RID: 4702
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400125F RID: 4703
		private static int HandleId;
	}
}
