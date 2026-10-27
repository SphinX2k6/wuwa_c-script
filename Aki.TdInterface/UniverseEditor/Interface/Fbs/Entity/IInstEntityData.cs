using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E1 RID: 18401
	public struct IInstEntityData : IFlatbufferObject
	{
		// Token: 0x17008440 RID: 33856
		// (get) Token: 0x0601C72E RID: 116526 RVA: 0x004066C8 File Offset: 0x004048C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C72F RID: 116527 RVA: 0x004066D5 File Offset: 0x004048D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C730 RID: 116528 RVA: 0x004066DC File Offset: 0x004048DC
		public static IInstEntityData GetRootAsIInstEntityData(ByteBuffer _bb)
		{
			return IInstEntityData.GetRootAsIInstEntityData(_bb, default(IInstEntityData));
		}

		// Token: 0x0601C731 RID: 116529 RVA: 0x004066F8 File Offset: 0x004048F8
		public static IInstEntityData GetRootAsIInstEntityData(ByteBuffer _bb, IInstEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C732 RID: 116530 RVA: 0x00406715 File Offset: 0x00404915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C733 RID: 116531 RVA: 0x00406724 File Offset: 0x00404924
		public IInstEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008441 RID: 33857
		// (get) Token: 0x0601C734 RID: 116532 RVA: 0x00406734 File Offset: 0x00404934
		public int InstId
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

		// Token: 0x17008442 RID: 33858
		// (get) Token: 0x0601C735 RID: 116533 RVA: 0x00406770 File Offset: 0x00404970
		public int EntityConfigId
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

		// Token: 0x0601C736 RID: 116534 RVA: 0x004067AC File Offset: 0x004049AC
		public static Offset<IInstEntityData> CreateIInstEntityData(FlatBufferBuilder builder, int InstId = 0, int EntityConfigId = 0)
		{
			builder.StartTable(2);
			IInstEntityData.AddEntityConfigId(builder, EntityConfigId);
			IInstEntityData.AddInstId(builder, InstId);
			return IInstEntityData.EndIInstEntityData(builder);
		}

		// Token: 0x0601C737 RID: 116535 RVA: 0x004067C9 File Offset: 0x004049C9
		public static void StartIInstEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C738 RID: 116536 RVA: 0x004067D2 File Offset: 0x004049D2
		public static void AddInstId(FlatBufferBuilder builder, int instId)
		{
			builder.AddInt(0, instId, 0);
		}

		// Token: 0x0601C739 RID: 116537 RVA: 0x004067DD File Offset: 0x004049DD
		public static void AddEntityConfigId(FlatBufferBuilder builder, int entityConfigId)
		{
			builder.AddInt(1, entityConfigId, 0);
		}

		// Token: 0x0601C73A RID: 116538 RVA: 0x004067E8 File Offset: 0x004049E8
		public static Offset<IInstEntityData> EndIInstEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IInstEntityData>(builder.EndTable());
		}

		// Token: 0x0601C73B RID: 116539 RVA: 0x004067F8 File Offset: 0x004049F8
		public IInstEntityDataT UnPack()
		{
			IInstEntityDataT instEntityDataT = new IInstEntityDataT();
			this.UnPackTo(instEntityDataT);
			return instEntityDataT;
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x00406813 File Offset: 0x00404A13
		public void UnPackTo(IInstEntityDataT _o)
		{
			_o.InstId = this.InstId;
			_o.EntityConfigId = this.EntityConfigId;
		}

		// Token: 0x0601C73D RID: 116541 RVA: 0x00406830 File Offset: 0x00404A30
		public static Offset<IInstEntityData> Pack(FlatBufferBuilder builder, IInstEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstEntityData>);
			}
			return IInstEntityData.CreateIInstEntityData(builder, _o.InstId, _o.EntityConfigId);
		}

		// Token: 0x0400CC78 RID: 52344
		private Table __p;
	}
}
