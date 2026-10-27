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
		// Token: 0x06002376 RID: 9078 RVA: 0x0005E747 File Offset: 0x0005C947
		[NullableContext(1)]
		public static ANStartResponse Create()
		{
			return new ANStartResponse();
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0005E74E File Offset: 0x0005C94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x0005E751 File Offset: 0x0005C951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartResponse.Descriptor;
			}
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0005E758 File Offset: 0x0005C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse()
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0005E760 File Offset: 0x0005C960
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

		// Token: 0x0600237B RID: 9083 RVA: 0x0005E7C4 File Offset: 0x0005C9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartResponse Clone()
		{
			return new ANStartResponse(this);
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0005E7CC File Offset: 0x0005C9CC
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0005E7D4 File Offset: 0x0005C9D4
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x0005E7DD File Offset: 0x0005C9DD
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0005E7E5 File Offset: 0x0005C9E5
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x0005E7EE File Offset: 0x0005C9EE
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0005E7F6 File Offset: 0x0005C9F6
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x0005E7FF File Offset: 0x0005C9FF
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0005E807 File Offset: 0x0005CA07
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

		// Token: 0x06002384 RID: 9092 RVA: 0x0005E810 File Offset: 0x0005CA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartResponse);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0005E820 File Offset: 0x0005CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartResponse other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0005E890 File Offset: 0x0005CA90
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

		// Token: 0x06002387 RID: 9095 RVA: 0x0005E917 File Offset: 0x0005CB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0005E924 File Offset: 0x0005CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0005E930 File Offset: 0x0005CB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.error_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Error);
			}
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
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

		// Token: 0x0600238B RID: 9099 RVA: 0x0005EA4C File Offset: 0x0005CC4C
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

		// Token: 0x0600238C RID: 9100 RVA: 0x0005EADC File Offset: 0x0005CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
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
				if (num <= 90U)
				{
					if (num == 48U)
					{
						this.MontageIndex = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.error_ == null)
						{
							this.Error = new DErrorResult();
						}
						input.ReadMessage(this.Error);
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
					if (num == 112U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024F3 RID: 9459
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024F4 RID: 9460
		public const int SkillIdFieldNumber = 14;

		// Token: 0x040024F5 RID: 9461
		private long skillId_;

		// Token: 0x040024F6 RID: 9462
		public const int MontageIndexFieldNumber = 6;

		// Token: 0x040024F7 RID: 9463
		private int montageIndex_;

		// Token: 0x040024F8 RID: 9464
		public const int AnIndexFieldNumber = 13;

		// Token: 0x040024F9 RID: 9465
		private int anIndex_;

		// Token: 0x040024FA RID: 9466
		public const int ErrorFieldNumber = 11;

		// Token: 0x040024FB RID: 9467
		private DErrorResult error_;
	}
}
