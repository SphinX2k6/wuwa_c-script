using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078A RID: 1930
	[NetMessage(EMessageId.HonamiStoryLimitTaskRewardResponse)]
	public sealed class HonamiStoryLimitTaskRewardResponse : IMessage<HonamiStoryLimitTaskRewardResponse>, IMessage, IEquatable<HonamiStoryLimitTaskRewardResponse>, IDeepCloneable<HonamiStoryLimitTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AE4D RID: 44621 RVA: 0x001A2D26 File Offset: 0x001A0F26
		[NullableContext(1)]
		public static HonamiStoryLimitTaskRewardResponse Create()
		{
			return new HonamiStoryLimitTaskRewardResponse();
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600AE4E RID: 44622 RVA: 0x001A2D2D File Offset: 0x001A0F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600AE4F RID: 44623 RVA: 0x001A2D30 File Offset: 0x001A0F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x001A2D37 File Offset: 0x001A0F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse()
		{
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x001A2D3F File Offset: 0x001A0F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse(HonamiStoryLimitTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x001A2D64 File Offset: 0x001A0F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskRewardResponse Clone()
		{
			return new HonamiStoryLimitTaskRewardResponse(this);
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x001A2D6C File Offset: 0x001A0F6C
		// (set) Token: 0x0600AE54 RID: 44628 RVA: 0x001A2D74 File Offset: 0x001A0F74
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

		// Token: 0x0600AE55 RID: 44629 RVA: 0x001A2D7D File Offset: 0x001A0F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskRewardResponse);
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x001A2D8B File Offset: 0x001A0F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x001A2DBC File Offset: 0x001A0FBC
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

		// Token: 0x0600AE58 RID: 44632 RVA: 0x001A2E01 File Offset: 0x001A1001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x001A2E0E File Offset: 0x001A100E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x001A2E17 File Offset: 0x001A1017
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

		// Token: 0x0600AE5B RID: 44635 RVA: 0x001A2E4C File Offset: 0x001A104C
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

		// Token: 0x0600AE5C RID: 44636 RVA: 0x001A2E8A File Offset: 0x001A108A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitTaskRewardResponse other)
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

		// Token: 0x0600AE5D RID: 44637 RVA: 0x001A2EBB File Offset: 0x001A10BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x001A2EC4 File Offset: 0x001A10C4
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

		// Token: 0x04004EB2 RID: 20146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB3 RID: 20147
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004EB4 RID: 20148
		private ErrorCode errorCode_;
	}
}
