using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F92 RID: 3986
	public sealed class RoguelikeLastInfo : IMessage<RoguelikeLastInfo>, IMessage, IEquatable<RoguelikeLastInfo>, IDeepCloneable<RoguelikeLastInfo>, IBufferMessage
	{
		// Token: 0x06015588 RID: 87432 RVA: 0x00319DA2 File Offset: 0x00317FA2
		[NullableContext(1)]
		public static RoguelikeLastInfo Create()
		{
			return new RoguelikeLastInfo();
		}

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x06015589 RID: 87433 RVA: 0x00319DA9 File Offset: 0x00317FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeLastInfo> Parser
		{
			get
			{
				return RoguelikeLastInfo._parser;
			}
		}

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x0601558A RID: 87434 RVA: 0x00319DB0 File Offset: 0x00317FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x0601558B RID: 87435 RVA: 0x00319DB3 File Offset: 0x00317FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeLastInfo.Descriptor;
			}
		}

		// Token: 0x0601558C RID: 87436 RVA: 0x00319DBA File Offset: 0x00317FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfo()
		{
		}

		// Token: 0x0601558D RID: 87437 RVA: 0x00319DC4 File Offset: 0x00317FC4
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

		// Token: 0x0601558E RID: 87438 RVA: 0x00319E18 File Offset: 0x00318018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeLastInfo Clone()
		{
			return new RoguelikeLastInfo(this);
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x0601558F RID: 87439 RVA: 0x00319E20 File Offset: 0x00318020
		// (set) Token: 0x06015590 RID: 87440 RVA: 0x00319E28 File Offset: 0x00318028
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

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x06015591 RID: 87441 RVA: 0x00319E31 File Offset: 0x00318031
		// (set) Token: 0x06015592 RID: 87442 RVA: 0x00319E39 File Offset: 0x00318039
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

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x06015593 RID: 87443 RVA: 0x00319E42 File Offset: 0x00318042
		// (set) Token: 0x06015594 RID: 87444 RVA: 0x00319E4A File Offset: 0x0031804A
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

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x06015595 RID: 87445 RVA: 0x00319E53 File Offset: 0x00318053
		// (set) Token: 0x06015596 RID: 87446 RVA: 0x00319E5B File Offset: 0x0031805B
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

		// Token: 0x06015597 RID: 87447 RVA: 0x00319E64 File Offset: 0x00318064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeLastInfo);
		}

		// Token: 0x06015598 RID: 87448 RVA: 0x00319E74 File Offset: 0x00318074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeLastInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.ModeType == other.ModeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015599 RID: 87449 RVA: 0x00319EE0 File Offset: 0x003180E0
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

		// Token: 0x0601559A RID: 87450 RVA: 0x00319F70 File Offset: 0x00318170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x00319F7D File Offset: 0x0031817D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601559C RID: 87452 RVA: 0x00319F88 File Offset: 0x00318188
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

		// Token: 0x0601559D RID: 87453 RVA: 0x0031A01C File Offset: 0x0031821C
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

		// Token: 0x0601559E RID: 87454 RVA: 0x0031A0A4 File Offset: 0x003182A4
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

		// Token: 0x0601559F RID: 87455 RVA: 0x0031A11C File Offset: 0x0031831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155A0 RID: 87456 RVA: 0x0031A128 File Offset: 0x00318328
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

		// Token: 0x040080EE RID: 33006
		private static readonly MessageParser<RoguelikeLastInfo> _parser = new MessageParser<RoguelikeLastInfo>(() => new RoguelikeLastInfo());

		// Token: 0x040080EF RID: 33007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080F0 RID: 33008
		public const int InstIdFieldNumber = 2;

		// Token: 0x040080F1 RID: 33009
		private int instId_;

		// Token: 0x040080F2 RID: 33010
		public const int CurLayerFieldNumber = 3;

		// Token: 0x040080F3 RID: 33011
		private int curLayer_;

		// Token: 0x040080F4 RID: 33012
		public const int MaxLayerFieldNumber = 4;

		// Token: 0x040080F5 RID: 33013
		private int maxLayer_;

		// Token: 0x040080F6 RID: 33014
		public const int ModeTypeFieldNumber = 5;

		// Token: 0x040080F7 RID: 33015
		private RogueChallengeModeType modeType_;
	}
}
