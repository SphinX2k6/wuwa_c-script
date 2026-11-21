using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001147 RID: 4423
	[NetMessage(EMessageId.RoverRogueLootChangeRequest)]
	public sealed class RoverRogueLootChangeRequest : IMessage<RoverRogueLootChangeRequest>, IMessage, IEquatable<RoverRogueLootChangeRequest>, IDeepCloneable<RoverRogueLootChangeRequest>, IBufferMessage
	{
		// Token: 0x06017A21 RID: 96801 RVA: 0x003709F8 File Offset: 0x0036EBF8
		[NullableContext(1)]
		public static RoverRogueLootChangeRequest Create()
		{
			return new RoverRogueLootChangeRequest();
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06017A22 RID: 96802 RVA: 0x003709FF File Offset: 0x0036EBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x06017A23 RID: 96803 RVA: 0x00370A02 File Offset: 0x0036EC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeRequest.Descriptor;
			}
		}

		// Token: 0x06017A24 RID: 96804 RVA: 0x00370A09 File Offset: 0x0036EC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest()
		{
		}

		// Token: 0x06017A25 RID: 96805 RVA: 0x00370A11 File Offset: 0x0036EC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest(RoverRogueLootChangeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.incId_ = other.incId_;
			this.lootId_ = other.lootId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A26 RID: 96806 RVA: 0x00370A4E File Offset: 0x0036EC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest Clone()
		{
			return new RoverRogueLootChangeRequest(this);
		}

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x06017A27 RID: 96807 RVA: 0x00370A56 File Offset: 0x0036EC56
		// (set) Token: 0x06017A28 RID: 96808 RVA: 0x00370A5E File Offset: 0x0036EC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x06017A29 RID: 96809 RVA: 0x00370A67 File Offset: 0x0036EC67
		// (set) Token: 0x06017A2A RID: 96810 RVA: 0x00370A6F File Offset: 0x0036EC6F
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

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06017A2B RID: 96811 RVA: 0x00370A78 File Offset: 0x0036EC78
		// (set) Token: 0x06017A2C RID: 96812 RVA: 0x00370A80 File Offset: 0x0036EC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootId
		{
			get
			{
				return this.lootId_;
			}
			set
			{
				this.lootId_ = value;
			}
		}

		// Token: 0x06017A2D RID: 96813 RVA: 0x00370A89 File Offset: 0x0036EC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeRequest);
		}

		// Token: 0x06017A2E RID: 96814 RVA: 0x00370A98 File Offset: 0x0036EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.IncId == other.IncId && this.LootId == other.LootId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A2F RID: 96815 RVA: 0x00370AF4 File Offset: 0x0036ECF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.LootId != 0)
			{
				num ^= this.LootId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A30 RID: 96816 RVA: 0x00370B65 File Offset: 0x0036ED65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A31 RID: 96817 RVA: 0x00370B72 File Offset: 0x0036ED72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A32 RID: 96818 RVA: 0x00370B7C File Offset: 0x0036ED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LootId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LootId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A33 RID: 96819 RVA: 0x00370BF4 File Offset: 0x0036EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.LootId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LootId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A34 RID: 96820 RVA: 0x00370C64 File Offset: 0x0036EE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.LootId != 0)
			{
				this.LootId = other.LootId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A35 RID: 96821 RVA: 0x00370CC8 File Offset: 0x0036EEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A36 RID: 96822 RVA: 0x00370CD4 File Offset: 0x0036EED4
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
					if (num != 104U)
					{
						if (num != 120U)
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
						this.LootId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D14 RID: 36116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D15 RID: 36117
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04008D16 RID: 36118
		private int activityId_;

		// Token: 0x04008D17 RID: 36119
		public const int IncIdFieldNumber = 15;

		// Token: 0x04008D18 RID: 36120
		private int incId_;

		// Token: 0x04008D19 RID: 36121
		public const int LootIdFieldNumber = 13;

		// Token: 0x04008D1A RID: 36122
		private int lootId_;
	}
}
