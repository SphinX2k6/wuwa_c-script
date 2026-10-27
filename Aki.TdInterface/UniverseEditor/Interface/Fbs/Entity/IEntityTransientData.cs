using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047DB RID: 18395
	public struct IEntityTransientData : IFlatbufferObject
	{
		// Token: 0x1700843A RID: 33850
		// (get) Token: 0x0601C70B RID: 116491 RVA: 0x00406353 File Offset: 0x00404553
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x00406360 File Offset: 0x00404560
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C70D RID: 116493 RVA: 0x00406368 File Offset: 0x00404568
		public static IEntityTransientData GetRootAsIEntityTransientData(ByteBuffer _bb)
		{
			return IEntityTransientData.GetRootAsIEntityTransientData(_bb, default(IEntityTransientData));
		}

		// Token: 0x0601C70E RID: 116494 RVA: 0x00406384 File Offset: 0x00404584
		public static IEntityTransientData GetRootAsIEntityTransientData(ByteBuffer _bb, IEntityTransientData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C70F RID: 116495 RVA: 0x004063A1 File Offset: 0x004045A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C710 RID: 116496 RVA: 0x004063B0 File Offset: 0x004045B0
		public IEntityTransientData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C711 RID: 116497 RVA: 0x004063C0 File Offset: 0x004045C0
		public static void StartIEntityTransientData(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0601C712 RID: 116498 RVA: 0x004063C9 File Offset: 0x004045C9
		public static Offset<IEntityTransientData> EndIEntityTransientData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTransientData>(builder.EndTable());
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x004063D8 File Offset: 0x004045D8
		public IEntityTransientDataT UnPack()
		{
			IEntityTransientDataT entityTransientDataT = new IEntityTransientDataT();
			this.UnPackTo(entityTransientDataT);
			return entityTransientDataT;
		}

		// Token: 0x0601C714 RID: 116500 RVA: 0x004063F3 File Offset: 0x004045F3
		public void UnPackTo(IEntityTransientDataT _o)
		{
		}

		// Token: 0x0601C715 RID: 116501 RVA: 0x004063F8 File Offset: 0x004045F8
		public static Offset<IEntityTransientData> Pack(FlatBufferBuilder builder, IEntityTransientDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTransientData>);
			}
			IEntityTransientData.StartIEntityTransientData(builder);
			return IEntityTransientData.EndIEntityTransientData(builder);
		}

		// Token: 0x0400CC74 RID: 52340
		private Table __p;
	}
}
