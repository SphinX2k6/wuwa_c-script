using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D32 RID: 7474
public class TrapDefenseRoutePointView : UiPanelBase
{
	// Token: 0x0600E253 RID: 57939 RVA: 0x00352B30 File Offset: 0x00350D30
	protected override void OnBeforeShow()
	{
		UUIItem sprite = base.GetSprite(0);
		int trapDefenseRoutePointNum = TrapDefenseConfig.Instance.GetTrapDefenseRoutePointNum();
		sprite.SetAlpha((float)(trapDefenseRoutePointNum - this.Index) / (float)trapDefenseRoutePointNum);
		this.RootItem.SetAlpha(0f);
	}

	// Token: 0x0600E254 RID: 57940 RVA: 0x00352B70 File Offset: 0x00350D70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600E255 RID: 57941 RVA: 0x00352B94 File Offset: 0x00350D94
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

	// Token: 0x040068AF RID: 26799
	public double StartTimestamp;

	// Token: 0x040068B0 RID: 26800
	public int Index;

	// Token: 0x02008338 RID: 33592
	private static class EChildComponent
	{
		// Token: 0x0402AC97 RID: 175255
		public const int Icon = 0;
	}
}
