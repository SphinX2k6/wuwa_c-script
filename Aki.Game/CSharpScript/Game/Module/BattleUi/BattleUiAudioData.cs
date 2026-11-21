using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C47 RID: 19527
	public class BattleUiAudioData
	{
		// Token: 0x06030BE9 RID: 199657 RVA: 0x00D985E1 File Offset: 0x00D967E1
		public void Init()
		{
		}

		// Token: 0x06030BEA RID: 199658 RVA: 0x00D985E4 File Offset: 0x00D967E4
		public void OnLeaveLevel()
		{
			foreach (BattleUiAudioInfo battleUiAudioInfo in this.AudioInfoMap.Values)
			{
				battleUiAudioInfo.Reset();
			}
		}

		// Token: 0x06030BEB RID: 199659 RVA: 0x00D9863C File Offset: 0x00D9683C
		public void Clear()
		{
		}

		// Token: 0x06030BEC RID: 199660 RVA: 0x00D98640 File Offset: 0x00D96840
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

		// Token: 0x04019CE2 RID: 105698
		[Nullable(1)]
		private readonly Dictionary<EBattleUiAudioType, BattleUiAudioInfo> AudioInfoMap = new Dictionary<EBattleUiAudioType, BattleUiAudioInfo>();
	}
}
