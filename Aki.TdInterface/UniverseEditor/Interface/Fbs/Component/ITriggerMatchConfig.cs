using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEA RID: 23274
	public struct ITriggerMatchConfig : IFlatbufferObject
	{
		// Token: 0x1700AF8E RID: 44942
		// (get) Token: 0x06027B94 RID: 162708 RVA: 0x00576E8B File Offset: 0x0057508B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B95 RID: 162709 RVA: 0x00576E98 File Offset: 0x00575098
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B96 RID: 162710 RVA: 0x00576EA0 File Offset: 0x005750A0
		public static ITriggerMatchConfig GetRootAsITriggerMatchConfig(ByteBuffer _bb)
		{
			return ITriggerMatchConfig.GetRootAsITriggerMatchConfig(_bb, default(ITriggerMatchConfig));
		}

		// Token: 0x06027B97 RID: 162711 RVA: 0x00576EBC File Offset: 0x005750BC
		public static ITriggerMatchConfig GetRootAsITriggerMatchConfig(ByteBuffer _bb, ITriggerMatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B98 RID: 162712 RVA: 0x00576ED9 File Offset: 0x005750D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B99 RID: 162713 RVA: 0x00576EE8 File Offset: 0x005750E8
		public ITriggerMatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF8F RID: 44943
		// (get) Token: 0x06027B9A RID: 162714 RVA: 0x00576EF8 File Offset: 0x005750F8
		public TEntityMatch EntityMatchType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TEntityMatch.NONE;
				}
				return (TEntityMatch)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x00576F34 File Offset: 0x00575134
		public TTable? EntityMatch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x00576F78 File Offset: 0x00575178
		public IEntityMatchAllCharacter EntityMatchAsIEntityMatchAllCharacter()
		{
			return this.EntityMatch<IEntityMatchAllCharacter>().Value;
		}

		// Token: 0x06027B9D RID: 162717 RVA: 0x00576F94 File Offset: 0x00575194
		public IEntityMatchDynamic EntityMatchAsIEntityMatchDynamic()
		{
			return this.EntityMatch<IEntityMatchDynamic>().Value;
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x00576FB0 File Offset: 0x005751B0
		public IEntityMatchPlayer EntityMatchAsIEntityMatchPlayer()
		{
			return this.EntityMatch<IEntityMatchPlayer>().Value;
		}

		// Token: 0x06027B9F RID: 162719 RVA: 0x00576FCC File Offset: 0x005751CC
		public IEntityMatchSpecificBp EntityMatchAsIEntityMatchSpecificBp()
		{
			return this.EntityMatch<IEntityMatchSpecificBp>().Value;
		}

		// Token: 0x1700AF90 RID: 44944
		// (get) Token: 0x06027BA0 RID: 162720 RVA: 0x00576FE8 File Offset: 0x005751E8
		public int EntityMatchCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF91 RID: 44945
		// (get) Token: 0x06027BA1 RID: 162721 RVA: 0x00577024 File Offset: 0x00575224
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027BA2 RID: 162722 RVA: 0x00577061 File Offset: 0x00575261
		public static Offset<ITriggerMatchConfig> CreateITriggerMatchConfig(FlatBufferBuilder builder, TEntityMatch EntityMatch_type = TEntityMatch.NONE, int EntityMatchOffset = 0, int EntityMatchCount = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITriggerMatchConfig.AddEntityMatchCount(builder, EntityMatchCount);
			ITriggerMatchConfig.AddEntityMatch(builder, EntityMatchOffset);
			ITriggerMatchConfig.AddNullMask(builder, NullMask);
			ITriggerMatchConfig.AddEntityMatchType(builder, EntityMatch_type);
			return ITriggerMatchConfig.EndITriggerMatchConfig(builder);
		}

		// Token: 0x06027BA3 RID: 162723 RVA: 0x0057708D File Offset: 0x0057528D
		public static void StartITriggerMatchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027BA4 RID: 162724 RVA: 0x00577096 File Offset: 0x00575296
		public static void AddEntityMatchType(FlatBufferBuilder builder, TEntityMatch entityMatchType)
		{
			builder.AddByte(0, (byte)entityMatchType, 0);
		}

		// Token: 0x06027BA5 RID: 162725 RVA: 0x005770A1 File Offset: 0x005752A1
		public static void AddEntityMatch(FlatBufferBuilder builder, int entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset, 0);
		}

		// Token: 0x06027BA6 RID: 162726 RVA: 0x005770AC File Offset: 0x005752AC
		public static void AddEntityMatchCount(FlatBufferBuilder builder, int entityMatchCount)
		{
			builder.AddInt(2, entityMatchCount, 0);
		}

		// Token: 0x06027BA7 RID: 162727 RVA: 0x005770B7 File Offset: 0x005752B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027BA8 RID: 162728 RVA: 0x005770C2 File Offset: 0x005752C2
		public static Offset<ITriggerMatchConfig> EndITriggerMatchConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerMatchConfig>(builder.EndTable());
		}

		// Token: 0x06027BA9 RID: 162729 RVA: 0x005770D0 File Offset: 0x005752D0
		public ITriggerMatchConfigT UnPack()
		{
			ITriggerMatchConfigT triggerMatchConfigT = new ITriggerMatchConfigT();
			this.UnPackTo(triggerMatchConfigT);
			return triggerMatchConfigT;
		}

		// Token: 0x06027BAA RID: 162730 RVA: 0x005770EC File Offset: 0x005752EC
		public void UnPackTo(ITriggerMatchConfigT _o)
		{
			_o.EntityMatch = new TEntityMatchUnion();
			_o.EntityMatch.Type = this.EntityMatchType;
			switch (this.EntityMatchType)
			{
			case TEntityMatch.IEntityMatchAllCharacter:
				_o.EntityMatch.Value = ((this.EntityMatch<IEntityMatchAllCharacter>() != null) ? this.EntityMatch<IEntityMatchAllCharacter>().Value.UnPack() : null);
				break;
			case TEntityMatch.IEntityMatchDynamic:
				_o.EntityMatch.Value = ((this.EntityMatch<IEntityMatchDynamic>() != null) ? this.EntityMatch<IEntityMatchDynamic>().Value.UnPack() : null);
				break;
			case TEntityMatch.IEntityMatchPlayer:
				_o.EntityMatch.Value = ((this.EntityMatch<IEntityMatchPlayer>() != null) ? this.EntityMatch<IEntityMatchPlayer>().Value.UnPack() : null);
				break;
			case TEntityMatch.IEntityMatchSpecificBp:
				_o.EntityMatch.Value = ((this.EntityMatch<IEntityMatchSpecificBp>() != null) ? this.EntityMatch<IEntityMatchSpecificBp>().Value.UnPack() : null);
				break;
			}
			_o.EntityMatchCount = this.EntityMatchCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027BAB RID: 162731 RVA: 0x00577234 File Offset: 0x00575434
		public static Offset<ITriggerMatchConfig> Pack(FlatBufferBuilder builder, ITriggerMatchConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerMatchConfig>);
			}
			TEntityMatch entityMatch_type = (_o.EntityMatch == null) ? TEntityMatch.NONE : _o.EntityMatch.Type;
			int entityMatchOffset = (_o.EntityMatch == null) ? 0 : TEntityMatchUnion.Pack(builder, _o.EntityMatch);
			return ITriggerMatchConfig.CreateITriggerMatchConfig(builder, entityMatch_type, entityMatchOffset, _o.EntityMatchCount, _o.NullMask);
		}

		// Token: 0x0400F1E0 RID: 61920
		private Table __p;
	}
}
