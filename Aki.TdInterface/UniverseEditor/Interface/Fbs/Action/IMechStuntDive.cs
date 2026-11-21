using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B9 RID: 29113
	public struct IMechStuntDive : IFlatbufferObject
	{
		// Token: 0x1700D539 RID: 54585
		// (get) Token: 0x06032A42 RID: 207426 RVA: 0x006D7AF4 File Offset: 0x006D5CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A43 RID: 207427 RVA: 0x006D7B01 File Offset: 0x006D5D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A44 RID: 207428 RVA: 0x006D7B08 File Offset: 0x006D5D08
		public static IMechStuntDive GetRootAsIMechStuntDive(ByteBuffer _bb)
		{
			return IMechStuntDive.GetRootAsIMechStuntDive(_bb, default(IMechStuntDive));
		}

		// Token: 0x06032A45 RID: 207429 RVA: 0x006D7B24 File Offset: 0x006D5D24
		public static IMechStuntDive GetRootAsIMechStuntDive(ByteBuffer _bb, IMechStuntDive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A46 RID: 207430 RVA: 0x006D7B41 File Offset: 0x006D5D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A47 RID: 207431 RVA: 0x006D7B50 File Offset: 0x006D5D50
		public IMechStuntDive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D53A RID: 54586
		// (get) Token: 0x06032A48 RID: 207432 RVA: 0x006D7B60 File Offset: 0x006D5D60
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

		// Token: 0x06032A49 RID: 207433 RVA: 0x006D7B9C File Offset: 0x006D5D9C
		public static Offset<IMechStuntDive> CreateIMechStuntDive(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntDive.AddType(builder, Type);
			return IMechStuntDive.EndIMechStuntDive(builder);
		}

		// Token: 0x06032A4A RID: 207434 RVA: 0x006D7BB2 File Offset: 0x006D5DB2
		public static void StartIMechStuntDive(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A4B RID: 207435 RVA: 0x006D7BBB File Offset: 0x006D5DBB
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A4C RID: 207436 RVA: 0x006D7BC6 File Offset: 0x006D5DC6
		public static Offset<IMechStuntDive> EndIMechStuntDive(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntDive>(builder.EndTable());
		}

		// Token: 0x06032A4D RID: 207437 RVA: 0x006D7BD4 File Offset: 0x006D5DD4
		public IMechStuntDiveT UnPack()
		{
			IMechStuntDiveT mechStuntDiveT = new IMechStuntDiveT();
			this.UnPackTo(mechStuntDiveT);
			return mechStuntDiveT;
		}

		// Token: 0x06032A4E RID: 207438 RVA: 0x006D7BEF File Offset: 0x006D5DEF
		public void UnPackTo(IMechStuntDiveT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A4F RID: 207439 RVA: 0x006D7C00 File Offset: 0x006D5E00
		public static Offset<IMechStuntDive> Pack(FlatBufferBuilder builder, IMechStuntDiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntDive>);
			}
			return IMechStuntDive.CreateIMechStuntDive(builder, _o.Type);
		}

		// Token: 0x040121D0 RID: 74192
		private Table __p;
	}
}
