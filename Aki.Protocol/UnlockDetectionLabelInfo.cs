using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001485 RID: 5253
	public sealed class UnlockDetectionLabelInfo : IMessage<UnlockDetectionLabelInfo>, IMessage, IEquatable<UnlockDetectionLabelInfo>, IDeepCloneable<UnlockDetectionLabelInfo>, IBufferMessage
	{
		// Token: 0x0601BCC5 RID: 113861 RVA: 0x00405585 File Offset: 0x00403785
		[NullableContext(1)]
		public static UnlockDetectionLabelInfo Create()
		{
			return new UnlockDetectionLabelInfo();
		}

		// Token: 0x17005DB7 RID: 23991
		// (get) Token: 0x0601BCC6 RID: 113862 RVA: 0x0040558C File Offset: 0x0040378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x0601BCC7 RID: 113863 RVA: 0x0040558F File Offset: 0x0040378F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockDetectionLabelInfo.Descriptor;
			}
		}

		// Token: 0x0601BCC8 RID: 113864 RVA: 0x00405596 File Offset: 0x00403796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo()
		{
		}

		// Token: 0x0601BCC9 RID: 113865 RVA: 0x004055B4 File Offset: 0x004037B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo(UnlockDetectionLabelInfo other) : this()
		{
			this.unlockedGuideIds_ = other.unlockedGuideIds_.Clone();
			this.unlockedDetectionTextIds_ = other.unlockedDetectionTextIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCCA RID: 113866 RVA: 0x004055EF File Offset: 0x004037EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo Clone()
		{
			return new UnlockDetectionLabelInfo(this);
		}

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x0601BCCB RID: 113867 RVA: 0x004055F7 File Offset: 0x004037F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedGuideIds
		{
			get
			{
				return this.unlockedGuideIds_;
			}
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x0601BCCC RID: 113868 RVA: 0x004055FF File Offset: 0x004037FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedDetectionTextIds
		{
			get
			{
				return this.unlockedDetectionTextIds_;
			}
		}

		// Token: 0x0601BCCD RID: 113869 RVA: 0x00405607 File Offset: 0x00403807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockDetectionLabelInfo);
		}

		// Token: 0x0601BCCE RID: 113870 RVA: 0x00405618 File Offset: 0x00403818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockDetectionLabelInfo other)
		{
			return other != null && (other == this || (this.unlockedGuideIds_.Equals(other.unlockedGuideIds_) && this.unlockedDetectionTextIds_.Equals(other.unlockedDetectionTextIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCCF RID: 113871 RVA: 0x0040566C File Offset: 0x0040386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedGuideIds_.GetHashCode();
			num ^= this.unlockedDetectionTextIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCD0 RID: 113872 RVA: 0x004056AE File Offset: 0x004038AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCD1 RID: 113873 RVA: 0x004056BB File Offset: 0x004038BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCD2 RID: 113874 RVA: 0x004056C4 File Offset: 0x004038C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedGuideIds_.WriteTo(ref output, UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
			this.unlockedDetectionTextIds_.WriteTo(ref output, UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCD3 RID: 113875 RVA: 0x004056FC File Offset: 0x004038FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedGuideIds_.CalculateSize(UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
			num += this.unlockedDetectionTextIds_.CalculateSize(UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCD4 RID: 113876 RVA: 0x00405748 File Offset: 0x00403948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockDetectionLabelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedGuideIds_.Add(other.unlockedGuideIds_);
			this.unlockedDetectionTextIds_.Add(other.unlockedDetectionTextIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCD5 RID: 113877 RVA: 0x00405787 File Offset: 0x00403987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCD6 RID: 113878 RVA: 0x00405790 File Offset: 0x00403990
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.unlockedGuideIds_.AddEntriesFrom(ref input, UnlockDetectionLabelInfo._repeated_unlockedGuideIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.unlockedDetectionTextIds_.AddEntriesFrom(ref input, UnlockDetectionLabelInfo._repeated_unlockedDetectionTextIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009FF5 RID: 40949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FF6 RID: 40950
		public const int UnlockedGuideIdsFieldNumber = 1;

		// Token: 0x04009FF7 RID: 40951
		private static readonly FieldCodec<int> _repeated_unlockedGuideIds_codec = FieldCodec.ForSInt32(10U);

		// Token: 0x04009FF8 RID: 40952
		private readonly RepeatedField<int> unlockedGuideIds_ = new RepeatedField<int>();

		// Token: 0x04009FF9 RID: 40953
		public const int UnlockedDetectionTextIdsFieldNumber = 2;

		// Token: 0x04009FFA RID: 40954
		private static readonly FieldCodec<int> _repeated_unlockedDetectionTextIds_codec = FieldCodec.ForSInt32(18U);

		// Token: 0x04009FFB RID: 40955
		private readonly RepeatedField<int> unlockedDetectionTextIds_ = new RepeatedField<int>();
	}
}
