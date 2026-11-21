using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011F4 RID: 4596
public class TrapDefenseRoutePointView : UiPanelBase
{
	// Token: 0x0600B670 RID: 46704 RVA: 0x0035E560 File Offset: 0x0035C760
	protected override void OnBeforeShow()
	{
		UUIItem sprite = base.GetSprite(0);
		int trapDefenseRoutePointNum = TrapDefenseConfig.Instance.GetTrapDefenseRoutePointNum();
		sprite.SetAlpha((float)(trapDefenseRoutePointNum - this.Index) / (float)trapDefenseRoutePointNum);
		this.RootItem.SetAlpha(0f);
	}

	// Token: 0x0600B671 RID: 46705 RVA: 0x0035E5A0 File Offset: 0x0035C7A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600B672 RID: 46706 RVA: 0x0035E5C4 File Offset: 0x0035C7C4
	[NullableContext(1)]
	public void UpdatePosition(FVector worldPosition, float scale, Vector2D centerOffset)
	{
		if (!base.IsShow)
		{
			return;
		}
		this.RootItem.SetAlpha(1f);
		Vector vector = Vector.Create((double)worldPosition.X, (double)worldPosition.Y, (double)worldPosition.Z);
		vector.Multiply(TrapDefenseDefine.worldToTrapDefenseUiUnit, vector);
		Vector2D vector2D = Vector2D.Create(vector.X, vector.Y);
		vector2D.Multiply((double)scale, vector2D).Subtraction(centerOffset, vector2D);
		base.GetRootItem().SetAnchorOffset(vector2D.ToUeVector2D(false));
	}

	// Token: 0x0400698E RID: 27022
	public double StartTimestamp;

	// Token: 0x0400698F RID: 27023
	public int Index;

	// Token: 0x020074C1 RID: 29889
	private static class EChildComponent
	{
		// Token: 0x04025FBF RID: 155583
		public const int Icon = 0;
	}
}
