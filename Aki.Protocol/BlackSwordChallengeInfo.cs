using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AC RID: 428
	public sealed class BlackSwordChallengeInfo : IMessage<BlackSwordChallengeInfo>, IMessage, IEquatable<BlackSwordChallengeInfo>, IDeepCloneable<BlackSwordChallengeInfo>, IBufferMessage
	{
		// Token: 0x06003209 RID: 12809 RVA: 0x0007F413 File Offset: 0x0007D613
		[NullableContext(1)]
		public static BlackSwordChallengeInfo Create()
		{
			return new BlackSwordChallengeInfo();
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x0007F41A File Offset: 0x0007D61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackSwordChallengeInfo> Parser
		{
			get
			{
				return BlackSwordChallengeInfo._parser;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x0007F421 File Offset: 0x0007D621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x0007F424 File Offset: 0x0007D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0007F42B File Offset: 0x0007D62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo()
		{
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0007F433 File Offset: 0x0007D633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo(BlackSwordChallengeInfo other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.isUnLocked_ = other.isUnLocked_;
			this.completeNumber_ = other.completeNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x0007F470 File Offset: 0x0007D670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeInfo Clone()
		{
			return new BlackSwordChallengeInfo(this);
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0007F478 File Offset: 0x0007D678
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0007F480 File Offset: 0x0007D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x0007F489 File Offset: 0x0007D689
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x0007F491 File Offset: 0x0007D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnLocked
		{
			get
			{
				return this.isUnLocked_;
			}
			set
			{
				this.isUnLocked_ = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x0007F49A File Offset: 0x0007D69A
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x0007F4A2 File Offset: 0x0007D6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompleteNumber
		{
			get
			{
				return this.completeNumber_;
			}
			set
			{
				this.completeNumber_ = value;
			}
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x0007F4AB File Offset: 0x0007D6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeInfo);
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x0007F4BC File Offset: 0x0007D6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeInfo other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.IsUnLocked == other.IsUnLocked && this.CompleteNumber == other.CompleteNumber && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x0007F518 File Offset: 0x0007D718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.IsUnLocked)
			{
				num ^= this.IsUnLocked.GetHashCode();
			}
			if (this.CompleteNumber != 0)
			{
				num ^= this.CompleteNumber.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x0007F589 File Offset: 0x0007D789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0007F596 File Offset: 0x0007D796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.IsUnLocked)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnLocked);
			}
			if (this.CompleteNumber != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x0007F614 File Offset: 0x0007D814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.IsUnLocked)
			{
				num += 2;
			}
			if (this.CompleteNumber != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompleteNumber);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0007F678 File Offset: 0x0007D878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.IsUnLocked)
			{
				this.IsUnLocked = other.IsUnLocked;
			}
			if (other.CompleteNumber != 0)
			{
				this.CompleteNumber = other.CompleteNumber;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x0007F6DC File Offset: 0x0007D8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
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
							this.CompleteNumber = input.ReadInt32();
						}
					}
					else
					{
						this.IsUnLocked = input.ReadBool();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400295C RID: 10588
		private static readonly MessageParser<BlackSwordChallengeInfo> _parser = new MessageParser<BlackSwordChallengeInfo>(() => new BlackSwordChallengeInfo());

		// Token: 0x0400295D RID: 10589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400295E RID: 10590
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x0400295F RID: 10591
		private int levelPlayId_;

		// Token: 0x04002960 RID: 10592
		public const int IsUnLockedFieldNumber = 2;

		// Token: 0x04002961 RID: 10593
		private bool isUnLocked_;

		// Token: 0x04002962 RID: 10594
		public const int CompleteNumberFieldNumber = 3;

		// Token: 0x04002963 RID: 10595
		private int completeNumber_;
	}
}
