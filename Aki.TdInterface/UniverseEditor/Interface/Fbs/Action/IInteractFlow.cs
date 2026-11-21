using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703A RID: 28730
	public struct IInteractFlow : IFlatbufferObject
	{
		// Token: 0x1700D25B RID: 53851
		// (get) Token: 0x06031CB0 RID: 203952 RVA: 0x006BD874 File Offset: 0x006BBA74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031CB1 RID: 203953 RVA: 0x006BD881 File Offset: 0x006BBA81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031CB2 RID: 203954 RVA: 0x006BD888 File Offset: 0x006BBA88
		public static IInteractFlow GetRootAsIInteractFlow(ByteBuffer _bb)
		{
			return IInteractFlow.GetRootAsIInteractFlow(_bb, default(IInteractFlow));
		}

		// Token: 0x06031CB3 RID: 203955 RVA: 0x006BD8A4 File Offset: 0x006BBAA4
		public static IInteractFlow GetRootAsIInteractFlow(ByteBuffer _bb, IInteractFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031CB4 RID: 203956 RVA: 0x006BD8C1 File Offset: 0x006BBAC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031CB5 RID: 203957 RVA: 0x006BD8D0 File Offset: 0x006BBAD0
		public IInteractFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D25C RID: 53852
		// (get) Token: 0x06031CB6 RID: 203958 RVA: 0x006BD8E0 File Offset: 0x006BBAE0
		public EInteractOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractOption.Flow;
				}
				return (EInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D25D RID: 53853
		// (get) Token: 0x06031CB7 RID: 203959 RVA: 0x006BD91C File Offset: 0x006BBB1C
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031CB8 RID: 203960 RVA: 0x006BD979 File Offset: 0x006BBB79
		public static Offset<IInteractFlow> CreateIInteractFlow(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IInteractFlow.AddFlow(builder, FlowOffset);
			IInteractFlow.AddType(builder, Type);
			return IInteractFlow.EndIInteractFlow(builder);
		}

		// Token: 0x06031CB9 RID: 203961 RVA: 0x006BD996 File Offset: 0x006BBB96
		public static void StartIInteractFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031CBA RID: 203962 RVA: 0x006BD99F File Offset: 0x006BBB9F
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CBB RID: 203963 RVA: 0x006BD9AA File Offset: 0x006BBBAA
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06031CBC RID: 203964 RVA: 0x006BD9BA File Offset: 0x006BBBBA
		public static Offset<IInteractFlow> EndIInteractFlow(FlatBufferBuilder builder)
		{
			return new Offset<IInteractFlow>(builder.EndTable());
		}

		// Token: 0x06031CBD RID: 203965 RVA: 0x006BD9C8 File Offset: 0x006BBBC8
		public IInteractFlowT UnPack()
		{
			IInteractFlowT interactFlowT = new IInteractFlowT();
			this.UnPackTo(interactFlowT);
			return interactFlowT;
		}

		// Token: 0x06031CBE RID: 203966 RVA: 0x006BD9E4 File Offset: 0x006BBBE4
		public void UnPackTo(IInteractFlowT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06031CBF RID: 203967 RVA: 0x006BDA2C File Offset: 0x006BBC2C
		public static Offset<IInteractFlow> Pack(FlatBufferBuilder builder, IInteractFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractFlow>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IInteractFlow.CreateIInteractFlow(builder, _o.Type, flowOffset);
		}

		// Token: 0x04011F81 RID: 73601
		private Table __p;
	}
}
