using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C7 RID: 455
	public sealed class BossPilingCtx : IMessage<BossPilingCtx>, IMessage, IEquatable<BossPilingCtx>, IDeepCloneable<BossPilingCtx>, IBufferMessage
	{
		// Token: 0x06003462 RID: 13410 RVA: 0x000846FF File Offset: 0x000828FF
		[NullableContext(1)]
		public static BossPilingCtx Create()
		{
			return new BossPilingCtx();
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x00084706 File Offset: 0x00082906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00084709 File Offset: 0x00082909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingCtx.Descriptor;
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00084710 File Offset: 0x00082910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx()
		{
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00084723 File Offset: 0x00082923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx(BossPilingCtx other) : this()
		{
			this.bossPilingLevelId_ = other.bossPilingLevelId_;
			this.skillBranchId_ = other.skillBranchId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00084759 File Offset: 0x00082959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingCtx Clone()
		{
			return new BossPilingCtx(this);
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x00084761 File Offset: 0x00082961
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x00084769 File Offset: 0x00082969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossPilingLevelId
		{
			get
			{
				return this.bossPilingLevelId_;
			}
			set
			{
				this.bossPilingLevelId_ = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x00084772 File Offset: 0x00082972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x0008477A File Offset: 0x0008297A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingCtx);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00084788 File Offset: 0x00082988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingCtx other)
		{
			return other != null && (other == this || (this.BossPilingLevelId == other.BossPilingLevelId && this.skillBranchId_.Equals(other.skillBranchId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x000847D8 File Offset: 0x000829D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossPilingLevelId != 0)
			{
				num ^= this.BossPilingLevelId.GetHashCode();
			}
			num ^= this.skillBranchId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00084825 File Offset: 0x00082A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00084832 File Offset: 0x00082A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x0008483C File Offset: 0x00082A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossPilingLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BossPilingLevelId);
			}
			this.skillBranchId_.WriteTo(ref output, BossPilingCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0008488C File Offset: 0x00082A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossPilingLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossPilingLevelId);
			}
			num += this.skillBranchId_.CalculateSize(BossPilingCtx._repeated_skillBranchId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000848E0 File Offset: 0x00082AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossPilingLevelId != 0)
			{
				this.BossPilingLevelId = other.BossPilingLevelId;
			}
			this.skillBranchId_.Add(other.skillBranchId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0008492D File Offset: 0x00082B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00084938 File Offset: 0x00082B38
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skillBranchId_.AddEntriesFrom(ref input, BossPilingCtx._repeated_skillBranchId_codec);
					}
				}
				else
				{
					this.BossPilingLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A52 RID: 10834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A53 RID: 10835
		public const int BossPilingLevelIdFieldNumber = 1;

		// Token: 0x04002A54 RID: 10836
		private int bossPilingLevelId_;

		// Token: 0x04002A55 RID: 10837
		public const int SkillBranchIdFieldNumber = 2;

		// Token: 0x04002A56 RID: 10838
		private static readonly FieldCodec<int> _repeated_skillBranchId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002A57 RID: 10839
		private readonly RepeatedField<int> skillBranchId_ = new RepeatedField<int>();
	}
}
