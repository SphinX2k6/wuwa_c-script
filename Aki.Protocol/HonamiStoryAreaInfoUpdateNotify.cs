using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074F RID: 1871
	[NetMessage(EMessageId.HonamiStoryAreaInfoUpdateNotify)]
	public sealed class HonamiStoryAreaInfoUpdateNotify : IMessage<HonamiStoryAreaInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryAreaInfoUpdateNotify>, IDeepCloneable<HonamiStoryAreaInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A9D1 RID: 43473 RVA: 0x00199572 File Offset: 0x00197772
		[NullableContext(1)]
		public static HonamiStoryAreaInfoUpdateNotify Create()
		{
			return new HonamiStoryAreaInfoUpdateNotify();
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x00199579 File Offset: 0x00197779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x0600A9D3 RID: 43475 RVA: 0x0019957C File Offset: 0x0019777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x00199583 File Offset: 0x00197783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify()
		{
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x00199596 File Offset: 0x00197796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify(HonamiStoryAreaInfoUpdateNotify other) : this()
		{
			this.honamiStoryAreaInfo_ = other.honamiStoryAreaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x001995C0 File Offset: 0x001977C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfoUpdateNotify Clone()
		{
			return new HonamiStoryAreaInfoUpdateNotify(this);
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x001995C8 File Offset: 0x001977C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryAreaInfo> HonamiStoryAreaInfo
		{
			get
			{
				return this.honamiStoryAreaInfo_;
			}
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x001995D0 File Offset: 0x001977D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaInfoUpdateNotify);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x001995DE File Offset: 0x001977DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryAreaInfo_.Equals(other.honamiStoryAreaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x00199614 File Offset: 0x00197814
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

		// Token: 0x0600A9DB RID: 43483 RVA: 0x00199648 File Offset: 0x00197848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x00199655 File Offset: 0x00197855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x0019965E File Offset: 0x0019785E
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

		// Token: 0x0600A9DE RID: 43486 RVA: 0x00199688 File Offset: 0x00197888
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

		// Token: 0x0600A9DF RID: 43487 RVA: 0x001996C1 File Offset: 0x001978C1
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

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x001996EF File Offset: 0x001978EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x001996F8 File Offset: 0x001978F8
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
					this.honamiStoryAreaInfo_.AddEntriesFrom(ref input, HonamiStoryAreaInfoUpdateNotify._repeated_honamiStoryAreaInfo_codec);
				}
			}
		}

		// Token: 0x04004DBE RID: 19902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBF RID: 19903
		public const int HonamiStoryAreaInfoFieldNumber = 11;

		// Token: 0x04004DC0 RID: 19904
		private static readonly FieldCodec<HonamiStoryAreaInfo> _repeated_honamiStoryAreaInfo_codec = FieldCodec.ForMessage<HonamiStoryAreaInfo>(90U, Aki.Protocol.HonamiStoryAreaInfo.Parser);

		// Token: 0x04004DC1 RID: 19905
		private readonly RepeatedField<HonamiStoryAreaInfo> honamiStoryAreaInfo_ = new RepeatedField<HonamiStoryAreaInfo>();
	}
}
