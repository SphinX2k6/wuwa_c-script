using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EF RID: 2543
	[NetMessage(EMessageId.ModifySignatureResponse)]
	public sealed class ModifySignatureResponse : IMessage<ModifySignatureResponse>, IMessage, IEquatable<ModifySignatureResponse>, IDeepCloneable<ModifySignatureResponse>, IBufferMessage
	{
		// Token: 0x0600DEB9 RID: 57017 RVA: 0x0020A8F5 File Offset: 0x00208AF5
		[NullableContext(1)]
		public static ModifySignatureResponse Create()
		{
			return new ModifySignatureResponse();
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600DEBA RID: 57018 RVA: 0x0020A8FC File Offset: 0x00208AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600DEBB RID: 57019 RVA: 0x0020A8FF File Offset: 0x00208AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifySignatureResponse.Descriptor;
			}
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x0020A906 File Offset: 0x00208B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse()
		{
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x0020A919 File Offset: 0x00208B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse(ModifySignatureResponse other) : this()
		{
			this.signature_ = other.signature_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x0020A94A File Offset: 0x00208B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse Clone()
		{
			return new ModifySignatureResponse(this);
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x0020A952 File Offset: 0x00208B52
		// (set) Token: 0x0600DEC0 RID: 57024 RVA: 0x0020A95A File Offset: 0x00208B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x0020A96D File Offset: 0x00208B6D
		// (set) Token: 0x0600DEC2 RID: 57026 RVA: 0x0020A975 File Offset: 0x00208B75
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

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x0020A97E File Offset: 0x00208B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifySignatureResponse);
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x0020A98C File Offset: 0x00208B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifySignatureResponse other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x0020A9DC File Offset: 0x00208BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x0020AA3C File Offset: 0x00208C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x0020AA49 File Offset: 0x00208C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x0020AA54 File Offset: 0x00208C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Signature);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0020AAB4 File Offset: 0x00208CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x0020AB10 File Offset: 0x00208D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifySignatureResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x0020AB65 File Offset: 0x00208D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x0020AB70 File Offset: 0x00208D70
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
				if (num != 10U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x04005BE7 RID: 23527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BE8 RID: 23528
		public const int SignatureFieldNumber = 1;

		// Token: 0x04005BE9 RID: 23529
		private string signature_ = "";

		// Token: 0x04005BEA RID: 23530
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005BEB RID: 23531
		private ErrorCode errorCode_;
	}
}
