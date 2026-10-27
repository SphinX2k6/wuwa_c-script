using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9D RID: 2973
	[NetMessage(EMessageId.OnlineMotorStartNotify)]
	public sealed class OnlineMotorStartNotify : IMessage<OnlineMotorStartNotify>, IMessage, IEquatable<OnlineMotorStartNotify>, IDeepCloneable<OnlineMotorStartNotify>, IBufferMessage
	{
		// Token: 0x060101F5 RID: 66037 RVA: 0x0025A908 File Offset: 0x00258B08
		[NullableContext(1)]
		public static OnlineMotorStartNotify Create()
		{
			return new OnlineMotorStartNotify();
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x060101F6 RID: 66038 RVA: 0x0025A90F File Offset: 0x00258B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x060101F7 RID: 66039 RVA: 0x0025A912 File Offset: 0x00258B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorStartNotify.Descriptor;
			}
		}

		// Token: 0x060101F8 RID: 66040 RVA: 0x0025A919 File Offset: 0x00258B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify()
		{
		}

		// Token: 0x060101F9 RID: 66041 RVA: 0x0025A921 File Offset: 0x00258B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify(OnlineMotorStartNotify other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101FA RID: 66042 RVA: 0x0025A946 File Offset: 0x00258B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorStartNotify Clone()
		{
			return new OnlineMotorStartNotify(this);
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x060101FB RID: 66043 RVA: 0x0025A94E File Offset: 0x00258B4E
		// (set) Token: 0x060101FC RID: 66044 RVA: 0x0025A956 File Offset: 0x00258B56
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

		// Token: 0x060101FD RID: 66045 RVA: 0x0025A95F File Offset: 0x00258B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorStartNotify);
		}

		// Token: 0x060101FE RID: 66046 RVA: 0x0025A96D File Offset: 0x00258B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorStartNotify other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101FF RID: 66047 RVA: 0x0025A99C File Offset: 0x00258B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06010200 RID: 66048 RVA: 0x0025A9DB File Offset: 0x00258BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010201 RID: 66049 RVA: 0x0025A9E8 File Offset: 0x00258BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010202 RID: 66050 RVA: 0x0025A9F1 File Offset: 0x00258BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.BeginTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010203 RID: 66051 RVA: 0x0025AA24 File Offset: 0x00258C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06010204 RID: 66052 RVA: 0x0025AA62 File Offset: 0x00258C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010205 RID: 66053 RVA: 0x0025AA93 File Offset: 0x00258C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010206 RID: 66054 RVA: 0x0025AA9C File Offset: 0x00258C9C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BeginTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040066C5 RID: 26309
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066C6 RID: 26310
		public const int BeginTimeFieldNumber = 14;

		// Token: 0x040066C7 RID: 26311
		private long beginTime_;
	}
}
