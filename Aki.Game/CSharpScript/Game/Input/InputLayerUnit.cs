using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006150 RID: 24912
	[NullableContext(1)]
	[Nullable(0)]
	public class InputLayerUnit
	{
		// Token: 0x0603BB82 RID: 244610 RVA: 0x010F3C90 File Offset: 0x010F1E90
		public void Add(InputLayer layer)
		{
			EInputLayer layerType = layer.GetLayerType();
			InputLayer inputLayer;
			if (this.LayerMap.TryGetValue(layerType, out inputLayer))
			{
				inputLayer.Clear();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "[InputLayerUnit]添加的InputLayer类型已存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LayerType", layerType);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.LayerMap[layerType] = layer;
			this.Sort();
		}

		// Token: 0x0603BB83 RID: 244611 RVA: 0x010F3CFC File Offset: 0x010F1EFC
		public void Remove(InputLayer layer)
		{
			EInputLayer layerType = layer.GetLayerType();
			if (this.LayerMap.ContainsKey(layerType))
			{
				this.LayerMap.Remove(layerType);
				this.Sort();
			}
		}

		// Token: 0x0603BB84 RID: 244612 RVA: 0x010F3D34 File Offset: 0x010F1F34
		public void Sort()
		{
			this.LayerList = new List<InputLayer>(this.LayerMap.Values);
			this.LayerList.Sort((InputLayer a, InputLayer b) => b.GetLayerType() - a.GetLayerType());
		}

		// Token: 0x0603BB85 RID: 244613 RVA: 0x010F3D84 File Offset: 0x010F1F84
		public void Clear()
		{
			foreach (InputLayer inputLayer in this.LayerMap.Values)
			{
				inputLayer.Clear();
			}
			this.LayerMap.Clear();
		}

		// Token: 0x0603BB86 RID: 244614 RVA: 0x010F3DE4 File Offset: 0x010F1FE4
		public List<InputLayer> GetLayerList()
		{
			return this.LayerList;
		}

		// Token: 0x0401F81E RID: 129054
		public readonly Dictionary<EInputLayer, InputLayer> LayerMap = new Dictionary<EInputLayer, InputLayer>();

		// Token: 0x0401F81F RID: 129055
		private List<InputLayer> LayerList = new List<InputLayer>();
	}
}
