using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001401 RID: 5121
	public sealed class TransitionWithSpineLoadingPb : IMessage<TransitionWithSpineLoadingPb>, IMessage, IEquatable<TransitionWithSpineLoadingPb>, IDeepCloneable<TransitionWithSpineLoadingPb>, IBufferMessage
	{
		// Token: 0x0601B24F RID: 111183 RVA: 0x003EEE46 File Offset: 0x003ED046
		[NullableContext(1)]
		public static TransitionWithSpineLoadingPb Create()
		{
			return new TransitionWithSpineLoadingPb();
		}

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x0601B250 RID: 111184 RVA: 0x003EEE4D File Offset: 0x003ED04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x0601B251 RID: 111185 RVA: 0x003EEE50 File Offset: 0x003ED050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithSpineLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601B252 RID: 111186 RVA: 0x003EEE57 File Offset: 0x003ED057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb()
		{
		}

		// Token: 0x0601B253 RID: 111187 RVA: 0x003EEE60 File Offset: 0x003ED060
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

		// Token: 0x0601B254 RID: 111188 RVA: 0x003EEF18 File Offset: 0x003ED118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpineLoadingPb Clone()
		{
			return new TransitionWithSpineLoadingPb(this);
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x0601B255 RID: 111189 RVA: 0x003EEF20 File Offset: 0x003ED120
		// (set) Token: 0x0601B256 RID: 111190 RVA: 0x003EEF28 File Offset: 0x003ED128
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

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x0601B257 RID: 111191 RVA: 0x003EEF31 File Offset: 0x003ED131
		// (set) Token: 0x0601B258 RID: 111192 RVA: 0x003EEF39 File Offset: 0x003ED139
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

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x0601B259 RID: 111193 RVA: 0x003EEF42 File Offset: 0x003ED142
		// (set) Token: 0x0601B25A RID: 111194 RVA: 0x003EEF4A File Offset: 0x003ED14A
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

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x0601B25B RID: 111195 RVA: 0x003EEF53 File Offset: 0x003ED153
		// (set) Token: 0x0601B25C RID: 111196 RVA: 0x003EEF6B File Offset: 0x003ED16B
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

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x0601B25D RID: 111197 RVA: 0x003EEF82 File Offset: 0x003ED182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasKeepTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601B25E RID: 111198 RVA: 0x003EEF8F File Offset: 0x003ED18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearKeepTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x0601B25F RID: 111199 RVA: 0x003EEFA0 File Offset: 0x003ED1A0
		// (set) Token: 0x0601B260 RID: 111200 RVA: 0x003EEFA8 File Offset: 0x003ED1A8
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

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x0601B261 RID: 111201 RVA: 0x003EEFB1 File Offset: 0x003ED1B1
		// (set) Token: 0x0601B262 RID: 111202 RVA: 0x003EEFC2 File Offset: 0x003ED1C2
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

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x0601B263 RID: 111203 RVA: 0x003EEFD5 File Offset: 0x003ED1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStartAkEvent
		{
			get
			{
				return this.startAkEvent_ != null;
			}
		}

		// Token: 0x0601B264 RID: 111204 RVA: 0x003EEFE0 File Offset: 0x003ED1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStartAkEvent()
		{
			this.startAkEvent_ = null;
		}

		// Token: 0x0601B265 RID: 111205 RVA: 0x003EEFE9 File Offset: 0x003ED1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithSpineLoadingPb);
		}

		// Token: 0x0601B266 RID: 111206 RVA: 0x003EEFF8 File Offset: 0x003ED1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithSpineLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenTypeBasePb, other.ICustomScreenTypeBasePb) && object.Equals(this.FadeBackgroundFadeInEffectPb, other.FadeBackgroundFadeInEffectPb) && object.Equals(this.FadeBackgroundFadeOutEffectPb, other.FadeBackgroundFadeOutEffectPb) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.KeepTime, other.KeepTime) && object.Equals(this.ICustomShowUiPb, other.ICustomShowUiPb) && !(this.StartAkEvent != other.StartAkEvent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B267 RID: 111207 RVA: 0x003EF0A4 File Offset: 0x003ED2A4
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

		// Token: 0x0601B268 RID: 111208 RVA: 0x003EF153 File Offset: 0x003ED353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B269 RID: 111209 RVA: 0x003EF160 File Offset: 0x003ED360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B26A RID: 111210 RVA: 0x003EF16C File Offset: 0x003ED36C
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

		// Token: 0x0601B26B RID: 111211 RVA: 0x003EF238 File Offset: 0x003ED438
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

		// Token: 0x0601B26C RID: 111212 RVA: 0x003EF2E4 File Offset: 0x003ED4E4
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

		// Token: 0x0601B26D RID: 111213 RVA: 0x003EF3E4 File Offset: 0x003ED5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B26E RID: 111214 RVA: 0x003EF3F0 File Offset: 0x003ED5F0
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

		// Token: 0x04009D05 RID: 40197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D06 RID: 40198
		private int _hasBits0;

		// Token: 0x04009D07 RID: 40199
		public const int ICustomScreenTypeBasePbFieldNumber = 1;

		// Token: 0x04009D08 RID: 40200
		private ICustomScreenTypeBasePb iCustomScreenTypeBasePb_;

		// Token: 0x04009D09 RID: 40201
		public const int FadeBackgroundFadeInEffectPbFieldNumber = 2;

		// Token: 0x04009D0A RID: 40202
		private FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb_;

		// Token: 0x04009D0B RID: 40203
		public const int FadeBackgroundFadeOutEffectPbFieldNumber = 3;

		// Token: 0x04009D0C RID: 40204
		private FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb_;

		// Token: 0x04009D0D RID: 40205
		public const int KeepTimeFieldNumber = 4;

		// Token: 0x04009D0E RID: 40206
		private static readonly float KeepTimeDefaultValue = 0f;

		// Token: 0x04009D0F RID: 40207
		private float keepTime_;

		// Token: 0x04009D10 RID: 40208
		public const int ICustomShowUiPbFieldNumber = 5;

		// Token: 0x04009D11 RID: 40209
		private ICustomShowUiPb iCustomShowUiPb_;

		// Token: 0x04009D12 RID: 40210
		public const int StartAkEventFieldNumber = 6;

		// Token: 0x04009D13 RID: 40211
		private static readonly string StartAkEventDefaultValue = "";

		// Token: 0x04009D14 RID: 40212
		private string startAkEvent_;
	}
}
