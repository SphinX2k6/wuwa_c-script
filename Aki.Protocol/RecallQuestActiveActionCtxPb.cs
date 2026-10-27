using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB7 RID: 3767
	public sealed class RecallQuestActiveActionCtxPb : IMessage<RecallQuestActiveActionCtxPb>, IMessage, IEquatable<RecallQuestActiveActionCtxPb>, IDeepCloneable<RecallQuestActiveActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601435D RID: 82781 RVA: 0x002F09E5 File Offset: 0x002EEBE5
		[NullableContext(1)]
		public static RecallQuestActiveActionCtxPb Create()
		{
			return new RecallQuestActiveActionCtxPb();
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0601435E RID: 82782 RVA: 0x002F09EC File Offset: 0x002EEBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0601435F RID: 82783 RVA: 0x002F09EF File Offset: 0x002EEBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActiveActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06014360 RID: 82784 RVA: 0x002F09F6 File Offset: 0x002EEBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb()
		{
		}

		// Token: 0x06014361 RID: 82785 RVA: 0x002F09FE File Offset: 0x002EEBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb(RecallQuestActiveActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014362 RID: 82786 RVA: 0x002F0A23 File Offset: 0x002EEC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActiveActionCtxPb Clone()
		{
			return new RecallQuestActiveActionCtxPb(this);
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x06014363 RID: 82787 RVA: 0x002F0A2B File Offset: 0x002EEC2B
		// (set) Token: 0x06014364 RID: 82788 RVA: 0x002F0A33 File Offset: 0x002EEC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x06014365 RID: 82789 RVA: 0x002F0A3C File Offset: 0x002EEC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActiveActionCtxPb);
		}

		// Token: 0x06014366 RID: 82790 RVA: 0x002F0A4A File Offset: 0x002EEC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActiveActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014367 RID: 82791 RVA: 0x002F0A78 File Offset: 0x002EEC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014368 RID: 82792 RVA: 0x002F0AB7 File Offset: 0x002EECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014369 RID: 82793 RVA: 0x002F0AC4 File Offset: 0x002EECC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601436A RID: 82794 RVA: 0x002F0ACD File Offset: 0x002EECCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601436B RID: 82795 RVA: 0x002F0B00 File Offset: 0x002EED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601436C RID: 82796 RVA: 0x002F0B3E File Offset: 0x002EED3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestActiveActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601436D RID: 82797 RVA: 0x002F0B6F File Offset: 0x002EED6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601436E RID: 82798 RVA: 0x002F0B78 File Offset: 0x002EED78
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B00 RID: 31488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B01 RID: 31489
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B02 RID: 31490
		private int recallQuestId_;
	}
}
