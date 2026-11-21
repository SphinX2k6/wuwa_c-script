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
		// Token: 0x0600236B RID: 9067 RVA: 0x0005E841 File Offset: 0x0005CA41
		[NullableContext(1)]
		public static ANStartNotify Create()
		{
			return new ANStartNotify();
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0005E848 File Offset: 0x0005CA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0005E84B File Offset: 0x0005CA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartNotify.Descriptor;
			}
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0005E852 File Offset: 0x0005CA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify()
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0005E85A File Offset: 0x0005CA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify(ANStartNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0005E897 File Offset: 0x0005CA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartNotify Clone()
		{
			return new ANStartNotify(this);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0005E89F File Offset: 0x0005CA9F
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0005E8A7 File Offset: 0x0005CAA7
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0005E8B8 File Offset: 0x0005CAB8
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0005E8C1 File Offset: 0x0005CAC1
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0005E8C9 File Offset: 0x0005CAC9
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

		// Token: 0x06002377 RID: 9079 RVA: 0x0005E8D2 File Offset: 0x0005CAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartNotify);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0005E8E0 File Offset: 0x0005CAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0005E93C File Offset: 0x0005CB3C
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

		// Token: 0x0600237A RID: 9082 RVA: 0x0005E9AD File Offset: 0x0005CBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0005E9BA File Offset: 0x0005CBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AnIndex);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(64);
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

		// Token: 0x0600237D RID: 9085 RVA: 0x0005EA3C File Offset: 0x0005CC3C
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

		// Token: 0x0600237E RID: 9086 RVA: 0x0005EAAC File Offset: 0x0005CCAC
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

		// Token: 0x0600237F RID: 9087 RVA: 0x0005EB10 File Offset: 0x0005CD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0005EB1C File Offset: 0x0005CD1C
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
				if (num != 16U)
				{
					if (num != 64U)
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

		// Token: 0x0400253D RID: 9533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400253E RID: 9534
		public const int SkillIdFieldNumber = 8;

		// Token: 0x0400253F RID: 9535
		private long skillId_;

		// Token: 0x04002540 RID: 9536
		public const int MontageIndexFieldNumber = 15;

		// Token: 0x04002541 RID: 9537
		private int montageIndex_;

		// Token: 0x04002542 RID: 9538
		public const int AnIndexFieldNumber = 2;

		// Token: 0x04002543 RID: 9539
		private int anIndex_;
	}
}
