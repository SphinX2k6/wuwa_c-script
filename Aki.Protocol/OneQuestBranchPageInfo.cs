using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8E RID: 2958
	public sealed class OneQuestBranchPageInfo : IMessage<OneQuestBranchPageInfo>, IMessage, IEquatable<OneQuestBranchPageInfo>, IDeepCloneable<OneQuestBranchPageInfo>, IBufferMessage
	{
		// Token: 0x0601008A RID: 65674 RVA: 0x00256F92 File Offset: 0x00255192
		[NullableContext(1)]
		public static OneQuestBranchPageInfo Create()
		{
			return new OneQuestBranchPageInfo();
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0601008B RID: 65675 RVA: 0x00256F99 File Offset: 0x00255199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneQuestBranchPageInfo> Parser
		{
			get
			{
				return OneQuestBranchPageInfo._parser;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0601008C RID: 65676 RVA: 0x00256FA0 File Offset: 0x002551A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0601008D RID: 65677 RVA: 0x00256FA3 File Offset: 0x002551A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneQuestBranchPageInfo.Descriptor;
			}
		}

		// Token: 0x0601008E RID: 65678 RVA: 0x00256FAA File Offset: 0x002551AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo()
		{
		}

		// Token: 0x0601008F RID: 65679 RVA: 0x00256FC0 File Offset: 0x002551C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo(OneQuestBranchPageInfo other) : this()
		{
			this.id_ = other.id_;
			this.curBranch_ = other.curBranch_;
			this.completeBranches_ = other.completeBranches_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010090 RID: 65680 RVA: 0x0025700D File Offset: 0x0025520D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo Clone()
		{
			return new OneQuestBranchPageInfo(this);
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x06010091 RID: 65681 RVA: 0x00257015 File Offset: 0x00255215
		// (set) Token: 0x06010092 RID: 65682 RVA: 0x0025701D File Offset: 0x0025521D
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

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x06010093 RID: 65683 RVA: 0x00257026 File Offset: 0x00255226
		// (set) Token: 0x06010094 RID: 65684 RVA: 0x0025702E File Offset: 0x0025522E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurBranch
		{
			get
			{
				return this.curBranch_;
			}
			set
			{
				this.curBranch_ = value;
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x06010095 RID: 65685 RVA: 0x00257037 File Offset: 0x00255237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteBranches
		{
			get
			{
				return this.completeBranches_;
			}
		}

		// Token: 0x06010096 RID: 65686 RVA: 0x0025703F File Offset: 0x0025523F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneQuestBranchPageInfo);
		}

		// Token: 0x06010097 RID: 65687 RVA: 0x00257050 File Offset: 0x00255250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneQuestBranchPageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CurBranch == other.CurBranch && this.completeBranches_.Equals(other.completeBranches_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010098 RID: 65688 RVA: 0x002570B0 File Offset: 0x002552B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CurBranch != 0)
			{
				num ^= this.CurBranch.GetHashCode();
			}
			num ^= this.completeBranches_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010099 RID: 65689 RVA: 0x00257116 File Offset: 0x00255316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601009A RID: 65690 RVA: 0x00257123 File Offset: 0x00255323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601009B RID: 65691 RVA: 0x0025712C File Offset: 0x0025532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CurBranch != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurBranch);
			}
			this.completeBranches_.WriteTo(ref output, OneQuestBranchPageInfo._repeated_completeBranches_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601009C RID: 65692 RVA: 0x00257198 File Offset: 0x00255398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CurBranch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurBranch);
			}
			num += this.completeBranches_.CalculateSize(OneQuestBranchPageInfo._repeated_completeBranches_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601009D RID: 65693 RVA: 0x00257204 File Offset: 0x00255404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneQuestBranchPageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CurBranch != 0)
			{
				this.CurBranch = other.CurBranch;
			}
			this.completeBranches_.Add(other.completeBranches_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601009E RID: 65694 RVA: 0x00257265 File Offset: 0x00255465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601009F RID: 65695 RVA: 0x00257270 File Offset: 0x00255470
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurBranch = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.completeBranches_.AddEntriesFrom(ref input, OneQuestBranchPageInfo._repeated_completeBranches_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006638 RID: 26168
		private static readonly MessageParser<OneQuestBranchPageInfo> _parser = new MessageParser<OneQuestBranchPageInfo>(() => new OneQuestBranchPageInfo());

		// Token: 0x04006639 RID: 26169
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400663A RID: 26170
		public const int IdFieldNumber = 1;

		// Token: 0x0400663B RID: 26171
		private int id_;

		// Token: 0x0400663C RID: 26172
		public const int CurBranchFieldNumber = 2;

		// Token: 0x0400663D RID: 26173
		private int curBranch_;

		// Token: 0x0400663E RID: 26174
		public const int CompleteBranchesFieldNumber = 3;

		// Token: 0x0400663F RID: 26175
		private static readonly FieldCodec<int> _repeated_completeBranches_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006640 RID: 26176
		private readonly RepeatedField<int> completeBranches_ = new RepeatedField<int>();
	}
}
