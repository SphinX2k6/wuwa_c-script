using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AFB RID: 19195
	public struct ISetUnopenedAreaPullback : IFlatbufferObject
	{
		// Token: 0x17008683 RID: 34435
		// (get) Token: 0x0601CEBA RID: 118458 RVA: 0x00411B38 File Offset: 0x0040FD38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CEBB RID: 118459 RVA: 0x00411B45 File Offset: 0x0040FD45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CEBC RID: 118460 RVA: 0x00411B4C File Offset: 0x0040FD4C
		public static ISetUnopenedAreaPullback GetRootAsISetUnopenedAreaPullback(ByteBuffer _bb)
		{
			return ISetUnopenedAreaPullback.GetRootAsISetUnopenedAreaPullback(_bb, default(ISetUnopenedAreaPullback));
		}

		// Token: 0x0601CEBD RID: 118461 RVA: 0x00411B68 File Offset: 0x0040FD68
		public static ISetUnopenedAreaPullback GetRootAsISetUnopenedAreaPullback(ByteBuffer _bb, ISetUnopenedAreaPullback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CEBE RID: 118462 RVA: 0x00411B85 File Offset: 0x0040FD85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CEBF RID: 118463 RVA: 0x00411B94 File Offset: 0x0040FD94
		public ISetUnopenedAreaPullback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008684 RID: 34436
		// (get) Token: 0x0601CEC0 RID: 118464 RVA: 0x00411BA4 File Offset: 0x0040FDA4
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

		// Token: 0x17008685 RID: 34437
		// (get) Token: 0x0601CEC1 RID: 118465 RVA: 0x00411BE0 File Offset: 0x0040FDE0
		public bool IsOpen
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CEC2 RID: 118466 RVA: 0x00411C1F File Offset: 0x0040FE1F
		public static Offset<ISetUnopenedAreaPullback> CreateISetUnopenedAreaPullback(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsOpen = false)
		{
			builder.StartTable(2);
			ISetUnopenedAreaPullback.AddIsOpen(builder, IsOpen);
			ISetUnopenedAreaPullback.AddType(builder, Type);
			return ISetUnopenedAreaPullback.EndISetUnopenedAreaPullback(builder);
		}

		// Token: 0x0601CEC3 RID: 118467 RVA: 0x00411C3C File Offset: 0x0040FE3C
		public static void StartISetUnopenedAreaPullback(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CEC4 RID: 118468 RVA: 0x00411C45 File Offset: 0x0040FE45
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CEC5 RID: 118469 RVA: 0x00411C50 File Offset: 0x0040FE50
		public static void AddIsOpen(FlatBufferBuilder builder, bool isOpen)
		{
			builder.AddBool(1, isOpen, false);
		}

		// Token: 0x0601CEC6 RID: 118470 RVA: 0x00411C5B File Offset: 0x0040FE5B
		public static Offset<ISetUnopenedAreaPullback> EndISetUnopenedAreaPullback(FlatBufferBuilder builder)
		{
			return new Offset<ISetUnopenedAreaPullback>(builder.EndTable());
		}

		// Token: 0x0601CEC7 RID: 118471 RVA: 0x00411C68 File Offset: 0x0040FE68
		public ISetUnopenedAreaPullbackT UnPack()
		{
			ISetUnopenedAreaPullbackT setUnopenedAreaPullbackT = new ISetUnopenedAreaPullbackT();
			this.UnPackTo(setUnopenedAreaPullbackT);
			return setUnopenedAreaPullbackT;
		}

		// Token: 0x0601CEC8 RID: 118472 RVA: 0x00411C83 File Offset: 0x0040FE83
		public void UnPackTo(ISetUnopenedAreaPullbackT _o)
		{
			_o.Type = this.Type;
			_o.IsOpen = this.IsOpen;
		}

		// Token: 0x0601CEC9 RID: 118473 RVA: 0x00411CA0 File Offset: 0x0040FEA0
		public static Offset<ISetUnopenedAreaPullback> Pack(FlatBufferBuilder builder, ISetUnopenedAreaPullbackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetUnopenedAreaPullback>);
			}
			return ISetUnopenedAreaPullback.CreateISetUnopenedAreaPullback(builder, _o.Type, _o.IsOpen);
		}

		// Token: 0x0400D282 RID: 53890
		private Table __p;
	}
}
