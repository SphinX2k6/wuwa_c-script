using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000711 RID: 1809
	[NetMessage(EMessageId.GravityFlipUpdateTypeNotify)]
	public sealed class GravityFlipUpdateTypeNotify : IMessage<GravityFlipUpdateTypeNotify>, IMessage, IEquatable<GravityFlipUpdateTypeNotify>, IDeepCloneable<GravityFlipUpdateTypeNotify>, IBufferMessage
	{
		// Token: 0x0600A484 RID: 42116 RVA: 0x0018D218 File Offset: 0x0018B418
		[NullableContext(1)]
		public static GravityFlipUpdateTypeNotify Create()
		{
			return new GravityFlipUpdateTypeNotify();
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x0018D21F File Offset: 0x0018B41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600A486 RID: 42118 RVA: 0x0018D222 File Offset: 0x0018B422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipUpdateTypeNotify.Descriptor;
			}
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x0018D229 File Offset: 0x0018B429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify()
		{
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x0018D231 File Offset: 0x0018B431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify(GravityFlipUpdateTypeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newGravityFlipType_ = other.newGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x0018D262 File Offset: 0x0018B462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify Clone()
		{
			return new GravityFlipUpdateTypeNotify(this);
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x0018D26A File Offset: 0x0018B46A
		// (set) Token: 0x0600A48B RID: 42123 RVA: 0x0018D272 File Offset: 0x0018B472
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

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600A48C RID: 42124 RVA: 0x0018D27B File Offset: 0x0018B47B
		// (set) Token: 0x0600A48D RID: 42125 RVA: 0x0018D283 File Offset: 0x0018B483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType NewGravityFlipType
		{
			get
			{
				return this.newGravityFlipType_;
			}
			set
			{
				this.newGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x0018D28C File Offset: 0x0018B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipUpdateTypeNotify);
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x0018D29A File Offset: 0x0018B49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipUpdateTypeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NewGravityFlipType == other.NewGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x0018D2D8 File Offset: 0x0018B4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.NewGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x0018D336 File Offset: 0x0018B536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x0018D343 File Offset: 0x0018B543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x0018D34C File Offset: 0x0018B54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.NewGravityFlipType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x0018D3A8 File Offset: 0x0018B5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NewGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x0018D400 File Offset: 0x0018B600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipUpdateTypeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				this.NewGravityFlipType = other.NewGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x0018D450 File Offset: 0x0018B650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x0018D45C File Offset: 0x0018B65C
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
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.NewGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BD1 RID: 19409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD2 RID: 19410
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04004BD3 RID: 19411
		private long entityId_;

		// Token: 0x04004BD4 RID: 19412
		public const int NewGravityFlipTypeFieldNumber = 5;

		// Token: 0x04004BD5 RID: 19413
		private GravityFlipType newGravityFlipType_;
	}
}
