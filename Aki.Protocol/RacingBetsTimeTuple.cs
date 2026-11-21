using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6D RID: 3693
	public sealed class RacingBetsTimeTuple : IMessage<RacingBetsTimeTuple>, IMessage, IEquatable<RacingBetsTimeTuple>, IDeepCloneable<RacingBetsTimeTuple>, IBufferMessage
	{
		// Token: 0x06013DCE RID: 81358 RVA: 0x002E4F11 File Offset: 0x002E3111
		[NullableContext(1)]
		public static RacingBetsTimeTuple Create()
		{
			return new RacingBetsTimeTuple();
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x06013DCF RID: 81359 RVA: 0x002E4F18 File Offset: 0x002E3118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x06013DD0 RID: 81360 RVA: 0x002E4F1B File Offset: 0x002E311B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTimeTuple.Descriptor;
			}
		}

		// Token: 0x06013DD1 RID: 81361 RVA: 0x002E4F22 File Offset: 0x002E3122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple()
		{
		}

		// Token: 0x06013DD2 RID: 81362 RVA: 0x002E4F2A File Offset: 0x002E312A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple(RacingBetsTimeTuple other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DD3 RID: 81363 RVA: 0x002E4F5B File Offset: 0x002E315B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple Clone()
		{
			return new RacingBetsTimeTuple(this);
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x06013DD4 RID: 81364 RVA: 0x002E4F63 File Offset: 0x002E3163
		// (set) Token: 0x06013DD5 RID: 81365 RVA: 0x002E4F6B File Offset: 0x002E316B
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

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x06013DD6 RID: 81366 RVA: 0x002E4F74 File Offset: 0x002E3174
		// (set) Token: 0x06013DD7 RID: 81367 RVA: 0x002E4F7C File Offset: 0x002E317C
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

		// Token: 0x06013DD8 RID: 81368 RVA: 0x002E4F85 File Offset: 0x002E3185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTimeTuple);
		}

		// Token: 0x06013DD9 RID: 81369 RVA: 0x002E4F93 File Offset: 0x002E3193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTimeTuple other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DDA RID: 81370 RVA: 0x002E4FD4 File Offset: 0x002E31D4
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

		// Token: 0x06013DDB RID: 81371 RVA: 0x002E502C File Offset: 0x002E322C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DDC RID: 81372 RVA: 0x002E5039 File Offset: 0x002E3239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DDD RID: 81373 RVA: 0x002E5044 File Offset: 0x002E3244
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

		// Token: 0x06013DDE RID: 81374 RVA: 0x002E509C File Offset: 0x002E329C
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

		// Token: 0x06013DDF RID: 81375 RVA: 0x002E50F4 File Offset: 0x002E32F4
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

		// Token: 0x06013DE0 RID: 81376 RVA: 0x002E5144 File Offset: 0x002E3344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DE1 RID: 81377 RVA: 0x002E5150 File Offset: 0x002E3350
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

		// Token: 0x040079E0 RID: 31200
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079E1 RID: 31201
		public const int BeginTimeFieldNumber = 1;

		// Token: 0x040079E2 RID: 31202
		private long beginTime_;

		// Token: 0x040079E3 RID: 31203
		public const int EndTimeFieldNumber = 2;

		// Token: 0x040079E4 RID: 31204
		private long endTime_;
	}
}
