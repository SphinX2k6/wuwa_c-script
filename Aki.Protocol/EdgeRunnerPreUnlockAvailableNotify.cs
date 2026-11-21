using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040F RID: 1039
	[NetMessage(EMessageId.EdgeRunnerPreUnlockAvailableNotify)]
	public sealed class EdgeRunnerPreUnlockAvailableNotify : IMessage<EdgeRunnerPreUnlockAvailableNotify>, IMessage, IEquatable<EdgeRunnerPreUnlockAvailableNotify>, IDeepCloneable<EdgeRunnerPreUnlockAvailableNotify>, IBufferMessage
	{
		// Token: 0x06006481 RID: 25729 RVA: 0x000F28C7 File Offset: 0x000F0AC7
		[NullableContext(1)]
		public static EdgeRunnerPreUnlockAvailableNotify Create()
		{
			return new EdgeRunnerPreUnlockAvailableNotify();
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x000F28CE File Offset: 0x000F0ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06006483 RID: 25731 RVA: 0x000F28D1 File Offset: 0x000F0AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerPreUnlockAvailableNotify.Descriptor;
			}
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x000F28D8 File Offset: 0x000F0AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify()
		{
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x000F28EB File Offset: 0x000F0AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify(EdgeRunnerPreUnlockAvailableNotify other) : this()
		{
			this.preUnlockIds_ = other.preUnlockIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x000F2915 File Offset: 0x000F0B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerPreUnlockAvailableNotify Clone()
		{
			return new EdgeRunnerPreUnlockAvailableNotify(this);
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06006487 RID: 25735 RVA: 0x000F291D File Offset: 0x000F0B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreUnlockIds
		{
			get
			{
				return this.preUnlockIds_;
			}
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x000F2925 File Offset: 0x000F0B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerPreUnlockAvailableNotify);
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x000F2933 File Offset: 0x000F0B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerPreUnlockAvailableNotify other)
		{
			return other != null && (other == this || (this.preUnlockIds_.Equals(other.preUnlockIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x000F2968 File Offset: 0x000F0B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.preUnlockIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x000F299C File Offset: 0x000F0B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x000F29A9 File Offset: 0x000F0BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x000F29B2 File Offset: 0x000F0BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preUnlockIds_.WriteTo(ref output, EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x000F29DC File Offset: 0x000F0BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.preUnlockIds_.CalculateSize(EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x000F2A15 File Offset: 0x000F0C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerPreUnlockAvailableNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.preUnlockIds_.Add(other.preUnlockIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x000F2A43 File Offset: 0x000F0C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x000F2A4C File Offset: 0x000F0C4C
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.preUnlockIds_.AddEntriesFrom(ref input, EdgeRunnerPreUnlockAvailableNotify._repeated_preUnlockIds_codec);
				}
			}
		}

		// Token: 0x040038FC RID: 14588
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038FD RID: 14589
		public const int PreUnlockIdsFieldNumber = 11;

		// Token: 0x040038FE RID: 14590
		private static readonly FieldCodec<int> _repeated_preUnlockIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040038FF RID: 14591
		private readonly RepeatedField<int> preUnlockIds_ = new RepeatedField<int>();
	}
}
