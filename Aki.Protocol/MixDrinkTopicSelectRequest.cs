using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E0 RID: 2528
	[NetMessage(EMessageId.MixDrinkTopicSelectRequest)]
	public sealed class MixDrinkTopicSelectRequest : IMessage<MixDrinkTopicSelectRequest>, IMessage, IEquatable<MixDrinkTopicSelectRequest>, IDeepCloneable<MixDrinkTopicSelectRequest>, IBufferMessage
	{
		// Token: 0x0600DD89 RID: 56713 RVA: 0x00207F7D File Offset: 0x0020617D
		[NullableContext(1)]
		public static MixDrinkTopicSelectRequest Create()
		{
			return new MixDrinkTopicSelectRequest();
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0600DD8A RID: 56714 RVA: 0x00207F84 File Offset: 0x00206184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0600DD8B RID: 56715 RVA: 0x00207F87 File Offset: 0x00206187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkTopicSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600DD8C RID: 56716 RVA: 0x00207F8E File Offset: 0x0020618E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest()
		{
		}

		// Token: 0x0600DD8D RID: 56717 RVA: 0x00207F96 File Offset: 0x00206196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest(MixDrinkTopicSelectRequest other) : this()
		{
			this.topicId_ = other.topicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD8E RID: 56718 RVA: 0x00207FBB File Offset: 0x002061BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectRequest Clone()
		{
			return new MixDrinkTopicSelectRequest(this);
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x00207FC3 File Offset: 0x002061C3
		// (set) Token: 0x0600DD90 RID: 56720 RVA: 0x00207FCB File Offset: 0x002061CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TopicId
		{
			get
			{
				return this.topicId_;
			}
			set
			{
				this.topicId_ = value;
			}
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x00207FD4 File Offset: 0x002061D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkTopicSelectRequest);
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x00207FE2 File Offset: 0x002061E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkTopicSelectRequest other)
		{
			return other != null && (other == this || (this.TopicId == other.TopicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x00208010 File Offset: 0x00206210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TopicId != 0)
			{
				num ^= this.TopicId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x0020804F File Offset: 0x0020624F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x0020805C File Offset: 0x0020625C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x00208065 File Offset: 0x00206265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TopicId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TopicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x00208098 File Offset: 0x00206298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TopicId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TopicId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x002080D6 File Offset: 0x002062D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkTopicSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TopicId != 0)
			{
				this.TopicId = other.TopicId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x00208107 File Offset: 0x00206307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x00208110 File Offset: 0x00206310
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
					this.TopicId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B98 RID: 23448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B99 RID: 23449
		public const int TopicIdFieldNumber = 7;

		// Token: 0x04005B9A RID: 23450
		private int topicId_;
	}
}
