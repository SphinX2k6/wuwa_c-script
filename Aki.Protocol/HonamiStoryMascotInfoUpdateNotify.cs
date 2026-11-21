using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077A RID: 1914
	[NetMessage(EMessageId.HonamiStoryMascotInfoUpdateNotify)]
	public sealed class HonamiStoryMascotInfoUpdateNotify : IMessage<HonamiStoryMascotInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryMascotInfoUpdateNotify>, IDeepCloneable<HonamiStoryMascotInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AD4D RID: 44365 RVA: 0x001A0EC7 File Offset: 0x0019F0C7
		[NullableContext(1)]
		public static HonamiStoryMascotInfoUpdateNotify Create()
		{
			return new HonamiStoryMascotInfoUpdateNotify();
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600AD4E RID: 44366 RVA: 0x001A0ECE File Offset: 0x0019F0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600AD4F RID: 44367 RVA: 0x001A0ED1 File Offset: 0x0019F0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x001A0ED8 File Offset: 0x0019F0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify()
		{
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x001A0EEB File Offset: 0x0019F0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify(HonamiStoryMascotInfoUpdateNotify other) : this()
		{
			this.honamiStoryMascotInfos_ = other.honamiStoryMascotInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x001A0F15 File Offset: 0x0019F115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify Clone()
		{
			return new HonamiStoryMascotInfoUpdateNotify(this);
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600AD53 RID: 44371 RVA: 0x001A0F1D File Offset: 0x0019F11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryMascotInfo> HonamiStoryMascotInfos
		{
			get
			{
				return this.honamiStoryMascotInfos_;
			}
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x001A0F25 File Offset: 0x0019F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotInfoUpdateNotify);
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x001A0F33 File Offset: 0x0019F133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryMascotInfos_.Equals(other.honamiStoryMascotInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x001A0F68 File Offset: 0x0019F168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryMascotInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x001A0F9C File Offset: 0x0019F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x001A0FA9 File Offset: 0x0019F1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x001A0FB2 File Offset: 0x0019F1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryMascotInfos_.WriteTo(ref output, HonamiStoryMascotInfoUpdateNotify._repeated_honamiStoryMascotInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x001A0FDC File Offset: 0x0019F1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryMascotInfos_.CalculateSize(HonamiStoryMascotInfoUpdateNotify._repeated_honamiStoryMascotInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x001A1015 File Offset: 0x0019F215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryMascotInfos_.Add(other.honamiStoryMascotInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x001A1043 File Offset: 0x0019F243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x001A104C File Offset: 0x0019F24C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryMascotInfos_.AddEntriesFrom(ref input, HonamiStoryMascotInfoUpdateNotify._repeated_honamiStoryMascotInfos_codec);
				}
			}
		}

		// Token: 0x04004EC4 RID: 20164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC5 RID: 20165
		public const int HonamiStoryMascotInfosFieldNumber = 6;

		// Token: 0x04004EC6 RID: 20166
		private static readonly FieldCodec<HonamiStoryMascotInfo> _repeated_honamiStoryMascotInfos_codec = FieldCodec.ForMessage<HonamiStoryMascotInfo>(50U, HonamiStoryMascotInfo.Parser);

		// Token: 0x04004EC7 RID: 20167
		private readonly RepeatedField<HonamiStoryMascotInfo> honamiStoryMascotInfos_ = new RepeatedField<HonamiStoryMascotInfo>();
	}
}
