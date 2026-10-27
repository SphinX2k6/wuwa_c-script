using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D3C RID: 19772
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopProjectBasePanel : UiPanelBase
	{
		// Token: 0x0603315F RID: 209247 RVA: 0x00BE7937 File Offset: 0x00BE5B37
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06033160 RID: 209248 RVA: 0x00BE7951 File Offset: 0x00BE5B51
		public void RefreshView(RoleDevelopData data, bool forceRefresh = false)
		{
			this.Data = data;
			this.OnRefreshView(forceRefresh);
		}

		// Token: 0x06033161 RID: 209249
		protected abstract void OnRefreshView(bool forceRefresh);

		// Token: 0x06033162 RID: 209250 RVA: 0x00BE7961 File Offset: 0x00BE5B61
		public virtual void OnCommonItemCountAnyChange(int configId)
		{
		}

		// Token: 0x06033163 RID: 209251 RVA: 0x00BE7964 File Offset: 0x00BE5B64
		public void PlaySequenceByName(string sequenceName, bool blockClick = false)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, blockClick, null);
		}

		// Token: 0x06033164 RID: 209252 RVA: 0x00BE798C File Offset: 0x00BE5B8C
		public void StopSequenceByName(string sequenceName, bool needEvent = false, bool toLastFrame = false)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopSequenceByKey(sequenceName, needEvent, toLastFrame);
		}

		// Token: 0x0401B292 RID: 111250
		[Nullable(2)]
		protected RoleDevelopData Data;

		// Token: 0x0401B293 RID: 111251
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;
	}
}
