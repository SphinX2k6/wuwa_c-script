using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007409 RID: 29705
	public struct IPetalGrabMoveLinear : IFlatbufferObject
	{
		// Token: 0x1700DA3F RID: 55871
		// (get) Token: 0x06033F9E RID: 212894 RVA: 0x00701B30 File Offset: 0x006FFD30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F9F RID: 212895 RVA: 0x00701B3D File Offset: 0x006FFD3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033FA0 RID: 212896 RVA: 0x00701B44 File Offset: 0x006FFD44
		public static IPetalGrabMoveLinear GetRootAsIPetalGrabMoveLinear(ByteBuffer _bb)
		{
			return IPetalGrabMoveLinear.GetRootAsIPetalGrabMoveLinear(_bb, default(IPetalGrabMoveLinear));
		}

		// Token: 0x06033FA1 RID: 212897 RVA: 0x00701B60 File Offset: 0x006FFD60
		public static IPetalGrabMoveLinear GetRootAsIPetalGrabMoveLinear(ByteBuffer _bb, IPetalGrabMoveLinear obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033FA2 RID: 212898 RVA: 0x00701B7D File Offset: 0x006FFD7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033FA3 RID: 212899 RVA: 0x00701B8C File Offset: 0x006FFD8C
		public IPetalGrabMoveLinear __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA40 RID: 55872
		// (get) Token: 0x06033FA4 RID: 212900 RVA: 0x00701B9C File Offset: 0x006FFD9C
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

		// Token: 0x1700DA41 RID: 55873
		// (get) Token: 0x06033FA5 RID: 212901 RVA: 0x00701BD8 File Offset: 0x006FFDD8
		public int StartHalfWidth
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DA42 RID: 55874
		// (get) Token: 0x06033FA6 RID: 212902 RVA: 0x00701C14 File Offset: 0x006FFE14
		public int EndHalfWidth
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033FA7 RID: 212903 RVA: 0x00701C50 File Offset: 0x006FFE50
		public static Offset<IPetalGrabMoveLinear> CreateIPetalGrabMoveLinear(FlatBufferBuilder builder, EPetalGrabMoveType Type = EPetalGrabMoveType.Linear, int StartHalfWidth = 0, int EndHalfWidth = 0)
		{
			builder.StartTable(3);
			IPetalGrabMoveLinear.AddEndHalfWidth(builder, EndHalfWidth);
			IPetalGrabMoveLinear.AddStartHalfWidth(builder, StartHalfWidth);
			IPetalGrabMoveLinear.AddType(builder, Type);
			return IPetalGrabMoveLinear.EndIPetalGrabMoveLinear(builder);
		}

		// Token: 0x06033FA8 RID: 212904 RVA: 0x00701C74 File Offset: 0x006FFE74
		public static void StartIPetalGrabMoveLinear(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033FA9 RID: 212905 RVA: 0x00701C7D File Offset: 0x006FFE7D
		public static void AddType(FlatBufferBuilder builder, EPetalGrabMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033FAA RID: 212906 RVA: 0x00701C88 File Offset: 0x006FFE88
		public static void AddStartHalfWidth(FlatBufferBuilder builder, int startHalfWidth)
		{
			builder.AddInt(1, startHalfWidth, 0);
		}

		// Token: 0x06033FAB RID: 212907 RVA: 0x00701C93 File Offset: 0x006FFE93
		public static void AddEndHalfWidth(FlatBufferBuilder builder, int endHalfWidth)
		{
			builder.AddInt(2, endHalfWidth, 0);
		}

		// Token: 0x06033FAC RID: 212908 RVA: 0x00701C9E File Offset: 0x006FFE9E
		public static Offset<IPetalGrabMoveLinear> EndIPetalGrabMoveLinear(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabMoveLinear>(builder.EndTable());
		}

		// Token: 0x06033FAD RID: 212909 RVA: 0x00701CAC File Offset: 0x006FFEAC
		public IPetalGrabMoveLinearT UnPack()
		{
			IPetalGrabMoveLinearT petalGrabMoveLinearT = new IPetalGrabMoveLinearT();
			this.UnPackTo(petalGrabMoveLinearT);
			return petalGrabMoveLinearT;
		}

		// Token: 0x06033FAE RID: 212910 RVA: 0x00701CC7 File Offset: 0x006FFEC7
		public void UnPackTo(IPetalGrabMoveLinearT _o)
		{
			_o.Type = this.Type;
			_o.StartHalfWidth = this.StartHalfWidth;
			_o.EndHalfWidth = this.EndHalfWidth;
		}

		// Token: 0x06033FAF RID: 212911 RVA: 0x00701CF0 File Offset: 0x006FFEF0
		public static Offset<IPetalGrabMoveLinear> Pack(FlatBufferBuilder builder, IPetalGrabMoveLinearT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabMoveLinear>);
			}
			return IPetalGrabMoveLinear.CreateIPetalGrabMoveLinear(builder, _o.Type, _o.StartHalfWidth, _o.EndHalfWidth);
		}

		// Token: 0x04012557 RID: 75095
		private Table __p;
	}
}
