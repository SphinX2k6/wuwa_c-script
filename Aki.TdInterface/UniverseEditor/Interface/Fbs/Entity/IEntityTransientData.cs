using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C43 RID: 19523
	public struct IEntityTransientData : IFlatbufferObject
	{
		// Token: 0x17008A85 RID: 35461
		// (get) Token: 0x0601DF08 RID: 122632 RVA: 0x00432CA3 File Offset: 0x00430EA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DF09 RID: 122633 RVA: 0x00432CB0 File Offset: 0x00430EB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DF0A RID: 122634 RVA: 0x00432CB8 File Offset: 0x00430EB8
		public static IEntityTransientData GetRootAsIEntityTransientData(ByteBuffer _bb)
		{
			return IEntityTransientData.GetRootAsIEntityTransientData(_bb, default(IEntityTransientData));
		}

		// Token: 0x0601DF0B RID: 122635 RVA: 0x00432CD4 File Offset: 0x00430ED4
		public static IEntityTransientData GetRootAsIEntityTransientData(ByteBuffer _bb, IEntityTransientData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DF0C RID: 122636 RVA: 0x00432CF1 File Offset: 0x00430EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DF0D RID: 122637 RVA: 0x00432D00 File Offset: 0x00430F00
		public IEntityTransientData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DF0E RID: 122638 RVA: 0x00432D10 File Offset: 0x00430F10
		public static void StartIEntityTransientData(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0601DF0F RID: 122639 RVA: 0x00432D19 File Offset: 0x00430F19
		public static Offset<IEntityTransientData> EndIEntityTransientData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTransientData>(builder.EndTable());
		}

		// Token: 0x0601DF10 RID: 122640 RVA: 0x00432D28 File Offset: 0x00430F28
		public IEntityTransientDataT UnPack()
		{
			IEntityTransientDataT entityTransientDataT = new IEntityTransientDataT();
			this.UnPackTo(entityTransientDataT);
			return entityTransientDataT;
		}

		// Token: 0x0601DF11 RID: 122641 RVA: 0x00432D43 File Offset: 0x00430F43
		public void UnPackTo(IEntityTransientDataT _o)
		{
		}

		// Token: 0x0601DF12 RID: 122642 RVA: 0x00432D48 File Offset: 0x00430F48
		public static Offset<IEntityTransientData> Pack(FlatBufferBuilder builder, IEntityTransientDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTransientData>);
			}
			IEntityTransientData.StartIEntityTransientData(builder);
			return IEntityTransientData.EndIEntityTransientData(builder);
		}

		// Token: 0x0400D6AF RID: 54959
		private Table __p;
	}
}
