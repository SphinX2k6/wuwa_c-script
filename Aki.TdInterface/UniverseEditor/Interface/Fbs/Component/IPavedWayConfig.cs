using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005716 RID: 22294
	public struct IPavedWayConfig : IFlatbufferObject
	{
		// Token: 0x1700A61C RID: 42524
		// (get) Token: 0x060254BD RID: 152765 RVA: 0x005259B3 File Offset: 0x00523BB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060254BE RID: 152766 RVA: 0x005259C0 File Offset: 0x00523BC0
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060254BF RID: 152767 RVA: 0x005259CF File Offset: 0x00523BCF
		public IPavedWayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A61D RID: 42525
		// (get) Token: 0x060254C0 RID: 152768 RVA: 0x005259DF File Offset: 0x00523BDF
		public bool AutoSprint
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060254C1 RID: 152769 RVA: 0x005259FF File Offset: 0x00523BFF
		public static Offset<IPavedWayConfig> CreateIPavedWayConfig(FlatBufferBuilder builder, bool AutoSprint)
		{
			builder.Prep(1, 1);
			builder.PutBool(AutoSprint);
			return new Offset<IPavedWayConfig>(builder.Offset);
		}

		// Token: 0x060254C2 RID: 152770 RVA: 0x00525A1C File Offset: 0x00523C1C
		public IPavedWayConfigT UnPack()
		{
			IPavedWayConfigT pavedWayConfigT = new IPavedWayConfigT();
			this.UnPackTo(pavedWayConfigT);
			return pavedWayConfigT;
		}

		// Token: 0x060254C3 RID: 152771 RVA: 0x00525A37 File Offset: 0x00523C37
		public void UnPackTo(IPavedWayConfigT _o)
		{
			_o.AutoSprint = this.AutoSprint;
		}

		// Token: 0x060254C4 RID: 152772 RVA: 0x00525A48 File Offset: 0x00523C48
		public static Offset<IPavedWayConfig> Pack(FlatBufferBuilder builder, IPavedWayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPavedWayConfig>);
			}
			return IPavedWayConfig.CreateIPavedWayConfig(builder, _o.AutoSprint);
		}

		// Token: 0x0400EB87 RID: 60295
		private Struct __p;
	}
}
