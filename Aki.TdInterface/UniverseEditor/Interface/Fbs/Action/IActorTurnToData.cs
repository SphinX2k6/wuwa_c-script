using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FB RID: 24827
	public struct IActorTurnToData : IFlatbufferObject
	{
		// Token: 0x1700B703 RID: 46851
		// (get) Token: 0x0602A6B7 RID: 173751 RVA: 0x005D8417 File Offset: 0x005D6617
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6B8 RID: 173752 RVA: 0x005D8424 File Offset: 0x005D6624
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6B9 RID: 173753 RVA: 0x005D842C File Offset: 0x005D662C
		public static IActorTurnToData GetRootAsIActorTurnToData(ByteBuffer _bb)
		{
			return IActorTurnToData.GetRootAsIActorTurnToData(_bb, default(IActorTurnToData));
		}

		// Token: 0x0602A6BA RID: 173754 RVA: 0x005D8448 File Offset: 0x005D6648
		public static IActorTurnToData GetRootAsIActorTurnToData(ByteBuffer _bb, IActorTurnToData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6BB RID: 173755 RVA: 0x005D8465 File Offset: 0x005D6665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6BC RID: 173756 RVA: 0x005D8474 File Offset: 0x005D6674
		public IActorTurnToData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B704 RID: 46852
		// (get) Token: 0x0602A6BD RID: 173757 RVA: 0x005D8484 File Offset: 0x005D6684
		public EActorTurnToMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorTurnToMode.Talker;
				}
				return (EActorTurnToMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A6BE RID: 173758 RVA: 0x005D84C0 File Offset: 0x005D66C0
		public static Offset<IActorTurnToData> CreateIActorTurnToData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToData.AddType(builder, Type);
			return IActorTurnToData.EndIActorTurnToData(builder);
		}

		// Token: 0x0602A6BF RID: 173759 RVA: 0x005D84D6 File Offset: 0x005D66D6
		public static void StartIActorTurnToData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A6C0 RID: 173760 RVA: 0x005D84DF File Offset: 0x005D66DF
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A6C1 RID: 173761 RVA: 0x005D84EA File Offset: 0x005D66EA
		public static Offset<IActorTurnToData> EndIActorTurnToData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToData>(builder.EndTable());
		}

		// Token: 0x0602A6C2 RID: 173762 RVA: 0x005D84F8 File Offset: 0x005D66F8
		public IActorTurnToDataT UnPack()
		{
			IActorTurnToDataT actorTurnToDataT = new IActorTurnToDataT();
			this.UnPackTo(actorTurnToDataT);
			return actorTurnToDataT;
		}

		// Token: 0x0602A6C3 RID: 173763 RVA: 0x005D8513 File Offset: 0x005D6713
		public void UnPackTo(IActorTurnToDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A6C4 RID: 173764 RVA: 0x005D8524 File Offset: 0x005D6724
		public static Offset<IActorTurnToData> Pack(FlatBufferBuilder builder, IActorTurnToDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToData>);
			}
			return IActorTurnToData.CreateIActorTurnToData(builder, _o.Type);
		}

		// Token: 0x040104C1 RID: 66753
		private Table __p;
	}
}
