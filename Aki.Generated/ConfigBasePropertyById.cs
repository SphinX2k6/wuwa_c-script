using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E2 RID: 226
	public class ConfigBasePropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00077991 File Offset: 0x00075B91
		static ConfigBasePropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBasePropertyById.CreateStaticDefaultValue), new Action(ConfigBasePropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000779B0 File Offset: 0x00075BB0
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

		// Token: 0x0600054F RID: 1359 RVA: 0x00077A2F File Offset: 0x00075C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigBasePropertyById.LogPair = null;
			ConfigBasePropertyById.HandleId = 0;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00077A3D File Offset: 0x00075C3D
		public static void Init()
		{
			ConfigBasePropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigBasePropertyById.HandleId, "db_property.db", "select BinData from `BaseProperty` where Id=?");
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00077A58 File Offset: 0x00075C58
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

		// Token: 0x04000612 RID: 1554
		private const string DB = "db_property.db";

		// Token: 0x04000613 RID: 1555
		private const string FILE = "s.属性.xlsx";

		// Token: 0x04000614 RID: 1556
		private const string TABLE = "BaseProperty";

		// Token: 0x04000615 RID: 1557
		private const string COMMAND = "select BinData from `BaseProperty` where Id=?";

		// Token: 0x04000616 RID: 1558
		private const string KEY_PREFIX = "BasePropertyById";

		// Token: 0x04000617 RID: 1559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000618 RID: 1560
		private static int HandleId;
	}
}
