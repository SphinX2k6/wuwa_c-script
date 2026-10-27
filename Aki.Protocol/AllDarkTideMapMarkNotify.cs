using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DF RID: 223
	[NetMessage(EMessageId.AllDarkTideMapMarkNotify)]
	public sealed class AllDarkTideMapMarkNotify : IMessage<AllDarkTideMapMarkNotify>, IMessage, IEquatable<AllDarkTideMapMarkNotify>, IDeepCloneable<AllDarkTideMapMarkNotify>, IBufferMessage
	{
		// Token: 0x0600212A RID: 8490 RVA: 0x00059055 File Offset: 0x00057255
		[NullableContext(1)]
		public static AllDarkTideMapMarkNotify Create()
		{
			return new AllDarkTideMapMarkNotify();
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0005905C File Offset: 0x0005725C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0005905F File Offset: 0x0005725F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AllDarkTideMapMarkNotify.Descriptor;
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00059066 File Offset: 0x00057266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllDarkTideMapMarkNotify()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00059079 File Offset: 0x00057279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllDarkTideMapMarkNotify(AllDarkTideMapMarkNotify other) : this()
		{
			this.markInfos_ = other.markInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000590A3 File Offset: 0x000572A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllDarkTideMapMarkNotify Clone()
		{
			return new AllDarkTideMapMarkNotify(this);
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x000590AB File Offset: 0x000572AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DarkTideMarkInfo> MarkInfos
		{
			get
			{
				return this.markInfos_;
			}
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000590B3 File Offset: 0x000572B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AllDarkTideMapMarkNotify);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x000590C1 File Offset: 0x000572C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AllDarkTideMapMarkNotify other)
		{
			return other != null && (other == this || (this.markInfos_.Equals(other.markInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000590F4 File Offset: 0x000572F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00059128 File Offset: 0x00057328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00059135 File Offset: 0x00057335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0005913E File Offset: 0x0005733E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markInfos_.WriteTo(ref output, AllDarkTideMapMarkNotify._repeated_markInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00059168 File Offset: 0x00057368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markInfos_.CalculateSize(AllDarkTideMapMarkNotify._repeated_markInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000591A1 File Offset: 0x000573A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AllDarkTideMapMarkNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.markInfos_.Add(other.markInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000591CF File Offset: 0x000573CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000591D8 File Offset: 0x000573D8
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
					this.markInfos_.AddEntriesFrom(ref input, AllDarkTideMapMarkNotify._repeated_markInfos_codec);
				}
			}
		}

		// Token: 0x0400242C RID: 9260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400242D RID: 9261
		public const int MarkInfosFieldNumber = 11;

		// Token: 0x0400242E RID: 9262
		private static readonly FieldCodec<DarkTideMarkInfo> _repeated_markInfos_codec = FieldCodec.ForMessage<DarkTideMarkInfo>(90U, DarkTideMarkInfo.Parser);

		// Token: 0x0400242F RID: 9263
		private readonly RepeatedField<DarkTideMarkInfo> markInfos_ = new RepeatedField<DarkTideMarkInfo>();
	}
}
