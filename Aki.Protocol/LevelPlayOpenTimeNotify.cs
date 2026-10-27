using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000902 RID: 2306
	[NetMessage(EMessageId.LevelPlayOpenTimeNotify)]
	public sealed class LevelPlayOpenTimeNotify : IMessage<LevelPlayOpenTimeNotify>, IMessage, IEquatable<LevelPlayOpenTimeNotify>, IDeepCloneable<LevelPlayOpenTimeNotify>, IBufferMessage
	{
		// Token: 0x0600CBB0 RID: 52144 RVA: 0x001E0A6C File Offset: 0x001DEC6C
		[NullableContext(1)]
		public static LevelPlayOpenTimeNotify Create()
		{
			return new LevelPlayOpenTimeNotify();
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x001E0A73 File Offset: 0x001DEC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600CBB2 RID: 52146 RVA: 0x001E0A76 File Offset: 0x001DEC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenTimeNotify.Descriptor;
			}
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x001E0A7D File Offset: 0x001DEC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify()
		{
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x001E0A85 File Offset: 0x001DEC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify(LevelPlayOpenTimeNotify other) : this()
		{
			this.id_ = other.id_;
			this.openTime_ = other.openTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x001E0AB6 File Offset: 0x001DECB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenTimeNotify Clone()
		{
			return new LevelPlayOpenTimeNotify(this);
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x001E0ABE File Offset: 0x001DECBE
		// (set) Token: 0x0600CBB7 RID: 52151 RVA: 0x001E0AC6 File Offset: 0x001DECC6
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

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600CBB8 RID: 52152 RVA: 0x001E0ACF File Offset: 0x001DECCF
		// (set) Token: 0x0600CBB9 RID: 52153 RVA: 0x001E0AD7 File Offset: 0x001DECD7
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

		// Token: 0x0600CBBA RID: 52154 RVA: 0x001E0AE0 File Offset: 0x001DECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenTimeNotify);
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x001E0AEE File Offset: 0x001DECEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenTimeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.OpenTime == other.OpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x001E0B2C File Offset: 0x001DED2C
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

		// Token: 0x0600CBBD RID: 52157 RVA: 0x001E0B84 File Offset: 0x001DED84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x001E0B91 File Offset: 0x001DED91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBBF RID: 52159 RVA: 0x001E0B9C File Offset: 0x001DED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.OpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x001E0BF8 File Offset: 0x001DEDF8
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

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x001E0C50 File Offset: 0x001DEE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenTimeNotify other)
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

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x001E0CA0 File Offset: 0x001DEEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x001E0CAC File Offset: 0x001DEEAC
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
				if (num != 88U)
				{
					if (num != 104U)
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

		// Token: 0x0400567A RID: 22138
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400567B RID: 22139
		public const int IdFieldNumber = 11;

		// Token: 0x0400567C RID: 22140
		private int id_;

		// Token: 0x0400567D RID: 22141
		public const int OpenTimeFieldNumber = 13;

		// Token: 0x0400567E RID: 22142
		private long openTime_;
	}
}
