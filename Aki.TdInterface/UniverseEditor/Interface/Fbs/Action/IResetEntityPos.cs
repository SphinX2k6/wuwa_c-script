using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E85 RID: 28293
	public struct IResetEntityPos : IFlatbufferObject
	{
		// Token: 0x1700D2B1 RID: 53937
		// (get) Token: 0x06032009 RID: 204809 RVA: 0x006C3804 File Offset: 0x006C1A04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603200A RID: 204810 RVA: 0x006C3811 File Offset: 0x006C1A11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603200B RID: 204811 RVA: 0x006C3818 File Offset: 0x006C1A18
		public static IResetEntityPos GetRootAsIResetEntityPos(ByteBuffer _bb)
		{
			return IResetEntityPos.GetRootAsIResetEntityPos(_bb, default(IResetEntityPos));
		}

		// Token: 0x0603200C RID: 204812 RVA: 0x006C3834 File Offset: 0x006C1A34
		public static IResetEntityPos GetRootAsIResetEntityPos(ByteBuffer _bb, IResetEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603200D RID: 204813 RVA: 0x006C3851 File Offset: 0x006C1A51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603200E RID: 204814 RVA: 0x006C3860 File Offset: 0x006C1A60
		public IResetEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2B2 RID: 53938
		// (get) Token: 0x0603200F RID: 204815 RVA: 0x006C3870 File Offset: 0x006C1A70
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032010 RID: 204816 RVA: 0x006C38AC File Offset: 0x006C1AAC
		public static Offset<IResetEntityPos> CreateIResetEntityPos(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			IResetEntityPos.AddEntityId(builder, EntityId);
			return IResetEntityPos.EndIResetEntityPos(builder);
		}

		// Token: 0x06032011 RID: 204817 RVA: 0x006C38C2 File Offset: 0x006C1AC2
		public static void StartIResetEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032012 RID: 204818 RVA: 0x006C38CB File Offset: 0x006C1ACB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06032013 RID: 204819 RVA: 0x006C38D6 File Offset: 0x006C1AD6
		public static Offset<IResetEntityPos> EndIResetEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IResetEntityPos>(builder.EndTable());
		}

		// Token: 0x06032014 RID: 204820 RVA: 0x006C38E4 File Offset: 0x006C1AE4
		public IResetEntityPosT UnPack()
		{
			IResetEntityPosT resetEntityPosT = new IResetEntityPosT();
			this.UnPackTo(resetEntityPosT);
			return resetEntityPosT;
		}

		// Token: 0x06032015 RID: 204821 RVA: 0x006C38FF File Offset: 0x006C1AFF
		public void UnPackTo(IResetEntityPosT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06032016 RID: 204822 RVA: 0x006C3910 File Offset: 0x006C1B10
		public static Offset<IResetEntityPos> Pack(FlatBufferBuilder builder, IResetEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetEntityPos>);
			}
			return IResetEntityPos.CreateIResetEntityPos(builder, _o.EntityId);
		}

		// Token: 0x04011873 RID: 71795
		private Table __p;
	}
}
