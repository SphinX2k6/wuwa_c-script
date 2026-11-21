using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E78 RID: 28280
	public struct IFlowDefineNpcCancelMotorcycleSharingPerform : IFlatbufferObject
	{
		// Token: 0x1700CF47 RID: 53063
		// (get) Token: 0x06030DC9 RID: 200137 RVA: 0x006A0F5C File Offset: 0x0069F15C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030DCA RID: 200138 RVA: 0x006A0F69 File Offset: 0x0069F169
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030DCB RID: 200139 RVA: 0x006A0F70 File Offset: 0x0069F170
		public static IFlowDefineNpcCancelMotorcycleSharingPerform GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcCancelMotorcycleSharingPerform.GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(_bb, default(IFlowDefineNpcCancelMotorcycleSharingPerform));
		}

		// Token: 0x06030DCC RID: 200140 RVA: 0x006A0F8C File Offset: 0x0069F18C
		public static IFlowDefineNpcCancelMotorcycleSharingPerform GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(ByteBuffer _bb, IFlowDefineNpcCancelMotorcycleSharingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030DCD RID: 200141 RVA: 0x006A0FA9 File Offset: 0x0069F1A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030DCE RID: 200142 RVA: 0x006A0FB8 File Offset: 0x0069F1B8
		public IFlowDefineNpcCancelMotorcycleSharingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF48 RID: 53064
		// (get) Token: 0x06030DCF RID: 200143 RVA: 0x006A0FC8 File Offset: 0x0069F1C8
		public ENpcGroupPerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return (ENpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF49 RID: 53065
		// (get) Token: 0x06030DD0 RID: 200144 RVA: 0x006A1004 File Offset: 0x0069F204
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030DD1 RID: 200145 RVA: 0x006A103B File Offset: 0x0069F23B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030DD2 RID: 200146 RVA: 0x006A104A File Offset: 0x0069F24A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030DD3 RID: 200147 RVA: 0x006A1058 File Offset: 0x0069F258
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> CreateIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcCancelMotorcycleSharingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcCancelMotorcycleSharingPerform.AddType(builder, Type);
			return IFlowDefineNpcCancelMotorcycleSharingPerform.EndIFlowDefineNpcCancelMotorcycleSharingPerform(builder);
		}

		// Token: 0x06030DD4 RID: 200148 RVA: 0x006A1075 File Offset: 0x0069F275
		public static void StartIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030DD5 RID: 200149 RVA: 0x006A107E File Offset: 0x0069F27E
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030DD6 RID: 200150 RVA: 0x006A1089 File Offset: 0x0069F289
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06030DD7 RID: 200151 RVA: 0x006A1099 File Offset: 0x0069F299
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> EndIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcCancelMotorcycleSharingPerform>(builder.EndTable());
		}

		// Token: 0x06030DD8 RID: 200152 RVA: 0x006A10A8 File Offset: 0x0069F2A8
		public IFlowDefineNpcCancelMotorcycleSharingPerformT UnPack()
		{
			IFlowDefineNpcCancelMotorcycleSharingPerformT flowDefineNpcCancelMotorcycleSharingPerformT = new IFlowDefineNpcCancelMotorcycleSharingPerformT();
			this.UnPackTo(flowDefineNpcCancelMotorcycleSharingPerformT);
			return flowDefineNpcCancelMotorcycleSharingPerformT;
		}

		// Token: 0x06030DD9 RID: 200153 RVA: 0x006A10C3 File Offset: 0x0069F2C3
		public void UnPackTo(IFlowDefineNpcCancelMotorcycleSharingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06030DDA RID: 200154 RVA: 0x006A10E0 File Offset: 0x0069F2E0
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcCancelMotorcycleSharingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcCancelMotorcycleSharingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcCancelMotorcycleSharingPerform.CreateIFlowDefineNpcCancelMotorcycleSharingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04011D49 RID: 73033
		private Table __p;
	}
}
