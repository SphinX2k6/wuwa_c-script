using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000755 RID: 1877
	[NetMessage(EMessageId.HonamiStoryBagInfoUpdateNotify)]
	public sealed class HonamiStoryBagInfoUpdateNotify : IMessage<HonamiStoryBagInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryBagInfoUpdateNotify>, IDeepCloneable<HonamiStoryBagInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AA44 RID: 43588 RVA: 0x0019A2EE File Offset: 0x001984EE
		[NullableContext(1)]
		public static HonamiStoryBagInfoUpdateNotify Create()
		{
			return new HonamiStoryBagInfoUpdateNotify();
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600AA45 RID: 43589 RVA: 0x0019A2F5 File Offset: 0x001984F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x0019A2F8 File Offset: 0x001984F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x0019A2FF File Offset: 0x001984FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify()
		{
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x0019A312 File Offset: 0x00198512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify(HonamiStoryBagInfoUpdateNotify other) : this()
		{
			this.honamiStoryBagInfos_ = other.honamiStoryBagInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x0019A33C File Offset: 0x0019853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagInfoUpdateNotify Clone()
		{
			return new HonamiStoryBagInfoUpdateNotify(this);
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600AA4A RID: 43594 RVA: 0x0019A344 File Offset: 0x00198544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagInfo> HonamiStoryBagInfos
		{
			get
			{
				return this.honamiStoryBagInfos_;
			}
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x0019A34C File Offset: 0x0019854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagInfoUpdateNotify);
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x0019A35A File Offset: 0x0019855A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryBagInfos_.Equals(other.honamiStoryBagInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x0019A390 File Offset: 0x00198590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryBagInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x0019A3C4 File Offset: 0x001985C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x0019A3D1 File Offset: 0x001985D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x0019A3DA File Offset: 0x001985DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryBagInfos_.WriteTo(ref output, HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x0019A404 File Offset: 0x00198604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryBagInfos_.CalculateSize(HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x0019A43D File Offset: 0x0019863D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryBagInfos_.Add(other.honamiStoryBagInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x0019A46B File Offset: 0x0019866B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x0019A474 File Offset: 0x00198674
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryBagInfos_.AddEntriesFrom(ref input, HonamiStoryBagInfoUpdateNotify._repeated_honamiStoryBagInfos_codec);
				}
			}
		}

		// Token: 0x04004DDB RID: 19931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DDC RID: 19932
		public const int HonamiStoryBagInfosFieldNumber = 10;

		// Token: 0x04004DDD RID: 19933
		private static readonly FieldCodec<HonamiStoryBagInfo> _repeated_honamiStoryBagInfos_codec = FieldCodec.ForMessage<HonamiStoryBagInfo>(82U, HonamiStoryBagInfo.Parser);

		// Token: 0x04004DDE RID: 19934
		private readonly RepeatedField<HonamiStoryBagInfo> honamiStoryBagInfos_ = new RepeatedField<HonamiStoryBagInfo>();
	}
}
