using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035F RID: 863
	[NetMessage(EMessageId.DangoBrawlFighterAttrChangeNotify)]
	public sealed class DangoBrawlFighterAttrChangeNotify : IMessage<DangoBrawlFighterAttrChangeNotify>, IMessage, IEquatable<DangoBrawlFighterAttrChangeNotify>, IDeepCloneable<DangoBrawlFighterAttrChangeNotify>, IBufferMessage
	{
		// Token: 0x06005660 RID: 22112 RVA: 0x000D347A File Offset: 0x000D167A
		[NullableContext(1)]
		public static DangoBrawlFighterAttrChangeNotify Create()
		{
			return new DangoBrawlFighterAttrChangeNotify();
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x000D3481 File Offset: 0x000D1681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x000D3484 File Offset: 0x000D1684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFighterAttrChangeNotify.Descriptor;
			}
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x000D348B File Offset: 0x000D168B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify()
		{
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x000D349E File Offset: 0x000D169E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify(DangoBrawlFighterAttrChangeNotify other) : this()
		{
			this.fighterUId_ = other.fighterUId_;
			this.finalAttrs_ = other.finalAttrs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x000D34D4 File Offset: 0x000D16D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFighterAttrChangeNotify Clone()
		{
			return new DangoBrawlFighterAttrChangeNotify(this);
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06005666 RID: 22118 RVA: 0x000D34DC File Offset: 0x000D16DC
		// (set) Token: 0x06005667 RID: 22119 RVA: 0x000D34E4 File Offset: 0x000D16E4
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

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06005668 RID: 22120 RVA: 0x000D34ED File Offset: 0x000D16ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> FinalAttrs
		{
			get
			{
				return this.finalAttrs_;
			}
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x000D34F5 File Offset: 0x000D16F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFighterAttrChangeNotify);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x000D3504 File Offset: 0x000D1704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFighterAttrChangeNotify other)
		{
			return other != null && (other == this || (this.FighterUId == other.FighterUId && this.FinalAttrs.Equals(other.FinalAttrs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x000D3554 File Offset: 0x000D1754
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

		// Token: 0x0600566C RID: 22124 RVA: 0x000D35A1 File Offset: 0x000D17A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x000D35AE File Offset: 0x000D17AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x000D35B8 File Offset: 0x000D17B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FighterUId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FighterUId);
			}
			this.finalAttrs_.WriteTo(ref output, DangoBrawlFighterAttrChangeNotify._map_finalAttrs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x000D3608 File Offset: 0x000D1808
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

		// Token: 0x06005670 RID: 22128 RVA: 0x000D365C File Offset: 0x000D185C
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

		// Token: 0x06005671 RID: 22129 RVA: 0x000D36A9 File Offset: 0x000D18A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x000D36B4 File Offset: 0x000D18B4
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
				if (num != 80U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.finalAttrs_.AddEntriesFrom(ref input, DangoBrawlFighterAttrChangeNotify._map_finalAttrs_codec);
					}
				}
				else
				{
					this.FighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040034C5 RID: 13509
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034C6 RID: 13510
		public const int FighterUIdFieldNumber = 10;

		// Token: 0x040034C7 RID: 13511
		private int fighterUId_;

		// Token: 0x040034C8 RID: 13512
		public const int FinalAttrsFieldNumber = 14;

		// Token: 0x040034C9 RID: 13513
		private static readonly MapField<int, int>.Codec _map_finalAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x040034CA RID: 13514
		private readonly MapField<int, int> finalAttrs_ = new MapField<int, int>();
	}
}
