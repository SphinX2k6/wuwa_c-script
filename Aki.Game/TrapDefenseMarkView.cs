using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011F1 RID: 4593
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMarkView : UiPanelBase
{
	// Token: 0x0600B660 RID: 46688 RVA: 0x0035E24E File Offset: 0x0035C44E
	[NullableContext(2)]
	public TrapDefenseMarkItem GetMarkData()
	{
		return TrapDefenseModel.Instance.MapData.GetDynamicMarkInfoByMarkId(this.MarkId);
	}

	// Token: 0x0600B661 RID: 46689 RVA: 0x0035E265 File Offset: 0x0035C465
	public TrapDefenseMarkView(int markId)
	{
		this.MarkId = markId;
	}

	// Token: 0x17001247 RID: 4679
	// (get) Token: 0x0600B662 RID: 46690 RVA: 0x0035E291 File Offset: 0x0035C491
	public bool NeedUpdatePosition
	{
		get
		{
			return this.NeedUpdatePositionInner;
		}
	}

	// Token: 0x0600B663 RID: 46691 RVA: 0x0035E299 File Offset: 0x0035C499
	public virtual void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
	{
	}

	// Token: 0x0600B664 RID: 46692 RVA: 0x0035E29C File Offset: 0x0035C49C
	public virtual void UpdatePosition(float scale, Vector2D centerOffset)
	{
		TrapDefenseMarkItem markData = this.GetMarkData();
		if (markData == null)
		{
			return;
		}
		Vector uiPosition = markData.UiPosition;
		if (uiPosition.IsZero())
		{
			return;
		}
		Vector2D vector2D = Vector2D.Create(uiPosition.X, uiPosition.Y);
		Vector2D vector2D2 = Vector2D.Create();
		vector2D.Multiply((double)scale, vector2D2).Subtraction(centerOffset, vector2D2);
		this.SetAnchorOffset(vector2D2, null);
		if (base.IsShow)
		{
			base.GetRootItem().SetAlpha(1f);
		}
	}

	// Token: 0x0600B665 RID: 46693 RVA: 0x0035E30C File Offset: 0x0035C50C
	public void SetAnchorOffset(Vector2D value, [Nullable(new byte[]
	{
		2,
		1
	})] UUIItem[] relativeItems = null)
	{
		if (!value.Equals(this.CurrentAnchorOffset, 9.999999747378752E-05))
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(value.ToUeVector2D(false));
			}
			if (relativeItems != null)
			{
				for (int i = 0; i < relativeItems.Length; i++)
				{
					relativeItems[i].SetAnchorOffset(value.ToUeVector2D(false));
				}
			}
			this.CurrentAnchorOffset.Set(value.X, value.Y);
		}
	}

	// Token: 0x0400698A RID: 27018
	public int MarkId;

	// Token: 0x0400698B RID: 27019
	private readonly Vector2D CurrentAnchorOffset = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400698C RID: 27020
	protected bool NeedUpdatePositionInner;
}
