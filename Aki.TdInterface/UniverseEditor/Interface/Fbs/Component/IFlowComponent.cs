using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E4 RID: 22500
	public struct IFlowComponent : IFlatbufferObject
	{
		// Token: 0x1700A2BC RID: 41660
		// (get) Token: 0x06024593 RID: 148883 RVA: 0x004FE812 File Offset: 0x004FCA12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024594 RID: 148884 RVA: 0x004FE81F File Offset: 0x004FCA1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024595 RID: 148885 RVA: 0x004FE828 File Offset: 0x004FCA28
		public static IFlowComponent GetRootAsIFlowComponent(ByteBuffer _bb)
		{
			return IFlowComponent.GetRootAsIFlowComponent(_bb, default(IFlowComponent));
		}

		// Token: 0x06024596 RID: 148886 RVA: 0x004FE844 File Offset: 0x004FCA44
		public static IFlowComponent GetRootAsIFlowComponent(ByteBuffer _bb, IFlowComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024597 RID: 148887 RVA: 0x004FE861 File Offset: 0x004FCA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024598 RID: 148888 RVA: 0x004FE870 File Offset: 0x004FCA70
		public IFlowComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2BD RID: 41661
		// (get) Token: 0x06024599 RID: 148889 RVA: 0x004FE880 File Offset: 0x004FCA80
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2BE RID: 41662
		// (get) Token: 0x0602459A RID: 148890 RVA: 0x004FE8C0 File Offset: 0x004FCAC0
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

		// Token: 0x1700A2BF RID: 41663
		// (get) Token: 0x0602459B RID: 148891 RVA: 0x004FE920 File Offset: 0x004FCB20
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

		// Token: 0x0602459C RID: 148892 RVA: 0x004FE95C File Offset: 0x004FCB5C
		public static Offset<IFlowComponent> CreateIFlowComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPlayFlow> InitStateOffset = default(Offset<IPlayFlow>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFlowComponent.AddInitState(builder, InitStateOffset);
			IFlowComponent.AddNullMask(builder, NullMask);
			IFlowComponent.AddDisabled(builder, Disabled);
			return IFlowComponent.EndIFlowComponent(builder);
		}

		// Token: 0x0602459D RID: 148893 RVA: 0x004FE980 File Offset: 0x004FCB80
		public static void StartIFlowComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602459E RID: 148894 RVA: 0x004FE989 File Offset: 0x004FCB89
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602459F RID: 148895 RVA: 0x004FE994 File Offset: 0x004FCB94
		public static void AddInitState(FlatBufferBuilder builder, Offset<IPlayFlow> initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x060245A0 RID: 148896 RVA: 0x004FE9A4 File Offset: 0x004FCBA4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060245A1 RID: 148897 RVA: 0x004FE9AF File Offset: 0x004FCBAF
		public static Offset<IFlowComponent> EndIFlowComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFlowComponent>(builder.EndTable());
		}

		// Token: 0x060245A2 RID: 148898 RVA: 0x004FE9BC File Offset: 0x004FCBBC
		public IFlowComponentT UnPack()
		{
			IFlowComponentT flowComponentT = new IFlowComponentT();
			this.UnPackTo(flowComponentT);
			return flowComponentT;
		}

		// Token: 0x060245A3 RID: 148899 RVA: 0x004FE9D8 File Offset: 0x004FCBD8
		public void UnPackTo(IFlowComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InitState = ((this.InitState != null) ? this.InitState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060245A4 RID: 148900 RVA: 0x004FEA2C File Offset: 0x004FCC2C
		public static Offset<IFlowComponent> Pack(FlatBufferBuilder builder, IFlowComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowComponent>);
			}
			Offset<IPlayFlow> initStateOffset = (_o.InitState == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.InitState);
			return IFlowComponent.CreateIFlowComponent(builder, _o.Disabled, initStateOffset, _o.NullMask);
		}

		// Token: 0x0400EFE2 RID: 61410
		private Table __p;
	}
}
