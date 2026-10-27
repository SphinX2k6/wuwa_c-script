using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6D RID: 2669
	[NetMessage(EMessageId.MotorFightTalentUpRequest)]
	public sealed class MotorFightTalentUpRequest : IMessage<MotorFightTalentUpRequest>, IMessage, IEquatable<MotorFightTalentUpRequest>, IDeepCloneable<MotorFightTalentUpRequest>, IBufferMessage
	{
		// Token: 0x0600E8C8 RID: 59592 RVA: 0x0022011D File Offset: 0x0021E31D
		[NullableContext(1)]
		public static MotorFightTalentUpRequest Create()
		{
			return new MotorFightTalentUpRequest();
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x00220124 File Offset: 0x0021E324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600E8CA RID: 59594 RVA: 0x00220127 File Offset: 0x0021E327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentUpRequest.Descriptor;
			}
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x0022012E File Offset: 0x0021E32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest()
		{
		}

		// Token: 0x0600E8CC RID: 59596 RVA: 0x00220136 File Offset: 0x0021E336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest(MotorFightTalentUpRequest other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8CD RID: 59597 RVA: 0x0022015B File Offset: 0x0021E35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpRequest Clone()
		{
			return new MotorFightTalentUpRequest(this);
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600E8CE RID: 59598 RVA: 0x00220163 File Offset: 0x0021E363
		// (set) Token: 0x0600E8CF RID: 59599 RVA: 0x0022016B File Offset: 0x0021E36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x00220174 File Offset: 0x0021E374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentUpRequest);
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x00220182 File Offset: 0x0021E382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentUpRequest other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8D2 RID: 59602 RVA: 0x002201B0 File Offset: 0x0021E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x002201EF File Offset: 0x0021E3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x002201FC File Offset: 0x0021E3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x00220205 File Offset: 0x0021E405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x00220238 File Offset: 0x0021E438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00220276 File Offset: 0x0021E476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x002202A7 File Offset: 0x0021E4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x002202B0 File Offset: 0x0021E4B0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EC1 RID: 24257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EC2 RID: 24258
		public const int TalentIdFieldNumber = 1;

		// Token: 0x04005EC3 RID: 24259
		private int talentId_;
	}
}
