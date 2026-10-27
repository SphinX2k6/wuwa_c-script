using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E16 RID: 28182
	public struct IRecoverDurability : IFlatbufferObject
	{
		// Token: 0x1700D20F RID: 53775
		// (get) Token: 0x06031CAE RID: 203950 RVA: 0x006BDC0A File Offset: 0x006BBE0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CAF RID: 203951 RVA: 0x006BDC17 File Offset: 0x006BBE17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CB0 RID: 203952 RVA: 0x006BDC20 File Offset: 0x006BBE20
		public static IRecoverDurability GetRootAsIRecoverDurability(ByteBuffer _bb)
		{
			return IRecoverDurability.GetRootAsIRecoverDurability(_bb, default(IRecoverDurability));
		}

		// Token: 0x06031CB1 RID: 203953 RVA: 0x006BDC3C File Offset: 0x006BBE3C
		public static IRecoverDurability GetRootAsIRecoverDurability(ByteBuffer _bb, IRecoverDurability obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CB2 RID: 203954 RVA: 0x006BDC59 File Offset: 0x006BBE59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CB3 RID: 203955 RVA: 0x006BDC68 File Offset: 0x006BBE68
		public IRecoverDurability __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D210 RID: 53776
		// (get) Token: 0x06031CB4 RID: 203956 RVA: 0x006BDC78 File Offset: 0x006BBE78
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

		// Token: 0x06031CB5 RID: 203957 RVA: 0x006BDCB4 File Offset: 0x006BBEB4
		public static Offset<IRecoverDurability> CreateIRecoverDurability(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			IRecoverDurability.AddEntityId(builder, EntityId);
			return IRecoverDurability.EndIRecoverDurability(builder);
		}

		// Token: 0x06031CB6 RID: 203958 RVA: 0x006BDCCA File Offset: 0x006BBECA
		public static void StartIRecoverDurability(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031CB7 RID: 203959 RVA: 0x006BDCD3 File Offset: 0x006BBED3
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06031CB8 RID: 203960 RVA: 0x006BDCDE File Offset: 0x006BBEDE
		public static Offset<IRecoverDurability> EndIRecoverDurability(FlatBufferBuilder builder)
		{
			return new Offset<IRecoverDurability>(builder.EndTable());
		}

		// Token: 0x06031CB9 RID: 203961 RVA: 0x006BDCEC File Offset: 0x006BBEEC
		public IRecoverDurabilityT UnPack()
		{
			IRecoverDurabilityT recoverDurabilityT = new IRecoverDurabilityT();
			this.UnPackTo(recoverDurabilityT);
			return recoverDurabilityT;
		}

		// Token: 0x06031CBA RID: 203962 RVA: 0x006BDD07 File Offset: 0x006BBF07
		public void UnPackTo(IRecoverDurabilityT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06031CBB RID: 203963 RVA: 0x006BDD18 File Offset: 0x006BBF18
		public static Offset<IRecoverDurability> Pack(FlatBufferBuilder builder, IRecoverDurabilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecoverDurability>);
			}
			return IRecoverDurability.CreateIRecoverDurability(builder, _o.EntityId);
		}

		// Token: 0x040117FE RID: 71678
		private Table __p;
	}
}
