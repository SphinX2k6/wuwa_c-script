using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018B RID: 395
	[NetMessage(EMessageId.BeControlledEntityHoverRequest)]
	public sealed class BeControlledEntityHoverRequest : IMessage<BeControlledEntityHoverRequest>, IMessage, IEquatable<BeControlledEntityHoverRequest>, IDeepCloneable<BeControlledEntityHoverRequest>, IBufferMessage
	{
		// Token: 0x06002F96 RID: 12182 RVA: 0x0007A279 File Offset: 0x00078479
		[NullableContext(1)]
		public static BeControlledEntityHoverRequest Create()
		{
			return new BeControlledEntityHoverRequest();
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x0007A280 File Offset: 0x00078480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x0007A283 File Offset: 0x00078483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledEntityHoverRequest.Descriptor;
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x0007A28A File Offset: 0x0007848A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest()
		{
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x0007A292 File Offset: 0x00078492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest(BeControlledEntityHoverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x0007A2B7 File Offset: 0x000784B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledEntityHoverRequest Clone()
		{
			return new BeControlledEntityHoverRequest(this);
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x0007A2BF File Offset: 0x000784BF
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x0007A2C7 File Offset: 0x000784C7
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

		// Token: 0x06002F9E RID: 12190 RVA: 0x0007A2D0 File Offset: 0x000784D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledEntityHoverRequest);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0007A2DE File Offset: 0x000784DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledEntityHoverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0007A30C File Offset: 0x0007850C
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

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0007A34B File Offset: 0x0007854B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x0007A358 File Offset: 0x00078558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0007A361 File Offset: 0x00078561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x0007A394 File Offset: 0x00078594
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

		// Token: 0x06002FA5 RID: 12197 RVA: 0x0007A3D2 File Offset: 0x000785D2
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

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0007A403 File Offset: 0x00078603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0007A40C File Offset: 0x0007860C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002910 RID: 10512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002911 RID: 10513
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04002912 RID: 10514
		private long entityId_;
	}
}
