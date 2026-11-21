using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C92 RID: 31890
	public struct IUiAnimConfig : IFlatbufferObject
	{
		// Token: 0x1700EECD RID: 61133
		// (get) Token: 0x06039839 RID: 235577 RVA: 0x007C3606 File Offset: 0x007C1806
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603983A RID: 235578 RVA: 0x007C3613 File Offset: 0x007C1813
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603983B RID: 235579 RVA: 0x007C361C File Offset: 0x007C181C
		public static IUiAnimConfig GetRootAsIUiAnimConfig(ByteBuffer _bb)
		{
			return IUiAnimConfig.GetRootAsIUiAnimConfig(_bb, default(IUiAnimConfig));
		}

		// Token: 0x0603983C RID: 235580 RVA: 0x007C3638 File Offset: 0x007C1838
		public static IUiAnimConfig GetRootAsIUiAnimConfig(ByteBuffer _bb, IUiAnimConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603983D RID: 235581 RVA: 0x007C3655 File Offset: 0x007C1855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603983E RID: 235582 RVA: 0x007C3664 File Offset: 0x007C1864
		public IUiAnimConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EECE RID: 61134
		// (get) Token: 0x0603983F RID: 235583 RVA: 0x007C3674 File Offset: 0x007C1874
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

		// Token: 0x06039840 RID: 235584 RVA: 0x007C36AB File Offset: 0x007C18AB
		public Span<byte> GetUiStartAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06039841 RID: 235585 RVA: 0x007C36BA File Offset: 0x007C18BA
		public byte[] GetUiStartAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700EECF RID: 61135
		// (get) Token: 0x06039842 RID: 235586 RVA: 0x007C36C8 File Offset: 0x007C18C8
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

		// Token: 0x06039843 RID: 235587 RVA: 0x007C36FF File Offset: 0x007C18FF
		public Span<byte> GetUiEndAnimNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039844 RID: 235588 RVA: 0x007C370E File Offset: 0x007C190E
		public byte[] GetUiEndAnimNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06039845 RID: 235589 RVA: 0x007C371C File Offset: 0x007C191C
		public static Offset<IUiAnimConfig> CreateIUiAnimConfig(FlatBufferBuilder builder, StringOffset UiStartAnimNameOffset = default(StringOffset), StringOffset UiEndAnimNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IUiAnimConfig.AddUiEndAnimName(builder, UiEndAnimNameOffset);
			IUiAnimConfig.AddUiStartAnimName(builder, UiStartAnimNameOffset);
			return IUiAnimConfig.EndIUiAnimConfig(builder);
		}

		// Token: 0x06039846 RID: 235590 RVA: 0x007C3739 File Offset: 0x007C1939
		public static void StartIUiAnimConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039847 RID: 235591 RVA: 0x007C3742 File Offset: 0x007C1942
		public static void AddUiStartAnimName(FlatBufferBuilder builder, StringOffset uiStartAnimNameOffset)
		{
			builder.AddOffset(0, uiStartAnimNameOffset.Value, 0);
		}

		// Token: 0x06039848 RID: 235592 RVA: 0x007C3752 File Offset: 0x007C1952
		public static void AddUiEndAnimName(FlatBufferBuilder builder, StringOffset uiEndAnimNameOffset)
		{
			builder.AddOffset(1, uiEndAnimNameOffset.Value, 0);
		}

		// Token: 0x06039849 RID: 235593 RVA: 0x007C3762 File Offset: 0x007C1962
		public static Offset<IUiAnimConfig> EndIUiAnimConfig(FlatBufferBuilder builder)
		{
			return new Offset<IUiAnimConfig>(builder.EndTable());
		}

		// Token: 0x0603984A RID: 235594 RVA: 0x007C3770 File Offset: 0x007C1970
		public IUiAnimConfigT UnPack()
		{
			IUiAnimConfigT uiAnimConfigT = new IUiAnimConfigT();
			this.UnPackTo(uiAnimConfigT);
			return uiAnimConfigT;
		}

		// Token: 0x0603984B RID: 235595 RVA: 0x007C378B File Offset: 0x007C198B
		public void UnPackTo(IUiAnimConfigT _o)
		{
			_o.UiStartAnimName = this.UiStartAnimName;
			_o.UiEndAnimName = this.UiEndAnimName;
		}

		// Token: 0x0603984C RID: 235596 RVA: 0x007C37A8 File Offset: 0x007C19A8
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

		// Token: 0x04013365 RID: 78693
		private Table __p;
	}
}
