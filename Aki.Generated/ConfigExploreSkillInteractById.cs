using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A4 RID: 676
	public class ConfigExploreSkillInteractById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x000B31DC File Offset: 0x000B13DC
		static ConfigExploreSkillInteractById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreSkillInteractById.CreateStaticDefaultValue), new Action(ConfigExploreSkillInteractById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000B31FC File Offset: 0x000B13FC
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

		// Token: 0x06000FDF RID: 4063 RVA: 0x000B327B File Offset: 0x000B147B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreSkillInteractById.LogPair = null;
			ConfigExploreSkillInteractById.HandleId = 0;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000B3289 File Offset: 0x000B1489
		public static void Init()
		{
			ConfigExploreSkillInteractById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreSkillInteractById.HandleId, "db_exploreskillinteract.db", "select BinData from `ExploreSkillInteract` where Id=?");
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000B32A4 File Offset: 0x000B14A4
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

		// Token: 0x04001260 RID: 4704
		private const string DB = "db_exploreskillinteract.db";

		// Token: 0x04001261 RID: 4705
		private const string FILE = "k.可视化编辑/c.Csv/t.探索技能交互物/*.csv*";

		// Token: 0x04001262 RID: 4706
		private const string TABLE = "ExploreSkillInteract";

		// Token: 0x04001263 RID: 4707
		private const string COMMAND = "select BinData from `ExploreSkillInteract` where Id=?";

		// Token: 0x04001264 RID: 4708
		private const string KEY_PREFIX = "ExploreSkillInteractById";

		// Token: 0x04001265 RID: 4709
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001266 RID: 4710
		private static int HandleId;
	}
}
