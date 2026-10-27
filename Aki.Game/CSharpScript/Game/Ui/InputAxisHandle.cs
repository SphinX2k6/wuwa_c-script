using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004673 RID: 18035
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisHandle : InputDistributeHandle<float>
	{
		// Token: 0x0602E8A0 RID: 190624 RVA: 0x00AC64C2 File Offset: 0x00AC46C2
		public InputAxisHandle(string inputDistributeTag, string name) : base(inputDistributeTag, name)
		{
		}

		// Token: 0x0602E8A1 RID: 190625 RVA: 0x00AC64CC File Offset: 0x00AC46CC
		public void BindAxis(TInputHandle<float> axisCallback)
		{
			base.Bind(axisCallback);
		}

		// Token: 0x0602E8A2 RID: 190626 RVA: 0x00AC64D5 File Offset: 0x00AC46D5
		public void UnBindAxis(TInputHandle<float> axisCallback)
		{
			base.UnBind(axisCallback);
		}

		// Token: 0x0602E8A3 RID: 190627 RVA: 0x00AC64DE File Offset: 0x00AC46DE
		public void BindAxisIgnoreLimit(TInputHandle<float> axisCallback)
		{
			base.BindIgnoreLimit(axisCallback);
		}

		// Token: 0x0602E8A4 RID: 190628 RVA: 0x00AC64E7 File Offset: 0x00AC46E7
		public void UnBindAxisIgnoreLimit(TInputHandle<float> axisCallback)
		{
			base.UnBindIgnoreLimit(axisCallback);
		}

		// Token: 0x0602E8A5 RID: 190629 RVA: 0x00AC64F0 File Offset: 0x00AC46F0
		public void InputAxis(float value)
		{
			this.InputCacheAxisValue(value);
			base.Call(value);
		}

		// Token: 0x0602E8A6 RID: 190630 RVA: 0x00AC6500 File Offset: 0x00AC4700
		public void InputAxisIgnoreLimit(float value)
		{
			this.InputCacheAxisValueIgnoreLimit(value);
			base.CallIgnoreLimit(value);
		}

		// Token: 0x0602E8A7 RID: 190631 RVA: 0x00AC6510 File Offset: 0x00AC4710
		public void InputCacheAxisValue(float value)
		{
			this.CacheAxisValue = value;
		}

		// Token: 0x0602E8A8 RID: 190632 RVA: 0x00AC6519 File Offset: 0x00AC4719
		public void InputCacheAxisValueIgnoreLimit(float value)
		{
			this.CacheAxisValueIgnoreLimit = value;
		}

		// Token: 0x0602E8A9 RID: 190633 RVA: 0x00AC6522 File Offset: 0x00AC4722
		public float GetCacheAxisValue()
		{
			return this.CacheAxisValue;
		}

		// Token: 0x0602E8AA RID: 190634 RVA: 0x00AC652A File Offset: 0x00AC472A
		public float GetCacheAxisValueIgnoreLimit()
		{
			return this.CacheAxisValueIgnoreLimit;
		}

		// Token: 0x04019516 RID: 103702
		private float CacheAxisValue;

		// Token: 0x04019517 RID: 103703
		private float CacheAxisValueIgnoreLimit;
	}
}
