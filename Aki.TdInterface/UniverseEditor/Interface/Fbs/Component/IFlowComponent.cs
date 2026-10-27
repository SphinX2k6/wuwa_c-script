using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200527C RID: 21116
	public struct IFlowComponent : IFlatbufferObject
	{
		// Token: 0x17009ABE RID: 39614
		// (get) Token: 0x060225F9 RID: 140793 RVA: 0x004C3CA2 File Offset: 0x004C1EA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060225FA RID: 140794 RVA: 0x004C3CAF File Offset: 0x004C1EAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060225FB RID: 140795 RVA: 0x004C3CB8 File Offset: 0x004C1EB8
		public static IFlowComponent GetRootAsIFlowComponent(ByteBuffer _bb)
		{
			return IFlowComponent.GetRootAsIFlowComponent(_bb, default(IFlowComponent));
		}

		// Token: 0x060225FC RID: 140796 RVA: 0x004C3CD4 File Offset: 0x004C1ED4
		public static IFlowComponent GetRootAsIFlowComponent(ByteBuffer _bb, IFlowComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225FD RID: 140797 RVA: 0x004C3CF1 File Offset: 0x004C1EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225FE RID: 140798 RVA: 0x004C3D00 File Offset: 0x004C1F00
		public IFlowComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ABF RID: 39615
		// (get) Token: 0x060225FF RID: 140799 RVA: 0x004C3D10 File Offset: 0x004C1F10
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009AC0 RID: 39616
		// (get) Token: 0x06022600 RID: 140800 RVA: 0x004C3D50 File Offset: 0x004C1F50
		public IPlayFlow? InitState
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

		// Token: 0x17009AC1 RID: 39617
		// (get) Token: 0x06022601 RID: 140801 RVA: 0x004C3DB0 File Offset: 0x004C1FB0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022602 RID: 140802 RVA: 0x004C3DEC File Offset: 0x004C1FEC
		public static Offset<IFlowComponent> CreateIFlowComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPlayFlow> InitStateOffset = default(Offset<IPlayFlow>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFlowComponent.AddInitState(builder, InitStateOffset);
			IFlowComponent.AddNullMask(builder, NullMask);
			IFlowComponent.AddDisabled(builder, Disabled);
			return IFlowComponent.EndIFlowComponent(builder);
		}

		// Token: 0x06022603 RID: 140803 RVA: 0x004C3E10 File Offset: 0x004C2010
		public static void StartIFlowComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022604 RID: 140804 RVA: 0x004C3E19 File Offset: 0x004C2019
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022605 RID: 140805 RVA: 0x004C3E24 File Offset: 0x004C2024
		public static void AddInitState(FlatBufferBuilder builder, Offset<IPlayFlow> initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x06022606 RID: 140806 RVA: 0x004C3E34 File Offset: 0x004C2034
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022607 RID: 140807 RVA: 0x004C3E3F File Offset: 0x004C203F
		public static Offset<IFlowComponent> EndIFlowComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFlowComponent>(builder.EndTable());
		}

		// Token: 0x06022608 RID: 140808 RVA: 0x004C3E4C File Offset: 0x004C204C
		public IFlowComponentT UnPack()
		{
			IFlowComponentT flowComponentT = new IFlowComponentT();
			this.UnPackTo(flowComponentT);
			return flowComponentT;
		}

		// Token: 0x06022609 RID: 140809 RVA: 0x004C3E68 File Offset: 0x004C2068
		public void UnPackTo(IFlowComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitState = ((this.InitState != null) ? this.InitState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602260A RID: 140810 RVA: 0x004C3EBC File Offset: 0x004C20BC
		public static Offset<IFlowComponent> Pack(FlatBufferBuilder builder, IFlowComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowComponent>);
			}
			Offset<IPlayFlow> initStateOffset = (_o.InitState == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.InitState);
			return IFlowComponent.CreateIFlowComponent(builder, _o.Disabled, initStateOffset, _o.NullMask);
		}

		// Token: 0x0400E3DB RID: 58331
		private Table __p;
	}
}
