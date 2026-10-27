using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001CCC RID: 7372
public class CollectionTypeItem : SyncGridProxyAbstract<MotorFightItemType>
{
	// Token: 0x0600DF2B RID: 57131 RVA: 0x0034430C File Offset: 0x0034250C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600DF2C RID: 57132 RVA: 0x00344348 File Offset: 0x00342548
	public override void Refresh(MotorFightItemType data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
	}

	// Token: 0x020082CD RID: 33485
	private static class EComponents
	{
		// Token: 0x0402AAAF RID: 174767
		public const int TextTypeName = 0;

		// Token: 0x0402AAB0 RID: 174768
		public const int SpriteIcon = 1;
	}
}
