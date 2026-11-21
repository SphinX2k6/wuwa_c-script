using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740C RID: 29708
	public struct IPetalGrabMoveType : IFlatbufferObject
	{
		// Token: 0x1700DA46 RID: 55878
		// (get) Token: 0x06033FB8 RID: 212920 RVA: 0x00701DC0 File Offset: 0x006FFFC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033FB9 RID: 212921 RVA: 0x00701DCD File Offset: 0x006FFFCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FBA RID: 212922 RVA: 0x00701DD4 File Offset: 0x006FFFD4
		public static IPetalGrabMoveType GetRootAsIPetalGrabMoveType(ByteBuffer _bb)
		{
			return IPetalGrabMoveType.GetRootAsIPetalGrabMoveType(_bb, default(IPetalGrabMoveType));
		}

		// Token: 0x06033FBB RID: 212923 RVA: 0x00701DF0 File Offset: 0x006FFFF0
		public static IPetalGrabMoveType GetRootAsIPetalGrabMoveType(ByteBuffer _bb, IPetalGrabMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FBC RID: 212924 RVA: 0x00701E0D File Offset: 0x0070000D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FBD RID: 212925 RVA: 0x00701E1C File Offset: 0x0070001C
		public IPetalGrabMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA47 RID: 55879
		// (get) Token: 0x06033FBE RID: 212926 RVA: 0x00701E2C File Offset: 0x0070002C
		public EPetalGrabMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPetalGrabMoveType.Linear;
				}
				return (EPetalGrabMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033FBF RID: 212927 RVA: 0x00701E68 File Offset: 0x00700068
		public static Offset<IPetalGrabMoveType> CreateIPetalGrabMoveType(FlatBufferBuilder builder, EPetalGrabMoveType Type = EPetalGrabMoveType.Linear)
		{
			builder.StartTable(1);
			IPetalGrabMoveType.AddType(builder, Type);
			return IPetalGrabMoveType.EndIPetalGrabMoveType(builder);
		}

		// Token: 0x06033FC0 RID: 212928 RVA: 0x00701E7E File Offset: 0x0070007E
		public static void StartIPetalGrabMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033FC1 RID: 212929 RVA: 0x00701E87 File Offset: 0x00700087
		public static void AddType(FlatBufferBuilder builder, EPetalGrabMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033FC2 RID: 212930 RVA: 0x00701E92 File Offset: 0x00700092
		public static Offset<IPetalGrabMoveType> EndIPetalGrabMoveType(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabMoveType>(builder.EndTable());
		}

		// Token: 0x06033FC3 RID: 212931 RVA: 0x00701EA0 File Offset: 0x007000A0
		public IPetalGrabMoveTypeT UnPack()
		{
			IPetalGrabMoveTypeT petalGrabMoveTypeT = new IPetalGrabMoveTypeT();
			this.UnPackTo(petalGrabMoveTypeT);
			return petalGrabMoveTypeT;
		}

		// Token: 0x06033FC4 RID: 212932 RVA: 0x00701EBB File Offset: 0x007000BB
		public void UnPackTo(IPetalGrabMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033FC5 RID: 212933 RVA: 0x00701ECC File Offset: 0x007000CC
		public static Offset<IPetalGrabMoveType> Pack(FlatBufferBuilder builder, IPetalGrabMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabMoveType>);
			}
			return IPetalGrabMoveType.CreateIPetalGrabMoveType(builder, _o.Type);
		}

		// Token: 0x0401255B RID: 75099
		private Table __p;
	}
}
