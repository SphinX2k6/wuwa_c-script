using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001194 RID: 4500
	public sealed class SceneItemAiComponentPb : IMessage<SceneItemAiComponentPb>, IMessage, IEquatable<SceneItemAiComponentPb>, IDeepCloneable<SceneItemAiComponentPb>, IBufferMessage
	{
		// Token: 0x06018090 RID: 98448 RVA: 0x0037FDFE File Offset: 0x0037DFFE
		[NullableContext(1)]
		public static SceneItemAiComponentPb Create()
		{
			return new SceneItemAiComponentPb();
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x06018091 RID: 98449 RVA: 0x0037FE05 File Offset: 0x0037E005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x06018092 RID: 98450 RVA: 0x0037FE08 File Offset: 0x0037E008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiComponentPb.Descriptor;
			}
		}

		// Token: 0x06018093 RID: 98451 RVA: 0x0037FE0F File Offset: 0x0037E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb()
		{
		}

		// Token: 0x06018094 RID: 98452 RVA: 0x0037FE18 File Offset: 0x0037E018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb(SceneItemAiComponentPb other) : this()
		{
			this.enable_ = other.enable_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018095 RID: 98453 RVA: 0x0037FE64 File Offset: 0x0037E064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb Clone()
		{
			return new SceneItemAiComponentPb(this);
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x06018096 RID: 98454 RVA: 0x0037FE6C File Offset: 0x0037E06C
		// (set) Token: 0x06018097 RID: 98455 RVA: 0x0037FE74 File Offset: 0x0037E074
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

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x06018098 RID: 98456 RVA: 0x0037FE7D File Offset: 0x0037E07D
		// (set) Token: 0x06018099 RID: 98457 RVA: 0x0037FE85 File Offset: 0x0037E085
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

		// Token: 0x0601809A RID: 98458 RVA: 0x0037FE8E File Offset: 0x0037E08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiComponentPb);
		}

		// Token: 0x0601809B RID: 98459 RVA: 0x0037FE9C File Offset: 0x0037E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiComponentPb other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601809C RID: 98460 RVA: 0x0037FEEC File Offset: 0x0037E0EC
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

		// Token: 0x0601809D RID: 98461 RVA: 0x0037FF41 File Offset: 0x0037E141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601809E RID: 98462 RVA: 0x0037FF4E File Offset: 0x0037E14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601809F RID: 98463 RVA: 0x0037FF58 File Offset: 0x0037E158
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

		// Token: 0x060180A0 RID: 98464 RVA: 0x0037FFB0 File Offset: 0x0037E1B0
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

		// Token: 0x060180A1 RID: 98465 RVA: 0x0037FFFC File Offset: 0x0037E1FC
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

		// Token: 0x060180A2 RID: 98466 RVA: 0x00380064 File Offset: 0x0037E264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180A3 RID: 98467 RVA: 0x00380070 File Offset: 0x0037E270
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

		// Token: 0x04008F41 RID: 36673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F42 RID: 36674
		public const int EnableFieldNumber = 1;

		// Token: 0x04008F43 RID: 36675
		private bool enable_;

		// Token: 0x04008F44 RID: 36676
		public const int AiInfoFieldNumber = 2;

		// Token: 0x04008F45 RID: 36677
		private SceneItemAiInfoPb aiInfo_;
	}
}
