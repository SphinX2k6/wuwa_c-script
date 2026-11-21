using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace UnrealEngine.Extension
{
	// Token: 0x02002F4F RID: 12111
	public static class LGuiExtension
	{
		// Token: 0x0601CB60 RID: 117600 RVA: 0x008C3564 File Offset: 0x008C1764
		public static FVector2D GetUiViewportSize()
		{
			if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
			{
				return new FVector2D();
			}
			float width = UiLayer.Instance.UiRootItem.GetWidth();
			float height = UiLayer.Instance.UiRootItem.GetHeight();
			return new FVector2D(width, height);
		}

		// Token: 0x0601CB61 RID: 117601 RVA: 0x008C35B0 File Offset: 0x008C17B0
		[NullableContext(1)]
		public static Vector2D GetViewportSize()
		{
			if (!ObjectUtils.IsValid(UiLayer.Instance.UiRootItem))
			{
				return new Vector2D();
			}
			double width = (double)UiLayer.Instance.UiRootItem.GetWidth();
			float height = UiLayer.Instance.UiRootItem.GetHeight();
			return new Vector2D(width, (double)height);
		}
	}
}
