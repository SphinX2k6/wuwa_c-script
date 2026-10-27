using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A88 RID: 2696
	public sealed class MotorOutlookIdTimePairPb : IMessage<MotorOutlookIdTimePairPb>, IMessage, IEquatable<MotorOutlookIdTimePairPb>, IDeepCloneable<MotorOutlookIdTimePairPb>, IBufferMessage
	{
		// Token: 0x0600EADD RID: 60125 RVA: 0x00224910 File Offset: 0x00222B10
		[NullableContext(1)]
		public static MotorOutlookIdTimePairPb Create()
		{
			return new MotorOutlookIdTimePairPb();
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600EADE RID: 60126 RVA: 0x00224917 File Offset: 0x00222B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOutlookIdTimePairPb> Parser
		{
			get
			{
				return MotorOutlookIdTimePairPb._parser;
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600EADF RID: 60127 RVA: 0x0022491E File Offset: 0x00222B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600EAE0 RID: 60128 RVA: 0x00224921 File Offset: 0x00222B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookIdTimePairPb.Descriptor;
			}
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x00224928 File Offset: 0x00222B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb()
		{
		}

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x00224930 File Offset: 0x00222B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb(MotorOutlookIdTimePairPb other) : this()
		{
			this.id_ = other.id_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00224961 File Offset: 0x00222B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookIdTimePairPb Clone()
		{
			return new MotorOutlookIdTimePairPb(this);
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600EAE4 RID: 60132 RVA: 0x00224969 File Offset: 0x00222B69
		// (set) Token: 0x0600EAE5 RID: 60133 RVA: 0x00224971 File Offset: 0x00222B71
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

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600EAE6 RID: 60134 RVA: 0x0022497A File Offset: 0x00222B7A
		// (set) Token: 0x0600EAE7 RID: 60135 RVA: 0x00224982 File Offset: 0x00222B82
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

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x0022498B File Offset: 0x00222B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookIdTimePairPb);
		}

		// Token: 0x0600EAE9 RID: 60137 RVA: 0x00224999 File Offset: 0x00222B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookIdTimePairPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAEA RID: 60138 RVA: 0x002249D8 File Offset: 0x00222BD8
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

		// Token: 0x0600EAEB RID: 60139 RVA: 0x00224A30 File Offset: 0x00222C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x00224A3D File Offset: 0x00222C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x00224A48 File Offset: 0x00222C48
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

		// Token: 0x0600EAEE RID: 60142 RVA: 0x00224AA0 File Offset: 0x00222CA0
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

		// Token: 0x0600EAEF RID: 60143 RVA: 0x00224AF8 File Offset: 0x00222CF8
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

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x00224B48 File Offset: 0x00222D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00224B54 File Offset: 0x00222D54
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

		// Token: 0x04005F56 RID: 24406
		private static readonly MessageParser<MotorOutlookIdTimePairPb> _parser = new MessageParser<MotorOutlookIdTimePairPb>(() => new MotorOutlookIdTimePairPb());

		// Token: 0x04005F57 RID: 24407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F58 RID: 24408
		public const int IdFieldNumber = 1;

		// Token: 0x04005F59 RID: 24409
		private int id_;

		// Token: 0x04005F5A RID: 24410
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04005F5B RID: 24411
		private long openTime_;
	}
}
