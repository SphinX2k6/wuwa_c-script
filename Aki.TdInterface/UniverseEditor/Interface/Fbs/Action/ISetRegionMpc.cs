using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007064 RID: 28772
	public struct ISetRegionMpc : IFlatbufferObject
	{
		// Token: 0x1700D5DA RID: 54746
		// (get) Token: 0x06032F14 RID: 208660 RVA: 0x006DF6CE File Offset: 0x006DD8CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F15 RID: 208661 RVA: 0x006DF6DB File Offset: 0x006DD8DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F16 RID: 208662 RVA: 0x006DF6E4 File Offset: 0x006DD8E4
		public static ISetRegionMpc GetRootAsISetRegionMpc(ByteBuffer _bb)
		{
			return ISetRegionMpc.GetRootAsISetRegionMpc(_bb, default(ISetRegionMpc));
		}

		// Token: 0x06032F17 RID: 208663 RVA: 0x006DF700 File Offset: 0x006DD900
		public static ISetRegionMpc GetRootAsISetRegionMpc(ByteBuffer _bb, ISetRegionMpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F18 RID: 208664 RVA: 0x006DF71D File Offset: 0x006DD91D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F19 RID: 208665 RVA: 0x006DF72C File Offset: 0x006DD92C
		public ISetRegionMpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5DB RID: 54747
		// (get) Token: 0x06032F1A RID: 208666 RVA: 0x006DF73C File Offset: 0x006DD93C
		public ERegionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERegionConfigType.Mpc;
				}
				return (ERegionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5DC RID: 54748
		// (get) Token: 0x06032F1B RID: 208667 RVA: 0x006DF778 File Offset: 0x006DD978
		public int RegionMpcId
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

		// Token: 0x06032F1C RID: 208668 RVA: 0x006DF7B4 File Offset: 0x006DD9B4
		public static Offset<ISetRegionMpc> CreateISetRegionMpc(FlatBufferBuilder builder, ERegionConfigType Type = ERegionConfigType.Mpc, int RegionMpcId = 0)
		{
			builder.StartTable(2);
			ISetRegionMpc.AddRegionMpcId(builder, RegionMpcId);
			ISetRegionMpc.AddType(builder, Type);
			return ISetRegionMpc.EndISetRegionMpc(builder);
		}

		// Token: 0x06032F1D RID: 208669 RVA: 0x006DF7D1 File Offset: 0x006DD9D1
		public static void StartISetRegionMpc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032F1E RID: 208670 RVA: 0x006DF7DA File Offset: 0x006DD9DA
		public static void AddType(FlatBufferBuilder builder, ERegionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F1F RID: 208671 RVA: 0x006DF7E5 File Offset: 0x006DD9E5
		public static void AddRegionMpcId(FlatBufferBuilder builder, int regionMpcId)
		{
			builder.AddInt(1, regionMpcId, 0);
		}

		// Token: 0x06032F20 RID: 208672 RVA: 0x006DF7F0 File Offset: 0x006DD9F0
		public static Offset<ISetRegionMpc> EndISetRegionMpc(FlatBufferBuilder builder)
		{
			return new Offset<ISetRegionMpc>(builder.EndTable());
		}

		// Token: 0x06032F21 RID: 208673 RVA: 0x006DF800 File Offset: 0x006DDA00
		public ISetRegionMpcT UnPack()
		{
			ISetRegionMpcT setRegionMpcT = new ISetRegionMpcT();
			this.UnPackTo(setRegionMpcT);
			return setRegionMpcT;
		}

		// Token: 0x06032F22 RID: 208674 RVA: 0x006DF81B File Offset: 0x006DDA1B
		public void UnPackTo(ISetRegionMpcT _o)
		{
			_o.Type = this.Type;
			_o.RegionMpcId = this.RegionMpcId;
		}

		// Token: 0x06032F23 RID: 208675 RVA: 0x006DF838 File Offset: 0x006DDA38
		public static Offset<ISetRegionMpc> Pack(FlatBufferBuilder builder, ISetRegionMpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRegionMpc>);
			}
			return ISetRegionMpc.CreateISetRegionMpc(builder, _o.Type, _o.RegionMpcId);
		}

		// Token: 0x04011AC7 RID: 72391
		private Table __p;
	}
}
