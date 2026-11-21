using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001027 RID: 4135
	public sealed class RogueWeeklyGoods : IMessage<RogueWeeklyGoods>, IMessage, IEquatable<RogueWeeklyGoods>, IDeepCloneable<RogueWeeklyGoods>, IBufferMessage
	{
		// Token: 0x06016212 RID: 90642 RVA: 0x00337C47 File Offset: 0x00335E47
		[NullableContext(1)]
		public static RogueWeeklyGoods Create()
		{
			return new RogueWeeklyGoods();
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x06016213 RID: 90643 RVA: 0x00337C4E File Offset: 0x00335E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x06016214 RID: 90644 RVA: 0x00337C51 File Offset: 0x00335E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGoods.Descriptor;
			}
		}

		// Token: 0x06016215 RID: 90645 RVA: 0x00337C58 File Offset: 0x00335E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods()
		{
		}

		// Token: 0x06016216 RID: 90646 RVA: 0x00337C60 File Offset: 0x00335E60
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

		// Token: 0x06016217 RID: 90647 RVA: 0x00337CB4 File Offset: 0x00335EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGoods Clone()
		{
			return new RogueWeeklyGoods(this);
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x06016218 RID: 90648 RVA: 0x00337CBC File Offset: 0x00335EBC
		// (set) Token: 0x06016219 RID: 90649 RVA: 0x00337CC4 File Offset: 0x00335EC4
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

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0601621A RID: 90650 RVA: 0x00337CCD File Offset: 0x00335ECD
		// (set) Token: 0x0601621B RID: 90651 RVA: 0x00337CD5 File Offset: 0x00335ED5
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

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x0601621C RID: 90652 RVA: 0x00337CDE File Offset: 0x00335EDE
		// (set) Token: 0x0601621D RID: 90653 RVA: 0x00337CE6 File Offset: 0x00335EE6
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

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0601621E RID: 90654 RVA: 0x00337CEF File Offset: 0x00335EEF
		// (set) Token: 0x0601621F RID: 90655 RVA: 0x00337CF7 File Offset: 0x00335EF7
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

		// Token: 0x06016220 RID: 90656 RVA: 0x00337D00 File Offset: 0x00335F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGoods);
		}

		// Token: 0x06016221 RID: 90657 RVA: 0x00337D10 File Offset: 0x00335F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGoods other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016222 RID: 90658 RVA: 0x00337D7C File Offset: 0x00335F7C
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

		// Token: 0x06016223 RID: 90659 RVA: 0x00337E06 File Offset: 0x00336006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016224 RID: 90660 RVA: 0x00337E13 File Offset: 0x00336013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016225 RID: 90661 RVA: 0x00337E1C File Offset: 0x0033601C
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

		// Token: 0x06016226 RID: 90662 RVA: 0x00337EAC File Offset: 0x003360AC
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

		// Token: 0x06016227 RID: 90663 RVA: 0x00337F1C File Offset: 0x0033611C
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

		// Token: 0x06016228 RID: 90664 RVA: 0x00337F94 File Offset: 0x00336194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016229 RID: 90665 RVA: 0x00337FA0 File Offset: 0x003361A0
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

		// Token: 0x040084F7 RID: 34039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084F8 RID: 34040
		public const int IsNewFieldNumber = 1;

		// Token: 0x040084F9 RID: 34041
		private bool isNew_;

		// Token: 0x040084FA RID: 34042
		public const int IsSellFieldNumber = 2;

		// Token: 0x040084FB RID: 34043
		private bool isSell_;

		// Token: 0x040084FC RID: 34044
		public const int SourcePriceFieldNumber = 3;

		// Token: 0x040084FD RID: 34045
		private int sourcePrice_;

		// Token: 0x040084FE RID: 34046
		public const int CurPriceFieldNumber = 4;

		// Token: 0x040084FF RID: 34047
		private int curPrice_;
	}
}
