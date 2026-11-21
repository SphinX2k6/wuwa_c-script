using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C8 RID: 456
	[NetMessage(EMessageId.BossPilingInstNotify)]
	public sealed class BossPilingInstNotify : IMessage<BossPilingInstNotify>, IMessage, IEquatable<BossPilingInstNotify>, IDeepCloneable<BossPilingInstNotify>, IBufferMessage
	{
		// Token: 0x06003476 RID: 13430 RVA: 0x000849A7 File Offset: 0x00082BA7
		[NullableContext(1)]
		public static BossPilingInstNotify Create()
		{
			return new BossPilingInstNotify();
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x000849AE File Offset: 0x00082BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x000849B1 File Offset: 0x00082BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingInstNotify.Descriptor;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000849B8 File Offset: 0x00082BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify()
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x000849CB File Offset: 0x00082BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify(BossPilingInstNotify other) : this()
		{
			this.bossPilingLevelId_ = other.bossPilingLevelId_;
			this.bossPilingBuffs_ = other.bossPilingBuffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00084A01 File Offset: 0x00082C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingInstNotify Clone()
		{
			return new BossPilingInstNotify(this);
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x00084A09 File Offset: 0x00082C09
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x00084A11 File Offset: 0x00082C11
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x00084A1A File Offset: 0x00082C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BossPilingBuffs
		{
			get
			{
				return this.bossPilingBuffs_;
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00084A22 File Offset: 0x00082C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingInstNotify);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00084A30 File Offset: 0x00082C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingInstNotify other)
		{
			return other != null && (other == this || (this.BossPilingLevelId == other.BossPilingLevelId && this.BossPilingBuffs.Equals(other.BossPilingBuffs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00084A80 File Offset: 0x00082C80
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

		// Token: 0x06003482 RID: 13442 RVA: 0x00084ACD File Offset: 0x00082CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00084ADA File Offset: 0x00082CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00084AE4 File Offset: 0x00082CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossPilingBuffs_.WriteTo(ref output, BossPilingInstNotify._map_bossPilingBuffs_codec);
			if (this.BossPilingLevelId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BossPilingLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00084B34 File Offset: 0x00082D34
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

		// Token: 0x06003486 RID: 13446 RVA: 0x00084B88 File Offset: 0x00082D88
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

		// Token: 0x06003487 RID: 13447 RVA: 0x00084BD5 File Offset: 0x00082DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00084BE0 File Offset: 0x00082DE0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BossPilingLevelId = input.ReadInt32();
					}
				}
				else
				{
					this.bossPilingBuffs_.AddEntriesFrom(ref input, BossPilingInstNotify._map_bossPilingBuffs_codec);
				}
			}
		}

		// Token: 0x04002A58 RID: 10840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A59 RID: 10841
		public const int BossPilingLevelIdFieldNumber = 12;

		// Token: 0x04002A5A RID: 10842
		private int bossPilingLevelId_;

		// Token: 0x04002A5B RID: 10843
		public const int BossPilingBuffsFieldNumber = 1;

		// Token: 0x04002A5C RID: 10844
		private static readonly MapField<int, int>.Codec _map_bossPilingBuffs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04002A5D RID: 10845
		private readonly MapField<int, int> bossPilingBuffs_ = new MapField<int, int>();
	}
}
