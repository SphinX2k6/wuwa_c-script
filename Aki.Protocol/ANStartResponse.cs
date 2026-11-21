using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FB RID: 251
	[NetMessage(EMessageId.ANStartResponse)]
	public sealed class ANStartResponse : IMessage<ANStartResponse>, IMessage, IEquatable<ANStartResponse>, IDeepCloneable<ANStartResponse>, IBufferMessage
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x0005F217 File Offset: 0x0005D417
		[NullableContext(1)]
		public static ANStartResponse Create()
		{
			return new ANStartResponse();
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0005F21E File Offset: 0x0005D41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0005F221 File Offset: 0x0005D421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartResponse.Descriptor;
			}
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0005F228 File Offset: 0x0005D428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse()
		{
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0005F230 File Offset: 0x0005D430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse(ANStartResponse other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0005F294 File Offset: 0x0005D494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse Clone()
		{
			return new ANStartResponse(this);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x0005F29C File Offset: 0x0005D49C
		// (set) Token: 0x060023B4 RID: 9140 RVA: 0x0005F2A4 File Offset: 0x0005D4A4
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0005F2AD File Offset: 0x0005D4AD
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x0005F2B5 File Offset: 0x0005D4B5
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0005F2BE File Offset: 0x0005D4BE
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0005F2C6 File Offset: 0x0005D4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AnIndex
		{
			get
			{
				return this.anIndex_;
			}
			set
			{
				this.anIndex_ = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0005F2CF File Offset: 0x0005D4CF
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x0005F2D7 File Offset: 0x0005D4D7
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

		// Token: 0x060023BB RID: 9147 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartResponse);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0005F2F0 File Offset: 0x0005D4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0005F360 File Offset: 0x0005D560
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
			if (this.AnIndex != 0)
			{
				num ^= this.AnIndex.GetHashCode();
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

		// Token: 0x060023BE RID: 9150 RVA: 0x0005F3E7 File Offset: 0x0005D5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0005F3F4 File Offset: 0x0005D5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0005F400 File Offset: 0x0005D600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Error);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0005F494 File Offset: 0x0005D694
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
			if (this.AnIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnIndex);
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

		// Token: 0x060023C2 RID: 9154 RVA: 0x0005F51C File Offset: 0x0005D71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ANStartResponse other)
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
			if (other.AnIndex != 0)
			{
				this.AnIndex = other.AnIndex;
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

		// Token: 0x060023C3 RID: 9155 RVA: 0x0005F5AC File Offset: 0x0005D7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0005F5B8 File Offset: 0x0005D7B8
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
				if (num <= 56U)
				{
					if (num == 34U)
					{
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
						continue;
					}
					if (num == 56U)
					{
						this.MontageIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.AnIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002552 RID: 9554
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002553 RID: 9555
		public const int SkillIdFieldNumber = 15;

		// Token: 0x04002554 RID: 9556
		private long skillId_;

		// Token: 0x04002555 RID: 9557
		public const int MontageIndexFieldNumber = 7;

		// Token: 0x04002556 RID: 9558
		private int montageIndex_;

		// Token: 0x04002557 RID: 9559
		public const int AnIndexFieldNumber = 13;

		// Token: 0x04002558 RID: 9560
		private int anIndex_;

		// Token: 0x04002559 RID: 9561
		public const int ErrorFieldNumber = 4;

		// Token: 0x0400255A RID: 9562
		private DErrorResult error_;
	}
}
