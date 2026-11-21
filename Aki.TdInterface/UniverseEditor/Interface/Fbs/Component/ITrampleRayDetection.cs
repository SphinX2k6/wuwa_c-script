using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D9 RID: 24793
	public struct ITrampleRayDetection : IFlatbufferObject
	{
		// Token: 0x1700B870 RID: 47216
		// (get) Token: 0x06029FCB RID: 171979 RVA: 0x005BB508 File Offset: 0x005B9708
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029FCC RID: 171980 RVA: 0x005BB515 File Offset: 0x005B9715
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029FCD RID: 171981 RVA: 0x005BB51C File Offset: 0x005B971C
		public static ITrampleRayDetection GetRootAsITrampleRayDetection(ByteBuffer _bb)
		{
			return ITrampleRayDetection.GetRootAsITrampleRayDetection(_bb, default(ITrampleRayDetection));
		}

		// Token: 0x06029FCE RID: 171982 RVA: 0x005BB538 File Offset: 0x005B9738
		public static ITrampleRayDetection GetRootAsITrampleRayDetection(ByteBuffer _bb, ITrampleRayDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029FCF RID: 171983 RVA: 0x005BB555 File Offset: 0x005B9755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029FD0 RID: 171984 RVA: 0x005BB564 File Offset: 0x005B9764
		public ITrampleRayDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029FD1 RID: 171985 RVA: 0x005BB574 File Offset: 0x005B9774
		public static void StartITrampleRayDetection(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06029FD2 RID: 171986 RVA: 0x005BB57D File Offset: 0x005B977D
		public static Offset<ITrampleRayDetection> EndITrampleRayDetection(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleRayDetection>(builder.EndTable());
		}

		// Token: 0x06029FD3 RID: 171987 RVA: 0x005BB58C File Offset: 0x005B978C
		public ITrampleRayDetectionT UnPack()
		{
			ITrampleRayDetectionT trampleRayDetectionT = new ITrampleRayDetectionT();
			this.UnPackTo(trampleRayDetectionT);
			return trampleRayDetectionT;
		}

		// Token: 0x06029FD4 RID: 171988 RVA: 0x005BB5A7 File Offset: 0x005B97A7
		public void UnPackTo(ITrampleRayDetectionT _o)
		{
		}

		// Token: 0x06029FD5 RID: 171989 RVA: 0x005BB5AC File Offset: 0x005B97AC
		public static Offset<ITrampleRayDetection> Pack(FlatBufferBuilder builder, ITrampleRayDetectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleRayDetection>);
			}
			ITrampleRayDetection.StartITrampleRayDetection(builder);
			return ITrampleRayDetection.EndITrampleRayDetection(builder);
		}

		// Token: 0x0400FEA3 RID: 65187
		private Table __p;
	}
}
