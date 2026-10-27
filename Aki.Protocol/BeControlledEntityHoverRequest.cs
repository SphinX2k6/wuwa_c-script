using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000188 RID: 392
	[NetMessage(EMessageId.BeControlledEntityHoverRequest)]
	public sealed class BeControlledEntityHoverRequest : IMessage<BeControlledEntityHoverRequest>, IMessage, IEquatable<BeControlledEntityHoverRequest>, IDeepCloneable<BeControlledEntityHoverRequest>, IBufferMessage
	{
		// Token: 0x06002F1F RID: 12063 RVA: 0x00078E45 File Offset: 0x00077045
		[NullableContext(1)]
		public static BeControlledEntityHoverRequest Create()
		{
			return new BeControlledEntityHoverRequest();
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x00078E4C File Offset: 0x0007704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x00078E4F File Offset: 0x0007704F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledEntityHoverRequest.Descriptor;
			}
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00078E56 File Offset: 0x00077056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest()
		{
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00078E5E File Offset: 0x0007705E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest(BeControlledEntityHoverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00078E83 File Offset: 0x00077083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest Clone()
		{
			return new BeControlledEntityHoverRequest(this);
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x00078E8B File Offset: 0x0007708B
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x00078E93 File Offset: 0x00077093
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

		// Token: 0x06002F27 RID: 12071 RVA: 0x00078E9C File Offset: 0x0007709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledEntityHoverRequest);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00078EAA File Offset: 0x000770AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledEntityHoverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00078ED8 File Offset: 0x000770D8
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

		// Token: 0x06002F2A RID: 12074 RVA: 0x00078F17 File Offset: 0x00077117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00078F24 File Offset: 0x00077124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00078F2D File Offset: 0x0007712D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00078F60 File Offset: 0x00077160
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

		// Token: 0x06002F2E RID: 12078 RVA: 0x00078F9E File Offset: 0x0007719E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledEntityHoverRequest other)
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

		// Token: 0x06002F2F RID: 12079 RVA: 0x00078FCF File Offset: 0x000771CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00078FD8 File Offset: 0x000771D8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400289C RID: 10396
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400289D RID: 10397
		public const int EntityIdFieldNumber = 9;

		// Token: 0x0400289E RID: 10398
		private long entityId_;
	}
}
