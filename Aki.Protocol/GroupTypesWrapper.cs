using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071F RID: 1823
	public sealed class GroupTypesWrapper : IMessage<GroupTypesWrapper>, IMessage, IEquatable<GroupTypesWrapper>, IDeepCloneable<GroupTypesWrapper>, IBufferMessage
	{
		// Token: 0x0600A5B0 RID: 42416 RVA: 0x0018FC9D File Offset: 0x0018DE9D
		[NullableContext(1)]
		public static GroupTypesWrapper Create()
		{
			return new GroupTypesWrapper();
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600A5B1 RID: 42417 RVA: 0x0018FCA4 File Offset: 0x0018DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600A5B2 RID: 42418 RVA: 0x0018FCA7 File Offset: 0x0018DEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupTypesWrapper.Descriptor;
			}
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x0018FCAE File Offset: 0x0018DEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper()
		{
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x0018FCC1 File Offset: 0x0018DEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper(GroupTypesWrapper other) : this()
		{
			this.groupTypes_ = other.groupTypes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x0018FCEB File Offset: 0x0018DEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper Clone()
		{
			return new GroupTypesWrapper(this);
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x0018FCF3 File Offset: 0x0018DEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GroupTypes
		{
			get
			{
				return this.groupTypes_;
			}
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x0018FCFB File Offset: 0x0018DEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupTypesWrapper);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0018FD09 File Offset: 0x0018DF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupTypesWrapper other)
		{
			return other != null && (other == this || (this.groupTypes_.Equals(other.groupTypes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x0018FD3C File Offset: 0x0018DF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.groupTypes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x0018FD70 File Offset: 0x0018DF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x0018FD7D File Offset: 0x0018DF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x0018FD86 File Offset: 0x0018DF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.groupTypes_.WriteTo(ref output, GroupTypesWrapper._repeated_groupTypes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x0018FDB0 File Offset: 0x0018DFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.groupTypes_.CalculateSize(GroupTypesWrapper._repeated_groupTypes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x0018FDE9 File Offset: 0x0018DFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupTypesWrapper other)
		{
			if (other == null)
			{
				return;
			}
			this.groupTypes_.Add(other.groupTypes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x0018FE17 File Offset: 0x0018E017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x0018FE20 File Offset: 0x0018E020
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.groupTypes_.AddEntriesFrom(ref input, GroupTypesWrapper._repeated_groupTypes_codec);
				}
			}
		}

		// Token: 0x04004C29 RID: 19497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C2A RID: 19498
		public const int GroupTypesFieldNumber = 1;

		// Token: 0x04004C2B RID: 19499
		private static readonly FieldCodec<int> _repeated_groupTypes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004C2C RID: 19500
		private readonly RepeatedField<int> groupTypes_ = new RepeatedField<int>();
	}
}
