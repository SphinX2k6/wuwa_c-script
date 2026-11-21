using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081B RID: 2075
	[NetMessage(EMessageId.InstTimeoutNotify)]
	public sealed class InstTimeoutNotify : IMessage<InstTimeoutNotify>, IMessage, IEquatable<InstTimeoutNotify>, IDeepCloneable<InstTimeoutNotify>, IBufferMessage
	{
		// Token: 0x0600B9ED RID: 47597 RVA: 0x001BB821 File Offset: 0x001B9A21
		[NullableContext(1)]
		public static InstTimeoutNotify Create()
		{
			return new InstTimeoutNotify();
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x001BB828 File Offset: 0x001B9A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x001BB82B File Offset: 0x001B9A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTimeoutNotify.Descriptor;
			}
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x001BB832 File Offset: 0x001B9A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify()
		{
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x001BB83A File Offset: 0x001B9A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify(InstTimeoutNotify other) : this()
		{
			this.timestamp_ = other.timestamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x001BB85F File Offset: 0x001B9A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTimeoutNotify Clone()
		{
			return new InstTimeoutNotify(this);
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x0600B9F3 RID: 47603 RVA: 0x001BB867 File Offset: 0x001B9A67
		// (set) Token: 0x0600B9F4 RID: 47604 RVA: 0x001BB86F File Offset: 0x001B9A6F
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

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x001BB878 File Offset: 0x001B9A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTimeoutNotify);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x001BB886 File Offset: 0x001B9A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTimeoutNotify other)
		{
			return other != null && (other == this || (this.Timestamp == other.Timestamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x001BB8B4 File Offset: 0x001B9AB4
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

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x001BB8F3 File Offset: 0x001B9AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x001BB900 File Offset: 0x001B9B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x001BB909 File Offset: 0x001B9B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Timestamp != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Timestamp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x001BB93C File Offset: 0x001B9B3C
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

		// Token: 0x0600B9FC RID: 47612 RVA: 0x001BB97A File Offset: 0x001B9B7A
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

		// Token: 0x0600B9FD RID: 47613 RVA: 0x001BB9AB File Offset: 0x001B9BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x001BB9B4 File Offset: 0x001B9BB4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Timestamp = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005234 RID: 21044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005235 RID: 21045
		public const int TimestampFieldNumber = 6;

		// Token: 0x04005236 RID: 21046
		private long timestamp_;
	}
}
