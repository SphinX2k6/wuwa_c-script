using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021C RID: 540
	[NetMessage(EMessageId.ButtonIsEnableResponse)]
	public sealed class ButtonIsEnableResponse : IMessage<ButtonIsEnableResponse>, IMessage, IEquatable<ButtonIsEnableResponse>, IDeepCloneable<ButtonIsEnableResponse>, IBufferMessage
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x00093C5F File Offset: 0x00091E5F
		[NullableContext(1)]
		public static ButtonIsEnableResponse Create()
		{
			return new ButtonIsEnableResponse();
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x00093C66 File Offset: 0x00091E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00093C69 File Offset: 0x00091E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ButtonIsEnableResponse.Descriptor;
			}
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00093C70 File Offset: 0x00091E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableResponse()
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00093C84 File Offset: 0x00091E84
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

		// Token: 0x06003B53 RID: 15187 RVA: 0x00093CDD File Offset: 0x00091EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ButtonIsEnableResponse Clone()
		{
			return new ButtonIsEnableResponse(this);
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00093CE5 File Offset: 0x00091EE5
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00093CED File Offset: 0x00091EED
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

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00093CF6 File Offset: 0x00091EF6
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x00093CFE File Offset: 0x00091EFE
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

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x00093D07 File Offset: 0x00091F07
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x00093D0F File Offset: 0x00091F0F
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

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x00093D18 File Offset: 0x00091F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ButtonEnableResult> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00093D20 File Offset: 0x00091F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ButtonIsEnableResponse);
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00093D30 File Offset: 0x00091F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ButtonIsEnableResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && this.Enable == other.Enable && this.result_.Equals(other.result_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00093DA0 File Offset: 0x00091FA0
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

		// Token: 0x06003B5E RID: 15198 RVA: 0x00093E2B File Offset: 0x0009202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00093E38 File Offset: 0x00092038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00093E44 File Offset: 0x00092044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ButtonType.Home)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.result_.WriteTo(ref output, ButtonIsEnableResponse._repeated_result_codec);
			if (this.Enable)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00093ECC File Offset: 0x000920CC
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

		// Token: 0x06003B62 RID: 15202 RVA: 0x00093F44 File Offset: 0x00092144
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

		// Token: 0x06003B63 RID: 15203 RVA: 0x00093FB9 File Offset: 0x000921B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00093FC4 File Offset: 0x000921C4
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.Type = (ButtonType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.result_.AddEntriesFrom(ref input, ButtonIsEnableResponse._repeated_result_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Enable = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C62 RID: 11362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C63 RID: 11363
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002C64 RID: 11364
		private ErrorCode errorCode_;

		// Token: 0x04002C65 RID: 11365
		public const int TypeFieldNumber = 2;

		// Token: 0x04002C66 RID: 11366
		private ButtonType type_;

		// Token: 0x04002C67 RID: 11367
		public const int EnableFieldNumber = 14;

		// Token: 0x04002C68 RID: 11368
		private bool enable_;

		// Token: 0x04002C69 RID: 11369
		public const int ResultFieldNumber = 11;

		// Token: 0x04002C6A RID: 11370
		private static readonly FieldCodec<ButtonEnableResult> _repeated_result_codec = FieldCodec.ForMessage<ButtonEnableResult>(90U, ButtonEnableResult.Parser);

		// Token: 0x04002C6B RID: 11371
		private readonly RepeatedField<ButtonEnableResult> result_ = new RepeatedField<ButtonEnableResult>();
	}
}
