using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2A RID: 3882
	public sealed class RhythmCtx : IMessage<RhythmCtx>, IMessage, IEquatable<RhythmCtx>, IDeepCloneable<RhythmCtx>, IBufferMessage
	{
		// Token: 0x06014CD5 RID: 85205 RVA: 0x0030541D File Offset: 0x0030361D
		[NullableContext(1)]
		public static RhythmCtx Create()
		{
			return new RhythmCtx();
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x06014CD6 RID: 85206 RVA: 0x00305424 File Offset: 0x00303624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x06014CD7 RID: 85207 RVA: 0x00305427 File Offset: 0x00303627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmCtx.Descriptor;
			}
		}

		// Token: 0x06014CD8 RID: 85208 RVA: 0x0030542E File Offset: 0x0030362E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx()
		{
		}

		// Token: 0x06014CD9 RID: 85209 RVA: 0x00305436 File Offset: 0x00303636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx(RhythmCtx other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CDA RID: 85210 RVA: 0x0030545B File Offset: 0x0030365B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmCtx Clone()
		{
			return new RhythmCtx(this);
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x06014CDB RID: 85211 RVA: 0x00305463 File Offset: 0x00303663
		// (set) Token: 0x06014CDC RID: 85212 RVA: 0x0030546B File Offset: 0x0030366B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x06014CDD RID: 85213 RVA: 0x00305474 File Offset: 0x00303674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmCtx);
		}

		// Token: 0x06014CDE RID: 85214 RVA: 0x00305482 File Offset: 0x00303682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmCtx other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CDF RID: 85215 RVA: 0x003054B0 File Offset: 0x003036B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014CE0 RID: 85216 RVA: 0x003054EF File Offset: 0x003036EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CE1 RID: 85217 RVA: 0x003054FC File Offset: 0x003036FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CE2 RID: 85218 RVA: 0x00305505 File Offset: 0x00303705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014CE3 RID: 85219 RVA: 0x00305538 File Offset: 0x00303738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014CE4 RID: 85220 RVA: 0x00305576 File Offset: 0x00303776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014CE5 RID: 85221 RVA: 0x003055A7 File Offset: 0x003037A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CE6 RID: 85222 RVA: 0x003055B0 File Offset: 0x003037B0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SubLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E03 RID: 32259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E04 RID: 32260
		public const int SubLevelIdFieldNumber = 2;

		// Token: 0x04007E05 RID: 32261
		private int subLevelId_;
	}
}
