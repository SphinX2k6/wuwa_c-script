using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B6 RID: 29366
	public struct ITalkEffectType : IFlatbufferObject
	{
		// Token: 0x1700D9D7 RID: 55767
		// (get) Token: 0x060341CB RID: 213451 RVA: 0x00701144 File Offset: 0x006FF344
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060341CC RID: 213452 RVA: 0x00701151 File Offset: 0x006FF351
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060341CD RID: 213453 RVA: 0x00701158 File Offset: 0x006FF358
		public static ITalkEffectType GetRootAsITalkEffectType(ByteBuffer _bb)
		{
			return ITalkEffectType.GetRootAsITalkEffectType(_bb, default(ITalkEffectType));
		}

		// Token: 0x060341CE RID: 213454 RVA: 0x00701174 File Offset: 0x006FF374
		public static ITalkEffectType GetRootAsITalkEffectType(ByteBuffer _bb, ITalkEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060341CF RID: 213455 RVA: 0x00701191 File Offset: 0x006FF391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060341D0 RID: 213456 RVA: 0x007011A0 File Offset: 0x006FF3A0
		public ITalkEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9D8 RID: 55768
		// (get) Token: 0x060341D1 RID: 213457 RVA: 0x007011B0 File Offset: 0x006FF3B0
		public ETalkEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectType.Effect;
				}
				return (ETalkEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341D2 RID: 213458 RVA: 0x007011EC File Offset: 0x006FF3EC
		public static Offset<ITalkEffectType> CreateITalkEffectType(FlatBufferBuilder builder, ETalkEffectType Type = ETalkEffectType.Effect)
		{
			builder.StartTable(1);
			ITalkEffectType.AddType(builder, Type);
			return ITalkEffectType.EndITalkEffectType(builder);
		}

		// Token: 0x060341D3 RID: 213459 RVA: 0x00701202 File Offset: 0x006FF402
		public static void StartITalkEffectType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060341D4 RID: 213460 RVA: 0x0070120B File Offset: 0x006FF40B
		public static void AddType(FlatBufferBuilder builder, ETalkEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060341D5 RID: 213461 RVA: 0x00701216 File Offset: 0x006FF416
		public static Offset<ITalkEffectType> EndITalkEffectType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectType>(builder.EndTable());
		}

		// Token: 0x060341D6 RID: 213462 RVA: 0x00701224 File Offset: 0x006FF424
		public ITalkEffectTypeT UnPack()
		{
			ITalkEffectTypeT talkEffectTypeT = new ITalkEffectTypeT();
			this.UnPackTo(talkEffectTypeT);
			return talkEffectTypeT;
		}

		// Token: 0x060341D7 RID: 213463 RVA: 0x0070123F File Offset: 0x006FF43F
		public void UnPackTo(ITalkEffectTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060341D8 RID: 213464 RVA: 0x00701250 File Offset: 0x006FF450
		public static Offset<ITalkEffectType> Pack(FlatBufferBuilder builder, ITalkEffectTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectType>);
			}
			return ITalkEffectType.CreateITalkEffectType(builder, _o.Type);
		}

		// Token: 0x04011DD7 RID: 73175
		private Table __p;
	}
}
