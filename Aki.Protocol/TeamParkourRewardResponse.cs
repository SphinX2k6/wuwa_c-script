using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139C RID: 5020
	[NetMessage(EMessageId.TeamParkourRewardResponse)]
	public sealed class TeamParkourRewardResponse : IMessage<TeamParkourRewardResponse>, IMessage, IEquatable<TeamParkourRewardResponse>, IDeepCloneable<TeamParkourRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AB91 RID: 109457 RVA: 0x003E4830 File Offset: 0x003E2A30
		[NullableContext(1)]
		public static TeamParkourRewardResponse Create()
		{
			return new TeamParkourRewardResponse();
		}

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x0601AB92 RID: 109458 RVA: 0x003E4837 File Offset: 0x003E2A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x0601AB93 RID: 109459 RVA: 0x003E483A File Offset: 0x003E2A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AB94 RID: 109460 RVA: 0x003E4841 File Offset: 0x003E2A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse()
		{
		}

		// Token: 0x0601AB95 RID: 109461 RVA: 0x003E4849 File Offset: 0x003E2A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse(TeamParkourRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB96 RID: 109462 RVA: 0x003E486E File Offset: 0x003E2A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardResponse Clone()
		{
			return new TeamParkourRewardResponse(this);
		}

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x0601AB97 RID: 109463 RVA: 0x003E4876 File Offset: 0x003E2A76
		// (set) Token: 0x0601AB98 RID: 109464 RVA: 0x003E487E File Offset: 0x003E2A7E
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

		// Token: 0x0601AB99 RID: 109465 RVA: 0x003E4887 File Offset: 0x003E2A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourRewardResponse);
		}

		// Token: 0x0601AB9A RID: 109466 RVA: 0x003E4895 File Offset: 0x003E2A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB9B RID: 109467 RVA: 0x003E48C4 File Offset: 0x003E2AC4
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

		// Token: 0x0601AB9C RID: 109468 RVA: 0x003E4909 File Offset: 0x003E2B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB9D RID: 109469 RVA: 0x003E4916 File Offset: 0x003E2B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB9E RID: 109470 RVA: 0x003E491F File Offset: 0x003E2B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB9F RID: 109471 RVA: 0x003E4954 File Offset: 0x003E2B54
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

		// Token: 0x0601ABA0 RID: 109472 RVA: 0x003E4992 File Offset: 0x003E2B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourRewardResponse other)
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

		// Token: 0x0601ABA1 RID: 109473 RVA: 0x003E49C3 File Offset: 0x003E2BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x003E49CC File Offset: 0x003E2BCC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009C79 RID: 40057
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C7A RID: 40058
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009C7B RID: 40059
		private ErrorCode errorCode_;
	}
}
