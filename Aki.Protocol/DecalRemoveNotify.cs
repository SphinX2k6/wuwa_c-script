using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BB RID: 955
	[NetMessage(EMessageId.DecalRemoveNotify)]
	public sealed class DecalRemoveNotify : IMessage<DecalRemoveNotify>, IMessage, IEquatable<DecalRemoveNotify>, IDeepCloneable<DecalRemoveNotify>, IBufferMessage
	{
		// Token: 0x06005D8F RID: 23951 RVA: 0x000E302F File Offset: 0x000E122F
		[NullableContext(1)]
		public static DecalRemoveNotify Create()
		{
			return new DecalRemoveNotify();
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06005D90 RID: 23952 RVA: 0x000E3036 File Offset: 0x000E1236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x000E3039 File Offset: 0x000E1239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x000E3040 File Offset: 0x000E1240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify()
		{
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x000E3053 File Offset: 0x000E1253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify(DecalRemoveNotify other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x000E307D File Offset: 0x000E127D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalRemoveNotify Clone()
		{
			return new DecalRemoveNotify(this);
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06005D95 RID: 23957 RVA: 0x000E3085 File Offset: 0x000E1285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecalInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x000E308D File Offset: 0x000E128D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalRemoveNotify);
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x000E309B File Offset: 0x000E129B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalRemoveNotify other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x000E30D0 File Offset: 0x000E12D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x000E3104 File Offset: 0x000E1304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x000E3111 File Offset: 0x000E1311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x000E311A File Offset: 0x000E131A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, DecalRemoveNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x000E3144 File Offset: 0x000E1344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(DecalRemoveNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x000E317D File Offset: 0x000E137D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecalRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x000E31AB File Offset: 0x000E13AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x000E31B4 File Offset: 0x000E13B4
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.info_.AddEntriesFrom(ref input, DecalRemoveNotify._repeated_info_codec);
				}
			}
		}

		// Token: 0x04003696 RID: 13974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003697 RID: 13975
		public const int InfoFieldNumber = 12;

		// Token: 0x04003698 RID: 13976
		private static readonly FieldCodec<DecalInfo> _repeated_info_codec = FieldCodec.ForMessage<DecalInfo>(98U, DecalInfo.Parser);

		// Token: 0x04003699 RID: 13977
		private readonly RepeatedField<DecalInfo> info_ = new RepeatedField<DecalInfo>();
	}
}
