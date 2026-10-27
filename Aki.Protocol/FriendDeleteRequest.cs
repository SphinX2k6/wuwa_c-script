using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000653 RID: 1619
	[NetMessage(EMessageId.FriendDeleteRequest)]
	public sealed class FriendDeleteRequest : IMessage<FriendDeleteRequest>, IMessage, IEquatable<FriendDeleteRequest>, IDeepCloneable<FriendDeleteRequest>, IBufferMessage
	{
		// Token: 0x060094D0 RID: 38096 RVA: 0x00167759 File Offset: 0x00165959
		[NullableContext(1)]
		public static FriendDeleteRequest Create()
		{
			return new FriendDeleteRequest();
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x060094D1 RID: 38097 RVA: 0x00167760 File Offset: 0x00165960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x00167763 File Offset: 0x00165963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeleteRequest.Descriptor;
			}
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x0016776A File Offset: 0x0016596A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest()
		{
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x00167772 File Offset: 0x00165972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest(FriendDeleteRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x00167797 File Offset: 0x00165997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest Clone()
		{
			return new FriendDeleteRequest(this);
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x060094D6 RID: 38102 RVA: 0x0016779F File Offset: 0x0016599F
		// (set) Token: 0x060094D7 RID: 38103 RVA: 0x001677A7 File Offset: 0x001659A7
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

		// Token: 0x060094D8 RID: 38104 RVA: 0x001677B0 File Offset: 0x001659B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeleteRequest);
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x001677BE File Offset: 0x001659BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeleteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x001677EC File Offset: 0x001659EC
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

		// Token: 0x060094DB RID: 38107 RVA: 0x0016782B File Offset: 0x00165A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x00167838 File Offset: 0x00165A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x00167841 File Offset: 0x00165A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x00167874 File Offset: 0x00165A74
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

		// Token: 0x060094DF RID: 38111 RVA: 0x001678B2 File Offset: 0x00165AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendDeleteRequest other)
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

		// Token: 0x060094E0 RID: 38112 RVA: 0x001678E3 File Offset: 0x00165AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x001678EC File Offset: 0x00165AEC
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400473C RID: 18236
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400473D RID: 18237
		public const int IdFieldNumber = 12;

		// Token: 0x0400473E RID: 18238
		private int id_;
	}
}
