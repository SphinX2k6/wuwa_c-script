using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F9 RID: 249
	[NetMessage(EMessageId.ANStartPush)]
	public sealed class ANStartPush : IMessage<ANStartPush>, IMessage, IEquatable<ANStartPush>, IDeepCloneable<ANStartPush>, IBufferMessage
	{
		// Token: 0x0600234A RID: 9034 RVA: 0x0005E0B7 File Offset: 0x0005C2B7
		[NullableContext(1)]
		public static ANStartPush Create()
		{
			return new ANStartPush();
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0005E0BE File Offset: 0x0005C2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0005E0C1 File Offset: 0x0005C2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartPush.Descriptor;
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush()
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0005E0D0 File Offset: 0x0005C2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush(ANStartPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0005E10D File Offset: 0x0005C30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush Clone()
		{
			return new ANStartPush(this);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0005E115 File Offset: 0x0005C315
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0005E11D File Offset: 0x0005C31D
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0005E126 File Offset: 0x0005C326
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0005E12E File Offset: 0x0005C32E
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0005E137 File Offset: 0x0005C337
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0005E13F File Offset: 0x0005C33F
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

		// Token: 0x06002356 RID: 9046 RVA: 0x0005E148 File Offset: 0x0005C348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartPush);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0005E158 File Offset: 0x0005C358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x0005E1B4 File Offset: 0x0005C3B4
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x0005E225 File Offset: 0x0005C425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0005E232 File Offset: 0x0005C432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0005E23C File Offset: 0x0005C43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(80);
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

		// Token: 0x0600235C RID: 9052 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0005E324 File Offset: 0x0005C524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ANStartPush other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0005E388 File Offset: 0x0005C588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0005E394 File Offset: 0x0005C594
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
				if (num != 72U)
				{
					if (num != 80U)
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
					this.AnIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x040024E5 RID: 9445
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024E6 RID: 9446
		public const int SkillIdFieldNumber = 10;

		// Token: 0x040024E7 RID: 9447
		private long skillId_;

		// Token: 0x040024E8 RID: 9448
		public const int MontageIndexFieldNumber = 15;

		// Token: 0x040024E9 RID: 9449
		private int montageIndex_;

		// Token: 0x040024EA RID: 9450
		public const int AnIndexFieldNumber = 9;

		// Token: 0x040024EB RID: 9451
		private int anIndex_;
	}
}
