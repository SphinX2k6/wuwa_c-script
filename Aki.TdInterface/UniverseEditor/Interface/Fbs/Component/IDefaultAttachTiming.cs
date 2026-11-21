using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E0 RID: 21984
	public struct IDefaultAttachTiming : IFlatbufferObject
	{
		// Token: 0x17009D65 RID: 40293
		// (get) Token: 0x06022FC5 RID: 143301 RVA: 0x004D0755 File Offset: 0x004CE955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FC6 RID: 143302 RVA: 0x004D0762 File Offset: 0x004CE962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FC7 RID: 143303 RVA: 0x004D076C File Offset: 0x004CE96C
		public static IDefaultAttachTiming GetRootAsIDefaultAttachTiming(ByteBuffer _bb)
		{
			return IDefaultAttachTiming.GetRootAsIDefaultAttachTiming(_bb, default(IDefaultAttachTiming));
		}

		// Token: 0x06022FC8 RID: 143304 RVA: 0x004D0788 File Offset: 0x004CE988
		public static IDefaultAttachTiming GetRootAsIDefaultAttachTiming(ByteBuffer _bb, IDefaultAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FC9 RID: 143305 RVA: 0x004D07A5 File Offset: 0x004CE9A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FCA RID: 143306 RVA: 0x004D07B4 File Offset: 0x004CE9B4
		public IDefaultAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D66 RID: 40294
		// (get) Token: 0x06022FCB RID: 143307 RVA: 0x004D07C4 File Offset: 0x004CE9C4
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

		// Token: 0x06022FCC RID: 143308 RVA: 0x004D0800 File Offset: 0x004CEA00
		public static Offset<IDefaultAttachTiming> CreateIDefaultAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default)
		{
			builder.StartTable(1);
			IDefaultAttachTiming.AddType(builder, Type);
			return IDefaultAttachTiming.EndIDefaultAttachTiming(builder);
		}

		// Token: 0x06022FCD RID: 143309 RVA: 0x004D0816 File Offset: 0x004CEA16
		public static void StartIDefaultAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022FCE RID: 143310 RVA: 0x004D081F File Offset: 0x004CEA1F
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FCF RID: 143311 RVA: 0x004D082A File Offset: 0x004CEA2A
		public static Offset<IDefaultAttachTiming> EndIDefaultAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IDefaultAttachTiming>(builder.EndTable());
		}

		// Token: 0x06022FD0 RID: 143312 RVA: 0x004D0838 File Offset: 0x004CEA38
		public IDefaultAttachTimingT UnPack()
		{
			IDefaultAttachTimingT defaultAttachTimingT = new IDefaultAttachTimingT();
			this.UnPackTo(defaultAttachTimingT);
			return defaultAttachTimingT;
		}

		// Token: 0x06022FD1 RID: 143313 RVA: 0x004D0853 File Offset: 0x004CEA53
		public void UnPackTo(IDefaultAttachTimingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022FD2 RID: 143314 RVA: 0x004D0864 File Offset: 0x004CEA64
		public static Offset<IDefaultAttachTiming> Pack(FlatBufferBuilder builder, IDefaultAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDefaultAttachTiming>);
			}
			return IDefaultAttachTiming.CreateIDefaultAttachTiming(builder, _o.Type);
		}

		// Token: 0x0400EC7B RID: 60539
		private Table __p;
	}
}
