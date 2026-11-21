using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x020062FD RID: 25341
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorTreeSavedData
	{
		// Token: 0x0603D4B4 RID: 251060 RVA: 0x011B6010 File Offset: 0x011B4210
		public FBtSaveLoadRecordItem GetNextRecord()
		{
			if (!this.IsValid())
			{
				return null;
			}
			return this.BtRecord.Items.Get(this.UsableIndex);
		}

		// Token: 0x0603D4B5 RID: 251061 RVA: 0x011B6034 File Offset: 0x011B4234
		public FBtSaveLoadRecordItem ConsumeRecord()
		{
			if (!this.IsValid())
			{
				return null;
			}
			TArray<FBtSaveLoadRecordItem> items = this.BtRecord.Items;
			int usableIndex = this.UsableIndex;
			this.UsableIndex = usableIndex + 1;
			return items.Get(usableIndex);
		}

		// Token: 0x0603D4B6 RID: 251062 RVA: 0x011B606C File Offset: 0x011B426C
		public bool IsValid()
		{
			FBtSaveLoadRecord btRecord = this.BtRecord;
			int num = (btRecord != null) ? btRecord.Items.Num() : 0;
			return this.Path != "" && num != 0 && this.UsableIndex < num;
		}

		// Token: 0x0603D4B7 RID: 251063 RVA: 0x011B60B4 File Offset: 0x011B42B4
		[NullableContext(1)]
		public BehaviorTreeSavedData DeepCopy()
		{
			BehaviorTreeSavedData behaviorTreeSavedData = new BehaviorTreeSavedData();
			behaviorTreeSavedData.Path = this.Path;
			behaviorTreeSavedData.UsableIndex = this.UsableIndex;
			if (this.BtRecord != null)
			{
				behaviorTreeSavedData.BtRecord = new FBtSaveLoadRecord();
				int num = this.BtRecord.Items.Num();
				for (int i = 0; i < num; i++)
				{
					FBtSaveLoadRecordItem fbtSaveLoadRecordItem = new FBtSaveLoadRecordItem();
					FBtSaveLoadRecordItem fbtSaveLoadRecordItem2 = this.BtRecord.Items.Get(i);
					fbtSaveLoadRecordItem.RunBehaviorNodeId = fbtSaveLoadRecordItem2.RunBehaviorNodeId;
					int num2 = fbtSaveLoadRecordItem2.SavedNodeMap.Num();
					for (int j = 0; j < num2; j++)
					{
						int key = fbtSaveLoadRecordItem2.SavedNodeMap.GetKey(j);
						int value = fbtSaveLoadRecordItem2.SavedNodeMap.Get(key);
						fbtSaveLoadRecordItem.SavedNodeMap.Add(key, value);
					}
					behaviorTreeSavedData.BtRecord.Items.Add(fbtSaveLoadRecordItem);
				}
			}
			return behaviorTreeSavedData;
		}

		// Token: 0x04020832 RID: 133170
		[Nullable(1)]
		public string Path = "";

		// Token: 0x04020833 RID: 133171
		public FBtSaveLoadRecord BtRecord;

		// Token: 0x04020834 RID: 133172
		private int UsableIndex;
	}
}
