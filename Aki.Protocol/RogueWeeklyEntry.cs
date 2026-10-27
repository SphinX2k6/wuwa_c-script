using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001036 RID: 4150
	public sealed class RogueWeeklyEntry : IMessage<RogueWeeklyEntry>, IMessage, IEquatable<RogueWeeklyEntry>, IDeepCloneable<RogueWeeklyEntry>, IBufferMessage
	{
		// Token: 0x060162D7 RID: 90839 RVA: 0x00338CA6 File Offset: 0x00336EA6
		[NullableContext(1)]
		public static RogueWeeklyEntry Create()
		{
			return new RogueWeeklyEntry();
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x060162D8 RID: 90840 RVA: 0x00338CAD File Offset: 0x00336EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyEntry> Parser
		{
			get
			{
				return RogueWeeklyEntry._parser;
			}
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x060162D9 RID: 90841 RVA: 0x00338CB4 File Offset: 0x00336EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x060162DA RID: 90842 RVA: 0x00338CB7 File Offset: 0x00336EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyEntry.Descriptor;
			}
		}

		// Token: 0x060162DB RID: 90843 RVA: 0x00338CBE File Offset: 0x00336EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry()
		{
		}

		// Token: 0x060162DC RID: 90844 RVA: 0x00338CC8 File Offset: 0x00336EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry(RogueWeeklyEntry other) : this()
		{
			this.index_ = other.index_;
			this.type_ = other.type_;
			this.configId_ = other.configId_;
			this.isRecommend_ = other.isRecommend_;
			RogueWeeklyEntry.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
			{
				if (dataCase == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
				{
					this.RogueWeeklyGoods = other.RogueWeeklyGoods.Clone();
				}
			}
			else
			{
				this.RogueWeeklyBuff = other.RogueWeeklyBuff.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162DD RID: 90845 RVA: 0x00338D51 File Offset: 0x00336F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry Clone()
		{
			return new RogueWeeklyEntry(this);
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x060162DE RID: 90846 RVA: 0x00338D59 File Offset: 0x00336F59
		// (set) Token: 0x060162DF RID: 90847 RVA: 0x00338D61 File Offset: 0x00336F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x060162E0 RID: 90848 RVA: 0x00338D6A File Offset: 0x00336F6A
		// (set) Token: 0x060162E1 RID: 90849 RVA: 0x00338D72 File Offset: 0x00336F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntryType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x060162E2 RID: 90850 RVA: 0x00338D7B File Offset: 0x00336F7B
		// (set) Token: 0x060162E3 RID: 90851 RVA: 0x00338D83 File Offset: 0x00336F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x060162E4 RID: 90852 RVA: 0x00338D8C File Offset: 0x00336F8C
		// (set) Token: 0x060162E5 RID: 90853 RVA: 0x00338DA4 File Offset: 0x00336FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff RogueWeeklyBuff
		{
			get
			{
				if (this.dataCase_ != RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
				{
					return null;
				}
				return (RogueWeeklyBuff)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueWeeklyEntry.DataOneofCase.None : RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff);
			}
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x060162E6 RID: 90854 RVA: 0x00338DBA File Offset: 0x00336FBA
		// (set) Token: 0x060162E7 RID: 90855 RVA: 0x00338DD2 File Offset: 0x00336FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods RogueWeeklyGoods
		{
			get
			{
				if (this.dataCase_ != RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
				{
					return null;
				}
				return (RogueWeeklyGoods)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? RogueWeeklyEntry.DataOneofCase.None : RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods);
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x060162E8 RID: 90856 RVA: 0x00338DE8 File Offset: 0x00336FE8
		// (set) Token: 0x060162E9 RID: 90857 RVA: 0x00338DF0 File Offset: 0x00336FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRecommend
		{
			get
			{
				return this.isRecommend_;
			}
			set
			{
				this.isRecommend_ = value;
			}
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x060162EA RID: 90858 RVA: 0x00338DF9 File Offset: 0x00336FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060162EB RID: 90859 RVA: 0x00338E01 File Offset: 0x00337001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueWeeklyEntry.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060162EC RID: 90860 RVA: 0x00338E11 File Offset: 0x00337011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyEntry);
		}

		// Token: 0x060162ED RID: 90861 RVA: 0x00338E20 File Offset: 0x00337020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyEntry other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Type == other.Type && this.ConfigId == other.ConfigId && object.Equals(this.RogueWeeklyBuff, other.RogueWeeklyBuff) && object.Equals(this.RogueWeeklyGoods, other.RogueWeeklyGoods) && this.IsRecommend == other.IsRecommend && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162EE RID: 90862 RVA: 0x00338EC4 File Offset: 0x003370C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
			{
				num ^= this.RogueWeeklyBuff.GetHashCode();
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
			{
				num ^= this.RogueWeeklyGoods.GetHashCode();
			}
			if (this.IsRecommend)
			{
				num ^= this.IsRecommend.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060162EF RID: 90863 RVA: 0x00338F8B File Offset: 0x0033718B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162F0 RID: 90864 RVA: 0x00338F98 File Offset: 0x00337198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162F1 RID: 90865 RVA: 0x00338FA4 File Offset: 0x003371A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueWeeklyBuff);
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueWeeklyGoods);
			}
			if (this.IsRecommend)
			{
				output.WriteRawTag(160, 6);
				output.WriteBool(this.IsRecommend);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162F2 RID: 90866 RVA: 0x00339074 File Offset: 0x00337274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyBuff);
			}
			if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyGoods);
			}
			if (this.IsRecommend)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162F3 RID: 90867 RVA: 0x00339120 File Offset: 0x00337320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Type != RogueWeeklyEntryType.Unknow)
			{
				this.Type = other.Type;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsRecommend)
			{
				this.IsRecommend = other.IsRecommend;
			}
			RogueWeeklyEntry.DataOneofCase dataCase = other.DataCase;
			if (dataCase != RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
			{
				if (dataCase == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
				{
					if (this.RogueWeeklyGoods == null)
					{
						this.RogueWeeklyGoods = new RogueWeeklyGoods();
					}
					this.RogueWeeklyGoods.MergeFrom(other.RogueWeeklyGoods);
				}
			}
			else
			{
				if (this.RogueWeeklyBuff == null)
				{
					this.RogueWeeklyBuff = new RogueWeeklyBuff();
				}
				this.RogueWeeklyBuff.MergeFrom(other.RogueWeeklyBuff);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060162F4 RID: 90868 RVA: 0x003391F3 File Offset: 0x003373F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162F5 RID: 90869 RVA: 0x003391FC File Offset: 0x003373FC
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (RogueWeeklyEntryType)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						RogueWeeklyBuff rogueWeeklyBuff = new RogueWeeklyBuff();
						if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyBuff)
						{
							rogueWeeklyBuff.MergeFrom(this.RogueWeeklyBuff);
						}
						input.ReadMessage(rogueWeeklyBuff);
						this.RogueWeeklyBuff = rogueWeeklyBuff;
						continue;
					}
					if (num == 42U)
					{
						RogueWeeklyGoods rogueWeeklyGoods = new RogueWeeklyGoods();
						if (this.dataCase_ == RogueWeeklyEntry.DataOneofCase.RogueWeeklyGoods)
						{
							rogueWeeklyGoods.MergeFrom(this.RogueWeeklyGoods);
						}
						input.ReadMessage(rogueWeeklyGoods);
						this.RogueWeeklyGoods = rogueWeeklyGoods;
						continue;
					}
					if (num == 800U)
					{
						this.IsRecommend = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040084BF RID: 33983
		private static readonly MessageParser<RogueWeeklyEntry> _parser = new MessageParser<RogueWeeklyEntry>(() => new RogueWeeklyEntry());

		// Token: 0x040084C0 RID: 33984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084C1 RID: 33985
		public const int IndexFieldNumber = 1;

		// Token: 0x040084C2 RID: 33986
		private int index_;

		// Token: 0x040084C3 RID: 33987
		public const int TypeFieldNumber = 2;

		// Token: 0x040084C4 RID: 33988
		private RogueWeeklyEntryType type_;

		// Token: 0x040084C5 RID: 33989
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x040084C6 RID: 33990
		private int configId_;

		// Token: 0x040084C7 RID: 33991
		public const int RogueWeeklyBuffFieldNumber = 4;

		// Token: 0x040084C8 RID: 33992
		public const int RogueWeeklyGoodsFieldNumber = 5;

		// Token: 0x040084C9 RID: 33993
		public const int IsRecommendFieldNumber = 100;

		// Token: 0x040084CA RID: 33994
		private bool isRecommend_;

		// Token: 0x040084CB RID: 33995
		private object data_;

		// Token: 0x040084CC RID: 33996
		private RogueWeeklyEntry.DataOneofCase dataCase_;

		// Token: 0x02001946 RID: 6470
		public enum DataOneofCase
		{
			// Token: 0x0400C9A9 RID: 51625
			None,
			// Token: 0x0400C9AA RID: 51626
			RogueWeeklyBuff = 4,
			// Token: 0x0400C9AB RID: 51627
			RogueWeeklyGoods
		}
	}
}
