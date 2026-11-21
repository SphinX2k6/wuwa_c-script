using System;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004837 RID: 18487
	public class InteractNavigation
	{
		// Token: 0x0602E76C RID: 190316 RVA: 0x00CF6ED0 File Offset: 0x00CF50D0
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

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x0602E76D RID: 190317 RVA: 0x00CF6F67 File Offset: 0x00CF5167
		// (set) Token: 0x0602E76E RID: 190318 RVA: 0x00CF6F6F File Offset: 0x00CF516F
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

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x0602E76F RID: 190319 RVA: 0x00CF6F78 File Offset: 0x00CF5178
		public int TotalNum
		{
			get
			{
				return this.TotalNumInternal;
			}
		}

		// Token: 0x0602E770 RID: 190320 RVA: 0x00CF6F80 File Offset: 0x00CF5180
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

		// Token: 0x0602E771 RID: 190321 RVA: 0x00CF70F4 File Offset: 0x00CF52F4
		public bool UpdateIndex(int totalNum)
		{
			int indexInternal = this.IndexInternal;
			this.UpdateIndexInternal(new int?(totalNum));
			return this.IndexInternal != indexInternal;
		}

		// Token: 0x0602E772 RID: 190322 RVA: 0x00CF7120 File Offset: 0x00CF5320
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

		// Token: 0x04018BCF RID: 101327
		private int TotalNumInternal;

		// Token: 0x04018BD0 RID: 101328
		private int IndexInternal;

		// Token: 0x04018BD1 RID: 101329
		private float LookUpValue;

		// Token: 0x04018BD2 RID: 101330
		private float ZoomValue;

		// Token: 0x04018BD3 RID: 101331
		private readonly float LookUpThreshold;

		// Token: 0x04018BD4 RID: 101332
		private readonly float ZoomThreshold;

		// Token: 0x04018BD5 RID: 101333
		private readonly bool AllowLoop;
	}
}
