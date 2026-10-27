using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680A RID: 26634
	public struct IFlowDefineNpcMotorcycleSharingPerform : IFlatbufferObject
	{
		// Token: 0x1700C5A8 RID: 50600
		// (get) Token: 0x0602E60A RID: 189962 RVA: 0x00654641 File Offset: 0x00652841
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E60B RID: 189963 RVA: 0x0065464E File Offset: 0x0065284E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E60C RID: 189964 RVA: 0x00654658 File Offset: 0x00652858
		public static IFlowDefineNpcMotorcycleSharingPerform GetRootAsIFlowDefineNpcMotorcycleSharingPerform(ByteBuffer _bb)
		{
			return IFlowDefineNpcMotorcycleSharingPerform.GetRootAsIFlowDefineNpcMotorcycleSharingPerform(_bb, default(IFlowDefineNpcMotorcycleSharingPerform));
		}

		// Token: 0x0602E60D RID: 189965 RVA: 0x00654674 File Offset: 0x00652874
		public static IFlowDefineNpcMotorcycleSharingPerform GetRootAsIFlowDefineNpcMotorcycleSharingPerform(ByteBuffer _bb, IFlowDefineNpcMotorcycleSharingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E60E RID: 189966 RVA: 0x00654691 File Offset: 0x00652891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E60F RID: 189967 RVA: 0x006546A0 File Offset: 0x006528A0
		public IFlowDefineNpcMotorcycleSharingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5A9 RID: 50601
		// (get) Token: 0x0602E610 RID: 189968 RVA: 0x006546B0 File Offset: 0x006528B0
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

		// Token: 0x1700C5AA RID: 50602
		// (get) Token: 0x0602E611 RID: 189969 RVA: 0x006546EC File Offset: 0x006528EC
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

		// Token: 0x0602E612 RID: 189970 RVA: 0x00654723 File Offset: 0x00652923
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E613 RID: 189971 RVA: 0x00654732 File Offset: 0x00652932
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E614 RID: 189972 RVA: 0x00654740 File Offset: 0x00652940
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> CreateIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder, ENpcGroupPerformType Type = ENpcGroupPerformType.HandInHand, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFlowDefineNpcMotorcycleSharingPerform.AddKey(builder, KeyOffset);
			IFlowDefineNpcMotorcycleSharingPerform.AddType(builder, Type);
			return IFlowDefineNpcMotorcycleSharingPerform.EndIFlowDefineNpcMotorcycleSharingPerform(builder);
		}

		// Token: 0x0602E615 RID: 189973 RVA: 0x0065475D File Offset: 0x0065295D
		public static void StartIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E616 RID: 189974 RVA: 0x00654766 File Offset: 0x00652966
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E617 RID: 189975 RVA: 0x00654771 File Offset: 0x00652971
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0602E618 RID: 189976 RVA: 0x00654781 File Offset: 0x00652981
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> EndIFlowDefineNpcMotorcycleSharingPerform(FlatBufferBuilder builder)
		{
			return new Offset<IFlowDefineNpcMotorcycleSharingPerform>(builder.EndTable());
		}

		// Token: 0x0602E619 RID: 189977 RVA: 0x00654790 File Offset: 0x00652990
		public IFlowDefineNpcMotorcycleSharingPerformT UnPack()
		{
			IFlowDefineNpcMotorcycleSharingPerformT flowDefineNpcMotorcycleSharingPerformT = new IFlowDefineNpcMotorcycleSharingPerformT();
			this.UnPackTo(flowDefineNpcMotorcycleSharingPerformT);
			return flowDefineNpcMotorcycleSharingPerformT;
		}

		// Token: 0x0602E61A RID: 189978 RVA: 0x006547AB File Offset: 0x006529AB
		public void UnPackTo(IFlowDefineNpcMotorcycleSharingPerformT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0602E61B RID: 189979 RVA: 0x006547C8 File Offset: 0x006529C8
		public static Offset<IFlowDefineNpcMotorcycleSharingPerform> Pack(FlatBufferBuilder builder, IFlowDefineNpcMotorcycleSharingPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowDefineNpcMotorcycleSharingPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IFlowDefineNpcMotorcycleSharingPerform.CreateIFlowDefineNpcMotorcycleSharingPerform(builder, _o.Type, keyOffset);
		}

		// Token: 0x04010F2E RID: 69422
		private Table __p;
	}
}
