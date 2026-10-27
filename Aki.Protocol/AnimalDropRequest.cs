using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E7 RID: 231
	[NetMessage(EMessageId.AnimalDropRequest)]
	public sealed class AnimalDropRequest : IMessage<AnimalDropRequest>, IMessage, IEquatable<AnimalDropRequest>, IDeepCloneable<AnimalDropRequest>, IBufferMessage
	{
		// Token: 0x060021C2 RID: 8642 RVA: 0x0005A289 File Offset: 0x00058489
		[NullableContext(1)]
		public static AnimalDropRequest Create()
		{
			return new AnimalDropRequest();
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x0005A290 File Offset: 0x00058490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0005A293 File Offset: 0x00058493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDropRequest.Descriptor;
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0005A29A File Offset: 0x0005849A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest()
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0005A2A2 File Offset: 0x000584A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest(AnimalDropRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0005A2C7 File Offset: 0x000584C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDropRequest Clone()
		{
			return new AnimalDropRequest(this);
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x0005A2CF File Offset: 0x000584CF
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x0005A2D7 File Offset: 0x000584D7
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

		// Token: 0x060021CA RID: 8650 RVA: 0x0005A2E0 File Offset: 0x000584E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDropRequest);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0005A2EE File Offset: 0x000584EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDropRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0005A31C File Offset: 0x0005851C
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

		// Token: 0x060021CD RID: 8653 RVA: 0x0005A35B File Offset: 0x0005855B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0005A368 File Offset: 0x00058568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0005A371 File Offset: 0x00058571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0005A3A4 File Offset: 0x000585A4
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

		// Token: 0x060021D1 RID: 8657 RVA: 0x0005A3E2 File Offset: 0x000585E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDropRequest other)
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

		// Token: 0x060021D2 RID: 8658 RVA: 0x0005A413 File Offset: 0x00058613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0005A41C File Offset: 0x0005861C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400244E RID: 9294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400244F RID: 9295
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04002450 RID: 9296
		private long entityId_;
	}
}
