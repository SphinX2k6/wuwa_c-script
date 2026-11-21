using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;
using CSharpScript.Game.Input.BattleInputData;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A9 RID: 13737
	[NullableContext(1)]
	[Nullable(0)]
	public class InputIdentification
	{
		// Token: 0x06023040 RID: 143424 RVA: 0x009F4F25 File Offset: 0x009F3125
		public InputIdentification(string name)
		{
			this.NameInternal = name;
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06023041 RID: 143425 RVA: 0x009F4F4A File Offset: 0x009F314A
		public string Name
		{
			get
			{
				return this.NameInternal;
			}
		}

		// Token: 0x06023042 RID: 143426 RVA: 0x009F4F54 File Offset: 0x009F3154
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

		// Token: 0x06023043 RID: 143427 RVA: 0x009F4FC4 File Offset: 0x009F31C4
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

		// Token: 0x04013BC9 RID: 80841
		private readonly string NameInternal;

		// Token: 0x04013BCA RID: 80842
		private EInputAction InputActionInternal = EInputAction.None;

		// Token: 0x04013BCB RID: 80843
		private EInputAxis InputAxisInternal = EInputAxis.None;
	}
}
