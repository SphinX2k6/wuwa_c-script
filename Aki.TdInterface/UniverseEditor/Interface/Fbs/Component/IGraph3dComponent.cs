using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005306 RID: 21254
	public struct IGraph3dComponent : IFlatbufferObject
	{
		// Token: 0x17009C0E RID: 39950
		// (get) Token: 0x06022B78 RID: 142200 RVA: 0x004CF9D2 File Offset: 0x004CDBD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B79 RID: 142201 RVA: 0x004CF9DF File Offset: 0x004CDBDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B7A RID: 142202 RVA: 0x004CF9E8 File Offset: 0x004CDBE8
		public static IGraph3dComponent GetRootAsIGraph3dComponent(ByteBuffer _bb)
		{
			return IGraph3dComponent.GetRootAsIGraph3dComponent(_bb, default(IGraph3dComponent));
		}

		// Token: 0x06022B7B RID: 142203 RVA: 0x004CFA04 File Offset: 0x004CDC04
		public static IGraph3dComponent GetRootAsIGraph3dComponent(ByteBuffer _bb, IGraph3dComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B7C RID: 142204 RVA: 0x004CFA21 File Offset: 0x004CDC21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B7D RID: 142205 RVA: 0x004CFA30 File Offset: 0x004CDC30
		public IGraph3dComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C0F RID: 39951
		// (get) Token: 0x06022B7E RID: 142206 RVA: 0x004CFA40 File Offset: 0x004CDC40
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009C10 RID: 39952
		// (get) Token: 0x06022B7F RID: 142207 RVA: 0x004CFA80 File Offset: 0x004CDC80
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

		// Token: 0x17009C11 RID: 39953
		// (get) Token: 0x06022B80 RID: 142208 RVA: 0x004CFAE0 File Offset: 0x004CDCE0
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

		// Token: 0x06022B81 RID: 142209 RVA: 0x004CFB1C File Offset: 0x004CDD1C
		public static Offset<IGraph3dComponent> CreateIGraph3dComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IGraph3dNormal> GraphConfigOffset = default(Offset<IGraph3dNormal>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGraph3dComponent.AddGraphConfig(builder, GraphConfigOffset);
			IGraph3dComponent.AddNullMask(builder, NullMask);
			IGraph3dComponent.AddDisabled(builder, Disabled);
			return IGraph3dComponent.EndIGraph3dComponent(builder);
		}

		// Token: 0x06022B82 RID: 142210 RVA: 0x004CFB40 File Offset: 0x004CDD40
		public static void StartIGraph3dComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022B83 RID: 142211 RVA: 0x004CFB49 File Offset: 0x004CDD49
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022B84 RID: 142212 RVA: 0x004CFB54 File Offset: 0x004CDD54
		public static void AddGraphConfig(FlatBufferBuilder builder, Offset<IGraph3dNormal> graphConfigOffset)
		{
			builder.AddOffset(1, graphConfigOffset.Value, 0);
		}

		// Token: 0x06022B85 RID: 142213 RVA: 0x004CFB64 File Offset: 0x004CDD64
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022B86 RID: 142214 RVA: 0x004CFB6F File Offset: 0x004CDD6F
		public static Offset<IGraph3dComponent> EndIGraph3dComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dComponent>(builder.EndTable());
		}

		// Token: 0x06022B87 RID: 142215 RVA: 0x004CFB7C File Offset: 0x004CDD7C
		public IGraph3dComponentT UnPack()
		{
			IGraph3dComponentT graph3dComponentT = new IGraph3dComponentT();
			this.UnPackTo(graph3dComponentT);
			return graph3dComponentT;
		}

		// Token: 0x06022B88 RID: 142216 RVA: 0x004CFB98 File Offset: 0x004CDD98
		public void UnPackTo(IGraph3dComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.GraphConfig = ((this.GraphConfig != null) ? this.GraphConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022B89 RID: 142217 RVA: 0x004CFBEC File Offset: 0x004CDDEC
		public static Offset<IGraph3dComponent> Pack(FlatBufferBuilder builder, IGraph3dComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dComponent>);
			}
			Offset<IGraph3dNormal> graphConfigOffset = (_o.GraphConfig == null) ? default(Offset<IGraph3dNormal>) : IGraph3dNormal.Pack(builder, _o.GraphConfig);
			return IGraph3dComponent.CreateIGraph3dComponent(builder, _o.Disabled, graphConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E4B8 RID: 58552
		private Table __p;
	}
}
