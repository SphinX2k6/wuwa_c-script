using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FB RID: 2043
	[NetMessage(EMessageId.InfrV2InfoResponse)]
	public sealed class InfrV2InfoResponse : IMessage<InfrV2InfoResponse>, IMessage, IEquatable<InfrV2InfoResponse>, IDeepCloneable<InfrV2InfoResponse>, IBufferMessage
	{
		// Token: 0x0600B706 RID: 46854 RVA: 0x001B497E File Offset: 0x001B2B7E
		[NullableContext(1)]
		public static InfrV2InfoResponse Create()
		{
			return new InfrV2InfoResponse();
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x0600B707 RID: 46855 RVA: 0x001B4985 File Offset: 0x001B2B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x0600B708 RID: 46856 RVA: 0x001B4988 File Offset: 0x001B2B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x001B498F File Offset: 0x001B2B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse()
		{
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x001B4998 File Offset: 0x001B2B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse(InfrV2InfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x001B49E4 File Offset: 0x001B2BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse Clone()
		{
			return new InfrV2InfoResponse(this);
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x0600B70C RID: 46860 RVA: 0x001B49EC File Offset: 0x001B2BEC
		// (set) Token: 0x0600B70D RID: 46861 RVA: 0x001B49F4 File Offset: 0x001B2BF4
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

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600B70E RID: 46862 RVA: 0x001B49FD File Offset: 0x001B2BFD
		// (set) Token: 0x0600B70F RID: 46863 RVA: 0x001B4A05 File Offset: 0x001B2C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x001B4A0E File Offset: 0x001B2C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoResponse);
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x001B4A1C File Offset: 0x001B2C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x001B4A6C File Offset: 0x001B2C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x001B4AC7 File Offset: 0x001B2CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x001B4AD4 File Offset: 0x001B2CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x001B4AE0 File Offset: 0x001B2CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x001B4B3C File Offset: 0x001B2D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x001B4B94 File Offset: 0x001B2D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrV2Pb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x001B4BFC File Offset: 0x001B2DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x001B4C08 File Offset: 0x001B2E08
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
				if (num != 32U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.infrInfo_ == null)
						{
							this.InfrInfo = new InfrV2Pb();
						}
						input.ReadMessage(this.InfrInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050EA RID: 20714
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050EB RID: 20715
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040050EC RID: 20716
		private ErrorCode errorCode_;

		// Token: 0x040050ED RID: 20717
		public const int InfrInfoFieldNumber = 9;

		// Token: 0x040050EE RID: 20718
		private InfrV2Pb infrInfo_;
	}
}
