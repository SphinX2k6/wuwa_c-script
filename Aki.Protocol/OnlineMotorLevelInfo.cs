using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B89 RID: 2953
	public sealed class OnlineMotorLevelInfo : IMessage<OnlineMotorLevelInfo>, IMessage, IEquatable<OnlineMotorLevelInfo>, IDeepCloneable<OnlineMotorLevelInfo>, IBufferMessage
	{
		// Token: 0x0601008D RID: 65677 RVA: 0x00257A5F File Offset: 0x00255C5F
		[NullableContext(1)]
		public static OnlineMotorLevelInfo Create()
		{
			return new OnlineMotorLevelInfo();
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0601008E RID: 65678 RVA: 0x00257A66 File Offset: 0x00255C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorLevelInfo> Parser
		{
			get
			{
				return OnlineMotorLevelInfo._parser;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0601008F RID: 65679 RVA: 0x00257A6D File Offset: 0x00255C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x06010090 RID: 65680 RVA: 0x00257A70 File Offset: 0x00255C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorLevelInfo.Descriptor;
			}
		}

		// Token: 0x06010091 RID: 65681 RVA: 0x00257A77 File Offset: 0x00255C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo()
		{
		}

		// Token: 0x06010092 RID: 65682 RVA: 0x00257A7F File Offset: 0x00255C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo(OnlineMotorLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.ranking_ = other.ranking_;
			this.timeCost_ = other.timeCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010093 RID: 65683 RVA: 0x00257ABC File Offset: 0x00255CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo Clone()
		{
			return new OnlineMotorLevelInfo(this);
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x06010094 RID: 65684 RVA: 0x00257AC4 File Offset: 0x00255CC4
		// (set) Token: 0x06010095 RID: 65685 RVA: 0x00257ACC File Offset: 0x00255CCC
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

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x06010096 RID: 65686 RVA: 0x00257AD5 File Offset: 0x00255CD5
		// (set) Token: 0x06010097 RID: 65687 RVA: 0x00257ADD File Offset: 0x00255CDD
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

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x06010098 RID: 65688 RVA: 0x00257AE6 File Offset: 0x00255CE6
		// (set) Token: 0x06010099 RID: 65689 RVA: 0x00257AEE File Offset: 0x00255CEE
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

		// Token: 0x0601009A RID: 65690 RVA: 0x00257AF7 File Offset: 0x00255CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorLevelInfo);
		}

		// Token: 0x0601009B RID: 65691 RVA: 0x00257B08 File Offset: 0x00255D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Ranking == other.Ranking && this.TimeCost == other.TimeCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601009C RID: 65692 RVA: 0x00257B64 File Offset: 0x00255D64
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

		// Token: 0x0601009D RID: 65693 RVA: 0x00257BD5 File Offset: 0x00255DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601009E RID: 65694 RVA: 0x00257BE2 File Offset: 0x00255DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601009F RID: 65695 RVA: 0x00257BEC File Offset: 0x00255DEC
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

		// Token: 0x060100A0 RID: 65696 RVA: 0x00257C60 File Offset: 0x00255E60
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

		// Token: 0x060100A1 RID: 65697 RVA: 0x00257CD0 File Offset: 0x00255ED0
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

		// Token: 0x060100A2 RID: 65698 RVA: 0x00257D34 File Offset: 0x00255F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100A3 RID: 65699 RVA: 0x00257D40 File Offset: 0x00255F40
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

		// Token: 0x040066AF RID: 26287
		private static readonly MessageParser<OnlineMotorLevelInfo> _parser = new MessageParser<OnlineMotorLevelInfo>(() => new OnlineMotorLevelInfo());

		// Token: 0x040066B0 RID: 26288
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066B1 RID: 26289
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040066B2 RID: 26290
		private int levelId_;

		// Token: 0x040066B3 RID: 26291
		public const int RankingFieldNumber = 2;

		// Token: 0x040066B4 RID: 26292
		private int ranking_;

		// Token: 0x040066B5 RID: 26293
		public const int TimeCostFieldNumber = 3;

		// Token: 0x040066B6 RID: 26294
		private int timeCost_;
	}
}
