using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F8 RID: 5368
	public sealed class UnlockDetectionLabelInfo : IMessage<UnlockDetectionLabelInfo>, IMessage, IEquatable<UnlockDetectionLabelInfo>, IDeepCloneable<UnlockDetectionLabelInfo>, IBufferMessage
	{
		// Token: 0x0601C750 RID: 116560 RVA: 0x00420849 File Offset: 0x0041EA49
		[NullableContext(1)]
		public static UnlockDetectionLabelInfo Create()
		{
			return new UnlockDetectionLabelInfo();
		}

		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x0601C751 RID: 116561 RVA: 0x00420850 File Offset: 0x0041EA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x0601C752 RID: 116562 RVA: 0x00420853 File Offset: 0x0041EA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockDetectionLabelInfo.Descriptor;
			}
		}

		// Token: 0x0601C753 RID: 116563 RVA: 0x0042085A File Offset: 0x0041EA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo()
		{
		}

		// Token: 0x0601C754 RID: 116564 RVA: 0x00420878 File Offset: 0x0041EA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo(UnlockDetectionLabelInfo other) : this()
		{
			this.unlockedGuideIds_ = other.unlockedGuideIds_.Clone();
			this.unlockedDetectionTextIds_ = other.unlockedDetectionTextIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C755 RID: 116565 RVA: 0x004208B3 File Offset: 0x0041EAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo Clone()
		{
			return new UnlockDetectionLabelInfo(this);
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x0601C756 RID: 116566 RVA: 0x004208BB File Offset: 0x0041EABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedGuideIds
		{
			get
			{
				return this.unlockedGuideIds_;
			}
		}

		// Token: 0x1700604F RID: 24655
		// (get) Token: 0x0601C757 RID: 116567 RVA: 0x004208C3 File Offset: 0x0041EAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedDetectionTextIds
		{
			get
			{
				return this.unlockedDetectionTextIds_;
			}
		}

		// Token: 0x0601C758 RID: 116568 RVA: 0x004208CB File Offset: 0x0041EACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockDetectionLabelInfo);
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x004208DC File Offset: 0x0041EADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockDetectionLabelInfo other)
		{
			return other != null && (other == this || (this.unlockedGuideIds_.Equals(other.unlockedGuideIds_) && this.unlockedDetectionTextIds_.Equals(other.unlockedDetectionTextIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C75A RID: 116570 RVA: 0x00420930 File Offset: 0x0041EB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedGuideIds_.GetHashCode();
			num ^= this.unlockedDetectionTextIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C75B RID: 116571 RVA: 0x00420972 File Offset: 0x0041EB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C75C RID: 116572 RVA: 0x0042097F File Offset: 0x0041EB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C75D RID: 116573 RVA: 0x00420988 File Offset: 0x0041EB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedGuideIds_.WriteTo(ref output, UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
			this.unlockedDetectionTextIds_.WriteTo(ref output, UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C75E RID: 116574 RVA: 0x004209C0 File Offset: 0x0041EBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedGuideIds_.CalculateSize(UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
			num += this.unlockedDetectionTextIds_.CalculateSize(UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C75F RID: 116575 RVA: 0x00420A0C File Offset: 0x0041EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockDetectionLabelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedGuideIds_.Add(other.unlockedGuideIds_);
			this.unlockedDetectionTextIds_.Add(other.unlockedDetectionTextIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C760 RID: 116576 RVA: 0x00420A4B File Offset: 0x0041EC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C761 RID: 116577 RVA: 0x00420A54 File Offset: 0x0041EC54
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.unlockedGuideIds_.AddEntriesFrom(ref input, UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.unlockedDetectionTextIds_.AddEntriesFrom(ref input, UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A43C RID: 42044
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A43D RID: 42045
		public const int UnlockedGuideIdsFieldNumber = 1;

		// Token: 0x0400A43E RID: 42046
		private static readonly FieldCodec<int> _repeated_unlockedGuideIds_codec = FieldCodec.ForSInt32(10U);

		// Token: 0x0400A43F RID: 42047
		private readonly RepeatedField<int> unlockedGuideIds_ = new RepeatedField<int>();

		// Token: 0x0400A440 RID: 42048
		public const int UnlockedDetectionTextIdsFieldNumber = 2;

		// Token: 0x0400A441 RID: 42049
		private static readonly FieldCodec<int> _repeated_unlockedDetectionTextIds_codec = FieldCodec.ForSInt32(18U);

		// Token: 0x0400A442 RID: 42050
		private readonly RepeatedField<int> unlockedDetectionTextIds_ = new RepeatedField<int>();
	}
}
