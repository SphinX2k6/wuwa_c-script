using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F0 RID: 4336
	[NetMessage(EMessageId.RoleTowerStageRetryResponse)]
	public sealed class RoleTowerStageRetryResponse : IMessage<RoleTowerStageRetryResponse>, IMessage, IEquatable<RoleTowerStageRetryResponse>, IDeepCloneable<RoleTowerStageRetryResponse>, IBufferMessage
	{
		// Token: 0x060172DF RID: 94943 RVA: 0x0035F583 File Offset: 0x0035D783
		[NullableContext(1)]
		public static RoleTowerStageRetryResponse Create()
		{
			return new RoleTowerStageRetryResponse();
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x060172E0 RID: 94944 RVA: 0x0035F58A File Offset: 0x0035D78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x060172E1 RID: 94945 RVA: 0x0035F58D File Offset: 0x0035D78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageRetryResponse.Descriptor;
			}
		}

		// Token: 0x060172E2 RID: 94946 RVA: 0x0035F594 File Offset: 0x0035D794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryResponse()
		{
		}

		// Token: 0x060172E3 RID: 94947 RVA: 0x0035F59C File Offset: 0x0035D79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryResponse(RoleTowerStageRetryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172E4 RID: 94948 RVA: 0x0035F5C1 File Offset: 0x0035D7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryResponse Clone()
		{
			return new RoleTowerStageRetryResponse(this);
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x060172E5 RID: 94949 RVA: 0x0035F5C9 File Offset: 0x0035D7C9
		// (set) Token: 0x060172E6 RID: 94950 RVA: 0x0035F5D1 File Offset: 0x0035D7D1
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

		// Token: 0x060172E7 RID: 94951 RVA: 0x0035F5DA File Offset: 0x0035D7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageRetryResponse);
		}

		// Token: 0x060172E8 RID: 94952 RVA: 0x0035F5E8 File Offset: 0x0035D7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageRetryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172E9 RID: 94953 RVA: 0x0035F618 File Offset: 0x0035D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060172EA RID: 94954 RVA: 0x0035F65D File Offset: 0x0035D85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172EB RID: 94955 RVA: 0x0035F66A File Offset: 0x0035D86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172EC RID: 94956 RVA: 0x0035F673 File Offset: 0x0035D873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172ED RID: 94957 RVA: 0x0035F6A8 File Offset: 0x0035D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x060172EE RID: 94958 RVA: 0x0035F6E6 File Offset: 0x0035D8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageRetryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172EF RID: 94959 RVA: 0x0035F717 File Offset: 0x0035D917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172F0 RID: 94960 RVA: 0x0035F720 File Offset: 0x0035D920
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008AB3 RID: 35507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AB4 RID: 35508
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008AB5 RID: 35509
		private ErrorCode errorCode_;
	}
}
