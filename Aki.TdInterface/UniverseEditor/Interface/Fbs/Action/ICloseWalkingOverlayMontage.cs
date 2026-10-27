using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006448 RID: 25672
	public struct ICloseWalkingOverlayMontage : IFlatbufferObject
	{
		// Token: 0x1700BF1F RID: 48927
		// (get) Token: 0x0602C6E2 RID: 181986 RVA: 0x0061852E File Offset: 0x0061672E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C6E3 RID: 181987 RVA: 0x0061853B File Offset: 0x0061673B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C6E4 RID: 181988 RVA: 0x00618544 File Offset: 0x00616744
		public static ICloseWalkingOverlayMontage GetRootAsICloseWalkingOverlayMontage(ByteBuffer _bb)
		{
			return ICloseWalkingOverlayMontage.GetRootAsICloseWalkingOverlayMontage(_bb, default(ICloseWalkingOverlayMontage));
		}

		// Token: 0x0602C6E5 RID: 181989 RVA: 0x00618560 File Offset: 0x00616760
		public static ICloseWalkingOverlayMontage GetRootAsICloseWalkingOverlayMontage(ByteBuffer _bb, ICloseWalkingOverlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C6E6 RID: 181990 RVA: 0x0061857D File Offset: 0x0061677D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C6E7 RID: 181991 RVA: 0x0061858C File Offset: 0x0061678C
		public ICloseWalkingOverlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF20 RID: 48928
		// (get) Token: 0x0602C6E8 RID: 181992 RVA: 0x0061859C File Offset: 0x0061679C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C6E9 RID: 181993 RVA: 0x006185D8 File Offset: 0x006167D8
		public static Offset<ICloseWalkingOverlayMontage> CreateICloseWalkingOverlayMontage(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			ICloseWalkingOverlayMontage.AddEntityId(builder, EntityId);
			return ICloseWalkingOverlayMontage.EndICloseWalkingOverlayMontage(builder);
		}

		// Token: 0x0602C6EA RID: 181994 RVA: 0x006185EE File Offset: 0x006167EE
		public static void StartICloseWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C6EB RID: 181995 RVA: 0x006185F7 File Offset: 0x006167F7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602C6EC RID: 181996 RVA: 0x00618602 File Offset: 0x00616802
		public static Offset<ICloseWalkingOverlayMontage> EndICloseWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<ICloseWalkingOverlayMontage>(builder.EndTable());
		}

		// Token: 0x0602C6ED RID: 181997 RVA: 0x00618610 File Offset: 0x00616810
		public ICloseWalkingOverlayMontageT UnPack()
		{
			ICloseWalkingOverlayMontageT closeWalkingOverlayMontageT = new ICloseWalkingOverlayMontageT();
			this.UnPackTo(closeWalkingOverlayMontageT);
			return closeWalkingOverlayMontageT;
		}

		// Token: 0x0602C6EE RID: 181998 RVA: 0x0061862B File Offset: 0x0061682B
		public void UnPackTo(ICloseWalkingOverlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602C6EF RID: 181999 RVA: 0x0061863C File Offset: 0x0061683C
		public static Offset<ICloseWalkingOverlayMontage> Pack(FlatBufferBuilder builder, ICloseWalkingOverlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseWalkingOverlayMontage>);
			}
			return ICloseWalkingOverlayMontage.CreateICloseWalkingOverlayMontage(builder, _o.EntityId);
		}

		// Token: 0x04010A47 RID: 68167
		private Table __p;
	}
}
