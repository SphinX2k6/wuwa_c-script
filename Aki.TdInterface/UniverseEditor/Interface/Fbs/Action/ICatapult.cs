using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B4 RID: 25268
	public struct ICatapult : IFlatbufferObject
	{
		// Token: 0x1700BC9F RID: 48287
		// (get) Token: 0x0602BA9F RID: 178847 RVA: 0x0060296C File Offset: 0x00600B6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BAA0 RID: 178848 RVA: 0x00602979 File Offset: 0x00600B79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BAA1 RID: 178849 RVA: 0x00602980 File Offset: 0x00600B80
		public static ICatapult GetRootAsICatapult(ByteBuffer _bb)
		{
			return ICatapult.GetRootAsICatapult(_bb, default(ICatapult));
		}

		// Token: 0x0602BAA2 RID: 178850 RVA: 0x0060299C File Offset: 0x00600B9C
		public static ICatapult GetRootAsICatapult(ByteBuffer _bb, ICatapult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BAA3 RID: 178851 RVA: 0x006029B9 File Offset: 0x00600BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BAA4 RID: 178852 RVA: 0x006029C8 File Offset: 0x00600BC8
		public ICatapult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCA0 RID: 48288
		// (get) Token: 0x0602BAA5 RID: 178853 RVA: 0x006029D8 File Offset: 0x00600BD8
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

		// Token: 0x1700BCA1 RID: 48289
		// (get) Token: 0x0602BAA6 RID: 178854 RVA: 0x00602A14 File Offset: 0x00600C14
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

		// Token: 0x0602BAA7 RID: 178855 RVA: 0x00602A71 File Offset: 0x00600C71
		public static Offset<ICatapult> CreateICatapult(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<ICatapultParam> ParamOffset = default(Offset<ICatapultParam>))
		{
			builder.StartTable(2);
			ICatapult.AddParam(builder, ParamOffset);
			ICatapult.AddType(builder, Type);
			return ICatapult.EndICatapult(builder);
		}

		// Token: 0x0602BAA8 RID: 178856 RVA: 0x00602A8E File Offset: 0x00600C8E
		public static void StartICatapult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BAA9 RID: 178857 RVA: 0x00602A97 File Offset: 0x00600C97
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BAAA RID: 178858 RVA: 0x00602AA2 File Offset: 0x00600CA2
		public static void AddParam(FlatBufferBuilder builder, Offset<ICatapultParam> paramOffset)
		{
			builder.AddOffset(1, paramOffset.Value, 0);
		}

		// Token: 0x0602BAAB RID: 178859 RVA: 0x00602AB2 File Offset: 0x00600CB2
		public static Offset<ICatapult> EndICatapult(FlatBufferBuilder builder)
		{
			return new Offset<ICatapult>(builder.EndTable());
		}

		// Token: 0x0602BAAC RID: 178860 RVA: 0x00602AC0 File Offset: 0x00600CC0
		public ICatapultT UnPack()
		{
			ICatapultT catapultT = new ICatapultT();
			this.UnPackTo(catapultT);
			return catapultT;
		}

		// Token: 0x0602BAAD RID: 178861 RVA: 0x00602ADC File Offset: 0x00600CDC
		public void UnPackTo(ICatapultT _o)
		{
			_o.Type = this.Type;
			_o.Param = ((this.Param != null) ? this.Param.Value.UnPack() : null);
		}

		// Token: 0x0602BAAE RID: 178862 RVA: 0x00602B24 File Offset: 0x00600D24
		public static Offset<ICatapult> Pack(FlatBufferBuilder builder, ICatapultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICatapult>);
			}
			Offset<ICatapultParam> paramOffset = (_o.Param == null) ? default(Offset<ICatapultParam>) : ICatapultParam.Pack(builder, _o.Param);
			return ICatapult.CreateICatapult(builder, _o.Type, paramOffset);
		}

		// Token: 0x04010852 RID: 67666
		private Table __p;
	}
}
