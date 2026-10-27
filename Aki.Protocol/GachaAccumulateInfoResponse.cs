using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068A RID: 1674
	[NetMessage(EMessageId.GachaAccumulateInfoResponse)]
	public sealed class GachaAccumulateInfoResponse : IMessage<GachaAccumulateInfoResponse>, IMessage, IEquatable<GachaAccumulateInfoResponse>, IDeepCloneable<GachaAccumulateInfoResponse>, IBufferMessage
	{
		// Token: 0x06009933 RID: 39219 RVA: 0x00170F14 File Offset: 0x0016F114
		[NullableContext(1)]
		public static GachaAccumulateInfoResponse Create()
		{
			return new GachaAccumulateInfoResponse();
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06009934 RID: 39220 RVA: 0x00170F1B File Offset: 0x0016F11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x00170F1E File Offset: 0x0016F11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaAccumulateInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00170F25 File Offset: 0x0016F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse()
		{
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00170F30 File Offset: 0x0016F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse(GachaAccumulateInfoResponse other) : this()
		{
			this.gachaAccumulateInfo_ = ((other.gachaAccumulateInfo_ != null) ? other.gachaAccumulateInfo_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00170F7C File Offset: 0x0016F17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfoResponse Clone()
		{
			return new GachaAccumulateInfoResponse(this);
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06009939 RID: 39225 RVA: 0x00170F84 File Offset: 0x0016F184
		// (set) Token: 0x0600993A RID: 39226 RVA: 0x00170F8C File Offset: 0x0016F18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaAccumulateInfo GachaAccumulateInfo
		{
			get
			{
				return this.gachaAccumulateInfo_;
			}
			set
			{
				this.gachaAccumulateInfo_ = value;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x00170F95 File Offset: 0x0016F195
		// (set) Token: 0x0600993C RID: 39228 RVA: 0x00170F9D File Offset: 0x0016F19D
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

		// Token: 0x0600993D RID: 39229 RVA: 0x00170FA6 File Offset: 0x0016F1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaAccumulateInfoResponse);
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x00170FB4 File Offset: 0x0016F1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaAccumulateInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.GachaAccumulateInfo, other.GachaAccumulateInfo) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600993F RID: 39231 RVA: 0x00171004 File Offset: 0x0016F204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaAccumulateInfo_ != null)
			{
				num ^= this.GachaAccumulateInfo.GetHashCode();
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

		// Token: 0x06009940 RID: 39232 RVA: 0x0017105F File Offset: 0x0016F25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x0017106C File Offset: 0x0016F26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x00171078 File Offset: 0x0016F278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.gachaAccumulateInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GachaAccumulateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x001710D4 File Offset: 0x0016F2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaAccumulateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaAccumulateInfo);
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

		// Token: 0x06009944 RID: 39236 RVA: 0x0017112C File Offset: 0x0016F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaAccumulateInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaAccumulateInfo_ != null)
			{
				if (this.gachaAccumulateInfo_ == null)
				{
					this.GachaAccumulateInfo = new GachaAccumulateInfo();
				}
				this.GachaAccumulateInfo.MergeFrom(other.GachaAccumulateInfo);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x00171194 File Offset: 0x0016F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x001711A0 File Offset: 0x0016F3A0
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
				if (num != 40U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gachaAccumulateInfo_ == null)
						{
							this.GachaAccumulateInfo = new GachaAccumulateInfo();
						}
						input.ReadMessage(this.GachaAccumulateInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400487A RID: 18554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400487B RID: 18555
		public const int GachaAccumulateInfoFieldNumber = 12;

		// Token: 0x0400487C RID: 18556
		private GachaAccumulateInfo gachaAccumulateInfo_;

		// Token: 0x0400487D RID: 18557
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400487E RID: 18558
		private ErrorCode errorCode_;
	}
}
