using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000340 RID: 832
	public sealed class DangoBrawlEnterCtx : IMessage<DangoBrawlEnterCtx>, IMessage, IEquatable<DangoBrawlEnterCtx>, IDeepCloneable<DangoBrawlEnterCtx>, IBufferMessage
	{
		// Token: 0x06005361 RID: 21345 RVA: 0x000CB576 File Offset: 0x000C9776
		[NullableContext(1)]
		public static DangoBrawlEnterCtx Create()
		{
			return new DangoBrawlEnterCtx();
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x000CB57D File Offset: 0x000C977D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x000CB580 File Offset: 0x000C9780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEnterCtx.Descriptor;
			}
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x000CB587 File Offset: 0x000C9787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx()
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x000CB58F File Offset: 0x000C978F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx(DangoBrawlEnterCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roleId_ = other.roleId_;
			this.isContinue_ = other.isContinue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x000CB5CC File Offset: 0x000C97CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEnterCtx Clone()
		{
			return new DangoBrawlEnterCtx(this);
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x000CB5D4 File Offset: 0x000C97D4
		// (set) Token: 0x06005368 RID: 21352 RVA: 0x000CB5DC File Offset: 0x000C97DC
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

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x000CB5E5 File Offset: 0x000C97E5
		// (set) Token: 0x0600536A RID: 21354 RVA: 0x000CB5ED File Offset: 0x000C97ED
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

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x000CB5F6 File Offset: 0x000C97F6
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x000CB5FE File Offset: 0x000C97FE
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

		// Token: 0x0600536D RID: 21357 RVA: 0x000CB607 File Offset: 0x000C9807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEnterCtx);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x000CB618 File Offset: 0x000C9818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEnterCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoleId == other.RoleId && this.IsContinue == other.IsContinue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x000CB674 File Offset: 0x000C9874
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

		// Token: 0x06005370 RID: 21360 RVA: 0x000CB6E5 File Offset: 0x000C98E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x000CB6F2 File Offset: 0x000C98F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x000CB6FC File Offset: 0x000C98FC
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

		// Token: 0x06005373 RID: 21363 RVA: 0x000CB770 File Offset: 0x000C9970
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

		// Token: 0x06005374 RID: 21364 RVA: 0x000CB7D4 File Offset: 0x000C99D4
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

		// Token: 0x06005375 RID: 21365 RVA: 0x000CB838 File Offset: 0x000C9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x000CB844 File Offset: 0x000C9A44
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

		// Token: 0x04003378 RID: 13176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003379 RID: 13177
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400337A RID: 13178
		private int challengeId_;

		// Token: 0x0400337B RID: 13179
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400337C RID: 13180
		private int roleId_;

		// Token: 0x0400337D RID: 13181
		public const int IsContinueFieldNumber = 3;

		// Token: 0x0400337E RID: 13182
		private bool isContinue_;
	}
}
