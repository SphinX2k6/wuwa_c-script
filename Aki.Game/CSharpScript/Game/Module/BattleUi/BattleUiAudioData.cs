using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C67 RID: 23655
	public class BattleUiAudioData
	{
		// Token: 0x0603BC9E RID: 244894 RVA: 0x00E48201 File Offset: 0x00E46401
		public void Init()
		{
		}

		// Token: 0x0603BC9F RID: 244895 RVA: 0x00E48204 File Offset: 0x00E46404
		public void OnLeaveLevel()
		{
			foreach (BattleUiAudioInfo battleUiAudioInfo in this.AudioInfoMap.Values)
			{
				battleUiAudioInfo.Reset();
			}
		}

		// Token: 0x0603BCA0 RID: 244896 RVA: 0x00E4825C File Offset: 0x00E4645C
		public void Clear()
		{
		}

		// Token: 0x0603BCA1 RID: 244897 RVA: 0x00E48260 File Offset: 0x00E46460
		public void PlayAudio(EBattleUiAudioType type, EBattleUiChild uiChildType = EBattleUiChild.Common)
		{
			BattleUiAudioInfo battleUiAudioInfo;
			if (!this.AudioInfoMap.TryGetValue(type, out battleUiAudioInfo))
			{
				battleUiAudioInfo = new BattleUiAudioInfo
				{
					AudioType = type
				};
				this.AudioInfoMap[type] = battleUiAudioInfo;
			}
			battleUiAudioInfo.UiChildType = uiChildType;
			battleUiAudioInfo.PlayAudio();
		}

		// Token: 0x0401F231 RID: 127537
		[Nullable(1)]
		private readonly Dictionary<EBattleUiAudioType, BattleUiAudioInfo> AudioInfoMap = new Dictionary<EBattleUiAudioType, BattleUiAudioInfo>();
	}
}
