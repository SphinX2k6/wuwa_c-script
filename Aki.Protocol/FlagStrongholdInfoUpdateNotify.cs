using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A2 RID: 1442
	[NetMessage(EMessageId.FlagStrongholdInfoUpdateNotify)]
	public sealed class FlagStrongholdInfoUpdateNotify : IMessage<FlagStrongholdInfoUpdateNotify>, IMessage, IEquatable<FlagStrongholdInfoUpdateNotify>, IDeepCloneable<FlagStrongholdInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008561 RID: 34145 RVA: 0x00140A7F File Offset: 0x0013EC7F
		[NullableContext(1)]
		public static FlagStrongholdInfoUpdateNotify Create()
		{
			return new FlagStrongholdInfoUpdateNotify();
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x00140A86 File Offset: 0x0013EC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x00140A89 File Offset: 0x0013EC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagStrongholdInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x00140A90 File Offset: 0x0013EC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify()
		{
		}

		// Token: 0x06008565 RID: 34149 RVA: 0x00140AA3 File Offset: 0x0013ECA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify(FlagStrongholdInfoUpdateNotify other) : this()
		{
			this.flagStrongholdInfo_ = other.flagStrongholdInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00140ACD File Offset: 0x0013ECCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagStrongholdInfoUpdateNotify Clone()
		{
			return new FlagStrongholdInfoUpdateNotify(this);
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x00140AD5 File Offset: 0x0013ECD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagStrongholdInfo> FlagStrongholdInfo
		{
			get
			{
				return this.flagStrongholdInfo_;
			}
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00140ADD File Offset: 0x0013ECDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagStrongholdInfoUpdateNotify);
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00140AEB File Offset: 0x0013ECEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagStrongholdInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.flagStrongholdInfo_.Equals(other.flagStrongholdInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x00140B20 File Offset: 0x0013ED20
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

		// Token: 0x0600856B RID: 34155 RVA: 0x00140B54 File Offset: 0x0013ED54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00140B61 File Offset: 0x0013ED61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x00140B6A File Offset: 0x0013ED6A
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

		// Token: 0x0600856E RID: 34158 RVA: 0x00140B94 File Offset: 0x0013ED94
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

		// Token: 0x0600856F RID: 34159 RVA: 0x00140BCD File Offset: 0x0013EDCD
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

		// Token: 0x06008570 RID: 34160 RVA: 0x00140BFB File Offset: 0x0013EDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x00140C04 File Offset: 0x0013EE04
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.flagStrongholdInfo_.AddEntriesFrom(ref input, FlagStrongholdInfoUpdateNotify._repeated_flagStrongholdInfo_codec);
				}
			}
		}

		// Token: 0x040041F8 RID: 16888
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041F9 RID: 16889
		public const int FlagStrongholdInfoFieldNumber = 2;

		// Token: 0x040041FA RID: 16890
		private static readonly FieldCodec<FlagStrongholdInfo> _repeated_flagStrongholdInfo_codec = FieldCodec.ForMessage<FlagStrongholdInfo>(18U, Aki.Protocol.FlagStrongholdInfo.Parser);

		// Token: 0x040041FB RID: 16891
		private readonly RepeatedField<FlagStrongholdInfo> flagStrongholdInfo_ = new RepeatedField<FlagStrongholdInfo>();
	}
}
