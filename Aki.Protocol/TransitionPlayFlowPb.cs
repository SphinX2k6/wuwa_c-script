using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FD RID: 5117
	public sealed class TransitionPlayFlowPb : IMessage<TransitionPlayFlowPb>, IMessage, IEquatable<TransitionPlayFlowPb>, IDeepCloneable<TransitionPlayFlowPb>, IBufferMessage
	{
		// Token: 0x0601B201 RID: 111105 RVA: 0x003EE3F9 File Offset: 0x003EC5F9
		[NullableContext(1)]
		public static TransitionPlayFlowPb Create()
		{
			return new TransitionPlayFlowPb();
		}

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x0601B202 RID: 111106 RVA: 0x003EE400 File Offset: 0x003EC600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x0601B203 RID: 111107 RVA: 0x003EE403 File Offset: 0x003EC603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionPlayFlowPb.Descriptor;
			}
		}

		// Token: 0x0601B204 RID: 111108 RVA: 0x003EE40A File Offset: 0x003EC60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb()
		{
		}

		// Token: 0x0601B205 RID: 111109 RVA: 0x003EE414 File Offset: 0x003EC614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb(TransitionPlayFlowPb other) : this()
		{
			this.actionParamPb_ = ((other.actionParamPb_ != null) ? other.actionParamPb_.Clone() : null);
			this.fadeBackgroundFadeInEffectPb_ = ((other.fadeBackgroundFadeInEffectPb_ != null) ? other.fadeBackgroundFadeInEffectPb_.Clone() : null);
			this.fadeBackgroundFadeOutEffectPb_ = ((other.fadeBackgroundFadeOutEffectPb_ != null) ? other.fadeBackgroundFadeOutEffectPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B206 RID: 111110 RVA: 0x003EE48C File Offset: 0x003EC68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowPb Clone()
		{
			return new TransitionPlayFlowPb(this);
		}

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x0601B207 RID: 111111 RVA: 0x003EE494 File Offset: 0x003EC694
		// (set) Token: 0x0601B208 RID: 111112 RVA: 0x003EE49C File Offset: 0x003EC69C
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

		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x0601B209 RID: 111113 RVA: 0x003EE4A5 File Offset: 0x003EC6A5
		// (set) Token: 0x0601B20A RID: 111114 RVA: 0x003EE4AD File Offset: 0x003EC6AD
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

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x0601B20B RID: 111115 RVA: 0x003EE4B6 File Offset: 0x003EC6B6
		// (set) Token: 0x0601B20C RID: 111116 RVA: 0x003EE4BE File Offset: 0x003EC6BE
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

		// Token: 0x0601B20D RID: 111117 RVA: 0x003EE4C7 File Offset: 0x003EC6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionPlayFlowPb);
		}

		// Token: 0x0601B20E RID: 111118 RVA: 0x003EE4D8 File Offset: 0x003EC6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionPlayFlowPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionParamPb, other.ActionParamPb) && object.Equals(this.FadeBackgroundFadeInEffectPb, other.FadeBackgroundFadeInEffectPb) && object.Equals(this.FadeBackgroundFadeOutEffectPb, other.FadeBackgroundFadeOutEffectPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B20F RID: 111119 RVA: 0x003EE540 File Offset: 0x003EC740
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

		// Token: 0x0601B210 RID: 111120 RVA: 0x003EE5A8 File Offset: 0x003EC7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B211 RID: 111121 RVA: 0x003EE5B5 File Offset: 0x003EC7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B212 RID: 111122 RVA: 0x003EE5C0 File Offset: 0x003EC7C0
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

		// Token: 0x0601B213 RID: 111123 RVA: 0x003EE638 File Offset: 0x003EC838
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

		// Token: 0x0601B214 RID: 111124 RVA: 0x003EE6A8 File Offset: 0x003EC8A8
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

		// Token: 0x0601B215 RID: 111125 RVA: 0x003EE754 File Offset: 0x003EC954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B216 RID: 111126 RVA: 0x003EE760 File Offset: 0x003EC960
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

		// Token: 0x04009CF4 RID: 40180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CF5 RID: 40181
		public const int ActionParamPbFieldNumber = 1;

		// Token: 0x04009CF6 RID: 40182
		private TransitionPlayFlowActionParamPb actionParamPb_;

		// Token: 0x04009CF7 RID: 40183
		public const int FadeBackgroundFadeInEffectPbFieldNumber = 2;

		// Token: 0x04009CF8 RID: 40184
		private FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb_;

		// Token: 0x04009CF9 RID: 40185
		public const int FadeBackgroundFadeOutEffectPbFieldNumber = 3;

		// Token: 0x04009CFA RID: 40186
		private FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb_;
	}
}
