using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x02005409 RID: 21513
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MenuScrollSettingBaseItem : UiPanelBase
	{
		// Token: 0x06036F9B RID: 225179 RVA: 0x00D067F5 File Offset: 0x00D049F5
		public void Initialize(UUIItem uiItem, Action<float> saveCallback, Action<string> sequence)
		{
			this.FireSaveMenuChange = saveCallback;
			this.PlaySequenceByName = sequence;
			this.SourceItem = uiItem;
		}

		// Token: 0x06036F9C RID: 225180 RVA: 0x00D0680C File Offset: 0x00D04A0C
		public UniTask Init()
		{
			MenuScrollSettingBaseItem.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MenuScrollSettingBaseItem.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036F9D RID: 225181 RVA: 0x00D0684F File Offset: 0x00D04A4F
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x06036F9E RID: 225182 RVA: 0x00D06851 File Offset: 0x00D04A51
		protected override void OnStart()
		{
		}

		// Token: 0x06036F9F RID: 225183 RVA: 0x00D06853 File Offset: 0x00D04A53
		protected override void OnBeforeDestroy()
		{
			this.Clear();
		}

		// Token: 0x06036FA0 RID: 225184 RVA: 0x00D0685B File Offset: 0x00D04A5B
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x06036FA1 RID: 225185 RVA: 0x00D06864 File Offset: 0x00D04A64
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06036FA2 RID: 225186 RVA: 0x00D0686C File Offset: 0x00D04A6C
		protected virtual void OnClear()
		{
		}

		// Token: 0x06036FA3 RID: 225187 RVA: 0x00D0686E File Offset: 0x00D04A6E
		public virtual UniTask ClearAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06036FA4 RID: 225188 RVA: 0x00D06875 File Offset: 0x00D04A75
		protected virtual void OnRemoveEvents()
		{
		}

		// Token: 0x06036FA5 RID: 225189 RVA: 0x00D06877 File Offset: 0x00D04A77
		public virtual void PlaySequenceFromName(string name)
		{
		}

		// Token: 0x06036FA6 RID: 225190 RVA: 0x00D0687C File Offset: 0x00D04A7C
		protected bool GetItemClickLimit(UUISelectableComponent component)
		{
			if (component.GetSelfInteractive())
			{
				return false;
			}
			MenuData data = this.Data;
			if (data != null && data.BtnDisableTipsEnable)
			{
				return true;
			}
			if (this.Data != null && !string.IsNullOrEmpty(this.Data.BtnDisableTips))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(this.Data.BtnDisableTips, Array.Empty<object>());
			}
			else
			{
				GenericPromptController.Instance.ShowPromptByCode("NotModify", Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x06036FA7 RID: 225191
		public abstract void SetInteractionActive(bool val);

		// Token: 0x06036FA8 RID: 225192 RVA: 0x00D068F4 File Offset: 0x00D04AF4
		public void ExecuteUpdate(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.Update(data, bGameSettingsUpdate);
			this.SetDetailVisible(data.GetIsDetailTextVisible());
		}

		// Token: 0x06036FA9 RID: 225193
		public abstract void Update(MenuData data, bool bGameSettingsUpdate);

		// Token: 0x06036FAA RID: 225194 RVA: 0x00D06911 File Offset: 0x00D04B11
		public void SetDetailVisible(bool bVisible)
		{
			if (this.Data == null)
			{
				return;
			}
			if (bVisible && !this.Data.HasDetailText())
			{
				return;
			}
			this.Data.SetDetailTextVisible(bVisible);
			this.OnSetDetailVisible(bVisible);
		}

		// Token: 0x06036FAB RID: 225195 RVA: 0x00D06940 File Offset: 0x00D04B40
		protected virtual void OnSetDetailVisible(bool bVisible)
		{
		}

		// Token: 0x06036FAC RID: 225196 RVA: 0x00D06944 File Offset: 0x00D04B44
		protected UniTask SetToggleSprite(string spritePath, string lockSpritePath, int name, int spriteName)
		{
			MenuScrollSettingBaseItem.<SetToggleSprite>d__21 <SetToggleSprite>d__;
			<SetToggleSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetToggleSprite>d__.<>4__this = this;
			<SetToggleSprite>d__.spritePath = spritePath;
			<SetToggleSprite>d__.lockSpritePath = lockSpritePath;
			<SetToggleSprite>d__.name = name;
			<SetToggleSprite>d__.spriteName = spriteName;
			<SetToggleSprite>d__.<>1__state = -1;
			<SetToggleSprite>d__.<>t__builder.Start<MenuScrollSettingBaseItem.<SetToggleSprite>d__21>(ref <SetToggleSprite>d__);
			return <SetToggleSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0401D024 RID: 118820
		[Nullable(2)]
		protected MenuData Data;

		// Token: 0x0401D025 RID: 118821
		protected Action<float> FireSaveMenuChange = delegate(float val)
		{
		};

		// Token: 0x0401D026 RID: 118822
		protected Action<string> PlaySequenceByName = delegate(string name)
		{
		};

		// Token: 0x0401D027 RID: 118823
		[Nullable(2)]
		private UUIItem SourceItem;
	}
}
