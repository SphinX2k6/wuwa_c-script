using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006404 RID: 25604
	public struct IGiantResponseType : IFlatbufferObject
	{
		// Token: 0x1700BD22 RID: 48418
		// (get) Token: 0x0602B7FA RID: 178170 RVA: 0x005ECC34 File Offset: 0x005EAE34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7FB RID: 178171 RVA: 0x005ECC41 File Offset: 0x005EAE41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7FC RID: 178172 RVA: 0x005ECC48 File Offset: 0x005EAE48
		public static IGiantResponseType GetRootAsIGiantResponseType(ByteBuffer _bb)
		{
			return IGiantResponseType.GetRootAsIGiantResponseType(_bb, default(IGiantResponseType));
		}

		// Token: 0x0602B7FD RID: 178173 RVA: 0x005ECC64 File Offset: 0x005EAE64
		public static IGiantResponseType GetRootAsIGiantResponseType(ByteBuffer _bb, IGiantResponseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7FE RID: 178174 RVA: 0x005ECC81 File Offset: 0x005EAE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7FF RID: 178175 RVA: 0x005ECC90 File Offset: 0x005EAE90
		public IGiantResponseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD23 RID: 48419
		// (get) Token: 0x0602B800 RID: 178176 RVA: 0x005ECCA0 File Offset: 0x005EAEA0
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

		// Token: 0x0602B801 RID: 178177 RVA: 0x005ECCDC File Offset: 0x005EAEDC
		public static Offset<IGiantResponseType> CreateIGiantResponseType(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation)
		{
			builder.StartTable(1);
			IGiantResponseType.AddType(builder, Type);
			return IGiantResponseType.EndIGiantResponseType(builder);
		}

		// Token: 0x0602B802 RID: 178178 RVA: 0x005ECCF2 File Offset: 0x005EAEF2
		public static void StartIGiantResponseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B803 RID: 178179 RVA: 0x005ECCFB File Offset: 0x005EAEFB
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B804 RID: 178180 RVA: 0x005ECD06 File Offset: 0x005EAF06
		public static Offset<IGiantResponseType> EndIGiantResponseType(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponseType>(builder.EndTable());
		}

		// Token: 0x0602B805 RID: 178181 RVA: 0x005ECD14 File Offset: 0x005EAF14
		public IGiantResponseTypeT UnPack()
		{
			IGiantResponseTypeT giantResponseTypeT = new IGiantResponseTypeT();
			this.UnPackTo(giantResponseTypeT);
			return giantResponseTypeT;
		}

		// Token: 0x0602B806 RID: 178182 RVA: 0x005ECD2F File Offset: 0x005EAF2F
		public void UnPackTo(IGiantResponseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B807 RID: 178183 RVA: 0x005ECD40 File Offset: 0x005EAF40
		public static Offset<IGiantResponseType> Pack(FlatBufferBuilder builder, IGiantResponseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponseType>);
			}
			return IGiantResponseType.CreateIGiantResponseType(builder, _o.Type);
		}

		// Token: 0x04010503 RID: 66819
		private Table __p;
	}
}
