using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BC RID: 1724
	[NetMessage(EMessageId.GetRewardTreasureBoxResponse)]
	public sealed class GetRewardTreasureBoxResponse : IMessage<GetRewardTreasureBoxResponse>, IMessage, IEquatable<GetRewardTreasureBoxResponse>, IDeepCloneable<GetRewardTreasureBoxResponse>, IBufferMessage
	{
		// Token: 0x06009E0E RID: 40462 RVA: 0x0017FBF9 File Offset: 0x0017DDF9
		[NullableContext(1)]
		public static GetRewardTreasureBoxResponse Create()
		{
			return new GetRewardTreasureBoxResponse();
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x0017FC00 File Offset: 0x0017DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06009E10 RID: 40464 RVA: 0x0017FC03 File Offset: 0x0017DE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRewardTreasureBoxResponse.Descriptor;
			}
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x0017FC0A File Offset: 0x0017DE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse()
		{
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x0017FC12 File Offset: 0x0017DE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse(GetRewardTreasureBoxResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x0017FC37 File Offset: 0x0017DE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRewardTreasureBoxResponse Clone()
		{
			return new GetRewardTreasureBoxResponse(this);
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06009E14 RID: 40468 RVA: 0x0017FC3F File Offset: 0x0017DE3F
		// (set) Token: 0x06009E15 RID: 40469 RVA: 0x0017FC47 File Offset: 0x0017DE47
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

		// Token: 0x06009E16 RID: 40470 RVA: 0x0017FC50 File Offset: 0x0017DE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRewardTreasureBoxResponse);
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x0017FC5E File Offset: 0x0017DE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRewardTreasureBoxResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x0017FC8C File Offset: 0x0017DE8C
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

		// Token: 0x06009E19 RID: 40473 RVA: 0x0017FCD1 File Offset: 0x0017DED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E1A RID: 40474 RVA: 0x0017FCDE File Offset: 0x0017DEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x0017FCE7 File Offset: 0x0017DEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06009E1C RID: 40476 RVA: 0x0017FD1C File Offset: 0x0017DF1C
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

		// Token: 0x06009E1D RID: 40477 RVA: 0x0017FD5A File Offset: 0x0017DF5A
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

		// Token: 0x06009E1E RID: 40478 RVA: 0x0017FD8B File Offset: 0x0017DF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x0017FD94 File Offset: 0x0017DF94
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A65 RID: 19045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A66 RID: 19046
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004A67 RID: 19047
		private ErrorCode errorCode_;
	}
}
