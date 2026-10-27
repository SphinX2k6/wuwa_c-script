using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;

// Token: 0x020016A0 RID: 5792
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectTabItemDungeonItem : SyncGridProxyAbstract<NewSoundDetectTabItemData>
{
	// Token: 0x0600A559 RID: 42329 RVA: 0x0024EEC5 File Offset: 0x0024D0C5
	protected override void OnStart()
	{
		this.TargetDungeonItem = new NewSoundDetectItem();
		this.TargetDungeonItem.CreateThenShowByActor(this.RootItem.GetOwner());
		this.TargetDungeonItem.SyncStart();
	}

	// Token: 0x0600A55A RID: 42330 RVA: 0x0024EEF3 File Offset: 0x0024D0F3
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

	// Token: 0x04004AD3 RID: 19155
	[Nullable(2)]
	private NewSoundDetectItem TargetDungeonItem;
}
