using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB9 RID: 3769
	[NetMessage(EMessageId.RecallTeleportToMarkIdRequest)]
	public sealed class RecallTeleportToMarkIdRequest : IMessage<RecallTeleportToMarkIdRequest>, IMessage, IEquatable<RecallTeleportToMarkIdRequest>, IDeepCloneable<RecallTeleportToMarkIdRequest>, IBufferMessage
	{
		// Token: 0x060143CE RID: 82894 RVA: 0x002F1AC4 File Offset: 0x002EFCC4
		[NullableContext(1)]
		public static RecallTeleportToMarkIdRequest Create()
		{
			return new RecallTeleportToMarkIdRequest();
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x060143CF RID: 82895 RVA: 0x002F1ACB File Offset: 0x002EFCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x060143D0 RID: 82896 RVA: 0x002F1ACE File Offset: 0x002EFCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallTeleportToMarkIdRequest.Descriptor;
			}
		}

		// Token: 0x060143D1 RID: 82897 RVA: 0x002F1AD5 File Offset: 0x002EFCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest()
		{
		}

		// Token: 0x060143D2 RID: 82898 RVA: 0x002F1ADD File Offset: 0x002EFCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest(RecallTeleportToMarkIdRequest other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143D3 RID: 82899 RVA: 0x002F1B02 File Offset: 0x002EFD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallTeleportToMarkIdRequest Clone()
		{
			return new RecallTeleportToMarkIdRequest(this);
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x060143D4 RID: 82900 RVA: 0x002F1B0A File Offset: 0x002EFD0A
		// (set) Token: 0x060143D5 RID: 82901 RVA: 0x002F1B12 File Offset: 0x002EFD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x060143D6 RID: 82902 RVA: 0x002F1B1B File Offset: 0x002EFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallTeleportToMarkIdRequest);
		}

		// Token: 0x060143D7 RID: 82903 RVA: 0x002F1B29 File Offset: 0x002EFD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallTeleportToMarkIdRequest other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143D8 RID: 82904 RVA: 0x002F1B58 File Offset: 0x002EFD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060143D9 RID: 82905 RVA: 0x002F1B97 File Offset: 0x002EFD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143DA RID: 82906 RVA: 0x002F1BA4 File Offset: 0x002EFDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143DB RID: 82907 RVA: 0x002F1BAD File Offset: 0x002EFDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143DC RID: 82908 RVA: 0x002F1BE0 File Offset: 0x002EFDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060143DD RID: 82909 RVA: 0x002F1C1E File Offset: 0x002EFE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallTeleportToMarkIdRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060143DE RID: 82910 RVA: 0x002F1C4F File Offset: 0x002EFE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143DF RID: 82911 RVA: 0x002F1C58 File Offset: 0x002EFE58
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B76 RID: 31606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B77 RID: 31607
		public const int MarkIdFieldNumber = 4;

		// Token: 0x04007B78 RID: 31608
		private int markId_;
	}
}
