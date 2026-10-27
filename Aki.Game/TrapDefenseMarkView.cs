using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D2F RID: 7471
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMarkView : UiPanelBase
{
	// Token: 0x0600E243 RID: 57923 RVA: 0x0035281E File Offset: 0x00350A1E
	[NullableContext(2)]
	public TrapDefenseMarkItem GetMarkData()
	{
		return TrapDefenseModel.Instance.MapData.GetDynamicMarkInfoByMarkId(this.MarkId);
	}

	// Token: 0x0600E244 RID: 57924 RVA: 0x00352835 File Offset: 0x00350A35
	public TrapDefenseMarkView(int markId)
	{
		this.MarkId = markId;
	}

	// Token: 0x1700121D RID: 4637
	// (get) Token: 0x0600E245 RID: 57925 RVA: 0x00352861 File Offset: 0x00350A61
	public bool NeedUpdatePosition
	{
		get
		{
			return this.NeedUpdatePositionInner;
		}
	}

	// Token: 0x0600E246 RID: 57926 RVA: 0x00352869 File Offset: 0x00350A69
	public virtual void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
	{
	}

	// Token: 0x0600E247 RID: 57927 RVA: 0x0035286C File Offset: 0x00350A6C
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

	// Token: 0x0600E248 RID: 57928 RVA: 0x003528DC File Offset: 0x00350ADC
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

	// Token: 0x040068AB RID: 26795
	public int MarkId;

	// Token: 0x040068AC RID: 26796
	private readonly Vector2D CurrentAnchorOffset = Vector2D.Create(0.0, 0.0);

	// Token: 0x040068AD RID: 26797
	protected bool NeedUpdatePositionInner;
}
