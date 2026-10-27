using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000828 RID: 2088
	[NetMessage(EMessageId.InstPlayDataNotify)]
	public sealed class InstPlayDataNotify : IMessage<InstPlayDataNotify>, IMessage, IEquatable<InstPlayDataNotify>, IDeepCloneable<InstPlayDataNotify>, IBufferMessage
	{
		// Token: 0x0600BA97 RID: 47767 RVA: 0x001BC519 File Offset: 0x001BA719
		[NullableContext(1)]
		public static InstPlayDataNotify Create()
		{
			return new InstPlayDataNotify();
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x001BC520 File Offset: 0x001BA720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600BA99 RID: 47769 RVA: 0x001BC523 File Offset: 0x001BA723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstPlayDataNotify.Descriptor;
			}
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x001BC52A File Offset: 0x001BA72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify()
		{
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x001BC532 File Offset: 0x001BA732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify(InstPlayDataNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x001BC557 File Offset: 0x001BA757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstPlayDataNotify Clone()
		{
			return new InstPlayDataNotify(this);
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600BA9D RID: 47773 RVA: 0x001BC55F File Offset: 0x001BA75F
		// (set) Token: 0x0600BA9E RID: 47774 RVA: 0x001BC567 File Offset: 0x001BA767
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

		// Token: 0x0600BA9F RID: 47775 RVA: 0x001BC570 File Offset: 0x001BA770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstPlayDataNotify);
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x001BC57E File Offset: 0x001BA77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstPlayDataNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x001BC5AC File Offset: 0x001BA7AC
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

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x001BC5EB File Offset: 0x001BA7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x001BC5F8 File Offset: 0x001BA7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x001BC601 File Offset: 0x001BA801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x001BC634 File Offset: 0x001BA834
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

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x001BC672 File Offset: 0x001BA872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstPlayDataNotify other)
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

		// Token: 0x0600BAA7 RID: 47783 RVA: 0x001BC6A3 File Offset: 0x001BA8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x001BC6AC File Offset: 0x001BA8AC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040051F1 RID: 20977
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051F2 RID: 20978
		public const int IdFieldNumber = 7;

		// Token: 0x040051F3 RID: 20979
		private int id_;
	}
}
