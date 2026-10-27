using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129F RID: 4767
	public sealed class SubActivityBeginTime : IMessage<SubActivityBeginTime>, IMessage, IEquatable<SubActivityBeginTime>, IDeepCloneable<SubActivityBeginTime>, IBufferMessage
	{
		// Token: 0x060195F6 RID: 103926 RVA: 0x003B02E7 File Offset: 0x003AE4E7
		[NullableContext(1)]
		public static SubActivityBeginTime Create()
		{
			return new SubActivityBeginTime();
		}

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x060195F7 RID: 103927 RVA: 0x003B02EE File Offset: 0x003AE4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubActivityBeginTime> Parser
		{
			get
			{
				return SubActivityBeginTime._parser;
			}
		}

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x060195F8 RID: 103928 RVA: 0x003B02F5 File Offset: 0x003AE4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x060195F9 RID: 103929 RVA: 0x003B02F8 File Offset: 0x003AE4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubActivityBeginTime.Descriptor;
			}
		}

		// Token: 0x060195FA RID: 103930 RVA: 0x003B02FF File Offset: 0x003AE4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime()
		{
		}

		// Token: 0x060195FB RID: 103931 RVA: 0x003B0307 File Offset: 0x003AE507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime(SubActivityBeginTime other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195FC RID: 103932 RVA: 0x003B0338 File Offset: 0x003AE538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubActivityBeginTime Clone()
		{
			return new SubActivityBeginTime(this);
		}

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x060195FD RID: 103933 RVA: 0x003B0340 File Offset: 0x003AE540
		// (set) Token: 0x060195FE RID: 103934 RVA: 0x003B0348 File Offset: 0x003AE548
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

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x060195FF RID: 103935 RVA: 0x003B0351 File Offset: 0x003AE551
		// (set) Token: 0x06019600 RID: 103936 RVA: 0x003B0359 File Offset: 0x003AE559
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

		// Token: 0x06019601 RID: 103937 RVA: 0x003B0362 File Offset: 0x003AE562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubActivityBeginTime);
		}

		// Token: 0x06019602 RID: 103938 RVA: 0x003B0370 File Offset: 0x003AE570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubActivityBeginTime other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019603 RID: 103939 RVA: 0x003B03B0 File Offset: 0x003AE5B0
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

		// Token: 0x06019604 RID: 103940 RVA: 0x003B0408 File Offset: 0x003AE608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019605 RID: 103941 RVA: 0x003B0415 File Offset: 0x003AE615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019606 RID: 103942 RVA: 0x003B0420 File Offset: 0x003AE620
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

		// Token: 0x06019607 RID: 103943 RVA: 0x003B0478 File Offset: 0x003AE678
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

		// Token: 0x06019608 RID: 103944 RVA: 0x003B04D0 File Offset: 0x003AE6D0
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

		// Token: 0x06019609 RID: 103945 RVA: 0x003B0520 File Offset: 0x003AE720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601960A RID: 103946 RVA: 0x003B052C File Offset: 0x003AE72C
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

		// Token: 0x04009507 RID: 38151
		private static readonly MessageParser<SubActivityBeginTime> _parser = new MessageParser<SubActivityBeginTime>(() => new SubActivityBeginTime());

		// Token: 0x04009508 RID: 38152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009509 RID: 38153
		public const int IdFieldNumber = 1;

		// Token: 0x0400950A RID: 38154
		private int id_;

		// Token: 0x0400950B RID: 38155
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x0400950C RID: 38156
		private long beginTime_;
	}
}
