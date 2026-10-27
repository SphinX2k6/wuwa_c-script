using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A98 RID: 2712
	[NetMessage(EMessageId.MotorParkourResultNotify)]
	public sealed class MotorParkourResultNotify : IMessage<MotorParkourResultNotify>, IMessage, IEquatable<MotorParkourResultNotify>, IDeepCloneable<MotorParkourResultNotify>, IBufferMessage
	{
		// Token: 0x0600EC20 RID: 60448 RVA: 0x00227771 File Offset: 0x00225971
		[NullableContext(1)]
		public static MotorParkourResultNotify Create()
		{
			return new MotorParkourResultNotify();
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600EC21 RID: 60449 RVA: 0x00227778 File Offset: 0x00225978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600EC22 RID: 60450 RVA: 0x0022777B File Offset: 0x0022597B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourResultNotify.Descriptor;
			}
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x00227782 File Offset: 0x00225982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify()
		{
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x0022778A File Offset: 0x0022598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify(MotorParkourResultNotify other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this.isSuccess_ = other.isSuccess_;
			this.timeRecord_ = other.timeRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x002277C7 File Offset: 0x002259C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify Clone()
		{
			return new MotorParkourResultNotify(this);
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600EC26 RID: 60454 RVA: 0x002277CF File Offset: 0x002259CF
		// (set) Token: 0x0600EC27 RID: 60455 RVA: 0x002277D7 File Offset: 0x002259D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorParkourId
		{
			get
			{
				return this.motorParkourId_;
			}
			set
			{
				this.motorParkourId_ = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600EC28 RID: 60456 RVA: 0x002277E0 File Offset: 0x002259E0
		// (set) Token: 0x0600EC29 RID: 60457 RVA: 0x002277E8 File Offset: 0x002259E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600EC2A RID: 60458 RVA: 0x002277F1 File Offset: 0x002259F1
		// (set) Token: 0x0600EC2B RID: 60459 RVA: 0x002277F9 File Offset: 0x002259F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeRecord
		{
			get
			{
				return this.timeRecord_;
			}
			set
			{
				this.timeRecord_ = value;
			}
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x00227802 File Offset: 0x00225A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourResultNotify);
		}

		// Token: 0x0600EC2D RID: 60461 RVA: 0x00227810 File Offset: 0x00225A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourResultNotify other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.IsSuccess == other.IsSuccess && this.TimeRecord == other.TimeRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC2E RID: 60462 RVA: 0x0022786C File Offset: 0x00225A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorParkourId != 0)
			{
				num ^= this.MotorParkourId.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.TimeRecord != 0)
			{
				num ^= this.TimeRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC2F RID: 60463 RVA: 0x002278DD File Offset: 0x00225ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC30 RID: 60464 RVA: 0x002278EA File Offset: 0x00225AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x002278F4 File Offset: 0x00225AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSuccess)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSuccess);
			}
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MotorParkourId);
			}
			if (this.TimeRecord != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TimeRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x0022796C File Offset: 0x00225B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorParkourId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorParkourId);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.TimeRecord != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeRecord);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x002279D0 File Offset: 0x00225BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorParkourId != 0)
			{
				this.MotorParkourId = other.MotorParkourId;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.TimeRecord != 0)
			{
				this.TimeRecord = other.TimeRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC34 RID: 60468 RVA: 0x00227A34 File Offset: 0x00225C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x00227A40 File Offset: 0x00225C40
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
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TimeRecord = input.ReadInt32();
						}
					}
					else
					{
						this.MotorParkourId = input.ReadInt32();
					}
				}
				else
				{
					this.IsSuccess = input.ReadBool();
				}
			}
		}

		// Token: 0x04005FBF RID: 24511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FC0 RID: 24512
		public const int MotorParkourIdFieldNumber = 7;

		// Token: 0x04005FC1 RID: 24513
		private int motorParkourId_;

		// Token: 0x04005FC2 RID: 24514
		public const int IsSuccessFieldNumber = 2;

		// Token: 0x04005FC3 RID: 24515
		private bool isSuccess_;

		// Token: 0x04005FC4 RID: 24516
		public const int TimeRecordFieldNumber = 9;

		// Token: 0x04005FC5 RID: 24517
		private int timeRecord_;
	}
}
