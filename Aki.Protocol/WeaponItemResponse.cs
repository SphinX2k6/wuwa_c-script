using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001568 RID: 5480
	[NetMessage(EMessageId.WeaponItemResponse)]
	public sealed class WeaponItemResponse : IMessage<WeaponItemResponse>, IMessage, IEquatable<WeaponItemResponse>, IDeepCloneable<WeaponItemResponse>, IBufferMessage
	{
		// Token: 0x0601D05E RID: 118878 RVA: 0x004343FA File Offset: 0x004325FA
		[NullableContext(1)]
		public static WeaponItemResponse Create()
		{
			return new WeaponItemResponse();
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x0601D05F RID: 118879 RVA: 0x00434401 File Offset: 0x00432601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x0601D060 RID: 118880 RVA: 0x00434404 File Offset: 0x00432604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemResponse.Descriptor;
			}
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x0043440B File Offset: 0x0043260B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse()
		{
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x0043441E File Offset: 0x0043261E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse(WeaponItemResponse other) : this()
		{
			this.weaponItemList_ = other.weaponItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x00434448 File Offset: 0x00432648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse Clone()
		{
			return new WeaponItemResponse(this);
		}

		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x0601D064 RID: 118884 RVA: 0x00434450 File Offset: 0x00432650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponItem> WeaponItemList
		{
			get
			{
				return this.weaponItemList_;
			}
		}

		// Token: 0x0601D065 RID: 118885 RVA: 0x00434458 File Offset: 0x00432658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemResponse);
		}

		// Token: 0x0601D066 RID: 118886 RVA: 0x00434466 File Offset: 0x00432666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemResponse other)
		{
			return other != null && (other == this || (this.weaponItemList_.Equals(other.weaponItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D067 RID: 118887 RVA: 0x0043449C File Offset: 0x0043269C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D068 RID: 118888 RVA: 0x004344D0 File Offset: 0x004326D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D069 RID: 118889 RVA: 0x004344DD File Offset: 0x004326DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D06A RID: 118890 RVA: 0x004344E6 File Offset: 0x004326E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponItemList_.WriteTo(ref output, WeaponItemResponse._repeated_weaponItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x00434510 File Offset: 0x00432710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponItemList_.CalculateSize(WeaponItemResponse._repeated_weaponItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x00434549 File Offset: 0x00432749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponItemList_.Add(other.weaponItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x00434577 File Offset: 0x00432777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D06E RID: 118894 RVA: 0x00434580 File Offset: 0x00432780
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
					this.weaponItemList_.AddEntriesFrom(ref input, WeaponItemResponse._repeated_weaponItemList_codec);
				}
			}
		}

		// Token: 0x0400A6C2 RID: 42690
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6C3 RID: 42691
		public const int WeaponItemListFieldNumber = 10;

		// Token: 0x0400A6C4 RID: 42692
		private static readonly FieldCodec<WeaponItem> _repeated_weaponItemList_codec = FieldCodec.ForMessage<WeaponItem>(82U, WeaponItem.Parser);

		// Token: 0x0400A6C5 RID: 42693
		private readonly RepeatedField<WeaponItem> weaponItemList_ = new RepeatedField<WeaponItem>();
	}
}
