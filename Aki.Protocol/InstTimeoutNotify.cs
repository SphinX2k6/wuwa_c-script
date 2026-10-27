using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082F RID: 2095
	[NetMessage(EMessageId.InstTimeoutNotify)]
	public sealed class InstTimeoutNotify : IMessage<InstTimeoutNotify>, IMessage, IEquatable<InstTimeoutNotify>, IDeepCloneable<InstTimeoutNotify>, IBufferMessage
	{
		// Token: 0x0600BB43 RID: 47939 RVA: 0x001BE25D File Offset: 0x001BC45D
		[NullableContext(1)]
		public static InstTimeoutNotify Create()
		{
			return new InstTimeoutNotify();
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x001BE264 File Offset: 0x001BC464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x0600BB45 RID: 47941 RVA: 0x001BE267 File Offset: 0x001BC467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTimeoutNotify.Descriptor;
			}
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x001BE26E File Offset: 0x001BC46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify()
		{
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x001BE276 File Offset: 0x001BC476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify(InstTimeoutNotify other) : this()
		{
			this.timestamp_ = other.timestamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x001BE29B File Offset: 0x001BC49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify Clone()
		{
			return new InstTimeoutNotify(this);
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x0600BB49 RID: 47945 RVA: 0x001BE2A3 File Offset: 0x001BC4A3
		// (set) Token: 0x0600BB4A RID: 47946 RVA: 0x001BE2AB File Offset: 0x001BC4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timestamp
		{
			get
			{
				return this.timestamp_;
			}
			set
			{
				this.timestamp_ = value;
			}
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x001BE2B4 File Offset: 0x001BC4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTimeoutNotify);
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x001BE2C2 File Offset: 0x001BC4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTimeoutNotify other)
		{
			return other != null && (other == this || (this.Timestamp == other.Timestamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x001BE2F0 File Offset: 0x001BC4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Timestamp != 0L)
			{
				num ^= this.Timestamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB4E RID: 47950 RVA: 0x001BE32F File Offset: 0x001BC52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x001BE33C File Offset: 0x001BC53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x001BE345 File Offset: 0x001BC545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Timestamp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Timestamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB51 RID: 47953 RVA: 0x001BE378 File Offset: 0x001BC578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Timestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x001BE3B6 File Offset: 0x001BC5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstTimeoutNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Timestamp != 0L)
			{
				this.Timestamp = other.Timestamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x001BE3E7 File Offset: 0x001BC5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB54 RID: 47956 RVA: 0x001BE3F0 File Offset: 0x001BC5F0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Timestamp = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400523B RID: 21051
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400523C RID: 21052
		public const int TimestampFieldNumber = 4;

		// Token: 0x0400523D RID: 21053
		private long timestamp_;
	}
}
