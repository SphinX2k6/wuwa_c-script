using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8A RID: 28298
	public struct IFlowDefineNpcMotorcycleSharingPerform : IFlatbufferObject
	{
		// Token: 0x1700CF5E RID: 53086
		// (get) Token: 0x06030E50 RID: 200272 RVA: 0x006A1D85 File Offset: 0x0069FF85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E51 RID: 200273 RVA: 0x006A1D92 File Offset: 0x0069FF92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E52 RID: 200274 RVA: 0x006A1D9C File Offset: 0x0069FF9C
		public static IFlowDefineNpcMotorcycleSharingPerform GetRootAsIFlowDefineNpcMotorcycleSharingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcMotorcycleSharingPerform.GetRootAsIFlowDefineNpcMotorcycleSharingPerform(_bb, default(IFlowDefineNpcMotorcycleSharingPerform));
		}

		// Token: 0x06030E53 RID: 200275 RVA: 0x006A1DB8 File Offset: 0x0069FFB8
		public static IFlowDefineNpcMotorcycleSharingPerform GetRootAsIFlowDefineNpcMotorcycleSharingPerform(ByteBuffer _bb, IFlowDefineNpcMotorcycleSharingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E54 RID: 200276 RVA: 0x006A1DD5 File Offset: 0x0069FFD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E55 RID: 200277 RVA: 0x006A1DE4 File Offset: 0x0069FFE4
		public IFlowDefineNpcMotorcycleSharingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF5F RID: 53087
		// (get) Token: 0x06030E56 RID: 200278 RVA: 0x006A1DF4 File Offset: 0x0069FFF4
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

		// Token: 0x1700CF60 RID: 53088
		// (get) Token: 0x06030E57 RID: 200279 RVA: 0x006A1E30 File Offset: 0x006A0030
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

		// Token: 0x06030E58 RID: 200280 RVA: 0x006A1E67 File Offset: 0x006A0067
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030E59 RID: 200281 RVA: 0x006A1E76 File Offset: 0x006A0076
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030E5A RID: 200282 RVA: 0x006A1E84 File Offset: 0x006A0084
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> CreateIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcMotorcycleSharingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcMotorcycleSharingPerform.AddType(builder, Type);
			return IFlowDefineNpcMotorcycleSharingPerform.EndIFlowDefineNpcMotorcycleSharingPerform(builder);
		}

		// Token: 0x06030E5B RID: 200283 RVA: 0x006A1EA1 File Offset: 0x006A00A1
		public static void StartIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030E5C RID: 200284 RVA: 0x006A1EAA File Offset: 0x006A00AA
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E5D RID: 200285 RVA: 0x006A1EB5 File Offset: 0x006A00B5
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06030E5E RID: 200286 RVA: 0x006A1EC5 File Offset: 0x006A00C5
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> EndIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcMotorcycleSharingPerform>(builder.EndTable());
		}

		// Token: 0x06030E5F RID: 200287 RVA: 0x006A1ED4 File Offset: 0x006A00D4
		public IFlowDefineNpcMotorcycleSharingPerformT UnPack()
		{
			IFlowDefineNpcMotorcycleSharingPerformT flowDefineNpcMotorcycleSharingPerformT = new IFlowDefineNpcMotorcycleSharingPerformT();
			this.UnPackTo(flowDefineNpcMotorcycleSharingPerformT);
			return flowDefineNpcMotorcycleSharingPerformT;
		}

		// Token: 0x06030E60 RID: 200288 RVA: 0x006A1EEF File Offset: 0x006A00EF
		public void UnPackTo(IFlowDefineNpcMotorcycleSharingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x06030E61 RID: 200289 RVA: 0x006A1F0C File Offset: 0x006A010C
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcMotorcycleSharingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcMotorcycleSharingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcMotorcycleSharingPerform.CreateIFlowDefineNpcMotorcycleSharingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04011D60 RID: 73056
		private Table __p;
	}
}
