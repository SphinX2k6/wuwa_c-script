using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB5 RID: 3765
	[NetMessage(EMessageId.RecallQuestReadyForGiveUpRequest)]
	public sealed class RecallQuestReadyForGiveUpRequest : IMessage<RecallQuestReadyForGiveUpRequest>, IMessage, IEquatable<RecallQuestReadyForGiveUpRequest>, IDeepCloneable<RecallQuestReadyForGiveUpRequest>, IBufferMessage
	{
		// Token: 0x06014382 RID: 82818 RVA: 0x002F11D4 File Offset: 0x002EF3D4
		[NullableContext(1)]
		public static RecallQuestReadyForGiveUpRequest Create()
		{
			return new RecallQuestReadyForGiveUpRequest();
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x06014383 RID: 82819 RVA: 0x002F11DB File Offset: 0x002EF3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x06014384 RID: 82820 RVA: 0x002F11DE File Offset: 0x002EF3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestReadyForGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x06014385 RID: 82821 RVA: 0x002F11E5 File Offset: 0x002EF3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest()
		{
		}

		// Token: 0x06014386 RID: 82822 RVA: 0x002F11ED File Offset: 0x002EF3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest(RecallQuestReadyForGiveUpRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014387 RID: 82823 RVA: 0x002F1212 File Offset: 0x002EF412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestReadyForGiveUpRequest Clone()
		{
			return new RecallQuestReadyForGiveUpRequest(this);
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x06014388 RID: 82824 RVA: 0x002F121A File Offset: 0x002EF41A
		// (set) Token: 0x06014389 RID: 82825 RVA: 0x002F1222 File Offset: 0x002EF422
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

		// Token: 0x0601438A RID: 82826 RVA: 0x002F122B File Offset: 0x002EF42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestReadyForGiveUpRequest);
		}

		// Token: 0x0601438B RID: 82827 RVA: 0x002F1239 File Offset: 0x002EF439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestReadyForGiveUpRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601438C RID: 82828 RVA: 0x002F1268 File Offset: 0x002EF468
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

		// Token: 0x0601438D RID: 82829 RVA: 0x002F12A7 File Offset: 0x002EF4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601438E RID: 82830 RVA: 0x002F12B4 File Offset: 0x002EF4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601438F RID: 82831 RVA: 0x002F12BD File Offset: 0x002EF4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014390 RID: 82832 RVA: 0x002F12F0 File Offset: 0x002EF4F0
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

		// Token: 0x06014391 RID: 82833 RVA: 0x002F132E File Offset: 0x002EF52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestReadyForGiveUpRequest other)
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

		// Token: 0x06014392 RID: 82834 RVA: 0x002F135F File Offset: 0x002EF55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014393 RID: 82835 RVA: 0x002F1368 File Offset: 0x002EF568
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B66 RID: 31590
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B67 RID: 31591
		public const int RecallQuestIdFieldNumber = 8;

		// Token: 0x04007B68 RID: 31592
		private int recallQuestId_;
	}
}
