using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025C RID: 604
	public class ConfigElementalBoxDefineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x000A9947 File Offset: 0x000A7B47
		static ConfigElementalBoxDefineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementalBoxDefineById.CreateStaticDefaultValue), new Action(ConfigElementalBoxDefineById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000A9968 File Offset: 0x000A7B68
		public static void CreateStaticDefaultValue()
		{
			ConfigElementalBoxDefineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementalBoxDefineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_elementalboxdefine.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/x.匣子核心定义/*.csv*"),
				new ValueTuple<string, object>("表名", "ElementalBoxDefine"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementalBoxDefine` where Id=?")
			});
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000A99E7 File Offset: 0x000A7BE7
		public static void ResetStaticDefaultValue()
		{
			ConfigElementalBoxDefineById.LogPair = null;
			ConfigElementalBoxDefineById.HandleId = 0;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000A99F5 File Offset: 0x000A7BF5
		public static void Init()
		{
			ConfigElementalBoxDefineById.HandleId = ConfigCommon.InitDataStatement(ConfigElementalBoxDefineById.HandleId, "db_elementalboxdefine.db", "select BinData from `ElementalBoxDefine` where Id=?");
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000A9A10 File Offset: 0x000A7C10
		public static ElementalBoxDefine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementalBoxDefineById.HandleId, ConfigElementalBoxDefineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementalBoxDefineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ElementalBoxDefine?(ElementalBoxDefine.GetRootAsElementalBoxDefine(configBuffer));
				}
			}
			ConfigElementalBoxDefineById.LogPair.Clear();
			ConfigElementalBoxDefineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigElementalBoxDefineById.HandleId, 1, p0Id, ConfigElementalBoxDefineById.LogPair) || ConfigCommon.Step(ConfigElementalBoxDefineById.HandleId, true, ConfigElementalBoxDefineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigElementalBoxDefineById.HandleId, ConfigElementalBoxDefineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementalBoxDefineById.HandleId, 0, ConfigElementalBoxDefineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigElementalBoxDefineById.HandleId, ConfigElementalBoxDefineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ElementalBoxDefine rootAsElementalBoxDefine = ElementalBoxDefine.GetRootAsElementalBoxDefine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementalBoxDefineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigElementalBoxDefineById.HandleId, ConfigElementalBoxDefineById.LogPair);
			return new ElementalBoxDefine?(rootAsElementalBoxDefine);
		}

		// Token: 0x04001068 RID: 4200
		private const string DB = "db_elementalboxdefine.db";

		// Token: 0x04001069 RID: 4201
		private const string FILE = "k.可视化编辑/c.Csv/x.匣子核心定义/*.csv*";

		// Token: 0x0400106A RID: 4202
		private const string TABLE = "ElementalBoxDefine";

		// Token: 0x0400106B RID: 4203
		private const string COMMAND = "select BinData from `ElementalBoxDefine` where Id=?";

		// Token: 0x0400106C RID: 4204
		private const string KEY_PREFIX = "ElementalBoxDefineById";

		// Token: 0x0400106D RID: 4205
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400106E RID: 4206
		private static int HandleId;
	}
}
