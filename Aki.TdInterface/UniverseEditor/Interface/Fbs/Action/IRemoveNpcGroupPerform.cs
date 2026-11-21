using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D3 RID: 30163
	public struct IRemoveNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700DDB8 RID: 56760
		// (get) Token: 0x06034EA2 RID: 216738 RVA: 0x0071C55D File Offset: 0x0071A75D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EA3 RID: 216739 RVA: 0x0071C56A File Offset: 0x0071A76A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EA4 RID: 216740 RVA: 0x0071C574 File Offset: 0x0071A774
		public static IRemoveNpcGroupPerform GetRootAsIRemoveNpcGroupPerform(ByteBuffer _bb)
		{
			return IRemoveNpcGroupPerform.GetRootAsIRemoveNpcGroupPerform(_bb, default(IRemoveNpcGroupPerform));
		}

		// Token: 0x06034EA5 RID: 216741 RVA: 0x0071C590 File Offset: 0x0071A790
		public static IRemoveNpcGroupPerform GetRootAsIRemoveNpcGroupPerform(ByteBuffer _bb, IRemoveNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EA6 RID: 216742 RVA: 0x0071C5AD File Offset: 0x0071A7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EA7 RID: 216743 RVA: 0x0071C5BC File Offset: 0x0071A7BC
		public IRemoveNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDB9 RID: 56761
		// (get) Token: 0x06034EA8 RID: 216744 RVA: 0x0071C5CC File Offset: 0x0071A7CC
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034EA9 RID: 216745 RVA: 0x0071C603 File Offset: 0x0071A803
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034EAA RID: 216746 RVA: 0x0071C612 File Offset: 0x0071A812
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06034EAB RID: 216747 RVA: 0x0071C620 File Offset: 0x0071A820
		public static Offset<IRemoveNpcGroupPerform> CreateIRemoveNpcGroupPerform(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRemoveNpcGroupPerform.AddKey(builder, KeyOffset);
			return IRemoveNpcGroupPerform.EndIRemoveNpcGroupPerform(builder);
		}

		// Token: 0x06034EAC RID: 216748 RVA: 0x0071C636 File Offset: 0x0071A836
		public static void StartIRemoveNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034EAD RID: 216749 RVA: 0x0071C63F File Offset: 0x0071A83F
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06034EAE RID: 216750 RVA: 0x0071C64F File Offset: 0x0071A84F
		public static Offset<IRemoveNpcGroupPerform> EndIRemoveNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x06034EAF RID: 216751 RVA: 0x0071C65C File Offset: 0x0071A85C
		public IRemoveNpcGroupPerformT UnPack()
		{
			IRemoveNpcGroupPerformT removeNpcGroupPerformT = new IRemoveNpcGroupPerformT();
			this.UnPackTo(removeNpcGroupPerformT);
			return removeNpcGroupPerformT;
		}

		// Token: 0x06034EB0 RID: 216752 RVA: 0x0071C677 File Offset: 0x0071A877
		public void UnPackTo(IRemoveNpcGroupPerformT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x06034EB1 RID: 216753 RVA: 0x0071C688 File Offset: 0x0071A888
		public static Offset<IRemoveNpcGroupPerform> Pack(FlatBufferBuilder builder, IRemoveNpcGroupPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveNpcGroupPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IRemoveNpcGroupPerform.CreateIRemoveNpcGroupPerform(builder, keyOffset);
		}

		// Token: 0x040127BA RID: 75706
		private Table __p;
	}
}
