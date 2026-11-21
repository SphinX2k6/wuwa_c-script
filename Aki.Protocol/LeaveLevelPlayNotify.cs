using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DB RID: 2267
	[NetMessage(EMessageId.LeaveLevelPlayNotify)]
	public sealed class LeaveLevelPlayNotify : IMessage<LeaveLevelPlayNotify>, IMessage, IEquatable<LeaveLevelPlayNotify>, IDeepCloneable<LeaveLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x0600C8E2 RID: 51426 RVA: 0x001DB0CD File Offset: 0x001D92CD
		[NullableContext(1)]
		public static LeaveLevelPlayNotify Create()
		{
			return new LeaveLevelPlayNotify();
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600C8E3 RID: 51427 RVA: 0x001DB0D4 File Offset: 0x001D92D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600C8E4 RID: 51428 RVA: 0x001DB0D7 File Offset: 0x001D92D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x001DB0DE File Offset: 0x001D92DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify()
		{
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x001DB0E6 File Offset: 0x001D92E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify(LeaveLevelPlayNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x001DB10B File Offset: 0x001D930B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify Clone()
		{
			return new LeaveLevelPlayNotify(this);
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600C8E8 RID: 51432 RVA: 0x001DB113 File Offset: 0x001D9313
		// (set) Token: 0x0600C8E9 RID: 51433 RVA: 0x001DB11B File Offset: 0x001D931B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x001DB124 File Offset: 0x001D9324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveLevelPlayNotify);
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x001DB132 File Offset: 0x001D9332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveLevelPlayNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x001DB160 File Offset: 0x001D9360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x001DB19F File Offset: 0x001D939F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8EE RID: 51438 RVA: 0x001DB1AC File Offset: 0x001D93AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x001DB1B5 File Offset: 0x001D93B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x001DB1E8 File Offset: 0x001D93E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x001DB226 File Offset: 0x001D9426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveLevelPlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x001DB257 File Offset: 0x001D9457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x001DB260 File Offset: 0x001D9460
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005616 RID: 22038
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005617 RID: 22039
		public const int IdFieldNumber = 9;

		// Token: 0x04005618 RID: 22040
		private int id_;
	}
}
