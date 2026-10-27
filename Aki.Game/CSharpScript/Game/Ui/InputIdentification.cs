using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Input.BattleInputData;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004678 RID: 18040
	[NullableContext(1)]
	[Nullable(0)]
	public class InputIdentification
	{
		// Token: 0x0602E8F6 RID: 190710 RVA: 0x00AC73C5 File Offset: 0x00AC55C5
		public InputIdentification(string name)
		{
			this.NameInternal = name;
		}

		// Token: 0x1700762E RID: 30254
		// (get) Token: 0x0602E8F7 RID: 190711 RVA: 0x00AC73EA File Offset: 0x00AC55EA
		public string Name
		{
			get
			{
				return this.NameInternal;
			}
		}

		// Token: 0x0602E8F8 RID: 190712 RVA: 0x00AC73F4 File Offset: 0x00AC55F4
		[NullableContext(2)]
		public EInputAction? GetInputAction(BattleInputData inputData)
		{
			if (this.InputActionInternal != EInputAction.None)
			{
				return new EInputAction?(this.InputActionInternal);
			}
			if (inputData == null)
			{
				return null;
			}
			EInputAction? action = inputData.GetAction(this.NameInternal);
			if (action == null)
			{
				return null;
			}
			this.InputActionInternal = action.Value;
			return new EInputAction?(this.InputActionInternal);
		}

		// Token: 0x0602E8F9 RID: 190713 RVA: 0x00AC7464 File Offset: 0x00AC5664
		[NullableContext(2)]
		public EInputAxis? GetInputAxis(BattleInputData inputData)
		{
			if (this.InputAxisInternal != EInputAxis.None)
			{
				return new EInputAxis?(this.InputAxisInternal);
			}
			if (inputData == null)
			{
				return null;
			}
			EInputAxis? axis = inputData.GetAxis(this.NameInternal);
			if (axis == null)
			{
				return null;
			}
			this.InputAxisInternal = axis.Value;
			return new EInputAxis?(this.InputAxisInternal);
		}

		// Token: 0x04019522 RID: 103714
		private readonly string NameInternal;

		// Token: 0x04019523 RID: 103715
		private EInputAction InputActionInternal = EInputAction.None;

		// Token: 0x04019524 RID: 103716
		private EInputAxis InputAxisInternal = EInputAxis.None;
	}
}
