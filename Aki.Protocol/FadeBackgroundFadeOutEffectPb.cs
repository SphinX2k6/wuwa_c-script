using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000516 RID: 1302
	public sealed class FadeBackgroundFadeOutEffectPb : IMessage<FadeBackgroundFadeOutEffectPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectPb>, IDeepCloneable<FadeBackgroundFadeOutEffectPb>, IBufferMessage
	{
		// Token: 0x06007A6B RID: 31339 RVA: 0x001295BA File Offset: 0x001277BA
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectPb Create()
		{
			return new FadeBackgroundFadeOutEffectPb();
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x001295C1 File Offset: 0x001277C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x001295C4 File Offset: 0x001277C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectPb.Descriptor;
			}
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x001295CB File Offset: 0x001277CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb()
		{
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x001295D4 File Offset: 0x001277D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb(FadeBackgroundFadeOutEffectPb other) : this()
		{
			FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase = other.FadeOutEffectCase;
			if (fadeOutEffectCase != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				if (fadeOutEffectCase == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					this.FadeBackgroundFadeOutEffectSceenPb = other.FadeBackgroundFadeOutEffectSceenPb.Clone();
				}
			}
			else
			{
				this.FadeBackgroundFadeOutEffectBlackPb = other.FadeBackgroundFadeOutEffectBlackPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x0012962D File Offset: 0x0012782D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb Clone()
		{
			return new FadeBackgroundFadeOutEffectPb(this);
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x00129635 File Offset: 0x00127835
		// (set) Token: 0x06007A72 RID: 31346 RVA: 0x0012964D File Offset: 0x0012784D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb FadeBackgroundFadeOutEffectBlackPb
		{
			get
			{
				if (this.fadeOutEffectCase_ != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
				{
					return null;
				}
				return (FadeBackgroundFadeOutEffectBlackPb)this.fadeOutEffect_;
			}
			set
			{
				this.fadeOutEffect_ = value;
				this.fadeOutEffectCase_ = ((value == null) ? FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None : FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb);
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06007A73 RID: 31347 RVA: 0x00129663 File Offset: 0x00127863
		// (set) Token: 0x06007A74 RID: 31348 RVA: 0x0012967B File Offset: 0x0012787B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb FadeBackgroundFadeOutEffectSceenPb
		{
			get
			{
				if (this.fadeOutEffectCase_ != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					return null;
				}
				return (FadeBackgroundFadeOutEffectSceenPb)this.fadeOutEffect_;
			}
			set
			{
				this.fadeOutEffect_ = value;
				this.fadeOutEffectCase_ = ((value == null) ? FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None : FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb);
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x00129691 File Offset: 0x00127891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase FadeOutEffectCase
		{
			get
			{
				return this.fadeOutEffectCase_;
			}
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x00129699 File Offset: 0x00127899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutEffect()
		{
			this.fadeOutEffectCase_ = FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None;
			this.fadeOutEffect_ = null;
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x001296A9 File Offset: 0x001278A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectPb);
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x001296B8 File Offset: 0x001278B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectPb other)
		{
			return other != null && (other == this || (object.Equals(this.FadeBackgroundFadeOutEffectBlackPb, other.FadeBackgroundFadeOutEffectBlackPb) && object.Equals(this.FadeBackgroundFadeOutEffectSceenPb, other.FadeBackgroundFadeOutEffectSceenPb) && this.FadeOutEffectCase == other.FadeOutEffectCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x0012971C File Offset: 0x0012791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				num ^= this.FadeBackgroundFadeOutEffectBlackPb.GetHashCode();
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				num ^= this.FadeBackgroundFadeOutEffectSceenPb.GetHashCode();
			}
			num ^= (int)this.fadeOutEffectCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x00129779 File Offset: 0x00127979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x00129786 File Offset: 0x00127986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x00129790 File Offset: 0x00127990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FadeBackgroundFadeOutEffectBlackPb);
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FadeBackgroundFadeOutEffectSceenPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x001297EC File Offset: 0x001279EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectBlackPb);
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectSceenPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x00129844 File Offset: 0x00127A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeOutEffectPb other)
		{
			if (other == null)
			{
				return;
			}
			FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase = other.FadeOutEffectCase;
			if (fadeOutEffectCase != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				if (fadeOutEffectCase == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					if (this.FadeBackgroundFadeOutEffectSceenPb == null)
					{
						this.FadeBackgroundFadeOutEffectSceenPb = new FadeBackgroundFadeOutEffectSceenPb();
					}
					this.FadeBackgroundFadeOutEffectSceenPb.MergeFrom(other.FadeBackgroundFadeOutEffectSceenPb);
				}
			}
			else
			{
				if (this.FadeBackgroundFadeOutEffectBlackPb == null)
				{
					this.FadeBackgroundFadeOutEffectBlackPb = new FadeBackgroundFadeOutEffectBlackPb();
				}
				this.FadeBackgroundFadeOutEffectBlackPb.MergeFrom(other.FadeBackgroundFadeOutEffectBlackPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x001298C7 File Offset: 0x00127AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x001298D0 File Offset: 0x00127AD0
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						FadeBackgroundFadeOutEffectSceenPb fadeBackgroundFadeOutEffectSceenPb = new FadeBackgroundFadeOutEffectSceenPb();
						if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
						{
							fadeBackgroundFadeOutEffectSceenPb.MergeFrom(this.FadeBackgroundFadeOutEffectSceenPb);
						}
						input.ReadMessage(fadeBackgroundFadeOutEffectSceenPb);
						this.FadeBackgroundFadeOutEffectSceenPb = fadeBackgroundFadeOutEffectSceenPb;
					}
				}
				else
				{
					FadeBackgroundFadeOutEffectBlackPb fadeBackgroundFadeOutEffectBlackPb = new FadeBackgroundFadeOutEffectBlackPb();
					if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
					{
						fadeBackgroundFadeOutEffectBlackPb.MergeFrom(this.FadeBackgroundFadeOutEffectBlackPb);
					}
					input.ReadMessage(fadeBackgroundFadeOutEffectBlackPb);
					this.FadeBackgroundFadeOutEffectBlackPb = fadeBackgroundFadeOutEffectBlackPb;
				}
			}
		}

		// Token: 0x04003EEE RID: 16110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EEF RID: 16111
		public const int FadeBackgroundFadeOutEffectBlackPbFieldNumber = 1;

		// Token: 0x04003EF0 RID: 16112
		public const int FadeBackgroundFadeOutEffectSceenPbFieldNumber = 2;

		// Token: 0x04003EF1 RID: 16113
		private object fadeOutEffect_;

		// Token: 0x04003EF2 RID: 16114
		private FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase_;

		// Token: 0x0200178A RID: 6026
		public enum FadeOutEffectOneofCase
		{
			// Token: 0x0400C6AA RID: 50858
			None,
			// Token: 0x0400C6AB RID: 50859
			FadeBackgroundFadeOutEffectBlackPb,
			// Token: 0x0400C6AC RID: 50860
			FadeBackgroundFadeOutEffectSceenPb
		}
	}
}
