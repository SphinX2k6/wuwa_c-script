using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B6 RID: 182
	[NetMessage(EMessageId.AddUnlockedDetectionTextNotify)]
	public sealed class AddUnlockedDetectionTextNotify : IMessage<AddUnlockedDetectionTextNotify>, IMessage, IEquatable<AddUnlockedDetectionTextNotify>, IDeepCloneable<AddUnlockedDetectionTextNotify>, IBufferMessage
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x00052057 File Offset: 0x00050257
		[NullableContext(1)]
		public static AddUnlockedDetectionTextNotify Create()
		{
			return new AddUnlockedDetectionTextNotify();
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0005205E File Offset: 0x0005025E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00052061 File Offset: 0x00050261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddUnlockedDetectionTextNotify.Descriptor;
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00052068 File Offset: 0x00050268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify()
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0005207B File Offset: 0x0005027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify(AddUnlockedDetectionTextNotify other) : this()
		{
			this.unlockedDetectionTextIds_ = other.unlockedDetectionTextIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000520A5 File Offset: 0x000502A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddUnlockedDetectionTextNotify Clone()
		{
			return new AddUnlockedDetectionTextNotify(this);
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000520AD File Offset: 0x000502AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedDetectionTextIds
		{
			get
			{
				return this.unlockedDetectionTextIds_;
			}
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000520B5 File Offset: 0x000502B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddUnlockedDetectionTextNotify);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000520C3 File Offset: 0x000502C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddUnlockedDetectionTextNotify other)
		{
			return other != null && (other == this || (this.unlockedDetectionTextIds_.Equals(other.unlockedDetectionTextIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000520F8 File Offset: 0x000502F8
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

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0005212C File Offset: 0x0005032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00052139 File Offset: 0x00050339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00052142 File Offset: 0x00050342
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

		// Token: 0x06001DFC RID: 7676 RVA: 0x0005216C File Offset: 0x0005036C
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

		// Token: 0x06001DFD RID: 7677 RVA: 0x000521A5 File Offset: 0x000503A5
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

		// Token: 0x06001DFE RID: 7678 RVA: 0x000521D3 File Offset: 0x000503D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000521DC File Offset: 0x000503DC
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedDetectionTextIds_.AddEntriesFrom(ref input, AddUnlockedDetectionTextNotify._repeated_unlockedDetectionTextIds_codec);
				}
			}
		}

		// Token: 0x0400233A RID: 9018
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400233B RID: 9019
		public const int UnlockedDetectionTextIdsFieldNumber = 6;

		// Token: 0x0400233C RID: 9020
		private static readonly FieldCodec<int> _repeated_unlockedDetectionTextIds_codec = FieldCodec.ForSInt32(50U);

		// Token: 0x0400233D RID: 9021
		private readonly RepeatedField<int> unlockedDetectionTextIds_ = new RepeatedField<int>();
	}
}
