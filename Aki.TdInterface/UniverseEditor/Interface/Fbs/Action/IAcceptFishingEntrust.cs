using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200606E RID: 24686
	public struct IAcceptFishingEntrust : IFlatbufferObject
	{
		// Token: 0x1700B5E7 RID: 46567
		// (get) Token: 0x06029CCC RID: 171212 RVA: 0x005BC42A File Offset: 0x005BA62A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CCD RID: 171213 RVA: 0x005BC437 File Offset: 0x005BA637
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CCE RID: 171214 RVA: 0x005BC440 File Offset: 0x005BA640
		public static IAcceptFishingEntrust GetRootAsIAcceptFishingEntrust(ByteBuffer _bb)
		{
			return IAcceptFishingEntrust.GetRootAsIAcceptFishingEntrust(_bb, default(IAcceptFishingEntrust));
		}

		// Token: 0x06029CCF RID: 171215 RVA: 0x005BC45C File Offset: 0x005BA65C
		public static IAcceptFishingEntrust GetRootAsIAcceptFishingEntrust(ByteBuffer _bb, IAcceptFishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CD0 RID: 171216 RVA: 0x005BC479 File Offset: 0x005BA679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CD1 RID: 171217 RVA: 0x005BC488 File Offset: 0x005BA688
		public IAcceptFishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5E8 RID: 46568
		// (get) Token: 0x06029CD2 RID: 171218 RVA: 0x005BC498 File Offset: 0x005BA698
		public int EntrustId
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

		// Token: 0x1700B5E9 RID: 46569
		// (get) Token: 0x06029CD3 RID: 171219 RVA: 0x005BC4D4 File Offset: 0x005BA6D4
		public bool IsAutoTracking
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5EA RID: 46570
		// (get) Token: 0x06029CD4 RID: 171220 RVA: 0x005BC514 File Offset: 0x005BA714
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029CD5 RID: 171221 RVA: 0x005BC550 File Offset: 0x005BA750
		public static Offset<IAcceptFishingEntrust> CreateIAcceptFishingEntrust(FlatBufferBuilder builder, int EntrustId = 0, bool IsAutoTracking = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAcceptFishingEntrust.AddEntrustId(builder, EntrustId);
			IAcceptFishingEntrust.AddNullMask(builder, NullMask);
			IAcceptFishingEntrust.AddIsAutoTracking(builder, IsAutoTracking);
			return IAcceptFishingEntrust.EndIAcceptFishingEntrust(builder);
		}

		// Token: 0x06029CD6 RID: 171222 RVA: 0x005BC574 File Offset: 0x005BA774
		public static void StartIAcceptFishingEntrust(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029CD7 RID: 171223 RVA: 0x005BC57D File Offset: 0x005BA77D
		public static void AddEntrustId(FlatBufferBuilder builder, int entrustId)
		{
			builder.AddInt(0, entrustId, 0);
		}

		// Token: 0x06029CD8 RID: 171224 RVA: 0x005BC588 File Offset: 0x005BA788
		public static void AddIsAutoTracking(FlatBufferBuilder builder, bool isAutoTracking)
		{
			builder.AddBool(1, isAutoTracking, false);
		}

		// Token: 0x06029CD9 RID: 171225 RVA: 0x005BC593 File Offset: 0x005BA793
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06029CDA RID: 171226 RVA: 0x005BC59E File Offset: 0x005BA79E
		public static Offset<IAcceptFishingEntrust> EndIAcceptFishingEntrust(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptFishingEntrust>(builder.EndTable());
		}

		// Token: 0x06029CDB RID: 171227 RVA: 0x005BC5AC File Offset: 0x005BA7AC
		public IAcceptFishingEntrustT UnPack()
		{
			IAcceptFishingEntrustT acceptFishingEntrustT = new IAcceptFishingEntrustT();
			this.UnPackTo(acceptFishingEntrustT);
			return acceptFishingEntrustT;
		}

		// Token: 0x06029CDC RID: 171228 RVA: 0x005BC5C7 File Offset: 0x005BA7C7
		public void UnPackTo(IAcceptFishingEntrustT _o)
		{
			_o.EntrustId = this.EntrustId;
			_o.IsAutoTracking = this.IsAutoTracking;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029CDD RID: 171229 RVA: 0x005BC5F0 File Offset: 0x005BA7F0
		public static Offset<IAcceptFishingEntrust> Pack(FlatBufferBuilder builder, IAcceptFishingEntrustT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptFishingEntrust>);
			}
			return IAcceptFishingEntrust.CreateIAcceptFishingEntrust(builder, _o.EntrustId, _o.IsAutoTracking, _o.NullMask);
		}

		// Token: 0x04010231 RID: 66097
		private Table __p;
	}
}
