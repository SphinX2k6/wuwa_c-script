using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006420 RID: 25632
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightItemTypeTemplateData : MultiTemplateGridDataBase<MotorFightItemType, MotorFightItemTypeItem>
	{
		// Token: 0x06040747 RID: 264007 RVA: 0x00F98C94 File Offset: 0x00F96E94
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06040748 RID: 264008 RVA: 0x00F98C97 File Offset: 0x00F96E97
		public override MotorFightItemTypeItem CreateProxy()
		{
			return new MotorFightItemTypeItem
			{
				GetUnlockNum = this.GetUnlockNum
			};
		}

		// Token: 0x0402182A RID: 137258
		public Func<int, Tuple<int, int>> GetUnlockNum = (int type) => new Tuple<int, int>(0, 0);
	}
}
