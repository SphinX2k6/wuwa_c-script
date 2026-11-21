using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004704 RID: 18180
	public class IWordArtEffectiveTargetType_UnionUnion
	{
		// Token: 0x17007F50 RID: 32592
		// (get) Token: 0x0601ABF5 RID: 109557 RVA: 0x003CCD8D File Offset: 0x003CAF8D
		// (set) Token: 0x0601ABF6 RID: 109558 RVA: 0x003CCD95 File Offset: 0x003CAF95
		public IWordArtEffectiveTargetType_Union Type { get; set; }

		// Token: 0x17007F51 RID: 32593
		// (get) Token: 0x0601ABF7 RID: 109559 RVA: 0x003CCD9E File Offset: 0x003CAF9E
		// (set) Token: 0x0601ABF8 RID: 109560 RVA: 0x003CCDA6 File Offset: 0x003CAFA6
		public object Value { get; set; }

		// Token: 0x0601ABF9 RID: 109561 RVA: 0x003CCDAF File Offset: 0x003CAFAF
		public IWordArtEffectiveTargetType_UnionUnion()
		{
			this.Type = IWordArtEffectiveTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601ABFA RID: 109562 RVA: 0x003CCDC5 File Offset: 0x003CAFC5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ABFB RID: 109563 RVA: 0x003CCDD7 File Offset: 0x003CAFD7
		public IWordArtEffectiveTargetTypeT AsIWordArtEffectiveTargetType()
		{
			return this.As<IWordArtEffectiveTargetTypeT>();
		}

		// Token: 0x0601ABFC RID: 109564 RVA: 0x003CCDDF File Offset: 0x003CAFDF
		public static IWordArtEffectiveTargetType_UnionUnion FromIWordArtEffectiveTargetType(IWordArtEffectiveTargetTypeT _iwordarteffectivetargettype)
		{
			return new IWordArtEffectiveTargetType_UnionUnion
			{
				Type = IWordArtEffectiveTargetType_Union.IWordArtEffectiveTargetType,
				Value = _iwordarteffectivetargettype
			};
		}

		// Token: 0x0601ABFD RID: 109565 RVA: 0x003CCDF4 File Offset: 0x003CAFF4
		public INumberWordArtEffectiveTargetTypeT AsINumberWordArtEffectiveTargetType()
		{
			return this.As<INumberWordArtEffectiveTargetTypeT>();
		}

		// Token: 0x0601ABFE RID: 109566 RVA: 0x003CCDFC File Offset: 0x003CAFFC
		public static IWordArtEffectiveTargetType_UnionUnion FromINumberWordArtEffectiveTargetType(INumberWordArtEffectiveTargetTypeT _inumberwordarteffectivetargettype)
		{
			return new IWordArtEffectiveTargetType_UnionUnion
			{
				Type = IWordArtEffectiveTargetType_Union.INumberWordArtEffectiveTargetType,
				Value = _inumberwordarteffectivetargettype
			};
		}

		// Token: 0x0601ABFF RID: 109567 RVA: 0x003CCE14 File Offset: 0x003CB014
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
