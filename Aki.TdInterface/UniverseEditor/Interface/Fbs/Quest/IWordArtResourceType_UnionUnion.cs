using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200470A RID: 18186
	public class IWordArtResourceType_UnionUnion
	{
		// Token: 0x17007F55 RID: 32597
		// (get) Token: 0x0601AC13 RID: 109587 RVA: 0x003CD001 File Offset: 0x003CB201
		// (set) Token: 0x0601AC14 RID: 109588 RVA: 0x003CD009 File Offset: 0x003CB209
		public IWordArtResourceType_Union Type { get; set; }

		// Token: 0x17007F56 RID: 32598
		// (get) Token: 0x0601AC15 RID: 109589 RVA: 0x003CD012 File Offset: 0x003CB212
		// (set) Token: 0x0601AC16 RID: 109590 RVA: 0x003CD01A File Offset: 0x003CB21A
		public object Value { get; set; }

		// Token: 0x0601AC17 RID: 109591 RVA: 0x003CD023 File Offset: 0x003CB223
		public IWordArtResourceType_UnionUnion()
		{
			this.Type = IWordArtResourceType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC18 RID: 109592 RVA: 0x003CD039 File Offset: 0x003CB239
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC19 RID: 109593 RVA: 0x003CD04B File Offset: 0x003CB24B
		public IWordArtResourceTypeT AsIWordArtResourceType()
		{
			return this.As<IWordArtResourceTypeT>();
		}

		// Token: 0x0601AC1A RID: 109594 RVA: 0x003CD053 File Offset: 0x003CB253
		public static IWordArtResourceType_UnionUnion FromIWordArtResourceType(IWordArtResourceTypeT _iwordartresourcetype)
		{
			return new IWordArtResourceType_UnionUnion
			{
				Type = IWordArtResourceType_Union.IWordArtResourceType,
				Value = _iwordartresourcetype
			};
		}

		// Token: 0x0601AC1B RID: 109595 RVA: 0x003CD068 File Offset: 0x003CB268
		public IWordArtDefaultResourceTypeT AsIWordArtDefaultResourceType()
		{
			return this.As<IWordArtDefaultResourceTypeT>();
		}

		// Token: 0x0601AC1C RID: 109596 RVA: 0x003CD070 File Offset: 0x003CB270
		public static IWordArtResourceType_UnionUnion FromIWordArtDefaultResourceType(IWordArtDefaultResourceTypeT _iwordartdefaultresourcetype)
		{
			return new IWordArtResourceType_UnionUnion
			{
				Type = IWordArtResourceType_Union.IWordArtDefaultResourceType,
				Value = _iwordartdefaultresourcetype
			};
		}

		// Token: 0x0601AC1D RID: 109597 RVA: 0x003CD088 File Offset: 0x003CB288
		public static int Pack(FlatBufferBuilder builder, IWordArtResourceType_UnionUnion _o)
		{
			IWordArtResourceType_Union type = _o.Type;
			if (type == IWordArtResourceType_Union.IWordArtResourceType)
			{
				return IWordArtResourceType.Pack(builder, _o.AsIWordArtResourceType()).Value;
			}
			if (type != IWordArtResourceType_Union.IWordArtDefaultResourceType)
			{
				return 0;
			}
			return IWordArtDefaultResourceType.Pack(builder, _o.AsIWordArtDefaultResourceType()).Value;
		}
	}
}
