using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DD RID: 4317
	[NetMessage(EMessageId.RoleTowerRankRewardReceiveResponse)]
	public sealed class RoleTowerRankRewardReceiveResponse : IMessage<RoleTowerRankRewardReceiveResponse>, IMessage, IEquatable<RoleTowerRankRewardReceiveResponse>, IDeepCloneable<RoleTowerRankRewardReceiveResponse>, IBufferMessage
	{
		// Token: 0x0601714C RID: 94540 RVA: 0x0035BD8D File Offset: 0x00359F8D
		[NullableContext(1)]
		public static RoleTowerRankRewardReceiveResponse Create()
		{
			return new RoleTowerRankRewardReceiveResponse();
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x0601714D RID: 94541 RVA: 0x0035BD94 File Offset: 0x00359F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x0601714E RID: 94542 RVA: 0x0035BD97 File Offset: 0x00359F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankRewardReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601714F RID: 94543 RVA: 0x0035BD9E File Offset: 0x00359F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveResponse()
		{
		}

		// Token: 0x06017150 RID: 94544 RVA: 0x0035BDA6 File Offset: 0x00359FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveResponse(RoleTowerRankRewardReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017151 RID: 94545 RVA: 0x0035BDCB File Offset: 0x00359FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveResponse Clone()
		{
			return new RoleTowerRankRewardReceiveResponse(this);
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x06017152 RID: 94546 RVA: 0x0035BDD3 File Offset: 0x00359FD3
		// (set) Token: 0x06017153 RID: 94547 RVA: 0x0035BDDB File Offset: 0x00359FDB
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

		// Token: 0x06017154 RID: 94548 RVA: 0x0035BDE4 File Offset: 0x00359FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankRewardReceiveResponse);
		}

		// Token: 0x06017155 RID: 94549 RVA: 0x0035BDF2 File Offset: 0x00359FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankRewardReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017156 RID: 94550 RVA: 0x0035BE20 File Offset: 0x0035A020
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

		// Token: 0x06017157 RID: 94551 RVA: 0x0035BE65 File Offset: 0x0035A065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017158 RID: 94552 RVA: 0x0035BE72 File Offset: 0x0035A072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017159 RID: 94553 RVA: 0x0035BE7B File Offset: 0x0035A07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601715A RID: 94554 RVA: 0x0035BEB0 File Offset: 0x0035A0B0
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

		// Token: 0x0601715B RID: 94555 RVA: 0x0035BEEE File Offset: 0x0035A0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankRewardReceiveResponse other)
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

		// Token: 0x0601715C RID: 94556 RVA: 0x0035BF1F File Offset: 0x0035A11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601715D RID: 94557 RVA: 0x0035BF28 File Offset: 0x0035A128
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008A32 RID: 35378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A33 RID: 35379
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008A34 RID: 35380
		private ErrorCode errorCode_;
	}
}
