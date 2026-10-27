using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001481 RID: 5249
	[NetMessage(EMessageId.UnblockPlayerRequest)]
	public sealed class UnblockPlayerRequest : IMessage<UnblockPlayerRequest>, IMessage, IEquatable<UnblockPlayerRequest>, IDeepCloneable<UnblockPlayerRequest>, IBufferMessage
	{
		// Token: 0x0601BC77 RID: 113783 RVA: 0x00404C8B File Offset: 0x00402E8B
		[NullableContext(1)]
		public static UnblockPlayerRequest Create()
		{
			return new UnblockPlayerRequest();
		}

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x0601BC78 RID: 113784 RVA: 0x00404C92 File Offset: 0x00402E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x0601BC79 RID: 113785 RVA: 0x00404C95 File Offset: 0x00402E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0601BC7A RID: 113786 RVA: 0x00404C9C File Offset: 0x00402E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest()
		{
		}

		// Token: 0x0601BC7B RID: 113787 RVA: 0x00404CA4 File Offset: 0x00402EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest(UnblockPlayerRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC7C RID: 113788 RVA: 0x00404CC9 File Offset: 0x00402EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnblockPlayerRequest Clone()
		{
			return new UnblockPlayerRequest(this);
		}

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x0601BC7D RID: 113789 RVA: 0x00404CD1 File Offset: 0x00402ED1
		// (set) Token: 0x0601BC7E RID: 113790 RVA: 0x00404CD9 File Offset: 0x00402ED9
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

		// Token: 0x0601BC7F RID: 113791 RVA: 0x00404CE2 File Offset: 0x00402EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerRequest);
		}

		// Token: 0x0601BC80 RID: 113792 RVA: 0x00404CF0 File Offset: 0x00402EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnblockPlayerRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC81 RID: 113793 RVA: 0x00404D20 File Offset: 0x00402F20
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

		// Token: 0x0601BC82 RID: 113794 RVA: 0x00404D5F File Offset: 0x00402F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC83 RID: 113795 RVA: 0x00404D6C File Offset: 0x00402F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC84 RID: 113796 RVA: 0x00404D75 File Offset: 0x00402F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC85 RID: 113797 RVA: 0x00404DA8 File Offset: 0x00402FA8
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

		// Token: 0x0601BC86 RID: 113798 RVA: 0x00404DE6 File Offset: 0x00402FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnblockPlayerRequest other)
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

		// Token: 0x0601BC87 RID: 113799 RVA: 0x00404E17 File Offset: 0x00403017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC88 RID: 113800 RVA: 0x00404E20 File Offset: 0x00403020
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FE4 RID: 40932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE5 RID: 40933
		public const int IdFieldNumber = 13;

		// Token: 0x04009FE6 RID: 40934
		private int id_;
	}
}
