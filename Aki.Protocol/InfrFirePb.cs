using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DB RID: 2011
	public sealed class InfrFirePb : IMessage<InfrFirePb>, IMessage, IEquatable<InfrFirePb>, IDeepCloneable<InfrFirePb>, IBufferMessage
	{
		// Token: 0x0600B498 RID: 46232 RVA: 0x001AFA91 File Offset: 0x001ADC91
		[NullableContext(1)]
		public static InfrFirePb Create()
		{
			return new InfrFirePb();
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x001AFA98 File Offset: 0x001ADC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x001AFA9B File Offset: 0x001ADC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFirePb.Descriptor;
			}
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x001AFAA2 File Offset: 0x001ADCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb()
		{
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x001AFAAC File Offset: 0x001ADCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb(InfrFirePb other) : this()
		{
			this.fireExp_ = other.fireExp_;
			this.fireLevel_ = other.fireLevel_;
			this.fireLevelReachTime_ = other.fireLevelReachTime_;
			this.fireStatus_ = other.fireStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x001AFB00 File Offset: 0x001ADD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb Clone()
		{
			return new InfrFirePb(this);
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600B49E RID: 46238 RVA: 0x001AFB08 File Offset: 0x001ADD08
		// (set) Token: 0x0600B49F RID: 46239 RVA: 0x001AFB10 File Offset: 0x001ADD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireExp
		{
			get
			{
				return this.fireExp_;
			}
			set
			{
				this.fireExp_ = value;
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600B4A0 RID: 46240 RVA: 0x001AFB19 File Offset: 0x001ADD19
		// (set) Token: 0x0600B4A1 RID: 46241 RVA: 0x001AFB21 File Offset: 0x001ADD21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FireLevel
		{
			get
			{
				return this.fireLevel_;
			}
			set
			{
				this.fireLevel_ = value;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x001AFB2A File Offset: 0x001ADD2A
		// (set) Token: 0x0600B4A3 RID: 46243 RVA: 0x001AFB32 File Offset: 0x001ADD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireLevelReachTime
		{
			get
			{
				return this.fireLevelReachTime_;
			}
			set
			{
				this.fireLevelReachTime_ = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x001AFB3B File Offset: 0x001ADD3B
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x001AFB43 File Offset: 0x001ADD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrStatusPb FireStatus
		{
			get
			{
				return this.fireStatus_;
			}
			set
			{
				this.fireStatus_ = value;
			}
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x001AFB4C File Offset: 0x001ADD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFirePb);
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x001AFB5C File Offset: 0x001ADD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFirePb other)
		{
			return other != null && (other == this || (this.FireExp == other.FireExp && this.FireLevel == other.FireLevel && this.FireLevelReachTime == other.FireLevelReachTime && this.FireStatus == other.FireStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x001AFBC8 File Offset: 0x001ADDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FireExp != 0L)
			{
				num ^= this.FireExp.GetHashCode();
			}
			if (this.FireLevel != 0)
			{
				num ^= this.FireLevel.GetHashCode();
			}
			if (this.FireLevelReachTime != 0L)
			{
				num ^= this.FireLevelReachTime.GetHashCode();
			}
			if (this.FireStatus != InfrStatusPb.InfrStatusLock)
			{
				num ^= this.FireStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x001AFC58 File Offset: 0x001ADE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x001AFC65 File Offset: 0x001ADE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x001AFC70 File Offset: 0x001ADE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FireExp != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrStatusPb.InfrStatusLock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x001AFD00 File Offset: 0x001ADF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FireExp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrStatusPb.InfrStatusLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x001AFD88 File Offset: 0x001ADF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFirePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FireExp != 0L)
			{
				this.FireExp = other.FireExp;
			}
			if (other.FireLevel != 0)
			{
				this.FireLevel = other.FireLevel;
			}
			if (other.FireLevelReachTime != 0L)
			{
				this.FireLevelReachTime = other.FireLevelReachTime;
			}
			if (other.FireStatus != InfrStatusPb.InfrStatusLock)
			{
				this.FireStatus = other.FireStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x001AFE00 File Offset: 0x001AE000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x001AFE0C File Offset: 0x001AE00C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FireExp = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.FireLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FireLevelReachTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.FireStatus = (InfrStatusPb)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005052 RID: 20562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005053 RID: 20563
		public const int FireExpFieldNumber = 1;

		// Token: 0x04005054 RID: 20564
		private long fireExp_;

		// Token: 0x04005055 RID: 20565
		public const int FireLevelFieldNumber = 2;

		// Token: 0x04005056 RID: 20566
		private int fireLevel_;

		// Token: 0x04005057 RID: 20567
		public const int FireLevelReachTimeFieldNumber = 3;

		// Token: 0x04005058 RID: 20568
		private long fireLevelReachTime_;

		// Token: 0x04005059 RID: 20569
		public const int FireStatusFieldNumber = 4;

		// Token: 0x0400505A RID: 20570
		private InfrStatusPb fireStatus_;
	}
}
