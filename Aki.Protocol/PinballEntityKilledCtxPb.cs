using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D44 RID: 3396
	public sealed class PinballEntityKilledCtxPb : IMessage<PinballEntityKilledCtxPb>, IMessage, IEquatable<PinballEntityKilledCtxPb>, IDeepCloneable<PinballEntityKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601252A RID: 75050 RVA: 0x002AC813 File Offset: 0x002AAA13
		[NullableContext(1)]
		public static PinballEntityKilledCtxPb Create()
		{
			return new PinballEntityKilledCtxPb();
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0601252B RID: 75051 RVA: 0x002AC81A File Offset: 0x002AAA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0601252C RID: 75052 RVA: 0x002AC81D File Offset: 0x002AAA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballEntityKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0601252D RID: 75053 RVA: 0x002AC824 File Offset: 0x002AAA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb()
		{
		}

		// Token: 0x0601252E RID: 75054 RVA: 0x002AC82C File Offset: 0x002AAA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb(PinballEntityKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601252F RID: 75055 RVA: 0x002AC851 File Offset: 0x002AAA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballEntityKilledCtxPb Clone()
		{
			return new PinballEntityKilledCtxPb(this);
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x06012530 RID: 75056 RVA: 0x002AC859 File Offset: 0x002AAA59
		// (set) Token: 0x06012531 RID: 75057 RVA: 0x002AC861 File Offset: 0x002AAA61
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

		// Token: 0x06012532 RID: 75058 RVA: 0x002AC86A File Offset: 0x002AAA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballEntityKilledCtxPb);
		}

		// Token: 0x06012533 RID: 75059 RVA: 0x002AC878 File Offset: 0x002AAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballEntityKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012534 RID: 75060 RVA: 0x002AC8A8 File Offset: 0x002AAAA8
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

		// Token: 0x06012535 RID: 75061 RVA: 0x002AC8E7 File Offset: 0x002AAAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012536 RID: 75062 RVA: 0x002AC8F4 File Offset: 0x002AAAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012537 RID: 75063 RVA: 0x002AC8FD File Offset: 0x002AAAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012538 RID: 75064 RVA: 0x002AC930 File Offset: 0x002AAB30
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

		// Token: 0x06012539 RID: 75065 RVA: 0x002AC96E File Offset: 0x002AAB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballEntityKilledCtxPb other)
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

		// Token: 0x0601253A RID: 75066 RVA: 0x002AC99F File Offset: 0x002AAB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x002AC9A8 File Offset: 0x002AABA8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007231 RID: 29233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007232 RID: 29234
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04007233 RID: 29235
		private long entityId_;
	}
}
