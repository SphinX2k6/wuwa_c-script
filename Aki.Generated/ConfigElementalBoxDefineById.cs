using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000270 RID: 624
	public class ConfigElementalBoxDefineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x000AFC0B File Offset: 0x000ADE0B
		static ConfigElementalBoxDefineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementalBoxDefineById.CreateStaticDefaultValue), new Action(ConfigElementalBoxDefineById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000AFC2C File Offset: 0x000ADE2C
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

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000AFCAB File Offset: 0x000ADEAB
		public static void ResetStaticDefaultValue()
		{
			ConfigElementalBoxDefineById.LogPair = null;
			ConfigElementalBoxDefineById.HandleId = 0;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000AFCB9 File Offset: 0x000ADEB9
		public static void Init()
		{
			ConfigElementalBoxDefineById.HandleId = ConfigCommon.InitDataStatement(ConfigElementalBoxDefineById.HandleId, "db_elementalboxdefine.db", "select BinData from `ElementalBoxDefine` where Id=?");
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000AFCD4 File Offset: 0x000ADED4
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

		// Token: 0x040010F4 RID: 4340
		private const string DB = "db_elementalboxdefine.db";

		// Token: 0x040010F5 RID: 4341
		private const string FILE = "k.可视化编辑/c.Csv/x.匣子核心定义/*.csv*";

		// Token: 0x040010F6 RID: 4342
		private const string TABLE = "ElementalBoxDefine";

		// Token: 0x040010F7 RID: 4343
		private const string COMMAND = "select BinData from `ElementalBoxDefine` where Id=?";

		// Token: 0x040010F8 RID: 4344
		private const string KEY_PREFIX = "ElementalBoxDefineById";

		// Token: 0x040010F9 RID: 4345
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010FA RID: 4346
		private static int HandleId;
	}
}
