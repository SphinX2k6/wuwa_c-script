using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7E RID: 3966
	[NetMessage(EMessageId.RogueArchiveSaveRequest)]
	public sealed class RogueArchiveSaveRequest : IMessage<RogueArchiveSaveRequest>, IMessage, IEquatable<RogueArchiveSaveRequest>, IDeepCloneable<RogueArchiveSaveRequest>, IBufferMessage
	{
		// Token: 0x0601533E RID: 86846 RVA: 0x00313014 File Offset: 0x00311214
		[NullableContext(1)]
		public static RogueArchiveSaveRequest Create()
		{
			return new RogueArchiveSaveRequest();
		}

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0601533F RID: 86847 RVA: 0x0031301B File Offset: 0x0031121B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x06015340 RID: 86848 RVA: 0x0031301E File Offset: 0x0031121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveSaveRequest.Descriptor;
			}
		}

		// Token: 0x06015341 RID: 86849 RVA: 0x00313025 File Offset: 0x00311225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest()
		{
		}

		// Token: 0x06015342 RID: 86850 RVA: 0x0031302D File Offset: 0x0031122D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest(RogueArchiveSaveRequest other) : this()
		{
			this.slotId_ = other.slotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015343 RID: 86851 RVA: 0x00313052 File Offset: 0x00311252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveSaveRequest Clone()
		{
			return new RogueArchiveSaveRequest(this);
		}

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06015344 RID: 86852 RVA: 0x0031305A File Offset: 0x0031125A
		// (set) Token: 0x06015345 RID: 86853 RVA: 0x00313062 File Offset: 0x00311262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x06015346 RID: 86854 RVA: 0x0031306B File Offset: 0x0031126B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveSaveRequest);
		}

		// Token: 0x06015347 RID: 86855 RVA: 0x00313079 File Offset: 0x00311279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveSaveRequest other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015348 RID: 86856 RVA: 0x003130A8 File Offset: 0x003112A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015349 RID: 86857 RVA: 0x003130E7 File Offset: 0x003112E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601534A RID: 86858 RVA: 0x003130F4 File Offset: 0x003112F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x003130FD File Offset: 0x003112FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x00313130 File Offset: 0x00311330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x0031316E File Offset: 0x0031136E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveSaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x0031319F File Offset: 0x0031139F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601534F RID: 86863 RVA: 0x003131A8 File Offset: 0x003113A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F81 RID: 32641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F82 RID: 32642
		public const int SlotIdFieldNumber = 6;

		// Token: 0x04007F83 RID: 32643
		private int slotId_;
	}
}
