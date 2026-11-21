using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFD RID: 23549
	public struct INpcStandbyShowFinitelyInfo : IFlatbufferObject
	{
		// Token: 0x1700AC4C RID: 44108
		// (get) Token: 0x06026E50 RID: 159312 RVA: 0x00552FE1 File Offset: 0x005511E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E51 RID: 159313 RVA: 0x00552FEE File Offset: 0x005511EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E52 RID: 159314 RVA: 0x00552FF8 File Offset: 0x005511F8
		public static INpcStandbyShowFinitelyInfo GetRootAsINpcStandbyShowFinitelyInfo(ByteBuffer _bb)
		{
			return INpcStandbyShowFinitelyInfo.GetRootAsINpcStandbyShowFinitelyInfo(_bb, default(INpcStandbyShowFinitelyInfo));
		}

		// Token: 0x06026E53 RID: 159315 RVA: 0x00553014 File Offset: 0x00551214
		public static INpcStandbyShowFinitelyInfo GetRootAsINpcStandbyShowFinitelyInfo(ByteBuffer _bb, INpcStandbyShowFinitelyInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E54 RID: 159316 RVA: 0x00553031 File Offset: 0x00551231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E55 RID: 159317 RVA: 0x00553040 File Offset: 0x00551240
		public INpcStandbyShowFinitelyInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC4D RID: 44109
		// (get) Token: 0x06026E56 RID: 159318 RVA: 0x00553050 File Offset: 0x00551250
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

		// Token: 0x06026E57 RID: 159319 RVA: 0x00553087 File Offset: 0x00551287
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026E58 RID: 159320 RVA: 0x00553096 File Offset: 0x00551296
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC4E RID: 44110
		// (get) Token: 0x06026E59 RID: 159321 RVA: 0x005530A4 File Offset: 0x005512A4
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

		// Token: 0x1700AC4F RID: 44111
		// (get) Token: 0x06026E5A RID: 159322 RVA: 0x00553104 File Offset: 0x00551304
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

		// Token: 0x1700AC50 RID: 44112
		// (get) Token: 0x06026E5B RID: 159323 RVA: 0x00553140 File Offset: 0x00551340
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

		// Token: 0x1700AC51 RID: 44113
		// (get) Token: 0x06026E5C RID: 159324 RVA: 0x00553180 File Offset: 0x00551380
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

		// Token: 0x1700AC52 RID: 44114
		// (get) Token: 0x06026E5D RID: 159325 RVA: 0x005531E0 File Offset: 0x005513E0
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

		// Token: 0x06026E5E RID: 159326 RVA: 0x0055321D File Offset: 0x0055141D
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

		// Token: 0x06026E5F RID: 159327 RVA: 0x00553259 File Offset: 0x00551459
		public static void StartINpcStandbyShowFinitelyInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026E60 RID: 159328 RVA: 0x00553262 File Offset: 0x00551462
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(0, montageOffset.Value, 0);
		}

		// Token: 0x06026E61 RID: 159329 RVA: 0x00553272 File Offset: 0x00551472
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(1, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06026E62 RID: 159330 RVA: 0x00553282 File Offset: 0x00551482
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(2, faceExpressionId, 0);
		}

		// Token: 0x06026E63 RID: 159331 RVA: 0x0055328D File Offset: 0x0055148D
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(3, time, 0);
		}

		// Token: 0x06026E64 RID: 159332 RVA: 0x00553298 File Offset: 0x00551498
		public static void AddIgnoreEntityCollision(FlatBufferBuilder builder, Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset)
		{
			builder.AddOffset(4, ignoreEntityCollisionOffset.Value, 0);
		}

		// Token: 0x06026E65 RID: 159333 RVA: 0x005532A8 File Offset: 0x005514A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026E66 RID: 159334 RVA: 0x005532B3 File Offset: 0x005514B3
		public static Offset<INpcStandbyShowFinitelyInfo> EndINpcStandbyShowFinitelyInfo(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowFinitelyInfo>(builder.EndTable());
		}

		// Token: 0x06026E67 RID: 159335 RVA: 0x005532C0 File Offset: 0x005514C0
		public INpcStandbyShowFinitelyInfoT UnPack()
		{
			INpcStandbyShowFinitelyInfoT npcStandbyShowFinitelyInfoT = new INpcStandbyShowFinitelyInfoT();
			this.UnPackTo(npcStandbyShowFinitelyInfoT);
			return npcStandbyShowFinitelyInfoT;
		}

		// Token: 0x06026E68 RID: 159336 RVA: 0x005532DC File Offset: 0x005514DC
		public void UnPackTo(INpcStandbyShowFinitelyInfoT _o)
		{
			_o.Montage = this.Montage;
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.Time = this.Time;
			_o.IgnoreEntityCollision = ((this.IgnoreEntityCollision != null) ? this.IgnoreEntityCollision.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026E69 RID: 159337 RVA: 0x00553378 File Offset: 0x00551578
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

		// Token: 0x0400F676 RID: 63094
		private Table __p;
	}
}
