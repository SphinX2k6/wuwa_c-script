using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F83 RID: 3971
	[NetMessage(EMessageId.RoguelikeChooseDataNotify)]
	public sealed class RoguelikeChooseDataNotify : IMessage<RoguelikeChooseDataNotify>, IMessage, IEquatable<RoguelikeChooseDataNotify>, IDeepCloneable<RoguelikeChooseDataNotify>, IBufferMessage
	{
		// Token: 0x0601544B RID: 87115 RVA: 0x00316C0F File Offset: 0x00314E0F
		[NullableContext(1)]
		public static RoguelikeChooseDataNotify Create()
		{
			return new RoguelikeChooseDataNotify();
		}

		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x0601544C RID: 87116 RVA: 0x00316C16 File Offset: 0x00314E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x0601544D RID: 87117 RVA: 0x00316C19 File Offset: 0x00314E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataNotify.Descriptor;
			}
		}

		// Token: 0x0601544E RID: 87118 RVA: 0x00316C20 File Offset: 0x00314E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify()
		{
		}

		// Token: 0x0601544F RID: 87119 RVA: 0x00316C33 File Offset: 0x00314E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify(RoguelikeChooseDataNotify other) : this()
		{
			this.roguelikeChooseDataList_ = other.roguelikeChooseDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015450 RID: 87120 RVA: 0x00316C5D File Offset: 0x00314E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataNotify Clone()
		{
			return new RoguelikeChooseDataNotify(this);
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x06015451 RID: 87121 RVA: 0x00316C65 File Offset: 0x00314E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeChooseData> RoguelikeChooseDataList
		{
			get
			{
				return this.roguelikeChooseDataList_;
			}
		}

		// Token: 0x06015452 RID: 87122 RVA: 0x00316C6D File Offset: 0x00314E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataNotify);
		}

		// Token: 0x06015453 RID: 87123 RVA: 0x00316C7B File Offset: 0x00314E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataNotify other)
		{
			return other != null && (other == this || (this.roguelikeChooseDataList_.Equals(other.roguelikeChooseDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015454 RID: 87124 RVA: 0x00316CB0 File Offset: 0x00314EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roguelikeChooseDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015455 RID: 87125 RVA: 0x00316CE4 File Offset: 0x00314EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015456 RID: 87126 RVA: 0x00316CF1 File Offset: 0x00314EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015457 RID: 87127 RVA: 0x00316CFA File Offset: 0x00314EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roguelikeChooseDataList_.WriteTo(ref output, RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015458 RID: 87128 RVA: 0x00316D24 File Offset: 0x00314F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roguelikeChooseDataList_.CalculateSize(RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015459 RID: 87129 RVA: 0x00316D5D File Offset: 0x00314F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roguelikeChooseDataList_.Add(other.roguelikeChooseDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601545A RID: 87130 RVA: 0x00316D8B File Offset: 0x00314F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601545B RID: 87131 RVA: 0x00316D94 File Offset: 0x00314F94
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roguelikeChooseDataList_.AddEntriesFrom(ref input, RoguelikeChooseDataNotify._repeated_roguelikeChooseDataList_codec);
				}
			}
		}

		// Token: 0x0400807A RID: 32890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400807B RID: 32891
		public const int RoguelikeChooseDataListFieldNumber = 11;

		// Token: 0x0400807C RID: 32892
		private static readonly FieldCodec<RoguelikeChooseData> _repeated_roguelikeChooseDataList_codec = FieldCodec.ForMessage<RoguelikeChooseData>(90U, RoguelikeChooseData.Parser);

		// Token: 0x0400807D RID: 32893
		private readonly RepeatedField<RoguelikeChooseData> roguelikeChooseDataList_ = new RepeatedField<RoguelikeChooseData>();
	}
}
