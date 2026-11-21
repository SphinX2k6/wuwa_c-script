using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F0 RID: 1520
	[NetMessage(EMessageId.FlowShowEntityNotify)]
	public sealed class FlowShowEntityNotify : IMessage<FlowShowEntityNotify>, IMessage, IEquatable<FlowShowEntityNotify>, IDeepCloneable<FlowShowEntityNotify>, IBufferMessage
	{
		// Token: 0x06008D19 RID: 36121 RVA: 0x00156A01 File Offset: 0x00154C01
		[NullableContext(1)]
		public static FlowShowEntityNotify Create()
		{
			return new FlowShowEntityNotify();
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06008D1A RID: 36122 RVA: 0x00156A08 File Offset: 0x00154C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x00156A0B File Offset: 0x00154C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowShowEntityNotify.Descriptor;
			}
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00156A12 File Offset: 0x00154C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify()
		{
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00156A25 File Offset: 0x00154C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify(FlowShowEntityNotify other) : this()
		{
			this.isHide_ = other.isHide_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00156A5B File Offset: 0x00154C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowShowEntityNotify Clone()
		{
			return new FlowShowEntityNotify(this);
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06008D1F RID: 36127 RVA: 0x00156A63 File Offset: 0x00154C63
		// (set) Token: 0x06008D20 RID: 36128 RVA: 0x00156A6B File Offset: 0x00154C6B
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

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x00156A74 File Offset: 0x00154C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x00156A7C File Offset: 0x00154C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowShowEntityNotify);
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00156A8C File Offset: 0x00154C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowShowEntityNotify other)
		{
			return other != null && (other == this || (this.IsHide == other.IsHide && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x00156ADC File Offset: 0x00154CDC
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

		// Token: 0x06008D25 RID: 36133 RVA: 0x00156B29 File Offset: 0x00154D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D26 RID: 36134 RVA: 0x00156B36 File Offset: 0x00154D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D27 RID: 36135 RVA: 0x00156B40 File Offset: 0x00154D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, FlowShowEntityNotify._repeated_entityIds_codec);
			if (this.IsHide)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsHide);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D28 RID: 36136 RVA: 0x00156B90 File Offset: 0x00154D90
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

		// Token: 0x06008D29 RID: 36137 RVA: 0x00156BD8 File Offset: 0x00154DD8
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

		// Token: 0x06008D2A RID: 36138 RVA: 0x00156C25 File Offset: 0x00154E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x00156C30 File Offset: 0x00154E30
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
				if (num != 16U && num != 18U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsHide = input.ReadBool();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, FlowShowEntityNotify._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04004553 RID: 17747
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004554 RID: 17748
		public const int IsHideFieldNumber = 7;

		// Token: 0x04004555 RID: 17749
		private bool isHide_;

		// Token: 0x04004556 RID: 17750
		public const int EntityIdsFieldNumber = 2;

		// Token: 0x04004557 RID: 17751
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004558 RID: 17752
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
