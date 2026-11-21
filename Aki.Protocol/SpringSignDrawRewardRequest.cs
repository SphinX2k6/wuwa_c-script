using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EC RID: 4844
	[NetMessage(EMessageId.SpringSignDrawRewardRequest)]
	public sealed class SpringSignDrawRewardRequest : IMessage<SpringSignDrawRewardRequest>, IMessage, IEquatable<SpringSignDrawRewardRequest>, IDeepCloneable<SpringSignDrawRewardRequest>, IBufferMessage
	{
		// Token: 0x06019D98 RID: 105880 RVA: 0x003C585C File Offset: 0x003C3A5C
		[NullableContext(1)]
		public static SpringSignDrawRewardRequest Create()
		{
			return new SpringSignDrawRewardRequest();
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x06019D99 RID: 105881 RVA: 0x003C5863 File Offset: 0x003C3A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x06019D9A RID: 105882 RVA: 0x003C5866 File Offset: 0x003C3A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRewardRequest.Descriptor;
			}
		}

		// Token: 0x06019D9B RID: 105883 RVA: 0x003C586D File Offset: 0x003C3A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest()
		{
		}

		// Token: 0x06019D9C RID: 105884 RVA: 0x003C5875 File Offset: 0x003C3A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest(SpringSignDrawRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D9D RID: 105885 RVA: 0x003C589A File Offset: 0x003C3A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRewardRequest Clone()
		{
			return new SpringSignDrawRewardRequest(this);
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x06019D9E RID: 105886 RVA: 0x003C58A2 File Offset: 0x003C3AA2
		// (set) Token: 0x06019D9F RID: 105887 RVA: 0x003C58AA File Offset: 0x003C3AAA
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

		// Token: 0x06019DA0 RID: 105888 RVA: 0x003C58B3 File Offset: 0x003C3AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRewardRequest);
		}

		// Token: 0x06019DA1 RID: 105889 RVA: 0x003C58C1 File Offset: 0x003C3AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DA2 RID: 105890 RVA: 0x003C58F0 File Offset: 0x003C3AF0
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

		// Token: 0x06019DA3 RID: 105891 RVA: 0x003C592F File Offset: 0x003C3B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DA4 RID: 105892 RVA: 0x003C593C File Offset: 0x003C3B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DA5 RID: 105893 RVA: 0x003C5945 File Offset: 0x003C3B45
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

		// Token: 0x06019DA6 RID: 105894 RVA: 0x003C5978 File Offset: 0x003C3B78
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

		// Token: 0x06019DA7 RID: 105895 RVA: 0x003C59B6 File Offset: 0x003C3BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRewardRequest other)
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

		// Token: 0x06019DA8 RID: 105896 RVA: 0x003C59E7 File Offset: 0x003C3BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DA9 RID: 105897 RVA: 0x003C59F0 File Offset: 0x003C3BF0
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

		// Token: 0x0400988C RID: 39052
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400988D RID: 39053
		public const int IdFieldNumber = 13;

		// Token: 0x0400988E RID: 39054
		private int id_;
	}
}
