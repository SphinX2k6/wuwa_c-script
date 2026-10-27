using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x02007098 RID: 28824
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorTreeSavedData
	{
		// Token: 0x060463C9 RID: 287689 RVA: 0x01192F04 File Offset: 0x01191104
		public FBtSaveLoadRecordItem GetNextRecord()
		{
			if (!this.IsValid())
			{
				return null;
			}
			return this.BtRecord.Items.Get(this.UsableIndex);
		}

		// Token: 0x060463CA RID: 287690 RVA: 0x01192F28 File Offset: 0x01191128
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

		// Token: 0x060463CB RID: 287691 RVA: 0x01192F60 File Offset: 0x01191160
		public bool IsValid()
		{
			FBtSaveLoadRecord btRecord = this.BtRecord;
			int num = (btRecord != null) ? btRecord.Items.Num() : 0;
			return this.Path != "" && num != 0 && this.UsableIndex < num;
		}

		// Token: 0x060463CC RID: 287692 RVA: 0x01192FA8 File Offset: 0x011911A8
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

		// Token: 0x04024CE0 RID: 150752
		[Nullable(1)]
		public string Path = "";

		// Token: 0x04024CE1 RID: 150753
		public FBtSaveLoadRecord BtRecord;

		// Token: 0x04024CE2 RID: 150754
		private int UsableIndex;
	}
}
