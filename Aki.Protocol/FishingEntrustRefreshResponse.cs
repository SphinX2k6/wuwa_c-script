using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000540 RID: 1344
	[NetMessage(EMessageId.FishingEntrustRefreshResponse)]
	public sealed class FishingEntrustRefreshResponse : IMessage<FishingEntrustRefreshResponse>, IMessage, IEquatable<FishingEntrustRefreshResponse>, IDeepCloneable<FishingEntrustRefreshResponse>, IBufferMessage
	{
		// Token: 0x06007E0D RID: 32269 RVA: 0x001317A5 File Offset: 0x0012F9A5
		[NullableContext(1)]
		public static FishingEntrustRefreshResponse Create()
		{
			return new FishingEntrustRefreshResponse();
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06007E0E RID: 32270 RVA: 0x001317AC File Offset: 0x0012F9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06007E0F RID: 32271 RVA: 0x001317AF File Offset: 0x0012F9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustRefreshResponse.Descriptor;
			}
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x001317B6 File Offset: 0x0012F9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse()
		{
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x001317BE File Offset: 0x0012F9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse(FishingEntrustRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x001317EF File Offset: 0x0012F9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse Clone()
		{
			return new FishingEntrustRefreshResponse(this);
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x001317F7 File Offset: 0x0012F9F7
		// (set) Token: 0x06007E14 RID: 32276 RVA: 0x001317FF File Offset: 0x0012F9FF
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

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06007E15 RID: 32277 RVA: 0x00131808 File Offset: 0x0012FA08
		// (set) Token: 0x06007E16 RID: 32278 RVA: 0x00131810 File Offset: 0x0012FA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x00131819 File Offset: 0x0012FA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustRefreshResponse);
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x00131827 File Offset: 0x0012FA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x00131868 File Offset: 0x0012FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x001318C6 File Offset: 0x0012FAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x001318D3 File Offset: 0x0012FAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x001318DC File Offset: 0x0012FADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x00131938 File Offset: 0x0012FB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x00131990 File Offset: 0x0012FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x001319E0 File Offset: 0x0012FBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x001319EC File Offset: 0x0012FBEC
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntrustId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004057 RID: 16471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004058 RID: 16472
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004059 RID: 16473
		private ErrorCode errorCode_;

		// Token: 0x0400405A RID: 16474
		public const int EntrustIdFieldNumber = 12;

		// Token: 0x0400405B RID: 16475
		private int entrustId_;
	}
}
