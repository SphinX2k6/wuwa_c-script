using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006718 RID: 26392
	public struct IActorFxEmoteStopAll : IFlatbufferObject
	{
		// Token: 0x1700BFE6 RID: 49126
		// (get) Token: 0x0602CB3B RID: 183099 RVA: 0x0061DC30 File Offset: 0x0061BE30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB3C RID: 183100 RVA: 0x0061DC3D File Offset: 0x0061BE3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB3D RID: 183101 RVA: 0x0061DC44 File Offset: 0x0061BE44
		public static IActorFxEmoteStopAll GetRootAsIActorFxEmoteStopAll(ByteBuffer _bb)
		{
			return IActorFxEmoteStopAll.GetRootAsIActorFxEmoteStopAll(_bb, default(IActorFxEmoteStopAll));
		}

		// Token: 0x0602CB3E RID: 183102 RVA: 0x0061DC60 File Offset: 0x0061BE60
		public static IActorFxEmoteStopAll GetRootAsIActorFxEmoteStopAll(ByteBuffer _bb, IActorFxEmoteStopAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB3F RID: 183103 RVA: 0x0061DC7D File Offset: 0x0061BE7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB40 RID: 183104 RVA: 0x0061DC8C File Offset: 0x0061BE8C
		public IActorFxEmoteStopAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFE7 RID: 49127
		// (get) Token: 0x0602CB41 RID: 183105 RVA: 0x0061DC9C File Offset: 0x0061BE9C
		public EActorFxEmoteStopSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteStopSubType.StopAll;
				}
				return (EActorFxEmoteStopSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB42 RID: 183106 RVA: 0x0061DCD8 File Offset: 0x0061BED8
		public static Offset<IActorFxEmoteStopAll> CreateIActorFxEmoteStopAll(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll)
		{
			builder.StartTable(1);
			IActorFxEmoteStopAll.AddType(builder, Type);
			return IActorFxEmoteStopAll.EndIActorFxEmoteStopAll(builder);
		}

		// Token: 0x0602CB43 RID: 183107 RVA: 0x0061DCEE File Offset: 0x0061BEEE
		public static void StartIActorFxEmoteStopAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CB44 RID: 183108 RVA: 0x0061DCF7 File Offset: 0x0061BEF7
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB45 RID: 183109 RVA: 0x0061DD02 File Offset: 0x0061BF02
		public static Offset<IActorFxEmoteStopAll> EndIActorFxEmoteStopAll(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopAll>(builder.EndTable());
		}

		// Token: 0x0602CB46 RID: 183110 RVA: 0x0061DD10 File Offset: 0x0061BF10
		public IActorFxEmoteStopAllT UnPack()
		{
			IActorFxEmoteStopAllT actorFxEmoteStopAllT = new IActorFxEmoteStopAllT();
			this.UnPackTo(actorFxEmoteStopAllT);
			return actorFxEmoteStopAllT;
		}

		// Token: 0x0602CB47 RID: 183111 RVA: 0x0061DD2B File Offset: 0x0061BF2B
		public void UnPackTo(IActorFxEmoteStopAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CB48 RID: 183112 RVA: 0x0061DD3C File Offset: 0x0061BF3C
		public static Offset<IActorFxEmoteStopAll> Pack(FlatBufferBuilder builder, IActorFxEmoteStopAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStopAll>);
			}
			return IActorFxEmoteStopAll.CreateIActorFxEmoteStopAll(builder, _o.Type);
		}

		// Token: 0x0401125F RID: 70239
		private Table __p;
	}
}
