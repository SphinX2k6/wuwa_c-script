using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001340 RID: 4928
	public sealed class SurvivorsMonsterKilledCtxPb : IMessage<SurvivorsMonsterKilledCtxPb>, IMessage, IEquatable<SurvivorsMonsterKilledCtxPb>, IDeepCloneable<SurvivorsMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601A441 RID: 107585 RVA: 0x003D4329 File Offset: 0x003D2529
		[NullableContext(1)]
		public static SurvivorsMonsterKilledCtxPb Create()
		{
			return new SurvivorsMonsterKilledCtxPb();
		}

		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x0601A442 RID: 107586 RVA: 0x003D4330 File Offset: 0x003D2530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0601A443 RID: 107587 RVA: 0x003D4333 File Offset: 0x003D2533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A444 RID: 107588 RVA: 0x003D433A File Offset: 0x003D253A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb()
		{
		}

		// Token: 0x0601A445 RID: 107589 RVA: 0x003D4342 File Offset: 0x003D2542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb(SurvivorsMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A446 RID: 107590 RVA: 0x003D4367 File Offset: 0x003D2567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterKilledCtxPb Clone()
		{
			return new SurvivorsMonsterKilledCtxPb(this);
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x0601A447 RID: 107591 RVA: 0x003D436F File Offset: 0x003D256F
		// (set) Token: 0x0601A448 RID: 107592 RVA: 0x003D4377 File Offset: 0x003D2577
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

		// Token: 0x0601A449 RID: 107593 RVA: 0x003D4380 File Offset: 0x003D2580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterKilledCtxPb);
		}

		// Token: 0x0601A44A RID: 107594 RVA: 0x003D438E File Offset: 0x003D258E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A44B RID: 107595 RVA: 0x003D43BC File Offset: 0x003D25BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601A44C RID: 107596 RVA: 0x003D43FB File Offset: 0x003D25FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A44D RID: 107597 RVA: 0x003D4408 File Offset: 0x003D2608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A44E RID: 107598 RVA: 0x003D4411 File Offset: 0x003D2611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A44F RID: 107599 RVA: 0x003D4444 File Offset: 0x003D2644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601A450 RID: 107600 RVA: 0x003D4482 File Offset: 0x003D2682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A451 RID: 107601 RVA: 0x003D44B3 File Offset: 0x003D26B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A452 RID: 107602 RVA: 0x003D44BC File Offset: 0x003D26BC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009A75 RID: 39541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A76 RID: 39542
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009A77 RID: 39543
		private long entityId_;
	}
}
