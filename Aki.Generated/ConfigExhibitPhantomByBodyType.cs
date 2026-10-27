using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028F RID: 655
	public class ConfigExhibitPhantomByBodyType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x000B067C File Offset: 0x000AE87C
		static ConfigExhibitPhantomByBodyType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExhibitPhantomByBodyType.CreateStaticDefaultValue), new Action(ConfigExhibitPhantomByBodyType.ResetStaticDefaultValue));
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000B069C File Offset: 0x000AE89C
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

		// Token: 0x06000F61 RID: 3937 RVA: 0x000B071B File Offset: 0x000AE91B
		public static void ResetStaticDefaultValue()
		{
			ConfigExhibitPhantomByBodyType.LogPair = null;
			ConfigExhibitPhantomByBodyType.HandleId = 0;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000B0729 File Offset: 0x000AE929
		public static void Init()
		{
			ConfigExhibitPhantomByBodyType.HandleId = ConfigCommon.InitDataStatement(ConfigExhibitPhantomByBodyType.HandleId, "db_spring26.db", "select BinData from `ExhibitPhantom` where BodyType=?");
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000B0744 File Offset: 0x000AE944
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

		// Token: 0x040011CD RID: 4557
		private const string DB = "db_spring26.db";

		// Token: 0x040011CE RID: 4558
		private const string FILE = "z.展台.xlsx";

		// Token: 0x040011CF RID: 4559
		private const string TABLE = "ExhibitPhantom";

		// Token: 0x040011D0 RID: 4560
		private const string COMMAND = "select BinData from `ExhibitPhantom` where BodyType=?";

		// Token: 0x040011D1 RID: 4561
		private const string KEY_PREFIX = "ExhibitPhantomByBodyType";

		// Token: 0x040011D2 RID: 4562
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011D3 RID: 4563
		private static int HandleId;
	}
}
