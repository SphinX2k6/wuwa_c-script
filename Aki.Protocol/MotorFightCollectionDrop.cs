using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3C RID: 2620
	public sealed class MotorFightCollectionDrop : IMessage<MotorFightCollectionDrop>, IMessage, IEquatable<MotorFightCollectionDrop>, IDeepCloneable<MotorFightCollectionDrop>, IBufferMessage
	{
		// Token: 0x0600E4C5 RID: 58565 RVA: 0x002173E3 File Offset: 0x002155E3
		[NullableContext(1)]
		public static MotorFightCollectionDrop Create()
		{
			return new MotorFightCollectionDrop();
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600E4C6 RID: 58566 RVA: 0x002173EA File Offset: 0x002155EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightCollectionDrop> Parser
		{
			get
			{
				return MotorFightCollectionDrop._parser;
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x002173F1 File Offset: 0x002155F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x002173F4 File Offset: 0x002155F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCollectionDrop.Descriptor;
			}
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x002173FB File Offset: 0x002155FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop()
		{
		}

		// Token: 0x0600E4CA RID: 58570 RVA: 0x00217403 File Offset: 0x00215603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop(MotorFightCollectionDrop other) : this()
		{
			this.pos_ = other.pos_;
			this.collectionId_ = other.collectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4CB RID: 58571 RVA: 0x00217434 File Offset: 0x00215634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionDrop Clone()
		{
			return new MotorFightCollectionDrop(this);
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x0021743C File Offset: 0x0021563C
		// (set) Token: 0x0600E4CD RID: 58573 RVA: 0x00217444 File Offset: 0x00215644
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

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600E4CE RID: 58574 RVA: 0x0021744D File Offset: 0x0021564D
		// (set) Token: 0x0600E4CF RID: 58575 RVA: 0x00217455 File Offset: 0x00215655
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

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x0021745E File Offset: 0x0021565E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCollectionDrop);
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x0021746C File Offset: 0x0021566C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCollectionDrop other)
		{
			return other != null && (other == this || (this.Pos == other.Pos && this.CollectionId == other.CollectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x002174AC File Offset: 0x002156AC
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

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x0021750A File Offset: 0x0021570A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x00217517 File Offset: 0x00215717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4D5 RID: 58581 RVA: 0x00217520 File Offset: 0x00215720
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

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00217578 File Offset: 0x00215778
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

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x002175D0 File Offset: 0x002157D0
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

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00217620 File Offset: 0x00215820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x0021762C File Offset: 0x0021582C
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

		// Token: 0x04005D92 RID: 23954
		private static readonly MessageParser<MotorFightCollectionDrop> _parser = new MessageParser<MotorFightCollectionDrop>(() => new MotorFightCollectionDrop());

		// Token: 0x04005D93 RID: 23955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D94 RID: 23956
		public const int PosFieldNumber = 1;

		// Token: 0x04005D95 RID: 23957
		private MotorFightCollectionPos pos_;

		// Token: 0x04005D96 RID: 23958
		public const int CollectionIdFieldNumber = 2;

		// Token: 0x04005D97 RID: 23959
		private int collectionId_;
	}
}
