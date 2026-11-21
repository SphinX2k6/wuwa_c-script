using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB6 RID: 27318
	public struct ICloseWalkingOverlayMontage : IFlatbufferObject
	{
		// Token: 0x1700C8A6 RID: 51366
		// (get) Token: 0x0602EE45 RID: 192069 RVA: 0x0066386E File Offset: 0x00661A6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE46 RID: 192070 RVA: 0x0066387B File Offset: 0x00661A7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE47 RID: 192071 RVA: 0x00663884 File Offset: 0x00661A84
		public static ICloseWalkingOverlayMontage GetRootAsICloseWalkingOverlayMontage(ByteBuffer _bb)
		{
			return ICloseWalkingOverlayMontage.GetRootAsICloseWalkingOverlayMontage(_bb, default(ICloseWalkingOverlayMontage));
		}

		// Token: 0x0602EE48 RID: 192072 RVA: 0x006638A0 File Offset: 0x00661AA0
		public static ICloseWalkingOverlayMontage GetRootAsICloseWalkingOverlayMontage(ByteBuffer _bb, ICloseWalkingOverlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE49 RID: 192073 RVA: 0x006638BD File Offset: 0x00661ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE4A RID: 192074 RVA: 0x006638CC File Offset: 0x00661ACC
		public ICloseWalkingOverlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8A7 RID: 51367
		// (get) Token: 0x0602EE4B RID: 192075 RVA: 0x006638DC File Offset: 0x00661ADC
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

		// Token: 0x0602EE4C RID: 192076 RVA: 0x00663918 File Offset: 0x00661B18
		public static Offset<ICloseWalkingOverlayMontage> CreateICloseWalkingOverlayMontage(FlatBufferBuilder builder, int EntityId = 0)
		{
			builder.StartTable(1);
			ICloseWalkingOverlayMontage.AddEntityId(builder, EntityId);
			return ICloseWalkingOverlayMontage.EndICloseWalkingOverlayMontage(builder);
		}

		// Token: 0x0602EE4D RID: 192077 RVA: 0x0066392E File Offset: 0x00661B2E
		public static void StartICloseWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EE4E RID: 192078 RVA: 0x00663937 File Offset: 0x00661B37
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602EE4F RID: 192079 RVA: 0x00663942 File Offset: 0x00661B42
		public static Offset<ICloseWalkingOverlayMontage> EndICloseWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<ICloseWalkingOverlayMontage>(builder.EndTable());
		}

		// Token: 0x0602EE50 RID: 192080 RVA: 0x00663950 File Offset: 0x00661B50
		public ICloseWalkingOverlayMontageT UnPack()
		{
			ICloseWalkingOverlayMontageT closeWalkingOverlayMontageT = new ICloseWalkingOverlayMontageT();
			this.UnPackTo(closeWalkingOverlayMontageT);
			return closeWalkingOverlayMontageT;
		}

		// Token: 0x0602EE51 RID: 192081 RVA: 0x0066396B File Offset: 0x00661B6B
		public void UnPackTo(ICloseWalkingOverlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602EE52 RID: 192082 RVA: 0x0066397C File Offset: 0x00661B7C
		public static Offset<ICloseWalkingOverlayMontage> Pack(FlatBufferBuilder builder, ICloseWalkingOverlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseWalkingOverlayMontage>);
			}
			return ICloseWalkingOverlayMontage.CreateICloseWalkingOverlayMontage(builder, _o.EntityId);
		}

		// Token: 0x0401185A RID: 71770
		private Table __p;
	}
}
