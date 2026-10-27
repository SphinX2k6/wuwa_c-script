using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003E RID: 62
	[NetMessage(EMessageId.AbyssReviveTimeNotify)]
	public sealed class AbyssReviveTimeNotify : IMessage<AbyssReviveTimeNotify>, IMessage, IEquatable<AbyssReviveTimeNotify>, IDeepCloneable<AbyssReviveTimeNotify>, IBufferMessage
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x00034B23 File Offset: 0x00032D23
		[NullableContext(1)]
		public static AbyssReviveTimeNotify Create()
		{
			return new AbyssReviveTimeNotify();
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00034B2A File Offset: 0x00032D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00034B2D File Offset: 0x00032D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveTimeNotify.Descriptor;
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00034B34 File Offset: 0x00032D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify()
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00034B47 File Offset: 0x00032D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify(AbyssReviveTimeNotify other) : this()
		{
			this.reviveTimeList_ = other.reviveTimeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00034B71 File Offset: 0x00032D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify Clone()
		{
			return new AbyssReviveTimeNotify(this);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00034B79 File Offset: 0x00032D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssEntityReviveTime> ReviveTimeList
		{
			get
			{
				return this.reviveTimeList_;
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00034B81 File Offset: 0x00032D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveTimeNotify);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00034B8F File Offset: 0x00032D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveTimeNotify other)
		{
			return other != null && (other == this || (this.reviveTimeList_.Equals(other.reviveTimeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00034BC4 File Offset: 0x00032DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.reviveTimeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00034BF8 File Offset: 0x00032DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00034C05 File Offset: 0x00032E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00034C0E File Offset: 0x00032E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reviveTimeList_.WriteTo(ref output, AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00034C38 File Offset: 0x00032E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.reviveTimeList_.CalculateSize(AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00034C71 File Offset: 0x00032E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.reviveTimeList_.Add(other.reviveTimeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00034C9F File Offset: 0x00032E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00034CA8 File Offset: 0x00032EA8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.reviveTimeList_.AddEntriesFrom(ref input, AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
				}
			}
		}

		// Token: 0x0400200E RID: 8206
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400200F RID: 8207
		public const int ReviveTimeListFieldNumber = 9;

		// Token: 0x04002010 RID: 8208
		private static readonly FieldCodec<AbyssEntityReviveTime> _repeated_reviveTimeList_codec = FieldCodec.ForMessage<AbyssEntityReviveTime>(74U, AbyssEntityReviveTime.Parser);

		// Token: 0x04002011 RID: 8209
		private readonly RepeatedField<AbyssEntityReviveTime> reviveTimeList_ = new RepeatedField<AbyssEntityReviveTime>();
	}
}
