using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001E35 RID: 7733
internal class MonsterHandBookMonsterItem : LoopScrollMediumItemGrid<int>
{
	// Token: 0x0600EB0D RID: 60173 RVA: 0x0037AEE8 File Offset: 0x003790E8
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB0E RID: 60174 RVA: 0x0037AF06 File Offset: 0x00379106
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB0F RID: 60175 RVA: 0x0037AF24 File Offset: 0x00379124
	protected override void OnRefresh(int data, bool isSelected, int gridIndex)
	{
		this.HandBookId = data;
		this.SetSelected(isSelected, false);
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(this.HandBookId);
		if (monsterInfoConfig == null)
		{
			return;
		}
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(this.HandBookId);
		if (monsterHandBookConfigById != null && monsterHandBookConfigById.GetValueOrDefault().DefaultUnlock)
		{
			this.IsLock = false;
			PhantomMediumItemGrid parameters = new PhantomMediumItemGrid
			{
				Data = this.HandBookId,
				MonsterId = new int?(monsterInfoConfig.Value.Id),
				BottomTextId = monsterInfoConfig.Value.Name
			};
			base.Apply<PhantomMediumItemGrid>(parameters);
			return;
		}
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Monster, this.HandBookId);
		bool flag = handBookInfo == null || !handBookInfo.IsRead;
		this.IsLock = (handBookInfo == null);
		PhantomMediumItemGrid parameters2 = new PhantomMediumItemGrid
		{
			Data = this.HandBookId,
			MonsterId = (this.IsLock ? null : new int?(monsterInfoConfig.Value.Id)),
			IsNewVisible = new bool?(!this.IsLock && flag),
			IsPhantomLock = new bool?(this.IsLock),
			BottomTextId = (this.IsLock ? "Text_UnDiscovered_Text" : monsterInfoConfig.Value.Name)
		};
		base.Apply<PhantomMediumItemGrid>(parameters2);
	}

	// Token: 0x0600EB10 RID: 60176 RVA: 0x0037B0AB File Offset: 0x003792AB
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600EB11 RID: 60177 RVA: 0x0037B0BF File Offset: 0x003792BF
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600EB12 RID: 60178 RVA: 0x0037B0C9 File Offset: 0x003792C9
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<UUIExtendToggle, int, bool> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.GetItemGridExtendToggle(), this.HandBookId, this.IsLock);
		}
	}

	// Token: 0x0600EB13 RID: 60179 RVA: 0x0037B0F1 File Offset: 0x003792F1
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Monster || id != this.HandBookId)
		{
			return;
		}
		base.SetNewVisible(new bool?(false));
	}

	// Token: 0x04006D0A RID: 27914
	public int HandBookId;

	// Token: 0x04006D0B RID: 27915
	private bool IsLock = true;

	// Token: 0x04006D0C RID: 27916
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;
}
