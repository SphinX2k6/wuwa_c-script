using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F7 RID: 24823
	public struct ITriggerMatchConfig : IFlatbufferObject
	{
		// Token: 0x1700B8CA RID: 47306
		// (get) Token: 0x0602A120 RID: 172320 RVA: 0x005BE34F File Offset: 0x005BC54F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A121 RID: 172321 RVA: 0x005BE35C File Offset: 0x005BC55C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A122 RID: 172322 RVA: 0x005BE364 File Offset: 0x005BC564
		public static ITriggerMatchConfig GetRootAsITriggerMatchConfig(ByteBuffer _bb)
		{
			return ITriggerMatchConfig.GetRootAsITriggerMatchConfig(_bb, default(ITriggerMatchConfig));
		}

		// Token: 0x0602A123 RID: 172323 RVA: 0x005BE380 File Offset: 0x005BC580
		public static ITriggerMatchConfig GetRootAsITriggerMatchConfig(ByteBuffer _bb, ITriggerMatchConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A124 RID: 172324 RVA: 0x005BE39D File Offset: 0x005BC59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A125 RID: 172325 RVA: 0x005BE3AC File Offset: 0x005BC5AC
		public ITriggerMatchConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8CB RID: 47307
		// (get) Token: 0x0602A126 RID: 172326 RVA: 0x005BE3BC File Offset: 0x005BC5BC
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

		// Token: 0x0602A127 RID: 172327 RVA: 0x005BE3F8 File Offset: 0x005BC5F8
		public TTable? EntityMatch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A128 RID: 172328 RVA: 0x005BE43C File Offset: 0x005BC63C
		public IEntityMatchAllCharacter EntityMatchAsIEntityMatchAllCharacter()
		{
			return this.EntityMatch<IEntityMatchAllCharacter>().Value;
		}

		// Token: 0x0602A129 RID: 172329 RVA: 0x005BE458 File Offset: 0x005BC658
		public IEntityMatchDynamic EntityMatchAsIEntityMatchDynamic()
		{
			return this.EntityMatch<IEntityMatchDynamic>().Value;
		}

		// Token: 0x0602A12A RID: 172330 RVA: 0x005BE474 File Offset: 0x005BC674
		public IEntityMatchPlayer EntityMatchAsIEntityMatchPlayer()
		{
			return this.EntityMatch<IEntityMatchPlayer>().Value;
		}

		// Token: 0x0602A12B RID: 172331 RVA: 0x005BE490 File Offset: 0x005BC690
		public IEntityMatchSpecificBp EntityMatchAsIEntityMatchSpecificBp()
		{
			return this.EntityMatch<IEntityMatchSpecificBp>().Value;
		}

		// Token: 0x1700B8CC RID: 47308
		// (get) Token: 0x0602A12C RID: 172332 RVA: 0x005BE4AC File Offset: 0x005BC6AC
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

		// Token: 0x1700B8CD RID: 47309
		// (get) Token: 0x0602A12D RID: 172333 RVA: 0x005BE4E8 File Offset: 0x005BC6E8
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

		// Token: 0x0602A12E RID: 172334 RVA: 0x005BE525 File Offset: 0x005BC725
		public static Offset<ITriggerMatchConfig> CreateITriggerMatchConfig(FlatBufferBuilder builder, TEntityMatch EntityMatch_type = TEntityMatch.NONE, int EntityMatchOffset = 0, int EntityMatchCount = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITriggerMatchConfig.AddEntityMatchCount(builder, EntityMatchCount);
			ITriggerMatchConfig.AddEntityMatch(builder, EntityMatchOffset);
			ITriggerMatchConfig.AddNullMask(builder, NullMask);
			ITriggerMatchConfig.AddEntityMatchType(builder, EntityMatch_type);
			return ITriggerMatchConfig.EndITriggerMatchConfig(builder);
		}

		// Token: 0x0602A12F RID: 172335 RVA: 0x005BE551 File Offset: 0x005BC751
		public static void StartITriggerMatchConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A130 RID: 172336 RVA: 0x005BE55A File Offset: 0x005BC75A
		public static void AddEntityMatchType(FlatBufferBuilder builder, TEntityMatch entityMatchType)
		{
			builder.AddByte(0, (byte)entityMatchType, 0);
		}

		// Token: 0x0602A131 RID: 172337 RVA: 0x005BE565 File Offset: 0x005BC765
		public static void AddEntityMatch(FlatBufferBuilder builder, int entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset, 0);
		}

		// Token: 0x0602A132 RID: 172338 RVA: 0x005BE570 File Offset: 0x005BC770
		public static void AddEntityMatchCount(FlatBufferBuilder builder, int entityMatchCount)
		{
			builder.AddInt(2, entityMatchCount, 0);
		}

		// Token: 0x0602A133 RID: 172339 RVA: 0x005BE57B File Offset: 0x005BC77B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A134 RID: 172340 RVA: 0x005BE586 File Offset: 0x005BC786
		public static Offset<ITriggerMatchConfig> EndITriggerMatchConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerMatchConfig>(builder.EndTable());
		}

		// Token: 0x0602A135 RID: 172341 RVA: 0x005BE594 File Offset: 0x005BC794
		public ITriggerMatchConfigT UnPack()
		{
			ITriggerMatchConfigT triggerMatchConfigT = new ITriggerMatchConfigT();
			this.UnPackTo(triggerMatchConfigT);
			return triggerMatchConfigT;
		}

		// Token: 0x0602A136 RID: 172342 RVA: 0x005BE5B0 File Offset: 0x005BC7B0
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

		// Token: 0x0602A137 RID: 172343 RVA: 0x005BE6F8 File Offset: 0x005BC8F8
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

		// Token: 0x0400FEDA RID: 65242
		private Table __p;
	}
}
