using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060D8 RID: 24792
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionData
	{
		// Token: 0x0603EAAF RID: 256687 RVA: 0x00F22BD8 File Offset: 0x00F20DD8
		public unsafe void SetChooseData(RoverRogueChooseData proto)
		{
			int bindId = proto.BindId;
			RoverlikeChooseData roverlikeChooseData;
			this.ChooseDataMap.TryGetValue(bindId, out roverlikeChooseData);
			RoverlikeChooseData roverlikeChooseData2 = new RoverlikeChooseData(proto);
			if (roverlikeChooseData != null)
			{
				roverlikeChooseData2.SubViewIncId = roverlikeChooseData.SubViewIncId;
				int num = -1;
				for (int i = 0; i < this.ChooseDataQueue.Count; i++)
				{
					if (this.ChooseDataQueue[i].BindId == bindId)
					{
						num = i;
						break;
					}
				}
				if (num != -1)
				{
					this.ChooseDataQueue[num] = roverlikeChooseData2;
				}
				this.ChooseDataMap[bindId] = roverlikeChooseData2;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] 更新ChooseData";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BindId", bindId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				RoverlikeController.Instance.UpdateActionSubView(roverlikeChooseData2.SubViewIncId);
				return;
			}
			this.ChooseDataQueue.Add(roverlikeChooseData2);
			this.ChooseDataMap[bindId] = roverlikeChooseData2;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Roverlike;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[俯视角肉鸽] 新增ChooseData";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", this.ChooseDataQueue.Count - 1);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BindId", bindId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			ERoverActionSubViewType type = RoverlikeActionSubViewFactory.ServerTypeToSubViewType(roverlikeChooseData2.Type);
			int subViewIncId = RoverlikeController.Instance.OpenActionSubView(type, roverlikeChooseData2.BindId);
			roverlikeChooseData2.SubViewIncId = subViewIncId;
		}

		// Token: 0x0603EAB0 RID: 256688 RVA: 0x00F22D60 File Offset: 0x00F20F60
		public unsafe void RemoveChooseData(int bindId)
		{
			RoverlikeChooseData roverlikeChooseData;
			if (!this.ChooseDataMap.TryGetValue(bindId, out roverlikeChooseData))
			{
				return;
			}
			roverlikeChooseData.IsSelect = true;
			if (roverlikeChooseData.SubViewIncId > 0)
			{
				RoverlikeController.Instance.FinishActionSubView(roverlikeChooseData.SubViewIncId);
			}
			int num = -1;
			for (int i = 0; i < this.ChooseDataQueue.Count; i++)
			{
				if (this.ChooseDataQueue[i].BindId == bindId)
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				this.ChooseDataQueue.RemoveAt(num);
			}
			this.ChooseDataMap.Remove(bindId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roverlike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[俯视角肉鸽] 删除ChooseData";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BindId", bindId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603EAB1 RID: 256689 RVA: 0x00F22E4C File Offset: 0x00F2104C
		[NullableContext(2)]
		public RoverlikeChooseData GetChooseDataByBindId(int bindId)
		{
			RoverlikeChooseData result;
			if (this.ChooseDataMap.TryGetValue(bindId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603EAB2 RID: 256690 RVA: 0x00F22E6C File Offset: 0x00F2106C
		public List<RoverlikeChooseData> GetAllChooseData()
		{
			return new List<RoverlikeChooseData>(this.ChooseDataQueue);
		}

		// Token: 0x0603EAB3 RID: 256691 RVA: 0x00F22E79 File Offset: 0x00F21079
		[NullableContext(2)]
		public RoverlikeChooseData GetCurrentChooseData()
		{
			if (this.ChooseDataQueue.Count == 0)
			{
				return null;
			}
			return this.ChooseDataQueue[this.ChooseDataQueue.Count - 1];
		}

		// Token: 0x0603EAB4 RID: 256692 RVA: 0x00F22EA4 File Offset: 0x00F210A4
		public bool IsCurrentChooseData(int bindId)
		{
			RoverlikeChooseData currentChooseData = this.GetCurrentChooseData();
			return currentChooseData != null && currentChooseData.BindId == bindId;
		}

		// Token: 0x0603EAB5 RID: 256693 RVA: 0x00F22EC6 File Offset: 0x00F210C6
		public void Clear()
		{
			this.ChooseDataQueue.Clear();
			this.ChooseDataMap.Clear();
			this.ObtainParamQueue.Clear();
		}

		// Token: 0x0603EAB6 RID: 256694 RVA: 0x00F22EE9 File Offset: 0x00F210E9
		public void PushObtainParam(IRoverlikeGeneralObtainParam param)
		{
			this.ObtainParamQueue.Add(param);
		}

		// Token: 0x0603EAB7 RID: 256695 RVA: 0x00F22EF7 File Offset: 0x00F210F7
		[NullableContext(2)]
		public IRoverlikeGeneralObtainParam PopObtainParam()
		{
			if (this.ObtainParamQueue.Count == 0)
			{
				return null;
			}
			IRoverlikeGeneralObtainParam result = this.ObtainParamQueue[0];
			this.ObtainParamQueue.RemoveAt(0);
			return result;
		}

		// Token: 0x0603EAB8 RID: 256696 RVA: 0x00F22F20 File Offset: 0x00F21120
		public bool HasObtainParam()
		{
			return this.ObtainParamQueue.Count > 0;
		}

		// Token: 0x04020C32 RID: 134194
		private readonly List<RoverlikeChooseData> ChooseDataQueue = new List<RoverlikeChooseData>();

		// Token: 0x04020C33 RID: 134195
		private readonly Dictionary<int, RoverlikeChooseData> ChooseDataMap = new Dictionary<int, RoverlikeChooseData>();

		// Token: 0x04020C34 RID: 134196
		private readonly List<IRoverlikeGeneralObtainParam> ObtainParamQueue = new List<IRoverlikeGeneralObtainParam>();
	}
}
