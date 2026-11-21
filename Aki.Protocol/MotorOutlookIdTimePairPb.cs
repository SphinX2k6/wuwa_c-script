using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A77 RID: 2679
	public sealed class MotorOutlookIdTimePairPb : IMessage<MotorOutlookIdTimePairPb>, IMessage, IEquatable<MotorOutlookIdTimePairPb>, IDeepCloneable<MotorOutlookIdTimePairPb>, IBufferMessage
	{
		// Token: 0x0600E9C3 RID: 59843 RVA: 0x00222714 File Offset: 0x00220914
		[NullableContext(1)]
		public static MotorOutlookIdTimePairPb Create()
		{
			return new MotorOutlookIdTimePairPb();
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x0022271B File Offset: 0x0022091B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookIdTimePairPb> Parser
		{
			get
			{
				return MotorOutlookIdTimePairPb._parser;
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600E9C5 RID: 59845 RVA: 0x00222722 File Offset: 0x00220922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x00222725 File Offset: 0x00220925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookIdTimePairPb.Descriptor;
			}
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x0022272C File Offset: 0x0022092C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb()
		{
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x00222734 File Offset: 0x00220934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb(MotorOutlookIdTimePairPb other) : this()
		{
			this.id_ = other.id_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x00222765 File Offset: 0x00220965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb Clone()
		{
			return new MotorOutlookIdTimePairPb(this);
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x0022276D File Offset: 0x0022096D
		// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x00222775 File Offset: 0x00220975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x0022277E File Offset: 0x0022097E
		// (set) Token: 0x0600E9CD RID: 59853 RVA: 0x00222786 File Offset: 0x00220986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x0022278F File Offset: 0x0022098F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookIdTimePairPb);
		}

		// Token: 0x0600E9CF RID: 59855 RVA: 0x0022279D File Offset: 0x0022099D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookIdTimePairPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x002227DC File Offset: 0x002209DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x00222834 File Offset: 0x00220A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x00222841 File Offset: 0x00220A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x0022284C File Offset: 0x00220A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x002228A4 File Offset: 0x00220AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x002228FC File Offset: 0x00220AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookIdTimePairPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x0022294C File Offset: 0x00220B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x00222958 File Offset: 0x00220B58
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OpenTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F5F RID: 24415
		private static readonly MessageParser<MotorOutlookIdTimePairPb> _parser = new MessageParser<MotorOutlookIdTimePairPb>(() => new MotorOutlookIdTimePairPb());

		// Token: 0x04005F60 RID: 24416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F61 RID: 24417
		public const int IdFieldNumber = 1;

		// Token: 0x04005F62 RID: 24418
		private int id_;

		// Token: 0x04005F63 RID: 24419
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04005F64 RID: 24420
		private long openTime_;
	}
}
