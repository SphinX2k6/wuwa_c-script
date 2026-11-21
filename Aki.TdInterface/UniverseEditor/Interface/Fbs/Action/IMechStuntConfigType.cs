using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B3 RID: 29107
	public struct IMechStuntConfigType : IFlatbufferObject
	{
		// Token: 0x1700D534 RID: 54580
		// (get) Token: 0x06032A1A RID: 207386 RVA: 0x006D772D File Offset: 0x006D592D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A1B RID: 207387 RVA: 0x006D773A File Offset: 0x006D593A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A1C RID: 207388 RVA: 0x006D7744 File Offset: 0x006D5944
		public static IMechStuntConfigType GetRootAsIMechStuntConfigType(ByteBuffer _bb)
		{
			return IMechStuntConfigType.GetRootAsIMechStuntConfigType(_bb, default(IMechStuntConfigType));
		}

		// Token: 0x06032A1D RID: 207389 RVA: 0x006D7760 File Offset: 0x006D5960
		public static IMechStuntConfigType GetRootAsIMechStuntConfigType(ByteBuffer _bb, IMechStuntConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A1E RID: 207390 RVA: 0x006D777D File Offset: 0x006D597D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A1F RID: 207391 RVA: 0x006D778C File Offset: 0x006D598C
		public IMechStuntConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D535 RID: 54581
		// (get) Token: 0x06032A20 RID: 207392 RVA: 0x006D779C File Offset: 0x006D599C
		public EMechStuntType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechStuntType.Dive;
				}
				return (EMechStuntType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032A21 RID: 207393 RVA: 0x006D77D8 File Offset: 0x006D59D8
		public static Offset<IMechStuntConfigType> CreateIMechStuntConfigType(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntConfigType.AddType(builder, Type);
			return IMechStuntConfigType.EndIMechStuntConfigType(builder);
		}

		// Token: 0x06032A22 RID: 207394 RVA: 0x006D77EE File Offset: 0x006D59EE
		public static void StartIMechStuntConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A23 RID: 207395 RVA: 0x006D77F7 File Offset: 0x006D59F7
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A24 RID: 207396 RVA: 0x006D7802 File Offset: 0x006D5A02
		public static Offset<IMechStuntConfigType> EndIMechStuntConfigType(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntConfigType>(builder.EndTable());
		}

		// Token: 0x06032A25 RID: 207397 RVA: 0x006D7810 File Offset: 0x006D5A10
		public IMechStuntConfigTypeT UnPack()
		{
			IMechStuntConfigTypeT mechStuntConfigTypeT = new IMechStuntConfigTypeT();
			this.UnPackTo(mechStuntConfigTypeT);
			return mechStuntConfigTypeT;
		}

		// Token: 0x06032A26 RID: 207398 RVA: 0x006D782B File Offset: 0x006D5A2B
		public void UnPackTo(IMechStuntConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A27 RID: 207399 RVA: 0x006D783C File Offset: 0x006D5A3C
		public static Offset<IMechStuntConfigType> Pack(FlatBufferBuilder builder, IMechStuntConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntConfigType>);
			}
			return IMechStuntConfigType.CreateIMechStuntConfigType(builder, _o.Type);
		}

		// Token: 0x040121C3 RID: 74179
		private Table __p;
	}
}
