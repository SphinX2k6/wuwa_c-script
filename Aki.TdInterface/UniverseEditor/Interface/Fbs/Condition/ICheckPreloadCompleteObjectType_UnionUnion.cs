using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FED RID: 20461
	public class ICheckPreloadCompleteObjectType_UnionUnion
	{
		// Token: 0x17009262 RID: 37474
		// (get) Token: 0x0601FEC7 RID: 130759 RVA: 0x0046EC1D File Offset: 0x0046CE1D
		// (set) Token: 0x0601FEC8 RID: 130760 RVA: 0x0046EC25 File Offset: 0x0046CE25
		public ICheckPreloadCompleteObjectType_Union Type { get; set; }

		// Token: 0x17009263 RID: 37475
		// (get) Token: 0x0601FEC9 RID: 130761 RVA: 0x0046EC2E File Offset: 0x0046CE2E
		// (set) Token: 0x0601FECA RID: 130762 RVA: 0x0046EC36 File Offset: 0x0046CE36
		public object Value { get; set; }

		// Token: 0x0601FECB RID: 130763 RVA: 0x0046EC3F File Offset: 0x0046CE3F
		public ICheckPreloadCompleteObjectType_UnionUnion()
		{
			this.Type = ICheckPreloadCompleteObjectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FECC RID: 130764 RVA: 0x0046EC55 File Offset: 0x0046CE55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FECD RID: 130765 RVA: 0x0046EC67 File Offset: 0x0046CE67
		public ICheckPreloadCompleteObjectTypeT AsICheckPreloadCompleteObjectType()
		{
			return this.As<ICheckPreloadCompleteObjectTypeT>();
		}

		// Token: 0x0601FECE RID: 130766 RVA: 0x0046EC6F File Offset: 0x0046CE6F
		public static ICheckPreloadCompleteObjectType_UnionUnion FromICheckPreloadCompleteObjectType(ICheckPreloadCompleteObjectTypeT _icheckpreloadcompleteobjecttype)
		{
			return new ICheckPreloadCompleteObjectType_UnionUnion
			{
				Type = ICheckPreloadCompleteObjectType_Union.ICheckPreloadCompleteObjectType,
				Value = _icheckpreloadcompleteobjecttype
			};
		}

		// Token: 0x0601FECF RID: 130767 RVA: 0x0046EC84 File Offset: 0x0046CE84
		public ICheckPreloadCompleteLinkResourceT AsICheckPreloadCompleteLinkResource()
		{
			return this.As<ICheckPreloadCompleteLinkResourceT>();
		}

		// Token: 0x0601FED0 RID: 130768 RVA: 0x0046EC8C File Offset: 0x0046CE8C
		public static ICheckPreloadCompleteObjectType_UnionUnion FromICheckPreloadCompleteLinkResource(ICheckPreloadCompleteLinkResourceT _icheckpreloadcompletelinkresource)
		{
			return new ICheckPreloadCompleteObjectType_UnionUnion
			{
				Type = ICheckPreloadCompleteObjectType_Union.ICheckPreloadCompleteLinkResource,
				Value = _icheckpreloadcompletelinkresource
			};
		}

		// Token: 0x0601FED1 RID: 130769 RVA: 0x0046ECA4 File Offset: 0x0046CEA4
		public static int Pack(FlatBufferBuilder builder, ICheckPreloadCompleteObjectType_UnionUnion _o)
		{
			ICheckPreloadCompleteObjectType_Union type = _o.Type;
			if (type == ICheckPreloadCompleteObjectType_Union.ICheckPreloadCompleteObjectType)
			{
				return ICheckPreloadCompleteObjectType.Pack(builder, _o.AsICheckPreloadCompleteObjectType()).Value;
			}
			if (type != ICheckPreloadCompleteObjectType_Union.ICheckPreloadCompleteLinkResource)
			{
				return 0;
			}
			return ICheckPreloadCompleteLinkResource.Pack(builder, _o.AsICheckPreloadCompleteLinkResource()).Value;
		}
	}
}
