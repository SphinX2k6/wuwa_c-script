using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A4 RID: 13732
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisHandle : InputDistributeHandle<float>
	{
		// Token: 0x06022FEA RID: 143338 RVA: 0x009F4022 File Offset: 0x009F2222
		public InputAxisHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x06022FEB RID: 143339 RVA: 0x009F402C File Offset: 0x009F222C
		public void BindAxis(TInputHandle<float> axisCallback)
		{
			base.Bind(axisCallback);
		}

		// Token: 0x06022FEC RID: 143340 RVA: 0x009F4035 File Offset: 0x009F2235
		public void UnBindAxis(TInputHandle<float> axisCallback)
		{
			base.UnBind(axisCallback);
		}

		// Token: 0x06022FED RID: 143341 RVA: 0x009F403E File Offset: 0x009F223E
		public void BindAxisIgnoreLimit(TInputHandle<float> axisCallback)
		{
			base.BindIgnoreLimit(axisCallback);
		}

		// Token: 0x06022FEE RID: 143342 RVA: 0x009F4047 File Offset: 0x009F2247
		public void UnBindAxisIgnoreLimit(TInputHandle<float> axisCallback)
		{
			base.UnBindIgnoreLimit(axisCallback);
		}

		// Token: 0x06022FEF RID: 143343 RVA: 0x009F4050 File Offset: 0x009F2250
		public void InputAxis(float value)
		{
			this.InputCacheAxisValue(value);
			base.Call(value);
		}

		// Token: 0x06022FF0 RID: 143344 RVA: 0x009F4060 File Offset: 0x009F2260
		public void InputAxisIgnoreLimit(float value)
		{
			this.InputCacheAxisValueIgnoreLimit(value);
			base.CallIgnoreLimit(value);
		}

		// Token: 0x06022FF1 RID: 143345 RVA: 0x009F4070 File Offset: 0x009F2270
		public void InputCacheAxisValue(float value)
		{
			this.CacheAxisValue = value;
		}

		// Token: 0x06022FF2 RID: 143346 RVA: 0x009F4079 File Offset: 0x009F2279
		public void InputCacheAxisValueIgnoreLimit(float value)
		{
			this.CacheAxisValueIgnoreLimit = value;
		}

		// Token: 0x06022FF3 RID: 143347 RVA: 0x009F4082 File Offset: 0x009F2282
		public float GetCacheAxisValue()
		{
			return this.CacheAxisValue;
		}

		// Token: 0x06022FF4 RID: 143348 RVA: 0x009F408A File Offset: 0x009F228A
		public float GetCacheAxisValueIgnoreLimit()
		{
			return this.CacheAxisValueIgnoreLimit;
		}

		// Token: 0x04013BBD RID: 80829
		private float CacheAxisValue;

		// Token: 0x04013BBE RID: 80830
		private float CacheAxisValueIgnoreLimit;
	}
}
