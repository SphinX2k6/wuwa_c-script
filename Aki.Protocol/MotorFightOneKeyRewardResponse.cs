using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3C RID: 2620
	[NetMessage(EMessageId.MotorFightOneKeyRewardResponse)]
	public sealed class MotorFightOneKeyRewardResponse : IMessage<MotorFightOneKeyRewardResponse>, IMessage, IEquatable<MotorFightOneKeyRewardResponse>, IDeepCloneable<MotorFightOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E50B RID: 58635 RVA: 0x0021800D File Offset: 0x0021620D
		[NullableContext(1)]
		public static MotorFightOneKeyRewardResponse Create()
		{
			return new MotorFightOneKeyRewardResponse();
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600E50C RID: 58636 RVA: 0x00218014 File Offset: 0x00216214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600E50D RID: 58637 RVA: 0x00218017 File Offset: 0x00216217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E50E RID: 58638 RVA: 0x0021801E File Offset: 0x0021621E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse()
		{
		}

		// Token: 0x0600E50F RID: 58639 RVA: 0x00218026 File Offset: 0x00216226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse(MotorFightOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E510 RID: 58640 RVA: 0x0021804B File Offset: 0x0021624B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse Clone()
		{
			return new MotorFightOneKeyRewardResponse(this);
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600E511 RID: 58641 RVA: 0x00218053 File Offset: 0x00216253
		// (set) Token: 0x0600E512 RID: 58642 RVA: 0x0021805B File Offset: 0x0021625B
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

		// Token: 0x0600E513 RID: 58643 RVA: 0x00218064 File Offset: 0x00216264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightOneKeyRewardResponse);
		}

		// Token: 0x0600E514 RID: 58644 RVA: 0x00218072 File Offset: 0x00216272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x002180A0 File Offset: 0x002162A0
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

		// Token: 0x0600E516 RID: 58646 RVA: 0x002180E5 File Offset: 0x002162E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x002180F2 File Offset: 0x002162F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E518 RID: 58648 RVA: 0x002180FB File Offset: 0x002162FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E519 RID: 58649 RVA: 0x00218130 File Offset: 0x00216330
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

		// Token: 0x0600E51A RID: 58650 RVA: 0x0021816E File Offset: 0x0021636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightOneKeyRewardResponse other)
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

		// Token: 0x0600E51B RID: 58651 RVA: 0x0021819F File Offset: 0x0021639F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E51C RID: 58652 RVA: 0x002181A8 File Offset: 0x002163A8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DFB RID: 24059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DFC RID: 24060
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005DFD RID: 24061
		private ErrorCode errorCode_;
	}
}
