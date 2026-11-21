using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052A RID: 1322
	[NetMessage(EMessageId.FirecrackerEntityCreatedNotify)]
	public sealed class FirecrackerEntityCreatedNotify : IMessage<FirecrackerEntityCreatedNotify>, IMessage, IEquatable<FirecrackerEntityCreatedNotify>, IDeepCloneable<FirecrackerEntityCreatedNotify>, IBufferMessage
	{
		// Token: 0x06007C5F RID: 31839 RVA: 0x0012DFB1 File Offset: 0x0012C1B1
		[NullableContext(1)]
		public static FirecrackerEntityCreatedNotify Create()
		{
			return new FirecrackerEntityCreatedNotify();
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06007C60 RID: 31840 RVA: 0x0012DFB8 File Offset: 0x0012C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06007C61 RID: 31841 RVA: 0x0012DFBB File Offset: 0x0012C1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FirecrackerEntityCreatedNotify.Descriptor;
			}
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x0012DFC2 File Offset: 0x0012C1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify()
		{
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x0012DFCA File Offset: 0x0012C1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify(FirecrackerEntityCreatedNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x0012DFEF File Offset: 0x0012C1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirecrackerEntityCreatedNotify Clone()
		{
			return new FirecrackerEntityCreatedNotify(this);
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x0012DFF7 File Offset: 0x0012C1F7
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0012DFFF File Offset: 0x0012C1FF
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

		// Token: 0x06007C67 RID: 31847 RVA: 0x0012E008 File Offset: 0x0012C208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FirecrackerEntityCreatedNotify);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x0012E016 File Offset: 0x0012C216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FirecrackerEntityCreatedNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0012E044 File Offset: 0x0012C244
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

		// Token: 0x06007C6A RID: 31850 RVA: 0x0012E083 File Offset: 0x0012C283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x0012E090 File Offset: 0x0012C290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x0012E099 File Offset: 0x0012C299
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

		// Token: 0x06007C6D RID: 31853 RVA: 0x0012E0CC File Offset: 0x0012C2CC
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

		// Token: 0x06007C6E RID: 31854 RVA: 0x0012E10A File Offset: 0x0012C30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FirecrackerEntityCreatedNotify other)
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

		// Token: 0x06007C6F RID: 31855 RVA: 0x0012E13B File Offset: 0x0012C33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x0012E144 File Offset: 0x0012C344
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

		// Token: 0x04003FE4 RID: 16356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE5 RID: 16357
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003FE6 RID: 16358
		private long entityId_;
	}
}
