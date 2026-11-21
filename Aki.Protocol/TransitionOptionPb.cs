using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146E RID: 5230
	public sealed class TransitionOptionPb : IMessage<TransitionOptionPb>, IMessage, IEquatable<TransitionOptionPb>, IDeepCloneable<TransitionOptionPb>, IBufferMessage
	{
		// Token: 0x0601BC4C RID: 113740 RVA: 0x004086BD File Offset: 0x004068BD
		[NullableContext(1)]
		public static TransitionOptionPb Create()
		{
			return new TransitionOptionPb();
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x0601BC4D RID: 113741 RVA: 0x004086C4 File Offset: 0x004068C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x0601BC4E RID: 113742 RVA: 0x004086C7 File Offset: 0x004068C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionOptionPb.Descriptor;
			}
		}

		// Token: 0x0601BC4F RID: 113743 RVA: 0x004086CE File Offset: 0x004068CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb()
		{
		}

		// Token: 0x0601BC50 RID: 113744 RVA: 0x004086D8 File Offset: 0x004068D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb(TransitionOptionPb other) : this()
		{
			this.transitionType_ = other.transitionType_;
			switch (other.OptionCase)
			{
			case TransitionOptionPb.OptionOneofCase.TransitionMp4:
				this.TransitionMp4 = other.TransitionMp4.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionFlow:
				this.TransitionFlow = other.TransitionFlow.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionInSeamless:
				this.TransitionInSeamless = other.TransitionInSeamless.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.FadeInScreenShowType:
				this.FadeInScreenShowType = other.FadeInScreenShowType;
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay:
				this.TransitionWithCharacterDisplay = other.TransitionWithCharacterDisplay.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading:
				this.TransitionWithCustomLoading = other.TransitionWithCustomLoading.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb:
				this.TransitionWithSpineLoadingPb = other.TransitionWithSpineLoadingPb.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb:
				this.TransitionWithSpecialCustomLoadingPb = other.TransitionWithSpecialCustomLoadingPb.Clone();
				break;
			case TransitionOptionPb.OptionOneofCase.PlayFlowPb:
				this.PlayFlowPb = other.PlayFlowPb.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC51 RID: 113745 RVA: 0x004087E7 File Offset: 0x004069E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb Clone()
		{
			return new TransitionOptionPb(this);
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x0601BC52 RID: 113746 RVA: 0x004087EF File Offset: 0x004069EF
		// (set) Token: 0x0601BC53 RID: 113747 RVA: 0x004087F7 File Offset: 0x004069F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionType TransitionType
		{
			get
			{
				return this.transitionType_;
			}
			set
			{
				this.transitionType_ = value;
			}
		}

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x0601BC54 RID: 113748 RVA: 0x00408800 File Offset: 0x00406A00
		// (set) Token: 0x0601BC55 RID: 113749 RVA: 0x00408818 File Offset: 0x00406A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb TransitionMp4
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionMp4)
				{
					return null;
				}
				return (TransitionMp4Pb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionMp4);
			}
		}

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x0601BC56 RID: 113750 RVA: 0x0040882E File Offset: 0x00406A2E
		// (set) Token: 0x0601BC57 RID: 113751 RVA: 0x00408846 File Offset: 0x00406A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb TransitionFlow
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionFlow)
				{
					return null;
				}
				return (TransitionFlowPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionFlow);
			}
		}

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x0601BC58 RID: 113752 RVA: 0x0040885C File Offset: 0x00406A5C
		// (set) Token: 0x0601BC59 RID: 113753 RVA: 0x00408874 File Offset: 0x00406A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionInSeamlessPb TransitionInSeamless
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionInSeamless)
				{
					return null;
				}
				return (TransitionInSeamlessPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionInSeamless);
			}
		}

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x0601BC5A RID: 113754 RVA: 0x0040888A File Offset: 0x00406A8A
		// (set) Token: 0x0601BC5B RID: 113755 RVA: 0x004088A1 File Offset: 0x00406AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FadeInScreenShowType
		{
			get
			{
				if (!this.HasFadeInScreenShowType)
				{
					return 0;
				}
				return (int)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = TransitionOptionPb.OptionOneofCase.FadeInScreenShowType;
			}
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x0601BC5C RID: 113756 RVA: 0x004088B6 File Offset: 0x00406AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInScreenShowType
		{
			get
			{
				return this.optionCase_ == TransitionOptionPb.OptionOneofCase.FadeInScreenShowType;
			}
		}

		// Token: 0x0601BC5D RID: 113757 RVA: 0x004088C1 File Offset: 0x00406AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInScreenShowType()
		{
			if (this.HasFadeInScreenShowType)
			{
				this.ClearOption();
			}
		}

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x0601BC5E RID: 113758 RVA: 0x004088D1 File Offset: 0x00406AD1
		// (set) Token: 0x0601BC5F RID: 113759 RVA: 0x004088E9 File Offset: 0x00406AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCharacterDisplayPb TransitionWithCharacterDisplay
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay)
				{
					return null;
				}
				return (TransitionWithCharacterDisplayPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay);
			}
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x0601BC60 RID: 113760 RVA: 0x004088FF File Offset: 0x00406AFF
		// (set) Token: 0x0601BC61 RID: 113761 RVA: 0x00408917 File Offset: 0x00406B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithCustomLoadingPb TransitionWithCustomLoading
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading)
				{
					return null;
				}
				return (TransitionWithCustomLoadingPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading);
			}
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x0601BC62 RID: 113762 RVA: 0x0040892D File Offset: 0x00406B2D
		// (set) Token: 0x0601BC63 RID: 113763 RVA: 0x00408945 File Offset: 0x00406B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb TransitionWithSpineLoadingPb
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb)
				{
					return null;
				}
				return (TransitionWithSpineLoadingPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb);
			}
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x0601BC64 RID: 113764 RVA: 0x0040895B File Offset: 0x00406B5B
		// (set) Token: 0x0601BC65 RID: 113765 RVA: 0x00408974 File Offset: 0x00406B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb TransitionWithSpecialCustomLoadingPb
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb)
				{
					return null;
				}
				return (TransitionWithSpecialCustomLoadingPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb);
			}
		}

		// Token: 0x17005E04 RID: 24068
		// (get) Token: 0x0601BC66 RID: 113766 RVA: 0x0040898B File Offset: 0x00406B8B
		// (set) Token: 0x0601BC67 RID: 113767 RVA: 0x004089A4 File Offset: 0x00406BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb PlayFlowPb
		{
			get
			{
				if (this.optionCase_ != TransitionOptionPb.OptionOneofCase.PlayFlowPb)
				{
					return null;
				}
				return (TransitionPlayFlowPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? TransitionOptionPb.OptionOneofCase.None : TransitionOptionPb.OptionOneofCase.PlayFlowPb);
			}
		}

		// Token: 0x17005E05 RID: 24069
		// (get) Token: 0x0601BC68 RID: 113768 RVA: 0x004089BB File Offset: 0x00406BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb.OptionOneofCase OptionCase
		{
			get
			{
				return this.optionCase_;
			}
		}

		// Token: 0x0601BC69 RID: 113769 RVA: 0x004089C3 File Offset: 0x00406BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOption()
		{
			this.optionCase_ = TransitionOptionPb.OptionOneofCase.None;
			this.option_ = null;
		}

		// Token: 0x0601BC6A RID: 113770 RVA: 0x004089D3 File Offset: 0x00406BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionOptionPb);
		}

		// Token: 0x0601BC6B RID: 113771 RVA: 0x004089E4 File Offset: 0x00406BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionOptionPb other)
		{
			return other != null && (other == this || (this.TransitionType == other.TransitionType && object.Equals(this.TransitionMp4, other.TransitionMp4) && object.Equals(this.TransitionFlow, other.TransitionFlow) && object.Equals(this.TransitionInSeamless, other.TransitionInSeamless) && this.FadeInScreenShowType == other.FadeInScreenShowType && object.Equals(this.TransitionWithCharacterDisplay, other.TransitionWithCharacterDisplay) && object.Equals(this.TransitionWithCustomLoading, other.TransitionWithCustomLoading) && object.Equals(this.TransitionWithSpineLoadingPb, other.TransitionWithSpineLoadingPb) && object.Equals(this.TransitionWithSpecialCustomLoadingPb, other.TransitionWithSpecialCustomLoadingPb) && object.Equals(this.PlayFlowPb, other.PlayFlowPb) && this.OptionCase == other.OptionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC6C RID: 113772 RVA: 0x00408AE8 File Offset: 0x00406CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TransitionType != TransitionType.Empty)
			{
				num ^= this.TransitionType.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionMp4)
			{
				num ^= this.TransitionMp4.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionFlow)
			{
				num ^= this.TransitionFlow.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionInSeamless)
			{
				num ^= this.TransitionInSeamless.GetHashCode();
			}
			if (this.HasFadeInScreenShowType)
			{
				num ^= this.FadeInScreenShowType.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay)
			{
				num ^= this.TransitionWithCharacterDisplay.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading)
			{
				num ^= this.TransitionWithCustomLoading.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb)
			{
				num ^= this.TransitionWithSpineLoadingPb.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb)
			{
				num ^= this.TransitionWithSpecialCustomLoadingPb.GetHashCode();
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.PlayFlowPb)
			{
				num ^= this.PlayFlowPb.GetHashCode();
			}
			num ^= (int)this.optionCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC6D RID: 113773 RVA: 0x00408C09 File Offset: 0x00406E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC6E RID: 113774 RVA: 0x00408C16 File Offset: 0x00406E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC6F RID: 113775 RVA: 0x00408C20 File Offset: 0x00406E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TransitionType != TransitionType.Empty)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TransitionType);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionMp4)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TransitionMp4);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionFlow)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TransitionFlow);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionInSeamless)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TransitionInSeamless);
			}
			if (this.HasFadeInScreenShowType)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FadeInScreenShowType);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TransitionWithCharacterDisplay);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TransitionWithCustomLoading);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TransitionWithSpineLoadingPb);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TransitionWithSpecialCustomLoadingPb);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.PlayFlowPb)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayFlowPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC70 RID: 113776 RVA: 0x00408D64 File Offset: 0x00406F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TransitionType != TransitionType.Empty)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TransitionType);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionMp4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionMp4);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionFlow)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionFlow);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionInSeamless)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionInSeamless);
			}
			if (this.HasFadeInScreenShowType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FadeInScreenShowType);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionWithCharacterDisplay);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionWithCustomLoading);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionWithSpineLoadingPb);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionWithSpecialCustomLoadingPb);
			}
			if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.PlayFlowPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayFlowPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC71 RID: 113777 RVA: 0x00408E84 File Offset: 0x00407084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionOptionPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TransitionType != TransitionType.Empty)
			{
				this.TransitionType = other.TransitionType;
			}
			switch (other.OptionCase)
			{
			case TransitionOptionPb.OptionOneofCase.TransitionMp4:
				if (this.TransitionMp4 == null)
				{
					this.TransitionMp4 = new TransitionMp4Pb();
				}
				this.TransitionMp4.MergeFrom(other.TransitionMp4);
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionFlow:
				if (this.TransitionFlow == null)
				{
					this.TransitionFlow = new TransitionFlowPb();
				}
				this.TransitionFlow.MergeFrom(other.TransitionFlow);
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionInSeamless:
				if (this.TransitionInSeamless == null)
				{
					this.TransitionInSeamless = new TransitionInSeamlessPb();
				}
				this.TransitionInSeamless.MergeFrom(other.TransitionInSeamless);
				break;
			case TransitionOptionPb.OptionOneofCase.FadeInScreenShowType:
				this.FadeInScreenShowType = other.FadeInScreenShowType;
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay:
				if (this.TransitionWithCharacterDisplay == null)
				{
					this.TransitionWithCharacterDisplay = new TransitionWithCharacterDisplayPb();
				}
				this.TransitionWithCharacterDisplay.MergeFrom(other.TransitionWithCharacterDisplay);
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading:
				if (this.TransitionWithCustomLoading == null)
				{
					this.TransitionWithCustomLoading = new TransitionWithCustomLoadingPb();
				}
				this.TransitionWithCustomLoading.MergeFrom(other.TransitionWithCustomLoading);
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb:
				if (this.TransitionWithSpineLoadingPb == null)
				{
					this.TransitionWithSpineLoadingPb = new TransitionWithSpineLoadingPb();
				}
				this.TransitionWithSpineLoadingPb.MergeFrom(other.TransitionWithSpineLoadingPb);
				break;
			case TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb:
				if (this.TransitionWithSpecialCustomLoadingPb == null)
				{
					this.TransitionWithSpecialCustomLoadingPb = new TransitionWithSpecialCustomLoadingPb();
				}
				this.TransitionWithSpecialCustomLoadingPb.MergeFrom(other.TransitionWithSpecialCustomLoadingPb);
				break;
			case TransitionOptionPb.OptionOneofCase.PlayFlowPb:
				if (this.PlayFlowPb == null)
				{
					this.PlayFlowPb = new TransitionPlayFlowPb();
				}
				this.PlayFlowPb.MergeFrom(other.PlayFlowPb);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BC72 RID: 113778 RVA: 0x00409043 File Offset: 0x00407243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC73 RID: 113779 RVA: 0x0040904C File Offset: 0x0040724C
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
				if (num <= 40U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.TransitionType = (TransitionType)input.ReadEnum();
							continue;
						}
						if (num == 18U)
						{
							TransitionMp4Pb transitionMp4Pb = new TransitionMp4Pb();
							if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionMp4)
							{
								transitionMp4Pb.MergeFrom(this.TransitionMp4);
							}
							input.ReadMessage(transitionMp4Pb);
							this.TransitionMp4 = transitionMp4Pb;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							TransitionFlowPb transitionFlowPb = new TransitionFlowPb();
							if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionFlow)
							{
								transitionFlowPb.MergeFrom(this.TransitionFlow);
							}
							input.ReadMessage(transitionFlowPb);
							this.TransitionFlow = transitionFlowPb;
							continue;
						}
						if (num == 34U)
						{
							TransitionInSeamlessPb transitionInSeamlessPb = new TransitionInSeamlessPb();
							if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionInSeamless)
							{
								transitionInSeamlessPb.MergeFrom(this.TransitionInSeamless);
							}
							input.ReadMessage(transitionInSeamlessPb);
							this.TransitionInSeamless = transitionInSeamlessPb;
							continue;
						}
						if (num == 40U)
						{
							this.FadeInScreenShowType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						TransitionWithCharacterDisplayPb transitionWithCharacterDisplayPb = new TransitionWithCharacterDisplayPb();
						if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCharacterDisplay)
						{
							transitionWithCharacterDisplayPb.MergeFrom(this.TransitionWithCharacterDisplay);
						}
						input.ReadMessage(transitionWithCharacterDisplayPb);
						this.TransitionWithCharacterDisplay = transitionWithCharacterDisplayPb;
						continue;
					}
					if (num == 58U)
					{
						TransitionWithCustomLoadingPb transitionWithCustomLoadingPb = new TransitionWithCustomLoadingPb();
						if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithCustomLoading)
						{
							transitionWithCustomLoadingPb.MergeFrom(this.TransitionWithCustomLoading);
						}
						input.ReadMessage(transitionWithCustomLoadingPb);
						this.TransitionWithCustomLoading = transitionWithCustomLoadingPb;
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						TransitionWithSpineLoadingPb transitionWithSpineLoadingPb = new TransitionWithSpineLoadingPb();
						if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpineLoadingPb)
						{
							transitionWithSpineLoadingPb.MergeFrom(this.TransitionWithSpineLoadingPb);
						}
						input.ReadMessage(transitionWithSpineLoadingPb);
						this.TransitionWithSpineLoadingPb = transitionWithSpineLoadingPb;
						continue;
					}
					if (num == 74U)
					{
						TransitionWithSpecialCustomLoadingPb transitionWithSpecialCustomLoadingPb = new TransitionWithSpecialCustomLoadingPb();
						if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.TransitionWithSpecialCustomLoadingPb)
						{
							transitionWithSpecialCustomLoadingPb.MergeFrom(this.TransitionWithSpecialCustomLoadingPb);
						}
						input.ReadMessage(transitionWithSpecialCustomLoadingPb);
						this.TransitionWithSpecialCustomLoadingPb = transitionWithSpecialCustomLoadingPb;
						continue;
					}
					if (num == 82U)
					{
						TransitionPlayFlowPb transitionPlayFlowPb = new TransitionPlayFlowPb();
						if (this.optionCase_ == TransitionOptionPb.OptionOneofCase.PlayFlowPb)
						{
							transitionPlayFlowPb.MergeFrom(this.PlayFlowPb);
						}
						input.ReadMessage(transitionPlayFlowPb);
						this.PlayFlowPb = transitionPlayFlowPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A124 RID: 41252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A125 RID: 41253
		public const int TransitionTypeFieldNumber = 1;

		// Token: 0x0400A126 RID: 41254
		private TransitionType transitionType_;

		// Token: 0x0400A127 RID: 41255
		public const int TransitionMp4FieldNumber = 2;

		// Token: 0x0400A128 RID: 41256
		public const int TransitionFlowFieldNumber = 3;

		// Token: 0x0400A129 RID: 41257
		public const int TransitionInSeamlessFieldNumber = 4;

		// Token: 0x0400A12A RID: 41258
		public const int FadeInScreenShowTypeFieldNumber = 5;

		// Token: 0x0400A12B RID: 41259
		public const int TransitionWithCharacterDisplayFieldNumber = 6;

		// Token: 0x0400A12C RID: 41260
		public const int TransitionWithCustomLoadingFieldNumber = 7;

		// Token: 0x0400A12D RID: 41261
		public const int TransitionWithSpineLoadingPbFieldNumber = 8;

		// Token: 0x0400A12E RID: 41262
		public const int TransitionWithSpecialCustomLoadingPbFieldNumber = 9;

		// Token: 0x0400A12F RID: 41263
		public const int PlayFlowPbFieldNumber = 10;

		// Token: 0x0400A130 RID: 41264
		private object option_;

		// Token: 0x0400A131 RID: 41265
		private TransitionOptionPb.OptionOneofCase optionCase_;

		// Token: 0x02001A74 RID: 6772
		public enum OptionOneofCase
		{
			// Token: 0x0400CFF8 RID: 53240
			None,
			// Token: 0x0400CFF9 RID: 53241
			TransitionMp4 = 2,
			// Token: 0x0400CFFA RID: 53242
			TransitionFlow,
			// Token: 0x0400CFFB RID: 53243
			TransitionInSeamless,
			// Token: 0x0400CFFC RID: 53244
			FadeInScreenShowType,
			// Token: 0x0400CFFD RID: 53245
			TransitionWithCharacterDisplay,
			// Token: 0x0400CFFE RID: 53246
			TransitionWithCustomLoading,
			// Token: 0x0400CFFF RID: 53247
			TransitionWithSpineLoadingPb,
			// Token: 0x0400D000 RID: 53248
			TransitionWithSpecialCustomLoadingPb,
			// Token: 0x0400D001 RID: 53249
			PlayFlowPb
		}
	}
}
