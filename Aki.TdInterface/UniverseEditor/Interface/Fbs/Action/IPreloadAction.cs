using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D89 RID: 28041
	public struct IPreloadAction : IFlatbufferObject
	{
		// Token: 0x1700D134 RID: 53556
		// (get) Token: 0x06031886 RID: 202886 RVA: 0x006B6C72 File Offset: 0x006B4E72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031887 RID: 202887 RVA: 0x006B6C7F File Offset: 0x006B4E7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031888 RID: 202888 RVA: 0x006B6C88 File Offset: 0x006B4E88
		public static IPreloadAction GetRootAsIPreloadAction(ByteBuffer _bb)
		{
			return IPreloadAction.GetRootAsIPreloadAction(_bb, default(IPreloadAction));
		}

		// Token: 0x06031889 RID: 202889 RVA: 0x006B6CA4 File Offset: 0x006B4EA4
		public static IPreloadAction GetRootAsIPreloadAction(ByteBuffer _bb, IPreloadAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603188A RID: 202890 RVA: 0x006B6CC1 File Offset: 0x006B4EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603188B RID: 202891 RVA: 0x006B6CD0 File Offset: 0x006B4ED0
		public IPreloadAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D135 RID: 53557
		// (get) Token: 0x0603188C RID: 202892 RVA: 0x006B6CE0 File Offset: 0x006B4EE0
		public TPreloadObjectTypeConfig PreloadObjectTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPreloadObjectTypeConfig.NONE;
				}
				return (TPreloadObjectTypeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603188D RID: 202893 RVA: 0x006B6D1C File Offset: 0x006B4F1C
		public TTable? PreloadObjectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603188E RID: 202894 RVA: 0x006B6D60 File Offset: 0x006B4F60
		public IPreloadFlows PreloadObjectTypeAsIPreloadFlows()
		{
			return this.PreloadObjectType<IPreloadFlows>().Value;
		}

		// Token: 0x0603188F RID: 202895 RVA: 0x006B6D7C File Offset: 0x006B4F7C
		public IPreloadLinkResource PreloadObjectTypeAsIPreloadLinkResource()
		{
			return this.PreloadObjectType<IPreloadLinkResource>().Value;
		}

		// Token: 0x06031890 RID: 202896 RVA: 0x006B6D98 File Offset: 0x006B4F98
		public IPreloadMp4s PreloadObjectTypeAsIPreloadMp4s()
		{
			return this.PreloadObjectType<IPreloadMp4s>().Value;
		}

		// Token: 0x06031891 RID: 202897 RVA: 0x006B6DB4 File Offset: 0x006B4FB4
		public IPreloadPhantomCharacterForSkill PreloadObjectTypeAsIPreloadPhantomCharacterForSkill()
		{
			return this.PreloadObjectType<IPreloadPhantomCharacterForSkill>().Value;
		}

		// Token: 0x06031892 RID: 202898 RVA: 0x006B6DD0 File Offset: 0x006B4FD0
		public IPreloadTrialCharacterForSkill PreloadObjectTypeAsIPreloadTrialCharacterForSkill()
		{
			return this.PreloadObjectType<IPreloadTrialCharacterForSkill>().Value;
		}

		// Token: 0x06031893 RID: 202899 RVA: 0x006B6DEB File Offset: 0x006B4FEB
		public static Offset<IPreloadAction> CreateIPreloadAction(FlatBufferBuilder builder, TPreloadObjectTypeConfig PreloadObjectType_type = TPreloadObjectTypeConfig.NONE, int PreloadObjectTypeOffset = 0)
		{
			builder.StartTable(2);
			IPreloadAction.AddPreloadObjectType(builder, PreloadObjectTypeOffset);
			IPreloadAction.AddPreloadObjectTypeType(builder, PreloadObjectType_type);
			return IPreloadAction.EndIPreloadAction(builder);
		}

		// Token: 0x06031894 RID: 202900 RVA: 0x006B6E08 File Offset: 0x006B5008
		public static void StartIPreloadAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031895 RID: 202901 RVA: 0x006B6E11 File Offset: 0x006B5011
		public static void AddPreloadObjectTypeType(FlatBufferBuilder builder, TPreloadObjectTypeConfig preloadObjectTypeType)
		{
			builder.AddByte(0, (byte)preloadObjectTypeType, 0);
		}

		// Token: 0x06031896 RID: 202902 RVA: 0x006B6E1C File Offset: 0x006B501C
		public static void AddPreloadObjectType(FlatBufferBuilder builder, int preloadObjectTypeOffset)
		{
			builder.AddOffset(1, preloadObjectTypeOffset, 0);
		}

		// Token: 0x06031897 RID: 202903 RVA: 0x006B6E27 File Offset: 0x006B5027
		public static Offset<IPreloadAction> EndIPreloadAction(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadAction>(builder.EndTable());
		}

		// Token: 0x06031898 RID: 202904 RVA: 0x006B6E34 File Offset: 0x006B5034
		public IPreloadActionT UnPack()
		{
			IPreloadActionT preloadActionT = new IPreloadActionT();
			this.UnPackTo(preloadActionT);
			return preloadActionT;
		}

		// Token: 0x06031899 RID: 202905 RVA: 0x006B6E50 File Offset: 0x006B5050
		public void UnPackTo(IPreloadActionT _o)
		{
			_o.PreloadObjectType = new TPreloadObjectTypeConfigUnion();
			_o.PreloadObjectType.Type = this.PreloadObjectTypeType;
			switch (this.PreloadObjectTypeType)
			{
			case TPreloadObjectTypeConfig.IPreloadFlows:
				_o.PreloadObjectType.Value = ((this.PreloadObjectType<IPreloadFlows>() != null) ? this.PreloadObjectType<IPreloadFlows>().Value.UnPack() : null);
				return;
			case TPreloadObjectTypeConfig.IPreloadLinkResource:
				_o.PreloadObjectType.Value = ((this.PreloadObjectType<IPreloadLinkResource>() != null) ? this.PreloadObjectType<IPreloadLinkResource>().Value.UnPack() : null);
				return;
			case TPreloadObjectTypeConfig.IPreloadMp4s:
				_o.PreloadObjectType.Value = ((this.PreloadObjectType<IPreloadMp4s>() != null) ? this.PreloadObjectType<IPreloadMp4s>().Value.UnPack() : null);
				return;
			case TPreloadObjectTypeConfig.IPreloadPhantomCharacterForSkill:
				_o.PreloadObjectType.Value = ((this.PreloadObjectType<IPreloadPhantomCharacterForSkill>() != null) ? this.PreloadObjectType<IPreloadPhantomCharacterForSkill>().Value.UnPack() : null);
				return;
			case TPreloadObjectTypeConfig.IPreloadTrialCharacterForSkill:
				_o.PreloadObjectType.Value = ((this.PreloadObjectType<IPreloadTrialCharacterForSkill>() != null) ? this.PreloadObjectType<IPreloadTrialCharacterForSkill>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603189A RID: 202906 RVA: 0x006B6FB0 File Offset: 0x006B51B0
		public static Offset<IPreloadAction> Pack(FlatBufferBuilder builder, IPreloadActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadAction>);
			}
			TPreloadObjectTypeConfig preloadObjectType_type = (_o.PreloadObjectType == null) ? TPreloadObjectTypeConfig.NONE : _o.PreloadObjectType.Type;
			int preloadObjectTypeOffset = (_o.PreloadObjectType == null) ? 0 : TPreloadObjectTypeConfigUnion.Pack(builder, _o.PreloadObjectType);
			return IPreloadAction.CreateIPreloadAction(builder, preloadObjectType_type, preloadObjectTypeOffset);
		}

		// Token: 0x04011757 RID: 71511
		private Table __p;
	}
}
