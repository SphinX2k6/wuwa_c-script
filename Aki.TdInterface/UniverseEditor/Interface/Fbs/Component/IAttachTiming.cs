using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EB RID: 21483
	public struct IAttachTiming : IFlatbufferObject
	{
		// Token: 0x17009807 RID: 38919
		// (get) Token: 0x06021921 RID: 137505 RVA: 0x004A10E2 File Offset: 0x0049F2E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021922 RID: 137506 RVA: 0x004A10EF File Offset: 0x0049F2EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021923 RID: 137507 RVA: 0x004A10F8 File Offset: 0x0049F2F8
		public static IAttachTiming GetRootAsIAttachTiming(ByteBuffer _bb)
		{
			return IAttachTiming.GetRootAsIAttachTiming(_bb, default(IAttachTiming));
		}

		// Token: 0x06021924 RID: 137508 RVA: 0x004A1114 File Offset: 0x0049F314
		public static IAttachTiming GetRootAsIAttachTiming(ByteBuffer _bb, IAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021925 RID: 137509 RVA: 0x004A1131 File Offset: 0x0049F331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021926 RID: 137510 RVA: 0x004A1140 File Offset: 0x0049F340
		public IAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009808 RID: 38920
		// (get) Token: 0x06021927 RID: 137511 RVA: 0x004A1150 File Offset: 0x0049F350
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021928 RID: 137512 RVA: 0x004A118C File Offset: 0x0049F38C
		public static Offset<IAttachTiming> CreateIAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default)
		{
			builder.StartTable(1);
			IAttachTiming.AddType(builder, Type);
			return IAttachTiming.EndIAttachTiming(builder);
		}

		// Token: 0x06021929 RID: 137513 RVA: 0x004A11A2 File Offset: 0x0049F3A2
		public static void StartIAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602192A RID: 137514 RVA: 0x004A11AB File Offset: 0x0049F3AB
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602192B RID: 137515 RVA: 0x004A11B6 File Offset: 0x0049F3B6
		public static Offset<IAttachTiming> EndIAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTiming>(builder.EndTable());
		}

		// Token: 0x0602192C RID: 137516 RVA: 0x004A11C4 File Offset: 0x0049F3C4
		public IAttachTimingT UnPack()
		{
			IAttachTimingT attachTimingT = new IAttachTimingT();
			this.UnPackTo(attachTimingT);
			return attachTimingT;
		}

		// Token: 0x0602192D RID: 137517 RVA: 0x004A11DF File Offset: 0x0049F3DF
		public void UnPackTo(IAttachTimingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602192E RID: 137518 RVA: 0x004A11F0 File Offset: 0x0049F3F0
		public static Offset<IAttachTiming> Pack(FlatBufferBuilder builder, IAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTiming>);
			}
			return IAttachTiming.CreateIAttachTiming(builder, _o.Type);
		}

		// Token: 0x0400E850 RID: 59472
		private Table __p;
	}
}
