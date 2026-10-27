using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005841 RID: 22593
	public struct IRenderFlag : IFlatbufferObject
	{
		// Token: 0x1700A8C9 RID: 43209
		// (get) Token: 0x06026022 RID: 155682 RVA: 0x0053D50C File Offset: 0x0053B70C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026023 RID: 155683 RVA: 0x0053D519 File Offset: 0x0053B719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06026024 RID: 155684 RVA: 0x0053D528 File Offset: 0x0053B728
		public IRenderFlag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8CA RID: 43210
		// (get) Token: 0x06026025 RID: 155685 RVA: 0x0053D538 File Offset: 0x0053B738
		public ERenderFlagType Type
		{
			get
			{
				return (ERenderFlagType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8CB RID: 43211
		// (get) Token: 0x06026026 RID: 155686 RVA: 0x0053D555 File Offset: 0x0053B755
		public bool Enable
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos + 1) > 0;
			}
		}

		// Token: 0x06026027 RID: 155687 RVA: 0x0053D577 File Offset: 0x0053B777
		public static Offset<IRenderFlag> CreateIRenderFlag(FlatBufferBuilder builder, ERenderFlagType Type, bool Enable)
		{
			builder.Prep(1, 2);
			builder.PutBool(Enable);
			builder.PutByte((byte)Type);
			return new Offset<IRenderFlag>(builder.Offset);
		}

		// Token: 0x06026028 RID: 155688 RVA: 0x0053D59C File Offset: 0x0053B79C
		public IRenderFlagT UnPack()
		{
			IRenderFlagT renderFlagT = new IRenderFlagT();
			this.UnPackTo(renderFlagT);
			return renderFlagT;
		}

		// Token: 0x06026029 RID: 155689 RVA: 0x0053D5B7 File Offset: 0x0053B7B7
		public void UnPackTo(IRenderFlagT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
		}

		// Token: 0x0602602A RID: 155690 RVA: 0x0053D5D4 File Offset: 0x0053B7D4
		public static Offset<IRenderFlag> Pack(FlatBufferBuilder builder, IRenderFlagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderFlag>);
			}
			return IRenderFlag.CreateIRenderFlag(builder, _o.Type, _o.Enable);
		}

		// Token: 0x0400ED5D RID: 60765
		private Struct __p;
	}
}
