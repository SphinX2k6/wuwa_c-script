using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004630 RID: 17968
	public struct IAddAllPhantom : IFlatbufferObject
	{
		// Token: 0x17007F84 RID: 32644
		// (get) Token: 0x0601B363 RID: 111459 RVA: 0x003DFD7D File Offset: 0x003DDF7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B364 RID: 111460 RVA: 0x003DFD8A File Offset: 0x003DDF8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B365 RID: 111461 RVA: 0x003DFD94 File Offset: 0x003DDF94
		public static IAddAllPhantom GetRootAsIAddAllPhantom(ByteBuffer _bb)
		{
			return IAddAllPhantom.GetRootAsIAddAllPhantom(_bb, default(IAddAllPhantom));
		}

		// Token: 0x0601B366 RID: 111462 RVA: 0x003DFDB0 File Offset: 0x003DDFB0
		public static IAddAllPhantom GetRootAsIAddAllPhantom(ByteBuffer _bb, IAddAllPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B367 RID: 111463 RVA: 0x003DFDCD File Offset: 0x003DDFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B368 RID: 111464 RVA: 0x003DFDDC File Offset: 0x003DDFDC
		public IAddAllPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F85 RID: 32645
		// (get) Token: 0x0601B369 RID: 111465 RVA: 0x003DFDEC File Offset: 0x003DDFEC
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B36A RID: 111466 RVA: 0x003DFE28 File Offset: 0x003DE028
		public static Offset<IAddAllPhantom> CreateIAddAllPhantom(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IAddAllPhantom.AddType(builder, Type);
			return IAddAllPhantom.EndIAddAllPhantom(builder);
		}

		// Token: 0x0601B36B RID: 111467 RVA: 0x003DFE3E File Offset: 0x003DE03E
		public static void StartIAddAllPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B36C RID: 111468 RVA: 0x003DFE47 File Offset: 0x003DE047
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B36D RID: 111469 RVA: 0x003DFE52 File Offset: 0x003DE052
		public static Offset<IAddAllPhantom> EndIAddAllPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IAddAllPhantom>(builder.EndTable());
		}

		// Token: 0x0601B36E RID: 111470 RVA: 0x003DFE60 File Offset: 0x003DE060
		public IAddAllPhantomT UnPack()
		{
			IAddAllPhantomT addAllPhantomT = new IAddAllPhantomT();
			this.UnPackTo(addAllPhantomT);
			return addAllPhantomT;
		}

		// Token: 0x0601B36F RID: 111471 RVA: 0x003DFE7B File Offset: 0x003DE07B
		public void UnPackTo(IAddAllPhantomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B370 RID: 111472 RVA: 0x003DFE8C File Offset: 0x003DE08C
		public static Offset<IAddAllPhantom> Pack(FlatBufferBuilder builder, IAddAllPhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddAllPhantom>);
			}
			return IAddAllPhantom.CreateIAddAllPhantom(builder, _o.Type);
		}

		// Token: 0x0400C7A8 RID: 51112
		private Table __p;
	}
}
