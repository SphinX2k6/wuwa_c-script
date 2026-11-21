using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DE RID: 2526
	[NetMessage(EMessageId.ModifySignatureResponse)]
	public sealed class ModifySignatureResponse : IMessage<ModifySignatureResponse>, IMessage, IEquatable<ModifySignatureResponse>, IDeepCloneable<ModifySignatureResponse>, IBufferMessage
	{
		// Token: 0x0600DD9F RID: 56735 RVA: 0x00208709 File Offset: 0x00206909
		[NullableContext(1)]
		public static ModifySignatureResponse Create()
		{
			return new ModifySignatureResponse();
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x00208710 File Offset: 0x00206910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0600DDA1 RID: 56737 RVA: 0x00208713 File Offset: 0x00206913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifySignatureResponse.Descriptor;
			}
		}

		// Token: 0x0600DDA2 RID: 56738 RVA: 0x0020871A File Offset: 0x0020691A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse()
		{
		}

		// Token: 0x0600DDA3 RID: 56739 RVA: 0x0020872D File Offset: 0x0020692D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse(ModifySignatureResponse other) : this()
		{
			this.signature_ = other.signature_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDA4 RID: 56740 RVA: 0x0020875E File Offset: 0x0020695E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureResponse Clone()
		{
			return new ModifySignatureResponse(this);
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600DDA5 RID: 56741 RVA: 0x00208766 File Offset: 0x00206966
		// (set) Token: 0x0600DDA6 RID: 56742 RVA: 0x0020876E File Offset: 0x0020696E
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

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600DDA7 RID: 56743 RVA: 0x00208781 File Offset: 0x00206981
		// (set) Token: 0x0600DDA8 RID: 56744 RVA: 0x00208789 File Offset: 0x00206989
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

		// Token: 0x0600DDA9 RID: 56745 RVA: 0x00208792 File Offset: 0x00206992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifySignatureResponse);
		}

		// Token: 0x0600DDAA RID: 56746 RVA: 0x002087A0 File Offset: 0x002069A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifySignatureResponse other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDAB RID: 56747 RVA: 0x002087F0 File Offset: 0x002069F0
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

		// Token: 0x0600DDAC RID: 56748 RVA: 0x00208850 File Offset: 0x00206A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDAD RID: 56749 RVA: 0x0020885D File Offset: 0x00206A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDAE RID: 56750 RVA: 0x00208868 File Offset: 0x00206A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDAF RID: 56751 RVA: 0x002088C8 File Offset: 0x00206AC8
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

		// Token: 0x0600DDB0 RID: 56752 RVA: 0x00208924 File Offset: 0x00206B24
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

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x00208979 File Offset: 0x00206B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x00208984 File Offset: 0x00206B84
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
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Signature = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005BF0 RID: 23536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BF1 RID: 23537
		public const int SignatureFieldNumber = 10;

		// Token: 0x04005BF2 RID: 23538
		private string signature_ = "";

		// Token: 0x04005BF3 RID: 23539
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005BF4 RID: 23540
		private ErrorCode errorCode_;
	}
}
