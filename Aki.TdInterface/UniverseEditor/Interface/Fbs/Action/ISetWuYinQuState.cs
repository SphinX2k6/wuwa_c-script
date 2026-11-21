using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007881 RID: 30849
	public struct ISetWuYinQuState : IFlatbufferObject
	{
		// Token: 0x1700E239 RID: 57913
		// (get) Token: 0x06036433 RID: 222259 RVA: 0x007448B4 File Offset: 0x00742AB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036434 RID: 222260 RVA: 0x007448C1 File Offset: 0x00742AC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036435 RID: 222261 RVA: 0x007448C8 File Offset: 0x00742AC8
		public static ISetWuYinQuState GetRootAsISetWuYinQuState(ByteBuffer _bb)
		{
			return ISetWuYinQuState.GetRootAsISetWuYinQuState(_bb, default(ISetWuYinQuState));
		}

		// Token: 0x06036436 RID: 222262 RVA: 0x007448E4 File Offset: 0x00742AE4
		public static ISetWuYinQuState GetRootAsISetWuYinQuState(ByteBuffer _bb, ISetWuYinQuState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036437 RID: 222263 RVA: 0x00744901 File Offset: 0x00742B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036438 RID: 222264 RVA: 0x00744910 File Offset: 0x00742B10
		public ISetWuYinQuState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E23A RID: 57914
		// (get) Token: 0x06036439 RID: 222265 RVA: 0x00744920 File Offset: 0x00742B20
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

		// Token: 0x0603643A RID: 222266 RVA: 0x00744957 File Offset: 0x00742B57
		public Span<byte> GetWuYinQuNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603643B RID: 222267 RVA: 0x00744966 File Offset: 0x00742B66
		public byte[] GetWuYinQuNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E23B RID: 57915
		// (get) Token: 0x0603643C RID: 222268 RVA: 0x00744974 File Offset: 0x00742B74
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

		// Token: 0x0603643D RID: 222269 RVA: 0x007449B0 File Offset: 0x00742BB0
		public static Offset<ISetWuYinQuState> CreateISetWuYinQuState(FlatBufferBuilder builder, StringOffset WuYinQuNameOffset = default(StringOffset), EWuYinQuState State = EWuYinQuState.End)
		{
			builder.StartTable(2);
			ISetWuYinQuState.AddWuYinQuName(builder, WuYinQuNameOffset);
			ISetWuYinQuState.AddState(builder, State);
			return ISetWuYinQuState.EndISetWuYinQuState(builder);
		}

		// Token: 0x0603643E RID: 222270 RVA: 0x007449CD File Offset: 0x00742BCD
		public static void StartISetWuYinQuState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603643F RID: 222271 RVA: 0x007449D6 File Offset: 0x00742BD6
		public static void AddWuYinQuName(FlatBufferBuilder builder, StringOffset wuYinQuNameOffset)
		{
			builder.AddOffset(0, wuYinQuNameOffset.Value, 0);
		}

		// Token: 0x06036440 RID: 222272 RVA: 0x007449E6 File Offset: 0x00742BE6
		public static void AddState(FlatBufferBuilder builder, EWuYinQuState state)
		{
			builder.AddByte(1, (byte)state, 0);
		}

		// Token: 0x06036441 RID: 222273 RVA: 0x007449F1 File Offset: 0x00742BF1
		public static Offset<ISetWuYinQuState> EndISetWuYinQuState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWuYinQuState>(builder.EndTable());
		}

		// Token: 0x06036442 RID: 222274 RVA: 0x00744A00 File Offset: 0x00742C00
		public ISetWuYinQuStateT UnPack()
		{
			ISetWuYinQuStateT setWuYinQuStateT = new ISetWuYinQuStateT();
			this.UnPackTo(setWuYinQuStateT);
			return setWuYinQuStateT;
		}

		// Token: 0x06036443 RID: 222275 RVA: 0x00744A1B File Offset: 0x00742C1B
		public void UnPackTo(ISetWuYinQuStateT _o)
		{
			_o.WuYinQuName = this.WuYinQuName;
			_o.State = this.State;
		}

		// Token: 0x06036444 RID: 222276 RVA: 0x00744A38 File Offset: 0x00742C38
		public static Offset<ISetWuYinQuState> Pack(FlatBufferBuilder builder, ISetWuYinQuStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetWuYinQuState>);
			}
			StringOffset wuYinQuNameOffset = (_o.WuYinQuName == null) ? default(StringOffset) : builder.CreateString(_o.WuYinQuName);
			return ISetWuYinQuState.CreateISetWuYinQuState(builder, wuYinQuNameOffset, _o.State);
		}

		// Token: 0x04012B10 RID: 76560
		private Table __p;
	}
}
