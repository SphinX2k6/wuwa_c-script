using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000357 RID: 855
	[NetMessage(EMessageId.DangoBrawlFighterAttrChangeNotify)]
	public sealed class DangoBrawlFighterAttrChangeNotify : IMessage<DangoBrawlFighterAttrChangeNotify>, IMessage, IEquatable<DangoBrawlFighterAttrChangeNotify>, IDeepCloneable<DangoBrawlFighterAttrChangeNotify>, IBufferMessage
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x000D0DEE File Offset: 0x000CEFEE
		[NullableContext(1)]
		public static DangoBrawlFighterAttrChangeNotify Create()
		{
			return new DangoBrawlFighterAttrChangeNotify();
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x000D0DF5 File Offset: 0x000CEFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x000D0DF8 File Offset: 0x000CEFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFighterAttrChangeNotify.Descriptor;
			}
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x000D0DFF File Offset: 0x000CEFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify()
		{
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x000D0E12 File Offset: 0x000CF012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify(DangoBrawlFighterAttrChangeNotify other) : this()
		{
			this.fighterUId_ = other.fighterUId_;
			this.finalAttrs_ = other.finalAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x000D0E48 File Offset: 0x000CF048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify Clone()
		{
			return new DangoBrawlFighterAttrChangeNotify(this);
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x000D0E50 File Offset: 0x000CF050
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x000D0E58 File Offset: 0x000CF058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
			set
			{
				this.fighterUId_ = value;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x000D0E61 File Offset: 0x000CF061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> FinalAttrs
		{
			get
			{
				return this.finalAttrs_;
			}
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x000D0E69 File Offset: 0x000CF069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFighterAttrChangeNotify);
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x000D0E78 File Offset: 0x000CF078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFighterAttrChangeNotify other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.FinalAttrs.Equals(other.FinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x000D0EC8 File Offset: 0x000CF0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FighterUId != 0)
			{
				num ^= this.FighterUId.GetHashCode();
			}
			num ^= this.FinalAttrs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x000D0F15 File Offset: 0x000CF115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x000D0F22 File Offset: 0x000CF122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x000D0F2C File Offset: 0x000CF12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finalAttrs_.WriteTo(ref output, DangoBrawlFighterAttrChangeNotify._map_finalAttrs_codec);
			if (this.FighterUId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FighterUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x000D0F7C File Offset: 0x000CF17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FighterUId);
			}
			num += this.finalAttrs_.CalculateSize(DangoBrawlFighterAttrChangeNotify._map_finalAttrs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x000D0FD0 File Offset: 0x000CF1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFighterAttrChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FighterUId != 0)
			{
				this.FighterUId = other.FighterUId;
			}
			this.finalAttrs_.MergeFrom(other.finalAttrs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x000D101D File Offset: 0x000CF21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x000D1028 File Offset: 0x000CF228
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FighterUId = input.ReadInt32();
					}
				}
				else
				{
					this.finalAttrs_.AddEntriesFrom(ref input, DangoBrawlFighterAttrChangeNotify._map_finalAttrs_codec);
				}
			}
		}

		// Token: 0x04003429 RID: 13353
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400342A RID: 13354
		public const int FighterUIdFieldNumber = 14;

		// Token: 0x0400342B RID: 13355
		private int fighterUId_;

		// Token: 0x0400342C RID: 13356
		public const int FinalAttrsFieldNumber = 13;

		// Token: 0x0400342D RID: 13357
		private static readonly MapField<int, int>.Codec _map_finalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x0400342E RID: 13358
		private readonly MapField<int, int> finalAttrs_ = new MapField<int, int>();
	}
}
