using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000349 RID: 841
	public sealed class DangoBrawlFightActionBuffRemoveInfo : IMessage<DangoBrawlFightActionBuffRemoveInfo>, IMessage, IEquatable<DangoBrawlFightActionBuffRemoveInfo>, IDeepCloneable<DangoBrawlFightActionBuffRemoveInfo>, IBufferMessage
	{
		// Token: 0x06005423 RID: 21539 RVA: 0x000CD148 File Offset: 0x000CB348
		[NullableContext(1)]
		public static DangoBrawlFightActionBuffRemoveInfo Create()
		{
			return new DangoBrawlFightActionBuffRemoveInfo();
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x000CD14F File Offset: 0x000CB34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x000CD152 File Offset: 0x000CB352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionBuffRemoveInfo.Descriptor;
			}
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x000CD159 File Offset: 0x000CB359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo()
		{
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x000CD161 File Offset: 0x000CB361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo(DangoBrawlFightActionBuffRemoveInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.targetFighterUId_ = other.targetFighterUId_;
			this.sourceItemUId_ = other.sourceItemUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x000CD19E File Offset: 0x000CB39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionBuffRemoveInfo Clone()
		{
			return new DangoBrawlFightActionBuffRemoveInfo(this);
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06005429 RID: 21545 RVA: 0x000CD1A6 File Offset: 0x000CB3A6
		// (set) Token: 0x0600542A RID: 21546 RVA: 0x000CD1AE File Offset: 0x000CB3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffUId
		{
			get
			{
				return this.buffUId_;
			}
			set
			{
				this.buffUId_ = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x0600542B RID: 21547 RVA: 0x000CD1B7 File Offset: 0x000CB3B7
		// (set) Token: 0x0600542C RID: 21548 RVA: 0x000CD1BF File Offset: 0x000CB3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x0600542D RID: 21549 RVA: 0x000CD1C8 File Offset: 0x000CB3C8
		// (set) Token: 0x0600542E RID: 21550 RVA: 0x000CD1D0 File Offset: 0x000CB3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceItemUId
		{
			get
			{
				return this.sourceItemUId_;
			}
			set
			{
				this.sourceItemUId_ = value;
			}
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x000CD1D9 File Offset: 0x000CB3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionBuffRemoveInfo);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x000CD1E8 File Offset: 0x000CB3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionBuffRemoveInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.TargetFighterUId == other.TargetFighterUId && this.SourceItemUId == other.SourceItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x000CD244 File Offset: 0x000CB444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.SourceItemUId != 0)
			{
				num ^= this.SourceItemUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x000CD2B5 File Offset: 0x000CB4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x000CD2C2 File Offset: 0x000CB4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x000CD2CC File Offset: 0x000CB4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.SourceItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SourceItemUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x000CD340 File Offset: 0x000CB540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.SourceItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceItemUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x000CD3B0 File Offset: 0x000CB5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionBuffRemoveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.SourceItemUId != 0)
			{
				this.SourceItemUId = other.SourceItemUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x000CD414 File Offset: 0x000CB614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x000CD420 File Offset: 0x000CB620
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
							this.SourceItemUId = input.ReadInt32();
						}
					}
					else
					{
						this.TargetFighterUId = input.ReadInt32();
					}
				}
				else
				{
					this.BuffUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033B5 RID: 13237
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033B6 RID: 13238
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x040033B7 RID: 13239
		private int buffUId_;

		// Token: 0x040033B8 RID: 13240
		public const int TargetFighterUIdFieldNumber = 2;

		// Token: 0x040033B9 RID: 13241
		private int targetFighterUId_;

		// Token: 0x040033BA RID: 13242
		public const int SourceItemUIdFieldNumber = 3;

		// Token: 0x040033BB RID: 13243
		private int sourceItemUId_;
	}
}
