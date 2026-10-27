using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B5 RID: 28853
	public struct ISetWuYinQuState : IFlatbufferObject
	{
		// Token: 0x1700D656 RID: 54870
		// (get) Token: 0x06033191 RID: 209297 RVA: 0x006E42A8 File Offset: 0x006E24A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033192 RID: 209298 RVA: 0x006E42B5 File Offset: 0x006E24B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033193 RID: 209299 RVA: 0x006E42BC File Offset: 0x006E24BC
		public static ISetWuYinQuState GetRootAsISetWuYinQuState(ByteBuffer _bb)
		{
			return ISetWuYinQuState.GetRootAsISetWuYinQuState(_bb, default(ISetWuYinQuState));
		}

		// Token: 0x06033194 RID: 209300 RVA: 0x006E42D8 File Offset: 0x006E24D8
		public static ISetWuYinQuState GetRootAsISetWuYinQuState(ByteBuffer _bb, ISetWuYinQuState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033195 RID: 209301 RVA: 0x006E42F5 File Offset: 0x006E24F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033196 RID: 209302 RVA: 0x006E4304 File Offset: 0x006E2504
		public ISetWuYinQuState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D657 RID: 54871
		// (get) Token: 0x06033197 RID: 209303 RVA: 0x006E4314 File Offset: 0x006E2514
		public string WuYinQuName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033198 RID: 209304 RVA: 0x006E434B File Offset: 0x006E254B
		public Span<byte> GetWuYinQuNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06033199 RID: 209305 RVA: 0x006E435A File Offset: 0x006E255A
		public byte[] GetWuYinQuNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D658 RID: 54872
		// (get) Token: 0x0603319A RID: 209306 RVA: 0x006E4368 File Offset: 0x006E2568
		public EWuYinQuState State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EWuYinQuState.End;
				}
				return (EWuYinQuState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603319B RID: 209307 RVA: 0x006E43A4 File Offset: 0x006E25A4
		public static Offset<ISetWuYinQuState> CreateISetWuYinQuState(FlatBufferBuilder builder, StringOffset WuYinQuNameOffset = default(StringOffset), EWuYinQuState State = EWuYinQuState.End)
		{
			builder.StartTable(2);
			ISetWuYinQuState.AddWuYinQuName(builder, WuYinQuNameOffset);
			ISetWuYinQuState.AddState(builder, State);
			return ISetWuYinQuState.EndISetWuYinQuState(builder);
		}

		// Token: 0x0603319C RID: 209308 RVA: 0x006E43C1 File Offset: 0x006E25C1
		public static void StartISetWuYinQuState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603319D RID: 209309 RVA: 0x006E43CA File Offset: 0x006E25CA
		public static void AddWuYinQuName(FlatBufferBuilder builder, StringOffset wuYinQuNameOffset)
		{
			builder.AddOffset(0, wuYinQuNameOffset.Value, 0);
		}

		// Token: 0x0603319E RID: 209310 RVA: 0x006E43DA File Offset: 0x006E25DA
		public static void AddState(FlatBufferBuilder builder, EWuYinQuState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x0603319F RID: 209311 RVA: 0x006E43E5 File Offset: 0x006E25E5
		public static Offset<ISetWuYinQuState> EndISetWuYinQuState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWuYinQuState>(builder.EndTable());
		}

		// Token: 0x060331A0 RID: 209312 RVA: 0x006E43F4 File Offset: 0x006E25F4
		public ISetWuYinQuStateT UnPack()
		{
			ISetWuYinQuStateT setWuYinQuStateT = new ISetWuYinQuStateT();
			this.UnPackTo(setWuYinQuStateT);
			return setWuYinQuStateT;
		}

		// Token: 0x060331A1 RID: 209313 RVA: 0x006E440F File Offset: 0x006E260F
		public void UnPackTo(ISetWuYinQuStateT _o)
		{
			_o.WuYinQuName = this.WuYinQuName;
			_o.State = this.State;
		}

		// Token: 0x060331A2 RID: 209314 RVA: 0x006E442C File Offset: 0x006E262C
		public static Offset<ISetWuYinQuState> Pack(FlatBufferBuilder builder, ISetWuYinQuStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetWuYinQuState>);
			}
			StringOffset wuYinQuNameOffset = (_o.WuYinQuName == null) ? default(StringOffset) : builder.CreateString(_o.WuYinQuName);
			return ISetWuYinQuState.CreateISetWuYinQuState(builder, wuYinQuNameOffset, _o.State);
		}

		// Token: 0x04011B22 RID: 72482
		private Table __p;
	}
}
