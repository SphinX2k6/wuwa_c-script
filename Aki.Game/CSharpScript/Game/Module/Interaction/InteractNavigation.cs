using System;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200585F RID: 22623
	public class InteractNavigation
	{
		// Token: 0x0603984F RID: 235599 RVA: 0x00DA81A8 File Offset: 0x00DA63A8
		public unsafe InteractNavigation(float lookUpThreshold, float zoomThreshold, bool allowLoop)
		{
			if (lookUpThreshold < 0f || zoomThreshold < 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "设置lookUp阈值和zoomThreshold阈值错误!";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("lookUpThreshold", lookUpThreshold);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("zoomThreshold", zoomThreshold);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.LookUpThreshold = lookUpThreshold;
			this.ZoomThreshold = zoomThreshold;
			this.AllowLoop = allowLoop;
		}

		// Token: 0x17008A58 RID: 35416
		// (get) Token: 0x06039850 RID: 235600 RVA: 0x00DA823F File Offset: 0x00DA643F
		// (set) Token: 0x06039851 RID: 235601 RVA: 0x00DA8247 File Offset: 0x00DA6447
		public int Index
		{
			get
			{
				return this.IndexInternal;
			}
			set
			{
				this.IndexInternal = value;
			}
		}

		// Token: 0x17008A59 RID: 35417
		// (get) Token: 0x06039852 RID: 235602 RVA: 0x00DA8250 File Offset: 0x00DA6450
		public int TotalNum
		{
			get
			{
				return this.TotalNumInternal;
			}
		}

		// Token: 0x06039853 RID: 235603 RVA: 0x00DA8258 File Offset: 0x00DA6458
		public bool UpdateValue(EInputAxis axisType, float value, int? totalNum = null)
		{
			int indexInternal = this.IndexInternal;
			if (this.IndexInternal != 0)
			{
				if (axisType == EInputAxis.LookUp)
				{
					if (this.LookUpValue * value < 0f)
					{
						this.LookUpValue = 0f;
					}
					this.LookUpValue += value;
					if (Math.Abs(this.LookUpValue) >= this.LookUpThreshold)
					{
						int num = ((value > 0f) ? 1 : -1) * (int)Math.Floor((double)Math.Abs(this.LookUpValue / this.LookUpThreshold));
						this.LookUpValue -= this.LookUpThreshold * (float)num;
						this.IndexInternal += num;
					}
				}
				else if (axisType == EInputAxis.Zoom)
				{
					float num2 = -value;
					if (this.ZoomValue * num2 < 0f)
					{
						this.ZoomValue = 0f;
					}
					this.ZoomValue += num2;
					if (Math.Abs(this.ZoomValue) >= this.ZoomThreshold)
					{
						int num3 = ((num2 > 0f) ? 1 : -1) * (int)Math.Floor((double)Math.Abs(this.ZoomValue / this.ZoomThreshold));
						this.ZoomValue -= this.ZoomThreshold * (float)num3;
						this.IndexInternal += num3;
					}
				}
			}
			else
			{
				this.IndexInternal = 0;
			}
			this.UpdateIndexInternal(totalNum);
			return this.IndexInternal != indexInternal;
		}

		// Token: 0x06039854 RID: 235604 RVA: 0x00DA83CC File Offset: 0x00DA65CC
		public bool UpdateIndex(int totalNum)
		{
			int indexInternal = this.IndexInternal;
			this.UpdateIndexInternal(new int?(totalNum));
			return this.IndexInternal != indexInternal;
		}

		// Token: 0x06039855 RID: 235605 RVA: 0x00DA83F8 File Offset: 0x00DA65F8
		private void UpdateIndexInternal(int? totalNum)
		{
			if (totalNum != null)
			{
				this.TotalNumInternal = totalNum.Value;
			}
			if (this.TotalNumInternal == 0)
			{
				return;
			}
			if (this.IndexInternal < 0 || this.IndexInternal >= this.TotalNumInternal)
			{
				if (!this.AllowLoop)
				{
					this.IndexInternal = Math.Max(0, Math.Min(this.IndexInternal, this.TotalNumInternal - 1));
					return;
				}
				this.IndexInternal %= this.TotalNumInternal;
				if (this.IndexInternal < 0)
				{
					this.IndexInternal = this.TotalNumInternal + this.IndexInternal;
				}
			}
		}

		// Token: 0x0401E132 RID: 123186
		private int TotalNumInternal;

		// Token: 0x0401E133 RID: 123187
		private int IndexInternal;

		// Token: 0x0401E134 RID: 123188
		private float LookUpValue;

		// Token: 0x0401E135 RID: 123189
		private float ZoomValue;

		// Token: 0x0401E136 RID: 123190
		private readonly float LookUpThreshold;

		// Token: 0x0401E137 RID: 123191
		private readonly float ZoomThreshold;

		// Token: 0x0401E138 RID: 123192
		private readonly bool AllowLoop;
	}
}
