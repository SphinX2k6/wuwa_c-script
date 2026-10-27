using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC4 RID: 3524
	[NetMessage(EMessageId.PlayInstShareFirstInfoNotify)]
	public sealed class PlayInstShareFirstInfoNotify : IMessage<PlayInstShareFirstInfoNotify>, IMessage, IEquatable<PlayInstShareFirstInfoNotify>, IDeepCloneable<PlayInstShareFirstInfoNotify>, IBufferMessage
	{
		// Token: 0x06012FA3 RID: 77731 RVA: 0x002C454B File Offset: 0x002C274B
		[NullableContext(1)]
		public static PlayInstShareFirstInfoNotify Create()
		{
			return new PlayInstShareFirstInfoNotify();
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x06012FA4 RID: 77732 RVA: 0x002C4552 File Offset: 0x002C2752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x06012FA5 RID: 77733 RVA: 0x002C4555 File Offset: 0x002C2755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayInstShareFirstInfoNotify.Descriptor;
			}
		}

		// Token: 0x06012FA6 RID: 77734 RVA: 0x002C455C File Offset: 0x002C275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify()
		{
		}

		// Token: 0x06012FA7 RID: 77735 RVA: 0x002C456F File Offset: 0x002C276F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify(PlayInstShareFirstInfoNotify other) : this()
		{
			this.firstInfo_ = other.firstInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FA8 RID: 77736 RVA: 0x002C4599 File Offset: 0x002C2799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayInstShareFirstInfoNotify Clone()
		{
			return new PlayInstShareFirstInfoNotify(this);
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x06012FA9 RID: 77737 RVA: 0x002C45A1 File Offset: 0x002C27A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayInstShareFirstInfo> FirstInfo
		{
			get
			{
				return this.firstInfo_;
			}
		}

		// Token: 0x06012FAA RID: 77738 RVA: 0x002C45A9 File Offset: 0x002C27A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayInstShareFirstInfoNotify);
		}

		// Token: 0x06012FAB RID: 77739 RVA: 0x002C45B7 File Offset: 0x002C27B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayInstShareFirstInfoNotify other)
		{
			return other != null && (other == this || (this.firstInfo_.Equals(other.firstInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FAC RID: 77740 RVA: 0x002C45EC File Offset: 0x002C27EC
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

		// Token: 0x06012FAD RID: 77741 RVA: 0x002C4620 File Offset: 0x002C2820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FAE RID: 77742 RVA: 0x002C462D File Offset: 0x002C282D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FAF RID: 77743 RVA: 0x002C4636 File Offset: 0x002C2836
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

		// Token: 0x06012FB0 RID: 77744 RVA: 0x002C4660 File Offset: 0x002C2860
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

		// Token: 0x06012FB1 RID: 77745 RVA: 0x002C4699 File Offset: 0x002C2899
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

		// Token: 0x06012FB2 RID: 77746 RVA: 0x002C46C7 File Offset: 0x002C28C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FB3 RID: 77747 RVA: 0x002C46D0 File Offset: 0x002C28D0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.firstInfo_.AddEntriesFrom(ref input, PlayInstShareFirstInfoNotify._repeated_firstInfo_codec);
				}
			}
		}

		// Token: 0x04007548 RID: 30024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007549 RID: 30025
		public const int FirstInfoFieldNumber = 1;

		// Token: 0x0400754A RID: 30026
		private static readonly FieldCodec<PlayInstShareFirstInfo> _repeated_firstInfo_codec = FieldCodec.ForMessage<PlayInstShareFirstInfo>(10U, PlayInstShareFirstInfo.Parser);

		// Token: 0x0400754B RID: 30027
		private readonly RepeatedField<PlayInstShareFirstInfo> firstInfo_ = new RepeatedField<PlayInstShareFirstInfo>();
	}
}
