using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x020012F7 RID: 4855
internal class MonsterHandBookMonsterItem : LoopScrollMediumItemGrid<int>
{
	// Token: 0x0600BF2C RID: 48940 RVA: 0x00386B74 File Offset: 0x00384D74
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF2D RID: 48941 RVA: 0x00386B92 File Offset: 0x00384D92
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF2E RID: 48942 RVA: 0x00386BB0 File Offset: 0x00384DB0
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

	// Token: 0x0600BF2F RID: 48943 RVA: 0x00386D37 File Offset: 0x00384F37
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600BF30 RID: 48944 RVA: 0x00386D4B File Offset: 0x00384F4B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600BF31 RID: 48945 RVA: 0x00386D55 File Offset: 0x00384F55
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

	// Token: 0x0600BF32 RID: 48946 RVA: 0x00386D7D File Offset: 0x00384F7D
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Monster || id != this.HandBookId)
		{
			return;
		}
		base.SetNewVisible(new bool?(false));
	}

	// Token: 0x04006DEB RID: 28139
	public int HandBookId;

	// Token: 0x04006DEC RID: 28140
	private bool IsLock = true;

	// Token: 0x04006DED RID: 28141
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;
}
