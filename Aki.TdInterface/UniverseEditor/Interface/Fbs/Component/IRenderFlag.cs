using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E4B RID: 24139
	public struct IRenderFlag : IFlatbufferObject
	{
		// Token: 0x1700B1F4 RID: 45556
		// (get) Token: 0x06028569 RID: 165225 RVA: 0x00583D70 File Offset: 0x00581F70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602856A RID: 165226 RVA: 0x00583D7D File Offset: 0x00581F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602856B RID: 165227 RVA: 0x00583D8C File Offset: 0x00581F8C
		public IRenderFlag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1F5 RID: 45557
		// (get) Token: 0x0602856C RID: 165228 RVA: 0x00583D9C File Offset: 0x00581F9C
		public ERenderFlagType Type
		{
			get
			{
				return (ERenderFlagType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700B1F6 RID: 45558
		// (get) Token: 0x0602856D RID: 165229 RVA: 0x00583DB9 File Offset: 0x00581FB9
		public bool Enable
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos + 1) > 0;
			}
		}

		// Token: 0x0602856E RID: 165230 RVA: 0x00583DDB File Offset: 0x00581FDB
		public static Offset<IRenderFlag> CreateIRenderFlag(FlatBufferBuilder builder, ERenderFlagType Type, bool Enable)
		{
			builder.Prep(1, 2);
			builder.PutBool(Enable);
			builder.PutByte((byte)Type);
			return new Offset<IRenderFlag>(builder.Offset);
		}

		// Token: 0x0602856F RID: 165231 RVA: 0x00583E00 File Offset: 0x00582000
		public IRenderFlagT UnPack()
		{
			IRenderFlagT renderFlagT = new IRenderFlagT();
			this.UnPackTo(renderFlagT);
			return renderFlagT;
		}

		// Token: 0x06028570 RID: 165232 RVA: 0x00583E1B File Offset: 0x0058201B
		public void UnPackTo(IRenderFlagT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
		}

		// Token: 0x06028571 RID: 165233 RVA: 0x00583E38 File Offset: 0x00582038
		public static Offset<IRenderFlag> Pack(FlatBufferBuilder builder, IRenderFlagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderFlag>);
			}
			return IRenderFlag.CreateIRenderFlag(builder, _o.Type, _o.Enable);
		}

		// Token: 0x0400FA4C RID: 64076
		private Struct __p;
	}
}
