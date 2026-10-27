using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B99 RID: 2969
	public sealed class OnlineMotorLevelInfo : IMessage<OnlineMotorLevelInfo>, IMessage, IEquatable<OnlineMotorLevelInfo>, IDeepCloneable<OnlineMotorLevelInfo>, IBufferMessage
	{
		// Token: 0x06010191 RID: 65937 RVA: 0x0025992B File Offset: 0x00257B2B
		[NullableContext(1)]
		public static OnlineMotorLevelInfo Create()
		{
			return new OnlineMotorLevelInfo();
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x06010192 RID: 65938 RVA: 0x00259932 File Offset: 0x00257B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorLevelInfo> Parser
		{
			get
			{
				return OnlineMotorLevelInfo._parser;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x06010193 RID: 65939 RVA: 0x00259939 File Offset: 0x00257B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x06010194 RID: 65940 RVA: 0x0025993C File Offset: 0x00257B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorLevelInfo.Descriptor;
			}
		}

		// Token: 0x06010195 RID: 65941 RVA: 0x00259943 File Offset: 0x00257B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo()
		{
		}

		// Token: 0x06010196 RID: 65942 RVA: 0x0025994B File Offset: 0x00257B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo(OnlineMotorLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.ranking_ = other.ranking_;
			this.timeCost_ = other.timeCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010197 RID: 65943 RVA: 0x00259988 File Offset: 0x00257B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo Clone()
		{
			return new OnlineMotorLevelInfo(this);
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x06010198 RID: 65944 RVA: 0x00259990 File Offset: 0x00257B90
		// (set) Token: 0x06010199 RID: 65945 RVA: 0x00259998 File Offset: 0x00257B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0601019A RID: 65946 RVA: 0x002599A1 File Offset: 0x00257BA1
		// (set) Token: 0x0601019B RID: 65947 RVA: 0x002599A9 File Offset: 0x00257BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ranking
		{
			get
			{
				return this.ranking_;
			}
			set
			{
				this.ranking_ = value;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0601019C RID: 65948 RVA: 0x002599B2 File Offset: 0x00257BB2
		// (set) Token: 0x0601019D RID: 65949 RVA: 0x002599BA File Offset: 0x00257BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeCost
		{
			get
			{
				return this.timeCost_;
			}
			set
			{
				this.timeCost_ = value;
			}
		}

		// Token: 0x0601019E RID: 65950 RVA: 0x002599C3 File Offset: 0x00257BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorLevelInfo);
		}

		// Token: 0x0601019F RID: 65951 RVA: 0x002599D4 File Offset: 0x00257BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Ranking == other.Ranking && this.TimeCost == other.TimeCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101A0 RID: 65952 RVA: 0x00259A30 File Offset: 0x00257C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Ranking != 0)
			{
				num ^= this.Ranking.GetHashCode();
			}
			if (this.TimeCost != 0)
			{
				num ^= this.TimeCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060101A1 RID: 65953 RVA: 0x00259AA1 File Offset: 0x00257CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101A2 RID: 65954 RVA: 0x00259AAE File Offset: 0x00257CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101A3 RID: 65955 RVA: 0x00259AB8 File Offset: 0x00257CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.Ranking != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Ranking);
			}
			if (this.TimeCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TimeCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060101A4 RID: 65956 RVA: 0x00259B2C File Offset: 0x00257D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Ranking != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ranking);
			}
			if (this.TimeCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060101A5 RID: 65957 RVA: 0x00259B9C File Offset: 0x00257D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Ranking != 0)
			{
				this.Ranking = other.Ranking;
			}
			if (other.TimeCost != 0)
			{
				this.TimeCost = other.TimeCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060101A6 RID: 65958 RVA: 0x00259C00 File Offset: 0x00257E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101A7 RID: 65959 RVA: 0x00259C0C File Offset: 0x00257E0C
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
							this.TimeCost = input.ReadInt32();
						}
					}
					else
					{
						this.Ranking = input.ReadInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400669F RID: 26271
		private static readonly MessageParser<OnlineMotorLevelInfo> _parser = new MessageParser<OnlineMotorLevelInfo>(() => new OnlineMotorLevelInfo());

		// Token: 0x040066A0 RID: 26272
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066A1 RID: 26273
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040066A2 RID: 26274
		private int levelId_;

		// Token: 0x040066A3 RID: 26275
		public const int RankingFieldNumber = 2;

		// Token: 0x040066A4 RID: 26276
		private int ranking_;

		// Token: 0x040066A5 RID: 26277
		public const int TimeCostFieldNumber = 3;

		// Token: 0x040066A6 RID: 26278
		private int timeCost_;
	}
}
