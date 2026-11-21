using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006763 RID: 26467
	public struct IActorTurnToEmptyData : IFlatbufferObject
	{
		// Token: 0x1700C073 RID: 49267
		// (get) Token: 0x0602CDBE RID: 183742 RVA: 0x00622746 File Offset: 0x00620946
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDBF RID: 183743 RVA: 0x00622753 File Offset: 0x00620953
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDC0 RID: 183744 RVA: 0x0062275C File Offset: 0x0062095C
		public static IActorTurnToEmptyData GetRootAsIActorTurnToEmptyData(ByteBuffer _bb)
		{
			return IActorTurnToEmptyData.GetRootAsIActorTurnToEmptyData(_bb, default(IActorTurnToEmptyData));
		}

		// Token: 0x0602CDC1 RID: 183745 RVA: 0x00622778 File Offset: 0x00620978
		public static IActorTurnToEmptyData GetRootAsIActorTurnToEmptyData(ByteBuffer _bb, IActorTurnToEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDC2 RID: 183746 RVA: 0x00622795 File Offset: 0x00620995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDC3 RID: 183747 RVA: 0x006227A4 File Offset: 0x006209A4
		public IActorTurnToEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C074 RID: 49268
		// (get) Token: 0x0602CDC4 RID: 183748 RVA: 0x006227B4 File Offset: 0x006209B4
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

		// Token: 0x0602CDC5 RID: 183749 RVA: 0x006227F0 File Offset: 0x006209F0
		public static Offset<IActorTurnToEmptyData> CreateIActorTurnToEmptyData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToEmptyData.AddType(builder, Type);
			return IActorTurnToEmptyData.EndIActorTurnToEmptyData(builder);
		}

		// Token: 0x0602CDC6 RID: 183750 RVA: 0x00622806 File Offset: 0x00620A06
		public static void StartIActorTurnToEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CDC7 RID: 183751 RVA: 0x0062280F File Offset: 0x00620A0F
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDC8 RID: 183752 RVA: 0x0062281A File Offset: 0x00620A1A
		public static Offset<IActorTurnToEmptyData> EndIActorTurnToEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToEmptyData>(builder.EndTable());
		}

		// Token: 0x0602CDC9 RID: 183753 RVA: 0x00622828 File Offset: 0x00620A28
		public IActorTurnToEmptyDataT UnPack()
		{
			IActorTurnToEmptyDataT actorTurnToEmptyDataT = new IActorTurnToEmptyDataT();
			this.UnPackTo(actorTurnToEmptyDataT);
			return actorTurnToEmptyDataT;
		}

		// Token: 0x0602CDCA RID: 183754 RVA: 0x00622843 File Offset: 0x00620A43
		public void UnPackTo(IActorTurnToEmptyDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CDCB RID: 183755 RVA: 0x00622854 File Offset: 0x00620A54
		public static Offset<IActorTurnToEmptyData> Pack(FlatBufferBuilder builder, IActorTurnToEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToEmptyData>);
			}
			return IActorTurnToEmptyData.CreateIActorTurnToEmptyData(builder, _o.Type);
		}

		// Token: 0x040112D1 RID: 70353
		private Table __p;
	}
}
