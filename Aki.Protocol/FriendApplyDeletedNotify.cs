using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064C RID: 1612
	[NetMessage(EMessageId.FriendApplyDeletedNotify)]
	public sealed class FriendApplyDeletedNotify : IMessage<FriendApplyDeletedNotify>, IMessage, IEquatable<FriendApplyDeletedNotify>, IDeepCloneable<FriendApplyDeletedNotify>, IBufferMessage
	{
		// Token: 0x0600944C RID: 37964 RVA: 0x00166773 File Offset: 0x00164973
		[NullableContext(1)]
		public static FriendApplyDeletedNotify Create()
		{
			return new FriendApplyDeletedNotify();
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x0600944D RID: 37965 RVA: 0x0016677A File Offset: 0x0016497A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x0600944E RID: 37966 RVA: 0x0016677D File Offset: 0x0016497D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyDeletedNotify.Descriptor;
			}
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00166784 File Offset: 0x00164984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify()
		{
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x0016678C File Offset: 0x0016498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify(FriendApplyDeletedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x001667B1 File Offset: 0x001649B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyDeletedNotify Clone()
		{
			return new FriendApplyDeletedNotify(this);
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x001667B9 File Offset: 0x001649B9
		// (set) Token: 0x06009453 RID: 37971 RVA: 0x001667C1 File Offset: 0x001649C1
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

		// Token: 0x06009454 RID: 37972 RVA: 0x001667CA File Offset: 0x001649CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyDeletedNotify);
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x001667D8 File Offset: 0x001649D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyDeletedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x00166808 File Offset: 0x00164A08
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

		// Token: 0x06009457 RID: 37975 RVA: 0x00166847 File Offset: 0x00164A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x00166854 File Offset: 0x00164A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x0016685D File Offset: 0x00164A5D
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

		// Token: 0x0600945A RID: 37978 RVA: 0x00166890 File Offset: 0x00164A90
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

		// Token: 0x0600945B RID: 37979 RVA: 0x001668CE File Offset: 0x00164ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyDeletedNotify other)
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

		// Token: 0x0600945C RID: 37980 RVA: 0x001668FF File Offset: 0x00164AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x00166908 File Offset: 0x00164B08
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

		// Token: 0x0400471F RID: 18207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004720 RID: 18208
		public const int IdFieldNumber = 12;

		// Token: 0x04004721 RID: 18209
		private int id_;
	}
}
