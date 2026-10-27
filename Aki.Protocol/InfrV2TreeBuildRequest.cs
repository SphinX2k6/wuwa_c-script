using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000809 RID: 2057
	[NetMessage(EMessageId.InfrV2TreeBuildRequest)]
	public sealed class InfrV2TreeBuildRequest : IMessage<InfrV2TreeBuildRequest>, IMessage, IEquatable<InfrV2TreeBuildRequest>, IDeepCloneable<InfrV2TreeBuildRequest>, IBufferMessage
	{
		// Token: 0x0600B810 RID: 47120 RVA: 0x001B6A01 File Offset: 0x001B4C01
		[NullableContext(1)]
		public static InfrV2TreeBuildRequest Create()
		{
			return new InfrV2TreeBuildRequest();
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600B811 RID: 47121 RVA: 0x001B6A08 File Offset: 0x001B4C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x001B6A0B File Offset: 0x001B4C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeBuildRequest.Descriptor;
			}
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x001B6A12 File Offset: 0x001B4C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest()
		{
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x001B6A1A File Offset: 0x001B4C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest(InfrV2TreeBuildRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x001B6A3F File Offset: 0x001B4C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeBuildRequest Clone()
		{
			return new InfrV2TreeBuildRequest(this);
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600B816 RID: 47126 RVA: 0x001B6A47 File Offset: 0x001B4C47
		// (set) Token: 0x0600B817 RID: 47127 RVA: 0x001B6A4F File Offset: 0x001B4C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x001B6A58 File Offset: 0x001B4C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeBuildRequest);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x001B6A66 File Offset: 0x001B4C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeBuildRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x001B6A94 File Offset: 0x001B4C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x001B6AD3 File Offset: 0x001B4CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x001B6AE0 File Offset: 0x001B4CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x001B6AE9 File Offset: 0x001B4CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x001B6B1C File Offset: 0x001B4D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x001B6B5A File Offset: 0x001B4D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeBuildRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x001B6B8B File Offset: 0x001B4D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x001B6B94 File Offset: 0x001B4D94
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005128 RID: 20776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005129 RID: 20777
		public const int IdFieldNumber = 1;

		// Token: 0x0400512A RID: 20778
		private int id_;
	}
}
