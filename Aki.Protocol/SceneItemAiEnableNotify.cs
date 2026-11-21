using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001196 RID: 4502
	[NetMessage(EMessageId.SceneItemAiEnableNotify)]
	public sealed class SceneItemAiEnableNotify : IMessage<SceneItemAiEnableNotify>, IMessage, IEquatable<SceneItemAiEnableNotify>, IDeepCloneable<SceneItemAiEnableNotify>, IBufferMessage
	{
		// Token: 0x060180B6 RID: 98486 RVA: 0x003802B5 File Offset: 0x0037E4B5
		[NullableContext(1)]
		public static SceneItemAiEnableNotify Create()
		{
			return new SceneItemAiEnableNotify();
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x060180B7 RID: 98487 RVA: 0x003802BC File Offset: 0x0037E4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x060180B8 RID: 98488 RVA: 0x003802BF File Offset: 0x0037E4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiEnableNotify.Descriptor;
			}
		}

		// Token: 0x060180B9 RID: 98489 RVA: 0x003802C6 File Offset: 0x0037E4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify()
		{
		}

		// Token: 0x060180BA RID: 98490 RVA: 0x003802D0 File Offset: 0x0037E4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify(SceneItemAiEnableNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180BB RID: 98491 RVA: 0x0038031C File Offset: 0x0037E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiEnableNotify Clone()
		{
			return new SceneItemAiEnableNotify(this);
		}

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x060180BC RID: 98492 RVA: 0x00380324 File Offset: 0x0037E524
		// (set) Token: 0x060180BD RID: 98493 RVA: 0x0038032C File Offset: 0x0037E52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x060180BE RID: 98494 RVA: 0x00380335 File Offset: 0x0037E535
		// (set) Token: 0x060180BF RID: 98495 RVA: 0x0038033D File Offset: 0x0037E53D
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

		// Token: 0x060180C0 RID: 98496 RVA: 0x00380346 File Offset: 0x0037E546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiEnableNotify);
		}

		// Token: 0x060180C1 RID: 98497 RVA: 0x00380354 File Offset: 0x0037E554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiEnableNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180C2 RID: 98498 RVA: 0x003803A4 File Offset: 0x0037E5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x060180C3 RID: 98499 RVA: 0x003803F9 File Offset: 0x0037E5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180C4 RID: 98500 RVA: 0x00380406 File Offset: 0x0037E606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180C5 RID: 98501 RVA: 0x00380410 File Offset: 0x0037E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AiInfo);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180C6 RID: 98502 RVA: 0x0038046C File Offset: 0x0037E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x060180C7 RID: 98503 RVA: 0x003804C4 File Offset: 0x0037E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
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

		// Token: 0x060180C8 RID: 98504 RVA: 0x0038052C File Offset: 0x0037E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180C9 RID: 98505 RVA: 0x00380538 File Offset: 0x0037E738
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
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
		}

		// Token: 0x04008F49 RID: 36681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F4A RID: 36682
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04008F4B RID: 36683
		private long entityId_;

		// Token: 0x04008F4C RID: 36684
		public const int AiInfoFieldNumber = 1;

		// Token: 0x04008F4D RID: 36685
		private SceneItemAiInfoPb aiInfo_;
	}
}
