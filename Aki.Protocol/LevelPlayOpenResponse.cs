using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000901 RID: 2305
	[NetMessage(EMessageId.LevelPlayOpenResponse)]
	public sealed class LevelPlayOpenResponse : IMessage<LevelPlayOpenResponse>, IMessage, IEquatable<LevelPlayOpenResponse>, IDeepCloneable<LevelPlayOpenResponse>, IBufferMessage
	{
		// Token: 0x0600CB9C RID: 52124 RVA: 0x001E07CF File Offset: 0x001DE9CF
		[NullableContext(1)]
		public static LevelPlayOpenResponse Create()
		{
			return new LevelPlayOpenResponse();
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x001E07D6 File Offset: 0x001DE9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600CB9E RID: 52126 RVA: 0x001E07D9 File Offset: 0x001DE9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenResponse.Descriptor;
			}
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x001E07E0 File Offset: 0x001DE9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse()
		{
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x001E07E8 File Offset: 0x001DE9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse(LevelPlayOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x001E0819 File Offset: 0x001DEA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenResponse Clone()
		{
			return new LevelPlayOpenResponse(this);
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x001E0821 File Offset: 0x001DEA21
		// (set) Token: 0x0600CBA3 RID: 52131 RVA: 0x001E0829 File Offset: 0x001DEA29
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

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x001E0832 File Offset: 0x001DEA32
		// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x001E083A File Offset: 0x001DEA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x001E0843 File Offset: 0x001DEA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenResponse);
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x001E0851 File Offset: 0x001DEA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x001E0890 File Offset: 0x001DEA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x001E08EE File Offset: 0x001DEAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x001E08FB File Offset: 0x001DEAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x001E0904 File Offset: 0x001DEB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x001E0960 File Offset: 0x001DEB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x001E09B8 File Offset: 0x001DEBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x001E0A08 File Offset: 0x001DEC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x001E0A14 File Offset: 0x001DEC14
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005675 RID: 22133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005676 RID: 22134
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005677 RID: 22135
		private ErrorCode errorCode_;

		// Token: 0x04005678 RID: 22136
		public const int LevelPlayIdFieldNumber = 11;

		// Token: 0x04005679 RID: 22137
		private int levelPlayId_;
	}
}
