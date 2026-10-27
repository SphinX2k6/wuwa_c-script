using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC7 RID: 24007
	public struct IGiantResponseType : IFlatbufferObject
	{
		// Token: 0x1700B3BC RID: 46012
		// (get) Token: 0x06029170 RID: 168304 RVA: 0x005A3F04 File Offset: 0x005A2104
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029171 RID: 168305 RVA: 0x005A3F11 File Offset: 0x005A2111
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029172 RID: 168306 RVA: 0x005A3F18 File Offset: 0x005A2118
		public static IGiantResponseType GetRootAsIGiantResponseType(ByteBuffer _bb)
		{
			return IGiantResponseType.GetRootAsIGiantResponseType(_bb, default(IGiantResponseType));
		}

		// Token: 0x06029173 RID: 168307 RVA: 0x005A3F34 File Offset: 0x005A2134
		public static IGiantResponseType GetRootAsIGiantResponseType(ByteBuffer _bb, IGiantResponseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029174 RID: 168308 RVA: 0x005A3F51 File Offset: 0x005A2151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029175 RID: 168309 RVA: 0x005A3F60 File Offset: 0x005A2160
		public IGiantResponseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3BD RID: 46013
		// (get) Token: 0x06029176 RID: 168310 RVA: 0x005A3F70 File Offset: 0x005A2170
		public EGiantResponseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantResponseType.PlayAnimation;
				}
				return (EGiantResponseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029177 RID: 168311 RVA: 0x005A3FAC File Offset: 0x005A21AC
		public static Offset<IGiantResponseType> CreateIGiantResponseType(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation)
		{
			builder.StartTable(1);
			IGiantResponseType.AddType(builder, Type);
			return IGiantResponseType.EndIGiantResponseType(builder);
		}

		// Token: 0x06029178 RID: 168312 RVA: 0x005A3FC2 File Offset: 0x005A21C2
		public static void StartIGiantResponseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029179 RID: 168313 RVA: 0x005A3FCB File Offset: 0x005A21CB
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602917A RID: 168314 RVA: 0x005A3FD6 File Offset: 0x005A21D6
		public static Offset<IGiantResponseType> EndIGiantResponseType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponseType>(builder.EndTable());
		}

		// Token: 0x0602917B RID: 168315 RVA: 0x005A3FE4 File Offset: 0x005A21E4
		public IGiantResponseTypeT UnPack()
		{
			IGiantResponseTypeT giantResponseTypeT = new IGiantResponseTypeT();
			this.UnPackTo(giantResponseTypeT);
			return giantResponseTypeT;
		}

		// Token: 0x0602917C RID: 168316 RVA: 0x005A3FFF File Offset: 0x005A21FF
		public void UnPackTo(IGiantResponseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602917D RID: 168317 RVA: 0x005A4010 File Offset: 0x005A2210
		public static Offset<IGiantResponseType> Pack(FlatBufferBuilder builder, IGiantResponseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponseType>);
			}
			return IGiantResponseType.CreateIGiantResponseType(builder, _o.Type);
		}

		// Token: 0x0400F7A8 RID: 63400
		private Table __p;
	}
}
