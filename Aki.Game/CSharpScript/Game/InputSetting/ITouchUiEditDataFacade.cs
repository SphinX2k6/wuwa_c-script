using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200619B RID: 24987
	[NullableContext(1)]
	public interface ITouchUiEditDataFacade
	{
		// Token: 0x0603BF3F RID: 245567
		void Init();

		// Token: 0x0603BF40 RID: 245568
		CommonTouchUiEditGroup? GetGroupConfig();

		// Token: 0x0603BF41 RID: 245569
		string[] GetResIdList();

		// Token: 0x0603BF42 RID: 245570
		int GetStorageId(string resId, int index);

		// Token: 0x0603BF43 RID: 245571
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		ValueTuple<string, int>? GetResPair(int storageId);

		// Token: 0x0603BF44 RID: 245572
		[return: Nullable(2)]
		ITouchUiEditData GetDefaultData(string resId, int index);

		// Token: 0x0603BF45 RID: 245573
		void SaveData(ITouchUiEditData[] dataList);

		// Token: 0x0603BF46 RID: 245574
		[return: Nullable(2)]
		ITouchUiEditData GetData(string resId, int index);

		// Token: 0x0603BF47 RID: 245575
		void Clear();

		// Token: 0x0603BF48 RID: 245576
		void ResetEditData();

		// Token: 0x170070F8 RID: 28920
		// (get) Token: 0x0603BF49 RID: 245577
		int MinTouchMoveDifference { get; }

		// Token: 0x170070F9 RID: 28921
		// (get) Token: 0x0603BF4A RID: 245578
		int MaxTouchMoveDifference { get; }

		// Token: 0x170070FA RID: 28922
		// (get) Token: 0x0603BF4B RID: 245579
		float MaxTouchMoveValue { get; }

		// Token: 0x170070FB RID: 28923
		// (get) Token: 0x0603BF4C RID: 245580
		float MinTouchMoveValue { get; }

		// Token: 0x170070FC RID: 28924
		// (get) Token: 0x0603BF4D RID: 245581
		float ControlScaleRate { get; }
	}
}
