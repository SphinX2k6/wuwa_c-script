using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599F RID: 22943
	public struct IInitState : IFlatbufferObject
	{
		// Token: 0x1700A69B RID: 42651
		// (get) Token: 0x06025675 RID: 153205 RVA: 0x00521C60 File Offset: 0x0051FE60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025676 RID: 153206 RVA: 0x00521C6D File Offset: 0x0051FE6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025677 RID: 153207 RVA: 0x00521C74 File Offset: 0x0051FE74
		public static IInitState GetRootAsIInitState(ByteBuffer _bb)
		{
			return IInitState.GetRootAsIInitState(_bb, default(IInitState));
		}

		// Token: 0x06025678 RID: 153208 RVA: 0x00521C90 File Offset: 0x0051FE90
		public static IInitState GetRootAsIInitState(ByteBuffer _bb, IInitState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025679 RID: 153209 RVA: 0x00521CAD File Offset: 0x0051FEAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602567A RID: 153210 RVA: 0x00521CBC File Offset: 0x0051FEBC
		public IInitState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A69C RID: 42652
		// (get) Token: 0x0602567B RID: 153211 RVA: 0x00521CCC File Offset: 0x0051FECC
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602567C RID: 153212 RVA: 0x00521D08 File Offset: 0x0051FF08
		public static Offset<IInitState> CreateIInitState(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitState.AddType(builder, Type);
			return IInitState.EndIInitState(builder);
		}

		// Token: 0x0602567D RID: 153213 RVA: 0x00521D1E File Offset: 0x0051FF1E
		public static void StartIInitState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602567E RID: 153214 RVA: 0x00521D27 File Offset: 0x0051FF27
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602567F RID: 153215 RVA: 0x00521D32 File Offset: 0x0051FF32
		public static Offset<IInitState> EndIInitState(FlatBufferBuilder builder)
		{
			return new Offset<IInitState>(builder.EndTable());
		}

		// Token: 0x06025680 RID: 153216 RVA: 0x00521D40 File Offset: 0x0051FF40
		public IInitStateT UnPack()
		{
			IInitStateT initStateT = new IInitStateT();
			this.UnPackTo(initStateT);
			return initStateT;
		}

		// Token: 0x06025681 RID: 153217 RVA: 0x00521D5B File Offset: 0x0051FF5B
		public void UnPackTo(IInitStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025682 RID: 153218 RVA: 0x00521D6C File Offset: 0x0051FF6C
		public static Offset<IInitState> Pack(FlatBufferBuilder builder, IInitStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitState>);
			}
			return IInitState.CreateIInitState(builder, _o.Type);
		}

		// Token: 0x0400F296 RID: 62102
		private Table __p;
	}
}
