using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FCF RID: 28623
	[NullableContext(1)]
	[Nullable(0)]
	public class InputLayerUnit
	{
		// Token: 0x060459D1 RID: 285137 RVA: 0x01149E9C File Offset: 0x0114809C
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

		// Token: 0x060459D2 RID: 285138 RVA: 0x01149F08 File Offset: 0x01148108
		public void Remove(InputLayer layer)
		{
			EInputLayer layerType = layer.GetLayerType();
			if (this.LayerMap.ContainsKey(layerType))
			{
				this.LayerMap.Remove(layerType);
				this.Sort();
			}
		}

		// Token: 0x060459D3 RID: 285139 RVA: 0x01149F40 File Offset: 0x01148140
		public void Sort()
		{
			this.LayerList = new List<InputLayer>(this.LayerMap.Values);
			this.LayerList.Sort((InputLayer a, InputLayer b) => b.GetLayerType() - a.GetLayerType());
		}

		// Token: 0x060459D4 RID: 285140 RVA: 0x01149F90 File Offset: 0x01148190
		public void Clear()
		{
			foreach (InputLayer inputLayer in this.LayerMap.Values)
			{
				inputLayer.Clear();
			}
			this.LayerMap.Clear();
		}

		// Token: 0x060459D5 RID: 285141 RVA: 0x01149FF0 File Offset: 0x011481F0
		public List<InputLayer> GetLayerList()
		{
			return this.LayerList;
		}

		// Token: 0x04024569 RID: 148841
		public readonly Dictionary<EInputLayer, InputLayer> LayerMap = new Dictionary<EInputLayer, InputLayer>();

		// Token: 0x0402456A RID: 148842
		private List<InputLayer> LayerList = new List<InputLayer>();
	}
}
