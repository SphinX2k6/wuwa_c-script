using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001474 RID: 5236
	public sealed class TransitionWithSpineLoadingPb : IMessage<TransitionWithSpineLoadingPb>, IMessage, IEquatable<TransitionWithSpineLoadingPb>, IDeepCloneable<TransitionWithSpineLoadingPb>, IBufferMessage
	{
		// Token: 0x0601BCDA RID: 113882 RVA: 0x0040A11A File Offset: 0x0040831A
		[NullableContext(1)]
		public static TransitionWithSpineLoadingPb Create()
		{
			return new TransitionWithSpineLoadingPb();
		}

		// Token: 0x17005E1B RID: 24091
		// (get) Token: 0x0601BCDB RID: 113883 RVA: 0x0040A121 File Offset: 0x00408321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E1C RID: 24092
		// (get) Token: 0x0601BCDC RID: 113884 RVA: 0x0040A124 File Offset: 0x00408324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithSpineLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601BCDD RID: 113885 RVA: 0x0040A12B File Offset: 0x0040832B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb()
		{
		}

		// Token: 0x0601BCDE RID: 113886 RVA: 0x0040A134 File Offset: 0x00408334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb(TransitionWithSpineLoadingPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.iCustomScreenTypeBasePb_ = ((other.iCustomScreenTypeBasePb_ != null) ? other.iCustomScreenTypeBasePb_.Clone() : null);
			this.fadeBackgroundFadeInEffectPb_ = ((other.fadeBackgroundFadeInEffectPb_ != null) ? other.fadeBackgroundFadeInEffectPb_.Clone() : null);
			this.fadeBackgroundFadeOutEffectPb_ = ((other.fadeBackgroundFadeOutEffectPb_ != null) ? other.fadeBackgroundFadeOutEffectPb_.Clone() : null);
			this.keepTime_ = other.keepTime_;
			this.iCustomShowUiPb_ = ((other.iCustomShowUiPb_ != null) ? other.iCustomShowUiPb_.Clone() : null);
			this.startAkEvent_ = other.startAkEvent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCDF RID: 113887 RVA: 0x0040A1EC File Offset: 0x004083EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb Clone()
		{
			return new TransitionWithSpineLoadingPb(this);
		}

		// Token: 0x17005E1D RID: 24093
		// (get) Token: 0x0601BCE0 RID: 113888 RVA: 0x0040A1F4 File Offset: 0x004083F4
		// (set) Token: 0x0601BCE1 RID: 113889 RVA: 0x0040A1FC File Offset: 0x004083FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb ICustomScreenTypeBasePb
		{
			get
			{
				return this.iCustomScreenTypeBasePb_;
			}
			set
			{
				this.iCustomScreenTypeBasePb_ = value;
			}
		}

		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x0601BCE2 RID: 113890 RVA: 0x0040A205 File Offset: 0x00408405
		// (set) Token: 0x0601BCE3 RID: 113891 RVA: 0x0040A20D File Offset: 0x0040840D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb FadeBackgroundFadeInEffectPb
		{
			get
			{
				return this.fadeBackgroundFadeInEffectPb_;
			}
			set
			{
				this.fadeBackgroundFadeInEffectPb_ = value;
			}
		}

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x0601BCE4 RID: 113892 RVA: 0x0040A216 File Offset: 0x00408416
		// (set) Token: 0x0601BCE5 RID: 113893 RVA: 0x0040A21E File Offset: 0x0040841E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb FadeBackgroundFadeOutEffectPb
		{
			get
			{
				return this.fadeBackgroundFadeOutEffectPb_;
			}
			set
			{
				this.fadeBackgroundFadeOutEffectPb_ = value;
			}
		}

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x0601BCE6 RID: 113894 RVA: 0x0040A227 File Offset: 0x00408427
		// (set) Token: 0x0601BCE7 RID: 113895 RVA: 0x0040A23F File Offset: 0x0040843F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float KeepTime
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.keepTime_;
				}
				return TransitionWithSpineLoadingPb.KeepTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.keepTime_ = value;
			}
		}

		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x0601BCE8 RID: 113896 RVA: 0x0040A256 File Offset: 0x00408456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasKeepTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601BCE9 RID: 113897 RVA: 0x0040A263 File Offset: 0x00408463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearKeepTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x0601BCEA RID: 113898 RVA: 0x0040A274 File Offset: 0x00408474
		// (set) Token: 0x0601BCEB RID: 113899 RVA: 0x0040A27C File Offset: 0x0040847C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomShowUiPb ICustomShowUiPb
		{
			get
			{
				return this.iCustomShowUiPb_;
			}
			set
			{
				this.iCustomShowUiPb_ = value;
			}
		}

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x0601BCEC RID: 113900 RVA: 0x0040A285 File Offset: 0x00408485
		// (set) Token: 0x0601BCED RID: 113901 RVA: 0x0040A296 File Offset: 0x00408496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartAkEvent
		{
			get
			{
				return this.startAkEvent_ ?? TransitionWithSpineLoadingPb.StartAkEventDefaultValue;
			}
			set
			{
				this.startAkEvent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x0601BCEE RID: 113902 RVA: 0x0040A2A9 File Offset: 0x004084A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStartAkEvent
		{
			get
			{
				return this.startAkEvent_ != null;
			}
		}

		// Token: 0x0601BCEF RID: 113903 RVA: 0x0040A2B4 File Offset: 0x004084B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStartAkEvent()
		{
			this.startAkEvent_ = null;
		}

		// Token: 0x0601BCF0 RID: 113904 RVA: 0x0040A2BD File Offset: 0x004084BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithSpineLoadingPb);
		}

		// Token: 0x0601BCF1 RID: 113905 RVA: 0x0040A2CC File Offset: 0x004084CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithSpineLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenTypeBasePb, other.ICustomScreenTypeBasePb) && object.Equals(this.FadeBackgroundFadeInEffectPb, other.FadeBackgroundFadeInEffectPb) && object.Equals(this.FadeBackgroundFadeOutEffectPb, other.FadeBackgroundFadeOutEffectPb) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.KeepTime, other.KeepTime) && object.Equals(this.ICustomShowUiPb, other.ICustomShowUiPb) && !(this.StartAkEvent != other.StartAkEvent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCF2 RID: 113906 RVA: 0x0040A378 File Offset: 0x00408578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iCustomScreenTypeBasePb_ != null)
			{
				num ^= this.ICustomScreenTypeBasePb.GetHashCode();
			}
			if (this.fadeBackgroundFadeInEffectPb_ != null)
			{
				num ^= this.FadeBackgroundFadeInEffectPb.GetHashCode();
			}
			if (this.fadeBackgroundFadeOutEffectPb_ != null)
			{
				num ^= this.FadeBackgroundFadeOutEffectPb.GetHashCode();
			}
			if (this.HasKeepTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.KeepTime);
			}
			if (this.iCustomShowUiPb_ != null)
			{
				num ^= this.ICustomShowUiPb.GetHashCode();
			}
			if (this.HasStartAkEvent)
			{
				num ^= this.StartAkEvent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCF3 RID: 113907 RVA: 0x0040A427 File Offset: 0x00408627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCF4 RID: 113908 RVA: 0x0040A434 File Offset: 0x00408634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCF5 RID: 113909 RVA: 0x0040A440 File Offset: 0x00408640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iCustomScreenTypeBasePb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenTypeBasePb);
			}
			if (this.fadeBackgroundFadeInEffectPb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FadeBackgroundFadeInEffectPb);
			}
			if (this.fadeBackgroundFadeOutEffectPb_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FadeBackgroundFadeOutEffectPb);
			}
			if (this.HasKeepTime)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.KeepTime);
			}
			if (this.iCustomShowUiPb_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ICustomShowUiPb);
			}
			if (this.HasStartAkEvent)
			{
				output.WriteRawTag(50);
				output.WriteString(this.StartAkEvent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCF6 RID: 113910 RVA: 0x0040A50C File Offset: 0x0040870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iCustomScreenTypeBasePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenTypeBasePb);
			}
			if (this.fadeBackgroundFadeInEffectPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeInEffectPb);
			}
			if (this.fadeBackgroundFadeOutEffectPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectPb);
			}
			if (this.HasKeepTime)
			{
				num += 5;
			}
			if (this.iCustomShowUiPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomShowUiPb);
			}
			if (this.HasStartAkEvent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StartAkEvent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCF7 RID: 113911 RVA: 0x0040A5B8 File Offset: 0x004087B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionWithSpineLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iCustomScreenTypeBasePb_ != null)
			{
				if (this.iCustomScreenTypeBasePb_ == null)
				{
					this.ICustomScreenTypeBasePb = new ICustomScreenTypeBasePb();
				}
				this.ICustomScreenTypeBasePb.MergeFrom(other.ICustomScreenTypeBasePb);
			}
			if (other.fadeBackgroundFadeInEffectPb_ != null)
			{
				if (this.fadeBackgroundFadeInEffectPb_ == null)
				{
					this.FadeBackgroundFadeInEffectPb = new FadeBackgroundFadeInEffectPb();
				}
				this.FadeBackgroundFadeInEffectPb.MergeFrom(other.FadeBackgroundFadeInEffectPb);
			}
			if (other.fadeBackgroundFadeOutEffectPb_ != null)
			{
				if (this.fadeBackgroundFadeOutEffectPb_ == null)
				{
					this.FadeBackgroundFadeOutEffectPb = new FadeBackgroundFadeOutEffectPb();
				}
				this.FadeBackgroundFadeOutEffectPb.MergeFrom(other.FadeBackgroundFadeOutEffectPb);
			}
			if (other.HasKeepTime)
			{
				this.KeepTime = other.KeepTime;
			}
			if (other.iCustomShowUiPb_ != null)
			{
				if (this.iCustomShowUiPb_ == null)
				{
					this.ICustomShowUiPb = new ICustomShowUiPb();
				}
				this.ICustomShowUiPb.MergeFrom(other.ICustomShowUiPb);
			}
			if (other.HasStartAkEvent)
			{
				this.StartAkEvent = other.StartAkEvent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCF8 RID: 113912 RVA: 0x0040A6B8 File Offset: 0x004088B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCF9 RID: 113913 RVA: 0x0040A6C4 File Offset: 0x004088C4
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						if (this.iCustomScreenTypeBasePb_ == null)
						{
							this.ICustomScreenTypeBasePb = new ICustomScreenTypeBasePb();
						}
						input.ReadMessage(this.ICustomScreenTypeBasePb);
						continue;
					}
					if (num == 18U)
					{
						if (this.fadeBackgroundFadeInEffectPb_ == null)
						{
							this.FadeBackgroundFadeInEffectPb = new FadeBackgroundFadeInEffectPb();
						}
						input.ReadMessage(this.FadeBackgroundFadeInEffectPb);
						continue;
					}
					if (num == 26U)
					{
						if (this.fadeBackgroundFadeOutEffectPb_ == null)
						{
							this.FadeBackgroundFadeOutEffectPb = new FadeBackgroundFadeOutEffectPb();
						}
						input.ReadMessage(this.FadeBackgroundFadeOutEffectPb);
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.KeepTime = input.ReadFloat();
						continue;
					}
					if (num == 42U)
					{
						if (this.iCustomShowUiPb_ == null)
						{
							this.ICustomShowUiPb = new ICustomShowUiPb();
						}
						input.ReadMessage(this.ICustomShowUiPb);
						continue;
					}
					if (num == 50U)
					{
						this.StartAkEvent = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A14C RID: 41292
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A14D RID: 41293
		private int _hasBits0;

		// Token: 0x0400A14E RID: 41294
		public const int ICustomScreenTypeBasePbFieldNumber = 1;

		// Token: 0x0400A14F RID: 41295
		private ICustomScreenTypeBasePb iCustomScreenTypeBasePb_;

		// Token: 0x0400A150 RID: 41296
		public const int FadeBackgroundFadeInEffectPbFieldNumber = 2;

		// Token: 0x0400A151 RID: 41297
		private FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb_;

		// Token: 0x0400A152 RID: 41298
		public const int FadeBackgroundFadeOutEffectPbFieldNumber = 3;

		// Token: 0x0400A153 RID: 41299
		private FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb_;

		// Token: 0x0400A154 RID: 41300
		public const int KeepTimeFieldNumber = 4;

		// Token: 0x0400A155 RID: 41301
		private static readonly float KeepTimeDefaultValue = 0f;

		// Token: 0x0400A156 RID: 41302
		private float keepTime_;

		// Token: 0x0400A157 RID: 41303
		public const int ICustomShowUiPbFieldNumber = 5;

		// Token: 0x0400A158 RID: 41304
		private ICustomShowUiPb iCustomShowUiPb_;

		// Token: 0x0400A159 RID: 41305
		public const int StartAkEventFieldNumber = 6;

		// Token: 0x0400A15A RID: 41306
		private static readonly string StartAkEventDefaultValue = "";

		// Token: 0x0400A15B RID: 41307
		private string startAkEvent_;
	}
}
