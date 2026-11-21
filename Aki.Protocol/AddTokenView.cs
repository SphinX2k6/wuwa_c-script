using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B4 RID: 180
	public sealed class AddTokenView : IMessage<AddTokenView>, IMessage, IEquatable<AddTokenView>, IDeepCloneable<AddTokenView>, IBufferMessage
	{
		// Token: 0x06001E00 RID: 7680 RVA: 0x00052630 File Offset: 0x00050830
		[NullableContext(1)]
		public static AddTokenView Create()
		{
			return new AddTokenView();
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00052637 File Offset: 0x00050837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0005263A File Offset: 0x0005083A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTokenView.Descriptor;
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00052641 File Offset: 0x00050841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView()
		{
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00052654 File Offset: 0x00050854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView(AddTokenView other) : this()
		{
			this.type_ = other.type_;
			this.rogueResGainDatas_ = other.rogueResGainDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0005268A File Offset: 0x0005088A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTokenView Clone()
		{
			return new AddTokenView(this);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00052692 File Offset: 0x00050892
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0005269A File Offset: 0x0005089A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000526A3 File Offset: 0x000508A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGainData> RogueResGainDatas
		{
			get
			{
				return this.rogueResGainDatas_;
			}
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x000526AB File Offset: 0x000508AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTokenView);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000526BC File Offset: 0x000508BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTokenView other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.rogueResGainDatas_.Equals(other.rogueResGainDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0005270C File Offset: 0x0005090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.rogueResGainDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00052759 File Offset: 0x00050959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00052766 File Offset: 0x00050966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00052770 File Offset: 0x00050970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			this.rogueResGainDatas_.WriteTo(ref output, AddTokenView._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000527C0 File Offset: 0x000509C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			num += this.rogueResGainDatas_.CalculateSize(AddTokenView._repeated_rogueResGainDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00052814 File Offset: 0x00050A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTokenView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this.rogueResGainDatas_.Add(other.rogueResGainDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00052861 File Offset: 0x00050A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0005286C File Offset: 0x00050A6C
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
						this.rogueResGainDatas_.AddEntriesFrom(ref input, AddTokenView._repeated_rogueResGainDatas_codec);
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002391 RID: 9105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002392 RID: 9106
		public const int TypeFieldNumber = 1;

		// Token: 0x04002393 RID: 9107
		private int type_;

		// Token: 0x04002394 RID: 9108
		public const int RogueResGainDatasFieldNumber = 2;

		// Token: 0x04002395 RID: 9109
		private static readonly FieldCodec<RogueResGainData> _repeated_rogueResGainDatas_codec = FieldCodec.ForMessage<RogueResGainData>(18U, RogueResGainData.Parser);

		// Token: 0x04002396 RID: 9110
		private readonly RepeatedField<RogueResGainData> rogueResGainDatas_ = new RepeatedField<RogueResGainData>();
	}
}
