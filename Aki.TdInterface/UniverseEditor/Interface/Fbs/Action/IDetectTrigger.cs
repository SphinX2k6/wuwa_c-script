using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C29 RID: 27689
	public struct IDetectTrigger : IFlatbufferObject
	{
		// Token: 0x1700CAEB RID: 51947
		// (get) Token: 0x0602FA63 RID: 195171 RVA: 0x0067DD5A File Offset: 0x0067BF5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA64 RID: 195172 RVA: 0x0067DD67 File Offset: 0x0067BF67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA65 RID: 195173 RVA: 0x0067DD70 File Offset: 0x0067BF70
		public static IDetectTrigger GetRootAsIDetectTrigger(ByteBuffer _bb)
		{
			return IDetectTrigger.GetRootAsIDetectTrigger(_bb, default(IDetectTrigger));
		}

		// Token: 0x0602FA66 RID: 195174 RVA: 0x0067DD8C File Offset: 0x0067BF8C
		public static IDetectTrigger GetRootAsIDetectTrigger(ByteBuffer _bb, IDetectTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA67 RID: 195175 RVA: 0x0067DDA9 File Offset: 0x0067BFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA68 RID: 195176 RVA: 0x0067DDB8 File Offset: 0x0067BFB8
		public IDetectTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602FA69 RID: 195177 RVA: 0x0067DDC8 File Offset: 0x0067BFC8
		public static void StartIDetectTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602FA6A RID: 195178 RVA: 0x0067DDD1 File Offset: 0x0067BFD1
		public static Offset<IDetectTrigger> EndIDetectTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IDetectTrigger>(builder.EndTable());
		}

		// Token: 0x0602FA6B RID: 195179 RVA: 0x0067DDE0 File Offset: 0x0067BFE0
		public IDetectTriggerT UnPack()
		{
			IDetectTriggerT detectTriggerT = new IDetectTriggerT();
			this.UnPackTo(detectTriggerT);
			return detectTriggerT;
		}

		// Token: 0x0602FA6C RID: 195180 RVA: 0x0067DDFB File Offset: 0x0067BFFB
		public void UnPackTo(IDetectTriggerT _o)
		{
		}

		// Token: 0x0602FA6D RID: 195181 RVA: 0x0067DE00 File Offset: 0x0067C000
		public static Offset<IDetectTrigger> Pack(FlatBufferBuilder builder, IDetectTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectTrigger>);
			}
			IDetectTrigger.StartIDetectTrigger(builder);
			return IDetectTrigger.EndIDetectTrigger(builder);
		}

		// Token: 0x04011A33 RID: 72243
		private Table __p;
	}
}
