using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A67 RID: 2663
	[NetMessage(EMessageId.MotorFightSelectCollectionResponse)]
	public sealed class MotorFightSelectCollectionResponse : IMessage<MotorFightSelectCollectionResponse>, IMessage, IEquatable<MotorFightSelectCollectionResponse>, IDeepCloneable<MotorFightSelectCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600E854 RID: 59476 RVA: 0x0021F367 File Offset: 0x0021D567
		[NullableContext(1)]
		public static MotorFightSelectCollectionResponse Create()
		{
			return new MotorFightSelectCollectionResponse();
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600E855 RID: 59477 RVA: 0x0021F36E File Offset: 0x0021D56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x0021F371 File Offset: 0x0021D571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600E857 RID: 59479 RVA: 0x0021F378 File Offset: 0x0021D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse()
		{
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x0021F380 File Offset: 0x0021D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse(MotorFightSelectCollectionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E859 RID: 59481 RVA: 0x0021F3A5 File Offset: 0x0021D5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionResponse Clone()
		{
			return new MotorFightSelectCollectionResponse(this);
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x0021F3AD File Offset: 0x0021D5AD
		// (set) Token: 0x0600E85B RID: 59483 RVA: 0x0021F3B5 File Offset: 0x0021D5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E85C RID: 59484 RVA: 0x0021F3BE File Offset: 0x0021D5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectCollectionResponse);
		}

		// Token: 0x0600E85D RID: 59485 RVA: 0x0021F3CC File Offset: 0x0021D5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E85E RID: 59486 RVA: 0x0021F3FC File Offset: 0x0021D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E85F RID: 59487 RVA: 0x0021F441 File Offset: 0x0021D641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E860 RID: 59488 RVA: 0x0021F44E File Offset: 0x0021D64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E861 RID: 59489 RVA: 0x0021F457 File Offset: 0x0021D657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E862 RID: 59490 RVA: 0x0021F48C File Offset: 0x0021D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E863 RID: 59491 RVA: 0x0021F4CA File Offset: 0x0021D6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectCollectionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E864 RID: 59492 RVA: 0x0021F4FB File Offset: 0x0021D6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E865 RID: 59493 RVA: 0x0021F504 File Offset: 0x0021D704
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EA6 RID: 24230
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EA7 RID: 24231
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04005EA8 RID: 24232
		private ErrorCode errCode_;
	}
}
