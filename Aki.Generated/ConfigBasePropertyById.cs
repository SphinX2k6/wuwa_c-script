using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F1 RID: 241
	public class ConfigBasePropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x0007D2F5 File Offset: 0x0007B4F5
		static ConfigBasePropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBasePropertyById.CreateStaticDefaultValue), new Action(ConfigBasePropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0007D314 File Offset: 0x0007B514
		public static void CreateStaticDefaultValue()
		{
			ConfigBasePropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBasePropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "BaseProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `BaseProperty` where Id=?")
			});
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0007D393 File Offset: 0x0007B593
		public static void ResetStaticDefaultValue()
		{
			ConfigBasePropertyById.LogPair = null;
			ConfigBasePropertyById.HandleId = 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0007D3A1 File Offset: 0x0007B5A1
		public static void Init()
		{
			ConfigBasePropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigBasePropertyById.HandleId, "db_property.db", "select BinData from `BaseProperty` where Id=?");
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0007D3BC File Offset: 0x0007B5BC
		public static BaseProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBasePropertyById.HandleId, ConfigBasePropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BasePropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BaseProperty?(BaseProperty.GetRootAsBaseProperty(configBuffer));
				}
			}
			ConfigBasePropertyById.LogPair.Clear();
			ConfigBasePropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBasePropertyById.HandleId, 1, p0Id, ConfigBasePropertyById.LogPair) || ConfigCommon.Step(ConfigBasePropertyById.HandleId, true, ConfigBasePropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBasePropertyById.HandleId, ConfigBasePropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBasePropertyById.HandleId, 0, ConfigBasePropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBasePropertyById.HandleId, ConfigBasePropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BaseProperty rootAsBaseProperty = BaseProperty.GetRootAsBaseProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BasePropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBasePropertyById.HandleId, ConfigBasePropertyById.LogPair);
			return new BaseProperty?(rootAsBaseProperty);
		}

		// Token: 0x0400067B RID: 1659
		private const string DB = "db_property.db";

		// Token: 0x0400067C RID: 1660
		private const string FILE = "s.属性.xlsx";

		// Token: 0x0400067D RID: 1661
		private const string TABLE = "BaseProperty";

		// Token: 0x0400067E RID: 1662
		private const string COMMAND = "select BinData from `BaseProperty` where Id=?";

		// Token: 0x0400067F RID: 1663
		private const string KEY_PREFIX = "BasePropertyById";

		// Token: 0x04000680 RID: 1664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000681 RID: 1665
		private static int HandleId;
	}
}
