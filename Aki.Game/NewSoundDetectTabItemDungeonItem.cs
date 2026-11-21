using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;

// Token: 0x02000B58 RID: 2904
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectTabItemDungeonItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x06007939 RID: 31033 RVA: 0x002592E1 File Offset: 0x002574E1
	protected override void OnStart()
	{
		this.TargetDungeonItem = new NewSoundDetectItem();
		this.TargetDungeonItem.CreateThenShowByActor(this.RootItem.GetOwner());
		this.TargetDungeonItem.SyncStart();
	}

	// Token: 0x0600793A RID: 31034 RVA: 0x0025930F File Offset: 0x0025750F
	public override void Refresh(NewSoundDetectTabItemData data)
	{
		if (data.Dungeon != null)
		{
			NewSoundDetectItem targetDungeonItem = this.TargetDungeonItem;
			if (targetDungeonItem == null)
			{
				return;
			}
			targetDungeonItem.Refresh(data.Dungeon, false, 0);
		}
	}

	// Token: 0x04004B7A RID: 19322
	[Nullable(2)]
	private NewSoundDetectItem TargetDungeonItem;
}
