using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020022D6 RID: 8918
[NullableContext(1)]
[Nullable(0)]
public static class WorldMapUtil
{
	// Token: 0x0601604D RID: 90189 RVA: 0x00660A3C File Offset: 0x0065EC3C
	public static Vector2D GetViewportSize()
	{
		if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
		{
			return Vector2D.Create();
		}
		return Vector2D.Create((double)UiLayer.Instance.UiRootItem.GetWidth(), (double)UiLayer.Instance.UiRootItem.GetHeight());
	}

	// Token: 0x0601604E RID: 90190 RVA: 0x00660A7A File Offset: 0x0065EC7A
	public static Vector2D GetViewportSizeByPool()
	{
		if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
		{
			return Vector2D.Create();
		}
		return Vector2D.Create((double)UiLayer.Instance.UiRootItem.GetWidth(), (double)UiLayer.Instance.UiRootItem.GetHeight());
	}
}
