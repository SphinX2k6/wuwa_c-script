using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FB RID: 5115
	public sealed class TransitionOptionPb : IMessage<TransitionOptionPb>, IMessage, IEquatable<TransitionOptionPb>, IDeepCloneable<TransitionOptionPb>, IBufferMessage
	{
		// Token: 0x0601B1C1 RID: 111041 RVA: 0x003ED3E9 File Offset: 0x003EB5E9
		[NullableContext(1)]
		public static TransitionOptionPb Create()
		{
			return new TransitionOptionPb();
		}

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x0601B1C2 RID: 111042 RVA: 0x003ED3F0 File Offset: 0x003EB5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x0601B1C3 RID: 111043 RVA: 0x003ED3F3 File Offset: 0x003EB5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionOptionPb.Descriptor;
			}
		}

		// Token: 0x0601B1C4 RID: 111044 RVA: 0x003ED3FA File Offset: 0x003EB5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb()
		{
		}

		// Token: 0x0601B1C5 RID: 111045 RVA: 0x003ED404 File Offset: 0x003EB604
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

		// Token: 0x0601B1C6 RID: 111046 RVA: 0x003ED513 File Offset: 0x003EB713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb Clone()
		{
			return new TransitionOptionPb(this);
		}

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x0601B1C7 RID: 111047 RVA: 0x003ED51B File Offset: 0x003EB71B
		// (set) Token: 0x0601B1C8 RID: 111048 RVA: 0x003ED523 File Offset: 0x003EB723
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

		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x0601B1C9 RID: 111049 RVA: 0x003ED52C File Offset: 0x003EB72C
		// (set) Token: 0x0601B1CA RID: 111050 RVA: 0x003ED544 File Offset: 0x003EB744
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

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x0601B1CB RID: 111051 RVA: 0x003ED55A File Offset: 0x003EB75A
		// (set) Token: 0x0601B1CC RID: 111052 RVA: 0x003ED572 File Offset: 0x003EB772
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

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x0601B1CD RID: 111053 RVA: 0x003ED588 File Offset: 0x003EB788
		// (set) Token: 0x0601B1CE RID: 111054 RVA: 0x003ED5A0 File Offset: 0x003EB7A0
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

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x0601B1CF RID: 111055 RVA: 0x003ED5B6 File Offset: 0x003EB7B6
		// (set) Token: 0x0601B1D0 RID: 111056 RVA: 0x003ED5CD File Offset: 0x003EB7CD
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

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x0601B1D1 RID: 111057 RVA: 0x003ED5E2 File Offset: 0x003EB7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInScreenShowType
		{
			get
			{
				return this.optionCase_ == TransitionOptionPb.OptionOneofCase.FadeInScreenShowType;
			}
		}

		// Token: 0x0601B1D2 RID: 111058 RVA: 0x003ED5ED File Offset: 0x003EB7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInScreenShowType()
		{
			if (this.HasFadeInScreenShowType)
			{
				this.ClearOption();
			}
		}

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x0601B1D3 RID: 111059 RVA: 0x003ED5FD File Offset: 0x003EB7FD
		// (set) Token: 0x0601B1D4 RID: 111060 RVA: 0x003ED615 File Offset: 0x003EB815
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

		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x0601B1D5 RID: 111061 RVA: 0x003ED62B File Offset: 0x003EB82B
		// (set) Token: 0x0601B1D6 RID: 111062 RVA: 0x003ED643 File Offset: 0x003EB843
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

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x0601B1D7 RID: 111063 RVA: 0x003ED659 File Offset: 0x003EB859
		// (set) Token: 0x0601B1D8 RID: 111064 RVA: 0x003ED671 File Offset: 0x003EB871
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

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x0601B1D9 RID: 111065 RVA: 0x003ED687 File Offset: 0x003EB887
		// (set) Token: 0x0601B1DA RID: 111066 RVA: 0x003ED6A0 File Offset: 0x003EB8A0
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

		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x0601B1DB RID: 111067 RVA: 0x003ED6B7 File Offset: 0x003EB8B7
		// (set) Token: 0x0601B1DC RID: 111068 RVA: 0x003ED6D0 File Offset: 0x003EB8D0
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

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x0601B1DD RID: 111069 RVA: 0x003ED6E7 File Offset: 0x003EB8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb.OptionOneofCase OptionCase
		{
			get
			{
				return this.optionCase_;
			}
		}

		// Token: 0x0601B1DE RID: 111070 RVA: 0x003ED6EF File Offset: 0x003EB8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOption()
		{
			this.optionCase_ = TransitionOptionPb.OptionOneofCase.None;
			this.option_ = null;
		}

		// Token: 0x0601B1DF RID: 111071 RVA: 0x003ED6FF File Offset: 0x003EB8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionOptionPb);
		}

		// Token: 0x0601B1E0 RID: 111072 RVA: 0x003ED710 File Offset: 0x003EB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionOptionPb other)
		{
			return other != null && (other == this || (this.TransitionType == other.TransitionType && object.Equals(this.TransitionMp4, other.TransitionMp4) && object.Equals(this.TransitionFlow, other.TransitionFlow) && object.Equals(this.TransitionInSeamless, other.TransitionInSeamless) && this.FadeInScreenShowType == other.FadeInScreenShowType && object.Equals(this.TransitionWithCharacterDisplay, other.TransitionWithCharacterDisplay) && object.Equals(this.TransitionWithCustomLoading, other.TransitionWithCustomLoading) && object.Equals(this.TransitionWithSpineLoadingPb, other.TransitionWithSpineLoadingPb) && object.Equals(this.TransitionWithSpecialCustomLoadingPb, other.TransitionWithSpecialCustomLoadingPb) && object.Equals(this.PlayFlowPb, other.PlayFlowPb) && this.OptionCase == other.OptionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1E1 RID: 111073 RVA: 0x003ED814 File Offset: 0x003EBA14
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

		// Token: 0x0601B1E2 RID: 111074 RVA: 0x003ED935 File Offset: 0x003EBB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1E3 RID: 111075 RVA: 0x003ED942 File Offset: 0x003EBB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1E4 RID: 111076 RVA: 0x003ED94C File Offset: 0x003EBB4C
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

		// Token: 0x0601B1E5 RID: 111077 RVA: 0x003EDA90 File Offset: 0x003EBC90
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

		// Token: 0x0601B1E6 RID: 111078 RVA: 0x003EDBB0 File Offset: 0x003EBDB0
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

		// Token: 0x0601B1E7 RID: 111079 RVA: 0x003EDD6F File Offset: 0x003EBF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1E8 RID: 111080 RVA: 0x003EDD78 File Offset: 0x003EBF78
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

		// Token: 0x04009CDD RID: 40157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CDE RID: 40158
		public const int TransitionTypeFieldNumber = 1;

		// Token: 0x04009CDF RID: 40159
		private TransitionType transitionType_;

		// Token: 0x04009CE0 RID: 40160
		public const int TransitionMp4FieldNumber = 2;

		// Token: 0x04009CE1 RID: 40161
		public const int TransitionFlowFieldNumber = 3;

		// Token: 0x04009CE2 RID: 40162
		public const int TransitionInSeamlessFieldNumber = 4;

		// Token: 0x04009CE3 RID: 40163
		public const int FadeInScreenShowTypeFieldNumber = 5;

		// Token: 0x04009CE4 RID: 40164
		public const int TransitionWithCharacterDisplayFieldNumber = 6;

		// Token: 0x04009CE5 RID: 40165
		public const int TransitionWithCustomLoadingFieldNumber = 7;

		// Token: 0x04009CE6 RID: 40166
		public const int TransitionWithSpineLoadingPbFieldNumber = 8;

		// Token: 0x04009CE7 RID: 40167
		public const int TransitionWithSpecialCustomLoadingPbFieldNumber = 9;

		// Token: 0x04009CE8 RID: 40168
		public const int PlayFlowPbFieldNumber = 10;

		// Token: 0x04009CE9 RID: 40169
		private object option_;

		// Token: 0x04009CEA RID: 40170
		private TransitionOptionPb.OptionOneofCase optionCase_;

		// Token: 0x020019D2 RID: 6610
		public enum OptionOneofCase
		{
			// Token: 0x0400CA8D RID: 51853
			None,
			// Token: 0x0400CA8E RID: 51854
			TransitionMp4 = 2,
			// Token: 0x0400CA8F RID: 51855
			TransitionFlow,
			// Token: 0x0400CA90 RID: 51856
			TransitionInSeamless,
			// Token: 0x0400CA91 RID: 51857
			FadeInScreenShowType,
			// Token: 0x0400CA92 RID: 51858
			TransitionWithCharacterDisplay,
			// Token: 0x0400CA93 RID: 51859
			TransitionWithCustomLoading,
			// Token: 0x0400CA94 RID: 51860
			TransitionWithSpineLoadingPb,
			// Token: 0x0400CA95 RID: 51861
			TransitionWithSpecialCustomLoadingPb,
			// Token: 0x0400CA96 RID: 51862
			PlayFlowPb
		}
	}
}
