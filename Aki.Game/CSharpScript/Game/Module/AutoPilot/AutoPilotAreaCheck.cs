using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay.BinTest;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E68 RID: 24168
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotAreaCheck
	{
		// Token: 0x0603D726 RID: 251686 RVA: 0x00ED2F7C File Offset: 0x00ED117C
		public void Init()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("AutoPilotAreas");
			if (intArrayConfig == null || intArrayConfig.Count == 0)
			{
				Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "AutoPilotAreas为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			using (IEnumerator<int> enumerator = intArrayConfig.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int areaId = enumerator.Current;
					Area? config = ConfigAreaByAreaId.GetConfig(areaId, true);
					if (config != null && !StringUtils.IsEmpty(config.Value.EdgeWallName))
					{
						string filePath = config.Value.EdgeWallName + "_C";
						int mapId = config.Value.MapConfigId;
						BinItem newBinItem = new BinItem();
						newBinItem.MapId = mapId;
						newBinItem.InitCallback = delegate()
						{
							if (newBinItem == null || newBinItem.BinSet == null || newBinItem.TestPoints == null)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.AutoPilot;
								ELogAuthor author = ELogAuthor.CB;
								string message = "BinMap添加边界出错";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", filePath);
								instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
								return;
							}
							Dictionary<int, BinItem> dictionary;
							this.BinMap.TryGetValue(mapId, out dictionary);
							if (dictionary == null)
							{
								dictionary = new Dictionary<int, BinItem>();
								this.BinMap[mapId] = dictionary;
							}
							dictionary[areaId] = newBinItem;
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.AutoPilot;
							ELogAuthor author2 = ELogAuthor.CB;
							string message2 = "BinMap添加边界";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", filePath);
							instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						};
						newBinItem.Init(filePath);
					}
				}
			}
		}

		// Token: 0x0603D727 RID: 251687 RVA: 0x00ED30B8 File Offset: 0x00ED12B8
		public int BinTest(global::Vector inputP, int mapId)
		{
			Dictionary<int, BinItem> dictionary2;
			Dictionary<int, BinItem> dictionary = this.BinMap.TryGetValue(mapId, out dictionary2) ? dictionary2 : null;
			if (dictionary == null)
			{
				return 0;
			}
			foreach (KeyValuePair<int, BinItem> keyValuePair in dictionary)
			{
				int num;
				BinItem binItem;
				keyValuePair.Deconstruct(out num, out binItem);
				int result = num;
				if (binItem.BinTest(inputP))
				{
					return result;
				}
			}
			return 0;
		}

		// Token: 0x0603D728 RID: 251688 RVA: 0x00ED313C File Offset: 0x00ED133C
		public void Clear()
		{
			this.BinMap.Clear();
		}

		// Token: 0x04020106 RID: 131334
		private readonly Dictionary<int, Dictionary<int, BinItem>> BinMap = new Dictionary<int, Dictionary<int, BinItem>>();
	}
}
