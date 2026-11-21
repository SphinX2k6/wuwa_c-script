using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058D RID: 1421
	[NetMessage(EMessageId.FlagStrongholdInfoUpdateNotify)]
	public sealed class FlagStrongholdInfoUpdateNotify : IMessage<FlagStrongholdInfoUpdateNotify>, IMessage, IEquatable<FlagStrongholdInfoUpdateNotify>, IDeepCloneable<FlagStrongholdInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060083F9 RID: 33785 RVA: 0x0013DE77 File Offset: 0x0013C077
		[NullableContext(1)]
		public static FlagStrongholdInfoUpdateNotify Create()
		{
			return new FlagStrongholdInfoUpdateNotify();
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060083FA RID: 33786 RVA: 0x0013DE7E File Offset: 0x0013C07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060083FB RID: 33787 RVA: 0x0013DE81 File Offset: 0x0013C081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagStrongholdInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x0013DE88 File Offset: 0x0013C088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify()
		{
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x0013DE9B File Offset: 0x0013C09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify(FlagStrongholdInfoUpdateNotify other) : this()
		{
			this.flagStrongholdInfo_ = other.flagStrongholdInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x0013DEC5 File Offset: 0x0013C0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify Clone()
		{
			return new FlagStrongholdInfoUpdateNotify(this);
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060083FF RID: 33791 RVA: 0x0013DECD File Offset: 0x0013C0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagStrongholdInfo> FlagStrongholdInfo
		{
			get
			{
				return this.flagStrongholdInfo_;
			}
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x0013DED5 File Offset: 0x0013C0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagStrongholdInfoUpdateNotify);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x0013DEE3 File Offset: 0x0013C0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagStrongholdInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.flagStrongholdInfo_.Equals(other.flagStrongholdInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x0013DF18 File Offset: 0x0013C118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.flagStrongholdInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x0013DF4C File Offset: 0x0013C14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x0013DF59 File Offset: 0x0013C159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x0013DF62 File Offset: 0x0013C162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flagStrongholdInfo_.WriteTo(ref output, FlagStrongholdInfoUpdateNotify._repeated_flagStrongholdInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x0013DF8C File Offset: 0x0013C18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.flagStrongholdInfo_.CalculateSize(FlagStrongholdInfoUpdateNotify._repeated_flagStrongholdInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x0013DFC5 File Offset: 0x0013C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagStrongholdInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.flagStrongholdInfo_.Add(other.flagStrongholdInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x0013DFF3 File Offset: 0x0013C1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x0013DFFC File Offset: 0x0013C1FC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.flagStrongholdInfo_.AddEntriesFrom(ref input, FlagStrongholdInfoUpdateNotify._repeated_flagStrongholdInfo_codec);
				}
			}
		}

		// Token: 0x040041EE RID: 16878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041EF RID: 16879
		public const int FlagStrongholdInfoFieldNumber = 15;

		// Token: 0x040041F0 RID: 16880
		private static readonly FieldCodec<FlagStrongholdInfo> _repeated_flagStrongholdInfo_codec = FieldCodec.ForMessage<FlagStrongholdInfo>(122U, Aki.Protocol.FlagStrongholdInfo.Parser);

		// Token: 0x040041F1 RID: 16881
		private readonly RepeatedField<FlagStrongholdInfo> flagStrongholdInfo_ = new RepeatedField<FlagStrongholdInfo>();
	}
}
