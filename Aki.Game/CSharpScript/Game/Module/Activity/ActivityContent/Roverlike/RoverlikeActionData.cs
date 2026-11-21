using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005056 RID: 20566
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionData
	{
		// Token: 0x06033773 RID: 210803 RVA: 0x00E699A0 File Offset: 0x00E67BA0
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

		// Token: 0x06033774 RID: 210804 RVA: 0x00E69B28 File Offset: 0x00E67D28
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

		// Token: 0x06033775 RID: 210805 RVA: 0x00E69C14 File Offset: 0x00E67E14
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

		// Token: 0x06033776 RID: 210806 RVA: 0x00E69C34 File Offset: 0x00E67E34
		public List<RoverlikeChooseData> GetAllChooseData()
		{
			return new List<RoverlikeChooseData>(this.ChooseDataQueue);
		}

		// Token: 0x06033777 RID: 210807 RVA: 0x00E69C41 File Offset: 0x00E67E41
		[NullableContext(2)]
		public RoverlikeChooseData GetCurrentChooseData()
		{
			if (this.ChooseDataQueue.Count == 0)
			{
				return null;
			}
			return this.ChooseDataQueue[this.ChooseDataQueue.Count - 1];
		}

		// Token: 0x06033778 RID: 210808 RVA: 0x00E69C6C File Offset: 0x00E67E6C
		public bool IsCurrentChooseData(int bindId)
		{
			RoverlikeChooseData currentChooseData = this.GetCurrentChooseData();
			return currentChooseData != null && currentChooseData.BindId == bindId;
		}

		// Token: 0x06033779 RID: 210809 RVA: 0x00E69C8E File Offset: 0x00E67E8E
		public void Clear()
		{
			this.ChooseDataQueue.Clear();
			this.ChooseDataMap.Clear();
			this.ObtainParamQueue.Clear();
		}

		// Token: 0x0603377A RID: 210810 RVA: 0x00E69CB1 File Offset: 0x00E67EB1
		public void PushObtainParam(IRoverlikeGeneralObtainParam param)
		{
			this.ObtainParamQueue.Add(param);
		}

		// Token: 0x0603377B RID: 210811 RVA: 0x00E69CBF File Offset: 0x00E67EBF
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

		// Token: 0x0603377C RID: 210812 RVA: 0x00E69CE8 File Offset: 0x00E67EE8
		public bool HasObtainParam()
		{
			return this.ObtainParamQueue.Count > 0;
		}

		// Token: 0x0401B55F RID: 111967
		private readonly List<RoverlikeChooseData> ChooseDataQueue = new List<RoverlikeChooseData>();

		// Token: 0x0401B560 RID: 111968
		private readonly Dictionary<int, RoverlikeChooseData> ChooseDataMap = new Dictionary<int, RoverlikeChooseData>();

		// Token: 0x0401B561 RID: 111969
		private readonly List<IRoverlikeGeneralObtainParam> ObtainParamQueue = new List<IRoverlikeGeneralObtainParam>();
	}
}
