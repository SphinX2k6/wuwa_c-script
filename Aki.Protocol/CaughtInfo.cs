using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023B RID: 571
	public sealed class CaughtInfo : IMessage<CaughtInfo>, IMessage, IEquatable<CaughtInfo>, IDeepCloneable<CaughtInfo>, IBufferMessage
	{
		// Token: 0x06003D89 RID: 15753 RVA: 0x00098572 File Offset: 0x00096772
		[NullableContext(1)]
		public static CaughtInfo Create()
		{
			return new CaughtInfo();
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x00098579 File Offset: 0x00096779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x0009857C File Offset: 0x0009677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtInfo.Descriptor;
			}
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00098583 File Offset: 0x00096783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo()
		{
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0009858C File Offset: 0x0009678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo(CaughtInfo other) : this()
		{
			this.attacker_ = other.attacker_;
			this.caughtInfoId_ = other.caughtInfoId_;
			this.isEnd_ = other.isEnd_;
			this.fightState_ = other.fightState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000985E0 File Offset: 0x000967E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Clone()
		{
			return new CaughtInfo(this);
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x000985E8 File Offset: 0x000967E8
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x000985F0 File Offset: 0x000967F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Attacker
		{
			get
			{
				return this.attacker_;
			}
			set
			{
				this.attacker_ = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x000985F9 File Offset: 0x000967F9
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x00098601 File Offset: 0x00096801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CaughtInfoId
		{
			get
			{
				return this.caughtInfoId_;
			}
			set
			{
				this.caughtInfoId_ = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x0009860A File Offset: 0x0009680A
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x00098612 File Offset: 0x00096812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnd
		{
			get
			{
				return this.isEnd_;
			}
			set
			{
				this.isEnd_ = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x0009861B File Offset: 0x0009681B
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00098623 File Offset: 0x00096823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x0009862C File Offset: 0x0009682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtInfo);
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0009863C File Offset: 0x0009683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtInfo other)
		{
			return other != null && (other == this || (this.Attacker == other.Attacker && this.CaughtInfoId == other.CaughtInfoId && this.IsEnd == other.IsEnd && this.FightState == other.FightState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000986A8 File Offset: 0x000968A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Attacker != 0L)
			{
				num ^= this.Attacker.GetHashCode();
			}
			if (this.CaughtInfoId != 0L)
			{
				num ^= this.CaughtInfoId.GetHashCode();
			}
			if (this.IsEnd)
			{
				num ^= this.IsEnd.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00098732 File Offset: 0x00096932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x0009873F File Offset: 0x0009693F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00098748 File Offset: 0x00096948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Attacker != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Attacker);
			}
			if (this.CaughtInfoId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CaughtInfoId);
			}
			if (this.IsEnd)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsEnd);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FightState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000987D8 File Offset: 0x000969D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Attacker != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Attacker);
			}
			if (this.CaughtInfoId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CaughtInfoId);
			}
			if (this.IsEnd)
			{
				num += 2;
			}
			if (this.FightState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00098854 File Offset: 0x00096A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Attacker != 0L)
			{
				this.Attacker = other.Attacker;
			}
			if (other.CaughtInfoId != 0L)
			{
				this.CaughtInfoId = other.CaughtInfoId;
			}
			if (other.IsEnd)
			{
				this.IsEnd = other.IsEnd;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x000988CC File Offset: 0x00096ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000988D8 File Offset: 0x00096AD8
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
						this.Attacker = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.CaughtInfoId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsEnd = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002CB1 RID: 11441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CB2 RID: 11442
		public const int AttackerFieldNumber = 1;

		// Token: 0x04002CB3 RID: 11443
		private long attacker_;

		// Token: 0x04002CB4 RID: 11444
		public const int CaughtInfoIdFieldNumber = 2;

		// Token: 0x04002CB5 RID: 11445
		private long caughtInfoId_;

		// Token: 0x04002CB6 RID: 11446
		public const int IsEndFieldNumber = 3;

		// Token: 0x04002CB7 RID: 11447
		private bool isEnd_;

		// Token: 0x04002CB8 RID: 11448
		public const int FightStateFieldNumber = 4;

		// Token: 0x04002CB9 RID: 11449
		private int fightState_;
	}
}
