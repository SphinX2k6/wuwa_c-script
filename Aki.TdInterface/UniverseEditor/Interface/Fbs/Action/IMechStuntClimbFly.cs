using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B0 RID: 29104
	public struct IMechStuntClimbFly : IFlatbufferObject
	{
		// Token: 0x1700D531 RID: 54577
		// (get) Token: 0x06032A08 RID: 207368 RVA: 0x006D75B5 File Offset: 0x006D57B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A09 RID: 207369 RVA: 0x006D75C2 File Offset: 0x006D57C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A0A RID: 207370 RVA: 0x006D75CC File Offset: 0x006D57CC
		public static IMechStuntClimbFly GetRootAsIMechStuntClimbFly(ByteBuffer _bb)
		{
			return IMechStuntClimbFly.GetRootAsIMechStuntClimbFly(_bb, default(IMechStuntClimbFly));
		}

		// Token: 0x06032A0B RID: 207371 RVA: 0x006D75E8 File Offset: 0x006D57E8
		public static IMechStuntClimbFly GetRootAsIMechStuntClimbFly(ByteBuffer _bb, IMechStuntClimbFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A0C RID: 207372 RVA: 0x006D7605 File Offset: 0x006D5805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A0D RID: 207373 RVA: 0x006D7614 File Offset: 0x006D5814
		public IMechStuntClimbFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D532 RID: 54578
		// (get) Token: 0x06032A0E RID: 207374 RVA: 0x006D7624 File Offset: 0x006D5824
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

		// Token: 0x06032A0F RID: 207375 RVA: 0x006D7660 File Offset: 0x006D5860
		public static Offset<IMechStuntClimbFly> CreateIMechStuntClimbFly(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntClimbFly.AddType(builder, Type);
			return IMechStuntClimbFly.EndIMechStuntClimbFly(builder);
		}

		// Token: 0x06032A10 RID: 207376 RVA: 0x006D7676 File Offset: 0x006D5876
		public static void StartIMechStuntClimbFly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A11 RID: 207377 RVA: 0x006D767F File Offset: 0x006D587F
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A12 RID: 207378 RVA: 0x006D768A File Offset: 0x006D588A
		public static Offset<IMechStuntClimbFly> EndIMechStuntClimbFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntClimbFly>(builder.EndTable());
		}

		// Token: 0x06032A13 RID: 207379 RVA: 0x006D7698 File Offset: 0x006D5898
		public IMechStuntClimbFlyT UnPack()
		{
			IMechStuntClimbFlyT mechStuntClimbFlyT = new IMechStuntClimbFlyT();
			this.UnPackTo(mechStuntClimbFlyT);
			return mechStuntClimbFlyT;
		}

		// Token: 0x06032A14 RID: 207380 RVA: 0x006D76B3 File Offset: 0x006D58B3
		public void UnPackTo(IMechStuntClimbFlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A15 RID: 207381 RVA: 0x006D76C4 File Offset: 0x006D58C4
		public static Offset<IMechStuntClimbFly> Pack(FlatBufferBuilder builder, IMechStuntClimbFlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntClimbFly>);
			}
			return IMechStuntClimbFly.CreateIMechStuntClimbFly(builder, _o.Type);
		}

		// Token: 0x040121C1 RID: 74177
		private Table __p;
	}
}
