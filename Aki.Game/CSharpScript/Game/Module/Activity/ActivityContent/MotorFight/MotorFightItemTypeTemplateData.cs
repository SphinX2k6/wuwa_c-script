using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539E RID: 21406
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightItemTypeTemplateData : MultiTemplateGridDataBase<MotorFightItemType, MotorFightItemTypeItem>
	{
		// Token: 0x06035408 RID: 218120 RVA: 0x00EDFC34 File Offset: 0x00EDDE34
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06035409 RID: 218121 RVA: 0x00EDFC37 File Offset: 0x00EDDE37
		public override MotorFightItemTypeItem CreateProxy()
		{
			return new MotorFightItemTypeItem
			{
				GetUnlockNum = this.GetUnlockNum
			};
		}

		// Token: 0x0401C159 RID: 115033
		public Func<int, Tuple<int, int>> GetUnlockNum = (int type) => new Tuple<int, int>(0, 0);
	}
}
