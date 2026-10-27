using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C75 RID: 3189
	public sealed class PhantomBattleDebugBuffInfo : IMessage<PhantomBattleDebugBuffInfo>, IMessage, IEquatable<PhantomBattleDebugBuffInfo>, IDeepCloneable<PhantomBattleDebugBuffInfo>, IBufferMessage
	{
		// Token: 0x06011494 RID: 70804 RVA: 0x00287E38 File Offset: 0x00286038
		[NullableContext(1)]
		public static PhantomBattleDebugBuffInfo Create()
		{
			return new PhantomBattleDebugBuffInfo();
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06011495 RID: 70805 RVA: 0x00287E3F File Offset: 0x0028603F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugBuffInfo> Parser
		{
			get
			{
				return PhantomBattleDebugBuffInfo._parser;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06011496 RID: 70806 RVA: 0x00287E46 File Offset: 0x00286046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06011497 RID: 70807 RVA: 0x00287E49 File Offset: 0x00286049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugBuffInfo.Descriptor;
			}
		}

		// Token: 0x06011498 RID: 70808 RVA: 0x00287E50 File Offset: 0x00286050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo()
		{
		}

		// Token: 0x06011499 RID: 70809 RVA: 0x00287E58 File Offset: 0x00286058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo(PhantomBattleDebugBuffInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.buffConfId_ = other.buffConfId_;
			this.remainRound_ = other.remainRound_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601149A RID: 70810 RVA: 0x00287E95 File Offset: 0x00286095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo Clone()
		{
			return new PhantomBattleDebugBuffInfo(this);
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0601149B RID: 70811 RVA: 0x00287E9D File Offset: 0x0028609D
		// (set) Token: 0x0601149C RID: 70812 RVA: 0x00287EA5 File Offset: 0x002860A5
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

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0601149D RID: 70813 RVA: 0x00287EAE File Offset: 0x002860AE
		// (set) Token: 0x0601149E RID: 70814 RVA: 0x00287EB6 File Offset: 0x002860B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffConfId
		{
			get
			{
				return this.buffConfId_;
			}
			set
			{
				this.buffConfId_ = value;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0601149F RID: 70815 RVA: 0x00287EBF File Offset: 0x002860BF
		// (set) Token: 0x060114A0 RID: 70816 RVA: 0x00287EC7 File Offset: 0x002860C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainRound
		{
			get
			{
				return this.remainRound_;
			}
			set
			{
				this.remainRound_ = value;
			}
		}

		// Token: 0x060114A1 RID: 70817 RVA: 0x00287ED0 File Offset: 0x002860D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugBuffInfo);
		}

		// Token: 0x060114A2 RID: 70818 RVA: 0x00287EE0 File Offset: 0x002860E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugBuffInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.BuffConfId == other.BuffConfId && this.RemainRound == other.RemainRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114A3 RID: 70819 RVA: 0x00287F3C File Offset: 0x0028613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.BuffConfId != 0)
			{
				num ^= this.BuffConfId.GetHashCode();
			}
			if (this.RemainRound != 0)
			{
				num ^= this.RemainRound.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060114A4 RID: 70820 RVA: 0x00287FAD File Offset: 0x002861AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114A5 RID: 70821 RVA: 0x00287FBA File Offset: 0x002861BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114A6 RID: 70822 RVA: 0x00287FC4 File Offset: 0x002861C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.BuffConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffConfId);
			}
			if (this.RemainRound != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RemainRound);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114A7 RID: 70823 RVA: 0x00288038 File Offset: 0x00286238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.BuffConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffConfId);
			}
			if (this.RemainRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainRound);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060114A8 RID: 70824 RVA: 0x002880A8 File Offset: 0x002862A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.BuffConfId != 0)
			{
				this.BuffConfId = other.BuffConfId;
			}
			if (other.RemainRound != 0)
			{
				this.RemainRound = other.RemainRound;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060114A9 RID: 70825 RVA: 0x0028810C File Offset: 0x0028630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114AA RID: 70826 RVA: 0x00288118 File Offset: 0x00286318
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
							this.RemainRound = input.ReadInt32();
						}
					}
					else
					{
						this.BuffConfId = input.ReadInt32();
					}
				}
				else
				{
					this.BuffUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006D4C RID: 27980
		private static readonly MessageParser<PhantomBattleDebugBuffInfo> _parser = new MessageParser<PhantomBattleDebugBuffInfo>(() => new PhantomBattleDebugBuffInfo());

		// Token: 0x04006D4D RID: 27981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D4E RID: 27982
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x04006D4F RID: 27983
		private int buffUId_;

		// Token: 0x04006D50 RID: 27984
		public const int BuffConfIdFieldNumber = 2;

		// Token: 0x04006D51 RID: 27985
		private int buffConfId_;

		// Token: 0x04006D52 RID: 27986
		public const int RemainRoundFieldNumber = 3;

		// Token: 0x04006D53 RID: 27987
		private int remainRound_;
	}
}
