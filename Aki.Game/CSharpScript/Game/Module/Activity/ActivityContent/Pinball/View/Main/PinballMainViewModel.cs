using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006339 RID: 25401
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballMainViewModel
	{
		// Token: 0x0603FEB9 RID: 261817 RVA: 0x00F77012 File Offset: 0x00F75212
		public PinballMainViewModel()
		{
			this.LevelDataList = new List<PinballLevelRecordData>();
		}

		// Token: 0x0603FEBA RID: 261818 RVA: 0x00F77025 File Offset: 0x00F75225
		[NullableContext(1)]
		public void SetChapterData(PinballChapterData chapterData)
		{
			this.ChapterData = chapterData;
		}

		// Token: 0x0603FEBB RID: 261819 RVA: 0x00F7702E File Offset: 0x00F7522E
		public PinballChapterData GetChapterData()
		{
			return this.ChapterData;
		}

		// Token: 0x0603FEBC RID: 261820 RVA: 0x00F77036 File Offset: 0x00F75236
		[NullableContext(1)]
		public void SetLevelDataList(List<PinballLevelRecordData> levelDataList)
		{
			this.LevelDataList = levelDataList;
		}

		// Token: 0x0603FEBD RID: 261821 RVA: 0x00F7703F File Offset: 0x00F7523F
		[NullableContext(1)]
		public List<PinballLevelRecordData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x0603FEBE RID: 261822 RVA: 0x00F77047 File Offset: 0x00F75247
		[NullableContext(1)]
		public void SetSelectLevelData(PinballLevelRecordData levelData)
		{
			this.SelectLevelData = levelData;
		}

		// Token: 0x0603FEBF RID: 261823 RVA: 0x00F77050 File Offset: 0x00F75250
		public void ClearSelectLevelData()
		{
			this.SelectLevelData = null;
		}

		// Token: 0x0603FEC0 RID: 261824 RVA: 0x00F77059 File Offset: 0x00F75259
		public PinballLevelRecordData GetSelectLevelData()
		{
			return this.SelectLevelData;
		}

		// Token: 0x0603FEC1 RID: 261825 RVA: 0x00F77061 File Offset: 0x00F75261
		[NullableContext(1)]
		public void SetOverrideCloseFunc(Action func)
		{
			this.OverrideCloseFunc = func;
		}

		// Token: 0x0603FEC2 RID: 261826 RVA: 0x00F7706A File Offset: 0x00F7526A
		public void ResetOverrideCloseFunc()
		{
			this.OverrideCloseFunc = null;
		}

		// Token: 0x0603FEC3 RID: 261827 RVA: 0x00F77073 File Offset: 0x00F75273
		public Action GetOverrideCloseFunc()
		{
			return this.OverrideCloseFunc;
		}

		// Token: 0x04021574 RID: 136564
		private PinballChapterData ChapterData;

		// Token: 0x04021575 RID: 136565
		[Nullable(1)]
		private List<PinballLevelRecordData> LevelDataList;

		// Token: 0x04021576 RID: 136566
		private PinballLevelRecordData SelectLevelData;

		// Token: 0x04021577 RID: 136567
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetTexture;

		// Token: 0x04021578 RID: 136568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetMaskTexture;

		// Token: 0x04021579 RID: 136569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> ChangePlanetSwitchTexture;

		// Token: 0x0402157A RID: 136570
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> SetViewTitle;

		// Token: 0x0402157B RID: 136571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> SetViewIcon;

		// Token: 0x0402157C RID: 136572
		public Action<int> SetViewHelpId;

		// Token: 0x0402157D RID: 136573
		public Action<bool> SetViewHelpBtnActive;

		// Token: 0x0402157E RID: 136574
		private Action OverrideCloseFunc;
	}
}
