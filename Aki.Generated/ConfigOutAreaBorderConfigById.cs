using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000632 RID: 1586
	public class ConfigOutAreaBorderConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600253C RID: 9532 RVA: 0x0012C2DC File Offset: 0x0012A4DC
		static ConfigOutAreaBorderConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOutAreaBorderConfigById.CreateStaticDefaultValue), new Action(ConfigOutAreaBorderConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0012C2FC File Offset: 0x0012A4FC
		public static void CreateStaticDefaultValue()
		{
			ConfigOutAreaBorderConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOutAreaBorderConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_outareaborderconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/q.区域出界效果/*.csv*"),
				new ValueTuple<string, object>("表名", "OutAreaBorderConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `OutAreaBorderConfig` where Id = ?")
			});
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0012C37B File Offset: 0x0012A57B
		public static void ResetStaticDefaultValue()
		{
			ConfigOutAreaBorderConfigById.LogPair = null;
			ConfigOutAreaBorderConfigById.HandleId = 0;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x0012C389 File Offset: 0x0012A589
		public static void Init()
		{
			ConfigOutAreaBorderConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigOutAreaBorderConfigById.HandleId, "db_outareaborderconfig.db", "select BinData from `OutAreaBorderConfig` where Id = ?");
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0012C3A4 File Offset: 0x0012A5A4
		public static OutAreaBorderConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OutAreaBorderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OutAreaBorderConfig?(OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(configBuffer));
				}
			}
			ConfigOutAreaBorderConfigById.LogPair.Clear();
			ConfigOutAreaBorderConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOutAreaBorderConfigById.HandleId, 1, p0Id, ConfigOutAreaBorderConfigById.LogPair) || ConfigCommon.Step(ConfigOutAreaBorderConfigById.HandleId, true, ConfigOutAreaBorderConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOutAreaBorderConfigById.HandleId, 0, ConfigOutAreaBorderConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OutAreaBorderConfig rootAsOutAreaBorderConfig = OutAreaBorderConfig.GetRootAsOutAreaBorderConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OutAreaBorderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOutAreaBorderConfigById.HandleId, ConfigOutAreaBorderConfigById.LogPair);
			return new OutAreaBorderConfig?(rootAsOutAreaBorderConfig);
		}

		// Token: 0x04002B44 RID: 11076
		private const string DB = "db_outareaborderconfig.db";

		// Token: 0x04002B45 RID: 11077
		private const string FILE = "k.可视化编辑/c.Csv/q.区域出界效果/*.csv*";

		// Token: 0x04002B46 RID: 11078
		private const string TABLE = "OutAreaBorderConfig";

		// Token: 0x04002B47 RID: 11079
		private const string COMMAND = "select BinData from `OutAreaBorderConfig` where Id = ?";

		// Token: 0x04002B48 RID: 11080
		private const string KEY_PREFIX = "OutAreaBorderConfigById";

		// Token: 0x04002B49 RID: 11081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B4A RID: 11082
		private static int HandleId;
	}
}
