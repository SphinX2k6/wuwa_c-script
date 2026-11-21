using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000328 RID: 808
	[NetMessage(EMessageId.DailyAdventureTaskRewardResponse)]
	public sealed class DailyAdventureTaskRewardResponse : IMessage<DailyAdventureTaskRewardResponse>, IMessage, IEquatable<DailyAdventureTaskRewardResponse>, IDeepCloneable<DailyAdventureTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005171 RID: 20849 RVA: 0x000C6A71 File Offset: 0x000C4C71
		[NullableContext(1)]
		public static DailyAdventureTaskRewardResponse Create()
		{
			return new DailyAdventureTaskRewardResponse();
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x000C6A78 File Offset: 0x000C4C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x000C6A7B File Offset: 0x000C4C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x000C6A82 File Offset: 0x000C4C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse()
		{
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x000C6A8A File Offset: 0x000C4C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse(DailyAdventureTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x000C6AAF File Offset: 0x000C4CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardResponse Clone()
		{
			return new DailyAdventureTaskRewardResponse(this);
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x000C6AB7 File Offset: 0x000C4CB7
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x000C6ABF File Offset: 0x000C4CBF
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

		// Token: 0x06005179 RID: 20857 RVA: 0x000C6AC8 File Offset: 0x000C4CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskRewardResponse);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x000C6AD6 File Offset: 0x000C4CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x000C6B04 File Offset: 0x000C4D04
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

		// Token: 0x0600517C RID: 20860 RVA: 0x000C6B49 File Offset: 0x000C4D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x000C6B56 File Offset: 0x000C4D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x000C6B5F File Offset: 0x000C4D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x000C6B94 File Offset: 0x000C4D94
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

		// Token: 0x06005180 RID: 20864 RVA: 0x000C6BD2 File Offset: 0x000C4DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureTaskRewardResponse other)
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

		// Token: 0x06005181 RID: 20865 RVA: 0x000C6C03 File Offset: 0x000C4E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x000C6C0C File Offset: 0x000C4E0C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003305 RID: 13061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003306 RID: 13062
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003307 RID: 13063
		private ErrorCode errorCode_;
	}
}
