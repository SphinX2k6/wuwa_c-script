using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001390 RID: 5008
	public sealed class TotalTopUpScoreInfo : IMessage<TotalTopUpScoreInfo>, IMessage, IEquatable<TotalTopUpScoreInfo>, IDeepCloneable<TotalTopUpScoreInfo>, IBufferMessage
	{
		// Token: 0x0601A938 RID: 108856 RVA: 0x003DB0E5 File Offset: 0x003D92E5
		[NullableContext(1)]
		public static TotalTopUpScoreInfo Create()
		{
			return new TotalTopUpScoreInfo();
		}

		// Token: 0x1700599B RID: 22939
		// (get) Token: 0x0601A939 RID: 108857 RVA: 0x003DB0EC File Offset: 0x003D92EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TotalTopUpScoreInfo> Parser
		{
			get
			{
				return TotalTopUpScoreInfo._parser;
			}
		}

		// Token: 0x1700599C RID: 22940
		// (get) Token: 0x0601A93A RID: 108858 RVA: 0x003DB0F3 File Offset: 0x003D92F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700599D RID: 22941
		// (get) Token: 0x0601A93B RID: 108859 RVA: 0x003DB0F6 File Offset: 0x003D92F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601A93C RID: 108860 RVA: 0x003DB0FD File Offset: 0x003D92FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo()
		{
		}

		// Token: 0x0601A93D RID: 108861 RVA: 0x003DB108 File Offset: 0x003D9308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo(TotalTopUpScoreInfo other) : this()
		{
			this.id_ = other.id_;
			this.goodsId_ = other.goodsId_;
			this.type_ = other.type_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A93E RID: 108862 RVA: 0x003DB15C File Offset: 0x003D935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo Clone()
		{
			return new TotalTopUpScoreInfo(this);
		}

		// Token: 0x1700599E RID: 22942
		// (get) Token: 0x0601A93F RID: 108863 RVA: 0x003DB164 File Offset: 0x003D9364
		// (set) Token: 0x0601A940 RID: 108864 RVA: 0x003DB16C File Offset: 0x003D936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700599F RID: 22943
		// (get) Token: 0x0601A941 RID: 108865 RVA: 0x003DB175 File Offset: 0x003D9375
		// (set) Token: 0x0601A942 RID: 108866 RVA: 0x003DB17D File Offset: 0x003D937D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x170059A0 RID: 22944
		// (get) Token: 0x0601A943 RID: 108867 RVA: 0x003DB186 File Offset: 0x003D9386
		// (set) Token: 0x0601A944 RID: 108868 RVA: 0x003DB18E File Offset: 0x003D938E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
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

		// Token: 0x170059A1 RID: 22945
		// (get) Token: 0x0601A945 RID: 108869 RVA: 0x003DB197 File Offset: 0x003D9397
		// (set) Token: 0x0601A946 RID: 108870 RVA: 0x003DB19F File Offset: 0x003D939F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601A947 RID: 108871 RVA: 0x003DB1A8 File Offset: 0x003D93A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfo);
		}

		// Token: 0x0601A948 RID: 108872 RVA: 0x003DB1B8 File Offset: 0x003D93B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GoodsId == other.GoodsId && this.Type == other.Type && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A949 RID: 108873 RVA: 0x003DB224 File Offset: 0x003D9424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GoodsId != 0)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A94A RID: 108874 RVA: 0x003DB2AE File Offset: 0x003D94AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A94B RID: 108875 RVA: 0x003DB2BB File Offset: 0x003D94BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A94C RID: 108876 RVA: 0x003DB2C4 File Offset: 0x003D94C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GoodsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GoodsId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A94D RID: 108877 RVA: 0x003DB354 File Offset: 0x003D9554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GoodsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodsId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A94E RID: 108878 RVA: 0x003DB3DC File Offset: 0x003D95DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GoodsId != 0)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A94F RID: 108879 RVA: 0x003DB454 File Offset: 0x003D9654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A950 RID: 108880 RVA: 0x003DB460 File Offset: 0x003D9660
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GoodsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Type = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A7B RID: 39547
		private static readonly MessageParser<TotalTopUpScoreInfo> _parser = new MessageParser<TotalTopUpScoreInfo>(() => new TotalTopUpScoreInfo());

		// Token: 0x04009A7C RID: 39548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A7D RID: 39549
		public const int IdFieldNumber = 1;

		// Token: 0x04009A7E RID: 39550
		private int id_;

		// Token: 0x04009A7F RID: 39551
		public const int GoodsIdFieldNumber = 2;

		// Token: 0x04009A80 RID: 39552
		private int goodsId_;

		// Token: 0x04009A81 RID: 39553
		public const int TypeFieldNumber = 3;

		// Token: 0x04009A82 RID: 39554
		private int type_;

		// Token: 0x04009A83 RID: 39555
		public const int ScoreFieldNumber = 4;

		// Token: 0x04009A84 RID: 39556
		private int score_;
	}
}
