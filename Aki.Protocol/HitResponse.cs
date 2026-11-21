using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000742 RID: 1858
	[NetMessage(EMessageId.HitResponse)]
	public sealed class HitResponse : IMessage<HitResponse>, IMessage, IEquatable<HitResponse>, IDeepCloneable<HitResponse>, IBufferMessage
	{
		// Token: 0x0600A8B6 RID: 43190 RVA: 0x00196890 File Offset: 0x00194A90
		[NullableContext(1)]
		public static HitResponse Create()
		{
			return new HitResponse();
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600A8B7 RID: 43191 RVA: 0x00196897 File Offset: 0x00194A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600A8B8 RID: 43192 RVA: 0x0019689A File Offset: 0x00194A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitResponse.Descriptor;
			}
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x001968A1 File Offset: 0x00194AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse()
		{
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x001968AC File Offset: 0x00194AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse(HitResponse other) : this()
		{
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x001968F8 File Offset: 0x00194AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse Clone()
		{
			return new HitResponse(this);
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x00196900 File Offset: 0x00194B00
		// (set) Token: 0x0600A8BD RID: 43197 RVA: 0x00196908 File Offset: 0x00194B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation HitInfo
		{
			get
			{
				return this.hitInfo_;
			}
			set
			{
				this.hitInfo_ = value;
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600A8BE RID: 43198 RVA: 0x00196911 File Offset: 0x00194B11
		// (set) Token: 0x0600A8BF RID: 43199 RVA: 0x00196919 File Offset: 0x00194B19
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

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x00196922 File Offset: 0x00194B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitResponse);
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x00196930 File Offset: 0x00194B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitResponse other)
		{
			return other != null && (other == this || (object.Equals(this.HitInfo, other.HitInfo) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x00196980 File Offset: 0x00194B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hitInfo_ != null)
			{
				num ^= this.HitInfo.GetHashCode();
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

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x001969DB File Offset: 0x00194BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x001969E8 File Offset: 0x00194BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x001969F4 File Offset: 0x00194BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.HitInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x00196A50 File Offset: 0x00194C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitInfo);
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

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00196AA8 File Offset: 0x00194CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hitInfo_ != null)
			{
				if (this.hitInfo_ == null)
				{
					this.HitInfo = new HitInformation();
				}
				this.HitInfo.MergeFrom(other.HitInfo);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x00196B10 File Offset: 0x00194D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x00196B1C File Offset: 0x00194D1C
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
				if (num != 106U)
				{
					if (num != 120U)
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
					if (this.hitInfo_ == null)
					{
						this.HitInfo = new HitInformation();
					}
					input.ReadMessage(this.HitInfo);
				}
			}
		}

		// Token: 0x04004D53 RID: 19795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D54 RID: 19796
		public const int HitInfoFieldNumber = 13;

		// Token: 0x04004D55 RID: 19797
		private HitInformation hitInfo_;

		// Token: 0x04004D56 RID: 19798
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004D57 RID: 19799
		private ErrorCode errorCode_;
	}
}
