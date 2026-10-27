using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000911 RID: 2321
	[NetMessage(EMessageId.LevelPlayVarRequest)]
	public sealed class LevelPlayVarRequest : IMessage<LevelPlayVarRequest>, IMessage, IEquatable<LevelPlayVarRequest>, IDeepCloneable<LevelPlayVarRequest>, IBufferMessage
	{
		// Token: 0x0600CCE2 RID: 52450 RVA: 0x001E3235 File Offset: 0x001E1435
		[NullableContext(1)]
		public static LevelPlayVarRequest Create()
		{
			return new LevelPlayVarRequest();
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600CCE3 RID: 52451 RVA: 0x001E323C File Offset: 0x001E143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x0600CCE4 RID: 52452 RVA: 0x001E323F File Offset: 0x001E143F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayVarRequest.Descriptor;
			}
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x001E3246 File Offset: 0x001E1446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest()
		{
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x001E324E File Offset: 0x001E144E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest(LevelPlayVarRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x001E327F File Offset: 0x001E147F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarRequest Clone()
		{
			return new LevelPlayVarRequest(this);
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x001E3287 File Offset: 0x001E1487
		// (set) Token: 0x0600CCE9 RID: 52457 RVA: 0x001E328F File Offset: 0x001E148F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x001E3298 File Offset: 0x001E1498
		// (set) Token: 0x0600CCEB RID: 52459 RVA: 0x001E32A0 File Offset: 0x001E14A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x001E32A9 File Offset: 0x001E14A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayVarRequest);
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x001E32B7 File Offset: 0x001E14B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayVarRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x001E32F8 File Offset: 0x001E14F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x001E3350 File Offset: 0x001E1550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x001E335D File Offset: 0x001E155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x001E3368 File Offset: 0x001E1568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x001E33C0 File Offset: 0x001E15C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x001E3418 File Offset: 0x001E1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayVarRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x001E3468 File Offset: 0x001E1668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x001E3474 File Offset: 0x001E1674
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056CE RID: 22222
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056CF RID: 22223
		public const int InstIdFieldNumber = 7;

		// Token: 0x040056D0 RID: 22224
		private int instId_;

		// Token: 0x040056D1 RID: 22225
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x040056D2 RID: 22226
		private int levelPlayId_;
	}
}
