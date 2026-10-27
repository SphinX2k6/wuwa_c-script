using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060BC RID: 24764
	public struct IActorFxEmoteStopSubType : IFlatbufferObject
	{
		// Token: 0x1700B683 RID: 46723
		// (get) Token: 0x0602A488 RID: 173192 RVA: 0x005D413D File Offset: 0x005D233D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A489 RID: 173193 RVA: 0x005D414A File Offset: 0x005D234A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A48A RID: 173194 RVA: 0x005D4154 File Offset: 0x005D2354
		public static IActorFxEmoteStopSubType GetRootAsIActorFxEmoteStopSubType(ByteBuffer _bb)
		{
			return IActorFxEmoteStopSubType.GetRootAsIActorFxEmoteStopSubType(_bb, default(IActorFxEmoteStopSubType));
		}

		// Token: 0x0602A48B RID: 173195 RVA: 0x005D4170 File Offset: 0x005D2370
		public static IActorFxEmoteStopSubType GetRootAsIActorFxEmoteStopSubType(ByteBuffer _bb, IActorFxEmoteStopSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A48C RID: 173196 RVA: 0x005D418D File Offset: 0x005D238D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A48D RID: 173197 RVA: 0x005D419C File Offset: 0x005D239C
		public IActorFxEmoteStopSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B684 RID: 46724
		// (get) Token: 0x0602A48E RID: 173198 RVA: 0x005D41AC File Offset: 0x005D23AC
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

		// Token: 0x0602A48F RID: 173199 RVA: 0x005D41E8 File Offset: 0x005D23E8
		public static Offset<IActorFxEmoteStopSubType> CreateIActorFxEmoteStopSubType(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll)
		{
			builder.StartTable(1);
			IActorFxEmoteStopSubType.AddType(builder, Type);
			return IActorFxEmoteStopSubType.EndIActorFxEmoteStopSubType(builder);
		}

		// Token: 0x0602A490 RID: 173200 RVA: 0x005D41FE File Offset: 0x005D23FE
		public static void StartIActorFxEmoteStopSubType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A491 RID: 173201 RVA: 0x005D4207 File Offset: 0x005D2407
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A492 RID: 173202 RVA: 0x005D4212 File Offset: 0x005D2412
		public static Offset<IActorFxEmoteStopSubType> EndIActorFxEmoteStopSubType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopSubType>(builder.EndTable());
		}

		// Token: 0x0602A493 RID: 173203 RVA: 0x005D4220 File Offset: 0x005D2420
		public IActorFxEmoteStopSubTypeT UnPack()
		{
			IActorFxEmoteStopSubTypeT actorFxEmoteStopSubTypeT = new IActorFxEmoteStopSubTypeT();
			this.UnPackTo(actorFxEmoteStopSubTypeT);
			return actorFxEmoteStopSubTypeT;
		}

		// Token: 0x0602A494 RID: 173204 RVA: 0x005D423B File Offset: 0x005D243B
		public void UnPackTo(IActorFxEmoteStopSubTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A495 RID: 173205 RVA: 0x005D424C File Offset: 0x005D244C
		public static Offset<IActorFxEmoteStopSubType> Pack(FlatBufferBuilder builder, IActorFxEmoteStopSubTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStopSubType>);
			}
			return IActorFxEmoteStopSubType.CreateIActorFxEmoteStopSubType(builder, _o.Type);
		}

		// Token: 0x04010460 RID: 66656
		private Table __p;
	}
}
