using System;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B0 RID: 14256
	public readonly struct VisualNovelTransform
	{
		// Token: 0x17004C4D RID: 19533
		// (get) Token: 0x06025195 RID: 151957 RVA: 0x00A77C38 File Offset: 0x00A75E38
		public float X { get; }

		// Token: 0x17004C4E RID: 19534
		// (get) Token: 0x06025196 RID: 151958 RVA: 0x00A77C40 File Offset: 0x00A75E40
		public float Y { get; }

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x06025197 RID: 151959 RVA: 0x00A77C48 File Offset: 0x00A75E48
		public float Scale { get; }

		// Token: 0x06025198 RID: 151960 RVA: 0x00A77C50 File Offset: 0x00A75E50
		public VisualNovelTransform(float x, float y, float scale)
		{
			this.X = x;
			this.Y = y;
			this.Scale = scale;
		}

		// Token: 0x06025199 RID: 151961 RVA: 0x00A77C68 File Offset: 0x00A75E68
		public static VisualNovelTransform Merge(VisualNovelTransform current, float? x, float? y, float? scale)
		{
			return new VisualNovelTransform(x ?? current.X, y ?? current.Y, Math.Max(scale ?? current.Scale, 0f));
		}
	}
}
