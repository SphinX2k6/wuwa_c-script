using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A0 RID: 2464
	public class ConfigSurvivorsPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x001A0A98 File Offset: 0x0019EC98
		static ConfigSurvivorsPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsPropertyById.CreateStaticDefaultValue), new Action(ConfigSurvivorsPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x001A0AB8 File Offset: 0x0019ECB8
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsProperty` where Id=?")
			});
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x001A0B37 File Offset: 0x0019ED37
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsPropertyById.LogPair = null;
			ConfigSurvivorsPropertyById.HandleId = 0;
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x001A0B45 File Offset: 0x0019ED45
		public static void Init()
		{
			ConfigSurvivorsPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsPropertyById.HandleId, "db_survivors.db", "select BinData from `SurvivorsProperty` where Id=?");
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x001A0B60 File Offset: 0x0019ED60
		public static SurvivorsProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsProperty?(SurvivorsProperty.GetRootAsSurvivorsProperty(configBuffer));
				}
			}
			ConfigSurvivorsPropertyById.LogPair.Clear();
			ConfigSurvivorsPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsPropertyById.HandleId, 1, p0Id, ConfigSurvivorsPropertyById.LogPair) || ConfigCommon.Step(ConfigSurvivorsPropertyById.HandleId, true, ConfigSurvivorsPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsPropertyById.HandleId, 0, ConfigSurvivorsPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsProperty rootAsSurvivorsProperty = SurvivorsProperty.GetRootAsSurvivorsProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
			return new SurvivorsProperty?(rootAsSurvivorsProperty);
		}

		// Token: 0x04004346 RID: 17222
		private const string DB = "db_survivors.db";

		// Token: 0x04004347 RID: 17223
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004348 RID: 17224
		private const string TABLE = "SurvivorsProperty";

		// Token: 0x04004349 RID: 17225
		private const string COMMAND = "select BinData from `SurvivorsProperty` where Id=?";

		// Token: 0x0400434A RID: 17226
		private const string KEY_PREFIX = "SurvivorsPropertyById";

		// Token: 0x0400434B RID: 17227
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400434C RID: 17228
		private static int HandleId;
	}
}
