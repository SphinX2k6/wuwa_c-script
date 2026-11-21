using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001026 RID: 4134
	public sealed class RogueWeeklyEntry : IMessage<RogueWeeklyEntry>, IMessage, IEquatable<RogueWeeklyEntry>, IDeepCloneable<RogueWeeklyEntry>, IBufferMessage
	{
		// Token: 0x060161F2 RID: 90610 RVA: 0x003375E2 File Offset: 0x003357E2
		[NullableContext(1)]
		public static RogueWeeklyEntry Create()
		{
			return new RogueWeeklyEntry();
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x060161F3 RID: 90611 RVA: 0x003375E9 File Offset: 0x003357E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyEntry> Parser
		{
			get
			{
				return RogueWeeklyEntry._parser;
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x060161F4 RID: 90612 RVA: 0x003375F0 File Offset: 0x003357F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x060161F5 RID: 90613 RVA: 0x003375F3 File Offset: 0x003357F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyEntry.Descriptor;
			}
		}

		// Token: 0x060161F6 RID: 90614 RVA: 0x003375FA File Offset: 0x003357FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry()
		{
		}

		// Token: 0x060161F7 RID: 90615 RVA: 0x00337604 File Offset: 0x00335804
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

		// Token: 0x060161F8 RID: 90616 RVA: 0x0033768D File Offset: 0x0033588D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry Clone()
		{
			return new RogueWeeklyEntry(this);
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x060161F9 RID: 90617 RVA: 0x00337695 File Offset: 0x00335895
		// (set) Token: 0x060161FA RID: 90618 RVA: 0x0033769D File Offset: 0x0033589D
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

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x060161FB RID: 90619 RVA: 0x003376A6 File Offset: 0x003358A6
		// (set) Token: 0x060161FC RID: 90620 RVA: 0x003376AE File Offset: 0x003358AE
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

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x060161FD RID: 90621 RVA: 0x003376B7 File Offset: 0x003358B7
		// (set) Token: 0x060161FE RID: 90622 RVA: 0x003376BF File Offset: 0x003358BF
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

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x060161FF RID: 90623 RVA: 0x003376C8 File Offset: 0x003358C8
		// (set) Token: 0x06016200 RID: 90624 RVA: 0x003376E0 File Offset: 0x003358E0
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

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x06016201 RID: 90625 RVA: 0x003376F6 File Offset: 0x003358F6
		// (set) Token: 0x06016202 RID: 90626 RVA: 0x0033770E File Offset: 0x0033590E
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

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x06016203 RID: 90627 RVA: 0x00337724 File Offset: 0x00335924
		// (set) Token: 0x06016204 RID: 90628 RVA: 0x0033772C File Offset: 0x0033592C
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

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x06016205 RID: 90629 RVA: 0x00337735 File Offset: 0x00335935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntry.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06016206 RID: 90630 RVA: 0x0033773D File Offset: 0x0033593D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = RogueWeeklyEntry.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06016207 RID: 90631 RVA: 0x0033774D File Offset: 0x0033594D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyEntry);
		}

		// Token: 0x06016208 RID: 90632 RVA: 0x0033775C File Offset: 0x0033595C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyEntry other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Type == other.Type && this.ConfigId == other.ConfigId && object.Equals(this.RogueWeeklyBuff, other.RogueWeeklyBuff) && object.Equals(this.RogueWeeklyGoods, other.RogueWeeklyGoods) && this.IsRecommend == other.IsRecommend && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016209 RID: 90633 RVA: 0x00337800 File Offset: 0x00335A00
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

		// Token: 0x0601620A RID: 90634 RVA: 0x003378C7 File Offset: 0x00335AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601620B RID: 90635 RVA: 0x003378D4 File Offset: 0x00335AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601620C RID: 90636 RVA: 0x003378E0 File Offset: 0x00335AE0
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

		// Token: 0x0601620D RID: 90637 RVA: 0x003379B0 File Offset: 0x00335BB0
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

		// Token: 0x0601620E RID: 90638 RVA: 0x00337A5C File Offset: 0x00335C5C
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

		// Token: 0x0601620F RID: 90639 RVA: 0x00337B2F File Offset: 0x00335D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016210 RID: 90640 RVA: 0x00337B38 File Offset: 0x00335D38
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

		// Token: 0x040084E9 RID: 34025
		private static readonly MessageParser<RogueWeeklyEntry> _parser = new MessageParser<RogueWeeklyEntry>(() => new RogueWeeklyEntry());

		// Token: 0x040084EA RID: 34026
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084EB RID: 34027
		public const int IndexFieldNumber = 1;

		// Token: 0x040084EC RID: 34028
		private int index_;

		// Token: 0x040084ED RID: 34029
		public const int TypeFieldNumber = 2;

		// Token: 0x040084EE RID: 34030
		private RogueWeeklyEntryType type_;

		// Token: 0x040084EF RID: 34031
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x040084F0 RID: 34032
		private int configId_;

		// Token: 0x040084F1 RID: 34033
		public const int RogueWeeklyBuffFieldNumber = 4;

		// Token: 0x040084F2 RID: 34034
		public const int RogueWeeklyGoodsFieldNumber = 5;

		// Token: 0x040084F3 RID: 34035
		public const int IsRecommendFieldNumber = 100;

		// Token: 0x040084F4 RID: 34036
		private bool isRecommend_;

		// Token: 0x040084F5 RID: 34037
		private object data_;

		// Token: 0x040084F6 RID: 34038
		private RogueWeeklyEntry.DataOneofCase dataCase_;

		// Token: 0x020019BE RID: 6590
		public enum DataOneofCase
		{
			// Token: 0x0400CED4 RID: 52948
			None,
			// Token: 0x0400CED5 RID: 52949
			RogueWeeklyBuff = 4,
			// Token: 0x0400CED6 RID: 52950
			RogueWeeklyGoods
		}
	}
}
