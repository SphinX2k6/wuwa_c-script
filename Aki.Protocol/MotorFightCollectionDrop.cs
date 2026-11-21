using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2B RID: 2603
	public sealed class MotorFightCollectionDrop : IMessage<MotorFightCollectionDrop>, IMessage, IEquatable<MotorFightCollectionDrop>, IDeepCloneable<MotorFightCollectionDrop>, IBufferMessage
	{
		// Token: 0x0600E3AB RID: 58283 RVA: 0x002151F3 File Offset: 0x002133F3
		[NullableContext(1)]
		public static MotorFightCollectionDrop Create()
		{
			return new MotorFightCollectionDrop();
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x002151FA File Offset: 0x002133FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightCollectionDrop> Parser
		{
			get
			{
				return MotorFightCollectionDrop._parser;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x00215201 File Offset: 0x00213401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x00215204 File Offset: 0x00213404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCollectionDrop.Descriptor;
			}
		}

		// Token: 0x0600E3AF RID: 58287 RVA: 0x0021520B File Offset: 0x0021340B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop()
		{
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x00215213 File Offset: 0x00213413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop(MotorFightCollectionDrop other) : this()
		{
			this.pos_ = other.pos_;
			this.collectionId_ = other.collectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00215244 File Offset: 0x00213444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop Clone()
		{
			return new MotorFightCollectionDrop(this);
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x0021524C File Offset: 0x0021344C
		// (set) Token: 0x0600E3B3 RID: 58291 RVA: 0x00215254 File Offset: 0x00213454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionPos Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x0021525D File Offset: 0x0021345D
		// (set) Token: 0x0600E3B5 RID: 58293 RVA: 0x00215265 File Offset: 0x00213465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CollectionId
		{
			get
			{
				return this.collectionId_;
			}
			set
			{
				this.collectionId_ = value;
			}
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x0021526E File Offset: 0x0021346E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCollectionDrop);
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x0021527C File Offset: 0x0021347C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCollectionDrop other)
		{
			return other != null && (other == this || (this.Pos == other.Pos && this.CollectionId == other.CollectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x002152BC File Offset: 0x002134BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.CollectionId != 0)
			{
				num ^= this.CollectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x0021531A File Offset: 0x0021351A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x00215327 File Offset: 0x00213527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00215330 File Offset: 0x00213530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != MotorFightCollectionPos.First)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Pos);
			}
			if (this.CollectionId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CollectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x00215388 File Offset: 0x00213588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this.CollectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CollectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x002153E0 File Offset: 0x002135E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightCollectionDrop other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Pos != MotorFightCollectionPos.First)
			{
				this.Pos = other.Pos;
			}
			if (other.CollectionId != 0)
			{
				this.CollectionId = other.CollectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x00215430 File Offset: 0x00213630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x0021543C File Offset: 0x0021363C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CollectionId = input.ReadInt32();
					}
				}
				else
				{
					this.Pos = (MotorFightCollectionPos)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D9B RID: 23963
		private static readonly MessageParser<MotorFightCollectionDrop> _parser = new MessageParser<MotorFightCollectionDrop>(() => new MotorFightCollectionDrop());

		// Token: 0x04005D9C RID: 23964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D9D RID: 23965
		public const int PosFieldNumber = 1;

		// Token: 0x04005D9E RID: 23966
		private MotorFightCollectionPos pos_;

		// Token: 0x04005D9F RID: 23967
		public const int CollectionIdFieldNumber = 2;

		// Token: 0x04005DA0 RID: 23968
		private int collectionId_;
	}
}
