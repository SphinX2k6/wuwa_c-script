using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F8 RID: 248
	[NetMessage(EMessageId.ANStartNotify)]
	public sealed class ANStartNotify : IMessage<ANStartNotify>, IMessage, IEquatable<ANStartNotify>, IDeepCloneable<ANStartNotify>, IBufferMessage
	{
		// Token: 0x06002334 RID: 9012 RVA: 0x0005DD71 File Offset: 0x0005BF71
		[NullableContext(1)]
		public static ANStartNotify Create()
		{
			return new ANStartNotify();
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0005DD78 File Offset: 0x0005BF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x0005DD7B File Offset: 0x0005BF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartNotify.Descriptor;
			}
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0005DD82 File Offset: 0x0005BF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify()
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0005DD8A File Offset: 0x0005BF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify(ANStartNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0005DDC7 File Offset: 0x0005BFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify Clone()
		{
			return new ANStartNotify(this);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0005DDCF File Offset: 0x0005BFCF
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0005DDD7 File Offset: 0x0005BFD7
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x0005DDE0 File Offset: 0x0005BFE0
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0005DDE8 File Offset: 0x0005BFE8
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x0005DDF1 File Offset: 0x0005BFF1
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x0005DDF9 File Offset: 0x0005BFF9
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

		// Token: 0x06002340 RID: 9024 RVA: 0x0005DE02 File Offset: 0x0005C002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartNotify);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0005DE10 File Offset: 0x0005C010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0005DE6C File Offset: 0x0005C06C
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

		// Token: 0x06002343 RID: 9027 RVA: 0x0005DEDD File Offset: 0x0005C0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0005DEEA File Offset: 0x0005C0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0005DEF4 File Offset: 0x0005C0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0005DF6C File Offset: 0x0005C16C
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

		// Token: 0x06002347 RID: 9031 RVA: 0x0005DFDC File Offset: 0x0005C1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ANStartNotify other)
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

		// Token: 0x06002348 RID: 9032 RVA: 0x0005E040 File Offset: 0x0005C240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0005E04C File Offset: 0x0005C24C
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 64U)
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

		// Token: 0x040024DE RID: 9438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024DF RID: 9439
		public const int SkillIdFieldNumber = 8;

		// Token: 0x040024E0 RID: 9440
		private long skillId_;

		// Token: 0x040024E1 RID: 9441
		public const int MontageIndexFieldNumber = 4;

		// Token: 0x040024E2 RID: 9442
		private int montageIndex_;

		// Token: 0x040024E3 RID: 9443
		public const int AnIndexFieldNumber = 5;

		// Token: 0x040024E4 RID: 9444
		private int anIndex_;
	}
}
