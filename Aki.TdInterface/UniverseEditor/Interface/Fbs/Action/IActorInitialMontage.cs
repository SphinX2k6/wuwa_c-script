using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672D RID: 26413
	public struct IActorInitialMontage : IFlatbufferObject
	{
		// Token: 0x1700BFFF RID: 49151
		// (get) Token: 0x0602CBD3 RID: 183251 RVA: 0x0061EB43 File Offset: 0x0061CD43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBD4 RID: 183252 RVA: 0x0061EB50 File Offset: 0x0061CD50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBD5 RID: 183253 RVA: 0x0061EB58 File Offset: 0x0061CD58
		public static IActorInitialMontage GetRootAsIActorInitialMontage(ByteBuffer _bb)
		{
			return IActorInitialMontage.GetRootAsIActorInitialMontage(_bb, default(IActorInitialMontage));
		}

		// Token: 0x0602CBD6 RID: 183254 RVA: 0x0061EB74 File Offset: 0x0061CD74
		public static IActorInitialMontage GetRootAsIActorInitialMontage(ByteBuffer _bb, IActorInitialMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBD7 RID: 183255 RVA: 0x0061EB91 File Offset: 0x0061CD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBD8 RID: 183256 RVA: 0x0061EBA0 File Offset: 0x0061CDA0
		public IActorInitialMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C000 RID: 49152
		// (get) Token: 0x0602CBD9 RID: 183257 RVA: 0x0061EBB0 File Offset: 0x0061CDB0
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602CBDA RID: 183258 RVA: 0x0061EC0D File Offset: 0x0061CE0D
		public static Offset<IActorInitialMontage> CreateIActorInitialMontage(FlatBufferBuilder builder, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>))
		{
			builder.StartTable(1);
			IActorInitialMontage.AddMontageId(builder, MontageIdOffset);
			return IActorInitialMontage.EndIActorInitialMontage(builder);
		}

		// Token: 0x0602CBDB RID: 183259 RVA: 0x0061EC23 File Offset: 0x0061CE23
		public static void StartIActorInitialMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CBDC RID: 183260 RVA: 0x0061EC2C File Offset: 0x0061CE2C
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(0, montageIdOffset.Value, 0);
		}

		// Token: 0x0602CBDD RID: 183261 RVA: 0x0061EC3C File Offset: 0x0061CE3C
		public static Offset<IActorInitialMontage> EndIActorInitialMontage(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialMontage>(builder.EndTable());
		}

		// Token: 0x0602CBDE RID: 183262 RVA: 0x0061EC4C File Offset: 0x0061CE4C
		public IActorInitialMontageT UnPack()
		{
			IActorInitialMontageT actorInitialMontageT = new IActorInitialMontageT();
			this.UnPackTo(actorInitialMontageT);
			return actorInitialMontageT;
		}

		// Token: 0x0602CBDF RID: 183263 RVA: 0x0061EC68 File Offset: 0x0061CE68
		public void UnPackTo(IActorInitialMontageT _o)
		{
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
		}

		// Token: 0x0602CBE0 RID: 183264 RVA: 0x0061ECA4 File Offset: 0x0061CEA4
		public static Offset<IActorInitialMontage> Pack(FlatBufferBuilder builder, IActorInitialMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorInitialMontage>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IActorInitialMontage.CreateIActorInitialMontage(builder, montageIdOffset);
		}

		// Token: 0x0401127A RID: 70266
		private Table __p;
	}
}
