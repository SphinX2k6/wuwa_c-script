using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7E RID: 2942
	public sealed class OneQuestBranchPageInfo : IMessage<OneQuestBranchPageInfo>, IMessage, IEquatable<OneQuestBranchPageInfo>, IDeepCloneable<OneQuestBranchPageInfo>, IBufferMessage
	{
		// Token: 0x0600FF86 RID: 65414 RVA: 0x002550C2 File Offset: 0x002532C2
		[NullableContext(1)]
		public static OneQuestBranchPageInfo Create()
		{
			return new OneQuestBranchPageInfo();
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600FF87 RID: 65415 RVA: 0x002550C9 File Offset: 0x002532C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneQuestBranchPageInfo> Parser
		{
			get
			{
				return OneQuestBranchPageInfo._parser;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600FF88 RID: 65416 RVA: 0x002550D0 File Offset: 0x002532D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600FF89 RID: 65417 RVA: 0x002550D3 File Offset: 0x002532D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneQuestBranchPageInfo.Descriptor;
			}
		}

		// Token: 0x0600FF8A RID: 65418 RVA: 0x002550DA File Offset: 0x002532DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo()
		{
		}

		// Token: 0x0600FF8B RID: 65419 RVA: 0x002550F0 File Offset: 0x002532F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo(OneQuestBranchPageInfo other) : this()
		{
			this.id_ = other.id_;
			this.curBranch_ = other.curBranch_;
			this.completeBranches_ = other.completeBranches_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF8C RID: 65420 RVA: 0x0025513D File Offset: 0x0025333D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo Clone()
		{
			return new OneQuestBranchPageInfo(this);
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600FF8D RID: 65421 RVA: 0x00255145 File Offset: 0x00253345
		// (set) Token: 0x0600FF8E RID: 65422 RVA: 0x0025514D File Offset: 0x0025334D
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

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600FF8F RID: 65423 RVA: 0x00255156 File Offset: 0x00253356
		// (set) Token: 0x0600FF90 RID: 65424 RVA: 0x0025515E File Offset: 0x0025335E
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

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600FF91 RID: 65425 RVA: 0x00255167 File Offset: 0x00253367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteBranches
		{
			get
			{
				return this.completeBranches_;
			}
		}

		// Token: 0x0600FF92 RID: 65426 RVA: 0x0025516F File Offset: 0x0025336F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneQuestBranchPageInfo);
		}

		// Token: 0x0600FF93 RID: 65427 RVA: 0x00255180 File Offset: 0x00253380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneQuestBranchPageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CurBranch == other.CurBranch && this.completeBranches_.Equals(other.completeBranches_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF94 RID: 65428 RVA: 0x002551E0 File Offset: 0x002533E0
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

		// Token: 0x0600FF95 RID: 65429 RVA: 0x00255246 File Offset: 0x00253446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF96 RID: 65430 RVA: 0x00255253 File Offset: 0x00253453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF97 RID: 65431 RVA: 0x0025525C File Offset: 0x0025345C
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

		// Token: 0x0600FF98 RID: 65432 RVA: 0x002552C8 File Offset: 0x002534C8
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

		// Token: 0x0600FF99 RID: 65433 RVA: 0x00255334 File Offset: 0x00253534
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

		// Token: 0x0600FF9A RID: 65434 RVA: 0x00255395 File Offset: 0x00253595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF9B RID: 65435 RVA: 0x002553A0 File Offset: 0x002535A0
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

		// Token: 0x04006648 RID: 26184
		private static readonly MessageParser<OneQuestBranchPageInfo> _parser = new MessageParser<OneQuestBranchPageInfo>(() => new OneQuestBranchPageInfo());

		// Token: 0x04006649 RID: 26185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400664A RID: 26186
		public const int IdFieldNumber = 1;

		// Token: 0x0400664B RID: 26187
		private int id_;

		// Token: 0x0400664C RID: 26188
		public const int CurBranchFieldNumber = 2;

		// Token: 0x0400664D RID: 26189
		private int curBranch_;

		// Token: 0x0400664E RID: 26190
		public const int CompleteBranchesFieldNumber = 3;

		// Token: 0x0400664F RID: 26191
		private static readonly FieldCodec<int> _repeated_completeBranches_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006650 RID: 26192
		private readonly RepeatedField<int> completeBranches_ = new RepeatedField<int>();
	}
}
