using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A87 RID: 2695
	[NetMessage(EMessageId.MotorParkourResultNotify)]
	public sealed class MotorParkourResultNotify : IMessage<MotorParkourResultNotify>, IMessage, IEquatable<MotorParkourResultNotify>, IDeepCloneable<MotorParkourResultNotify>, IBufferMessage
	{
		// Token: 0x0600EB06 RID: 60166 RVA: 0x00225579 File Offset: 0x00223779
		[NullableContext(1)]
		public static MotorParkourResultNotify Create()
		{
			return new MotorParkourResultNotify();
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600EB07 RID: 60167 RVA: 0x00225580 File Offset: 0x00223780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x00225583 File Offset: 0x00223783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourResultNotify.Descriptor;
			}
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x0022558A File Offset: 0x0022378A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify()
		{
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x00225592 File Offset: 0x00223792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify(MotorParkourResultNotify other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this.isSuccess_ = other.isSuccess_;
			this.timeRecord_ = other.timeRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x002255CF File Offset: 0x002237CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourResultNotify Clone()
		{
			return new MotorParkourResultNotify(this);
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600EB0C RID: 60172 RVA: 0x002255D7 File Offset: 0x002237D7
		// (set) Token: 0x0600EB0D RID: 60173 RVA: 0x002255DF File Offset: 0x002237DF
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

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600EB0E RID: 60174 RVA: 0x002255E8 File Offset: 0x002237E8
		// (set) Token: 0x0600EB0F RID: 60175 RVA: 0x002255F0 File Offset: 0x002237F0
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

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600EB10 RID: 60176 RVA: 0x002255F9 File Offset: 0x002237F9
		// (set) Token: 0x0600EB11 RID: 60177 RVA: 0x00225601 File Offset: 0x00223801
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

		// Token: 0x0600EB12 RID: 60178 RVA: 0x0022560A File Offset: 0x0022380A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourResultNotify);
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x00225618 File Offset: 0x00223818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourResultNotify other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.IsSuccess == other.IsSuccess && this.TimeRecord == other.TimeRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x00225674 File Offset: 0x00223874
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

		// Token: 0x0600EB15 RID: 60181 RVA: 0x002256E5 File Offset: 0x002238E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x002256F2 File Offset: 0x002238F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x002256FC File Offset: 0x002238FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeRecord != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TimeRecord);
			}
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MotorParkourId);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x00225774 File Offset: 0x00223974
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

		// Token: 0x0600EB19 RID: 60185 RVA: 0x002257D8 File Offset: 0x002239D8
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

		// Token: 0x0600EB1A RID: 60186 RVA: 0x0022583C File Offset: 0x00223A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x00225848 File Offset: 0x00223A48
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
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsSuccess = input.ReadBool();
						}
					}
					else
					{
						this.MotorParkourId = input.ReadInt32();
					}
				}
				else
				{
					this.TimeRecord = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FC8 RID: 24520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FC9 RID: 24521
		public const int MotorParkourIdFieldNumber = 9;

		// Token: 0x04005FCA RID: 24522
		private int motorParkourId_;

		// Token: 0x04005FCB RID: 24523
		public const int IsSuccessFieldNumber = 11;

		// Token: 0x04005FCC RID: 24524
		private bool isSuccess_;

		// Token: 0x04005FCD RID: 24525
		public const int TimeRecordFieldNumber = 4;

		// Token: 0x04005FCE RID: 24526
		private int timeRecord_;
	}
}
