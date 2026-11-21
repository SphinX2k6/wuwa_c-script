using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB4 RID: 3508
	[NetMessage(EMessageId.PlayInstShareFirstInfoNotify)]
	public sealed class PlayInstShareFirstInfoNotify : IMessage<PlayInstShareFirstInfoNotify>, IMessage, IEquatable<PlayInstShareFirstInfoNotify>, IDeepCloneable<PlayInstShareFirstInfoNotify>, IBufferMessage
	{
		// Token: 0x06012EA7 RID: 77479 RVA: 0x002C2927 File Offset: 0x002C0B27
		[NullableContext(1)]
		public static PlayInstShareFirstInfoNotify Create()
		{
			return new PlayInstShareFirstInfoNotify();
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x06012EA8 RID: 77480 RVA: 0x002C292E File Offset: 0x002C0B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x06012EA9 RID: 77481 RVA: 0x002C2931 File Offset: 0x002C0B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayInstShareFirstInfoNotify.Descriptor;
			}
		}

		// Token: 0x06012EAA RID: 77482 RVA: 0x002C2938 File Offset: 0x002C0B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify()
		{
		}

		// Token: 0x06012EAB RID: 77483 RVA: 0x002C294B File Offset: 0x002C0B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify(PlayInstShareFirstInfoNotify other) : this()
		{
			this.firstInfo_ = other.firstInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EAC RID: 77484 RVA: 0x002C2975 File Offset: 0x002C0B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify Clone()
		{
			return new PlayInstShareFirstInfoNotify(this);
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x06012EAD RID: 77485 RVA: 0x002C297D File Offset: 0x002C0B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayInstShareFirstInfo> FirstInfo
		{
			get
			{
				return this.firstInfo_;
			}
		}

		// Token: 0x06012EAE RID: 77486 RVA: 0x002C2985 File Offset: 0x002C0B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayInstShareFirstInfoNotify);
		}

		// Token: 0x06012EAF RID: 77487 RVA: 0x002C2993 File Offset: 0x002C0B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayInstShareFirstInfoNotify other)
		{
			return other != null && (other == this || (this.firstInfo_.Equals(other.firstInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EB0 RID: 77488 RVA: 0x002C29C8 File Offset: 0x002C0BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.firstInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012EB1 RID: 77489 RVA: 0x002C29FC File Offset: 0x002C0BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EB2 RID: 77490 RVA: 0x002C2A09 File Offset: 0x002C0C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EB3 RID: 77491 RVA: 0x002C2A12 File Offset: 0x002C0C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.firstInfo_.WriteTo(ref output, PlayInstShareFirstInfoNotify._repeated_firstInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EB4 RID: 77492 RVA: 0x002C2A3C File Offset: 0x002C0C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.firstInfo_.CalculateSize(PlayInstShareFirstInfoNotify._repeated_firstInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012EB5 RID: 77493 RVA: 0x002C2A75 File Offset: 0x002C0C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayInstShareFirstInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.firstInfo_.Add(other.firstInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EB6 RID: 77494 RVA: 0x002C2AA3 File Offset: 0x002C0CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EB7 RID: 77495 RVA: 0x002C2AAC File Offset: 0x002C0CAC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.firstInfo_.AddEntriesFrom(ref input, PlayInstShareFirstInfoNotify._repeated_firstInfo_codec);
				}
			}
		}

		// Token: 0x04007560 RID: 30048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007561 RID: 30049
		public const int FirstInfoFieldNumber = 5;

		// Token: 0x04007562 RID: 30050
		private static readonly FieldCodec<PlayInstShareFirstInfo> _repeated_firstInfo_codec = FieldCodec.ForMessage<PlayInstShareFirstInfo>(42U, PlayInstShareFirstInfo.Parser);

		// Token: 0x04007563 RID: 30051
		private readonly RepeatedField<PlayInstShareFirstInfo> firstInfo_ = new RepeatedField<PlayInstShareFirstInfo>();
	}
}
