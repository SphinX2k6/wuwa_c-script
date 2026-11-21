using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070B RID: 1803
	public sealed class GroupTypesWrapper : IMessage<GroupTypesWrapper>, IMessage, IEquatable<GroupTypesWrapper>, IDeepCloneable<GroupTypesWrapper>, IBufferMessage
	{
		// Token: 0x0600A45A RID: 42074 RVA: 0x0018D269 File Offset: 0x0018B469
		[NullableContext(1)]
		public static GroupTypesWrapper Create()
		{
			return new GroupTypesWrapper();
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x0018D270 File Offset: 0x0018B470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600A45C RID: 42076 RVA: 0x0018D273 File Offset: 0x0018B473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupTypesWrapper.Descriptor;
			}
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x0018D27A File Offset: 0x0018B47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper()
		{
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x0018D28D File Offset: 0x0018B48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper(GroupTypesWrapper other) : this()
		{
			this.groupTypes_ = other.groupTypes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x0018D2B7 File Offset: 0x0018B4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupTypesWrapper Clone()
		{
			return new GroupTypesWrapper(this);
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600A460 RID: 42080 RVA: 0x0018D2BF File Offset: 0x0018B4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GroupTypes
		{
			get
			{
				return this.groupTypes_;
			}
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x0018D2C7 File Offset: 0x0018B4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupTypesWrapper);
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x0018D2D5 File Offset: 0x0018B4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupTypesWrapper other)
		{
			return other != null && (other == this || (this.groupTypes_.Equals(other.groupTypes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x0018D308 File Offset: 0x0018B508
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

		// Token: 0x0600A464 RID: 42084 RVA: 0x0018D33C File Offset: 0x0018B53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x0018D349 File Offset: 0x0018B549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x0018D352 File Offset: 0x0018B552
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

		// Token: 0x0600A467 RID: 42087 RVA: 0x0018D37C File Offset: 0x0018B57C
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

		// Token: 0x0600A468 RID: 42088 RVA: 0x0018D3B5 File Offset: 0x0018B5B5
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

		// Token: 0x0600A469 RID: 42089 RVA: 0x0018D3E3 File Offset: 0x0018B5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x0018D3EC File Offset: 0x0018B5EC
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

		// Token: 0x04004C22 RID: 19490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C23 RID: 19491
		public const int GroupTypesFieldNumber = 1;

		// Token: 0x04004C24 RID: 19492
		private static readonly FieldCodec<int> _repeated_groupTypes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004C25 RID: 19493
		private readonly RepeatedField<int> groupTypes_ = new RepeatedField<int>();
	}
}
