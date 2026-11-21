using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001195 RID: 4501
	[NetMessage(EMessageId.SceneItemAiDisableNotify)]
	public sealed class SceneItemAiDisableNotify : IMessage<SceneItemAiDisableNotify>, IMessage, IEquatable<SceneItemAiDisableNotify>, IDeepCloneable<SceneItemAiDisableNotify>, IBufferMessage
	{
		// Token: 0x060180A4 RID: 98468 RVA: 0x003800DA File Offset: 0x0037E2DA
		[NullableContext(1)]
		public static SceneItemAiDisableNotify Create()
		{
			return new SceneItemAiDisableNotify();
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x060180A5 RID: 98469 RVA: 0x003800E1 File Offset: 0x0037E2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x060180A6 RID: 98470 RVA: 0x003800E4 File Offset: 0x0037E2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiDisableNotify.Descriptor;
			}
		}

		// Token: 0x060180A7 RID: 98471 RVA: 0x003800EB File Offset: 0x0037E2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify()
		{
		}

		// Token: 0x060180A8 RID: 98472 RVA: 0x003800F3 File Offset: 0x0037E2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify(SceneItemAiDisableNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180A9 RID: 98473 RVA: 0x00380118 File Offset: 0x0037E318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiDisableNotify Clone()
		{
			return new SceneItemAiDisableNotify(this);
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x060180AA RID: 98474 RVA: 0x00380120 File Offset: 0x0037E320
		// (set) Token: 0x060180AB RID: 98475 RVA: 0x00380128 File Offset: 0x0037E328
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

		// Token: 0x060180AC RID: 98476 RVA: 0x00380131 File Offset: 0x0037E331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiDisableNotify);
		}

		// Token: 0x060180AD RID: 98477 RVA: 0x0038013F File Offset: 0x0037E33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiDisableNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180AE RID: 98478 RVA: 0x00380170 File Offset: 0x0037E370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060180AF RID: 98479 RVA: 0x003801AF File Offset: 0x0037E3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180B0 RID: 98480 RVA: 0x003801BC File Offset: 0x0037E3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180B1 RID: 98481 RVA: 0x003801C5 File Offset: 0x0037E3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180B2 RID: 98482 RVA: 0x003801F8 File Offset: 0x0037E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060180B3 RID: 98483 RVA: 0x00380236 File Offset: 0x0037E436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiDisableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060180B4 RID: 98484 RVA: 0x00380267 File Offset: 0x0037E467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180B5 RID: 98485 RVA: 0x00380270 File Offset: 0x0037E470
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008F46 RID: 36678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F47 RID: 36679
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04008F48 RID: 36680
		private long entityId_;
	}
}
