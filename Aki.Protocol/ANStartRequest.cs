using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FA RID: 250
	[NetMessage(EMessageId.ANStartRequest)]
	public sealed class ANStartRequest : IMessage<ANStartRequest>, IMessage, IEquatable<ANStartRequest>, IDeepCloneable<ANStartRequest>, IBufferMessage
	{
		// Token: 0x06002397 RID: 9111 RVA: 0x0005EECF File Offset: 0x0005D0CF
		[NullableContext(1)]
		public static ANStartRequest Create()
		{
			return new ANStartRequest();
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0005EED6 File Offset: 0x0005D0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0005EED9 File Offset: 0x0005D0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartRequest.Descriptor;
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest()
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest(ANStartRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0005EF25 File Offset: 0x0005D125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest Clone()
		{
			return new ANStartRequest(this);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x0005EF2D File Offset: 0x0005D12D
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x0005EF35 File Offset: 0x0005D135
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x0005EF3E File Offset: 0x0005D13E
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x0005EF46 File Offset: 0x0005D146
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x0005EF4F File Offset: 0x0005D14F
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x0005EF57 File Offset: 0x0005D157
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

		// Token: 0x060023A3 RID: 9123 RVA: 0x0005EF60 File Offset: 0x0005D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartRequest);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0005EF70 File Offset: 0x0005D170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0005EFCC File Offset: 0x0005D1CC
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

		// Token: 0x060023A6 RID: 9126 RVA: 0x0005F03D File Offset: 0x0005D23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0005F04A File Offset: 0x0005D24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0005F054 File Offset: 0x0005D254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0005F0CC File Offset: 0x0005D2CC
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

		// Token: 0x060023AA RID: 9130 RVA: 0x0005F13C File Offset: 0x0005D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ANStartRequest other)
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

		// Token: 0x060023AB RID: 9131 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0005F1AC File Offset: 0x0005D3AC
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.MontageIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400254B RID: 9547
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400254C RID: 9548
		public const int SkillIdFieldNumber = 13;

		// Token: 0x0400254D RID: 9549
		private long skillId_;

		// Token: 0x0400254E RID: 9550
		public const int MontageIndexFieldNumber = 5;

		// Token: 0x0400254F RID: 9551
		private int montageIndex_;

		// Token: 0x04002550 RID: 9552
		public const int AnIndexFieldNumber = 10;

		// Token: 0x04002551 RID: 9553
		private int anIndex_;
	}
}
