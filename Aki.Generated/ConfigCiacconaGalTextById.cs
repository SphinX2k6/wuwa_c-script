using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016C RID: 364
	public class ConfigCiacconaGalTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00089B24 File Offset: 0x00087D24
		static ConfigCiacconaGalTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalTextById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalTextById.ResetStaticDefaultValue));
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00089B44 File Offset: 0x00087D44
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalText"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalText` where Id=?")
			});
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00089BC3 File Offset: 0x00087DC3
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalTextById.LogPair = null;
			ConfigCiacconaGalTextById.HandleId = 0;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00089BD1 File Offset: 0x00087DD1
		public static void Init()
		{
			ConfigCiacconaGalTextById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalTextById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalText` where Id=?");
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00089BEC File Offset: 0x00087DEC
		public static CiacconaGalText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalText?(CiacconaGalText.GetRootAsCiacconaGalText(configBuffer));
				}
			}
			ConfigCiacconaGalTextById.LogPair.Clear();
			ConfigCiacconaGalTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalTextById.HandleId, 1, p0Id, ConfigCiacconaGalTextById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalTextById.HandleId, true, ConfigCiacconaGalTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalTextById.HandleId, 0, ConfigCiacconaGalTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalText rootAsCiacconaGalText = CiacconaGalText.GetRootAsCiacconaGalText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
			return new CiacconaGalText?(rootAsCiacconaGalText);
		}

		// Token: 0x040009D8 RID: 2520
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009D9 RID: 2521
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009DA RID: 2522
		private const string TABLE = "CiacconaGalText";

		// Token: 0x040009DB RID: 2523
		private const string COMMAND = "select BinData from `CiacconaGalText` where Id=?";

		// Token: 0x040009DC RID: 2524
		private const string KEY_PREFIX = "CiacconaGalTextById";

		// Token: 0x040009DD RID: 2525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009DE RID: 2526
		private static int HandleId;
	}
}
