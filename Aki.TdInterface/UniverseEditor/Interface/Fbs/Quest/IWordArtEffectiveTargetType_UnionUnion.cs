using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A8 RID: 17064
	public class IWordArtEffectiveTargetType_UnionUnion
	{
		// Token: 0x1700791F RID: 31007
		// (get) Token: 0x06019489 RID: 103561 RVA: 0x003A16B5 File Offset: 0x0039F8B5
		// (set) Token: 0x0601948A RID: 103562 RVA: 0x003A16BD File Offset: 0x0039F8BD
		public IWordArtEffectiveTargetType_Union Type { get; set; }

		// Token: 0x17007920 RID: 31008
		// (get) Token: 0x0601948B RID: 103563 RVA: 0x003A16C6 File Offset: 0x0039F8C6
		// (set) Token: 0x0601948C RID: 103564 RVA: 0x003A16CE File Offset: 0x0039F8CE
		public object Value { get; set; }

		// Token: 0x0601948D RID: 103565 RVA: 0x003A16D7 File Offset: 0x0039F8D7
		public IWordArtEffectiveTargetType_UnionUnion()
		{
			this.Type = IWordArtEffectiveTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601948E RID: 103566 RVA: 0x003A16ED File Offset: 0x0039F8ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601948F RID: 103567 RVA: 0x003A16FF File Offset: 0x0039F8FF
		public IWordArtEffectiveTargetTypeT AsIWordArtEffectiveTargetType()
		{
			return this.As<IWordArtEffectiveTargetTypeT>();
		}

		// Token: 0x06019490 RID: 103568 RVA: 0x003A1707 File Offset: 0x0039F907
		public static IWordArtEffectiveTargetType_UnionUnion FromIWordArtEffectiveTargetType(IWordArtEffectiveTargetTypeT _iwordarteffectivetargettype)
		{
			return new IWordArtEffectiveTargetType_UnionUnion
			{
				Type = IWordArtEffectiveTargetType_Union.IWordArtEffectiveTargetType,
				Value = _iwordarteffectivetargettype
			};
		}

		// Token: 0x06019491 RID: 103569 RVA: 0x003A171C File Offset: 0x0039F91C
		public INumberWordArtEffectiveTargetTypeT AsINumberWordArtEffectiveTargetType()
		{
			return this.As<INumberWordArtEffectiveTargetTypeT>();
		}

		// Token: 0x06019492 RID: 103570 RVA: 0x003A1724 File Offset: 0x0039F924
		public static IWordArtEffectiveTargetType_UnionUnion FromINumberWordArtEffectiveTargetType(INumberWordArtEffectiveTargetTypeT _inumberwordarteffectivetargettype)
		{
			return new IWordArtEffectiveTargetType_UnionUnion
			{
				Type = IWordArtEffectiveTargetType_Union.INumberWordArtEffectiveTargetType,
				Value = _inumberwordarteffectivetargettype
			};
		}

		// Token: 0x06019493 RID: 103571 RVA: 0x003A173C File Offset: 0x0039F93C
		public static int Pack(FlatBufferBuilder builder, IWordArtEffectiveTargetType_UnionUnion _o)
		{
			IWordArtEffectiveTargetType_Union type = _o.Type;
			if (type == IWordArtEffectiveTargetType_Union.IWordArtEffectiveTargetType)
			{
				return IWordArtEffectiveTargetType.Pack(builder, _o.AsIWordArtEffectiveTargetType()).Value;
			}
			if (type != IWordArtEffectiveTargetType_Union.INumberWordArtEffectiveTargetType)
			{
				return 0;
			}
			return INumberWordArtEffectiveTargetType.Pack(builder, _o.AsINumberWordArtEffectiveTargetType()).Value;
		}
	}
}
