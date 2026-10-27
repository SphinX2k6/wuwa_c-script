using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000215 RID: 533
	public sealed class ButtonEnableResult : IMessage<ButtonEnableResult>, IMessage, IEquatable<ButtonEnableResult>, IDeepCloneable<ButtonEnableResult>, IBufferMessage
	{
		// Token: 0x06003A7F RID: 14975 RVA: 0x00091ABF File Offset: 0x0008FCBF
		[NullableContext(1)]
		public static ButtonEnableResult Create()
		{
			return new ButtonEnableResult();
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00091AC6 File Offset: 0x0008FCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ButtonEnableResult> Parser
		{
			get
			{
				return ButtonEnableResult._parser;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x00091ACD File Offset: 0x0008FCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00091AD0 File Offset: 0x0008FCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonEnableResult.Descriptor;
			}
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00091AD7 File Offset: 0x0008FCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult()
		{
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x00091ADF File Offset: 0x0008FCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult(ButtonEnableResult other) : this()
		{
			this.type_ = other.type_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x00091B10 File Offset: 0x0008FD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonEnableResult Clone()
		{
			return new ButtonEnableResult(this);
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00091B18 File Offset: 0x0008FD18
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00091B20 File Offset: 0x0008FD20
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

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x00091B29 File Offset: 0x0008FD29
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x00091B31 File Offset: 0x0008FD31
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

		// Token: 0x06003A8A RID: 14986 RVA: 0x00091B3A File Offset: 0x0008FD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonEnableResult);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00091B48 File Offset: 0x0008FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonEnableResult other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00091B88 File Offset: 0x0008FD88
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

		// Token: 0x06003A8D RID: 14989 RVA: 0x00091BE6 File Offset: 0x0008FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00091BF3 File Offset: 0x0008FDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00091BFC File Offset: 0x0008FDFC
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

		// Token: 0x06003A90 RID: 14992 RVA: 0x00091C58 File Offset: 0x0008FE58
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

		// Token: 0x06003A91 RID: 14993 RVA: 0x00091CA4 File Offset: 0x0008FEA4
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

		// Token: 0x06003A92 RID: 14994 RVA: 0x00091CF4 File Offset: 0x0008FEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00091D00 File Offset: 0x0008FF00
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

		// Token: 0x04002BD4 RID: 11220
		private static readonly MessageParser<ButtonEnableResult> _parser = new MessageParser<ButtonEnableResult>(() => new ButtonEnableResult());

		// Token: 0x04002BD5 RID: 11221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD6 RID: 11222
		public const int TypeFieldNumber = 2;

		// Token: 0x04002BD7 RID: 11223
		private ButtonType type_;

		// Token: 0x04002BD8 RID: 11224
		public const int EnableFieldNumber = 3;

		// Token: 0x04002BD9 RID: 11225
		private bool enable_;
	}
}
