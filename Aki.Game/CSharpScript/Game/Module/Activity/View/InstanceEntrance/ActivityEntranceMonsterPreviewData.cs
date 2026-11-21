using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF6 RID: 20214
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceMonsterPreviewData
	{
		// Token: 0x06032CEA RID: 208106 RVA: 0x00E439C4 File Offset: 0x00E41BC4
		public string GetMonsterTips(int dataIndex)
		{
			if (this.GetMonsterTipsFunc == null)
			{
				return string.Empty;
			}
			return this.GetMonsterTipsFunc(dataIndex);
		}

		// Token: 0x06032CEB RID: 208107 RVA: 0x00E439E0 File Offset: 0x00E41BE0
		public bool GetMonsterPreviewState(int dataIndex)
		{
			return this.GetMonsterPreviewStateFunc != null && this.GetMonsterPreviewStateFunc(dataIndex);
		}

		// Token: 0x06032CEC RID: 208108 RVA: 0x00E439F8 File Offset: 0x00E41BF8
		public int GetInstanceDungeonId(int dataIndex)
		{
			if (this.GetInstanceDungeonIdFunc == null)
			{
				return 0;
			}
			return this.GetInstanceDungeonIdFunc(dataIndex);
		}

		// Token: 0x06032CED RID: 208109 RVA: 0x00E43A10 File Offset: 0x00E41C10
		public Action<int> GetPreviewCallBack()
		{
			return this.GetClickPreviewCallBack;
		}

		// Token: 0x06032CEE RID: 208110 RVA: 0x00E43A18 File Offset: 0x00E41C18
		public static ActivityEntranceMonsterPreviewData Create(Func<int, string> getMonsterTipsFunc, Func<int, bool> getMonsterPreviewStateFunc, Func<int, int> getInstanceDungeonIdFunc, Action<int> getPreviewCallBack)
		{
			return new ActivityEntranceMonsterPreviewData
			{
				GetMonsterTipsFunc = getMonsterTipsFunc,
				GetMonsterPreviewStateFunc = getMonsterPreviewStateFunc,
				GetInstanceDungeonIdFunc = getInstanceDungeonIdFunc,
				GetClickPreviewCallBack = getPreviewCallBack
			};
		}

		// Token: 0x0401AF94 RID: 110484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetMonsterTipsFunc;

		// Token: 0x0401AF95 RID: 110485
		[Nullable(2)]
		private Func<int, bool> GetMonsterPreviewStateFunc;

		// Token: 0x0401AF96 RID: 110486
		[Nullable(2)]
		private Func<int, int> GetInstanceDungeonIdFunc;

		// Token: 0x0401AF97 RID: 110487
		[Nullable(2)]
		private Action<int> GetClickPreviewCallBack;
	}
}
