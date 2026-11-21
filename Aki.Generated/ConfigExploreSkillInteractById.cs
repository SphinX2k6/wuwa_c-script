using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B8 RID: 696
	public class ConfigExploreSkillInteractById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001055 RID: 4181 RVA: 0x000B94A0 File Offset: 0x000B76A0
		static ConfigExploreSkillInteractById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreSkillInteractById.CreateStaticDefaultValue), new Action(ConfigExploreSkillInteractById.ResetStaticDefaultValue));
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x000B94C0 File Offset: 0x000B76C0
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreSkillInteractById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreSkillInteractById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_exploreskillinteract.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.探索技能交互物/*.csv*"),
				new ValueTuple<string, object>("表名", "ExploreSkillInteract"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreSkillInteract` where Id=?")
			});
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000B953F File Offset: 0x000B773F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreSkillInteractById.LogPair = null;
			ConfigExploreSkillInteractById.HandleId = 0;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000B954D File Offset: 0x000B774D
		public static void Init()
		{
			ConfigExploreSkillInteractById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreSkillInteractById.HandleId, "db_exploreskillinteract.db", "select BinData from `ExploreSkillInteract` where Id=?");
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000B9568 File Offset: 0x000B7768
		public static ExploreSkillInteract? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreSkillInteractById.HandleId, ConfigExploreSkillInteractById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreSkillInteractById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreSkillInteract?(ExploreSkillInteract.GetRootAsExploreSkillInteract(configBuffer));
				}
			}
			ConfigExploreSkillInteractById.LogPair.Clear();
			ConfigExploreSkillInteractById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreSkillInteractById.HandleId, 1, p0Id, ConfigExploreSkillInteractById.LogPair) || ConfigCommon.Step(ConfigExploreSkillInteractById.HandleId, true, ConfigExploreSkillInteractById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreSkillInteractById.HandleId, ConfigExploreSkillInteractById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreSkillInteractById.HandleId, 0, ConfigExploreSkillInteractById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreSkillInteractById.HandleId, ConfigExploreSkillInteractById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreSkillInteract rootAsExploreSkillInteract = ExploreSkillInteract.GetRootAsExploreSkillInteract(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreSkillInteractById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreSkillInteractById.HandleId, ConfigExploreSkillInteractById.LogPair);
			return new ExploreSkillInteract?(rootAsExploreSkillInteract);
		}

		// Token: 0x040012EC RID: 4844
		private const string DB = "db_exploreskillinteract.db";

		// Token: 0x040012ED RID: 4845
		private const string FILE = "k.可视化编辑/c.Csv/t.探索技能交互物/*.csv*";

		// Token: 0x040012EE RID: 4846
		private const string TABLE = "ExploreSkillInteract";

		// Token: 0x040012EF RID: 4847
		private const string COMMAND = "select BinData from `ExploreSkillInteract` where Id=?";

		// Token: 0x040012F0 RID: 4848
		private const string KEY_PREFIX = "ExploreSkillInteractById";

		// Token: 0x040012F1 RID: 4849
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012F2 RID: 4850
		private static int HandleId;
	}
}
