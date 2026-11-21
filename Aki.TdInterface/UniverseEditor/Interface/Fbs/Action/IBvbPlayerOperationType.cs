using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BF RID: 26815
	public struct IBvbPlayerOperationType : IFlatbufferObject
	{
		// Token: 0x1700C519 RID: 50457
		// (get) Token: 0x0602DDCB RID: 187851 RVA: 0x00644608 File Offset: 0x00642808
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDCC RID: 187852 RVA: 0x00644615 File Offset: 0x00642815
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDCD RID: 187853 RVA: 0x0064461C File Offset: 0x0064281C
		public static IBvbPlayerOperationType GetRootAsIBvbPlayerOperationType(ByteBuffer _bb)
		{
			return IBvbPlayerOperationType.GetRootAsIBvbPlayerOperationType(_bb, default(IBvbPlayerOperationType));
		}

		// Token: 0x0602DDCE RID: 187854 RVA: 0x00644638 File Offset: 0x00642838
		public static IBvbPlayerOperationType GetRootAsIBvbPlayerOperationType(ByteBuffer _bb, IBvbPlayerOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDCF RID: 187855 RVA: 0x00644655 File Offset: 0x00642855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DDD0 RID: 187856 RVA: 0x00644664 File Offset: 0x00642864
		public IBvbPlayerOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C51A RID: 50458
		// (get) Token: 0x0602DDD1 RID: 187857 RVA: 0x00644674 File Offset: 0x00642874
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DDD2 RID: 187858 RVA: 0x006446B0 File Offset: 0x006428B0
		public static Offset<IBvbPlayerOperationType> CreateIBvbPlayerOperationType(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbPlayerOperationType.AddType(builder, Type);
			return IBvbPlayerOperationType.EndIBvbPlayerOperationType(builder);
		}

		// Token: 0x0602DDD3 RID: 187859 RVA: 0x006446C6 File Offset: 0x006428C6
		public static void StartIBvbPlayerOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DDD4 RID: 187860 RVA: 0x006446CF File Offset: 0x006428CF
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DDD5 RID: 187861 RVA: 0x006446DA File Offset: 0x006428DA
		public static Offset<IBvbPlayerOperationType> EndIBvbPlayerOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerOperationType>(builder.EndTable());
		}

		// Token: 0x0602DDD6 RID: 187862 RVA: 0x006446E8 File Offset: 0x006428E8
		public IBvbPlayerOperationTypeT UnPack()
		{
			IBvbPlayerOperationTypeT bvbPlayerOperationTypeT = new IBvbPlayerOperationTypeT();
			this.UnPackTo(bvbPlayerOperationTypeT);
			return bvbPlayerOperationTypeT;
		}

		// Token: 0x0602DDD7 RID: 187863 RVA: 0x00644703 File Offset: 0x00642903
		public void UnPackTo(IBvbPlayerOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DDD8 RID: 187864 RVA: 0x00644714 File Offset: 0x00642914
		public static Offset<IBvbPlayerOperationType> Pack(FlatBufferBuilder builder, IBvbPlayerOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerOperationType>);
			}
			return IBvbPlayerOperationType.CreateIBvbPlayerOperationType(builder, _o.Type);
		}

		// Token: 0x040115B1 RID: 71089
		private Table __p;
	}
}
