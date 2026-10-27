using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000763 RID: 1891
	[NetMessage(EMessageId.HonamiStoryAreaInfoUpdateNotify)]
	public sealed class HonamiStoryAreaInfoUpdateNotify : IMessage<HonamiStoryAreaInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryAreaInfoUpdateNotify>, IDeepCloneable<HonamiStoryAreaInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AB27 RID: 43815 RVA: 0x0019BF9A File Offset: 0x0019A19A
		[NullableContext(1)]
		public static HonamiStoryAreaInfoUpdateNotify Create()
		{
			return new HonamiStoryAreaInfoUpdateNotify();
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x0019BFA1 File Offset: 0x0019A1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600AB29 RID: 43817 RVA: 0x0019BFA4 File Offset: 0x0019A1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x0019BFAB File Offset: 0x0019A1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify()
		{
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x0019BFBE File Offset: 0x0019A1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify(HonamiStoryAreaInfoUpdateNotify other) : this()
		{
			this.honamiStoryAreaInfo_ = other.honamiStoryAreaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x0019BFE8 File Offset: 0x0019A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify Clone()
		{
			return new HonamiStoryAreaInfoUpdateNotify(this);
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x0019BFF0 File Offset: 0x0019A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryAreaInfo> HonamiStoryAreaInfo
		{
			get
			{
				return this.honamiStoryAreaInfo_;
			}
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x0019BFF8 File Offset: 0x0019A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaInfoUpdateNotify);
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x0019C006 File Offset: 0x0019A206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryAreaInfo_.Equals(other.honamiStoryAreaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x0019C03C File Offset: 0x0019A23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryAreaInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x0019C070 File Offset: 0x0019A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x0019C07D File Offset: 0x0019A27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x0019C086 File Offset: 0x0019A286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryAreaInfo_.WriteTo(ref output, HonamiStoryAreaInfoUpdateNotify._repeated_honamiStoryAreaInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x0019C0B0 File Offset: 0x0019A2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryAreaInfo_.CalculateSize(HonamiStoryAreaInfoUpdateNotify._repeated_honamiStoryAreaInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x0019C0E9 File Offset: 0x0019A2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryAreaInfo_.Add(other.honamiStoryAreaInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x0019C117 File Offset: 0x0019A317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x0019C120 File Offset: 0x0019A320
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryAreaInfo_.AddEntriesFrom(ref input, HonamiStoryAreaInfoUpdateNotify._repeated_honamiStoryAreaInfo_codec);
				}
			}
		}

		// Token: 0x04004DC5 RID: 19909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DC6 RID: 19910
		public const int HonamiStoryAreaInfoFieldNumber = 13;

		// Token: 0x04004DC7 RID: 19911
		private static readonly FieldCodec<HonamiStoryAreaInfo> _repeated_honamiStoryAreaInfo_codec = FieldCodec.ForMessage<HonamiStoryAreaInfo>(106U, Aki.Protocol.HonamiStoryAreaInfo.Parser);

		// Token: 0x04004DC8 RID: 19912
		private readonly RepeatedField<HonamiStoryAreaInfo> honamiStoryAreaInfo_ = new RepeatedField<HonamiStoryAreaInfo>();
	}
}
