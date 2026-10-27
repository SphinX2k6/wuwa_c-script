using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C0 RID: 22464
	public struct IQteType : IFlatbufferObject
	{
		// Token: 0x1700A7AA RID: 42922
		// (get) Token: 0x06025B40 RID: 154432 RVA: 0x0053332C File Offset: 0x0053152C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B41 RID: 154433 RVA: 0x00533339 File Offset: 0x00531539
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B42 RID: 154434 RVA: 0x00533340 File Offset: 0x00531540
		public static IQteType GetRootAsIQteType(ByteBuffer _bb)
		{
			return IQteType.GetRootAsIQteType(_bb, default(IQteType));
		}

		// Token: 0x06025B43 RID: 154435 RVA: 0x0053335C File Offset: 0x0053155C
		public static IQteType GetRootAsIQteType(ByteBuffer _bb, IQteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B44 RID: 154436 RVA: 0x00533379 File Offset: 0x00531579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B45 RID: 154437 RVA: 0x00533388 File Offset: 0x00531588
		public IQteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7AB RID: 42923
		// (get) Token: 0x06025B46 RID: 154438 RVA: 0x00533398 File Offset: 0x00531598
		public EQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQteType.SingleBtn;
				}
				return (EQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A7AC RID: 42924
		// (get) Token: 0x06025B47 RID: 154439 RVA: 0x005333D4 File Offset: 0x005315D4
		public int QteId
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

		// Token: 0x06025B48 RID: 154440 RVA: 0x00533410 File Offset: 0x00531610
		public static Offset<IQteType> CreateIQteType(FlatBufferBuilder builder, EQteType Type = EQteType.SingleBtn, int QteId = 0)
		{
			builder.StartTable(2);
			IQteType.AddQteId(builder, QteId);
			IQteType.AddType(builder, Type);
			return IQteType.EndIQteType(builder);
		}

		// Token: 0x06025B49 RID: 154441 RVA: 0x0053342D File Offset: 0x0053162D
		public static void StartIQteType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025B4A RID: 154442 RVA: 0x00533436 File Offset: 0x00531636
		public static void AddType(FlatBufferBuilder builder, EQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025B4B RID: 154443 RVA: 0x00533441 File Offset: 0x00531641
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(1, qteId, 0);
		}

		// Token: 0x06025B4C RID: 154444 RVA: 0x0053344C File Offset: 0x0053164C
		public static Offset<IQteType> EndIQteType(FlatBufferBuilder builder)
		{
			return new Offset<IQteType>(builder.EndTable());
		}

		// Token: 0x06025B4D RID: 154445 RVA: 0x0053345C File Offset: 0x0053165C
		public IQteTypeT UnPack()
		{
			IQteTypeT qteTypeT = new IQteTypeT();
			this.UnPackTo(qteTypeT);
			return qteTypeT;
		}

		// Token: 0x06025B4E RID: 154446 RVA: 0x00533477 File Offset: 0x00531677
		public void UnPackTo(IQteTypeT _o)
		{
			_o.Type = this.Type;
			_o.QteId = this.QteId;
		}

		// Token: 0x06025B4F RID: 154447 RVA: 0x00533494 File Offset: 0x00531694
		public static Offset<IQteType> Pack(FlatBufferBuilder builder, IQteTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQteType>);
			}
			return IQteType.CreateIQteType(builder, _o.Type, _o.QteId);
		}

		// Token: 0x0400EC99 RID: 60569
		private Table __p;
	}
}
