using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AD RID: 26541
	public struct IFinishTalk : IFlatbufferObject
	{
		// Token: 0x1700C4FB RID: 50427
		// (get) Token: 0x0602E2F1 RID: 189169 RVA: 0x0064EA66 File Offset: 0x0064CC66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2F2 RID: 189170 RVA: 0x0064EA73 File Offset: 0x0064CC73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2F3 RID: 189171 RVA: 0x0064EA7C File Offset: 0x0064CC7C
		public static IFinishTalk GetRootAsIFinishTalk(ByteBuffer _bb)
		{
			return IFinishTalk.GetRootAsIFinishTalk(_bb, default(IFinishTalk));
		}

		// Token: 0x0602E2F4 RID: 189172 RVA: 0x0064EA98 File Offset: 0x0064CC98
		public static IFinishTalk GetRootAsIFinishTalk(ByteBuffer _bb, IFinishTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2F5 RID: 189173 RVA: 0x0064EAB5 File Offset: 0x0064CCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2F6 RID: 189174 RVA: 0x0064EAC4 File Offset: 0x0064CCC4
		public IFinishTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E2F7 RID: 189175 RVA: 0x0064EAD4 File Offset: 0x0064CCD4
		public static void StartIFinishTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E2F8 RID: 189176 RVA: 0x0064EADD File Offset: 0x0064CCDD
		public static Offset<IFinishTalk> EndIFinishTalk(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTalk>(builder.EndTable());
		}

		// Token: 0x0602E2F9 RID: 189177 RVA: 0x0064EAEC File Offset: 0x0064CCEC
		public IFinishTalkT UnPack()
		{
			IFinishTalkT finishTalkT = new IFinishTalkT();
			this.UnPackTo(finishTalkT);
			return finishTalkT;
		}

		// Token: 0x0602E2FA RID: 189178 RVA: 0x0064EB07 File Offset: 0x0064CD07
		public void UnPackTo(IFinishTalkT _o)
		{
		}

		// Token: 0x0602E2FB RID: 189179 RVA: 0x0064EB0C File Offset: 0x0064CD0C
		public static Offset<IFinishTalk> Pack(FlatBufferBuilder builder, IFinishTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishTalk>);
			}
			IFinishTalk.StartIFinishTalk(builder);
			return IFinishTalk.EndIFinishTalk(builder);
		}

		// Token: 0x04010EB9 RID: 69305
		private Table __p;
	}
}
