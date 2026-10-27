using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005392 RID: 21394
	public struct IHitLogicChangeCountDownState : IFlatbufferObject
	{
		// Token: 0x17009D38 RID: 40248
		// (get) Token: 0x06023096 RID: 143510 RVA: 0x004DA0C0 File Offset: 0x004D82C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023097 RID: 143511 RVA: 0x004DA0CD File Offset: 0x004D82CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023098 RID: 143512 RVA: 0x004DA0D4 File Offset: 0x004D82D4
		public static IHitLogicChangeCountDownState GetRootAsIHitLogicChangeCountDownState(ByteBuffer _bb)
		{
			return IHitLogicChangeCountDownState.GetRootAsIHitLogicChangeCountDownState(_bb, default(IHitLogicChangeCountDownState));
		}

		// Token: 0x06023099 RID: 143513 RVA: 0x004DA0F0 File Offset: 0x004D82F0
		public static IHitLogicChangeCountDownState GetRootAsIHitLogicChangeCountDownState(ByteBuffer _bb, IHitLogicChangeCountDownState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602309A RID: 143514 RVA: 0x004DA10D File Offset: 0x004D830D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602309B RID: 143515 RVA: 0x004DA11C File Offset: 0x004D831C
		public IHitLogicChangeCountDownState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D39 RID: 40249
		// (get) Token: 0x0602309C RID: 143516 RVA: 0x004DA12C File Offset: 0x004D832C
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602309D RID: 143517 RVA: 0x004DA168 File Offset: 0x004D8368
		public static Offset<IHitLogicChangeCountDownState> CreateIHitLogicChangeCountDownState(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState)
		{
			builder.StartTable(1);
			IHitLogicChangeCountDownState.AddType(builder, Type);
			return IHitLogicChangeCountDownState.EndIHitLogicChangeCountDownState(builder);
		}

		// Token: 0x0602309E RID: 143518 RVA: 0x004DA17E File Offset: 0x004D837E
		public static void StartIHitLogicChangeCountDownState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602309F RID: 143519 RVA: 0x004DA187 File Offset: 0x004D8387
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060230A0 RID: 143520 RVA: 0x004DA192 File Offset: 0x004D8392
		public static Offset<IHitLogicChangeCountDownState> EndIHitLogicChangeCountDownState(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeCountDownState>(builder.EndTable());
		}

		// Token: 0x060230A1 RID: 143521 RVA: 0x004DA1A0 File Offset: 0x004D83A0
		public IHitLogicChangeCountDownStateT UnPack()
		{
			IHitLogicChangeCountDownStateT hitLogicChangeCountDownStateT = new IHitLogicChangeCountDownStateT();
			this.UnPackTo(hitLogicChangeCountDownStateT);
			return hitLogicChangeCountDownStateT;
		}

		// Token: 0x060230A2 RID: 143522 RVA: 0x004DA1BB File Offset: 0x004D83BB
		public void UnPackTo(IHitLogicChangeCountDownStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060230A3 RID: 143523 RVA: 0x004DA1CC File Offset: 0x004D83CC
		public static Offset<IHitLogicChangeCountDownState> Pack(FlatBufferBuilder builder, IHitLogicChangeCountDownStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeCountDownState>);
			}
			return IHitLogicChangeCountDownState.CreateIHitLogicChangeCountDownState(builder, _o.Type);
		}

		// Token: 0x0400E57E RID: 58750
		private Table __p;
	}
}
