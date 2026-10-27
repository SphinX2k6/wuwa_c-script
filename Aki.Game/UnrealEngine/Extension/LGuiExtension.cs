using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace UnrealEngine.Extension
{
	// Token: 0x020044B6 RID: 17590
	public static class LGuiExtension
	{
		// Token: 0x0602D547 RID: 185671 RVA: 0x00A3923C File Offset: 0x00A3743C
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

		// Token: 0x0602D548 RID: 185672 RVA: 0x00A39288 File Offset: 0x00A37488
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
