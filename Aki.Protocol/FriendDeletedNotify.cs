using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000652 RID: 1618
	[NetMessage(EMessageId.FriendDeletedNotify)]
	public sealed class FriendDeletedNotify : IMessage<FriendDeletedNotify>, IMessage, IEquatable<FriendDeletedNotify>, IDeepCloneable<FriendDeletedNotify>, IBufferMessage
	{
		// Token: 0x060094BE RID: 38078 RVA: 0x00167581 File Offset: 0x00165781
		[NullableContext(1)]
		public static FriendDeletedNotify Create()
		{
			return new FriendDeletedNotify();
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x060094BF RID: 38079 RVA: 0x00167588 File Offset: 0x00165788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x060094C0 RID: 38080 RVA: 0x0016758B File Offset: 0x0016578B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeletedNotify.Descriptor;
			}
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x00167592 File Offset: 0x00165792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify()
		{
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x0016759A File Offset: 0x0016579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify(FriendDeletedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x001675BF File Offset: 0x001657BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify Clone()
		{
			return new FriendDeletedNotify(this);
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x060094C4 RID: 38084 RVA: 0x001675C7 File Offset: 0x001657C7
		// (set) Token: 0x060094C5 RID: 38085 RVA: 0x001675CF File Offset: 0x001657CF
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

		// Token: 0x060094C6 RID: 38086 RVA: 0x001675D8 File Offset: 0x001657D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeletedNotify);
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x001675E6 File Offset: 0x001657E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeletedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00167614 File Offset: 0x00165814
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

		// Token: 0x060094C9 RID: 38089 RVA: 0x00167653 File Offset: 0x00165853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x00167660 File Offset: 0x00165860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00167669 File Offset: 0x00165869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x0016769C File Offset: 0x0016589C
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

		// Token: 0x060094CD RID: 38093 RVA: 0x001676DA File Offset: 0x001658DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendDeletedNotify other)
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

		// Token: 0x060094CE RID: 38094 RVA: 0x0016770B File Offset: 0x0016590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00167714 File Offset: 0x00165914
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004739 RID: 18233
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400473A RID: 18234
		public const int IdFieldNumber = 5;

		// Token: 0x0400473B RID: 18235
		private int id_;
	}
}
