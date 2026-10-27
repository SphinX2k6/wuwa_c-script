using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006987 RID: 27015
	public struct IInteractFlow : IFlatbufferObject
	{
		// Token: 0x1700C858 RID: 51288
		// (get) Token: 0x0602F2E0 RID: 193248 RVA: 0x0066D38C File Offset: 0x0066B58C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F2E1 RID: 193249 RVA: 0x0066D399 File Offset: 0x0066B599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F2E2 RID: 193250 RVA: 0x0066D3A0 File Offset: 0x0066B5A0
		public static IInteractFlow GetRootAsIInteractFlow(ByteBuffer _bb)
		{
			return IInteractFlow.GetRootAsIInteractFlow(_bb, default(IInteractFlow));
		}

		// Token: 0x0602F2E3 RID: 193251 RVA: 0x0066D3BC File Offset: 0x0066B5BC
		public static IInteractFlow GetRootAsIInteractFlow(ByteBuffer _bb, IInteractFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F2E4 RID: 193252 RVA: 0x0066D3D9 File Offset: 0x0066B5D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F2E5 RID: 193253 RVA: 0x0066D3E8 File Offset: 0x0066B5E8
		public IInteractFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C859 RID: 51289
		// (get) Token: 0x0602F2E6 RID: 193254 RVA: 0x0066D3F8 File Offset: 0x0066B5F8
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

		// Token: 0x1700C85A RID: 51290
		// (get) Token: 0x0602F2E7 RID: 193255 RVA: 0x0066D434 File Offset: 0x0066B634
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

		// Token: 0x0602F2E8 RID: 193256 RVA: 0x0066D491 File Offset: 0x0066B691
		public static Offset<IInteractFlow> CreateIInteractFlow(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IInteractFlow.AddFlow(builder, FlowOffset);
			IInteractFlow.AddType(builder, Type);
			return IInteractFlow.EndIInteractFlow(builder);
		}

		// Token: 0x0602F2E9 RID: 193257 RVA: 0x0066D4AE File Offset: 0x0066B6AE
		public static void StartIInteractFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F2EA RID: 193258 RVA: 0x0066D4B7 File Offset: 0x0066B6B7
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F2EB RID: 193259 RVA: 0x0066D4C2 File Offset: 0x0066B6C2
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0602F2EC RID: 193260 RVA: 0x0066D4D2 File Offset: 0x0066B6D2
		public static Offset<IInteractFlow> EndIInteractFlow(FlatBufferBuilder builder)
		{
			return new Offset<IInteractFlow>(builder.EndTable());
		}

		// Token: 0x0602F2ED RID: 193261 RVA: 0x0066D4E0 File Offset: 0x0066B6E0
		public IInteractFlowT UnPack()
		{
			IInteractFlowT interactFlowT = new IInteractFlowT();
			this.UnPackTo(interactFlowT);
			return interactFlowT;
		}

		// Token: 0x0602F2EE RID: 193262 RVA: 0x0066D4FC File Offset: 0x0066B6FC
		public void UnPackTo(IInteractFlowT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0602F2EF RID: 193263 RVA: 0x0066D544 File Offset: 0x0066B744
		public static Offset<IInteractFlow> Pack(FlatBufferBuilder builder, IInteractFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractFlow>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IInteractFlow.CreateIInteractFlow(builder, _o.Type, flowOffset);
		}

		// Token: 0x04011115 RID: 69909
		private Table __p;
	}
}
