using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7B RID: 2683
	public sealed class MotorOnlineRankPlayerInfo : IMessage<MotorOnlineRankPlayerInfo>, IMessage, IEquatable<MotorOnlineRankPlayerInfo>, IDeepCloneable<MotorOnlineRankPlayerInfo>, IBufferMessage
	{
		// Token: 0x0600E9D6 RID: 59862 RVA: 0x00222308 File Offset: 0x00220508
		[NullableContext(1)]
		public static MotorOnlineRankPlayerInfo Create()
		{
			return new MotorOnlineRankPlayerInfo();
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x0022230F File Offset: 0x0022050F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOnlineRankPlayerInfo> Parser
		{
			get
			{
				return MotorOnlineRankPlayerInfo._parser;
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600E9D8 RID: 59864 RVA: 0x00222316 File Offset: 0x00220516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x00222319 File Offset: 0x00220519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x00222320 File Offset: 0x00220520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo()
		{
		}

		// Token: 0x0600E9DB RID: 59867 RVA: 0x00222328 File Offset: 0x00220528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo(MotorOnlineRankPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9DC RID: 59868 RVA: 0x00222359 File Offset: 0x00220559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankPlayerInfo Clone()
		{
			return new MotorOnlineRankPlayerInfo(this);
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x00222361 File Offset: 0x00220561
		// (set) Token: 0x0600E9DE RID: 59870 RVA: 0x00222369 File Offset: 0x00220569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x00222372 File Offset: 0x00220572
		// (set) Token: 0x0600E9E0 RID: 59872 RVA: 0x0022237A File Offset: 0x0022057A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x00222383 File Offset: 0x00220583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankPlayerInfo);
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x00222391 File Offset: 0x00220591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.Rank == other.Rank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x002223D0 File Offset: 0x002205D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x00222428 File Offset: 0x00220628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x00222435 File Offset: 0x00220635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x00222440 File Offset: 0x00220640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Rank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x00222498 File Offset: 0x00220698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x002224F0 File Offset: 0x002206F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineRankPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00222540 File Offset: 0x00220740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9EA RID: 59882 RVA: 0x0022254C File Offset: 0x0022074C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Rank = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F06 RID: 24326
		private static readonly MessageParser<MotorOnlineRankPlayerInfo> _parser = new MessageParser<MotorOnlineRankPlayerInfo>(() => new MotorOnlineRankPlayerInfo());

		// Token: 0x04005F07 RID: 24327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F08 RID: 24328
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005F09 RID: 24329
		private int playerId_;

		// Token: 0x04005F0A RID: 24330
		public const int RankFieldNumber = 2;

		// Token: 0x04005F0B RID: 24331
		private int rank_;
	}
}
