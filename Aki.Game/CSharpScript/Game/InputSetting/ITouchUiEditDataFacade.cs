using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200701A RID: 28698
	[NullableContext(1)]
	public interface ITouchUiEditDataFacade
	{
		// Token: 0x06045D89 RID: 286089
		void Init();

		// Token: 0x06045D8A RID: 286090
		CommonTouchUiEditGroup? GetGroupConfig();

		// Token: 0x06045D8B RID: 286091
		string[] GetResIdList();

		// Token: 0x06045D8C RID: 286092
		int GetStorageId(string resId, int index);

		// Token: 0x06045D8D RID: 286093
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		ValueTuple<string, int>? GetResPair(int storageId);

		// Token: 0x06045D8E RID: 286094
		[return: Nullable(2)]
		ITouchUiEditData GetDefaultData(string resId, int index);

		// Token: 0x06045D8F RID: 286095
		void SaveData(ITouchUiEditData[] dataList);

		// Token: 0x06045D90 RID: 286096
		[return: Nullable(2)]
		ITouchUiEditData GetData(string resId, int index);

		// Token: 0x06045D91 RID: 286097
		void Clear();

		// Token: 0x06045D92 RID: 286098
		void ResetEditData();

		// Token: 0x17009BB8 RID: 39864
		// (get) Token: 0x06045D93 RID: 286099
		int MinTouchMoveDifference { get; }

		// Token: 0x17009BB9 RID: 39865
		// (get) Token: 0x06045D94 RID: 286100
		int MaxTouchMoveDifference { get; }

		// Token: 0x17009BBA RID: 39866
		// (get) Token: 0x06045D95 RID: 286101
		float MaxTouchMoveValue { get; }

		// Token: 0x17009BBB RID: 39867
		// (get) Token: 0x06045D96 RID: 286102
		float MinTouchMoveValue { get; }

		// Token: 0x17009BBC RID: 39868
		// (get) Token: 0x06045D97 RID: 286103
		float ControlScaleRate { get; }
	}
}
