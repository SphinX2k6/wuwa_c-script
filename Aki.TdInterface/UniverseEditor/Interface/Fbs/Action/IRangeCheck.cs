using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007585 RID: 30085
	public struct IRangeCheck : IFlatbufferObject
	{
		// Token: 0x1700DD4A RID: 56650
		// (get) Token: 0x06034C64 RID: 216164 RVA: 0x00718C83 File Offset: 0x00716E83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034C65 RID: 216165 RVA: 0x00718C90 File Offset: 0x00716E90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034C66 RID: 216166 RVA: 0x00718C98 File Offset: 0x00716E98
		public static IRangeCheck GetRootAsIRangeCheck(ByteBuffer _bb)
		{
			return IRangeCheck.GetRootAsIRangeCheck(_bb, default(IRangeCheck));
		}

		// Token: 0x06034C67 RID: 216167 RVA: 0x00718CB4 File Offset: 0x00716EB4
		public static IRangeCheck GetRootAsIRangeCheck(ByteBuffer _bb, IRangeCheck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034C68 RID: 216168 RVA: 0x00718CD1 File Offset: 0x00716ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034C69 RID: 216169 RVA: 0x00718CE0 File Offset: 0x00716EE0
		public IRangeCheck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD4B RID: 56651
		// (get) Token: 0x06034C6A RID: 216170 RVA: 0x00718CF0 File Offset: 0x00716EF0
		public ERangeCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeCheckType.Cone;
				}
				return (ERangeCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034C6B RID: 216171 RVA: 0x00718D2C File Offset: 0x00716F2C
		public static Offset<IRangeCheck> CreateIRangeCheck(FlatBufferBuilder builder, ERangeCheckType Type = ERangeCheckType.Cone)
		{
			builder.StartTable(1);
			IRangeCheck.AddType(builder, Type);
			return IRangeCheck.EndIRangeCheck(builder);
		}

		// Token: 0x06034C6C RID: 216172 RVA: 0x00718D42 File Offset: 0x00716F42
		public static void StartIRangeCheck(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034C6D RID: 216173 RVA: 0x00718D4B File Offset: 0x00716F4B
		public static void AddType(FlatBufferBuilder builder, ERangeCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034C6E RID: 216174 RVA: 0x00718D56 File Offset: 0x00716F56
		public static Offset<IRangeCheck> EndIRangeCheck(FlatBufferBuilder builder)
		{
			return new Offset<IRangeCheck>(builder.EndTable());
		}

		// Token: 0x06034C6F RID: 216175 RVA: 0x00718D64 File Offset: 0x00716F64
		public IRangeCheckT UnPack()
		{
			IRangeCheckT rangeCheckT = new IRangeCheckT();
			this.UnPackTo(rangeCheckT);
			return rangeCheckT;
		}

		// Token: 0x06034C70 RID: 216176 RVA: 0x00718D7F File Offset: 0x00716F7F
		public void UnPackTo(IRangeCheckT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034C71 RID: 216177 RVA: 0x00718D90 File Offset: 0x00716F90
		public static Offset<IRangeCheck> Pack(FlatBufferBuilder builder, IRangeCheckT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeCheck>);
			}
			return IRangeCheck.CreateIRangeCheck(builder, _o.Type);
		}

		// Token: 0x0401276D RID: 75629
		private Table __p;
	}
}
