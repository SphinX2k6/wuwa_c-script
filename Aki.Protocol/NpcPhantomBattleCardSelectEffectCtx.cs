using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5C RID: 2908
	public sealed class NpcPhantomBattleCardSelectEffectCtx : IMessage<NpcPhantomBattleCardSelectEffectCtx>, IMessage, IEquatable<NpcPhantomBattleCardSelectEffectCtx>, IDeepCloneable<NpcPhantomBattleCardSelectEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FC52 RID: 64594 RVA: 0x0024C660 File Offset: 0x0024A860
		[NullableContext(1)]
		public static NpcPhantomBattleCardSelectEffectCtx Create()
		{
			return new NpcPhantomBattleCardSelectEffectCtx();
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600FC53 RID: 64595 RVA: 0x0024C667 File Offset: 0x0024A867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600FC54 RID: 64596 RVA: 0x0024C66A File Offset: 0x0024A86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardSelectEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FC55 RID: 64597 RVA: 0x0024C671 File Offset: 0x0024A871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx()
		{
		}

		// Token: 0x0600FC56 RID: 64598 RVA: 0x0024C679 File Offset: 0x0024A879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx(NpcPhantomBattleCardSelectEffectCtx other) : this()
		{
			this.curHandNum_ = other.curHandNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC57 RID: 64599 RVA: 0x0024C6AA File Offset: 0x0024A8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx Clone()
		{
			return new NpcPhantomBattleCardSelectEffectCtx(this);
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600FC58 RID: 64600 RVA: 0x0024C6B2 File Offset: 0x0024A8B2
		// (set) Token: 0x0600FC59 RID: 64601 RVA: 0x0024C6BA File Offset: 0x0024A8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurHandNum
		{
			get
			{
				return this.curHandNum_;
			}
			set
			{
				this.curHandNum_ = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600FC5A RID: 64602 RVA: 0x0024C6C3 File Offset: 0x0024A8C3
		// (set) Token: 0x0600FC5B RID: 64603 RVA: 0x0024C6CB File Offset: 0x0024A8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FC5C RID: 64604 RVA: 0x0024C6D4 File Offset: 0x0024A8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardSelectEffectCtx);
		}

		// Token: 0x0600FC5D RID: 64605 RVA: 0x0024C6E2 File Offset: 0x0024A8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardSelectEffectCtx other)
		{
			return other != null && (other == this || (this.CurHandNum == other.CurHandNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC5E RID: 64606 RVA: 0x0024C720 File Offset: 0x0024A920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurHandNum != 0)
			{
				num ^= this.CurHandNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC5F RID: 64607 RVA: 0x0024C778 File Offset: 0x0024A978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC60 RID: 64608 RVA: 0x0024C785 File Offset: 0x0024A985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC61 RID: 64609 RVA: 0x0024C790 File Offset: 0x0024A990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurHandNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC62 RID: 64610 RVA: 0x0024C7E8 File Offset: 0x0024A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurHandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC63 RID: 64611 RVA: 0x0024C840 File Offset: 0x0024AA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardSelectEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurHandNum != 0)
			{
				this.CurHandNum = other.CurHandNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC64 RID: 64612 RVA: 0x0024C890 File Offset: 0x0024AA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC65 RID: 64613 RVA: 0x0024C89C File Offset: 0x0024AA9C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.CurHandNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400651E RID: 25886
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400651F RID: 25887
		public const int CurHandNumFieldNumber = 1;

		// Token: 0x04006520 RID: 25888
		private int curHandNum_;

		// Token: 0x04006521 RID: 25889
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006522 RID: 25890
		private int cardLibraryNum_;
	}
}
