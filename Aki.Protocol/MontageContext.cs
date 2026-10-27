using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A07 RID: 2567
	public sealed class MontageContext : IMessage<MontageContext>, IMessage, IEquatable<MontageContext>, IDeepCloneable<MontageContext>, IBufferMessage
	{
		// Token: 0x0600E09E RID: 57502 RVA: 0x0020E83C File Offset: 0x0020CA3C
		[NullableContext(1)]
		public static MontageContext Create()
		{
			return new MontageContext();
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600E09F RID: 57503 RVA: 0x0020E843 File Offset: 0x0020CA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x0020E846 File Offset: 0x0020CA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontageContext.Descriptor;
			}
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x0020E84D File Offset: 0x0020CA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext()
		{
		}

		// Token: 0x0600E0A2 RID: 57506 RVA: 0x0020E855 File Offset: 0x0020CA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext(MontageContext other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0A3 RID: 57507 RVA: 0x0020E892 File Offset: 0x0020CA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext Clone()
		{
			return new MontageContext(this);
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x0020E89A File Offset: 0x0020CA9A
		// (set) Token: 0x0600E0A5 RID: 57509 RVA: 0x0020E8A2 File Offset: 0x0020CAA2
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

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x0020E8AB File Offset: 0x0020CAAB
		// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x0020E8B3 File Offset: 0x0020CAB3
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

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x0020E8BC File Offset: 0x0020CABC
		// (set) Token: 0x0600E0A9 RID: 57513 RVA: 0x0020E8C4 File Offset: 0x0020CAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x0020E8CD File Offset: 0x0020CACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontageContext);
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x0020E8DC File Offset: 0x0020CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontageContext other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x0020E938 File Offset: 0x0020CB38
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
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0AD RID: 57517 RVA: 0x0020E9A9 File Offset: 0x0020CBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x0020E9B6 File Offset: 0x0020CBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x0020E9C0 File Offset: 0x0020CBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x0020EA34 File Offset: 0x0020CC34
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
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x0020EAA4 File Offset: 0x0020CCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontageContext other)
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
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x0020EB08 File Offset: 0x0020CD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0020EB14 File Offset: 0x0020CD14
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ContextId = input.ReadInt64();
						}
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
		}

		// Token: 0x04005C6D RID: 23661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C6E RID: 23662
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04005C6F RID: 23663
		private long skillId_;

		// Token: 0x04005C70 RID: 23664
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x04005C71 RID: 23665
		private int montageIndex_;

		// Token: 0x04005C72 RID: 23666
		public const int ContextIdFieldNumber = 3;

		// Token: 0x04005C73 RID: 23667
		private long contextId_;
	}
}
