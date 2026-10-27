using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000216 RID: 534
	[NetMessage(EMessageId.ButtonIsEnableRequest)]
	public sealed class ButtonIsEnableRequest : IMessage<ButtonIsEnableRequest>, IMessage, IEquatable<ButtonIsEnableRequest>, IDeepCloneable<ButtonIsEnableRequest>, IBufferMessage
	{
		// Token: 0x06003A95 RID: 14997 RVA: 0x00091D74 File Offset: 0x0008FF74
		[NullableContext(1)]
		public static ButtonIsEnableRequest Create()
		{
			return new ButtonIsEnableRequest();
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x00091D7B File Offset: 0x0008FF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x00091D7E File Offset: 0x0008FF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonIsEnableRequest.Descriptor;
			}
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00091D85 File Offset: 0x0008FF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest()
		{
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00091D98 File Offset: 0x0008FF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest(ButtonIsEnableRequest other) : this()
		{
			this.type_ = other.type_;
			this.types_ = other.types_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00091DCE File Offset: 0x0008FFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableRequest Clone()
		{
			return new ButtonIsEnableRequest(this);
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x00091DD6 File Offset: 0x0008FFD6
		// (set) Token: 0x06003A9C RID: 15004 RVA: 0x00091DDE File Offset: 0x0008FFDE
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

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x00091DE7 File Offset: 0x0008FFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ButtonType> Types_
		{
			get
			{
				return this.types_;
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00091DEF File Offset: 0x0008FFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonIsEnableRequest);
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x00091E00 File Offset: 0x00090000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonIsEnableRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.types_.Equals(other.types_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00091E50 File Offset: 0x00090050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ButtonType.Home)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.types_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00091EA3 File Offset: 0x000900A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x00091EB0 File Offset: 0x000900B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x00091EBC File Offset: 0x000900BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.types_.WriteTo(ref output, ButtonIsEnableRequest._repeated_types_codec);
			if (this.Type != ButtonType.Home)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x00091F0C File Offset: 0x0009010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ButtonType.Home)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.types_.CalculateSize(ButtonIsEnableRequest._repeated_types_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00091F60 File Offset: 0x00090160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ButtonIsEnableRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ButtonType.Home)
			{
				this.Type = other.Type;
			}
			this.types_.Add(other.types_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00091FAD File Offset: 0x000901AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00091FB8 File Offset: 0x000901B8
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
				if (num != 24U && num != 26U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (ButtonType)input.ReadEnum();
					}
				}
				else
				{
					this.types_.AddEntriesFrom(ref input, ButtonIsEnableRequest._repeated_types_codec);
				}
			}
		}

		// Token: 0x04002BDA RID: 11226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BDB RID: 11227
		public const int TypeFieldNumber = 8;

		// Token: 0x04002BDC RID: 11228
		private ButtonType type_;

		// Token: 0x04002BDD RID: 11229
		public const int Types_FieldNumber = 3;

		// Token: 0x04002BDE RID: 11230
		private static readonly FieldCodec<ButtonType> _repeated_types_codec = FieldCodec.ForEnum<ButtonType>(26U, (ButtonType x) => (int)x, (int x) => (ButtonType)x);

		// Token: 0x04002BDF RID: 11231
		private readonly RepeatedField<ButtonType> types_ = new RepeatedField<ButtonType>();
	}
}
