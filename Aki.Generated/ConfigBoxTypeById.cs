using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000119 RID: 281
	public class ConfigBoxTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x0007EDC0 File Offset: 0x0007CFC0
		static ConfigBoxTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBoxTypeById.CreateStaticDefaultValue), new Action(ConfigBoxTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		public static void CreateStaticDefaultValue()
		{
			ConfigBoxTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBoxTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_treasure.db"),
				new ValueTuple<string, object>("文件", "w.物资箱.xlsx"),
				new ValueTuple<string, object>("表名", "BoxType"),
				new ValueTuple<string, object>("语句", "select BinData from `BoxType` where Id=?")
			});
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0007EE5F File Offset: 0x0007D05F
		public static void ResetStaticDefaultValue()
		{
			ConfigBoxTypeById.LogPair = null;
			ConfigBoxTypeById.HandleId = 0;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0007EE6D File Offset: 0x0007D06D
		public static void Init()
		{
			ConfigBoxTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigBoxTypeById.HandleId, "db_treasure.db", "select BinData from `BoxType` where Id=?");
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0007EE88 File Offset: 0x0007D088
		public static BoxType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BoxType?(BoxType.GetRootAsBoxType(configBuffer));
				}
			}
			ConfigBoxTypeById.LogPair.Clear();
			ConfigBoxTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBoxTypeById.HandleId, 1, p0Id, ConfigBoxTypeById.LogPair) || ConfigCommon.Step(ConfigBoxTypeById.HandleId, true, ConfigBoxTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBoxTypeById.HandleId, 0, ConfigBoxTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BoxType rootAsBoxType = BoxType.GetRootAsBoxType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
			return new BoxType?(rootAsBoxType);
		}

		// Token: 0x04000793 RID: 1939
		private const string DB = "db_treasure.db";

		// Token: 0x04000794 RID: 1940
		private const string FILE = "w.物资箱.xlsx";

		// Token: 0x04000795 RID: 1941
		private const string TABLE = "BoxType";

		// Token: 0x04000796 RID: 1942
		private const string COMMAND = "select BinData from `BoxType` where Id=?";

		// Token: 0x04000797 RID: 1943
		private const string KEY_PREFIX = "BoxTypeById";

		// Token: 0x04000798 RID: 1944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000799 RID: 1945
		private static int HandleId;
	}
}
