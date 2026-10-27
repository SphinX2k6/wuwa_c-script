using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA5 RID: 3749
	[NetMessage(EMessageId.RecallExploreSkillRouletteNotify)]
	public sealed class RecallExploreSkillRouletteNotify : IMessage<RecallExploreSkillRouletteNotify>, IMessage, IEquatable<RecallExploreSkillRouletteNotify>, IDeepCloneable<RecallExploreSkillRouletteNotify>, IBufferMessage
	{
		// Token: 0x060141F4 RID: 82420 RVA: 0x002EDB5C File Offset: 0x002EBD5C
		[NullableContext(1)]
		public static RecallExploreSkillRouletteNotify Create()
		{
			return new RecallExploreSkillRouletteNotify();
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x060141F5 RID: 82421 RVA: 0x002EDB63 File Offset: 0x002EBD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x060141F6 RID: 82422 RVA: 0x002EDB66 File Offset: 0x002EBD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteNotify.Descriptor;
			}
		}

		// Token: 0x060141F7 RID: 82423 RVA: 0x002EDB6D File Offset: 0x002EBD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify()
		{
		}

		// Token: 0x060141F8 RID: 82424 RVA: 0x002EDB75 File Offset: 0x002EBD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify(RecallExploreSkillRouletteNotify other) : this()
		{
			this.extraItemId_ = other.extraItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141F9 RID: 82425 RVA: 0x002EDB9A File Offset: 0x002EBD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify Clone()
		{
			return new RecallExploreSkillRouletteNotify(this);
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x060141FA RID: 82426 RVA: 0x002EDBA2 File Offset: 0x002EBDA2
		// (set) Token: 0x060141FB RID: 82427 RVA: 0x002EDBAA File Offset: 0x002EBDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraItemId
		{
			get
			{
				return this.extraItemId_;
			}
			set
			{
				this.extraItemId_ = value;
			}
		}

		// Token: 0x060141FC RID: 82428 RVA: 0x002EDBB3 File Offset: 0x002EBDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteNotify);
		}

		// Token: 0x060141FD RID: 82429 RVA: 0x002EDBC1 File Offset: 0x002EBDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteNotify other)
		{
			return other != null && (other == this || (this.ExtraItemId == other.ExtraItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141FE RID: 82430 RVA: 0x002EDBF0 File Offset: 0x002EBDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraItemId != 0)
			{
				num ^= this.ExtraItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060141FF RID: 82431 RVA: 0x002EDC2F File Offset: 0x002EBE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014200 RID: 82432 RVA: 0x002EDC3C File Offset: 0x002EBE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014201 RID: 82433 RVA: 0x002EDC45 File Offset: 0x002EBE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ExtraItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014202 RID: 82434 RVA: 0x002EDC78 File Offset: 0x002EBE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014203 RID: 82435 RVA: 0x002EDCB6 File Offset: 0x002EBEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallExploreSkillRouletteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraItemId != 0)
			{
				this.ExtraItemId = other.ExtraItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014204 RID: 82436 RVA: 0x002EDCE7 File Offset: 0x002EBEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014205 RID: 82437 RVA: 0x002EDCF0 File Offset: 0x002EBEF0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExtraItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A9E RID: 31390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A9F RID: 31391
		public const int ExtraItemIdFieldNumber = 4;

		// Token: 0x04007AA0 RID: 31392
		private int extraItemId_;
	}
}
