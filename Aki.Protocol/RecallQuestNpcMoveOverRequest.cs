using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC3 RID: 3779
	[NetMessage(EMessageId.RecallQuestNpcMoveOverRequest)]
	public sealed class RecallQuestNpcMoveOverRequest : IMessage<RecallQuestNpcMoveOverRequest>, IMessage, IEquatable<RecallQuestNpcMoveOverRequest>, IDeepCloneable<RecallQuestNpcMoveOverRequest>, IBufferMessage
	{
		// Token: 0x06014443 RID: 83011 RVA: 0x002F24D1 File Offset: 0x002F06D1
		[NullableContext(1)]
		public static RecallQuestNpcMoveOverRequest Create()
		{
			return new RecallQuestNpcMoveOverRequest();
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06014444 RID: 83012 RVA: 0x002F24D8 File Offset: 0x002F06D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06014445 RID: 83013 RVA: 0x002F24DB File Offset: 0x002F06DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestNpcMoveOverRequest.Descriptor;
			}
		}

		// Token: 0x06014446 RID: 83014 RVA: 0x002F24E2 File Offset: 0x002F06E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest()
		{
		}

		// Token: 0x06014447 RID: 83015 RVA: 0x002F24EA File Offset: 0x002F06EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest(RecallQuestNpcMoveOverRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014448 RID: 83016 RVA: 0x002F250F File Offset: 0x002F070F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestNpcMoveOverRequest Clone()
		{
			return new RecallQuestNpcMoveOverRequest(this);
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06014449 RID: 83017 RVA: 0x002F2517 File Offset: 0x002F0717
		// (set) Token: 0x0601444A RID: 83018 RVA: 0x002F251F File Offset: 0x002F071F
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

		// Token: 0x0601444B RID: 83019 RVA: 0x002F2528 File Offset: 0x002F0728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestNpcMoveOverRequest);
		}

		// Token: 0x0601444C RID: 83020 RVA: 0x002F2536 File Offset: 0x002F0736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestNpcMoveOverRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601444D RID: 83021 RVA: 0x002F2564 File Offset: 0x002F0764
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

		// Token: 0x0601444E RID: 83022 RVA: 0x002F25A3 File Offset: 0x002F07A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601444F RID: 83023 RVA: 0x002F25B0 File Offset: 0x002F07B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014450 RID: 83024 RVA: 0x002F25B9 File Offset: 0x002F07B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014451 RID: 83025 RVA: 0x002F25EC File Offset: 0x002F07EC
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

		// Token: 0x06014452 RID: 83026 RVA: 0x002F262A File Offset: 0x002F082A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestNpcMoveOverRequest other)
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

		// Token: 0x06014453 RID: 83027 RVA: 0x002F265B File Offset: 0x002F085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014454 RID: 83028 RVA: 0x002F2664 File Offset: 0x002F0864
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007B36 RID: 31542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B37 RID: 31543
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04007B38 RID: 31544
		private long entityId_;
	}
}
