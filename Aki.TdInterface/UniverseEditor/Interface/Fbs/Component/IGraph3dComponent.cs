using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588C RID: 22668
	public struct IGraph3dComponent : IFlatbufferObject
	{
		// Token: 0x1700A446 RID: 42054
		// (get) Token: 0x06024C2C RID: 150572 RVA: 0x0050C8A6 File Offset: 0x0050AAA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C2D RID: 150573 RVA: 0x0050C8B3 File Offset: 0x0050AAB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C2E RID: 150574 RVA: 0x0050C8BC File Offset: 0x0050AABC
		public static IGraph3dComponent GetRootAsIGraph3dComponent(ByteBuffer _bb)
		{
			return IGraph3dComponent.GetRootAsIGraph3dComponent(_bb, default(IGraph3dComponent));
		}

		// Token: 0x06024C2F RID: 150575 RVA: 0x0050C8D8 File Offset: 0x0050AAD8
		public static IGraph3dComponent GetRootAsIGraph3dComponent(ByteBuffer _bb, IGraph3dComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C30 RID: 150576 RVA: 0x0050C8F5 File Offset: 0x0050AAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C31 RID: 150577 RVA: 0x0050C904 File Offset: 0x0050AB04
		public IGraph3dComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A447 RID: 42055
		// (get) Token: 0x06024C32 RID: 150578 RVA: 0x0050C914 File Offset: 0x0050AB14
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A448 RID: 42056
		// (get) Token: 0x06024C33 RID: 150579 RVA: 0x0050C954 File Offset: 0x0050AB54
		public IGraph3dNormal? GraphConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGraph3dNormal?(default(IGraph3dNormal).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A449 RID: 42057
		// (get) Token: 0x06024C34 RID: 150580 RVA: 0x0050C9B4 File Offset: 0x0050ABB4
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

		// Token: 0x06024C35 RID: 150581 RVA: 0x0050C9F0 File Offset: 0x0050ABF0
		public static Offset<IGraph3dComponent> CreateIGraph3dComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IGraph3dNormal> GraphConfigOffset = default(Offset<IGraph3dNormal>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGraph3dComponent.AddGraphConfig(builder, GraphConfigOffset);
			IGraph3dComponent.AddNullMask(builder, NullMask);
			IGraph3dComponent.AddDisabled(builder, Disabled);
			return IGraph3dComponent.EndIGraph3dComponent(builder);
		}

		// Token: 0x06024C36 RID: 150582 RVA: 0x0050CA14 File Offset: 0x0050AC14
		public static void StartIGraph3dComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024C37 RID: 150583 RVA: 0x0050CA1D File Offset: 0x0050AC1D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024C38 RID: 150584 RVA: 0x0050CA28 File Offset: 0x0050AC28
		public static void AddGraphConfig(FlatBufferBuilder builder, Offset<IGraph3dNormal> graphConfigOffset)
		{
			builder.AddOffset(1, graphConfigOffset.Value, 0);
		}

		// Token: 0x06024C39 RID: 150585 RVA: 0x0050CA38 File Offset: 0x0050AC38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024C3A RID: 150586 RVA: 0x0050CA43 File Offset: 0x0050AC43
		public static Offset<IGraph3dComponent> EndIGraph3dComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dComponent>(builder.EndTable());
		}

		// Token: 0x06024C3B RID: 150587 RVA: 0x0050CA50 File Offset: 0x0050AC50
		public IGraph3dComponentT UnPack()
		{
			IGraph3dComponentT graph3dComponentT = new IGraph3dComponentT();
			this.UnPackTo(graph3dComponentT);
			return graph3dComponentT;
		}

		// Token: 0x06024C3C RID: 150588 RVA: 0x0050CA6C File Offset: 0x0050AC6C
		public void UnPackTo(IGraph3dComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.GraphConfig = ((this.GraphConfig != null) ? this.GraphConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024C3D RID: 150589 RVA: 0x0050CAC0 File Offset: 0x0050ACC0
		public static Offset<IGraph3dComponent> Pack(FlatBufferBuilder builder, IGraph3dComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dComponent>);
			}
			Offset<IGraph3dNormal> graphConfigOffset = (_o.GraphConfig == null) ? default(Offset<IGraph3dNormal>) : IGraph3dNormal.Pack(builder, _o.GraphConfig);
			return IGraph3dComponent.CreateIGraph3dComponent(builder, _o.Disabled, graphConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F0E8 RID: 61672
		private Table __p;
	}
}
