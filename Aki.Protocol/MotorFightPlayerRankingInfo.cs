using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3F RID: 2623
	public sealed class MotorFightPlayerRankingInfo : IMessage<MotorFightPlayerRankingInfo>, IMessage, IEquatable<MotorFightPlayerRankingInfo>, IDeepCloneable<MotorFightPlayerRankingInfo>, IBufferMessage
	{
		// Token: 0x0600E53F RID: 58687 RVA: 0x00218509 File Offset: 0x00216709
		[NullableContext(1)]
		public static MotorFightPlayerRankingInfo Create()
		{
			return new MotorFightPlayerRankingInfo();
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x00218510 File Offset: 0x00216710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightPlayerRankingInfo> Parser
		{
			get
			{
				return MotorFightPlayerRankingInfo._parser;
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600E541 RID: 58689 RVA: 0x00218517 File Offset: 0x00216717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600E542 RID: 58690 RVA: 0x0021851A File Offset: 0x0021671A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerRankingInfo.Descriptor;
			}
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x00218521 File Offset: 0x00216721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo()
		{
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x00218534 File Offset: 0x00216734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo(MotorFightPlayerRankingInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.resultCommon_ = ((other.resultCommon_ != null) ? other.resultCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x0021858C File Offset: 0x0021678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerRankingInfo Clone()
		{
			return new MotorFightPlayerRankingInfo(this);
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600E546 RID: 58694 RVA: 0x00218594 File Offset: 0x00216794
		// (set) Token: 0x0600E547 RID: 58695 RVA: 0x0021859C File Offset: 0x0021679C
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

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0600E548 RID: 58696 RVA: 0x002185A5 File Offset: 0x002167A5
		// (set) Token: 0x0600E549 RID: 58697 RVA: 0x002185AD File Offset: 0x002167AD
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

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600E54A RID: 58698 RVA: 0x002185C0 File Offset: 0x002167C0
		// (set) Token: 0x0600E54B RID: 58699 RVA: 0x002185C8 File Offset: 0x002167C8
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

		// Token: 0x0600E54C RID: 58700 RVA: 0x002185D1 File Offset: 0x002167D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerRankingInfo);
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x002185E0 File Offset: 0x002167E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerRankingInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this.ResultCommon, other.ResultCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x00218644 File Offset: 0x00216844
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

		// Token: 0x0600E54F RID: 58703 RVA: 0x002186B4 File Offset: 0x002168B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x002186C1 File Offset: 0x002168C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x002186CC File Offset: 0x002168CC
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

		// Token: 0x0600E552 RID: 58706 RVA: 0x00218748 File Offset: 0x00216948
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

		// Token: 0x0600E553 RID: 58707 RVA: 0x002187BC File Offset: 0x002169BC
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

		// Token: 0x0600E554 RID: 58708 RVA: 0x0021883D File Offset: 0x00216A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00218848 File Offset: 0x00216A48
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

		// Token: 0x04005E02 RID: 24066
		private static readonly MessageParser<MotorFightPlayerRankingInfo> _parser = new MessageParser<MotorFightPlayerRankingInfo>(() => new MotorFightPlayerRankingInfo());

		// Token: 0x04005E03 RID: 24067
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E04 RID: 24068
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005E05 RID: 24069
		private int playerId_;

		// Token: 0x04005E06 RID: 24070
		public const int NameFieldNumber = 2;

		// Token: 0x04005E07 RID: 24071
		private string name_ = "";

		// Token: 0x04005E08 RID: 24072
		public const int ResultCommonFieldNumber = 3;

		// Token: 0x04005E09 RID: 24073
		private MotorFightResultBase resultCommon_;
	}
}
