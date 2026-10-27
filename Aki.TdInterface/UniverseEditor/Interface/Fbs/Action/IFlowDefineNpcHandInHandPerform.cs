using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006807 RID: 26631
	public struct IFlowDefineNpcHandInHandPerform : IFlatbufferObject
	{
		// Token: 0x1700C5A3 RID: 50595
		// (get) Token: 0x0602E5F2 RID: 189938 RVA: 0x0065440E File Offset: 0x0065260E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5F3 RID: 189939 RVA: 0x0065441B File Offset: 0x0065261B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5F4 RID: 189940 RVA: 0x00654424 File Offset: 0x00652624
		public static IFlowDefineNpcHandInHandPerform GetRootAsIFlowDefineNpcHandInHandPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcHandInHandPerform.GetRootAsIFlowDefineNpcHandInHandPerform(_bb, default(IFlowDefineNpcHandInHandPerform));
		}

		// Token: 0x0602E5F5 RID: 189941 RVA: 0x00654440 File Offset: 0x00652640
		public static IFlowDefineNpcHandInHandPerform GetRootAsIFlowDefineNpcHandInHandPerform(ByteBuffer _bb, IFlowDefineNpcHandInHandPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5F6 RID: 189942 RVA: 0x0065445D File Offset: 0x0065265D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5F7 RID: 189943 RVA: 0x0065446C File Offset: 0x0065266C
		public IFlowDefineNpcHandInHandPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5A4 RID: 50596
		// (get) Token: 0x0602E5F8 RID: 189944 RVA: 0x0065447C File Offset: 0x0065267C
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

		// Token: 0x1700C5A5 RID: 50597
		// (get) Token: 0x0602E5F9 RID: 189945 RVA: 0x006544B8 File Offset: 0x006526B8
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

		// Token: 0x0602E5FA RID: 189946 RVA: 0x006544EF File Offset: 0x006526EF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E5FB RID: 189947 RVA: 0x006544FE File Offset: 0x006526FE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E5FC RID: 189948 RVA: 0x0065450C File Offset: 0x0065270C
		public static Offset<IFlowDefineNpcHandInHandPerform> CreateIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcHandInHandPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcHandInHandPerform.AddType(builder, Type);
			return IFlowDefineNpcHandInHandPerform.EndIFlowDefineNpcHandInHandPerform(builder);
		}

		// Token: 0x0602E5FD RID: 189949 RVA: 0x00654529 File Offset: 0x00652729
		public static void StartIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E5FE RID: 189950 RVA: 0x00654532 File Offset: 0x00652732
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E5FF RID: 189951 RVA: 0x0065453D File Offset: 0x0065273D
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0602E600 RID: 189952 RVA: 0x0065454D File Offset: 0x0065274D
		public static Offset<IFlowDefineNpcHandInHandPerform> EndIFlowDefineNpcHandInHandPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcHandInHandPerform>(builder.EndTable());
		}

		// Token: 0x0602E601 RID: 189953 RVA: 0x0065455C File Offset: 0x0065275C
		public IFlowDefineNpcHandInHandPerformT UnPack()
		{
			IFlowDefineNpcHandInHandPerformT flowDefineNpcHandInHandPerformT = new IFlowDefineNpcHandInHandPerformT();
			this.UnPackTo(flowDefineNpcHandInHandPerformT);
			return flowDefineNpcHandInHandPerformT;
		}

		// Token: 0x0602E602 RID: 189954 RVA: 0x00654577 File Offset: 0x00652777
		public void UnPackTo(IFlowDefineNpcHandInHandPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0602E603 RID: 189955 RVA: 0x00654594 File Offset: 0x00652794
		public static Offset<IFlowDefineNpcHandInHandPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcHandInHandPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcHandInHandPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcHandInHandPerform.CreateIFlowDefineNpcHandInHandPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04010F2B RID: 69419
		private Table __p;
	}
}
