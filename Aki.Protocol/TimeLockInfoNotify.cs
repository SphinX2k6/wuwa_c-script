using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001377 RID: 4983
	[NetMessage(EMessageId.TimeLockInfoNotify)]
	public sealed class TimeLockInfoNotify : IMessage<TimeLockInfoNotify>, IMessage, IEquatable<TimeLockInfoNotify>, IDeepCloneable<TimeLockInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A753 RID: 108371 RVA: 0x003D748C File Offset: 0x003D568C
		[NullableContext(1)]
		public static TimeLockInfoNotify Create()
		{
			return new TimeLockInfoNotify();
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x0601A754 RID: 108372 RVA: 0x003D7493 File Offset: 0x003D5693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x0601A755 RID: 108373 RVA: 0x003D7496 File Offset: 0x003D5696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeLockInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A756 RID: 108374 RVA: 0x003D749D File Offset: 0x003D569D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify()
		{
		}

		// Token: 0x0601A757 RID: 108375 RVA: 0x003D74A5 File Offset: 0x003D56A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify(TimeLockInfoNotify other) : this()
		{
			this.isLock_ = other.isLock_;
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A758 RID: 108376 RVA: 0x003D74E2 File Offset: 0x003D56E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify Clone()
		{
			return new TimeLockInfoNotify(this);
		}

		// Token: 0x17005940 RID: 22848
		// (get) Token: 0x0601A759 RID: 108377 RVA: 0x003D74EA File Offset: 0x003D56EA
		// (set) Token: 0x0601A75A RID: 108378 RVA: 0x003D74F2 File Offset: 0x003D56F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x17005941 RID: 22849
		// (get) Token: 0x0601A75B RID: 108379 RVA: 0x003D74FB File Offset: 0x003D56FB
		// (set) Token: 0x0601A75C RID: 108380 RVA: 0x003D7503 File Offset: 0x003D5703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Hour
		{
			get
			{
				return this.hour_;
			}
			set
			{
				this.hour_ = value;
			}
		}

		// Token: 0x17005942 RID: 22850
		// (get) Token: 0x0601A75D RID: 108381 RVA: 0x003D750C File Offset: 0x003D570C
		// (set) Token: 0x0601A75E RID: 108382 RVA: 0x003D7514 File Offset: 0x003D5714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Minute
		{
			get
			{
				return this.minute_;
			}
			set
			{
				this.minute_ = value;
			}
		}

		// Token: 0x0601A75F RID: 108383 RVA: 0x003D751D File Offset: 0x003D571D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeLockInfoNotify);
		}

		// Token: 0x0601A760 RID: 108384 RVA: 0x003D752C File Offset: 0x003D572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeLockInfoNotify other)
		{
			return other != null && (other == this || (this.IsLock == other.IsLock && this.Hour == other.Hour && this.Minute == other.Minute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A761 RID: 108385 RVA: 0x003D7588 File Offset: 0x003D5788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this.Hour != 0L)
			{
				num ^= this.Hour.GetHashCode();
			}
			if (this.Minute != 0L)
			{
				num ^= this.Minute.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A762 RID: 108386 RVA: 0x003D75F9 File Offset: 0x003D57F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A763 RID: 108387 RVA: 0x003D7606 File Offset: 0x003D5806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A764 RID: 108388 RVA: 0x003D7610 File Offset: 0x003D5810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLock)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsLock);
			}
			if (this.Hour != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Hour);
			}
			if (this.Minute != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Minute);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A765 RID: 108389 RVA: 0x003D7684 File Offset: 0x003D5884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsLock)
			{
				num += 2;
			}
			if (this.Hour != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Hour);
			}
			if (this.Minute != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Minute);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A766 RID: 108390 RVA: 0x003D76E8 File Offset: 0x003D58E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeLockInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			if (other.Hour != 0L)
			{
				this.Hour = other.Hour;
			}
			if (other.Minute != 0L)
			{
				this.Minute = other.Minute;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A767 RID: 108391 RVA: 0x003D774C File Offset: 0x003D594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A768 RID: 108392 RVA: 0x003D7758 File Offset: 0x003D5958
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
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Minute = input.ReadInt64();
						}
					}
					else
					{
						this.Hour = input.ReadInt64();
					}
				}
				else
				{
					this.IsLock = input.ReadBool();
				}
			}
		}

		// Token: 0x04009A05 RID: 39429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A06 RID: 39430
		public const int IsLockFieldNumber = 1;

		// Token: 0x04009A07 RID: 39431
		private bool isLock_;

		// Token: 0x04009A08 RID: 39432
		public const int HourFieldNumber = 8;

		// Token: 0x04009A09 RID: 39433
		private long hour_;

		// Token: 0x04009A0A RID: 39434
		public const int MinuteFieldNumber = 10;

		// Token: 0x04009A0B RID: 39435
		private long minute_;
	}
}
