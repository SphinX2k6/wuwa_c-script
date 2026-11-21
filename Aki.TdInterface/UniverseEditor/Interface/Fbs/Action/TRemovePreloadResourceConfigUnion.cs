using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F92 RID: 32658
	public class TRemovePreloadResourceConfigUnion
	{
		// Token: 0x1700F2D9 RID: 62169
		// (get) Token: 0x0603AD91 RID: 241041 RVA: 0x007E894E File Offset: 0x007E6B4E
		// (set) Token: 0x0603AD92 RID: 241042 RVA: 0x007E8956 File Offset: 0x007E6B56
		public TRemovePreloadResourceConfig Type { get; set; }

		// Token: 0x1700F2DA RID: 62170
		// (get) Token: 0x0603AD93 RID: 241043 RVA: 0x007E895F File Offset: 0x007E6B5F
		// (set) Token: 0x0603AD94 RID: 241044 RVA: 0x007E8967 File Offset: 0x007E6B67
		public object Value { get; set; }

		// Token: 0x0603AD95 RID: 241045 RVA: 0x007E8970 File Offset: 0x007E6B70
		public TRemovePreloadResourceConfigUnion()
		{
			this.Type = TRemovePreloadResourceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD96 RID: 241046 RVA: 0x007E8986 File Offset: 0x007E6B86
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD97 RID: 241047 RVA: 0x007E8998 File Offset: 0x007E6B98
		public IRemovePreloadFlowsT AsIRemovePreloadFlows()
		{
			return this.As<IRemovePreloadFlowsT>();
		}

		// Token: 0x0603AD98 RID: 241048 RVA: 0x007E89A0 File Offset: 0x007E6BA0
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadFlows(IRemovePreloadFlowsT _iremovepreloadflows)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadFlows,
				Value = _iremovepreloadflows
			};
		}

		// Token: 0x0603AD99 RID: 241049 RVA: 0x007E89B5 File Offset: 0x007E6BB5
		public IRemovePreloadLinkResourceT AsIRemovePreloadLinkResource()
		{
			return this.As<IRemovePreloadLinkResourceT>();
		}

		// Token: 0x0603AD9A RID: 241050 RVA: 0x007E89BD File Offset: 0x007E6BBD
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadLinkResource(IRemovePreloadLinkResourceT _iremovepreloadlinkresource)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadLinkResource,
				Value = _iremovepreloadlinkresource
			};
		}

		// Token: 0x0603AD9B RID: 241051 RVA: 0x007E89D2 File Offset: 0x007E6BD2
		public IRemovePreloadResourcePhantomCharacterT AsIRemovePreloadResourcePhantomCharacter()
		{
			return this.As<IRemovePreloadResourcePhantomCharacterT>();
		}

		// Token: 0x0603AD9C RID: 241052 RVA: 0x007E89DA File Offset: 0x007E6BDA
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadResourcePhantomCharacter(IRemovePreloadResourcePhantomCharacterT _iremovepreloadresourcephantomcharacter)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadResourcePhantomCharacter,
				Value = _iremovepreloadresourcephantomcharacter
			};
		}

		// Token: 0x0603AD9D RID: 241053 RVA: 0x007E89EF File Offset: 0x007E6BEF
		public IRemovePreloadResourceTrialCharacterT AsIRemovePreloadResourceTrialCharacter()
		{
			return this.As<IRemovePreloadResourceTrialCharacterT>();
		}

		// Token: 0x0603AD9E RID: 241054 RVA: 0x007E89F7 File Offset: 0x007E6BF7
		public static TRemovePreloadResourceConfigUnion FromIRemovePreloadResourceTrialCharacter(IRemovePreloadResourceTrialCharacterT _iremovepreloadresourcetrialcharacter)
		{
			return new TRemovePreloadResourceConfigUnion
			{
				Type = TRemovePreloadResourceConfig.IRemovePreloadResourceTrialCharacter,
				Value = _iremovepreloadresourcetrialcharacter
			};
		}

		// Token: 0x0603AD9F RID: 241055 RVA: 0x007E8A0C File Offset: 0x007E6C0C
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
