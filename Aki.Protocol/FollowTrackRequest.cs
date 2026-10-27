using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000619 RID: 1561
	[NetMessage(EMessageId.FollowTrackRequest)]
	public sealed class FollowTrackRequest : IMessage<FollowTrackRequest>, IMessage, IEquatable<FollowTrackRequest>, IDeepCloneable<FollowTrackRequest>, IBufferMessage
	{
		// Token: 0x0600901E RID: 36894 RVA: 0x0015CF04 File Offset: 0x0015B104
		[NullableContext(1)]
		public static FollowTrackRequest Create()
		{
			return new FollowTrackRequest();
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x0015CF0B File Offset: 0x0015B10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06009020 RID: 36896 RVA: 0x0015CF0E File Offset: 0x0015B10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowTrackRequest.Descriptor;
			}
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0015CF15 File Offset: 0x0015B115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest()
		{
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0015CF1D File Offset: 0x0015B11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest(FollowTrackRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0015CF42 File Offset: 0x0015B142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackRequest Clone()
		{
			return new FollowTrackRequest(this);
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x0015CF4A File Offset: 0x0015B14A
		// (set) Token: 0x06009025 RID: 36901 RVA: 0x0015CF52 File Offset: 0x0015B152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0015CF5B File Offset: 0x0015B15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowTrackRequest);
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0015CF69 File Offset: 0x0015B169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowTrackRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0015CF98 File Offset: 0x0015B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0015CFD7 File Offset: 0x0015B1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0015CFE4 File Offset: 0x0015B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0015CFED File Offset: 0x0015B1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0015D020 File Offset: 0x0015B220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0015D05E File Offset: 0x0015B25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowTrackRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x0015D08F File Offset: 0x0015B28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x0015D098 File Offset: 0x0015B298
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040045D3 RID: 17875
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045D4 RID: 17876
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040045D5 RID: 17877
		private long entityId_;
	}
}
