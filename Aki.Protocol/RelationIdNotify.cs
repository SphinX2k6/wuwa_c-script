using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDC RID: 3804
	[NetMessage(EMessageId.RelationIdNotify)]
	public sealed class RelationIdNotify : IMessage<RelationIdNotify>, IMessage, IEquatable<RelationIdNotify>, IDeepCloneable<RelationIdNotify>, IBufferMessage
	{
		// Token: 0x0601469F RID: 83615 RVA: 0x002F7F3D File Offset: 0x002F613D
		[NullableContext(1)]
		public static RelationIdNotify Create()
		{
			return new RelationIdNotify();
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x060146A0 RID: 83616 RVA: 0x002F7F44 File Offset: 0x002F6144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x060146A1 RID: 83617 RVA: 0x002F7F47 File Offset: 0x002F6147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelationIdNotify.Descriptor;
			}
		}

		// Token: 0x060146A2 RID: 83618 RVA: 0x002F7F4E File Offset: 0x002F614E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify()
		{
		}

		// Token: 0x060146A3 RID: 83619 RVA: 0x002F7F58 File Offset: 0x002F6158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify(RelationIdNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.relationId_ = other.relationId_;
			this.istId_ = other.istId_;
			this.matchIndex_ = other.matchIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146A4 RID: 83620 RVA: 0x002F7FAC File Offset: 0x002F61AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelationIdNotify Clone()
		{
			return new RelationIdNotify(this);
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x060146A5 RID: 83621 RVA: 0x002F7FB4 File Offset: 0x002F61B4
		// (set) Token: 0x060146A6 RID: 83622 RVA: 0x002F7FBC File Offset: 0x002F61BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x060146A7 RID: 83623 RVA: 0x002F7FC5 File Offset: 0x002F61C5
		// (set) Token: 0x060146A8 RID: 83624 RVA: 0x002F7FCD File Offset: 0x002F61CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RelationId
		{
			get
			{
				return this.relationId_;
			}
			set
			{
				this.relationId_ = value;
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x060146A9 RID: 83625 RVA: 0x002F7FD6 File Offset: 0x002F61D6
		// (set) Token: 0x060146AA RID: 83626 RVA: 0x002F7FDE File Offset: 0x002F61DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IstId
		{
			get
			{
				return this.istId_;
			}
			set
			{
				this.istId_ = value;
			}
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x060146AB RID: 83627 RVA: 0x002F7FE7 File Offset: 0x002F61E7
		// (set) Token: 0x060146AC RID: 83628 RVA: 0x002F7FEF File Offset: 0x002F61EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MatchIndex
		{
			get
			{
				return this.matchIndex_;
			}
			set
			{
				this.matchIndex_ = value;
			}
		}

		// Token: 0x060146AD RID: 83629 RVA: 0x002F7FF8 File Offset: 0x002F61F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelationIdNotify);
		}

		// Token: 0x060146AE RID: 83630 RVA: 0x002F8008 File Offset: 0x002F6208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelationIdNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.RelationId == other.RelationId && this.IstId == other.IstId && this.MatchIndex == other.MatchIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146AF RID: 83631 RVA: 0x002F8074 File Offset: 0x002F6274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.RelationId != 0)
			{
				num ^= this.RelationId.GetHashCode();
			}
			if (this.IstId != 0)
			{
				num ^= this.IstId.GetHashCode();
			}
			if (this.MatchIndex != 0)
			{
				num ^= this.MatchIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146B0 RID: 83632 RVA: 0x002F80FE File Offset: 0x002F62FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146B1 RID: 83633 RVA: 0x002F810B File Offset: 0x002F630B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146B2 RID: 83634 RVA: 0x002F8114 File Offset: 0x002F6314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.RelationId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RelationId);
			}
			if (this.MatchIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MatchIndex);
			}
			if (this.IstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146B3 RID: 83635 RVA: 0x002F81A4 File Offset: 0x002F63A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.RelationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RelationId);
			}
			if (this.IstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IstId);
			}
			if (this.MatchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MatchIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146B4 RID: 83636 RVA: 0x002F822C File Offset: 0x002F642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelationIdNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.RelationId != 0)
			{
				this.RelationId = other.RelationId;
			}
			if (other.IstId != 0)
			{
				this.IstId = other.IstId;
			}
			if (other.MatchIndex != 0)
			{
				this.MatchIndex = other.MatchIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146B5 RID: 83637 RVA: 0x002F82A4 File Offset: 0x002F64A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146B6 RID: 83638 RVA: 0x002F82B0 File Offset: 0x002F64B0
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
				if (num <= 72U)
				{
					if (num == 8U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RelationId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.MatchIndex = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007C52 RID: 31826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C53 RID: 31827
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x04007C54 RID: 31828
		private int entityConfigId_;

		// Token: 0x04007C55 RID: 31829
		public const int RelationIdFieldNumber = 9;

		// Token: 0x04007C56 RID: 31830
		private int relationId_;

		// Token: 0x04007C57 RID: 31831
		public const int IstIdFieldNumber = 14;

		// Token: 0x04007C58 RID: 31832
		private int istId_;

		// Token: 0x04007C59 RID: 31833
		public const int MatchIndexFieldNumber = 13;

		// Token: 0x04007C5A RID: 31834
		private int matchIndex_;
	}
}
