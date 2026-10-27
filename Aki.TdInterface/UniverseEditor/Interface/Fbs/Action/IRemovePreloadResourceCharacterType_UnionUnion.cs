using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E62 RID: 28258
	public class IRemovePreloadResourceCharacterType_UnionUnion
	{
		// Token: 0x1700D279 RID: 53881
		// (get) Token: 0x06031EE4 RID: 204516 RVA: 0x006C15B9 File Offset: 0x006BF7B9
		// (set) Token: 0x06031EE5 RID: 204517 RVA: 0x006C15C1 File Offset: 0x006BF7C1
		public IRemovePreloadResourceCharacterType_Union Type { get; set; }

		// Token: 0x1700D27A RID: 53882
		// (get) Token: 0x06031EE6 RID: 204518 RVA: 0x006C15CA File Offset: 0x006BF7CA
		// (set) Token: 0x06031EE7 RID: 204519 RVA: 0x006C15D2 File Offset: 0x006BF7D2
		public object Value { get; set; }

		// Token: 0x06031EE8 RID: 204520 RVA: 0x006C15DB File Offset: 0x006BF7DB
		public IRemovePreloadResourceCharacterType_UnionUnion()
		{
			this.Type = IRemovePreloadResourceCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031EE9 RID: 204521 RVA: 0x006C15F1 File Offset: 0x006BF7F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031EEA RID: 204522 RVA: 0x006C1603 File Offset: 0x006BF803
		public IRemovePreloadResourceCharacterTypeT AsIRemovePreloadResourceCharacterType()
		{
			return this.As<IRemovePreloadResourceCharacterTypeT>();
		}

		// Token: 0x06031EEB RID: 204523 RVA: 0x006C160B File Offset: 0x006BF80B
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourceCharacterType(IRemovePreloadResourceCharacterTypeT _iremovepreloadresourcecharactertype)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceCharacterType,
				Value = _iremovepreloadresourcecharactertype
			};
		}

		// Token: 0x06031EEC RID: 204524 RVA: 0x006C1620 File Offset: 0x006BF820
		public IRemovePreloadResourceTrialCharacterT AsIRemovePreloadResourceTrialCharacter()
		{
			return this.As<IRemovePreloadResourceTrialCharacterT>();
		}

		// Token: 0x06031EED RID: 204525 RVA: 0x006C1628 File Offset: 0x006BF828
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourceTrialCharacter(IRemovePreloadResourceTrialCharacterT _iremovepreloadresourcetrialcharacter)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceTrialCharacter,
				Value = _iremovepreloadresourcetrialcharacter
			};
		}

		// Token: 0x06031EEE RID: 204526 RVA: 0x006C163D File Offset: 0x006BF83D
		public IRemovePreloadFlowsT AsIRemovePreloadFlows()
		{
			return this.As<IRemovePreloadFlowsT>();
		}

		// Token: 0x06031EEF RID: 204527 RVA: 0x006C1645 File Offset: 0x006BF845
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadFlows(IRemovePreloadFlowsT _iremovepreloadflows)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadFlows,
				Value = _iremovepreloadflows
			};
		}

		// Token: 0x06031EF0 RID: 204528 RVA: 0x006C165A File Offset: 0x006BF85A
		public IRemovePreloadResourcePhantomCharacterT AsIRemovePreloadResourcePhantomCharacter()
		{
			return this.As<IRemovePreloadResourcePhantomCharacterT>();
		}

		// Token: 0x06031EF1 RID: 204529 RVA: 0x006C1662 File Offset: 0x006BF862
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourcePhantomCharacter(IRemovePreloadResourcePhantomCharacterT _iremovepreloadresourcephantomcharacter)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourcePhantomCharacter,
				Value = _iremovepreloadresourcephantomcharacter
			};
		}

		// Token: 0x06031EF2 RID: 204530 RVA: 0x006C1677 File Offset: 0x006BF877
		public IRemovePreloadLinkResourceT AsIRemovePreloadLinkResource()
		{
			return this.As<IRemovePreloadLinkResourceT>();
		}

		// Token: 0x06031EF3 RID: 204531 RVA: 0x006C167F File Offset: 0x006BF87F
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadLinkResource(IRemovePreloadLinkResourceT _iremovepreloadlinkresource)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadLinkResource,
				Value = _iremovepreloadlinkresource
			};
		}

		// Token: 0x06031EF4 RID: 204532 RVA: 0x006C1694 File Offset: 0x006BF894
		public static int Pack(FlatBufferBuilder builder, IRemovePreloadResourceCharacterType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceCharacterType:
				return IRemovePreloadResourceCharacterType.Pack(builder, _o.AsIRemovePreloadResourceCharacterType()).Value;
			case IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceTrialCharacter:
				return IRemovePreloadResourceTrialCharacter.Pack(builder, _o.AsIRemovePreloadResourceTrialCharacter()).Value;
			case IRemovePreloadResourceCharacterType_Union.IRemovePreloadFlows:
				return IRemovePreloadFlows.Pack(builder, _o.AsIRemovePreloadFlows()).Value;
			case IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourcePhantomCharacter:
				return IRemovePreloadResourcePhantomCharacter.Pack(builder, _o.AsIRemovePreloadResourcePhantomCharacter()).Value;
			case IRemovePreloadResourceCharacterType_Union.IRemovePreloadLinkResource:
				return IRemovePreloadLinkResource.Pack(builder, _o.AsIRemovePreloadLinkResource()).Value;
			default:
				return 0;
			}
		}
	}
}
