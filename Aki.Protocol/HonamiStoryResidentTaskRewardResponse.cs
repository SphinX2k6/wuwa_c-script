using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079B RID: 1947
	[NetMessage(EMessageId.HonamiStoryResidentTaskRewardResponse)]
	public sealed class HonamiStoryResidentTaskRewardResponse : IMessage<HonamiStoryResidentTaskRewardResponse>, IMessage, IEquatable<HonamiStoryResidentTaskRewardResponse>, IDeepCloneable<HonamiStoryResidentTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AF99 RID: 44953 RVA: 0x001A56A8 File Offset: 0x001A38A8
		[NullableContext(1)]
		public static HonamiStoryResidentTaskRewardResponse Create()
		{
			return new HonamiStoryResidentTaskRewardResponse();
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x0600AF9A RID: 44954 RVA: 0x001A56AF File Offset: 0x001A38AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x0600AF9B RID: 44955 RVA: 0x001A56B2 File Offset: 0x001A38B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x001A56B9 File Offset: 0x001A38B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse()
		{
		}

		// Token: 0x0600AF9D RID: 44957 RVA: 0x001A56C1 File Offset: 0x001A38C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse(HonamiStoryResidentTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF9E RID: 44958 RVA: 0x001A56E6 File Offset: 0x001A38E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardResponse Clone()
		{
			return new HonamiStoryResidentTaskRewardResponse(this);
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x0600AF9F RID: 44959 RVA: 0x001A56EE File Offset: 0x001A38EE
		// (set) Token: 0x0600AFA0 RID: 44960 RVA: 0x001A56F6 File Offset: 0x001A38F6
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

		// Token: 0x0600AFA1 RID: 44961 RVA: 0x001A56FF File Offset: 0x001A38FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskRewardResponse);
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x001A570D File Offset: 0x001A390D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x001A573C File Offset: 0x001A393C
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

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x001A5781 File Offset: 0x001A3981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x001A578E File Offset: 0x001A398E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x001A5797 File Offset: 0x001A3997
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

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x001A57CC File Offset: 0x001A39CC
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

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x001A580A File Offset: 0x001A3A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskRewardResponse other)
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

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x001A583B File Offset: 0x001A3A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFAA RID: 44970 RVA: 0x001A5844 File Offset: 0x001A3A44
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

		// Token: 0x04004F05 RID: 20229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F06 RID: 20230
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004F07 RID: 20231
		private ErrorCode errorCode_;
	}
}
