using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001037 RID: 4151
	public sealed class RogueWeeklyGoods : IMessage<RogueWeeklyGoods>, IMessage, IEquatable<RogueWeeklyGoods>, IDeepCloneable<RogueWeeklyGoods>, IBufferMessage
	{
		// Token: 0x060162F7 RID: 90871 RVA: 0x0033930B File Offset: 0x0033750B
		[NullableContext(1)]
		public static RogueWeeklyGoods Create()
		{
			return new RogueWeeklyGoods();
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x060162F8 RID: 90872 RVA: 0x00339312 File Offset: 0x00337512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x060162F9 RID: 90873 RVA: 0x00339315 File Offset: 0x00337515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGoods.Descriptor;
			}
		}

		// Token: 0x060162FA RID: 90874 RVA: 0x0033931C File Offset: 0x0033751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods()
		{
		}

		// Token: 0x060162FB RID: 90875 RVA: 0x00339324 File Offset: 0x00337524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods(RogueWeeklyGoods other) : this()
		{
			this.isNew_ = other.isNew_;
			this.isSell_ = other.isSell_;
			this.sourcePrice_ = other.sourcePrice_;
			this.curPrice_ = other.curPrice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162FC RID: 90876 RVA: 0x00339378 File Offset: 0x00337578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods Clone()
		{
			return new RogueWeeklyGoods(this);
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x060162FD RID: 90877 RVA: 0x00339380 File Offset: 0x00337580
		// (set) Token: 0x060162FE RID: 90878 RVA: 0x00339388 File Offset: 0x00337588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x060162FF RID: 90879 RVA: 0x00339391 File Offset: 0x00337591
		// (set) Token: 0x06016300 RID: 90880 RVA: 0x00339399 File Offset: 0x00337599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSell
		{
			get
			{
				return this.isSell_;
			}
			set
			{
				this.isSell_ = value;
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x06016301 RID: 90881 RVA: 0x003393A2 File Offset: 0x003375A2
		// (set) Token: 0x06016302 RID: 90882 RVA: 0x003393AA File Offset: 0x003375AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourcePrice
		{
			get
			{
				return this.sourcePrice_;
			}
			set
			{
				this.sourcePrice_ = value;
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x06016303 RID: 90883 RVA: 0x003393B3 File Offset: 0x003375B3
		// (set) Token: 0x06016304 RID: 90884 RVA: 0x003393BB File Offset: 0x003375BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPrice
		{
			get
			{
				return this.curPrice_;
			}
			set
			{
				this.curPrice_ = value;
			}
		}

		// Token: 0x06016305 RID: 90885 RVA: 0x003393C4 File Offset: 0x003375C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGoods);
		}

		// Token: 0x06016306 RID: 90886 RVA: 0x003393D4 File Offset: 0x003375D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGoods other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016307 RID: 90887 RVA: 0x00339440 File Offset: 0x00337640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.IsSell)
			{
				num ^= this.IsSell.GetHashCode();
			}
			if (this.SourcePrice != 0)
			{
				num ^= this.SourcePrice.GetHashCode();
			}
			if (this.CurPrice != 0)
			{
				num ^= this.CurPrice.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016308 RID: 90888 RVA: 0x003394CA File Offset: 0x003376CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016309 RID: 90889 RVA: 0x003394D7 File Offset: 0x003376D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601630A RID: 90890 RVA: 0x003394E0 File Offset: 0x003376E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this.IsSell)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSell);
			}
			if (this.SourcePrice != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurPrice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601630B RID: 90891 RVA: 0x00339570 File Offset: 0x00337770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.IsSell)
			{
				num += 2;
			}
			if (this.SourcePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPrice);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601630C RID: 90892 RVA: 0x003395E0 File Offset: 0x003377E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyGoods other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.IsSell)
			{
				this.IsSell = other.IsSell;
			}
			if (other.SourcePrice != 0)
			{
				this.SourcePrice = other.SourcePrice;
			}
			if (other.CurPrice != 0)
			{
				this.CurPrice = other.CurPrice;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601630D RID: 90893 RVA: 0x00339658 File Offset: 0x00337858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601630E RID: 90894 RVA: 0x00339664 File Offset: 0x00337864
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
						this.IsNew = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.IsSell = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SourcePrice = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CurPrice = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040084CD RID: 33997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084CE RID: 33998
		public const int IsNewFieldNumber = 1;

		// Token: 0x040084CF RID: 33999
		private bool isNew_;

		// Token: 0x040084D0 RID: 34000
		public const int IsSellFieldNumber = 2;

		// Token: 0x040084D1 RID: 34001
		private bool isSell_;

		// Token: 0x040084D2 RID: 34002
		public const int SourcePriceFieldNumber = 3;

		// Token: 0x040084D3 RID: 34003
		private int sourcePrice_;

		// Token: 0x040084D4 RID: 34004
		public const int CurPriceFieldNumber = 4;

		// Token: 0x040084D5 RID: 34005
		private int curPrice_;
	}
}
