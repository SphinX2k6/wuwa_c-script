using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565C RID: 22108
	public struct INpcStandbyShowFinitelyInfo : IFlatbufferObject
	{
		// Token: 0x1700A3BD RID: 41917
		// (get) Token: 0x06024C17 RID: 150551 RVA: 0x00512445 File Offset: 0x00510645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C18 RID: 150552 RVA: 0x00512452 File Offset: 0x00510652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C19 RID: 150553 RVA: 0x0051245C File Offset: 0x0051065C
		public static INpcStandbyShowFinitelyInfo GetRootAsINpcStandbyShowFinitelyInfo(ByteBuffer _bb)
		{
			return INpcStandbyShowFinitelyInfo.GetRootAsINpcStandbyShowFinitelyInfo(_bb, default(INpcStandbyShowFinitelyInfo));
		}

		// Token: 0x06024C1A RID: 150554 RVA: 0x00512478 File Offset: 0x00510678
		public static INpcStandbyShowFinitelyInfo GetRootAsINpcStandbyShowFinitelyInfo(ByteBuffer _bb, INpcStandbyShowFinitelyInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C1B RID: 150555 RVA: 0x00512495 File Offset: 0x00510695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C1C RID: 150556 RVA: 0x005124A4 File Offset: 0x005106A4
		public INpcStandbyShowFinitelyInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3BE RID: 41918
		// (get) Token: 0x06024C1D RID: 150557 RVA: 0x005124B4 File Offset: 0x005106B4
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024C1E RID: 150558 RVA: 0x005124EB File Offset: 0x005106EB
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024C1F RID: 150559 RVA: 0x005124FA File Offset: 0x005106FA
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A3BF RID: 41919
		// (get) Token: 0x06024C20 RID: 150560 RVA: 0x00512508 File Offset: 0x00510708
		public IMontageId? RegisteredMontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A3C0 RID: 41920
		// (get) Token: 0x06024C21 RID: 150561 RVA: 0x00512568 File Offset: 0x00510768
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3C1 RID: 41921
		// (get) Token: 0x06024C22 RID: 150562 RVA: 0x005125A4 File Offset: 0x005107A4
		public int Time
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A3C2 RID: 41922
		// (get) Token: 0x06024C23 RID: 150563 RVA: 0x005125E4 File Offset: 0x005107E4
		public IIgnoreEntityIdsCollision? IgnoreEntityCollision
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IIgnoreEntityIdsCollision?(default(IIgnoreEntityIdsCollision).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A3C3 RID: 41923
		// (get) Token: 0x06024C24 RID: 150564 RVA: 0x00512644 File Offset: 0x00510844
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024C25 RID: 150565 RVA: 0x00512681 File Offset: 0x00510881
		public static Offset<INpcStandbyShowFinitelyInfo> CreateINpcStandbyShowFinitelyInfo(FlatBufferBuilder builder, StringOffset MontageOffset = default(StringOffset), Offset<IMontageId> RegisteredMontageIdOffset = default(Offset<IMontageId>), int FaceExpressionId = 0, int Time = 0, Offset<IIgnoreEntityIdsCollision> IgnoreEntityCollisionOffset = default(Offset<IIgnoreEntityIdsCollision>), byte NullMask = 0)
		{
			builder.StartTable(6);
			INpcStandbyShowFinitelyInfo.AddIgnoreEntityCollision(builder, IgnoreEntityCollisionOffset);
			INpcStandbyShowFinitelyInfo.AddTime(builder, Time);
			INpcStandbyShowFinitelyInfo.AddFaceExpressionId(builder, FaceExpressionId);
			INpcStandbyShowFinitelyInfo.AddRegisteredMontageId(builder, RegisteredMontageIdOffset);
			INpcStandbyShowFinitelyInfo.AddMontage(builder, MontageOffset);
			INpcStandbyShowFinitelyInfo.AddNullMask(builder, NullMask);
			return INpcStandbyShowFinitelyInfo.EndINpcStandbyShowFinitelyInfo(builder);
		}

		// Token: 0x06024C26 RID: 150566 RVA: 0x005126BD File Offset: 0x005108BD
		public static void StartINpcStandbyShowFinitelyInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024C27 RID: 150567 RVA: 0x005126C6 File Offset: 0x005108C6
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x06024C28 RID: 150568 RVA: 0x005126D6 File Offset: 0x005108D6
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(1, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06024C29 RID: 150569 RVA: 0x005126E6 File Offset: 0x005108E6
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(2, faceExpressionId, 0);
		}

		// Token: 0x06024C2A RID: 150570 RVA: 0x005126F1 File Offset: 0x005108F1
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(3, time, 0);
		}

		// Token: 0x06024C2B RID: 150571 RVA: 0x005126FC File Offset: 0x005108FC
		public static void AddIgnoreEntityCollision(FlatBufferBuilder builder, Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset)
		{
			builder.AddOffset(4, ignoreEntityCollisionOffset.Value, 0);
		}

		// Token: 0x06024C2C RID: 150572 RVA: 0x0051270C File Offset: 0x0051090C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024C2D RID: 150573 RVA: 0x00512717 File Offset: 0x00510917
		public static Offset<INpcStandbyShowFinitelyInfo> EndINpcStandbyShowFinitelyInfo(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowFinitelyInfo>(builder.EndTable());
		}

		// Token: 0x06024C2E RID: 150574 RVA: 0x00512724 File Offset: 0x00510924
		public INpcStandbyShowFinitelyInfoT UnPack()
		{
			INpcStandbyShowFinitelyInfoT npcStandbyShowFinitelyInfoT = new INpcStandbyShowFinitelyInfoT();
			this.UnPackTo(npcStandbyShowFinitelyInfoT);
			return npcStandbyShowFinitelyInfoT;
		}

		// Token: 0x06024C2F RID: 150575 RVA: 0x00512740 File Offset: 0x00510940
		public void UnPackTo(INpcStandbyShowFinitelyInfoT _o)
		{
			_o.Montage = this.Montage;
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.Time = this.Time;
			_o.IgnoreEntityCollision = ((this.IgnoreEntityCollision != null) ? this.IgnoreEntityCollision.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024C30 RID: 150576 RVA: 0x005127DC File Offset: 0x005109DC
		public static Offset<INpcStandbyShowFinitelyInfo> Pack(FlatBufferBuilder builder, INpcStandbyShowFinitelyInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcStandbyShowFinitelyInfo>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			Offset<IMontageId> registeredMontageIdOffset = (_o.RegisteredMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.RegisteredMontageId);
			Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset = (_o.IgnoreEntityCollision == null) ? default(Offset<IIgnoreEntityIdsCollision>) : IIgnoreEntityIdsCollision.Pack(builder, _o.IgnoreEntityCollision);
			return INpcStandbyShowFinitelyInfo.CreateINpcStandbyShowFinitelyInfo(builder, montageOffset, registeredMontageIdOffset, _o.FaceExpressionId, _o.Time, ignoreEntityCollisionOffset, _o.NullMask);
		}

		// Token: 0x0400EA0D RID: 59917
		private Table __p;
	}
}
