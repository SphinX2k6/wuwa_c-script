using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E95 RID: 3733
	[NetMessage(EMessageId.RecallExploreSkillRouletteNotify)]
	public sealed class RecallExploreSkillRouletteNotify : IMessage<RecallExploreSkillRouletteNotify>, IMessage, IEquatable<RecallExploreSkillRouletteNotify>, IDeepCloneable<RecallExploreSkillRouletteNotify>, IBufferMessage
	{
		// Token: 0x0601410F RID: 82191 RVA: 0x002EC4AF File Offset: 0x002EA6AF
		[NullableContext(1)]
		public static RecallExploreSkillRouletteNotify Create()
		{
			return new RecallExploreSkillRouletteNotify();
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x06014110 RID: 82192 RVA: 0x002EC4B6 File Offset: 0x002EA6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x06014111 RID: 82193 RVA: 0x002EC4B9 File Offset: 0x002EA6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteNotify.Descriptor;
			}
		}

		// Token: 0x06014112 RID: 82194 RVA: 0x002EC4C0 File Offset: 0x002EA6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify()
		{
		}

		// Token: 0x06014113 RID: 82195 RVA: 0x002EC4C8 File Offset: 0x002EA6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify(RecallExploreSkillRouletteNotify other) : this()
		{
			this.extraItemId_ = other.extraItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014114 RID: 82196 RVA: 0x002EC4ED File Offset: 0x002EA6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteNotify Clone()
		{
			return new RecallExploreSkillRouletteNotify(this);
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x06014115 RID: 82197 RVA: 0x002EC4F5 File Offset: 0x002EA6F5
		// (set) Token: 0x06014116 RID: 82198 RVA: 0x002EC4FD File Offset: 0x002EA6FD
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

		// Token: 0x06014117 RID: 82199 RVA: 0x002EC506 File Offset: 0x002EA706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteNotify);
		}

		// Token: 0x06014118 RID: 82200 RVA: 0x002EC514 File Offset: 0x002EA714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteNotify other)
		{
			return other != null && (other == this || (this.ExtraItemId == other.ExtraItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014119 RID: 82201 RVA: 0x002EC544 File Offset: 0x002EA744
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

		// Token: 0x0601411A RID: 82202 RVA: 0x002EC583 File Offset: 0x002EA783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601411B RID: 82203 RVA: 0x002EC590 File Offset: 0x002EA790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601411C RID: 82204 RVA: 0x002EC599 File Offset: 0x002EA799
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

		// Token: 0x0601411D RID: 82205 RVA: 0x002EC5CC File Offset: 0x002EA7CC
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

		// Token: 0x0601411E RID: 82206 RVA: 0x002EC60A File Offset: 0x002EA80A
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

		// Token: 0x0601411F RID: 82207 RVA: 0x002EC63B File Offset: 0x002EA83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014120 RID: 82208 RVA: 0x002EC644 File Offset: 0x002EA844
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

		// Token: 0x04007AC8 RID: 31432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AC9 RID: 31433
		public const int ExtraItemIdFieldNumber = 4;

		// Token: 0x04007ACA RID: 31434
		private int extraItemId_;
	}
}
