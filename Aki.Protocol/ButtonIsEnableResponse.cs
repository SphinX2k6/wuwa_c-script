using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000217 RID: 535
	[NetMessage(EMessageId.ButtonIsEnableResponse)]
	public sealed class ButtonIsEnableResponse : IMessage<ButtonIsEnableResponse>, IMessage, IEquatable<ButtonIsEnableResponse>, IDeepCloneable<ButtonIsEnableResponse>, IBufferMessage
	{
		// Token: 0x06003AA9 RID: 15017 RVA: 0x00092048 File Offset: 0x00090248
		[NullableContext(1)]
		public static ButtonIsEnableResponse Create()
		{
			return new ButtonIsEnableResponse();
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x0009204F File Offset: 0x0009024F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x00092052 File Offset: 0x00090252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonIsEnableResponse.Descriptor;
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00092059 File Offset: 0x00090259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableResponse()
		{
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0009206C File Offset: 0x0009026C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableResponse(ButtonIsEnableResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.type_ = other.type_;
			this.enable_ = other.enable_;
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x000920C5 File Offset: 0x000902C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableResponse Clone()
		{
			return new ButtonIsEnableResponse(this);
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x000920CD File Offset: 0x000902CD
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x000920D5 File Offset: 0x000902D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x000920DE File Offset: 0x000902DE
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x000920E6 File Offset: 0x000902E6
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x000920EF File Offset: 0x000902EF
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x000920F7 File Offset: 0x000902F7
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x00092100 File Offset: 0x00090300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ButtonEnableResult> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00092108 File Offset: 0x00090308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonIsEnableResponse);
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x00092118 File Offset: 0x00090318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonIsEnableResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && this.Enable == other.Enable && this.result_.Equals(other.result_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00092188 File Offset: 0x00090388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Type != ButtonType.Home)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			num ^= this.result_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00092213 File Offset: 0x00090413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x00092220 File Offset: 0x00090420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x0009222C File Offset: 0x0009042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.result_.WriteTo(ref output, ButtonIsEnableResponse._repeated_result_codec);
			if (this.Type != ButtonType.Home)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Enable)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000922B4 File Offset: 0x000904B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Type != ButtonType.Home)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Enable)
			{
				num += 2;
			}
			num += this.result_.CalculateSize(ButtonIsEnableResponse._repeated_result_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x0009232C File Offset: 0x0009052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ButtonIsEnableResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Type != ButtonType.Home)
			{
				this.Type = other.Type;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this.result_.Add(other.result_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000923A1 File Offset: 0x000905A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x000923AC File Offset: 0x000905AC
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.result_.AddEntriesFrom(ref input, ButtonIsEnableResponse._repeated_result_codec);
						continue;
					}
					if (num == 32U)
					{
						this.Type = (ButtonType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.Enable = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BE0 RID: 11232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BE1 RID: 11233
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002BE2 RID: 11234
		private ErrorCode errorCode_;

		// Token: 0x04002BE3 RID: 11235
		public const int TypeFieldNumber = 4;

		// Token: 0x04002BE4 RID: 11236
		private ButtonType type_;

		// Token: 0x04002BE5 RID: 11237
		public const int EnableFieldNumber = 12;

		// Token: 0x04002BE6 RID: 11238
		private bool enable_;

		// Token: 0x04002BE7 RID: 11239
		public const int ResultFieldNumber = 1;

		// Token: 0x04002BE8 RID: 11240
		private static readonly FieldCodec<ButtonEnableResult> _repeated_result_codec = FieldCodec.ForMessage<ButtonEnableResult>(10U, ButtonEnableResult.Parser);

		// Token: 0x04002BE9 RID: 11241
		private readonly RepeatedField<ButtonEnableResult> result_ = new RepeatedField<ButtonEnableResult>();
	}
}
