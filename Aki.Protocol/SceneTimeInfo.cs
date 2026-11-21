using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CE RID: 4558
	public sealed class SceneTimeInfo : IMessage<SceneTimeInfo>, IMessage, IEquatable<SceneTimeInfo>, IDeepCloneable<SceneTimeInfo>, IBufferMessage
	{
		// Token: 0x0601855B RID: 99675 RVA: 0x0038AE2B File Offset: 0x0038902B
		[NullableContext(1)]
		public static SceneTimeInfo Create()
		{
			return new SceneTimeInfo();
		}

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x0601855C RID: 99676 RVA: 0x0038AE32 File Offset: 0x00389032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x0601855D RID: 99677 RVA: 0x0038AE35 File Offset: 0x00389035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTimeInfo.Descriptor;
			}
		}

		// Token: 0x0601855E RID: 99678 RVA: 0x0038AE3C File Offset: 0x0038903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo()
		{
		}

		// Token: 0x0601855F RID: 99679 RVA: 0x0038AE44 File Offset: 0x00389044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo(SceneTimeInfo other) : this()
		{
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this.ownerTimeClockTimeSpan_ = other.ownerTimeClockTimeSpan_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018560 RID: 99680 RVA: 0x0038AE81 File Offset: 0x00389081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo Clone()
		{
			return new SceneTimeInfo(this);
		}

		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x06018561 RID: 99681 RVA: 0x0038AE89 File Offset: 0x00389089
		// (set) Token: 0x06018562 RID: 99682 RVA: 0x0038AE91 File Offset: 0x00389091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Hour
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

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x06018563 RID: 99683 RVA: 0x0038AE9A File Offset: 0x0038909A
		// (set) Token: 0x06018564 RID: 99684 RVA: 0x0038AEA2 File Offset: 0x003890A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Minute
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

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x06018565 RID: 99685 RVA: 0x0038AEAB File Offset: 0x003890AB
		// (set) Token: 0x06018566 RID: 99686 RVA: 0x0038AEB3 File Offset: 0x003890B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerTimeClockTimeSpan
		{
			get
			{
				return this.ownerTimeClockTimeSpan_;
			}
			set
			{
				this.ownerTimeClockTimeSpan_ = value;
			}
		}

		// Token: 0x06018567 RID: 99687 RVA: 0x0038AEBC File Offset: 0x003890BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTimeInfo);
		}

		// Token: 0x06018568 RID: 99688 RVA: 0x0038AECC File Offset: 0x003890CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTimeInfo other)
		{
			return other != null && (other == this || (this.Hour == other.Hour && this.Minute == other.Minute && this.OwnerTimeClockTimeSpan == other.OwnerTimeClockTimeSpan && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018569 RID: 99689 RVA: 0x0038AF28 File Offset: 0x00389128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Hour != 0)
			{
				num ^= this.Hour.GetHashCode();
			}
			if (this.Minute != 0)
			{
				num ^= this.Minute.GetHashCode();
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				num ^= this.OwnerTimeClockTimeSpan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601856A RID: 99690 RVA: 0x0038AF99 File Offset: 0x00389199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601856B RID: 99691 RVA: 0x0038AFA6 File Offset: 0x003891A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601856C RID: 99692 RVA: 0x0038AFB0 File Offset: 0x003891B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Hour != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Hour);
			}
			if (this.Minute != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Minute);
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.OwnerTimeClockTimeSpan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601856D RID: 99693 RVA: 0x0038B024 File Offset: 0x00389224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Hour != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hour);
			}
			if (this.Minute != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Minute);
			}
			if (this.OwnerTimeClockTimeSpan != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerTimeClockTimeSpan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601856E RID: 99694 RVA: 0x0038B094 File Offset: 0x00389294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneTimeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Hour != 0)
			{
				this.Hour = other.Hour;
			}
			if (other.Minute != 0)
			{
				this.Minute = other.Minute;
			}
			if (other.OwnerTimeClockTimeSpan != 0L)
			{
				this.OwnerTimeClockTimeSpan = other.OwnerTimeClockTimeSpan;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601856F RID: 99695 RVA: 0x0038B0F8 File Offset: 0x003892F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018570 RID: 99696 RVA: 0x0038B104 File Offset: 0x00389304
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OwnerTimeClockTimeSpan = input.ReadInt64();
						}
					}
					else
					{
						this.Minute = input.ReadInt32();
					}
				}
				else
				{
					this.Hour = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090A3 RID: 37027
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090A4 RID: 37028
		public const int HourFieldNumber = 1;

		// Token: 0x040090A5 RID: 37029
		private int hour_;

		// Token: 0x040090A6 RID: 37030
		public const int MinuteFieldNumber = 2;

		// Token: 0x040090A7 RID: 37031
		private int minute_;

		// Token: 0x040090A8 RID: 37032
		public const int OwnerTimeClockTimeSpanFieldNumber = 3;

		// Token: 0x040090A9 RID: 37033
		private long ownerTimeClockTimeSpan_;
	}
}
