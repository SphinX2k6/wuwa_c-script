using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C87 RID: 23687
	public struct IPasserbyNpcLiftMove : IFlatbufferObject
	{
		// Token: 0x1700AE04 RID: 44548
		// (get) Token: 0x060274AB RID: 160939 RVA: 0x005616FF File Offset: 0x0055F8FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060274AC RID: 160940 RVA: 0x0056170C File Offset: 0x0055F90C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060274AD RID: 160941 RVA: 0x00561714 File Offset: 0x0055F914
		public static IPasserbyNpcLiftMove GetRootAsIPasserbyNpcLiftMove(ByteBuffer _bb)
		{
			return IPasserbyNpcLiftMove.GetRootAsIPasserbyNpcLiftMove(_bb, default(IPasserbyNpcLiftMove));
		}

		// Token: 0x060274AE RID: 160942 RVA: 0x00561730 File Offset: 0x0055F930
		public static IPasserbyNpcLiftMove GetRootAsIPasserbyNpcLiftMove(ByteBuffer _bb, IPasserbyNpcLiftMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060274AF RID: 160943 RVA: 0x0056174D File Offset: 0x0055F94D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060274B0 RID: 160944 RVA: 0x0056175C File Offset: 0x0055F95C
		public IPasserbyNpcLiftMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE05 RID: 44549
		// (get) Token: 0x060274B1 RID: 160945 RVA: 0x0056176C File Offset: 0x0055F96C
		public EPasserbyNpcMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return (EPasserbyNpcMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AE06 RID: 44550
		// (get) Token: 0x060274B2 RID: 160946 RVA: 0x005617A8 File Offset: 0x0055F9A8
		public IPasserbyNpcRideLiftLeaveOnArrivalMove? NpcLiftConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcRideLiftLeaveOnArrivalMove?(default(IPasserbyNpcRideLiftLeaveOnArrivalMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060274B3 RID: 160947 RVA: 0x00561805 File Offset: 0x0055FA05
		public static Offset<IPasserbyNpcLiftMove> CreateIPasserbyNpcLiftMove(FlatBufferBuilder builder, EPasserbyNpcMoveType Type = EPasserbyNpcMoveType.Spline, Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> NpcLiftConfigOffset = default(Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove>))
		{
			builder.StartTable(2);
			IPasserbyNpcLiftMove.AddNpcLiftConfig(builder, NpcLiftConfigOffset);
			IPasserbyNpcLiftMove.AddType(builder, Type);
			return IPasserbyNpcLiftMove.EndIPasserbyNpcLiftMove(builder);
		}

		// Token: 0x060274B4 RID: 160948 RVA: 0x00561822 File Offset: 0x0055FA22
		public static void StartIPasserbyNpcLiftMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060274B5 RID: 160949 RVA: 0x0056182B File Offset: 0x0055FA2B
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060274B6 RID: 160950 RVA: 0x00561836 File Offset: 0x0055FA36
		public static void AddNpcLiftConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> npcLiftConfigOffset)
		{
			builder.AddOffset(1, npcLiftConfigOffset.Value, 0);
		}

		// Token: 0x060274B7 RID: 160951 RVA: 0x00561846 File Offset: 0x0055FA46
		public static Offset<IPasserbyNpcLiftMove> EndIPasserbyNpcLiftMove(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcLiftMove>(builder.EndTable());
		}

		// Token: 0x060274B8 RID: 160952 RVA: 0x00561854 File Offset: 0x0055FA54
		public IPasserbyNpcLiftMoveT UnPack()
		{
			IPasserbyNpcLiftMoveT passerbyNpcLiftMoveT = new IPasserbyNpcLiftMoveT();
			this.UnPackTo(passerbyNpcLiftMoveT);
			return passerbyNpcLiftMoveT;
		}

		// Token: 0x060274B9 RID: 160953 RVA: 0x00561870 File Offset: 0x0055FA70
		public void UnPackTo(IPasserbyNpcLiftMoveT _o)
		{
			_o.Type = this.Type;
			_o.NpcLiftConfig = ((this.NpcLiftConfig != null) ? this.NpcLiftConfig.Value.UnPack() : null);
		}

		// Token: 0x060274BA RID: 160954 RVA: 0x005618B8 File Offset: 0x0055FAB8
		public static Offset<IPasserbyNpcLiftMove> Pack(FlatBufferBuilder builder, IPasserbyNpcLiftMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcLiftMove>);
			}
			Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove> npcLiftConfigOffset = (_o.NpcLiftConfig == null) ? default(Offset<IPasserbyNpcRideLiftLeaveOnArrivalMove>) : IPasserbyNpcRideLiftLeaveOnArrivalMove.Pack(builder, _o.NpcLiftConfig);
			return IPasserbyNpcLiftMove.CreateIPasserbyNpcLiftMove(builder, _o.Type, npcLiftConfigOffset);
		}

		// Token: 0x0400F790 RID: 63376
		private Table __p;
	}
}
