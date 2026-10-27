using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006462 RID: 25698
	public struct ICommonBtContext : IFlatbufferObject
	{
		// Token: 0x1700BF3D RID: 48957
		// (get) Token: 0x0602C784 RID: 182148 RVA: 0x00619379 File Offset: 0x00617579
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C785 RID: 182149 RVA: 0x00619386 File Offset: 0x00617586
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C786 RID: 182150 RVA: 0x00619390 File Offset: 0x00617590
		public static ICommonBtContext GetRootAsICommonBtContext(ByteBuffer _bb)
		{
			return ICommonBtContext.GetRootAsICommonBtContext(_bb, default(ICommonBtContext));
		}

		// Token: 0x0602C787 RID: 182151 RVA: 0x006193AC File Offset: 0x006175AC
		public static ICommonBtContext GetRootAsICommonBtContext(ByteBuffer _bb, ICommonBtContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C788 RID: 182152 RVA: 0x006193C9 File Offset: 0x006175C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C789 RID: 182153 RVA: 0x006193D8 File Offset: 0x006175D8
		public ICommonBtContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF3E RID: 48958
		// (get) Token: 0x0602C78A RID: 182154 RVA: 0x006193E8 File Offset: 0x006175E8
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF3F RID: 48959
		// (get) Token: 0x0602C78B RID: 182155 RVA: 0x00619424 File Offset: 0x00617624
		public int Id
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

		// Token: 0x0602C78C RID: 182156 RVA: 0x00619460 File Offset: 0x00617660
		public static Offset<ICommonBtContext> CreateICommonBtContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			ICommonBtContext.AddId(builder, Id);
			ICommonBtContext.AddType(builder, Type);
			return ICommonBtContext.EndICommonBtContext(builder);
		}

		// Token: 0x0602C78D RID: 182157 RVA: 0x0061947D File Offset: 0x0061767D
		public static void StartICommonBtContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C78E RID: 182158 RVA: 0x00619486 File Offset: 0x00617686
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C78F RID: 182159 RVA: 0x00619491 File Offset: 0x00617691
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602C790 RID: 182160 RVA: 0x0061949C File Offset: 0x0061769C
		public static Offset<ICommonBtContext> EndICommonBtContext(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtContext>(builder.EndTable());
		}

		// Token: 0x0602C791 RID: 182161 RVA: 0x006194AC File Offset: 0x006176AC
		public ICommonBtContextT UnPack()
		{
			ICommonBtContextT commonBtContextT = new ICommonBtContextT();
			this.UnPackTo(commonBtContextT);
			return commonBtContextT;
		}

		// Token: 0x0602C792 RID: 182162 RVA: 0x006194C7 File Offset: 0x006176C7
		public void UnPackTo(ICommonBtContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602C793 RID: 182163 RVA: 0x006194E4 File Offset: 0x006176E4
		public static Offset<ICommonBtContext> Pack(FlatBufferBuilder builder, ICommonBtContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtContext>);
			}
			return ICommonBtContext.CreateICommonBtContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x04010A5F RID: 68191
		private Table __p;
	}
}
