using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0A RID: 2570
	[NetMessage(EMessageId.MontagePlayResponse)]
	public sealed class MontagePlayResponse : IMessage<MontagePlayResponse>, IMessage, IEquatable<MontagePlayResponse>, IDeepCloneable<MontagePlayResponse>, IBufferMessage
	{
		// Token: 0x0600E0DA RID: 57562 RVA: 0x0020EFF1 File Offset: 0x0020D1F1
		[NullableContext(1)]
		public static MontagePlayResponse Create()
		{
			return new MontagePlayResponse();
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x0020EFF8 File Offset: 0x0020D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x0020EFFB File Offset: 0x0020D1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayResponse.Descriptor;
			}
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x0020F002 File Offset: 0x0020D202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse()
		{
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x0020F00C File Offset: 0x0020D20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse(MontagePlayResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x0020F064 File Offset: 0x0020D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayResponse Clone()
		{
			return new MontagePlayResponse(this);
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600E0E0 RID: 57568 RVA: 0x0020F06C File Offset: 0x0020D26C
		// (set) Token: 0x0600E0E1 RID: 57569 RVA: 0x0020F074 File Offset: 0x0020D274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x0020F07D File Offset: 0x0020D27D
		// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x0020F085 File Offset: 0x0020D285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x0020F08E File Offset: 0x0020D28E
		// (set) Token: 0x0600E0E5 RID: 57573 RVA: 0x0020F096 File Offset: 0x0020D296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x0020F09F File Offset: 0x0020D29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayResponse);
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x0020F0B0 File Offset: 0x0020D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x0020F110 File Offset: 0x0020D310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x0020F17E File Offset: 0x0020D37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x0020F18B File Offset: 0x0020D38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x0020F194 File Offset: 0x0020D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Error);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x0020F20C File Offset: 0x0020D40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x0020F27C File Offset: 0x0020D47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x0020F2F8 File Offset: 0x0020D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x0020F304 File Offset: 0x0020D504
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
				if (num != 26U)
				{
					if (num != 48U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MontageIndex = input.ReadInt32();
						}
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x04005C7C RID: 23676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C7D RID: 23677
		public const int SkillIdFieldNumber = 6;

		// Token: 0x04005C7E RID: 23678
		private long skillId_;

		// Token: 0x04005C7F RID: 23679
		public const int MontageIndexFieldNumber = 15;

		// Token: 0x04005C80 RID: 23680
		private int montageIndex_;

		// Token: 0x04005C81 RID: 23681
		public const int ErrorFieldNumber = 3;

		// Token: 0x04005C82 RID: 23682
		private DErrorResult error_;
	}
}
