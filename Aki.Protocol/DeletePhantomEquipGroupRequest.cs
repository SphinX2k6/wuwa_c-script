using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BF RID: 959
	[NetMessage(EMessageId.DeletePhantomEquipGroupRequest)]
	public sealed class DeletePhantomEquipGroupRequest : IMessage<DeletePhantomEquipGroupRequest>, IMessage, IEquatable<DeletePhantomEquipGroupRequest>, IDeepCloneable<DeletePhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x06005DDD RID: 24029 RVA: 0x000E3935 File Offset: 0x000E1B35
		[NullableContext(1)]
		public static DeletePhantomEquipGroupRequest Create()
		{
			return new DeletePhantomEquipGroupRequest();
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06005DDE RID: 24030 RVA: 0x000E393C File Offset: 0x000E1B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06005DDF RID: 24031 RVA: 0x000E393F File Offset: 0x000E1B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeletePhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x000E3946 File Offset: 0x000E1B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest()
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x000E394E File Offset: 0x000E1B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest(DeletePhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x000E3973 File Offset: 0x000E1B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeletePhantomEquipGroupRequest Clone()
		{
			return new DeletePhantomEquipGroupRequest(this);
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x000E397B File Offset: 0x000E1B7B
		// (set) Token: 0x06005DE4 RID: 24036 RVA: 0x000E3983 File Offset: 0x000E1B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x000E398C File Offset: 0x000E1B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeletePhantomEquipGroupRequest);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x000E399A File Offset: 0x000E1B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeletePhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x000E39C8 File Offset: 0x000E1BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x000E3A07 File Offset: 0x000E1C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x000E3A14 File Offset: 0x000E1C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x000E3A1D File Offset: 0x000E1C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x000E3A50 File Offset: 0x000E1C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x000E3A8E File Offset: 0x000E1C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeletePhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x000E3ABF File Offset: 0x000E1CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x000E3AC8 File Offset: 0x000E1CC8
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x040036A8 RID: 13992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A9 RID: 13993
		public const int IndexFieldNumber = 13;

		// Token: 0x040036AA RID: 13994
		private int index_;
	}
}
