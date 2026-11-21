using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021A RID: 538
	public sealed class ButtonEnableResult : IMessage<ButtonEnableResult>, IMessage, IEquatable<ButtonEnableResult>, IDeepCloneable<ButtonEnableResult>, IBufferMessage
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x000936D7 File Offset: 0x000918D7
		[NullableContext(1)]
		public static ButtonEnableResult Create()
		{
			return new ButtonEnableResult();
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x000936DE File Offset: 0x000918DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ButtonEnableResult> Parser
		{
			get
			{
				return ButtonEnableResult._parser;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x000936E5 File Offset: 0x000918E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x000936E8 File Offset: 0x000918E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonEnableResult.Descriptor;
			}
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x000936EF File Offset: 0x000918EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult()
		{
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x000936F7 File Offset: 0x000918F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult(ButtonEnableResult other) : this()
		{
			this.type_ = other.type_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00093728 File Offset: 0x00091928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult Clone()
		{
			return new ButtonEnableResult(this);
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x00093730 File Offset: 0x00091930
		// (set) Token: 0x06003B2C RID: 15148 RVA: 0x00093738 File Offset: 0x00091938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00093741 File Offset: 0x00091941
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x00093749 File Offset: 0x00091949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00093752 File Offset: 0x00091952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonEnableResult);
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00093760 File Offset: 0x00091960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonEnableResult other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x000937A0 File Offset: 0x000919A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ButtonType.Home)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x000937FE File Offset: 0x000919FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x0009380B File Offset: 0x00091A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00093814 File Offset: 0x00091A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ButtonType.Home)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.Enable)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00093870 File Offset: 0x00091A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ButtonType.Home)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x000938BC File Offset: 0x00091ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ButtonEnableResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ButtonType.Home)
			{
				this.Type = other.Type;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x0009390C File Offset: 0x00091B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00093918 File Offset: 0x00091B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Enable = input.ReadBool();
					}
				}
				else
				{
					this.Type = (ButtonType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C56 RID: 11350
		private static readonly MessageParser<ButtonEnableResult> _parser = new MessageParser<ButtonEnableResult>(() => new ButtonEnableResult());

		// Token: 0x04002C57 RID: 11351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C58 RID: 11352
		public const int TypeFieldNumber = 2;

		// Token: 0x04002C59 RID: 11353
		private ButtonType type_;

		// Token: 0x04002C5A RID: 11354
		public const int EnableFieldNumber = 3;

		// Token: 0x04002C5B RID: 11355
		private bool enable_;
	}
}
