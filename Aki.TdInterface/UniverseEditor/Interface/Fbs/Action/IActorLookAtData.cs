using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006736 RID: 26422
	public struct IActorLookAtData : IFlatbufferObject
	{
		// Token: 0x1700C018 RID: 49176
		// (get) Token: 0x0602CC3D RID: 183357 RVA: 0x0061FD14 File Offset: 0x0061DF14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC3E RID: 183358 RVA: 0x0061FD21 File Offset: 0x0061DF21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC3F RID: 183359 RVA: 0x0061FD28 File Offset: 0x0061DF28
		public static IActorLookAtData GetRootAsIActorLookAtData(ByteBuffer _bb)
		{
			return IActorLookAtData.GetRootAsIActorLookAtData(_bb, default(IActorLookAtData));
		}

		// Token: 0x0602CC40 RID: 183360 RVA: 0x0061FD44 File Offset: 0x0061DF44
		public static IActorLookAtData GetRootAsIActorLookAtData(ByteBuffer _bb, IActorLookAtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC41 RID: 183361 RVA: 0x0061FD61 File Offset: 0x0061DF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC42 RID: 183362 RVA: 0x0061FD70 File Offset: 0x0061DF70
		public IActorLookAtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C019 RID: 49177
		// (get) Token: 0x0602CC43 RID: 183363 RVA: 0x0061FD80 File Offset: 0x0061DF80
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CC44 RID: 183364 RVA: 0x0061FDBC File Offset: 0x0061DFBC
		public static Offset<IActorLookAtData> CreateIActorLookAtData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker)
		{
			builder.StartTable(1);
			IActorLookAtData.AddType(builder, Type);
			return IActorLookAtData.EndIActorLookAtData(builder);
		}

		// Token: 0x0602CC45 RID: 183365 RVA: 0x0061FDD2 File Offset: 0x0061DFD2
		public static void StartIActorLookAtData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CC46 RID: 183366 RVA: 0x0061FDDB File Offset: 0x0061DFDB
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC47 RID: 183367 RVA: 0x0061FDE6 File Offset: 0x0061DFE6
		public static Offset<IActorLookAtData> EndIActorLookAtData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtData>(builder.EndTable());
		}

		// Token: 0x0602CC48 RID: 183368 RVA: 0x0061FDF4 File Offset: 0x0061DFF4
		public IActorLookAtDataT UnPack()
		{
			IActorLookAtDataT actorLookAtDataT = new IActorLookAtDataT();
			this.UnPackTo(actorLookAtDataT);
			return actorLookAtDataT;
		}

		// Token: 0x0602CC49 RID: 183369 RVA: 0x0061FE0F File Offset: 0x0061E00F
		public void UnPackTo(IActorLookAtDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CC4A RID: 183370 RVA: 0x0061FE20 File Offset: 0x0061E020
		public static Offset<IActorLookAtData> Pack(FlatBufferBuilder builder, IActorLookAtDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtData>);
			}
			return IActorLookAtData.CreateIActorLookAtData(builder, _o.Type);
		}

		// Token: 0x04011288 RID: 70280
		private Table __p;
	}
}
