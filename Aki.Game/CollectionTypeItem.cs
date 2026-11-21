using System;
using System.Collections.Generic;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200118E RID: 4494
public class CollectionTypeItem : SyncGridProxyAbstract<MotorFightItemType>
{
	// Token: 0x0600B348 RID: 45896 RVA: 0x0034FD34 File Offset: 0x0034DF34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600B349 RID: 45897 RVA: 0x0034FD70 File Offset: 0x0034DF70
	public override void Refresh(MotorFightItemType data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		this.SetSpriteByPath(data.Icon, base.GetSprite(1), false, null, null);
	}

	// Token: 0x02007456 RID: 29782
	private static class EComponents
	{
		// Token: 0x04025DD7 RID: 155095
		public const int TextTypeName = 0;

		// Token: 0x04025DD8 RID: 155096
		public const int SpriteIcon = 1;
	}
}
