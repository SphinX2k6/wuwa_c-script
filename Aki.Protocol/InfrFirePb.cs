using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C7 RID: 1991
	public sealed class InfrFirePb : IMessage<InfrFirePb>, IMessage, IEquatable<InfrFirePb>, IDeepCloneable<InfrFirePb>, IBufferMessage
	{
		// Token: 0x0600B342 RID: 45890 RVA: 0x001AD05D File Offset: 0x001AB25D
		[NullableContext(1)]
		public static InfrFirePb Create()
		{
			return new InfrFirePb();
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600B343 RID: 45891 RVA: 0x001AD064 File Offset: 0x001AB264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600B344 RID: 45892 RVA: 0x001AD067 File Offset: 0x001AB267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFirePb.Descriptor;
			}
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x001AD06E File Offset: 0x001AB26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb()
		{
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x001AD078 File Offset: 0x001AB278
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

		// Token: 0x0600B347 RID: 45895 RVA: 0x001AD0CC File Offset: 0x001AB2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb Clone()
		{
			return new InfrFirePb(this);
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x001AD0D4 File Offset: 0x001AB2D4
		// (set) Token: 0x0600B349 RID: 45897 RVA: 0x001AD0DC File Offset: 0x001AB2DC
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

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x001AD0E5 File Offset: 0x001AB2E5
		// (set) Token: 0x0600B34B RID: 45899 RVA: 0x001AD0ED File Offset: 0x001AB2ED
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

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x001AD0F6 File Offset: 0x001AB2F6
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x001AD0FE File Offset: 0x001AB2FE
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

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x001AD107 File Offset: 0x001AB307
		// (set) Token: 0x0600B34F RID: 45903 RVA: 0x001AD10F File Offset: 0x001AB30F
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

		// Token: 0x0600B350 RID: 45904 RVA: 0x001AD118 File Offset: 0x001AB318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFirePb);
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x001AD128 File Offset: 0x001AB328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFirePb other)
		{
			return other != null && (other == this || (this.FireExp == other.FireExp && this.FireLevel == other.FireLevel && this.FireLevelReachTime == other.FireLevelReachTime && this.FireStatus == other.FireStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x001AD194 File Offset: 0x001AB394
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

		// Token: 0x0600B353 RID: 45907 RVA: 0x001AD224 File Offset: 0x001AB424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x001AD231 File Offset: 0x001AB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x001AD23C File Offset: 0x001AB43C
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

		// Token: 0x0600B356 RID: 45910 RVA: 0x001AD2CC File Offset: 0x001AB4CC
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

		// Token: 0x0600B357 RID: 45911 RVA: 0x001AD354 File Offset: 0x001AB554
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

		// Token: 0x0600B358 RID: 45912 RVA: 0x001AD3CC File Offset: 0x001AB5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x001AD3D8 File Offset: 0x001AB5D8
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

		// Token: 0x0400504B RID: 20555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400504C RID: 20556
		public const int FireExpFieldNumber = 1;

		// Token: 0x0400504D RID: 20557
		private long fireExp_;

		// Token: 0x0400504E RID: 20558
		public const int FireLevelFieldNumber = 2;

		// Token: 0x0400504F RID: 20559
		private int fireLevel_;

		// Token: 0x04005050 RID: 20560
		public const int FireLevelReachTimeFieldNumber = 3;

		// Token: 0x04005051 RID: 20561
		private long fireLevelReachTime_;

		// Token: 0x04005052 RID: 20562
		public const int FireStatusFieldNumber = 4;

		// Token: 0x04005053 RID: 20563
		private InfrStatusPb fireStatus_;
	}
}
