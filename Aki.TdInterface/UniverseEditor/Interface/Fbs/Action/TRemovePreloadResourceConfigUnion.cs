using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007766 RID: 30566
	public class TRemovePreloadResourceConfigUnion
	{
		// Token: 0x1700E687 RID: 59015
		// (get) Token: 0x06037848 RID: 227400 RVA: 0x0078387E File Offset: 0x00781A7E
		// (set) Token: 0x06037849 RID: 227401 RVA: 0x00783886 File Offset: 0x00781A86
		public TRemovePreloadResourceConfig Type { get; set; }

		// Token: 0x1700E688 RID: 59016
		// (get) Token: 0x0603784A RID: 227402 RVA: 0x0078388F File Offset: 0x00781A8F
		// (set) Token: 0x0603784B RID: 227403 RVA: 0x00783897 File Offset: 0x00781A97
		public object Value { get; set; }

		// Token: 0x0603784C RID: 227404 RVA: 0x007838A0 File Offset: 0x00781AA0
		public TRemovePreloadResourceConfigUnion()
		{
			this.Type = TRemovePreloadResourceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603784D RID: 227405 RVA: 0x007838B6 File Offset: 0x00781AB6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603784E RID: 227406 RVA: 0x007838C8 File Offset: 0x00781AC8
		public IRemovePreloadFlowsT AsIRemovePreloadFlows()
		{
			return this.As<IRemovePreloadFlowsT>();
		}

		// Token: 0x0603784F RID: 227407 RVA: 0x007838D0 File Offset: 0x00781AD0
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadFlows(IRemovePreloadFlowsT _iremovepreloadflows)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadFlows,
				Value = _iremovepreloadflows
			};
		}

		// Token: 0x06037850 RID: 227408 RVA: 0x007838E5 File Offset: 0x00781AE5
		public IRemovePreloadLinkResourceT AsIRemovePreloadLinkResource()
		{
			return this.As<IRemovePreloadLinkResourceT>();
		}

		// Token: 0x06037851 RID: 227409 RVA: 0x007838ED File Offset: 0x00781AED
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadLinkResource(IRemovePreloadLinkResourceT _iremovepreloadlinkresource)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadLinkResource,
				Value = _iremovepreloadlinkresource
			};
		}

		// Token: 0x06037852 RID: 227410 RVA: 0x00783902 File Offset: 0x00781B02
		public IRemovePreloadResourcePhantomCharacterT AsIRemovePreloadResourcePhantomCharacter()
		{
			return this.As<IRemovePreloadResourcePhantomCharacterT>();
		}

		// Token: 0x06037853 RID: 227411 RVA: 0x0078390A File Offset: 0x00781B0A
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadResourcePhantomCharacter(IRemovePreloadResourcePhantomCharacterT _iremovepreloadresourcephantomcharacter)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadResourcePhantomCharacter,
				Value = _iremovepreloadresourcephantomcharacter
			};
		}

		// Token: 0x06037854 RID: 227412 RVA: 0x0078391F File Offset: 0x00781B1F
		public IRemovePreloadResourceTrialCharacterT AsIRemovePreloadResourceTrialCharacter()
		{
			return this.As<IRemovePreloadResourceTrialCharacterT>();
		}

		// Token: 0x06037855 RID: 227413 RVA: 0x00783927 File Offset: 0x00781B27
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadResourceTrialCharacter(IRemovePreloadResourceTrialCharacterT _iremovepreloadresourcetrialcharacter)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadResourceTrialCharacter,
				Value = _iremovepreloadresourcetrialcharacter
			};
		}

		// Token: 0x06037856 RID: 227414 RVA: 0x0078393C File Offset: 0x00781B3C
		public static int Pack(FlatBufferBuilder builder, TRemovePreloadResourceConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TRemovePreloadResourceConfig.IRemovePreloadFlows:
				return IRemovePreloadFlows.Pack(builder, _o.AsIRemovePreloadFlows()).Value;
			case TRemovePreloadResourceConfig.IRemovePreloadLinkResource:
				return IRemovePreloadLinkResource.Pack(builder, _o.AsIRemovePreloadLinkResource()).Value;
			case TRemovePreloadResourceConfig.IRemovePreloadResourcePhantomCharacter:
				return IRemovePreloadResourcePhantomCharacter.Pack(builder, _o.AsIRemovePreloadResourcePhantomCharacter()).Value;
			case TRemovePreloadResourceConfig.IRemovePreloadResourceTrialCharacter:
				return IRemovePreloadResourceTrialCharacter.Pack(builder, _o.AsIRemovePreloadResourceTrialCharacter()).Value;
			default:
				return 0;
			}
		}
	}
}
