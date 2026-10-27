using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110D RID: 4365
	[NetMessage(EMessageId.RoverRogueLootChangeRequest)]
	public sealed class RoverRogueLootChangeRequest : IMessage<RoverRogueLootChangeRequest>, IMessage, IEquatable<RoverRogueLootChangeRequest>, IDeepCloneable<RoverRogueLootChangeRequest>, IBufferMessage
	{
		// Token: 0x06017480 RID: 95360 RVA: 0x003616AC File Offset: 0x0035F8AC
		[NullableContext(1)]
		public static RoverRogueLootChangeRequest Create()
		{
			return new RoverRogueLootChangeRequest();
		}

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x06017481 RID: 95361 RVA: 0x003616B3 File Offset: 0x0035F8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x06017482 RID: 95362 RVA: 0x003616B6 File Offset: 0x0035F8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootChangeRequest.Descriptor;
			}
		}

		// Token: 0x06017483 RID: 95363 RVA: 0x003616BD File Offset: 0x0035F8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest()
		{
		}

		// Token: 0x06017484 RID: 95364 RVA: 0x003616C5 File Offset: 0x0035F8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest(RoverRogueLootChangeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.incId_ = other.incId_;
			this.lootId_ = other.lootId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017485 RID: 95365 RVA: 0x00361702 File Offset: 0x0035F902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootChangeRequest Clone()
		{
			return new RoverRogueLootChangeRequest(this);
		}

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x06017486 RID: 95366 RVA: 0x0036170A File Offset: 0x0035F90A
		// (set) Token: 0x06017487 RID: 95367 RVA: 0x00361712 File Offset: 0x0035F912
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

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x06017488 RID: 95368 RVA: 0x0036171B File Offset: 0x0035F91B
		// (set) Token: 0x06017489 RID: 95369 RVA: 0x00361723 File Offset: 0x0035F923
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

		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x0601748A RID: 95370 RVA: 0x0036172C File Offset: 0x0035F92C
		// (set) Token: 0x0601748B RID: 95371 RVA: 0x00361734 File Offset: 0x0035F934
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

		// Token: 0x0601748C RID: 95372 RVA: 0x0036173D File Offset: 0x0035F93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootChangeRequest);
		}

		// Token: 0x0601748D RID: 95373 RVA: 0x0036174C File Offset: 0x0035F94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootChangeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.IncId == other.IncId && this.LootId == other.LootId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601748E RID: 95374 RVA: 0x003617A8 File Offset: 0x0035F9A8
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

		// Token: 0x0601748F RID: 95375 RVA: 0x00361819 File Offset: 0x0035FA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017490 RID: 95376 RVA: 0x00361826 File Offset: 0x0035FA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017491 RID: 95377 RVA: 0x00361830 File Offset: 0x0035FA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LootId != 0)
			{
				output.WriteRawTag(88);
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

		// Token: 0x06017492 RID: 95378 RVA: 0x003618A8 File Offset: 0x0035FAA8
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

		// Token: 0x06017493 RID: 95379 RVA: 0x00361918 File Offset: 0x0035FB18
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

		// Token: 0x06017494 RID: 95380 RVA: 0x0036197C File Offset: 0x0035FB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017495 RID: 95381 RVA: 0x00361988 File Offset: 0x0035FB88
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
				if (num != 64U)
				{
					if (num != 88U)
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

		// Token: 0x04008A81 RID: 35457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A82 RID: 35458
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04008A83 RID: 35459
		private int activityId_;

		// Token: 0x04008A84 RID: 35460
		public const int IncIdFieldNumber = 15;

		// Token: 0x04008A85 RID: 35461
		private int incId_;

		// Token: 0x04008A86 RID: 35462
		public const int LootIdFieldNumber = 11;

		// Token: 0x04008A87 RID: 35463
		private int lootId_;
	}
}
