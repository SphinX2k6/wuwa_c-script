using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAA RID: 3754
	[NetMessage(EMessageId.RecallInstSaveDataNotify)]
	public sealed class RecallInstSaveDataNotify : IMessage<RecallInstSaveDataNotify>, IMessage, IEquatable<RecallInstSaveDataNotify>, IDeepCloneable<RecallInstSaveDataNotify>, IBufferMessage
	{
		// Token: 0x06014255 RID: 82517 RVA: 0x002EE6EA File Offset: 0x002EC8EA
		[NullableContext(1)]
		public static RecallInstSaveDataNotify Create()
		{
			return new RecallInstSaveDataNotify();
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x06014256 RID: 82518 RVA: 0x002EE6F1 File Offset: 0x002EC8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x06014257 RID: 82519 RVA: 0x002EE6F4 File Offset: 0x002EC8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInstSaveDataNotify.Descriptor;
			}
		}

		// Token: 0x06014258 RID: 82520 RVA: 0x002EE6FB File Offset: 0x002EC8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify()
		{
		}

		// Token: 0x06014259 RID: 82521 RVA: 0x002EE70E File Offset: 0x002EC90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify(RecallInstSaveDataNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601425A RID: 82522 RVA: 0x002EE744 File Offset: 0x002EC944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInstSaveDataNotify Clone()
		{
			return new RecallInstSaveDataNotify(this);
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x0601425B RID: 82523 RVA: 0x002EE74C File Offset: 0x002EC94C
		// (set) Token: 0x0601425C RID: 82524 RVA: 0x002EE754 File Offset: 0x002EC954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x0601425D RID: 82525 RVA: 0x002EE75D File Offset: 0x002EC95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601425E RID: 82526 RVA: 0x002EE765 File Offset: 0x002EC965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInstSaveDataNotify);
		}

		// Token: 0x0601425F RID: 82527 RVA: 0x002EE774 File Offset: 0x002EC974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInstSaveDataNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014260 RID: 82528 RVA: 0x002EE7C4 File Offset: 0x002EC9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014261 RID: 82529 RVA: 0x002EE811 File Offset: 0x002ECA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014262 RID: 82530 RVA: 0x002EE81E File Offset: 0x002ECA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014263 RID: 82531 RVA: 0x002EE828 File Offset: 0x002ECA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, RecallInstSaveDataNotify._repeated_ids_codec);
			if (this.RecallId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014264 RID: 82532 RVA: 0x002EE878 File Offset: 0x002ECA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			num += this.ids_.CalculateSize(RecallInstSaveDataNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014265 RID: 82533 RVA: 0x002EE8CC File Offset: 0x002ECACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallInstSaveDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014266 RID: 82534 RVA: 0x002EE919 File Offset: 0x002ECB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014267 RID: 82535 RVA: 0x002EE924 File Offset: 0x002ECB24
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
				if (num != 32U && num != 34U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RecallId = input.ReadInt32();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, RecallInstSaveDataNotify._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04007AB6 RID: 31414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AB7 RID: 31415
		public const int RecallIdFieldNumber = 11;

		// Token: 0x04007AB8 RID: 31416
		private int recallId_;

		// Token: 0x04007AB9 RID: 31417
		public const int IdsFieldNumber = 4;

		// Token: 0x04007ABA RID: 31418
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04007ABB RID: 31419
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
