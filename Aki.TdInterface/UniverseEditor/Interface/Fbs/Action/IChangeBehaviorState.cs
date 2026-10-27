using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062CF RID: 25295
	public struct IChangeBehaviorState : IFlatbufferObject
	{
		// Token: 0x1700BCD3 RID: 48339
		// (get) Token: 0x0602BB8D RID: 179085 RVA: 0x00604396 File Offset: 0x00602596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB8E RID: 179086 RVA: 0x006043A3 File Offset: 0x006025A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB8F RID: 179087 RVA: 0x006043AC File Offset: 0x006025AC
		public static IChangeBehaviorState GetRootAsIChangeBehaviorState(ByteBuffer _bb)
		{
			return IChangeBehaviorState.GetRootAsIChangeBehaviorState(_bb, default(IChangeBehaviorState));
		}

		// Token: 0x0602BB90 RID: 179088 RVA: 0x006043C8 File Offset: 0x006025C8
		public static IChangeBehaviorState GetRootAsIChangeBehaviorState(ByteBuffer _bb, IChangeBehaviorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB91 RID: 179089 RVA: 0x006043E5 File Offset: 0x006025E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB92 RID: 179090 RVA: 0x006043F4 File Offset: 0x006025F4
		public IChangeBehaviorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCD4 RID: 48340
		// (get) Token: 0x0602BB93 RID: 179091 RVA: 0x00604404 File Offset: 0x00602604
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCD5 RID: 48341
		// (get) Token: 0x0602BB94 RID: 179092 RVA: 0x00604440 File Offset: 0x00602640
		public bool IsInstant
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602BB95 RID: 179093 RVA: 0x0060447F File Offset: 0x0060267F
		public static Offset<IChangeBehaviorState> CreateIChangeBehaviorState(FlatBufferBuilder builder, int StateId = 0, bool IsInstant = false)
		{
			builder.StartTable(2);
			IChangeBehaviorState.AddStateId(builder, StateId);
			IChangeBehaviorState.AddIsInstant(builder, IsInstant);
			return IChangeBehaviorState.EndIChangeBehaviorState(builder);
		}

		// Token: 0x0602BB96 RID: 179094 RVA: 0x0060449C File Offset: 0x0060269C
		public static void StartIChangeBehaviorState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BB97 RID: 179095 RVA: 0x006044A5 File Offset: 0x006026A5
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x0602BB98 RID: 179096 RVA: 0x006044B0 File Offset: 0x006026B0
		public static void AddIsInstant(FlatBufferBuilder builder, bool isInstant)
		{
			builder.AddBool(1, isInstant, false);
		}

		// Token: 0x0602BB99 RID: 179097 RVA: 0x006044BB File Offset: 0x006026BB
		public static Offset<IChangeBehaviorState> EndIChangeBehaviorState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeBehaviorState>(builder.EndTable());
		}

		// Token: 0x0602BB9A RID: 179098 RVA: 0x006044C8 File Offset: 0x006026C8
		public IChangeBehaviorStateT UnPack()
		{
			IChangeBehaviorStateT changeBehaviorStateT = new IChangeBehaviorStateT();
			this.UnPackTo(changeBehaviorStateT);
			return changeBehaviorStateT;
		}

		// Token: 0x0602BB9B RID: 179099 RVA: 0x006044E3 File Offset: 0x006026E3
		public void UnPackTo(IChangeBehaviorStateT _o)
		{
			_o.StateId = this.StateId;
			_o.IsInstant = this.IsInstant;
		}

		// Token: 0x0602BB9C RID: 179100 RVA: 0x00604500 File Offset: 0x00602700
		public static Offset<IChangeBehaviorState> Pack(FlatBufferBuilder builder, IChangeBehaviorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeBehaviorState>);
			}
			return IChangeBehaviorState.CreateIChangeBehaviorState(builder, _o.StateId, _o.IsInstant);
		}

		// Token: 0x04010877 RID: 67703
		private Table __p;
	}
}
