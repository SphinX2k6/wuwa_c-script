using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675D RID: 26461
	public struct IActorTurnToData : IFlatbufferObject
	{
		// Token: 0x1700C06E RID: 49262
		// (get) Token: 0x0602CD98 RID: 183704 RVA: 0x006223BF File Offset: 0x006205BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD99 RID: 183705 RVA: 0x006223CC File Offset: 0x006205CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD9A RID: 183706 RVA: 0x006223D4 File Offset: 0x006205D4
		public static IActorTurnToData GetRootAsIActorTurnToData(ByteBuffer _bb)
		{
			return IActorTurnToData.GetRootAsIActorTurnToData(_bb, default(IActorTurnToData));
		}

		// Token: 0x0602CD9B RID: 183707 RVA: 0x006223F0 File Offset: 0x006205F0
		public static IActorTurnToData GetRootAsIActorTurnToData(ByteBuffer _bb, IActorTurnToData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD9C RID: 183708 RVA: 0x0062240D File Offset: 0x0062060D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD9D RID: 183709 RVA: 0x0062241C File Offset: 0x0062061C
		public IActorTurnToData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C06F RID: 49263
		// (get) Token: 0x0602CD9E RID: 183710 RVA: 0x0062242C File Offset: 0x0062062C
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

		// Token: 0x0602CD9F RID: 183711 RVA: 0x00622468 File Offset: 0x00620668
		public static Offset<IActorTurnToData> CreateIActorTurnToData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToData.AddType(builder, Type);
			return IActorTurnToData.EndIActorTurnToData(builder);
		}

		// Token: 0x0602CDA0 RID: 183712 RVA: 0x0062247E File Offset: 0x0062067E
		public static void StartIActorTurnToData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CDA1 RID: 183713 RVA: 0x00622487 File Offset: 0x00620687
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDA2 RID: 183714 RVA: 0x00622492 File Offset: 0x00620692
		public static Offset<IActorTurnToData> EndIActorTurnToData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToData>(builder.EndTable());
		}

		// Token: 0x0602CDA3 RID: 183715 RVA: 0x006224A0 File Offset: 0x006206A0
		public IActorTurnToDataT UnPack()
		{
			IActorTurnToDataT actorTurnToDataT = new IActorTurnToDataT();
			this.UnPackTo(actorTurnToDataT);
			return actorTurnToDataT;
		}

		// Token: 0x0602CDA4 RID: 183716 RVA: 0x006224BB File Offset: 0x006206BB
		public void UnPackTo(IActorTurnToDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CDA5 RID: 183717 RVA: 0x006224CC File Offset: 0x006206CC
		public static Offset<IActorTurnToData> Pack(FlatBufferBuilder builder, IActorTurnToDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToData>);
			}
			return IActorTurnToData.CreateIActorTurnToData(builder, _o.Type);
		}

		// Token: 0x040112C5 RID: 70341
		private Table __p;
	}
}
