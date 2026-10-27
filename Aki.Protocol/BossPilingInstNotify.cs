using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C4 RID: 452
	[NetMessage(EMessageId.BossPilingInstNotify)]
	public sealed class BossPilingInstNotify : IMessage<BossPilingInstNotify>, IMessage, IEquatable<BossPilingInstNotify>, IDeepCloneable<BossPilingInstNotify>, IBufferMessage
	{
		// Token: 0x060033E9 RID: 13289 RVA: 0x00083237 File Offset: 0x00081437
		[NullableContext(1)]
		public static BossPilingInstNotify Create()
		{
			return new BossPilingInstNotify();
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x0008323E File Offset: 0x0008143E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00083241 File Offset: 0x00081441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingInstNotify.Descriptor;
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00083248 File Offset: 0x00081448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify()
		{
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0008325B File Offset: 0x0008145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify(BossPilingInstNotify other) : this()
		{
			this.bossPilingLevelId_ = other.bossPilingLevelId_;
			this.bossPilingBuffs_ = other.bossPilingBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00083291 File Offset: 0x00081491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify Clone()
		{
			return new BossPilingInstNotify(this);
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00083299 File Offset: 0x00081499
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x000832A1 File Offset: 0x000814A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossPilingLevelId
		{
			get
			{
				return this.bossPilingLevelId_;
			}
			set
			{
				this.bossPilingLevelId_ = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000832AA File Offset: 0x000814AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BossPilingBuffs
		{
			get
			{
				return this.bossPilingBuffs_;
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000832B2 File Offset: 0x000814B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingInstNotify);
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000832C0 File Offset: 0x000814C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingInstNotify other)
		{
			return other != null && (other == this || (this.BossPilingLevelId == other.BossPilingLevelId && this.BossPilingBuffs.Equals(other.BossPilingBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00083310 File Offset: 0x00081510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossPilingLevelId != 0)
			{
				num ^= this.BossPilingLevelId.GetHashCode();
			}
			num ^= this.BossPilingBuffs.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x0008335D File Offset: 0x0008155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x0008336A File Offset: 0x0008156A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00083374 File Offset: 0x00081574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossPilingLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BossPilingLevelId);
			}
			this.bossPilingBuffs_.WriteTo(ref output, BossPilingInstNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000833C4 File Offset: 0x000815C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossPilingLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossPilingLevelId);
			}
			num += this.bossPilingBuffs_.CalculateSize(BossPilingInstNotify._map_bossPilingBuffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00083418 File Offset: 0x00081618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingInstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossPilingLevelId != 0)
			{
				this.BossPilingLevelId = other.BossPilingLevelId;
			}
			this.bossPilingBuffs_.MergeFrom(other.bossPilingBuffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00083465 File Offset: 0x00081665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00083470 File Offset: 0x00081670
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bossPilingBuffs_.AddEntriesFrom(ref input, BossPilingInstNotify._map_bossPilingBuffs_codec);
					}
				}
				else
				{
					this.BossPilingLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029DD RID: 10717
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029DE RID: 10718
		public const int BossPilingLevelIdFieldNumber = 1;

		// Token: 0x040029DF RID: 10719
		private int bossPilingLevelId_;

		// Token: 0x040029E0 RID: 10720
		public const int BossPilingBuffsFieldNumber = 2;

		// Token: 0x040029E1 RID: 10721
		private static readonly MapField<int, int>.Codec _map_bossPilingBuffs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040029E2 RID: 10722
		private readonly MapField<int, int> bossPilingBuffs_ = new MapField<int, int>();
	}
}
