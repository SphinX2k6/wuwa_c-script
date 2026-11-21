using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF9 RID: 31737
	public struct IToggleMapMarkState : IFlatbufferObject
	{
		// Token: 0x1700EDBB RID: 60859
		// (get) Token: 0x0603934E RID: 234318 RVA: 0x007BA7B6 File Offset: 0x007B89B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603934F RID: 234319 RVA: 0x007BA7C3 File Offset: 0x007B89C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039350 RID: 234320 RVA: 0x007BA7CC File Offset: 0x007B89CC
		public static IToggleMapMarkState GetRootAsIToggleMapMarkState(ByteBuffer _bb)
		{
			return IToggleMapMarkState.GetRootAsIToggleMapMarkState(_bb, default(IToggleMapMarkState));
		}

		// Token: 0x06039351 RID: 234321 RVA: 0x007BA7E8 File Offset: 0x007B89E8
		public static IToggleMapMarkState GetRootAsIToggleMapMarkState(ByteBuffer _bb, IToggleMapMarkState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039352 RID: 234322 RVA: 0x007BA805 File Offset: 0x007B8A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039353 RID: 234323 RVA: 0x007BA814 File Offset: 0x007B8A14
		public IToggleMapMarkState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDBC RID: 60860
		// (get) Token: 0x06039354 RID: 234324 RVA: 0x007BA824 File Offset: 0x007B8A24
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039355 RID: 234325 RVA: 0x007BA860 File Offset: 0x007B8A60
		public static Offset<IToggleMapMarkState> CreateIToggleMapMarkState(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show)
		{
			builder.StartTable(1);
			IToggleMapMarkState.AddType(builder, Type);
			return IToggleMapMarkState.EndIToggleMapMarkState(builder);
		}

		// Token: 0x06039356 RID: 234326 RVA: 0x007BA876 File Offset: 0x007B8A76
		public static void StartIToggleMapMarkState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039357 RID: 234327 RVA: 0x007BA87F File Offset: 0x007B8A7F
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039358 RID: 234328 RVA: 0x007BA88A File Offset: 0x007B8A8A
		public static Offset<IToggleMapMarkState> EndIToggleMapMarkState(FlatBufferBuilder builder)
		{
			return new Offset<IToggleMapMarkState>(builder.EndTable());
		}

		// Token: 0x06039359 RID: 234329 RVA: 0x007BA898 File Offset: 0x007B8A98
		public IToggleMapMarkStateT UnPack()
		{
			IToggleMapMarkStateT toggleMapMarkStateT = new IToggleMapMarkStateT();
			this.UnPackTo(toggleMapMarkStateT);
			return toggleMapMarkStateT;
		}

		// Token: 0x0603935A RID: 234330 RVA: 0x007BA8B3 File Offset: 0x007B8AB3
		public void UnPackTo(IToggleMapMarkStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603935B RID: 234331 RVA: 0x007BA8C4 File Offset: 0x007B8AC4
		public static Offset<IToggleMapMarkState> Pack(FlatBufferBuilder builder, IToggleMapMarkStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleMapMarkState>);
			}
			return IToggleMapMarkState.CreateIToggleMapMarkState(builder, _o.Type);
		}

		// Token: 0x0401329A RID: 78490
		private Table __p;
	}
}
