using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C1 RID: 20673
	public struct ICompleteCertainFishingEntrust : IFlatbufferObject
	{
		// Token: 0x1700942D RID: 37933
		// (get) Token: 0x06020639 RID: 132665 RVA: 0x0047C694 File Offset: 0x0047A894
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602063A RID: 132666 RVA: 0x0047C6A1 File Offset: 0x0047A8A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602063B RID: 132667 RVA: 0x0047C6A8 File Offset: 0x0047A8A8
		public static ICompleteCertainFishingEntrust GetRootAsICompleteCertainFishingEntrust(ByteBuffer _bb)
		{
			return ICompleteCertainFishingEntrust.GetRootAsICompleteCertainFishingEntrust(_bb, default(ICompleteCertainFishingEntrust));
		}

		// Token: 0x0602063C RID: 132668 RVA: 0x0047C6C4 File Offset: 0x0047A8C4
		public static ICompleteCertainFishingEntrust GetRootAsICompleteCertainFishingEntrust(ByteBuffer _bb, ICompleteCertainFishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602063D RID: 132669 RVA: 0x0047C6E1 File Offset: 0x0047A8E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602063E RID: 132670 RVA: 0x0047C6F0 File Offset: 0x0047A8F0
		public ICompleteCertainFishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700942E RID: 37934
		// (get) Token: 0x0602063F RID: 132671 RVA: 0x0047C700 File Offset: 0x0047A900
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700942F RID: 37935
		// (get) Token: 0x06020640 RID: 132672 RVA: 0x0047C73C File Offset: 0x0047A93C
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

		// Token: 0x17009430 RID: 37936
		// (get) Token: 0x06020641 RID: 132673 RVA: 0x0047C778 File Offset: 0x0047A978
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020642 RID: 132674 RVA: 0x0047C7B4 File Offset: 0x0047A9B4
		public static Offset<ICompleteCertainFishingEntrust> CreateICompleteCertainFishingEntrust(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int Id = 0, int Count = 0)
		{
			builder.StartTable(3);
			ICompleteCertainFishingEntrust.AddCount(builder, Count);
			ICompleteCertainFishingEntrust.AddId(builder, Id);
			ICompleteCertainFishingEntrust.AddType(builder, Type);
			return ICompleteCertainFishingEntrust.EndICompleteCertainFishingEntrust(builder);
		}

		// Token: 0x06020643 RID: 132675 RVA: 0x0047C7D8 File Offset: 0x0047A9D8
		public static void StartICompleteCertainFishingEntrust(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020644 RID: 132676 RVA: 0x0047C7E1 File Offset: 0x0047A9E1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020645 RID: 132677 RVA: 0x0047C7EC File Offset: 0x0047A9EC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06020646 RID: 132678 RVA: 0x0047C7F7 File Offset: 0x0047A9F7
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06020647 RID: 132679 RVA: 0x0047C802 File Offset: 0x0047AA02
		public static Offset<ICompleteCertainFishingEntrust> EndICompleteCertainFishingEntrust(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteCertainFishingEntrust>(builder.EndTable());
		}

		// Token: 0x06020648 RID: 132680 RVA: 0x0047C810 File Offset: 0x0047AA10
		public ICompleteCertainFishingEntrustT UnPack()
		{
			ICompleteCertainFishingEntrustT completeCertainFishingEntrustT = new ICompleteCertainFishingEntrustT();
			this.UnPackTo(completeCertainFishingEntrustT);
			return completeCertainFishingEntrustT;
		}

		// Token: 0x06020649 RID: 132681 RVA: 0x0047C82B File Offset: 0x0047AA2B
		public void UnPackTo(ICompleteCertainFishingEntrustT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Count = this.Count;
		}

		// Token: 0x0602064A RID: 132682 RVA: 0x0047C854 File Offset: 0x0047AA54
		public static Offset<ICompleteCertainFishingEntrust> Pack(FlatBufferBuilder builder, ICompleteCertainFishingEntrustT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteCertainFishingEntrust>);
			}
			return ICompleteCertainFishingEntrust.CreateICompleteCertainFishingEntrust(builder, _o.Type, _o.Id, _o.Count);
		}

		// Token: 0x0400DFD3 RID: 57299
		private Table __p;
	}
}
