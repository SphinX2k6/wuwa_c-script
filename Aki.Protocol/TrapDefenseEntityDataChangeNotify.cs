using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001496 RID: 5270
	[NetMessage(EMessageId.TrapDefenseEntityDataChangeNotify)]
	public sealed class TrapDefenseEntityDataChangeNotify : IMessage<TrapDefenseEntityDataChangeNotify>, IMessage, IEquatable<TrapDefenseEntityDataChangeNotify>, IDeepCloneable<TrapDefenseEntityDataChangeNotify>, IBufferMessage
	{
		// Token: 0x0601BFAA RID: 114602 RVA: 0x004107FD File Offset: 0x0040E9FD
		[NullableContext(1)]
		public static TrapDefenseEntityDataChangeNotify Create()
		{
			return new TrapDefenseEntityDataChangeNotify();
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x0601BFAB RID: 114603 RVA: 0x00410804 File Offset: 0x0040EA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x0601BFAC RID: 114604 RVA: 0x00410807 File Offset: 0x0040EA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseEntityDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601BFAD RID: 114605 RVA: 0x0041080E File Offset: 0x0040EA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify()
		{
		}

		// Token: 0x0601BFAE RID: 114606 RVA: 0x00410818 File Offset: 0x0040EA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify(TrapDefenseEntityDataChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newComponentData_ = ((other.newComponentData_ != null) ? other.newComponentData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFAF RID: 114607 RVA: 0x00410864 File Offset: 0x0040EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify Clone()
		{
			return new TrapDefenseEntityDataChangeNotify(this);
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x0601BFB0 RID: 114608 RVA: 0x0041086C File Offset: 0x0040EA6C
		// (set) Token: 0x0601BFB1 RID: 114609 RVA: 0x00410874 File Offset: 0x0040EA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x0601BFB2 RID: 114610 RVA: 0x0041087D File Offset: 0x0040EA7D
		// (set) Token: 0x0601BFB3 RID: 114611 RVA: 0x00410885 File Offset: 0x0040EA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb NewComponentData
		{
			get
			{
				return this.newComponentData_;
			}
			set
			{
				this.newComponentData_ = value;
			}
		}

		// Token: 0x0601BFB4 RID: 114612 RVA: 0x0041088E File Offset: 0x0040EA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseEntityDataChangeNotify);
		}

		// Token: 0x0601BFB5 RID: 114613 RVA: 0x0041089C File Offset: 0x0040EA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseEntityDataChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.NewComponentData, other.NewComponentData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFB6 RID: 114614 RVA: 0x004108EC File Offset: 0x0040EAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.newComponentData_ != null)
			{
				num ^= this.NewComponentData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFB7 RID: 114615 RVA: 0x00410941 File Offset: 0x0040EB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFB8 RID: 114616 RVA: 0x0041094E File Offset: 0x0040EB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFB9 RID: 114617 RVA: 0x00410958 File Offset: 0x0040EB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFBA RID: 114618 RVA: 0x004109B4 File Offset: 0x0040EBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFBB RID: 114619 RVA: 0x00410A0C File Offset: 0x0040EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseEntityDataChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.newComponentData_ != null)
			{
				if (this.newComponentData_ == null)
				{
					this.NewComponentData = new TrapDefenseComponentPb();
				}
				this.NewComponentData.MergeFrom(other.NewComponentData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFBC RID: 114620 RVA: 0x00410A74 File Offset: 0x0040EC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFBD RID: 114621 RVA: 0x00410A80 File Offset: 0x0040EC80
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
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newComponentData_ == null)
						{
							this.NewComponentData = new TrapDefenseComponentPb();
						}
						input.ReadMessage(this.NewComponentData);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A227 RID: 41511
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A228 RID: 41512
		public const int EntityIdFieldNumber = 9;

		// Token: 0x0400A229 RID: 41513
		private long entityId_;

		// Token: 0x0400A22A RID: 41514
		public const int NewComponentDataFieldNumber = 14;

		// Token: 0x0400A22B RID: 41515
		private TrapDefenseComponentPb newComponentData_;
	}
}
