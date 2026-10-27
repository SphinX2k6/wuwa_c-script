using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007244 RID: 29252
	public struct ISuperCatapult : IFlatbufferObject
	{
		// Token: 0x1700D90C RID: 55564
		// (get) Token: 0x06033E1A RID: 212506 RVA: 0x006FABEA File Offset: 0x006F8DEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E1B RID: 212507 RVA: 0x006FABF7 File Offset: 0x006F8DF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E1C RID: 212508 RVA: 0x006FAC00 File Offset: 0x006F8E00
		public static ISuperCatapult GetRootAsISuperCatapult(ByteBuffer _bb)
		{
			return ISuperCatapult.GetRootAsISuperCatapult(_bb, default(ISuperCatapult));
		}

		// Token: 0x06033E1D RID: 212509 RVA: 0x006FAC1C File Offset: 0x006F8E1C
		public static ISuperCatapult GetRootAsISuperCatapult(ByteBuffer _bb, ISuperCatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E1E RID: 212510 RVA: 0x006FAC39 File Offset: 0x006F8E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E1F RID: 212511 RVA: 0x006FAC48 File Offset: 0x006F8E48
		public ISuperCatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D90D RID: 55565
		// (get) Token: 0x06033E20 RID: 212512 RVA: 0x006FAC58 File Offset: 0x006F8E58
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

		// Token: 0x1700D90E RID: 55566
		// (get) Token: 0x06033E21 RID: 212513 RVA: 0x006FAC94 File Offset: 0x006F8E94
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

		// Token: 0x06033E22 RID: 212514 RVA: 0x006FACF1 File Offset: 0x006F8EF1
		public static Offset<ISuperCatapult> CreateISuperCatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<ICatapultParam> ParamOffset = default(Offset<ICatapultParam>))
		{
			builder.StartTable(2);
			ISuperCatapult.AddParam(builder, ParamOffset);
			ISuperCatapult.AddType(builder, Type);
			return ISuperCatapult.EndISuperCatapult(builder);
		}

		// Token: 0x06033E23 RID: 212515 RVA: 0x006FAD0E File Offset: 0x006F8F0E
		public static void StartISuperCatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033E24 RID: 212516 RVA: 0x006FAD17 File Offset: 0x006F8F17
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E25 RID: 212517 RVA: 0x006FAD22 File Offset: 0x006F8F22
		public static void AddParam(FlatBufferBuilder builder, Offset<ICatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x06033E26 RID: 212518 RVA: 0x006FAD32 File Offset: 0x006F8F32
		public static Offset<ISuperCatapult> EndISuperCatapult(FlatBufferBuilder builder)
		{
			return new Offset<ISuperCatapult>(builder.EndTable());
		}

		// Token: 0x06033E27 RID: 212519 RVA: 0x006FAD40 File Offset: 0x006F8F40
		public ISuperCatapultT UnPack()
		{
			ISuperCatapultT superCatapultT = new ISuperCatapultT();
			this.UnPackTo(superCatapultT);
			return superCatapultT;
		}

		// Token: 0x06033E28 RID: 212520 RVA: 0x006FAD5C File Offset: 0x006F8F5C
		public void UnPackTo(ISuperCatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
		}

		// Token: 0x06033E29 RID: 212521 RVA: 0x006FADA4 File Offset: 0x006F8FA4
		public static Offset<ISuperCatapult> Pack(FlatBufferBuilder builder, ISuperCatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuperCatapult>);
			}
			Offset<ICatapultParam> paramOffset = (_o.Param == null) ? default(Offset<ICatapultParam>) : ICatapultParam.Pack(builder, _o.Param);
			return ISuperCatapult.CreateISuperCatapult(builder, _o.Type, paramOffset);
		}

		// Token: 0x04011D35 RID: 73013
		private Table __p;
	}
}
