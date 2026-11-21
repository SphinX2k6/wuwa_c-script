using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EA RID: 5098
	[NetMessage(EMessageId.TimeLockInfoNotify)]
	public sealed class TimeLockInfoNotify : IMessage<TimeLockInfoNotify>, IMessage, IEquatable<TimeLockInfoNotify>, IDeepCloneable<TimeLockInfoNotify>, IBufferMessage
	{
		// Token: 0x0601B1DC RID: 111068 RVA: 0x003F26A0 File Offset: 0x003F08A0
		[NullableContext(1)]
		public static TimeLockInfoNotify Create()
		{
			return new TimeLockInfoNotify();
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x0601B1DD RID: 111069 RVA: 0x003F26A7 File Offset: 0x003F08A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x0601B1DE RID: 111070 RVA: 0x003F26AA File Offset: 0x003F08AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeLockInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601B1DF RID: 111071 RVA: 0x003F26B1 File Offset: 0x003F08B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify()
		{
		}

		// Token: 0x0601B1E0 RID: 111072 RVA: 0x003F26B9 File Offset: 0x003F08B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify(TimeLockInfoNotify other) : this()
		{
			this.isLock_ = other.isLock_;
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1E1 RID: 111073 RVA: 0x003F26F6 File Offset: 0x003F08F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeLockInfoNotify Clone()
		{
			return new TimeLockInfoNotify(this);
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x0601B1E2 RID: 111074 RVA: 0x003F26FE File Offset: 0x003F08FE
		// (set) Token: 0x0601B1E3 RID: 111075 RVA: 0x003F2706 File Offset: 0x003F0906
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

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x0601B1E4 RID: 111076 RVA: 0x003F270F File Offset: 0x003F090F
		// (set) Token: 0x0601B1E5 RID: 111077 RVA: 0x003F2717 File Offset: 0x003F0917
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

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x0601B1E6 RID: 111078 RVA: 0x003F2720 File Offset: 0x003F0920
		// (set) Token: 0x0601B1E7 RID: 111079 RVA: 0x003F2728 File Offset: 0x003F0928
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

		// Token: 0x0601B1E8 RID: 111080 RVA: 0x003F2731 File Offset: 0x003F0931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeLockInfoNotify);
		}

		// Token: 0x0601B1E9 RID: 111081 RVA: 0x003F2740 File Offset: 0x003F0940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeLockInfoNotify other)
		{
			return other != null && (other == this || (this.IsLock == other.IsLock && this.Hour == other.Hour && this.Minute == other.Minute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1EA RID: 111082 RVA: 0x003F279C File Offset: 0x003F099C
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

		// Token: 0x0601B1EB RID: 111083 RVA: 0x003F280D File Offset: 0x003F0A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1EC RID: 111084 RVA: 0x003F281A File Offset: 0x003F0A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1ED RID: 111085 RVA: 0x003F2824 File Offset: 0x003F0A24
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
				output.WriteRawTag(16);
				output.WriteInt64(this.Hour);
			}
			if (this.Minute != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Minute);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1EE RID: 111086 RVA: 0x003F2898 File Offset: 0x003F0A98
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

		// Token: 0x0601B1EF RID: 111087 RVA: 0x003F28FC File Offset: 0x003F0AFC
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

		// Token: 0x0601B1F0 RID: 111088 RVA: 0x003F2960 File Offset: 0x003F0B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1F1 RID: 111089 RVA: 0x003F296C File Offset: 0x003F0B6C
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
						if (num != 112U)
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

		// Token: 0x04009E4A RID: 40522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E4B RID: 40523
		public const int IsLockFieldNumber = 1;

		// Token: 0x04009E4C RID: 40524
		private bool isLock_;

		// Token: 0x04009E4D RID: 40525
		public const int HourFieldNumber = 2;

		// Token: 0x04009E4E RID: 40526
		private long hour_;

		// Token: 0x04009E4F RID: 40527
		public const int MinuteFieldNumber = 14;

		// Token: 0x04009E50 RID: 40528
		private long minute_;
	}
}
