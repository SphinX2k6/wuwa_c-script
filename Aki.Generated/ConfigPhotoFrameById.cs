using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DB RID: 1755
	public class ConfigPhotoFrameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002932 RID: 10546 RVA: 0x00142353 File Offset: 0x00140553
		static ConfigPhotoFrameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFrameById.CreateStaticDefaultValue), new Action(ConfigPhotoFrameById.ResetStaticDefaultValue));
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00142374 File Offset: 0x00140574
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFrameById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFrameById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFrame"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFrame` where Id=?")
			});
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x001423F3 File Offset: 0x001405F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFrameById.LogPair = null;
			ConfigPhotoFrameById.HandleId = 0;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00142401 File Offset: 0x00140601
		public static void Init()
		{
			ConfigPhotoFrameById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFrameById.HandleId, "db_photonew.db", "select BinData from `PhotoFrame` where Id=?");
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0014241C File Offset: 0x0014061C
		public static PhotoFrame? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFrame?(PhotoFrame.GetRootAsPhotoFrame(configBuffer));
				}
			}
			ConfigPhotoFrameById.LogPair.Clear();
			ConfigPhotoFrameById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFrameById.HandleId, 1, p0Id, ConfigPhotoFrameById.LogPair) || ConfigCommon.Step(ConfigPhotoFrameById.HandleId, true, ConfigPhotoFrameById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFrameById.HandleId, 0, ConfigPhotoFrameById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFrame rootAsPhotoFrame = PhotoFrame.GetRootAsPhotoFrame(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFrameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFrameById.HandleId, ConfigPhotoFrameById.LogPair);
			return new PhotoFrame?(rootAsPhotoFrame);
		}

		// Token: 0x04002FE3 RID: 12259
		private const string DB = "db_photonew.db";

		// Token: 0x04002FE4 RID: 12260
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002FE5 RID: 12261
		private const string TABLE = "PhotoFrame";

		// Token: 0x04002FE6 RID: 12262
		private const string COMMAND = "select BinData from `PhotoFrame` where Id=?";

		// Token: 0x04002FE7 RID: 12263
		private const string KEY_PREFIX = "PhotoFrameById";

		// Token: 0x04002FE8 RID: 12264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FE9 RID: 12265
		private static int HandleId;
	}
}
