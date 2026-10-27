using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F0F RID: 24335
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceMonsterPreviewData
	{
		// Token: 0x0603DD4F RID: 253263 RVA: 0x00EF1CBC File Offset: 0x00EEFEBC
		public string GetMonsterTips(int dataIndex)
		{
			if (this.GetMonsterTipsFunc == null)
			{
				return string.Empty;
			}
			return this.GetMonsterTipsFunc(dataIndex);
		}

		// Token: 0x0603DD50 RID: 253264 RVA: 0x00EF1CD8 File Offset: 0x00EEFED8
		public bool GetMonsterPreviewState(int dataIndex)
		{
			return this.GetMonsterPreviewStateFunc != null && this.GetMonsterPreviewStateFunc(dataIndex);
		}

		// Token: 0x0603DD51 RID: 253265 RVA: 0x00EF1CF0 File Offset: 0x00EEFEF0
		public int GetInstanceDungeonId(int dataIndex)
		{
			if (this.GetInstanceDungeonIdFunc == null)
			{
				return 0;
			}
			return this.GetInstanceDungeonIdFunc(dataIndex);
		}

		// Token: 0x0603DD52 RID: 253266 RVA: 0x00EF1D08 File Offset: 0x00EEFF08
		public Action<int> GetPreviewCallBack()
		{
			return this.GetClickPreviewCallBack;
		}

		// Token: 0x0603DD53 RID: 253267 RVA: 0x00EF1D10 File Offset: 0x00EEFF10
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

		// Token: 0x040204C2 RID: 132290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetMonsterTipsFunc;

		// Token: 0x040204C3 RID: 132291
		[Nullable(2)]
		private Func<int, bool> GetMonsterPreviewStateFunc;

		// Token: 0x040204C4 RID: 132292
		[Nullable(2)]
		private Func<int, int> GetInstanceDungeonIdFunc;

		// Token: 0x040204C5 RID: 132293
		[Nullable(2)]
		private Action<int> GetClickPreviewCallBack;
	}
}
