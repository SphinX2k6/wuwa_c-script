using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067A RID: 1658
	public class ConfigPhantomBattleCardElementById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x001393A8 File Offset: 0x001375A8
		static ConfigPhantomBattleCardElementById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardElementById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardElementById.ResetStaticDefaultValue));
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x001393C8 File Offset: 0x001375C8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardElementById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardElementById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardElement"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardElement` where Id=?")
			});
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00139447 File Offset: 0x00137647
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardElementById.LogPair = null;
			ConfigPhantomBattleCardElementById.HandleId = 0;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00139455 File Offset: 0x00137655
		public static void Init()
		{
			ConfigPhantomBattleCardElementById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardElementById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardElement` where Id=?");
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00139470 File Offset: 0x00137670
		public static PhantomBattleCardElement? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardElementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardElement?(PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(configBuffer));
				}
			}
			ConfigPhantomBattleCardElementById.LogPair.Clear();
			ConfigPhantomBattleCardElementById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardElementById.HandleId, 1, p0Id, ConfigPhantomBattleCardElementById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardElementById.HandleId, true, ConfigPhantomBattleCardElementById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardElementById.HandleId, 0, ConfigPhantomBattleCardElementById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardElement rootAsPhantomBattleCardElement = PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardElementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
			return new PhantomBattleCardElement?(rootAsPhantomBattleCardElement);
		}

		// Token: 0x04002D3C RID: 11580
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D3D RID: 11581
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D3E RID: 11582
		private const string TABLE = "PhantomBattleCardElement";

		// Token: 0x04002D3F RID: 11583
		private const string COMMAND = "select BinData from `PhantomBattleCardElement` where Id=?";

		// Token: 0x04002D40 RID: 11584
		private const string KEY_PREFIX = "PhantomBattleCardElementById";

		// Token: 0x04002D41 RID: 11585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D42 RID: 11586
		private static int HandleId;
	}
}
