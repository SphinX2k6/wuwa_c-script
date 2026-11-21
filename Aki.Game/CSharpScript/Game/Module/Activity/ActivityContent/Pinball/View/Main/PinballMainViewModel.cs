using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B7 RID: 21175
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainViewModel
	{
		// Token: 0x06034B7A RID: 215930 RVA: 0x00EBDF6E File Offset: 0x00EBC16E
		public PinballMainViewModel()
		{
			this.LevelDataList = new List<PinballLevelRecordData>();
		}

		// Token: 0x06034B7B RID: 215931 RVA: 0x00EBDF81 File Offset: 0x00EBC181
		[NullableContext(1)]
		public void SetChapterData(PinballChapterData chapterData)
		{
			this.ChapterData = chapterData;
		}

		// Token: 0x06034B7C RID: 215932 RVA: 0x00EBDF8A File Offset: 0x00EBC18A
		public PinballChapterData GetChapterData()
		{
			return this.ChapterData;
		}

		// Token: 0x06034B7D RID: 215933 RVA: 0x00EBDF92 File Offset: 0x00EBC192
		[NullableContext(1)]
		public void SetLevelDataList(List<PinballLevelRecordData> levelDataList)
		{
			this.LevelDataList = levelDataList;
		}

		// Token: 0x06034B7E RID: 215934 RVA: 0x00EBDF9B File Offset: 0x00EBC19B
		[NullableContext(1)]
		public List<PinballLevelRecordData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x06034B7F RID: 215935 RVA: 0x00EBDFA3 File Offset: 0x00EBC1A3
		[NullableContext(1)]
		public void SetSelectLevelData(PinballLevelRecordData levelData)
		{
			this.SelectLevelData = levelData;
		}

		// Token: 0x06034B80 RID: 215936 RVA: 0x00EBDFAC File Offset: 0x00EBC1AC
		public void ClearSelectLevelData()
		{
			this.SelectLevelData = null;
		}

		// Token: 0x06034B81 RID: 215937 RVA: 0x00EBDFB5 File Offset: 0x00EBC1B5
		public PinballLevelRecordData GetSelectLevelData()
		{
			return this.SelectLevelData;
		}

		// Token: 0x06034B82 RID: 215938 RVA: 0x00EBDFBD File Offset: 0x00EBC1BD
		[NullableContext(1)]
		public void SetOverrideCloseFunc(Action func)
		{
			this.OverrideCloseFunc = func;
		}

		// Token: 0x06034B83 RID: 215939 RVA: 0x00EBDFC6 File Offset: 0x00EBC1C6
		public void ResetOverrideCloseFunc()
		{
			this.OverrideCloseFunc = null;
		}

		// Token: 0x06034B84 RID: 215940 RVA: 0x00EBDFCF File Offset: 0x00EBC1CF
		public Action GetOverrideCloseFunc()
		{
			return this.OverrideCloseFunc;
		}

		// Token: 0x0401BEA3 RID: 114339
		private PinballChapterData ChapterData;

		// Token: 0x0401BEA4 RID: 114340
		[Nullable(1)]
		private List<PinballLevelRecordData> LevelDataList;

		// Token: 0x0401BEA5 RID: 114341
		private PinballLevelRecordData SelectLevelData;

		// Token: 0x0401BEA6 RID: 114342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetTexture;

		// Token: 0x0401BEA7 RID: 114343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetMaskTexture;

		// Token: 0x0401BEA8 RID: 114344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetSwitchTexture;

		// Token: 0x0401BEA9 RID: 114345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> SetViewTitle;

		// Token: 0x0401BEAA RID: 114346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> SetViewIcon;

		// Token: 0x0401BEAB RID: 114347
		public Action<int> SetViewHelpId;

		// Token: 0x0401BEAC RID: 114348
		public Action<bool> SetViewHelpBtnActive;

		// Token: 0x0401BEAD RID: 114349
		private Action OverrideCloseFunc;
	}
}
