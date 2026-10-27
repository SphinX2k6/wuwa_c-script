using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000605 RID: 1541
	[NetMessage(EMessageId.FlowShowEntityNotify)]
	public sealed class FlowShowEntityNotify : IMessage<FlowShowEntityNotify>, IMessage, IEquatable<FlowShowEntityNotify>, IDeepCloneable<FlowShowEntityNotify>, IBufferMessage
	{
		// Token: 0x06008E81 RID: 36481 RVA: 0x00159605 File Offset: 0x00157805
		[NullableContext(1)]
		public static FlowShowEntityNotify Create()
		{
			return new FlowShowEntityNotify();
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06008E82 RID: 36482 RVA: 0x0015960C File Offset: 0x0015780C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x0015960F File Offset: 0x0015780F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowShowEntityNotify.Descriptor;
			}
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00159616 File Offset: 0x00157816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify()
		{
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x00159629 File Offset: 0x00157829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify(FlowShowEntityNotify other) : this()
		{
			this.isHide_ = other.isHide_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x0015965F File Offset: 0x0015785F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify Clone()
		{
			return new FlowShowEntityNotify(this);
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06008E87 RID: 36487 RVA: 0x00159667 File Offset: 0x00157867
		// (set) Token: 0x06008E88 RID: 36488 RVA: 0x0015966F File Offset: 0x0015786F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHide
		{
			get
			{
				return this.isHide_;
			}
			set
			{
				this.isHide_ = value;
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x00159678 File Offset: 0x00157878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x00159680 File Offset: 0x00157880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowShowEntityNotify);
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x00159690 File Offset: 0x00157890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowShowEntityNotify other)
		{
			return other != null && (other == this || (this.IsHide == other.IsHide && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x001596E0 File Offset: 0x001578E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsHide)
			{
				num ^= this.IsHide.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E8D RID: 36493 RVA: 0x0015972D File Offset: 0x0015792D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E8E RID: 36494 RVA: 0x0015973A File Offset: 0x0015793A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x00159744 File Offset: 0x00157944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsHide)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsHide);
			}
			this.entityIds_.WriteTo(ref output, FlowShowEntityNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x00159794 File Offset: 0x00157994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsHide)
			{
				num += 2;
			}
			num += this.entityIds_.CalculateSize(FlowShowEntityNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x001597DC File Offset: 0x001579DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowShowEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsHide)
			{
				this.IsHide = other.IsHide;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x00159829 File Offset: 0x00157A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00159834 File Offset: 0x00157A34
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
				if (num != 24U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, FlowShowEntityNotify._repeated_entityIds_codec);
					}
				}
				else
				{
					this.IsHide = input.ReadBool();
				}
			}
		}

		// Token: 0x0400455D RID: 17757
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400455E RID: 17758
		public const int IsHideFieldNumber = 3;

		// Token: 0x0400455F RID: 17759
		private bool isHide_;

		// Token: 0x04004560 RID: 17760
		public const int EntityIdsFieldNumber = 6;

		// Token: 0x04004561 RID: 17761
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004562 RID: 17762
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
