using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061D RID: 1565
	public class ConfigNpcSystemBackgroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024BE RID: 9406 RVA: 0x001296E4 File Offset: 0x001278E4
		static ConfigNpcSystemBackgroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcSystemBackgroundById.CreateStaticDefaultValue), new Action(ConfigNpcSystemBackgroundById.ResetStaticDefaultValue));
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00129704 File Offset: 0x00127904
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcSystemBackgroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "NpcSystemBackground"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcSystemBackground` where Id=?")
			});
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00129783 File Offset: 0x00127983
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundById.LogPair = null;
			ConfigNpcSystemBackgroundById.HandleId = 0;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00129791 File Offset: 0x00127991
		public static void Init()
		{
			ConfigNpcSystemBackgroundById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcSystemBackgroundById.HandleId, "db_commonbackground.db", "select BinData from `NpcSystemBackground` where Id=?");
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x001297AC File Offset: 0x001279AC
		public static NpcSystemBackground? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcSystemBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NpcSystemBackground?(NpcSystemBackground.GetRootAsNpcSystemBackground(configBuffer));
				}
			}
			ConfigNpcSystemBackgroundById.LogPair.Clear();
			ConfigNpcSystemBackgroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNpcSystemBackgroundById.HandleId, 1, p0Id, ConfigNpcSystemBackgroundById.LogPair) || ConfigCommon.Step(ConfigNpcSystemBackgroundById.HandleId, true, ConfigNpcSystemBackgroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcSystemBackgroundById.HandleId, 0, ConfigNpcSystemBackgroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NpcSystemBackground rootAsNpcSystemBackground = NpcSystemBackground.GetRootAsNpcSystemBackground(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcSystemBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNpcSystemBackgroundById.HandleId, ConfigNpcSystemBackgroundById.LogPair);
			return new NpcSystemBackground?(rootAsNpcSystemBackground);
		}

		// Token: 0x04002AB1 RID: 10929
		private const string DB = "db_commonbackground.db";

		// Token: 0x04002AB2 RID: 10930
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04002AB3 RID: 10931
		private const string TABLE = "NpcSystemBackground";

		// Token: 0x04002AB4 RID: 10932
		private const string COMMAND = "select BinData from `NpcSystemBackground` where Id=?";

		// Token: 0x04002AB5 RID: 10933
		private const string KEY_PREFIX = "NpcSystemBackgroundById";

		// Token: 0x04002AB6 RID: 10934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AB7 RID: 10935
		private static int HandleId;
	}
}
