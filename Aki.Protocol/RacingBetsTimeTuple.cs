using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7D RID: 3709
	public sealed class RacingBetsTimeTuple : IMessage<RacingBetsTimeTuple>, IMessage, IEquatable<RacingBetsTimeTuple>, IDeepCloneable<RacingBetsTimeTuple>, IBufferMessage
	{
		// Token: 0x06013EB3 RID: 81587 RVA: 0x002E65D1 File Offset: 0x002E47D1
		[NullableContext(1)]
		public static RacingBetsTimeTuple Create()
		{
			return new RacingBetsTimeTuple();
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x06013EB4 RID: 81588 RVA: 0x002E65D8 File Offset: 0x002E47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x06013EB5 RID: 81589 RVA: 0x002E65DB File Offset: 0x002E47DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTimeTuple.Descriptor;
			}
		}

		// Token: 0x06013EB6 RID: 81590 RVA: 0x002E65E2 File Offset: 0x002E47E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple()
		{
		}

		// Token: 0x06013EB7 RID: 81591 RVA: 0x002E65EA File Offset: 0x002E47EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple(RacingBetsTimeTuple other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EB8 RID: 81592 RVA: 0x002E661B File Offset: 0x002E481B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple Clone()
		{
			return new RacingBetsTimeTuple(this);
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x06013EB9 RID: 81593 RVA: 0x002E6623 File Offset: 0x002E4823
		// (set) Token: 0x06013EBA RID: 81594 RVA: 0x002E662B File Offset: 0x002E482B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x06013EBB RID: 81595 RVA: 0x002E6634 File Offset: 0x002E4834
		// (set) Token: 0x06013EBC RID: 81596 RVA: 0x002E663C File Offset: 0x002E483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x06013EBD RID: 81597 RVA: 0x002E6645 File Offset: 0x002E4845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTimeTuple);
		}

		// Token: 0x06013EBE RID: 81598 RVA: 0x002E6653 File Offset: 0x002E4853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTimeTuple other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013EBF RID: 81599 RVA: 0x002E6694 File Offset: 0x002E4894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013EC0 RID: 81600 RVA: 0x002E66EC File Offset: 0x002E48EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013EC1 RID: 81601 RVA: 0x002E66F9 File Offset: 0x002E48F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013EC2 RID: 81602 RVA: 0x002E6704 File Offset: 0x002E4904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013EC3 RID: 81603 RVA: 0x002E675C File Offset: 0x002E495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013EC4 RID: 81604 RVA: 0x002E67B4 File Offset: 0x002E49B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTimeTuple other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013EC5 RID: 81605 RVA: 0x002E6804 File Offset: 0x002E4A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013EC6 RID: 81606 RVA: 0x002E6810 File Offset: 0x002E4A10
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
						this.EndTime = input.ReadInt64();
					}
				}
				else
				{
					this.BeginTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040079B6 RID: 31158
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079B7 RID: 31159
		public const int BeginTimeFieldNumber = 1;

		// Token: 0x040079B8 RID: 31160
		private long beginTime_;

		// Token: 0x040079B9 RID: 31161
		public const int EndTimeFieldNumber = 2;

		// Token: 0x040079BA RID: 31162
		private long endTime_;
	}
}
