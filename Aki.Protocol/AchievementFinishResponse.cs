using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005D RID: 93
	[NetMessage(EMessageId.AchievementFinishResponse)]
	public sealed class AchievementFinishResponse : IMessage<AchievementFinishResponse>, IMessage, IEquatable<AchievementFinishResponse>, IDeepCloneable<AchievementFinishResponse>, IBufferMessage
	{
		// Token: 0x0600160B RID: 5643 RVA: 0x0003A3D9 File Offset: 0x000385D9
		[NullableContext(1)]
		public static AchievementFinishResponse Create()
		{
			return new AchievementFinishResponse();
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0003A3E0 File Offset: 0x000385E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x0003A3E3 File Offset: 0x000385E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x0003A3EA File Offset: 0x000385EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse()
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0003A3F2 File Offset: 0x000385F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse(AchievementFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0003A417 File Offset: 0x00038617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementFinishResponse Clone()
		{
			return new AchievementFinishResponse(this);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0003A41F File Offset: 0x0003861F
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x0003A427 File Offset: 0x00038627
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

		// Token: 0x06001613 RID: 5651 RVA: 0x0003A430 File Offset: 0x00038630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementFinishResponse);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0003A43E File Offset: 0x0003863E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0003A46C File Offset: 0x0003866C
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

		// Token: 0x06001616 RID: 5654 RVA: 0x0003A4B1 File Offset: 0x000386B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0003A4BE File Offset: 0x000386BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0003A4C7 File Offset: 0x000386C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0003A4FC File Offset: 0x000386FC
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

		// Token: 0x0600161A RID: 5658 RVA: 0x0003A53A File Offset: 0x0003873A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementFinishResponse other)
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

		// Token: 0x0600161B RID: 5659 RVA: 0x0003A56B File Offset: 0x0003876B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0003A574 File Offset: 0x00038774
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002117 RID: 8471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002118 RID: 8472
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002119 RID: 8473
		private ErrorCode errorCode_;
	}
}
