using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004675 RID: 18037
	public struct IOpenBackLoginView : IFlatbufferObject
	{
		// Token: 0x17008016 RID: 32790
		// (get) Token: 0x0601B613 RID: 112147 RVA: 0x003E4568 File Offset: 0x003E2768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B614 RID: 112148 RVA: 0x003E4575 File Offset: 0x003E2775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B615 RID: 112149 RVA: 0x003E457C File Offset: 0x003E277C
		public static IOpenBackLoginView GetRootAsIOpenBackLoginView(ByteBuffer _bb)
		{
			return IOpenBackLoginView.GetRootAsIOpenBackLoginView(_bb, default(IOpenBackLoginView));
		}

		// Token: 0x0601B616 RID: 112150 RVA: 0x003E4598 File Offset: 0x003E2798
		public static IOpenBackLoginView GetRootAsIOpenBackLoginView(ByteBuffer _bb, IOpenBackLoginView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B617 RID: 112151 RVA: 0x003E45B5 File Offset: 0x003E27B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B618 RID: 112152 RVA: 0x003E45C4 File Offset: 0x003E27C4
		public IOpenBackLoginView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008017 RID: 32791
		// (get) Token: 0x0601B619 RID: 112153 RVA: 0x003E45D4 File Offset: 0x003E27D4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008018 RID: 32792
		// (get) Token: 0x0601B61A RID: 112154 RVA: 0x003E4610 File Offset: 0x003E2810
		public string Account
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

		// Token: 0x0601B61B RID: 112155 RVA: 0x003E4647 File Offset: 0x003E2847
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B61C RID: 112156 RVA: 0x003E4656 File Offset: 0x003E2856
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601B61D RID: 112157 RVA: 0x003E4664 File Offset: 0x003E2864
		public static Offset<IOpenBackLoginView> CreateIOpenBackLoginView(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset AccountOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IOpenBackLoginView.AddAccount(builder, AccountOffset);
			IOpenBackLoginView.AddType(builder, Type);
			return IOpenBackLoginView.EndIOpenBackLoginView(builder);
		}

		// Token: 0x0601B61E RID: 112158 RVA: 0x003E4681 File Offset: 0x003E2881
		public static void StartIOpenBackLoginView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B61F RID: 112159 RVA: 0x003E468A File Offset: 0x003E288A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B620 RID: 112160 RVA: 0x003E4695 File Offset: 0x003E2895
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(1, accountOffset.Value, 0);
		}

		// Token: 0x0601B621 RID: 112161 RVA: 0x003E46A5 File Offset: 0x003E28A5
		public static Offset<IOpenBackLoginView> EndIOpenBackLoginView(FlatBufferBuilder builder)
		{
			return new Offset<IOpenBackLoginView>(builder.EndTable());
		}

		// Token: 0x0601B622 RID: 112162 RVA: 0x003E46B4 File Offset: 0x003E28B4
		public IOpenBackLoginViewT UnPack()
		{
			IOpenBackLoginViewT openBackLoginViewT = new IOpenBackLoginViewT();
			this.UnPackTo(openBackLoginViewT);
			return openBackLoginViewT;
		}

		// Token: 0x0601B623 RID: 112163 RVA: 0x003E46CF File Offset: 0x003E28CF
		public void UnPackTo(IOpenBackLoginViewT _o)
		{
			_o.Type = this.Type;
			_o.Account = this.Account;
		}

		// Token: 0x0601B624 RID: 112164 RVA: 0x003E46EC File Offset: 0x003E28EC
		public static Offset<IOpenBackLoginView> Pack(FlatBufferBuilder builder, IOpenBackLoginViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenBackLoginView>);
			}
			StringOffset accountOffset = (_o.Account == null) ? default(StringOffset) : builder.CreateString(_o.Account);
			return IOpenBackLoginView.CreateIOpenBackLoginView(builder, _o.Type, accountOffset);
		}

		// Token: 0x0400C838 RID: 51256
		private Table __p;
	}
}
