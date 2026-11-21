using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E2 RID: 226
	[NetMessage(EMessageId.AnimalDestroyRequest)]
	public sealed class AnimalDestroyRequest : IMessage<AnimalDestroyRequest>, IMessage, IEquatable<AnimalDestroyRequest>, IDeepCloneable<AnimalDestroyRequest>, IBufferMessage
	{
		// Token: 0x0600219B RID: 8603 RVA: 0x0005A237 File Offset: 0x00058437
		[NullableContext(1)]
		public static AnimalDestroyRequest Create()
		{
			return new AnimalDestroyRequest();
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0005A23E File Offset: 0x0005843E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0005A241 File Offset: 0x00058441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDestroyRequest.Descriptor;
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0005A248 File Offset: 0x00058448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest()
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0005A250 File Offset: 0x00058450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest(AnimalDestroyRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0005A275 File Offset: 0x00058475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyRequest Clone()
		{
			return new AnimalDestroyRequest(this);
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0005A27D File Offset: 0x0005847D
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x0005A285 File Offset: 0x00058485
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

		// Token: 0x060021A3 RID: 8611 RVA: 0x0005A28E File Offset: 0x0005848E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDestroyRequest);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0005A29C File Offset: 0x0005849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDestroyRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0005A2CC File Offset: 0x000584CC
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

		// Token: 0x060021A6 RID: 8614 RVA: 0x0005A30B File Offset: 0x0005850B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0005A318 File Offset: 0x00058518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0005A321 File Offset: 0x00058521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0005A354 File Offset: 0x00058554
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

		// Token: 0x060021AA RID: 8618 RVA: 0x0005A392 File Offset: 0x00058592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDestroyRequest other)
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

		// Token: 0x060021AB RID: 8619 RVA: 0x0005A3C3 File Offset: 0x000585C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0005A3CC File Offset: 0x000585CC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400249A RID: 9370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400249B RID: 9371
		public const int EntityIdFieldNumber = 11;

		// Token: 0x0400249C RID: 9372
		private long entityId_;
	}
}
