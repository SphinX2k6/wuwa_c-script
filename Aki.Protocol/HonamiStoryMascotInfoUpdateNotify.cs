using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078E RID: 1934
	[NetMessage(EMessageId.HonamiStoryMascotInfoUpdateNotify)]
	public sealed class HonamiStoryMascotInfoUpdateNotify : IMessage<HonamiStoryMascotInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryMascotInfoUpdateNotify>, IDeepCloneable<HonamiStoryMascotInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AEA3 RID: 44707 RVA: 0x001A38EF File Offset: 0x001A1AEF
		[NullableContext(1)]
		public static HonamiStoryMascotInfoUpdateNotify Create()
		{
			return new HonamiStoryMascotInfoUpdateNotify();
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600AEA4 RID: 44708 RVA: 0x001A38F6 File Offset: 0x001A1AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600AEA5 RID: 44709 RVA: 0x001A38F9 File Offset: 0x001A1AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x001A3900 File Offset: 0x001A1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify()
		{
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x001A3913 File Offset: 0x001A1B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify(HonamiStoryMascotInfoUpdateNotify other) : this()
		{
			this.honamiStoryMascotInfos_ = other.honamiStoryMascotInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x001A393D File Offset: 0x001A1B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfoUpdateNotify Clone()
		{
			return new HonamiStoryMascotInfoUpdateNotify(this);
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x001A3945 File Offset: 0x001A1B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryMascotInfo> HonamiStoryMascotInfos
		{
			get
			{
				return this.honamiStoryMascotInfos_;
			}
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x001A394D File Offset: 0x001A1B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotInfoUpdateNotify);
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x001A395B File Offset: 0x001A1B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryMascotInfos_.Equals(other.honamiStoryMascotInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEAC RID: 44716 RVA: 0x001A3990 File Offset: 0x001A1B90
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

		// Token: 0x0600AEAD RID: 44717 RVA: 0x001A39C4 File Offset: 0x001A1BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x001A39D1 File Offset: 0x001A1BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x001A39DA File Offset: 0x001A1BDA
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

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x001A3A04 File Offset: 0x001A1C04
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

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x001A3A3D File Offset: 0x001A1C3D
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

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x001A3A6B File Offset: 0x001A1C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x001A3A74 File Offset: 0x001A1C74
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
					this.honamiStoryMascotInfos_.AddEntriesFrom(ref input, HonamiStoryMascotInfoUpdateNotify._repeated_honamiStoryMascotInfos_codec);
				}
			}
		}

		// Token: 0x04004ECB RID: 20171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ECC RID: 20172
		public const int HonamiStoryMascotInfosFieldNumber = 1;

		// Token: 0x04004ECD RID: 20173
		private static readonly FieldCodec<HonamiStoryMascotInfo> _repeated_honamiStoryMascotInfos_codec = FieldCodec.ForMessage<HonamiStoryMascotInfo>(10U, HonamiStoryMascotInfo.Parser);

		// Token: 0x04004ECE RID: 20174
		private readonly RepeatedField<HonamiStoryMascotInfo> honamiStoryMascotInfos_ = new RepeatedField<HonamiStoryMascotInfo>();
	}
}
