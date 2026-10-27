using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AE RID: 17070
	public class IWordArtResourceType_UnionUnion
	{
		// Token: 0x17007924 RID: 31012
		// (get) Token: 0x060194A7 RID: 103591 RVA: 0x003A1929 File Offset: 0x0039FB29
		// (set) Token: 0x060194A8 RID: 103592 RVA: 0x003A1931 File Offset: 0x0039FB31
		public IWordArtResourceType_Union Type { get; set; }

		// Token: 0x17007925 RID: 31013
		// (get) Token: 0x060194A9 RID: 103593 RVA: 0x003A193A File Offset: 0x0039FB3A
		// (set) Token: 0x060194AA RID: 103594 RVA: 0x003A1942 File Offset: 0x0039FB42
		public object Value { get; set; }

		// Token: 0x060194AB RID: 103595 RVA: 0x003A194B File Offset: 0x0039FB4B
		public IWordArtResourceType_UnionUnion()
		{
			this.Type = IWordArtResourceType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060194AC RID: 103596 RVA: 0x003A1961 File Offset: 0x0039FB61
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060194AD RID: 103597 RVA: 0x003A1973 File Offset: 0x0039FB73
		public IWordArtResourceTypeT AsIWordArtResourceType()
		{
			return this.As<IWordArtResourceTypeT>();
		}

		// Token: 0x060194AE RID: 103598 RVA: 0x003A197B File Offset: 0x0039FB7B
		public static IWordArtResourceType_UnionUnion FromIWordArtResourceType(IWordArtResourceTypeT _iwordartresourcetype)
		{
			return new IWordArtResourceType_UnionUnion
			{
				Type = IWordArtResourceType_Union.IWordArtResourceType,
				Value = _iwordartresourcetype
			};
		}

		// Token: 0x060194AF RID: 103599 RVA: 0x003A1990 File Offset: 0x0039FB90
		public IWordArtDefaultResourceTypeT AsIWordArtDefaultResourceType()
		{
			return this.As<IWordArtDefaultResourceTypeT>();
		}

		// Token: 0x060194B0 RID: 103600 RVA: 0x003A1998 File Offset: 0x0039FB98
		public static IWordArtResourceType_UnionUnion FromIWordArtDefaultResourceType(IWordArtDefaultResourceTypeT _iwordartdefaultresourcetype)
		{
			return new IWordArtResourceType_UnionUnion
			{
				Type = IWordArtResourceType_Union.IWordArtDefaultResourceType,
				Value = _iwordartdefaultresourcetype
			};
		}

		// Token: 0x060194B1 RID: 103601 RVA: 0x003A19B0 File Offset: 0x0039FBB0
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
