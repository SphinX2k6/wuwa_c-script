using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F7 RID: 2551
	[NetMessage(EMessageId.MontagePlayNotify)]
	public sealed class MontagePlayNotify : IMessage<MontagePlayNotify>, IMessage, IEquatable<MontagePlayNotify>, IDeepCloneable<MontagePlayNotify>, IBufferMessage
	{
		// Token: 0x0600DF9A RID: 57242 RVA: 0x0020C992 File Offset: 0x0020AB92
		[NullableContext(1)]
		public static MontagePlayNotify Create()
		{
			return new MontagePlayNotify();
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600DF9B RID: 57243 RVA: 0x0020C999 File Offset: 0x0020AB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x0020C99C File Offset: 0x0020AB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontagePlayNotify.Descriptor;
			}
		}

		// Token: 0x0600DF9D RID: 57245 RVA: 0x0020C9A3 File Offset: 0x0020ABA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify()
		{
		}

		// Token: 0x0600DF9E RID: 57246 RVA: 0x0020C9AB File Offset: 0x0020ABAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify(MontagePlayNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF9F RID: 57247 RVA: 0x0020C9DC File Offset: 0x0020ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontagePlayNotify Clone()
		{
			return new MontagePlayNotify(this);
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x0020C9E4 File Offset: 0x0020ABE4
		// (set) Token: 0x0600DFA1 RID: 57249 RVA: 0x0020C9EC File Offset: 0x0020ABEC
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

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x0020C9F5 File Offset: 0x0020ABF5
		// (set) Token: 0x0600DFA3 RID: 57251 RVA: 0x0020C9FD File Offset: 0x0020ABFD
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

		// Token: 0x0600DFA4 RID: 57252 RVA: 0x0020CA06 File Offset: 0x0020AC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontagePlayNotify);
		}

		// Token: 0x0600DFA5 RID: 57253 RVA: 0x0020CA14 File Offset: 0x0020AC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontagePlayNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x0020CA54 File Offset: 0x0020AC54
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x0020CAAC File Offset: 0x0020ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x0020CAB9 File Offset: 0x0020ACB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFA9 RID: 57257 RVA: 0x0020CAC4 File Offset: 0x0020ACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x0020CB20 File Offset: 0x0020AD20
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFAB RID: 57259 RVA: 0x0020CB78 File Offset: 0x0020AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontagePlayNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x0020CBC8 File Offset: 0x0020ADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x0020CBD4 File Offset: 0x0020ADD4
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
					if (num != 72U)
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
		}

		// Token: 0x04005C7D RID: 23677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C7E RID: 23678
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04005C7F RID: 23679
		private long skillId_;

		// Token: 0x04005C80 RID: 23680
		public const int MontageIndexFieldNumber = 9;

		// Token: 0x04005C81 RID: 23681
		private int montageIndex_;
	}
}
