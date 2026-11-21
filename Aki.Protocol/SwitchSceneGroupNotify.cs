using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001374 RID: 4980
	[NetMessage(EMessageId.SwitchSceneGroupNotify)]
	public sealed class SwitchSceneGroupNotify : IMessage<SwitchSceneGroupNotify>, IMessage, IEquatable<SwitchSceneGroupNotify>, IDeepCloneable<SwitchSceneGroupNotify>, IBufferMessage
	{
		// Token: 0x0601A852 RID: 108626 RVA: 0x003DD3E7 File Offset: 0x003DB5E7
		[NullableContext(1)]
		public static SwitchSceneGroupNotify Create()
		{
			return new SwitchSceneGroupNotify();
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x0601A853 RID: 108627 RVA: 0x003DD3EE File Offset: 0x003DB5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x0601A854 RID: 108628 RVA: 0x003DD3F1 File Offset: 0x003DB5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchSceneGroupNotify.Descriptor;
			}
		}

		// Token: 0x0601A855 RID: 108629 RVA: 0x003DD3F8 File Offset: 0x003DB5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify()
		{
		}

		// Token: 0x0601A856 RID: 108630 RVA: 0x003DD400 File Offset: 0x003DB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify(SwitchSceneGroupNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.group_ = other.group_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A857 RID: 108631 RVA: 0x003DD431 File Offset: 0x003DB631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchSceneGroupNotify Clone()
		{
			return new SwitchSceneGroupNotify(this);
		}

		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x0601A858 RID: 108632 RVA: 0x003DD439 File Offset: 0x003DB639
		// (set) Token: 0x0601A859 RID: 108633 RVA: 0x003DD441 File Offset: 0x003DB641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x0601A85A RID: 108634 RVA: 0x003DD44A File Offset: 0x003DB64A
		// (set) Token: 0x0601A85B RID: 108635 RVA: 0x003DD452 File Offset: 0x003DB652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x0601A85C RID: 108636 RVA: 0x003DD45B File Offset: 0x003DB65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchSceneGroupNotify);
		}

		// Token: 0x0601A85D RID: 108637 RVA: 0x003DD469 File Offset: 0x003DB669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchSceneGroupNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Group == other.Group && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A85E RID: 108638 RVA: 0x003DD4A8 File Offset: 0x003DB6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A85F RID: 108639 RVA: 0x003DD500 File Offset: 0x003DB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A860 RID: 108640 RVA: 0x003DD50D File Offset: 0x003DB70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A861 RID: 108641 RVA: 0x003DD518 File Offset: 0x003DB718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Group != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Group);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A862 RID: 108642 RVA: 0x003DD574 File Offset: 0x003DB774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A863 RID: 108643 RVA: 0x003DD5CC File Offset: 0x003DB7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchSceneGroupNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A864 RID: 108644 RVA: 0x003DD61C File Offset: 0x003DB81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A865 RID: 108645 RVA: 0x003DD628 File Offset: 0x003DB828
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Group = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B7E RID: 39806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B7F RID: 39807
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04009B80 RID: 39808
		private int playerId_;

		// Token: 0x04009B81 RID: 39809
		public const int GroupFieldNumber = 15;

		// Token: 0x04009B82 RID: 39810
		private int group_;
	}
}
