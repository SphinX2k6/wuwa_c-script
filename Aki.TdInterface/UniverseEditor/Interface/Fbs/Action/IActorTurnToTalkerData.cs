using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676F RID: 26479
	public struct IActorTurnToTalkerData : IFlatbufferObject
	{
		// Token: 0x1700C083 RID: 49283
		// (get) Token: 0x0602CE0E RID: 183822 RVA: 0x00622EC4 File Offset: 0x006210C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE0F RID: 183823 RVA: 0x00622ED1 File Offset: 0x006210D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE10 RID: 183824 RVA: 0x00622ED8 File Offset: 0x006210D8
		public static IActorTurnToTalkerData GetRootAsIActorTurnToTalkerData(ByteBuffer _bb)
		{
			return IActorTurnToTalkerData.GetRootAsIActorTurnToTalkerData(_bb, default(IActorTurnToTalkerData));
		}

		// Token: 0x0602CE11 RID: 183825 RVA: 0x00622EF4 File Offset: 0x006210F4
		public static IActorTurnToTalkerData GetRootAsIActorTurnToTalkerData(ByteBuffer _bb, IActorTurnToTalkerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE12 RID: 183826 RVA: 0x00622F11 File Offset: 0x00621111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE13 RID: 183827 RVA: 0x00622F20 File Offset: 0x00621120
		public IActorTurnToTalkerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C084 RID: 49284
		// (get) Token: 0x0602CE14 RID: 183828 RVA: 0x00622F30 File Offset: 0x00621130
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

		// Token: 0x0602CE15 RID: 183829 RVA: 0x00622F6C File Offset: 0x0062116C
		public static Offset<IActorTurnToTalkerData> CreateIActorTurnToTalkerData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToTalkerData.AddType(builder, Type);
			return IActorTurnToTalkerData.EndIActorTurnToTalkerData(builder);
		}

		// Token: 0x0602CE16 RID: 183830 RVA: 0x00622F82 File Offset: 0x00621182
		public static void StartIActorTurnToTalkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CE17 RID: 183831 RVA: 0x00622F8B File Offset: 0x0062118B
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CE18 RID: 183832 RVA: 0x00622F96 File Offset: 0x00621196
		public static Offset<IActorTurnToTalkerData> EndIActorTurnToTalkerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToTalkerData>(builder.EndTable());
		}

		// Token: 0x0602CE19 RID: 183833 RVA: 0x00622FA4 File Offset: 0x006211A4
		public IActorTurnToTalkerDataT UnPack()
		{
			IActorTurnToTalkerDataT actorTurnToTalkerDataT = new IActorTurnToTalkerDataT();
			this.UnPackTo(actorTurnToTalkerDataT);
			return actorTurnToTalkerDataT;
		}

		// Token: 0x0602CE1A RID: 183834 RVA: 0x00622FBF File Offset: 0x006211BF
		public void UnPackTo(IActorTurnToTalkerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CE1B RID: 183835 RVA: 0x00622FD0 File Offset: 0x006211D0
		public static Offset<IActorTurnToTalkerData> Pack(FlatBufferBuilder builder, IActorTurnToTalkerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToTalkerData>);
			}
			return IActorTurnToTalkerData.CreateIActorTurnToTalkerData(builder, _o.Type);
		}

		// Token: 0x040112DB RID: 70363
		private Table __p;
	}
}
