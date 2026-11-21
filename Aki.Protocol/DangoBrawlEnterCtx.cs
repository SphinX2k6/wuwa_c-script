using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000348 RID: 840
	public sealed class DangoBrawlEnterCtx : IMessage<DangoBrawlEnterCtx>, IMessage, IEquatable<DangoBrawlEnterCtx>, IDeepCloneable<DangoBrawlEnterCtx>, IBufferMessage
	{
		// Token: 0x0600544E RID: 21582 RVA: 0x000CDBFA File Offset: 0x000CBDFA
		[NullableContext(1)]
		public static DangoBrawlEnterCtx Create()
		{
			return new DangoBrawlEnterCtx();
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x000CDC01 File Offset: 0x000CBE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x000CDC04 File Offset: 0x000CBE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEnterCtx.Descriptor;
			}
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x000CDC0B File Offset: 0x000CBE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx()
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x000CDC13 File Offset: 0x000CBE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx(DangoBrawlEnterCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roleId_ = other.roleId_;
			this.isContinue_ = other.isContinue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x000CDC50 File Offset: 0x000CBE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx Clone()
		{
			return new DangoBrawlEnterCtx(this);
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06005454 RID: 21588 RVA: 0x000CDC58 File Offset: 0x000CBE58
		// (set) Token: 0x06005455 RID: 21589 RVA: 0x000CDC60 File Offset: 0x000CBE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06005456 RID: 21590 RVA: 0x000CDC69 File Offset: 0x000CBE69
		// (set) Token: 0x06005457 RID: 21591 RVA: 0x000CDC71 File Offset: 0x000CBE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x000CDC7A File Offset: 0x000CBE7A
		// (set) Token: 0x06005459 RID: 21593 RVA: 0x000CDC82 File Offset: 0x000CBE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsContinue
		{
			get
			{
				return this.isContinue_;
			}
			set
			{
				this.isContinue_ = value;
			}
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x000CDC8B File Offset: 0x000CBE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEnterCtx);
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x000CDC9C File Offset: 0x000CBE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEnterCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoleId == other.RoleId && this.IsContinue == other.IsContinue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x000CDCF8 File Offset: 0x000CBEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.IsContinue)
			{
				num ^= this.IsContinue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x000CDD69 File Offset: 0x000CBF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x000CDD76 File Offset: 0x000CBF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x000CDD80 File Offset: 0x000CBF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.IsContinue)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsContinue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x000CDDF4 File Offset: 0x000CBFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.IsContinue)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x000CDE58 File Offset: 0x000CC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.IsContinue)
			{
				this.IsContinue = other.IsContinue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x000CDEBC File Offset: 0x000CC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x000CDEC8 File Offset: 0x000CC0C8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsContinue = input.ReadBool();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003414 RID: 13332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003415 RID: 13333
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04003416 RID: 13334
		private int challengeId_;

		// Token: 0x04003417 RID: 13335
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04003418 RID: 13336
		private int roleId_;

		// Token: 0x04003419 RID: 13337
		public const int IsContinueFieldNumber = 3;

		// Token: 0x0400341A RID: 13338
		private bool isContinue_;
	}
}
