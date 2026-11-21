using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130E RID: 4878
	public sealed class SubActivityBeginTime : IMessage<SubActivityBeginTime>, IMessage, IEquatable<SubActivityBeginTime>, IDeepCloneable<SubActivityBeginTime>, IBufferMessage
	{
		// Token: 0x0601A02C RID: 106540 RVA: 0x003CAA17 File Offset: 0x003C8C17
		[NullableContext(1)]
		public static SubActivityBeginTime Create()
		{
			return new SubActivityBeginTime();
		}

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x0601A02D RID: 106541 RVA: 0x003CAA1E File Offset: 0x003C8C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubActivityBeginTime> Parser
		{
			get
			{
				return SubActivityBeginTime._parser;
			}
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x0601A02E RID: 106542 RVA: 0x003CAA25 File Offset: 0x003C8C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x0601A02F RID: 106543 RVA: 0x003CAA28 File Offset: 0x003C8C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubActivityBeginTime.Descriptor;
			}
		}

		// Token: 0x0601A030 RID: 106544 RVA: 0x003CAA2F File Offset: 0x003C8C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime()
		{
		}

		// Token: 0x0601A031 RID: 106545 RVA: 0x003CAA37 File Offset: 0x003C8C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime(SubActivityBeginTime other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A032 RID: 106546 RVA: 0x003CAA68 File Offset: 0x003C8C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime Clone()
		{
			return new SubActivityBeginTime(this);
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x0601A033 RID: 106547 RVA: 0x003CAA70 File Offset: 0x003C8C70
		// (set) Token: 0x0601A034 RID: 106548 RVA: 0x003CAA78 File Offset: 0x003C8C78
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

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x0601A035 RID: 106549 RVA: 0x003CAA81 File Offset: 0x003C8C81
		// (set) Token: 0x0601A036 RID: 106550 RVA: 0x003CAA89 File Offset: 0x003C8C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x0601A037 RID: 106551 RVA: 0x003CAA92 File Offset: 0x003C8C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubActivityBeginTime);
		}

		// Token: 0x0601A038 RID: 106552 RVA: 0x003CAAA0 File Offset: 0x003C8CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubActivityBeginTime other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A039 RID: 106553 RVA: 0x003CAAE0 File Offset: 0x003C8CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A03A RID: 106554 RVA: 0x003CAB38 File Offset: 0x003C8D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A03B RID: 106555 RVA: 0x003CAB45 File Offset: 0x003C8D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A03C RID: 106556 RVA: 0x003CAB50 File Offset: 0x003C8D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A03D RID: 106557 RVA: 0x003CABA8 File Offset: 0x003C8DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A03E RID: 106558 RVA: 0x003CAC00 File Offset: 0x003C8E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubActivityBeginTime other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A03F RID: 106559 RVA: 0x003CAC50 File Offset: 0x003C8E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A040 RID: 106560 RVA: 0x003CAC5C File Offset: 0x003C8E5C
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
						this.BeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009931 RID: 39217
		private static readonly MessageParser<SubActivityBeginTime> _parser = new MessageParser<SubActivityBeginTime>(() => new SubActivityBeginTime());

		// Token: 0x04009932 RID: 39218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009933 RID: 39219
		public const int IdFieldNumber = 1;

		// Token: 0x04009934 RID: 39220
		private int id_;

		// Token: 0x04009935 RID: 39221
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04009936 RID: 39222
		private long beginTime_;
	}
}
