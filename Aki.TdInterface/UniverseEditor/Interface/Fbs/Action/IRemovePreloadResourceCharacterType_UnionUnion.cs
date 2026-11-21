using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E3 RID: 30179
	public class IRemovePreloadResourceCharacterType_UnionUnion
	{
		// Token: 0x1700DDCB RID: 56779
		// (get) Token: 0x06034F0C RID: 216844 RVA: 0x0071D0B9 File Offset: 0x0071B2B9
		// (set) Token: 0x06034F0D RID: 216845 RVA: 0x0071D0C1 File Offset: 0x0071B2C1
		public IRemovePreloadResourceCharacterType_Union Type { get; set; }

		// Token: 0x1700DDCC RID: 56780
		// (get) Token: 0x06034F0E RID: 216846 RVA: 0x0071D0CA File Offset: 0x0071B2CA
		// (set) Token: 0x06034F0F RID: 216847 RVA: 0x0071D0D2 File Offset: 0x0071B2D2
		public object Value { get; set; }

		// Token: 0x06034F10 RID: 216848 RVA: 0x0071D0DB File Offset: 0x0071B2DB
		public IRemovePreloadResourceCharacterType_UnionUnion()
		{
			this.Type = IRemovePreloadResourceCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034F11 RID: 216849 RVA: 0x0071D0F1 File Offset: 0x0071B2F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034F12 RID: 216850 RVA: 0x0071D103 File Offset: 0x0071B303
		public IRemovePreloadResourceCharacterTypeT AsIRemovePreloadResourceCharacterType()
		{
			return this.As<IRemovePreloadResourceCharacterTypeT>();
		}

		// Token: 0x06034F13 RID: 216851 RVA: 0x0071D10B File Offset: 0x0071B30B
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourceCharacterType(IRemovePreloadResourceCharacterTypeT _iremovepreloadresourcecharactertype)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceCharacterType,
				Value = _iremovepreloadresourcecharactertype
			};
		}

		// Token: 0x06034F14 RID: 216852 RVA: 0x0071D120 File Offset: 0x0071B320
		public IRemovePreloadResourceTrialCharacterT AsIRemovePreloadResourceTrialCharacter()
		{
			return this.As<IRemovePreloadResourceTrialCharacterT>();
		}

		// Token: 0x06034F15 RID: 216853 RVA: 0x0071D128 File Offset: 0x0071B328
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourceTrialCharacter(IRemovePreloadResourceTrialCharacterT _iremovepreloadresourcetrialcharacter)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourceTrialCharacter,
				Value = _iremovepreloadresourcetrialcharacter
			};
		}

		// Token: 0x06034F16 RID: 216854 RVA: 0x0071D13D File Offset: 0x0071B33D
		public IRemovePreloadFlowsT AsIRemovePreloadFlows()
		{
			return this.As<IRemovePreloadFlowsT>();
		}

		// Token: 0x06034F17 RID: 216855 RVA: 0x0071D145 File Offset: 0x0071B345
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadFlows(IRemovePreloadFlowsT _iremovepreloadflows)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadFlows,
				Value = _iremovepreloadflows
			};
		}

		// Token: 0x06034F18 RID: 216856 RVA: 0x0071D15A File Offset: 0x0071B35A
		public IRemovePreloadResourcePhantomCharacterT AsIRemovePreloadResourcePhantomCharacter()
		{
			return this.As<IRemovePreloadResourcePhantomCharacterT>();
		}

		// Token: 0x06034F19 RID: 216857 RVA: 0x0071D162 File Offset: 0x0071B362
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadResourcePhantomCharacter(IRemovePreloadResourcePhantomCharacterT _iremovepreloadresourcephantomcharacter)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadResourcePhantomCharacter,
				Value = _iremovepreloadresourcephantomcharacter
			};
		}

		// Token: 0x06034F1A RID: 216858 RVA: 0x0071D177 File Offset: 0x0071B377
		public IRemovePreloadLinkResourceT AsIRemovePreloadLinkResource()
		{
			return this.As<IRemovePreloadLinkResourceT>();
		}

		// Token: 0x06034F1B RID: 216859 RVA: 0x0071D17F File Offset: 0x0071B37F
		public static IRemovePreloadResourceCharacterType_UnionUnion FromIRemovePreloadLinkResource(IRemovePreloadLinkResourceT _iremovepreloadlinkresource)
		{
			return new IRemovePreloadResourceCharacterType_UnionUnion
			{
				Type = IRemovePreloadResourceCharacterType_Union.IRemovePreloadLinkResource,
				Value = _iremovepreloadlinkresource
			};
		}

		// Token: 0x06034F1C RID: 216860 RVA: 0x0071D194 File Offset: 0x0071B394
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
