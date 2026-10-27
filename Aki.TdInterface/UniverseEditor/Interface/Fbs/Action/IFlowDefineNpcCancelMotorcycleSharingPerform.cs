using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F8 RID: 26616
	public struct IFlowDefineNpcCancelMotorcycleSharingPerform : IFlatbufferObject
	{
		// Token: 0x1700C591 RID: 50577
		// (get) Token: 0x0602E583 RID: 189827 RVA: 0x00653818 File Offset: 0x00651A18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E584 RID: 189828 RVA: 0x00653825 File Offset: 0x00651A25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E585 RID: 189829 RVA: 0x0065382C File Offset: 0x00651A2C
		public static IFlowDefineNpcCancelMotorcycleSharingPerform GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcCancelMotorcycleSharingPerform.GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(_bb, default(IFlowDefineNpcCancelMotorcycleSharingPerform));
		}

		// Token: 0x0602E586 RID: 189830 RVA: 0x00653848 File Offset: 0x00651A48
		public static IFlowDefineNpcCancelMotorcycleSharingPerform GetRootAsIFlowDefineNpcCancelMotorcycleSharingPerform(ByteBuffer _bb, IFlowDefineNpcCancelMotorcycleSharingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E587 RID: 189831 RVA: 0x00653865 File Offset: 0x00651A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E588 RID: 189832 RVA: 0x00653874 File Offset: 0x00651A74
		public IFlowDefineNpcCancelMotorcycleSharingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C592 RID: 50578
		// (get) Token: 0x0602E589 RID: 189833 RVA: 0x00653884 File Offset: 0x00651A84
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

		// Token: 0x1700C593 RID: 50579
		// (get) Token: 0x0602E58A RID: 189834 RVA: 0x006538C0 File Offset: 0x00651AC0
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

		// Token: 0x0602E58B RID: 189835 RVA: 0x006538F7 File Offset: 0x00651AF7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E58C RID: 189836 RVA: 0x00653906 File Offset: 0x00651B06
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E58D RID: 189837 RVA: 0x00653914 File Offset: 0x00651B14
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> CreateIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcCancelMotorcycleSharingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcCancelMotorcycleSharingPerform.AddType(builder, Type);
			return IFlowDefineNpcCancelMotorcycleSharingPerform.EndIFlowDefineNpcCancelMotorcycleSharingPerform(builder);
		}

		// Token: 0x0602E58E RID: 189838 RVA: 0x00653931 File Offset: 0x00651B31
		public static void StartIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E58F RID: 189839 RVA: 0x0065393A File Offset: 0x00651B3A
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E590 RID: 189840 RVA: 0x00653945 File Offset: 0x00651B45
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0602E591 RID: 189841 RVA: 0x00653955 File Offset: 0x00651B55
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> EndIFlowDefineNpcCancelMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcCancelMotorcycleSharingPerform>(builder.EndTable());
		}

		// Token: 0x0602E592 RID: 189842 RVA: 0x00653964 File Offset: 0x00651B64
		public IFlowDefineNpcCancelMotorcycleSharingPerformT UnPack()
		{
			IFlowDefineNpcCancelMotorcycleSharingPerformT flowDefineNpcCancelMotorcycleSharingPerformT = new IFlowDefineNpcCancelMotorcycleSharingPerformT();
			this.UnPackTo(flowDefineNpcCancelMotorcycleSharingPerformT);
			return flowDefineNpcCancelMotorcycleSharingPerformT;
		}

		// Token: 0x0602E593 RID: 189843 RVA: 0x0065397F File Offset: 0x00651B7F
		public void UnPackTo(IFlowDefineNpcCancelMotorcycleSharingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0602E594 RID: 189844 RVA: 0x0065399C File Offset: 0x00651B9C
		public static Offset<IFlowDefineNpcCancelMotorcycleSharingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcCancelMotorcycleSharingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcCancelMotorcycleSharingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcCancelMotorcycleSharingPerform.CreateIFlowDefineNpcCancelMotorcycleSharingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04010F17 RID: 69399
		private Table __p;
	}
}
