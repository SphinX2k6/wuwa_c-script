using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA3 RID: 28323
	public struct IResetPosByResetPoint : IFlatbufferObject
	{
		// Token: 0x1700D2E2 RID: 53986
		// (get) Token: 0x060320F1 RID: 205041 RVA: 0x006C51E2 File Offset: 0x006C33E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320F2 RID: 205042 RVA: 0x006C51EF File Offset: 0x006C33EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320F3 RID: 205043 RVA: 0x006C51F8 File Offset: 0x006C33F8
		public static IResetPosByResetPoint GetRootAsIResetPosByResetPoint(ByteBuffer _bb)
		{
			return IResetPosByResetPoint.GetRootAsIResetPosByResetPoint(_bb, default(IResetPosByResetPoint));
		}

		// Token: 0x060320F4 RID: 205044 RVA: 0x006C5214 File Offset: 0x006C3414
		public static IResetPosByResetPoint GetRootAsIResetPosByResetPoint(ByteBuffer _bb, IResetPosByResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320F5 RID: 205045 RVA: 0x006C5231 File Offset: 0x006C3431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320F6 RID: 205046 RVA: 0x006C5240 File Offset: 0x006C3440
		public IResetPosByResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2E3 RID: 53987
		// (get) Token: 0x060320F7 RID: 205047 RVA: 0x006C5250 File Offset: 0x006C3450
		public EResetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPosType.PosEntity;
				}
				return (EResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060320F8 RID: 205048 RVA: 0x006C528C File Offset: 0x006C348C
		public static Offset<IResetPosByResetPoint> CreateIResetPosByResetPoint(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity)
		{
			builder.StartTable(1);
			IResetPosByResetPoint.AddType(builder, Type);
			return IResetPosByResetPoint.EndIResetPosByResetPoint(builder);
		}

		// Token: 0x060320F9 RID: 205049 RVA: 0x006C52A2 File Offset: 0x006C34A2
		public static void StartIResetPosByResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060320FA RID: 205050 RVA: 0x006C52AB File Offset: 0x006C34AB
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060320FB RID: 205051 RVA: 0x006C52B6 File Offset: 0x006C34B6
		public static Offset<IResetPosByResetPoint> EndIResetPosByResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosByResetPoint>(builder.EndTable());
		}

		// Token: 0x060320FC RID: 205052 RVA: 0x006C52C4 File Offset: 0x006C34C4
		public IResetPosByResetPointT UnPack()
		{
			IResetPosByResetPointT resetPosByResetPointT = new IResetPosByResetPointT();
			this.UnPackTo(resetPosByResetPointT);
			return resetPosByResetPointT;
		}

		// Token: 0x060320FD RID: 205053 RVA: 0x006C52DF File Offset: 0x006C34DF
		public void UnPackTo(IResetPosByResetPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060320FE RID: 205054 RVA: 0x006C52F0 File Offset: 0x006C34F0
		public static Offset<IResetPosByResetPoint> Pack(FlatBufferBuilder builder, IResetPosByResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosByResetPoint>);
			}
			return IResetPosByResetPoint.CreateIResetPosByResetPoint(builder, _o.Type);
		}

		// Token: 0x04011896 RID: 71830
		private Table __p;
	}
}
