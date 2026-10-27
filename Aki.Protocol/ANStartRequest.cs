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
		// Token: 0x06002360 RID: 9056 RVA: 0x0005E3FF File Offset: 0x0005C5FF
		[NullableContext(1)]
		public static ANStartRequest Create()
		{
			return new ANStartRequest();
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x0005E406 File Offset: 0x0005C606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0005E409 File Offset: 0x0005C609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartRequest.Descriptor;
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0005E410 File Offset: 0x0005C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest()
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0005E418 File Offset: 0x0005C618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest(ANStartRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0005E455 File Offset: 0x0005C655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartRequest Clone()
		{
			return new ANStartRequest(this);
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0005E45D File Offset: 0x0005C65D
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0005E465 File Offset: 0x0005C665
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0005E46E File Offset: 0x0005C66E
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0005E476 File Offset: 0x0005C676
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0005E47F File Offset: 0x0005C67F
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0005E487 File Offset: 0x0005C687
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

		// Token: 0x0600236C RID: 9068 RVA: 0x0005E490 File Offset: 0x0005C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartRequest);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0005E4FC File Offset: 0x0005C6FC
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

		// Token: 0x0600236F RID: 9071 RVA: 0x0005E56D File Offset: 0x0005C76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0005E57A File Offset: 0x0005C77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0005E584 File Offset: 0x0005C784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0005E5FC File Offset: 0x0005C7FC
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

		// Token: 0x06002373 RID: 9075 RVA: 0x0005E66C File Offset: 0x0005C86C
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

		// Token: 0x06002374 RID: 9076 RVA: 0x0005E6D0 File Offset: 0x0005C8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0005E6DC File Offset: 0x0005C8DC
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 88U)
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

		// Token: 0x040024EC RID: 9452
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024ED RID: 9453
		public const int SkillIdFieldNumber = 7;

		// Token: 0x040024EE RID: 9454
		private long skillId_;

		// Token: 0x040024EF RID: 9455
		public const int MontageIndexFieldNumber = 11;

		// Token: 0x040024F0 RID: 9456
		private int montageIndex_;

		// Token: 0x040024F1 RID: 9457
		public const int AnIndexFieldNumber = 6;

		// Token: 0x040024F2 RID: 9458
		private int anIndex_;
	}
}
