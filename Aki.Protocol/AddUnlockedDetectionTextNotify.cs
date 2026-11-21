using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B7 RID: 183
	[NetMessage(EMessageId.AddUnlockedDetectionTextNotify)]
	public sealed class AddUnlockedDetectionTextNotify : IMessage<AddUnlockedDetectionTextNotify>, IMessage, IEquatable<AddUnlockedDetectionTextNotify>, IDeepCloneable<AddUnlockedDetectionTextNotify>, IBufferMessage
	{
		// Token: 0x06001E38 RID: 7736 RVA: 0x00052D0B File Offset: 0x00050F0B
		[NullableContext(1)]
		public static AddUnlockedDetectionTextNotify Create()
		{
			return new AddUnlockedDetectionTextNotify();
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00052D12 File Offset: 0x00050F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x00052D15 File Offset: 0x00050F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddUnlockedDetectionTextNotify.Descriptor;
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00052D1C File Offset: 0x00050F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify()
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00052D2F File Offset: 0x00050F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify(AddUnlockedDetectionTextNotify other) : this()
		{
			this.unlockedDetectionTextIds_ = other.unlockedDetectionTextIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00052D59 File Offset: 0x00050F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify Clone()
		{
			return new AddUnlockedDetectionTextNotify(this);
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00052D61 File Offset: 0x00050F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedDetectionTextIds
		{
			get
			{
				return this.unlockedDetectionTextIds_;
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00052D69 File Offset: 0x00050F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddUnlockedDetectionTextNotify);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00052D77 File Offset: 0x00050F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddUnlockedDetectionTextNotify other)
		{
			return other != null && (other == this || (this.unlockedDetectionTextIds_.Equals(other.unlockedDetectionTextIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00052DAC File Offset: 0x00050FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedDetectionTextIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00052DE0 File Offset: 0x00050FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00052DED File Offset: 0x00050FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00052DF6 File Offset: 0x00050FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedDetectionTextIds_.WriteTo(ref output, AddUnlockedDetectionTextNotify._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00052E20 File Offset: 0x00051020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedDetectionTextIds_.CalculateSize(AddUnlockedDetectionTextNotify._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00052E59 File Offset: 0x00051059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddUnlockedDetectionTextNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedDetectionTextIds_.Add(other.unlockedDetectionTextIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00052E87 File Offset: 0x00051087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00052E90 File Offset: 0x00051090
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedDetectionTextIds_.AddEntriesFrom(ref input, AddUnlockedDetectionTextNotify._repeated_unlockedDetectionTextIds_codec);
				}
			}
		}

		// Token: 0x0400239D RID: 9117
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400239E RID: 9118
		public const int UnlockedDetectionTextIdsFieldNumber = 15;

		// Token: 0x0400239F RID: 9119
		private static readonly FieldCodec<int> _repeated_unlockedDetectionTextIds_codec = FieldCodec.ForSInt32(122U);

		// Token: 0x040023A0 RID: 9120
		private readonly RepeatedField<int> unlockedDetectionTextIds_ = new RepeatedField<int>();
	}
}
