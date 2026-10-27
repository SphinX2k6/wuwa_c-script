using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB4 RID: 3764
	public sealed class RecallQuestAcceptActionCtxPb : IMessage<RecallQuestAcceptActionCtxPb>, IMessage, IEquatable<RecallQuestAcceptActionCtxPb>, IDeepCloneable<RecallQuestAcceptActionCtxPb>, IBufferMessage
	{
		// Token: 0x06014321 RID: 82721 RVA: 0x002F0228 File Offset: 0x002EE428
		[NullableContext(1)]
		public static RecallQuestAcceptActionCtxPb Create()
		{
			return new RecallQuestAcceptActionCtxPb();
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x06014322 RID: 82722 RVA: 0x002F022F File Offset: 0x002EE42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x06014323 RID: 82723 RVA: 0x002F0232 File Offset: 0x002EE432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestAcceptActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06014324 RID: 82724 RVA: 0x002F0239 File Offset: 0x002EE439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb()
		{
		}

		// Token: 0x06014325 RID: 82725 RVA: 0x002F0241 File Offset: 0x002EE441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb(RecallQuestAcceptActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014326 RID: 82726 RVA: 0x002F0266 File Offset: 0x002EE466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb Clone()
		{
			return new RecallQuestAcceptActionCtxPb(this);
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x06014327 RID: 82727 RVA: 0x002F026E File Offset: 0x002EE46E
		// (set) Token: 0x06014328 RID: 82728 RVA: 0x002F0276 File Offset: 0x002EE476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x06014329 RID: 82729 RVA: 0x002F027F File Offset: 0x002EE47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestAcceptActionCtxPb);
		}

		// Token: 0x0601432A RID: 82730 RVA: 0x002F028D File Offset: 0x002EE48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestAcceptActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601432B RID: 82731 RVA: 0x002F02BC File Offset: 0x002EE4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601432C RID: 82732 RVA: 0x002F02FB File Offset: 0x002EE4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601432D RID: 82733 RVA: 0x002F0308 File Offset: 0x002EE508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601432E RID: 82734 RVA: 0x002F0311 File Offset: 0x002EE511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601432F RID: 82735 RVA: 0x002F0344 File Offset: 0x002EE544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014330 RID: 82736 RVA: 0x002F0382 File Offset: 0x002EE582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestAcceptActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014331 RID: 82737 RVA: 0x002F03B3 File Offset: 0x002EE5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014332 RID: 82738 RVA: 0x002F03BC File Offset: 0x002EE5BC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AF1 RID: 31473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AF2 RID: 31474
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007AF3 RID: 31475
		private int recallQuestId_;
	}
}
