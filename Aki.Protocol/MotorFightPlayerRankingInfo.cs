using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A50 RID: 2640
	public sealed class MotorFightPlayerRankingInfo : IMessage<MotorFightPlayerRankingInfo>, IMessage, IEquatable<MotorFightPlayerRankingInfo>, IDeepCloneable<MotorFightPlayerRankingInfo>, IBufferMessage
	{
		// Token: 0x0600E659 RID: 58969 RVA: 0x0021A6FD File Offset: 0x002188FD
		[NullableContext(1)]
		public static MotorFightPlayerRankingInfo Create()
		{
			return new MotorFightPlayerRankingInfo();
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0021A704 File Offset: 0x00218904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightPlayerRankingInfo> Parser
		{
			get
			{
				return MotorFightPlayerRankingInfo._parser;
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600E65B RID: 58971 RVA: 0x0021A70B File Offset: 0x0021890B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600E65C RID: 58972 RVA: 0x0021A70E File Offset: 0x0021890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerRankingInfo.Descriptor;
			}
		}

		// Token: 0x0600E65D RID: 58973 RVA: 0x0021A715 File Offset: 0x00218915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo()
		{
		}

		// Token: 0x0600E65E RID: 58974 RVA: 0x0021A728 File Offset: 0x00218928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo(MotorFightPlayerRankingInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.resultCommon_ = ((other.resultCommon_ != null) ? other.resultCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E65F RID: 58975 RVA: 0x0021A780 File Offset: 0x00218980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo Clone()
		{
			return new MotorFightPlayerRankingInfo(this);
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600E660 RID: 58976 RVA: 0x0021A788 File Offset: 0x00218988
		// (set) Token: 0x0600E661 RID: 58977 RVA: 0x0021A790 File Offset: 0x00218990
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

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600E662 RID: 58978 RVA: 0x0021A799 File Offset: 0x00218999
		// (set) Token: 0x0600E663 RID: 58979 RVA: 0x0021A7A1 File Offset: 0x002189A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600E664 RID: 58980 RVA: 0x0021A7B4 File Offset: 0x002189B4
		// (set) Token: 0x0600E665 RID: 58981 RVA: 0x0021A7BC File Offset: 0x002189BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase ResultCommon
		{
			get
			{
				return this.resultCommon_;
			}
			set
			{
				this.resultCommon_ = value;
			}
		}

		// Token: 0x0600E666 RID: 58982 RVA: 0x0021A7C5 File Offset: 0x002189C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerRankingInfo);
		}

		// Token: 0x0600E667 RID: 58983 RVA: 0x0021A7D4 File Offset: 0x002189D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerRankingInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this.ResultCommon, other.ResultCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E668 RID: 58984 RVA: 0x0021A838 File Offset: 0x00218A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.resultCommon_ != null)
			{
				num ^= this.ResultCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E669 RID: 58985 RVA: 0x0021A8A8 File Offset: 0x00218AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x0021A8B5 File Offset: 0x00218AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x0021A8C0 File Offset: 0x00218AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.resultCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ResultCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x0021A93C File Offset: 0x00218B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.resultCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E66D RID: 58989 RVA: 0x0021A9B0 File Offset: 0x00218BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightPlayerRankingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.resultCommon_ != null)
			{
				if (this.resultCommon_ == null)
				{
					this.ResultCommon = new MotorFightResultBase();
				}
				this.ResultCommon.MergeFrom(other.ResultCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x0021AA31 File Offset: 0x00218C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x0021AA3C File Offset: 0x00218C3C
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.resultCommon_ == null)
							{
								this.ResultCommon = new MotorFightResultBase();
							}
							input.ReadMessage(this.ResultCommon);
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DF9 RID: 24057
		private static readonly MessageParser<MotorFightPlayerRankingInfo> _parser = new MessageParser<MotorFightPlayerRankingInfo>(() => new MotorFightPlayerRankingInfo());

		// Token: 0x04005DFA RID: 24058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DFB RID: 24059
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005DFC RID: 24060
		private int playerId_;

		// Token: 0x04005DFD RID: 24061
		public const int NameFieldNumber = 2;

		// Token: 0x04005DFE RID: 24062
		private string name_ = "";

		// Token: 0x04005DFF RID: 24063
		public const int ResultCommonFieldNumber = 3;

		// Token: 0x04005E00 RID: 24064
		private MotorFightResultBase resultCommon_;
	}
}
