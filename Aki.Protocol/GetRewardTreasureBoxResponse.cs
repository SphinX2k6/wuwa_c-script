using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D0 RID: 1744
	[NetMessage(EMessageId.GetRewardTreasureBoxResponse)]
	public sealed class GetRewardTreasureBoxResponse : IMessage<GetRewardTreasureBoxResponse>, IMessage, IEquatable<GetRewardTreasureBoxResponse>, IDeepCloneable<GetRewardTreasureBoxResponse>, IBufferMessage
	{
		// Token: 0x06009F64 RID: 40804 RVA: 0x0018262D File Offset: 0x0018082D
		[NullableContext(1)]
		public static GetRewardTreasureBoxResponse Create()
		{
			return new GetRewardTreasureBoxResponse();
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06009F65 RID: 40805 RVA: 0x00182634 File Offset: 0x00180834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x00182637 File Offset: 0x00180837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRewardTreasureBoxResponse.Descriptor;
			}
		}

		// Token: 0x06009F67 RID: 40807 RVA: 0x0018263E File Offset: 0x0018083E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse()
		{
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x00182646 File Offset: 0x00180846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse(GetRewardTreasureBoxResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F69 RID: 40809 RVA: 0x0018266B File Offset: 0x0018086B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse Clone()
		{
			return new GetRewardTreasureBoxResponse(this);
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x00182673 File Offset: 0x00180873
		// (set) Token: 0x06009F6B RID: 40811 RVA: 0x0018267B File Offset: 0x0018087B
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

		// Token: 0x06009F6C RID: 40812 RVA: 0x00182684 File Offset: 0x00180884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRewardTreasureBoxResponse);
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x00182692 File Offset: 0x00180892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRewardTreasureBoxResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x001826C0 File Offset: 0x001808C0
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

		// Token: 0x06009F6F RID: 40815 RVA: 0x00182705 File Offset: 0x00180905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x00182712 File Offset: 0x00180912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x0018271B File Offset: 0x0018091B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x00182750 File Offset: 0x00180950
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

		// Token: 0x06009F73 RID: 40819 RVA: 0x0018278E File Offset: 0x0018098E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRewardTreasureBoxResponse other)
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

		// Token: 0x06009F74 RID: 40820 RVA: 0x001827BF File Offset: 0x001809BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x001827C8 File Offset: 0x001809C8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A6C RID: 19052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A6D RID: 19053
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004A6E RID: 19054
		private ErrorCode errorCode_;
	}
}
