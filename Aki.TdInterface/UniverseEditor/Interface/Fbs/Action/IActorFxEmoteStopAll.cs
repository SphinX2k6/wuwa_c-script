using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B6 RID: 24758
	public struct IActorFxEmoteStopAll : IFlatbufferObject
	{
		// Token: 0x1700B67B RID: 46715
		// (get) Token: 0x0602A45A RID: 173146 RVA: 0x005D3C88 File Offset: 0x005D1E88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A45B RID: 173147 RVA: 0x005D3C95 File Offset: 0x005D1E95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A45C RID: 173148 RVA: 0x005D3C9C File Offset: 0x005D1E9C
		public static IActorFxEmoteStopAll GetRootAsIActorFxEmoteStopAll(ByteBuffer _bb)
		{
			return IActorFxEmoteStopAll.GetRootAsIActorFxEmoteStopAll(_bb, default(IActorFxEmoteStopAll));
		}

		// Token: 0x0602A45D RID: 173149 RVA: 0x005D3CB8 File Offset: 0x005D1EB8
		public static IActorFxEmoteStopAll GetRootAsIActorFxEmoteStopAll(ByteBuffer _bb, IActorFxEmoteStopAll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A45E RID: 173150 RVA: 0x005D3CD5 File Offset: 0x005D1ED5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A45F RID: 173151 RVA: 0x005D3CE4 File Offset: 0x005D1EE4
		public IActorFxEmoteStopAll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B67C RID: 46716
		// (get) Token: 0x0602A460 RID: 173152 RVA: 0x005D3CF4 File Offset: 0x005D1EF4
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

		// Token: 0x0602A461 RID: 173153 RVA: 0x005D3D30 File Offset: 0x005D1F30
		public static Offset<IActorFxEmoteStopAll> CreateIActorFxEmoteStopAll(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll)
		{
			builder.StartTable(1);
			IActorFxEmoteStopAll.AddType(builder, Type);
			return IActorFxEmoteStopAll.EndIActorFxEmoteStopAll(builder);
		}

		// Token: 0x0602A462 RID: 173154 RVA: 0x005D3D46 File Offset: 0x005D1F46
		public static void StartIActorFxEmoteStopAll(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A463 RID: 173155 RVA: 0x005D3D4F File Offset: 0x005D1F4F
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A464 RID: 173156 RVA: 0x005D3D5A File Offset: 0x005D1F5A
		public static Offset<IActorFxEmoteStopAll> EndIActorFxEmoteStopAll(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopAll>(builder.EndTable());
		}

		// Token: 0x0602A465 RID: 173157 RVA: 0x005D3D68 File Offset: 0x005D1F68
		public IActorFxEmoteStopAllT UnPack()
		{
			IActorFxEmoteStopAllT actorFxEmoteStopAllT = new IActorFxEmoteStopAllT();
			this.UnPackTo(actorFxEmoteStopAllT);
			return actorFxEmoteStopAllT;
		}

		// Token: 0x0602A466 RID: 173158 RVA: 0x005D3D83 File Offset: 0x005D1F83
		public void UnPackTo(IActorFxEmoteStopAllT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A467 RID: 173159 RVA: 0x005D3D94 File Offset: 0x005D1F94
		public static Offset<IActorFxEmoteStopAll> Pack(FlatBufferBuilder builder, IActorFxEmoteStopAllT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStopAll>);
			}
			return IActorFxEmoteStopAll.CreateIActorFxEmoteStopAll(builder, _o.Type);
		}

		// Token: 0x0401045B RID: 66651
		private Table __p;
	}
}
