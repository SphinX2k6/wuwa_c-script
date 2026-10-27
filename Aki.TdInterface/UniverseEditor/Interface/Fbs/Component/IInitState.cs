using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005419 RID: 21529
	public struct IInitState : IFlatbufferObject
	{
		// Token: 0x17009E61 RID: 40545
		// (get) Token: 0x060235BD RID: 144829 RVA: 0x004E4C34 File Offset: 0x004E2E34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235BE RID: 144830 RVA: 0x004E4C41 File Offset: 0x004E2E41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235BF RID: 144831 RVA: 0x004E4C48 File Offset: 0x004E2E48
		public static IInitState GetRootAsIInitState(ByteBuffer _bb)
		{
			return IInitState.GetRootAsIInitState(_bb, default(IInitState));
		}

		// Token: 0x060235C0 RID: 144832 RVA: 0x004E4C64 File Offset: 0x004E2E64
		public static IInitState GetRootAsIInitState(ByteBuffer _bb, IInitState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235C1 RID: 144833 RVA: 0x004E4C81 File Offset: 0x004E2E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235C2 RID: 144834 RVA: 0x004E4C90 File Offset: 0x004E2E90
		public IInitState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E62 RID: 40546
		// (get) Token: 0x060235C3 RID: 144835 RVA: 0x004E4CA0 File Offset: 0x004E2EA0
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

		// Token: 0x060235C4 RID: 144836 RVA: 0x004E4CDC File Offset: 0x004E2EDC
		public static Offset<IInitState> CreateIInitState(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitState.AddType(builder, Type);
			return IInitState.EndIInitState(builder);
		}

		// Token: 0x060235C5 RID: 144837 RVA: 0x004E4CF2 File Offset: 0x004E2EF2
		public static void StartIInitState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060235C6 RID: 144838 RVA: 0x004E4CFB File Offset: 0x004E2EFB
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060235C7 RID: 144839 RVA: 0x004E4D06 File Offset: 0x004E2F06
		public static Offset<IInitState> EndIInitState(FlatBufferBuilder builder)
		{
			return new Offset<IInitState>(builder.EndTable());
		}

		// Token: 0x060235C8 RID: 144840 RVA: 0x004E4D14 File Offset: 0x004E2F14
		public IInitStateT UnPack()
		{
			IInitStateT initStateT = new IInitStateT();
			this.UnPackTo(initStateT);
			return initStateT;
		}

		// Token: 0x060235C9 RID: 144841 RVA: 0x004E4D2F File Offset: 0x004E2F2F
		public void UnPackTo(IInitStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060235CA RID: 144842 RVA: 0x004E4D40 File Offset: 0x004E2F40
		public static Offset<IInitState> Pack(FlatBufferBuilder builder, IInitStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitState>);
			}
			return IInitState.CreateIInitState(builder, _o.Type);
		}

		// Token: 0x0400E665 RID: 58981
		private Table __p;
	}
}
