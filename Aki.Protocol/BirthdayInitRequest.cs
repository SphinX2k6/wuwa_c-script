using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019F RID: 415
	[NetMessage(EMessageId.BirthdayInitRequest)]
	public sealed class BirthdayInitRequest : IMessage<BirthdayInitRequest>, IMessage, IEquatable<BirthdayInitRequest>, IDeepCloneable<BirthdayInitRequest>, IBufferMessage
	{
		// Token: 0x0600312A RID: 12586 RVA: 0x0007D77E File Offset: 0x0007B97E
		[NullableContext(1)]
		public static BirthdayInitRequest Create()
		{
			return new BirthdayInitRequest();
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x0007D785 File Offset: 0x0007B985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0007D788 File Offset: 0x0007B988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayInitRequest.Descriptor;
			}
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0007D78F File Offset: 0x0007B98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest()
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x0007D797 File Offset: 0x0007B997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest(BirthdayInitRequest other) : this()
		{
			this.birthday_ = other.birthday_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x0007D7BC File Offset: 0x0007B9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest Clone()
		{
			return new BirthdayInitRequest(this);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0007D7C4 File Offset: 0x0007B9C4
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0007D7CC File Offset: 0x0007B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Birthday
		{
			get
			{
				return this.birthday_;
			}
			set
			{
				this.birthday_ = value;
			}
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x0007D7D5 File Offset: 0x0007B9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayInitRequest);
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x0007D7E3 File Offset: 0x0007B9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayInitRequest other)
		{
			return other != null && (other == this || (this.Birthday == other.Birthday && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0007D814 File Offset: 0x0007BA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Birthday != 0)
			{
				num ^= this.Birthday.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0007D853 File Offset: 0x0007BA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0007D860 File Offset: 0x0007BA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x0007D869 File Offset: 0x0007BA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Birthday != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x0007D89C File Offset: 0x0007BA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Birthday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0007D8DA File Offset: 0x0007BADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayInitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Birthday != 0)
			{
				this.Birthday = other.Birthday;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x0007D90B File Offset: 0x0007BB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0007D914 File Offset: 0x0007BB14
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Birthday = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400297B RID: 10619
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400297C RID: 10620
		public const int BirthdayFieldNumber = 12;

		// Token: 0x0400297D RID: 10621
		private int birthday_;
	}
}
