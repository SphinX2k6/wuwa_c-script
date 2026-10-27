using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749C RID: 29852
	public struct IUiAnimConfig : IFlatbufferObject
	{
		// Token: 0x1700E2A9 RID: 58025
		// (get) Token: 0x06036436 RID: 222262 RVA: 0x0076064A File Offset: 0x0075E84A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036437 RID: 222263 RVA: 0x00760657 File Offset: 0x0075E857
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036438 RID: 222264 RVA: 0x00760660 File Offset: 0x0075E860
		public static IUiAnimConfig GetRootAsIUiAnimConfig(ByteBuffer _bb)
		{
			return IUiAnimConfig.GetRootAsIUiAnimConfig(_bb, default(IUiAnimConfig));
		}

		// Token: 0x06036439 RID: 222265 RVA: 0x0076067C File Offset: 0x0075E87C
		public static IUiAnimConfig GetRootAsIUiAnimConfig(ByteBuffer _bb, IUiAnimConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603643A RID: 222266 RVA: 0x00760699 File Offset: 0x0075E899
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603643B RID: 222267 RVA: 0x007606A8 File Offset: 0x0075E8A8
		public IUiAnimConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2AA RID: 58026
		// (get) Token: 0x0603643C RID: 222268 RVA: 0x007606B8 File Offset: 0x0075E8B8
		public string UiStartAnimName
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

		// Token: 0x0603643D RID: 222269 RVA: 0x007606EF File Offset: 0x0075E8EF
		public Span<byte> GetUiStartAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603643E RID: 222270 RVA: 0x007606FE File Offset: 0x0075E8FE
		public byte[] GetUiStartAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E2AB RID: 58027
		// (get) Token: 0x0603643F RID: 222271 RVA: 0x0076070C File Offset: 0x0075E90C
		public string UiEndAnimName
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

		// Token: 0x06036440 RID: 222272 RVA: 0x00760743 File Offset: 0x0075E943
		public Span<byte> GetUiEndAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036441 RID: 222273 RVA: 0x00760752 File Offset: 0x0075E952
		public byte[] GetUiEndAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06036442 RID: 222274 RVA: 0x00760760 File Offset: 0x0075E960
		public static Offset<IUiAnimConfig> CreateIUiAnimConfig(FlatBufferBuilder builder, StringOffset UiStartAnimNameOffset = default(StringOffset), StringOffset UiEndAnimNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IUiAnimConfig.AddUiEndAnimName(builder, UiEndAnimNameOffset);
			IUiAnimConfig.AddUiStartAnimName(builder, UiStartAnimNameOffset);
			return IUiAnimConfig.EndIUiAnimConfig(builder);
		}

		// Token: 0x06036443 RID: 222275 RVA: 0x0076077D File Offset: 0x0075E97D
		public static void StartIUiAnimConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036444 RID: 222276 RVA: 0x00760786 File Offset: 0x0075E986
		public static void AddUiStartAnimName(FlatBufferBuilder builder, StringOffset uiStartAnimNameOffset)
		{
			builder.AddOffset(0, uiStartAnimNameOffset.Value, 0);
		}

		// Token: 0x06036445 RID: 222277 RVA: 0x00760796 File Offset: 0x0075E996
		public static void AddUiEndAnimName(FlatBufferBuilder builder, StringOffset uiEndAnimNameOffset)
		{
			builder.AddOffset(1, uiEndAnimNameOffset.Value, 0);
		}

		// Token: 0x06036446 RID: 222278 RVA: 0x007607A6 File Offset: 0x0075E9A6
		public static Offset<IUiAnimConfig> EndIUiAnimConfig(FlatBufferBuilder builder)
		{
			return new Offset<IUiAnimConfig>(builder.EndTable());
		}

		// Token: 0x06036447 RID: 222279 RVA: 0x007607B4 File Offset: 0x0075E9B4
		public IUiAnimConfigT UnPack()
		{
			IUiAnimConfigT uiAnimConfigT = new IUiAnimConfigT();
			this.UnPackTo(uiAnimConfigT);
			return uiAnimConfigT;
		}

		// Token: 0x06036448 RID: 222280 RVA: 0x007607CF File Offset: 0x0075E9CF
		public void UnPackTo(IUiAnimConfigT _o)
		{
			_o.UiStartAnimName = this.UiStartAnimName;
			_o.UiEndAnimName = this.UiEndAnimName;
		}

		// Token: 0x06036449 RID: 222281 RVA: 0x007607EC File Offset: 0x0075E9EC
		public static Offset<IUiAnimConfig> Pack(FlatBufferBuilder builder, IUiAnimConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUiAnimConfig>);
			}
			StringOffset uiStartAnimNameOffset = (_o.UiStartAnimName == null) ? default(StringOffset) : builder.CreateString(_o.UiStartAnimName);
			StringOffset uiEndAnimNameOffset = (_o.UiEndAnimName == null) ? default(StringOffset) : builder.CreateString(_o.UiEndAnimName);
			return IUiAnimConfig.CreateIUiAnimConfig(builder, uiStartAnimNameOffset, uiEndAnimNameOffset);
		}

		// Token: 0x0401233A RID: 74554
		private Table __p;
	}
}
