using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA7 RID: 15271
	public struct IShowTimelineBase : IFlatbufferObject
	{
		// Token: 0x170068AF RID: 26799
		// (get) Token: 0x06014EE9 RID: 85737 RVA: 0x00309426 File Offset: 0x00307626
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014EEA RID: 85738 RVA: 0x00309433 File Offset: 0x00307633
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014EEB RID: 85739 RVA: 0x0030943C File Offset: 0x0030763C
		public static IShowTimelineBase GetRootAsIShowTimelineBase(ByteBuffer _bb)
		{
			return IShowTimelineBase.GetRootAsIShowTimelineBase(_bb, default(IShowTimelineBase));
		}

		// Token: 0x06014EEC RID: 85740 RVA: 0x00309458 File Offset: 0x00307658
		public static IShowTimelineBase GetRootAsIShowTimelineBase(ByteBuffer _bb, IShowTimelineBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014EED RID: 85741 RVA: 0x00309475 File Offset: 0x00307675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014EEE RID: 85742 RVA: 0x00309484 File Offset: 0x00307684
		public IShowTimelineBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068B0 RID: 26800
		// (get) Token: 0x06014EEF RID: 85743 RVA: 0x00309494 File Offset: 0x00307694
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x003094D0 File Offset: 0x003076D0
		public static Offset<IShowTimelineBase> CreateIShowTimelineBase(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint)
		{
			builder.StartTable(1);
			IShowTimelineBase.AddType(builder, Type);
			return IShowTimelineBase.EndIShowTimelineBase(builder);
		}

		// Token: 0x06014EF1 RID: 85745 RVA: 0x003094E6 File Offset: 0x003076E6
		public static void StartIShowTimelineBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x003094EF File Offset: 0x003076EF
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014EF3 RID: 85747 RVA: 0x003094FA File Offset: 0x003076FA
		public static Offset<IShowTimelineBase> EndIShowTimelineBase(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineBase>(builder.EndTable());
		}

		// Token: 0x06014EF4 RID: 85748 RVA: 0x00309508 File Offset: 0x00307708
		public IShowTimelineBaseT UnPack()
		{
			IShowTimelineBaseT showTimelineBaseT = new IShowTimelineBaseT();
			this.UnPackTo(showTimelineBaseT);
			return showTimelineBaseT;
		}

		// Token: 0x06014EF5 RID: 85749 RVA: 0x00309523 File Offset: 0x00307723
		public void UnPackTo(IShowTimelineBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014EF6 RID: 85750 RVA: 0x00309534 File Offset: 0x00307734
		public static Offset<IShowTimelineBase> Pack(FlatBufferBuilder builder, IShowTimelineBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineBase>);
			}
			return IShowTimelineBase.CreateIShowTimelineBase(builder, _o.Type);
		}

		// Token: 0x0400B11E RID: 45342
		private Table __p;
	}
}
