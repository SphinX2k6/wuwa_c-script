using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000EB RID: 235
	[NetMessage(EMessageId.AnimationGameplayTagRequest)]
	public sealed class AnimationGameplayTagRequest : IMessage<AnimationGameplayTagRequest>, IMessage, IEquatable<AnimationGameplayTagRequest>, IDeepCloneable<AnimationGameplayTagRequest>, IBufferMessage
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0005B628 File Offset: 0x00059828
		[NullableContext(1)]
		public static AnimationGameplayTagRequest Create()
		{
			return new AnimationGameplayTagRequest();
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0005B62F File Offset: 0x0005982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0005B632 File Offset: 0x00059832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationGameplayTagRequest.Descriptor;
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0005B639 File Offset: 0x00059839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest()
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0005B641 File Offset: 0x00059841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest(AnimationGameplayTagRequest other) : this()
		{
			this.changedTagId_ = other.changedTagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0005B672 File Offset: 0x00059872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationGameplayTagRequest Clone()
		{
			return new AnimationGameplayTagRequest(this);
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0005B67A File Offset: 0x0005987A
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x0005B682 File Offset: 0x00059882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangedTagId
		{
			get
			{
				return this.changedTagId_;
			}
			set
			{
				this.changedTagId_ = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x0005B68B File Offset: 0x0005988B
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x0005B693 File Offset: 0x00059893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0005B69C File Offset: 0x0005989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationGameplayTagRequest);
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x0005B6AA File Offset: 0x000598AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationGameplayTagRequest other)
		{
			return other != null && (other == this || (this.ChangedTagId == other.ChangedTagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0005B6E8 File Offset: 0x000598E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChangedTagId != 0)
			{
				num ^= this.ChangedTagId.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0005B740 File Offset: 0x00059940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0005B74D File Offset: 0x0005994D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0005B758 File Offset: 0x00059958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAdd)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsAdd);
			}
			if (this.ChangedTagId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ChangedTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0005B7B4 File Offset: 0x000599B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChangedTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangedTagId);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0005B800 File Offset: 0x00059A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationGameplayTagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChangedTagId != 0)
			{
				this.ChangedTagId = other.ChangedTagId;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0005B850 File Offset: 0x00059A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0005B85C File Offset: 0x00059A5C
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
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChangedTagId = input.ReadInt32();
					}
				}
				else
				{
					this.IsAdd = input.ReadBool();
				}
			}
		}

		// Token: 0x040024BD RID: 9405
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024BE RID: 9406
		public const int ChangedTagIdFieldNumber = 15;

		// Token: 0x040024BF RID: 9407
		private int changedTagId_;

		// Token: 0x040024C0 RID: 9408
		public const int IsAddFieldNumber = 6;

		// Token: 0x040024C1 RID: 9409
		private bool isAdd_;
	}
}
