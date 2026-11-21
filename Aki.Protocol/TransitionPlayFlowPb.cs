using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001470 RID: 5232
	public sealed class TransitionPlayFlowPb : IMessage<TransitionPlayFlowPb>, IMessage, IEquatable<TransitionPlayFlowPb>, IDeepCloneable<TransitionPlayFlowPb>, IBufferMessage
	{
		// Token: 0x0601BC8C RID: 113804 RVA: 0x004096CD File Offset: 0x004078CD
		[NullableContext(1)]
		public static TransitionPlayFlowPb Create()
		{
			return new TransitionPlayFlowPb();
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x0601BC8D RID: 113805 RVA: 0x004096D4 File Offset: 0x004078D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x0601BC8E RID: 113806 RVA: 0x004096D7 File Offset: 0x004078D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionPlayFlowPb.Descriptor;
			}
		}

		// Token: 0x0601BC8F RID: 113807 RVA: 0x004096DE File Offset: 0x004078DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb()
		{
		}

		// Token: 0x0601BC90 RID: 113808 RVA: 0x004096E8 File Offset: 0x004078E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb(TransitionPlayFlowPb other) : this()
		{
			this.actionParamPb_ = ((other.actionParamPb_ != null) ? other.actionParamPb_.Clone() : null);
			this.fadeBackgroundFadeInEffectPb_ = ((other.fadeBackgroundFadeInEffectPb_ != null) ? other.fadeBackgroundFadeInEffectPb_.Clone() : null);
			this.fadeBackgroundFadeOutEffectPb_ = ((other.fadeBackgroundFadeOutEffectPb_ != null) ? other.fadeBackgroundFadeOutEffectPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC91 RID: 113809 RVA: 0x00409760 File Offset: 0x00407960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb Clone()
		{
			return new TransitionPlayFlowPb(this);
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x0601BC92 RID: 113810 RVA: 0x00409768 File Offset: 0x00407968
		// (set) Token: 0x0601BC93 RID: 113811 RVA: 0x00409770 File Offset: 0x00407970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb ActionParamPb
		{
			get
			{
				return this.actionParamPb_;
			}
			set
			{
				this.actionParamPb_ = value;
			}
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x0601BC94 RID: 113812 RVA: 0x00409779 File Offset: 0x00407979
		// (set) Token: 0x0601BC95 RID: 113813 RVA: 0x00409781 File Offset: 0x00407981
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

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x0601BC96 RID: 113814 RVA: 0x0040978A File Offset: 0x0040798A
		// (set) Token: 0x0601BC97 RID: 113815 RVA: 0x00409792 File Offset: 0x00407992
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

		// Token: 0x0601BC98 RID: 113816 RVA: 0x0040979B File Offset: 0x0040799B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionPlayFlowPb);
		}

		// Token: 0x0601BC99 RID: 113817 RVA: 0x004097AC File Offset: 0x004079AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionPlayFlowPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionParamPb, other.ActionParamPb) && object.Equals(this.FadeBackgroundFadeInEffectPb, other.FadeBackgroundFadeInEffectPb) && object.Equals(this.FadeBackgroundFadeOutEffectPb, other.FadeBackgroundFadeOutEffectPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC9A RID: 113818 RVA: 0x00409814 File Offset: 0x00407A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.actionParamPb_ != null)
			{
				num ^= this.ActionParamPb.GetHashCode();
			}
			if (this.fadeBackgroundFadeInEffectPb_ != null)
			{
				num ^= this.FadeBackgroundFadeInEffectPb.GetHashCode();
			}
			if (this.fadeBackgroundFadeOutEffectPb_ != null)
			{
				num ^= this.FadeBackgroundFadeOutEffectPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC9B RID: 113819 RVA: 0x0040987C File Offset: 0x00407A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC9C RID: 113820 RVA: 0x00409889 File Offset: 0x00407A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC9D RID: 113821 RVA: 0x00409894 File Offset: 0x00407A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.actionParamPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActionParamPb);
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC9E RID: 113822 RVA: 0x0040990C File Offset: 0x00407B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.actionParamPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionParamPb);
			}
			if (this.fadeBackgroundFadeInEffectPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeInEffectPb);
			}
			if (this.fadeBackgroundFadeOutEffectPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC9F RID: 113823 RVA: 0x0040997C File Offset: 0x00407B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionPlayFlowPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.actionParamPb_ != null)
			{
				if (this.actionParamPb_ == null)
				{
					this.ActionParamPb = new TransitionPlayFlowActionParamPb();
				}
				this.ActionParamPb.MergeFrom(other.ActionParamPb);
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x00409A28 File Offset: 0x00407C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x00409A34 File Offset: 0x00407C34
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.fadeBackgroundFadeOutEffectPb_ == null)
							{
								this.FadeBackgroundFadeOutEffectPb = new FadeBackgroundFadeOutEffectPb();
							}
							input.ReadMessage(this.FadeBackgroundFadeOutEffectPb);
						}
					}
					else
					{
						if (this.fadeBackgroundFadeInEffectPb_ == null)
						{
							this.FadeBackgroundFadeInEffectPb = new FadeBackgroundFadeInEffectPb();
						}
						input.ReadMessage(this.FadeBackgroundFadeInEffectPb);
					}
				}
				else
				{
					if (this.actionParamPb_ == null)
					{
						this.ActionParamPb = new TransitionPlayFlowActionParamPb();
					}
					input.ReadMessage(this.ActionParamPb);
				}
			}
		}

		// Token: 0x0400A13B RID: 41275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A13C RID: 41276
		public const int ActionParamPbFieldNumber = 1;

		// Token: 0x0400A13D RID: 41277
		private TransitionPlayFlowActionParamPb actionParamPb_;

		// Token: 0x0400A13E RID: 41278
		public const int FadeBackgroundFadeInEffectPbFieldNumber = 2;

		// Token: 0x0400A13F RID: 41279
		private FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb_;

		// Token: 0x0400A140 RID: 41280
		public const int FadeBackgroundFadeOutEffectPbFieldNumber = 3;

		// Token: 0x0400A141 RID: 41281
		private FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb_;
	}
}
