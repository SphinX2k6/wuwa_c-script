using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E0 RID: 4320
	[NetMessage(EMessageId.RollBlockMovementFinishRequest)]
	public sealed class RollBlockMovementFinishRequest : IMessage<RollBlockMovementFinishRequest>, IMessage, IEquatable<RollBlockMovementFinishRequest>, IDeepCloneable<RollBlockMovementFinishRequest>, IBufferMessage
	{
		// Token: 0x060170BB RID: 94395 RVA: 0x0035852F File Offset: 0x0035672F
		[NullableContext(1)]
		public static RollBlockMovementFinishRequest Create()
		{
			return new RollBlockMovementFinishRequest();
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x060170BC RID: 94396 RVA: 0x00358536 File Offset: 0x00356736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x060170BD RID: 94397 RVA: 0x00358539 File Offset: 0x00356739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockMovementFinishRequest.Descriptor;
			}
		}

		// Token: 0x060170BE RID: 94398 RVA: 0x00358540 File Offset: 0x00356740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest()
		{
		}

		// Token: 0x060170BF RID: 94399 RVA: 0x00358548 File Offset: 0x00356748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest(RollBlockMovementFinishRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170C0 RID: 94400 RVA: 0x00358579 File Offset: 0x00356779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest Clone()
		{
			return new RollBlockMovementFinishRequest(this);
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x060170C1 RID: 94401 RVA: 0x00358581 File Offset: 0x00356781
		// (set) Token: 0x060170C2 RID: 94402 RVA: 0x00358589 File Offset: 0x00356789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x060170C3 RID: 94403 RVA: 0x00358592 File Offset: 0x00356792
		// (set) Token: 0x060170C4 RID: 94404 RVA: 0x0035859A File Offset: 0x0035679A
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

		// Token: 0x060170C5 RID: 94405 RVA: 0x003585A3 File Offset: 0x003567A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockMovementFinishRequest);
		}

		// Token: 0x060170C6 RID: 94406 RVA: 0x003585B1 File Offset: 0x003567B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockMovementFinishRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170C7 RID: 94407 RVA: 0x003585F0 File Offset: 0x003567F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170C8 RID: 94408 RVA: 0x00358648 File Offset: 0x00356848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170C9 RID: 94409 RVA: 0x00358655 File Offset: 0x00356855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170CA RID: 94410 RVA: 0x00358660 File Offset: 0x00356860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170CB RID: 94411 RVA: 0x003586B8 File Offset: 0x003568B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170CC RID: 94412 RVA: 0x00358710 File Offset: 0x00356910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockMovementFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170CD RID: 94413 RVA: 0x00358760 File Offset: 0x00356960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170CE RID: 94414 RVA: 0x0035876C File Offset: 0x0035696C
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400892C RID: 35116
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400892D RID: 35117
		public const int IncIdFieldNumber = 8;

		// Token: 0x0400892E RID: 35118
		private int incId_;

		// Token: 0x0400892F RID: 35119
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04008930 RID: 35120
		private long entityId_;
	}
}
