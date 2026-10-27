using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C1 RID: 26049
	public struct IDetectTrigger : IFlatbufferObject
	{
		// Token: 0x1700C15C RID: 49500
		// (get) Token: 0x0602D2DF RID: 185055 RVA: 0x00631B96 File Offset: 0x0062FD96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D2E0 RID: 185056 RVA: 0x00631BA3 File Offset: 0x0062FDA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D2E1 RID: 185057 RVA: 0x00631BAC File Offset: 0x0062FDAC
		public static IDetectTrigger GetRootAsIDetectTrigger(ByteBuffer _bb)
		{
			return IDetectTrigger.GetRootAsIDetectTrigger(_bb, default(IDetectTrigger));
		}

		// Token: 0x0602D2E2 RID: 185058 RVA: 0x00631BC8 File Offset: 0x0062FDC8
		public static IDetectTrigger GetRootAsIDetectTrigger(ByteBuffer _bb, IDetectTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D2E3 RID: 185059 RVA: 0x00631BE5 File Offset: 0x0062FDE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D2E4 RID: 185060 RVA: 0x00631BF4 File Offset: 0x0062FDF4
		public IDetectTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D2E5 RID: 185061 RVA: 0x00631C04 File Offset: 0x0062FE04
		public static void StartIDetectTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602D2E6 RID: 185062 RVA: 0x00631C0D File Offset: 0x0062FE0D
		public static Offset<IDetectTrigger> EndIDetectTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IDetectTrigger>(builder.EndTable());
		}

		// Token: 0x0602D2E7 RID: 185063 RVA: 0x00631C1C File Offset: 0x0062FE1C
		public IDetectTriggerT UnPack()
		{
			IDetectTriggerT detectTriggerT = new IDetectTriggerT();
			this.UnPackTo(detectTriggerT);
			return detectTriggerT;
		}

		// Token: 0x0602D2E8 RID: 185064 RVA: 0x00631C37 File Offset: 0x0062FE37
		public void UnPackTo(IDetectTriggerT _o)
		{
		}

		// Token: 0x0602D2E9 RID: 185065 RVA: 0x00631C3C File Offset: 0x0062FE3C
		public static Offset<IDetectTrigger> Pack(FlatBufferBuilder builder, IDetectTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectTrigger>);
			}
			IDetectTrigger.StartIDetectTrigger(builder);
			return IDetectTrigger.EndIDetectTrigger(builder);
		}

		// Token: 0x04010C21 RID: 68641
		private Table __p;
	}
}
