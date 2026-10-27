using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002D7C RID: 11644
[NullableContext(1)]
[Nullable(0)]
public static class WorldMapUtil
{
	// Token: 0x060187AB RID: 100267 RVA: 0x0063AA24 File Offset: 0x00638C24
	public static Vector2D GetViewportSize()
	{
		if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
		{
			return Vector2D.Create();
		}
		return Vector2D.Create((double)UiLayer.Instance.UiRootItem.GetWidth(), (double)UiLayer.Instance.UiRootItem.GetHeight());
	}

	// Token: 0x060187AC RID: 100268 RVA: 0x0063AA62 File Offset: 0x00638C62
	public static Vector2D GetViewportSizeByPool()
	{
		if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
		{
			return Vector2D.Create();
		}
		return Vector2D.Create((double)UiLayer.Instance.UiRootItem.GetWidth(), (double)UiLayer.Instance.UiRootItem.GetHeight());
	}
}
