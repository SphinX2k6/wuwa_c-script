using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D1D RID: 23837
	public struct IPavedWayConfig : IFlatbufferObject
	{
		// Token: 0x1700AF3C RID: 44860
		// (get) Token: 0x060279CC RID: 162252 RVA: 0x0056B6BA File Offset: 0x005698BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060279CD RID: 162253 RVA: 0x0056B6C7 File Offset: 0x005698C7
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060279CE RID: 162254 RVA: 0x0056B6D6 File Offset: 0x005698D6
		public IPavedWayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF3D RID: 44861
		// (get) Token: 0x060279CF RID: 162255 RVA: 0x0056B6E6 File Offset: 0x005698E6
		public bool AutoSprint
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060279D0 RID: 162256 RVA: 0x0056B706 File Offset: 0x00569906
		public static Offset<IPavedWayConfig> CreateIPavedWayConfig(FlatBufferBuilder builder, bool AutoSprint)
		{
			builder.Prep(1, 1);
			builder.PutBool(AutoSprint);
			return new Offset<IPavedWayConfig>(builder.Offset);
		}

		// Token: 0x060279D1 RID: 162257 RVA: 0x0056B724 File Offset: 0x00569924
		public IPavedWayConfigT UnPack()
		{
			IPavedWayConfigT pavedWayConfigT = new IPavedWayConfigT();
			this.UnPackTo(pavedWayConfigT);
			return pavedWayConfigT;
		}

		// Token: 0x060279D2 RID: 162258 RVA: 0x0056B73F File Offset: 0x0056993F
		public void UnPackTo(IPavedWayConfigT _o)
		{
			_o.AutoSprint = this.AutoSprint;
		}

		// Token: 0x060279D3 RID: 162259 RVA: 0x0056B750 File Offset: 0x00569950
		public static Offset<IPavedWayConfig> Pack(FlatBufferBuilder builder, IPavedWayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPavedWayConfig>);
			}
			return IPavedWayConfig.CreateIPavedWayConfig(builder, _o.AutoSprint);
		}

		// Token: 0x0400F870 RID: 63600
		private Struct __p;
	}
}
