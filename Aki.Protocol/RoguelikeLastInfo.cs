using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA2 RID: 4002
	public sealed class RoguelikeLastInfo : IMessage<RoguelikeLastInfo>, IMessage, IEquatable<RoguelikeLastInfo>, IDeepCloneable<RoguelikeLastInfo>, IBufferMessage
	{
		// Token: 0x0601566D RID: 87661 RVA: 0x0031B44E File Offset: 0x0031964E
		[NullableContext(1)]
		public static RoguelikeLastInfo Create()
		{
			return new RoguelikeLastInfo();
		}

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x0601566E RID: 87662 RVA: 0x0031B455 File Offset: 0x00319655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeLastInfo> Parser
		{
			get
			{
				return RoguelikeLastInfo._parser;
			}
		}

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x0601566F RID: 87663 RVA: 0x0031B45C File Offset: 0x0031965C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x06015670 RID: 87664 RVA: 0x0031B45F File Offset: 0x0031965F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfo.Descriptor;
			}
		}

		// Token: 0x06015671 RID: 87665 RVA: 0x0031B466 File Offset: 0x00319666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfo()
		{
		}

		// Token: 0x06015672 RID: 87666 RVA: 0x0031B470 File Offset: 0x00319670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfo(RoguelikeLastInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.modeType_ = other.modeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015673 RID: 87667 RVA: 0x0031B4C4 File Offset: 0x003196C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfo Clone()
		{
			return new RoguelikeLastInfo(this);
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x06015674 RID: 87668 RVA: 0x0031B4CC File Offset: 0x003196CC
		// (set) Token: 0x06015675 RID: 87669 RVA: 0x0031B4D4 File Offset: 0x003196D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x06015676 RID: 87670 RVA: 0x0031B4DD File Offset: 0x003196DD
		// (set) Token: 0x06015677 RID: 87671 RVA: 0x0031B4E5 File Offset: 0x003196E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x06015678 RID: 87672 RVA: 0x0031B4EE File Offset: 0x003196EE
		// (set) Token: 0x06015679 RID: 87673 RVA: 0x0031B4F6 File Offset: 0x003196F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x0601567A RID: 87674 RVA: 0x0031B4FF File Offset: 0x003196FF
		// (set) Token: 0x0601567B RID: 87675 RVA: 0x0031B507 File Offset: 0x00319707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueChallengeModeType ModeType
		{
			get
			{
				return this.modeType_;
			}
			set
			{
				this.modeType_ = value;
			}
		}

		// Token: 0x0601567C RID: 87676 RVA: 0x0031B510 File Offset: 0x00319710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfo);
		}

		// Token: 0x0601567D RID: 87677 RVA: 0x0031B520 File Offset: 0x00319720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.ModeType == other.ModeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601567E RID: 87678 RVA: 0x0031B58C File Offset: 0x0031978C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.ModeType != RogueChallengeModeType.None)
			{
				num ^= this.ModeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601567F RID: 87679 RVA: 0x0031B61C File Offset: 0x0031981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015680 RID: 87680 RVA: 0x0031B629 File Offset: 0x00319829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015681 RID: 87681 RVA: 0x0031B634 File Offset: 0x00319834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.ModeType != RogueChallengeModeType.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ModeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015682 RID: 87682 RVA: 0x0031B6C8 File Offset: 0x003198C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.ModeType != RogueChallengeModeType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015683 RID: 87683 RVA: 0x0031B750 File Offset: 0x00319950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeLastInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.ModeType != RogueChallengeModeType.None)
			{
				this.ModeType = other.ModeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015684 RID: 87684 RVA: 0x0031B7C8 File Offset: 0x003199C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015685 RID: 87685 RVA: 0x0031B7D4 File Offset: 0x003199D4
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
					if (num == 16U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.ModeType = (RogueChallengeModeType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080C4 RID: 32964
		private static readonly MessageParser<RoguelikeLastInfo> _parser = new MessageParser<RoguelikeLastInfo>(() => new RoguelikeLastInfo());

		// Token: 0x040080C5 RID: 32965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080C6 RID: 32966
		public const int InstIdFieldNumber = 2;

		// Token: 0x040080C7 RID: 32967
		private int instId_;

		// Token: 0x040080C8 RID: 32968
		public const int CurLayerFieldNumber = 3;

		// Token: 0x040080C9 RID: 32969
		private int curLayer_;

		// Token: 0x040080CA RID: 32970
		public const int MaxLayerFieldNumber = 4;

		// Token: 0x040080CB RID: 32971
		private int maxLayer_;

		// Token: 0x040080CC RID: 32972
		public const int ModeTypeFieldNumber = 5;

		// Token: 0x040080CD RID: 32973
		private RogueChallengeModeType modeType_;
	}
}
