using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D0 RID: 26320
	public struct IAcceptFishingEntrust : IFlatbufferObject
	{
		// Token: 0x1700BF52 RID: 48978
		// (get) Token: 0x0602C380 RID: 181120 RVA: 0x0060590E File Offset: 0x00603B0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C381 RID: 181121 RVA: 0x0060591B File Offset: 0x00603B1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C382 RID: 181122 RVA: 0x00605924 File Offset: 0x00603B24
		public static IAcceptFishingEntrust GetRootAsIAcceptFishingEntrust(ByteBuffer _bb)
		{
			return IAcceptFishingEntrust.GetRootAsIAcceptFishingEntrust(_bb, default(IAcceptFishingEntrust));
		}

		// Token: 0x0602C383 RID: 181123 RVA: 0x00605940 File Offset: 0x00603B40
		public static IAcceptFishingEntrust GetRootAsIAcceptFishingEntrust(ByteBuffer _bb, IAcceptFishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C384 RID: 181124 RVA: 0x0060595D File Offset: 0x00603B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C385 RID: 181125 RVA: 0x0060596C File Offset: 0x00603B6C
		public IAcceptFishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF53 RID: 48979
		// (get) Token: 0x0602C386 RID: 181126 RVA: 0x0060597C File Offset: 0x00603B7C
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

		// Token: 0x1700BF54 RID: 48980
		// (get) Token: 0x0602C387 RID: 181127 RVA: 0x006059B8 File Offset: 0x00603BB8
		public bool IsAutoTracking
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF55 RID: 48981
		// (get) Token: 0x0602C388 RID: 181128 RVA: 0x006059F8 File Offset: 0x00603BF8
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

		// Token: 0x0602C389 RID: 181129 RVA: 0x00605A34 File Offset: 0x00603C34
		public static Offset<IAcceptFishingEntrust> CreateIAcceptFishingEntrust(FlatBufferBuilder builder, int EntrustId = 0, bool IsAutoTracking = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAcceptFishingEntrust.AddEntrustId(builder, EntrustId);
			IAcceptFishingEntrust.AddNullMask(builder, NullMask);
			IAcceptFishingEntrust.AddIsAutoTracking(builder, IsAutoTracking);
			return IAcceptFishingEntrust.EndIAcceptFishingEntrust(builder);
		}

		// Token: 0x0602C38A RID: 181130 RVA: 0x00605A58 File Offset: 0x00603C58
		public static void StartIAcceptFishingEntrust(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C38B RID: 181131 RVA: 0x00605A61 File Offset: 0x00603C61
		public static void AddEntrustId(FlatBufferBuilder builder, int entrustId)
		{
			builder.AddInt(0, entrustId, 0);
		}

		// Token: 0x0602C38C RID: 181132 RVA: 0x00605A6C File Offset: 0x00603C6C
		public static void AddIsAutoTracking(FlatBufferBuilder builder, bool isAutoTracking)
		{
			builder.AddBool(1, isAutoTracking, false);
		}

		// Token: 0x0602C38D RID: 181133 RVA: 0x00605A77 File Offset: 0x00603C77
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C38E RID: 181134 RVA: 0x00605A82 File Offset: 0x00603C82
		public static Offset<IAcceptFishingEntrust> EndIAcceptFishingEntrust(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptFishingEntrust>(builder.EndTable());
		}

		// Token: 0x0602C38F RID: 181135 RVA: 0x00605A90 File Offset: 0x00603C90
		public IAcceptFishingEntrustT UnPack()
		{
			IAcceptFishingEntrustT acceptFishingEntrustT = new IAcceptFishingEntrustT();
			this.UnPackTo(acceptFishingEntrustT);
			return acceptFishingEntrustT;
		}

		// Token: 0x0602C390 RID: 181136 RVA: 0x00605AAB File Offset: 0x00603CAB
		public void UnPackTo(IAcceptFishingEntrustT _o)
		{
			_o.EntrustId = this.EntrustId;
			_o.IsAutoTracking = this.IsAutoTracking;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C391 RID: 181137 RVA: 0x00605AD4 File Offset: 0x00603CD4
		public static Offset<IAcceptFishingEntrust> Pack(FlatBufferBuilder builder, IAcceptFishingEntrustT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptFishingEntrust>);
			}
			return IAcceptFishingEntrust.CreateIAcceptFishingEntrust(builder, _o.EntrustId, _o.IsAutoTracking, _o.NullMask);
		}

		// Token: 0x04011026 RID: 69670
		private Table __p;
	}
}
