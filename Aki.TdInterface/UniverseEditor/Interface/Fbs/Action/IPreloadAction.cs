using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007504 RID: 29956
	public struct IPreloadAction : IFlatbufferObject
	{
		// Token: 0x1700DC7C RID: 56444
		// (get) Token: 0x06034882 RID: 215170 RVA: 0x0071235A File Offset: 0x0071055A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034883 RID: 215171 RVA: 0x00712367 File Offset: 0x00710567
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034884 RID: 215172 RVA: 0x00712370 File Offset: 0x00710570
		public static IPreloadAction GetRootAsIPreloadAction(ByteBuffer _bb)
		{
			return IPreloadAction.GetRootAsIPreloadAction(_bb, default(IPreloadAction));
		}

		// Token: 0x06034885 RID: 215173 RVA: 0x0071238C File Offset: 0x0071058C
		public static IPreloadAction GetRootAsIPreloadAction(ByteBuffer _bb, IPreloadAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034886 RID: 215174 RVA: 0x007123A9 File Offset: 0x007105A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034887 RID: 215175 RVA: 0x007123B8 File Offset: 0x007105B8
		public IPreloadAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC7D RID: 56445
		// (get) Token: 0x06034888 RID: 215176 RVA: 0x007123C8 File Offset: 0x007105C8
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

		// Token: 0x06034889 RID: 215177 RVA: 0x00712404 File Offset: 0x00710604
		public TTable? PreloadObjectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603488A RID: 215178 RVA: 0x00712448 File Offset: 0x00710648
		public IPreloadFlows PreloadObjectTypeAsIPreloadFlows()
		{
			return this.PreloadObjectType<IPreloadFlows>().Value;
		}

		// Token: 0x0603488B RID: 215179 RVA: 0x00712464 File Offset: 0x00710664
		public IPreloadLinkResource PreloadObjectTypeAsIPreloadLinkResource()
		{
			return this.PreloadObjectType<IPreloadLinkResource>().Value;
		}

		// Token: 0x0603488C RID: 215180 RVA: 0x00712480 File Offset: 0x00710680
		public IPreloadMp4s PreloadObjectTypeAsIPreloadMp4s()
		{
			return this.PreloadObjectType<IPreloadMp4s>().Value;
		}

		// Token: 0x0603488D RID: 215181 RVA: 0x0071249C File Offset: 0x0071069C
		public IPreloadPhantomCharacterForSkill PreloadObjectTypeAsIPreloadPhantomCharacterForSkill()
		{
			return this.PreloadObjectType<IPreloadPhantomCharacterForSkill>().Value;
		}

		// Token: 0x0603488E RID: 215182 RVA: 0x007124B8 File Offset: 0x007106B8
		public IPreloadTrialCharacterForSkill PreloadObjectTypeAsIPreloadTrialCharacterForSkill()
		{
			return this.PreloadObjectType<IPreloadTrialCharacterForSkill>().Value;
		}

		// Token: 0x0603488F RID: 215183 RVA: 0x007124D3 File Offset: 0x007106D3
		public static Offset<IPreloadAction> CreateIPreloadAction(FlatBufferBuilder builder, TPreloadObjectTypeConfig PreloadObjectType_type = TPreloadObjectTypeConfig.NONE, int PreloadObjectTypeOffset = 0)
		{
			builder.StartTable(2);
			IPreloadAction.AddPreloadObjectType(builder, PreloadObjectTypeOffset);
			IPreloadAction.AddPreloadObjectTypeType(builder, PreloadObjectType_type);
			return IPreloadAction.EndIPreloadAction(builder);
		}

		// Token: 0x06034890 RID: 215184 RVA: 0x007124F0 File Offset: 0x007106F0
		public static void StartIPreloadAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034891 RID: 215185 RVA: 0x007124F9 File Offset: 0x007106F9
		public static void AddPreloadObjectTypeType(FlatBufferBuilder builder, TPreloadObjectTypeConfig preloadObjectTypeType)
		{
			builder.AddByte(0, (byte)preloadObjectTypeType, 0);
		}

		// Token: 0x06034892 RID: 215186 RVA: 0x00712504 File Offset: 0x00710704
		public static void AddPreloadObjectType(FlatBufferBuilder builder, int preloadObjectTypeOffset)
		{
			builder.AddOffset(1, preloadObjectTypeOffset, 0);
		}

		// Token: 0x06034893 RID: 215187 RVA: 0x0071250F File Offset: 0x0071070F
		public static Offset<IPreloadAction> EndIPreloadAction(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadAction>(builder.EndTable());
		}

		// Token: 0x06034894 RID: 215188 RVA: 0x0071251C File Offset: 0x0071071C
		public IPreloadActionT UnPack()
		{
			IPreloadActionT preloadActionT = new IPreloadActionT();
			this.UnPackTo(preloadActionT);
			return preloadActionT;
		}

		// Token: 0x06034895 RID: 215189 RVA: 0x00712538 File Offset: 0x00710738
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

		// Token: 0x06034896 RID: 215190 RVA: 0x00712698 File Offset: 0x00710898
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

		// Token: 0x040126D3 RID: 75475
		private Table __p;
	}
}
