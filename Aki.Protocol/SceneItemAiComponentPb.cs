using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115A RID: 4442
	public sealed class SceneItemAiComponentPb : IMessage<SceneItemAiComponentPb>, IMessage, IEquatable<SceneItemAiComponentPb>, IDeepCloneable<SceneItemAiComponentPb>, IBufferMessage
	{
		// Token: 0x06017AEF RID: 97007 RVA: 0x00370AAE File Offset: 0x0036ECAE
		[NullableContext(1)]
		public static SceneItemAiComponentPb Create()
		{
			return new SceneItemAiComponentPb();
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x06017AF0 RID: 97008 RVA: 0x00370AB5 File Offset: 0x0036ECB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x06017AF1 RID: 97009 RVA: 0x00370AB8 File Offset: 0x0036ECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiComponentPb.Descriptor;
			}
		}

		// Token: 0x06017AF2 RID: 97010 RVA: 0x00370ABF File Offset: 0x0036ECBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb()
		{
		}

		// Token: 0x06017AF3 RID: 97011 RVA: 0x00370AC8 File Offset: 0x0036ECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb(SceneItemAiComponentPb other) : this()
		{
			this.enable_ = other.enable_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017AF4 RID: 97012 RVA: 0x00370B14 File Offset: 0x0036ED14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb Clone()
		{
			return new SceneItemAiComponentPb(this);
		}

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x06017AF5 RID: 97013 RVA: 0x00370B1C File Offset: 0x0036ED1C
		// (set) Token: 0x06017AF6 RID: 97014 RVA: 0x00370B24 File Offset: 0x0036ED24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x06017AF7 RID: 97015 RVA: 0x00370B2D File Offset: 0x0036ED2D
		// (set) Token: 0x06017AF8 RID: 97016 RVA: 0x00370B35 File Offset: 0x0036ED35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiInfoPb AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x06017AF9 RID: 97017 RVA: 0x00370B3E File Offset: 0x0036ED3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiComponentPb);
		}

		// Token: 0x06017AFA RID: 97018 RVA: 0x00370B4C File Offset: 0x0036ED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiComponentPb other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017AFB RID: 97019 RVA: 0x00370B9C File Offset: 0x0036ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017AFC RID: 97020 RVA: 0x00370BF1 File Offset: 0x0036EDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017AFD RID: 97021 RVA: 0x00370BFE File Offset: 0x0036EDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017AFE RID: 97022 RVA: 0x00370C08 File Offset: 0x0036EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enable);
			}
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017AFF RID: 97023 RVA: 0x00370C60 File Offset: 0x0036EE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B00 RID: 97024 RVA: 0x00370CAC File Offset: 0x0036EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new SceneItemAiInfoPb();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B01 RID: 97025 RVA: 0x00370D14 File Offset: 0x0036EF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B02 RID: 97026 RVA: 0x00370D20 File Offset: 0x0036EF20
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.aiInfo_ == null)
						{
							this.AiInfo = new SceneItemAiInfoPb();
						}
						input.ReadMessage(this.AiInfo);
					}
				}
				else
				{
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x04008CAE RID: 36014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CAF RID: 36015
		public const int EnableFieldNumber = 1;

		// Token: 0x04008CB0 RID: 36016
		private bool enable_;

		// Token: 0x04008CB1 RID: 36017
		public const int AiInfoFieldNumber = 2;

		// Token: 0x04008CB2 RID: 36018
		private SceneItemAiInfoPb aiInfo_;
	}
}
