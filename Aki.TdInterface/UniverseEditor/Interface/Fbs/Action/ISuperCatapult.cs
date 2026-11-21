using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A19 RID: 31257
	public struct ISuperCatapult : IFlatbufferObject
	{
		// Token: 0x1700E505 RID: 58629
		// (get) Token: 0x0603711C RID: 225564 RVA: 0x0075BF4A File Offset: 0x0075A14A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603711D RID: 225565 RVA: 0x0075BF57 File Offset: 0x0075A157
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603711E RID: 225566 RVA: 0x0075BF60 File Offset: 0x0075A160
		public static ISuperCatapult GetRootAsISuperCatapult(ByteBuffer _bb)
		{
			return ISuperCatapult.GetRootAsISuperCatapult(_bb, default(ISuperCatapult));
		}

		// Token: 0x0603711F RID: 225567 RVA: 0x0075BF7C File Offset: 0x0075A17C
		public static ISuperCatapult GetRootAsISuperCatapult(ByteBuffer _bb, ISuperCatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037120 RID: 225568 RVA: 0x0075BF99 File Offset: 0x0075A199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037121 RID: 225569 RVA: 0x0075BFA8 File Offset: 0x0075A1A8
		public ISuperCatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E506 RID: 58630
		// (get) Token: 0x06037122 RID: 225570 RVA: 0x0075BFB8 File Offset: 0x0075A1B8
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E507 RID: 58631
		// (get) Token: 0x06037123 RID: 225571 RVA: 0x0075BFF4 File Offset: 0x0075A1F4
		public ICatapultParam? Param
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICatapultParam?(default(ICatapultParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06037124 RID: 225572 RVA: 0x0075C051 File Offset: 0x0075A251
		public static Offset<ISuperCatapult> CreateISuperCatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<ICatapultParam> ParamOffset = default(Offset<ICatapultParam>))
		{
			builder.StartTable(2);
			ISuperCatapult.AddParam(builder, ParamOffset);
			ISuperCatapult.AddType(builder, Type);
			return ISuperCatapult.EndISuperCatapult(builder);
		}

		// Token: 0x06037125 RID: 225573 RVA: 0x0075C06E File Offset: 0x0075A26E
		public static void StartISuperCatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037126 RID: 225574 RVA: 0x0075C077 File Offset: 0x0075A277
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037127 RID: 225575 RVA: 0x0075C082 File Offset: 0x0075A282
		public static void AddParam(FlatBufferBuilder builder, Offset<ICatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x06037128 RID: 225576 RVA: 0x0075C092 File Offset: 0x0075A292
		public static Offset<ISuperCatapult> EndISuperCatapult(FlatBufferBuilder builder)
		{
			return new Offset<ISuperCatapult>(builder.EndTable());
		}

		// Token: 0x06037129 RID: 225577 RVA: 0x0075C0A0 File Offset: 0x0075A2A0
		public ISuperCatapultT UnPack()
		{
			ISuperCatapultT superCatapultT = new ISuperCatapultT();
			this.UnPackTo(superCatapultT);
			return superCatapultT;
		}

		// Token: 0x0603712A RID: 225578 RVA: 0x0075C0BC File Offset: 0x0075A2BC
		public void UnPackTo(ISuperCatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
		}

		// Token: 0x0603712B RID: 225579 RVA: 0x0075C104 File Offset: 0x0075A304
		public static Offset<ISuperCatapult> Pack(FlatBufferBuilder builder, ISuperCatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuperCatapult>);
			}
			Offset<ICatapultParam> paramOffset = (_o.Param == null) ? default(Offset<ICatapultParam>) : ICatapultParam.Pack(builder, _o.Param);
			return ISuperCatapult.CreateISuperCatapult(builder, _o.Type, paramOffset);
		}

		// Token: 0x04012D37 RID: 77111
		private Table __p;
	}
}
