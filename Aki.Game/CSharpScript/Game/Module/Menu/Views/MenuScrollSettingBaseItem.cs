using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043EC RID: 17388
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MenuScrollSettingBaseItem : UiPanelBase
	{
		// Token: 0x0602BEE4 RID: 179940 RVA: 0x00C55C15 File Offset: 0x00C53E15
		public void Initialize(UUIItem uiItem, Action<float> saveCallback, Action<string> sequence)
		{
			this.FireSaveMenuChange = saveCallback;
			this.PlaySequenceByName = sequence;
			this.SourceItem = uiItem;
		}

		// Token: 0x0602BEE5 RID: 179941 RVA: 0x00C55C2C File Offset: 0x00C53E2C
		public UniTask Init()
		{
			MenuScrollSettingBaseItem.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MenuScrollSettingBaseItem.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BEE6 RID: 179942 RVA: 0x00C55C6F File Offset: 0x00C53E6F
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x0602BEE7 RID: 179943 RVA: 0x00C55C71 File Offset: 0x00C53E71
		protected override void OnStart()
		{
		}

		// Token: 0x0602BEE8 RID: 179944 RVA: 0x00C55C73 File Offset: 0x00C53E73
		protected override void OnBeforeDestroy()
		{
			this.Clear();
		}

		// Token: 0x0602BEE9 RID: 179945 RVA: 0x00C55C7B File Offset: 0x00C53E7B
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0602BEEA RID: 179946 RVA: 0x00C55C84 File Offset: 0x00C53E84
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x0602BEEB RID: 179947 RVA: 0x00C55C8C File Offset: 0x00C53E8C
		protected virtual void OnClear()
		{
		}

		// Token: 0x0602BEEC RID: 179948 RVA: 0x00C55C8E File Offset: 0x00C53E8E
		public virtual UniTask ClearAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602BEED RID: 179949 RVA: 0x00C55C95 File Offset: 0x00C53E95
		protected virtual void OnRemoveEvents()
		{
		}

		// Token: 0x0602BEEE RID: 179950 RVA: 0x00C55C97 File Offset: 0x00C53E97
		public virtual void PlaySequenceFromName(string name)
		{
		}

		// Token: 0x0602BEEF RID: 179951 RVA: 0x00C55C9C File Offset: 0x00C53E9C
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

		// Token: 0x0602BEF0 RID: 179952
		public abstract void SetInteractionActive(bool val);

		// Token: 0x0602BEF1 RID: 179953 RVA: 0x00C55D14 File Offset: 0x00C53F14
		public void ExecuteUpdate(MenuData data, bool bGameSettingsUpdate)
		{
			this.Data = data;
			this.Update(data, bGameSettingsUpdate);
			this.SetDetailVisible(data.GetIsDetailTextVisible());
		}

		// Token: 0x0602BEF2 RID: 179954
		public abstract void Update(MenuData data, bool bGameSettingsUpdate);

		// Token: 0x0602BEF3 RID: 179955 RVA: 0x00C55D31 File Offset: 0x00C53F31
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

		// Token: 0x0602BEF4 RID: 179956 RVA: 0x00C55D60 File Offset: 0x00C53F60
		protected virtual void OnSetDetailVisible(bool bVisible)
		{
		}

		// Token: 0x0602BEF5 RID: 179957 RVA: 0x00C55D64 File Offset: 0x00C53F64
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

		// Token: 0x04017ABD RID: 96957
		[Nullable(2)]
		protected MenuData Data;

		// Token: 0x04017ABE RID: 96958
		protected Action<float> FireSaveMenuChange = delegate(float val)
		{
		};

		// Token: 0x04017ABF RID: 96959
		protected Action<string> PlaySequenceByName = delegate(string name)
		{
		};

		// Token: 0x04017AC0 RID: 96960
		[Nullable(2)]
		private UUIItem SourceItem;
	}
}
