using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F70 RID: 3952
	[NetMessage(EMessageId.RogueBlackFlowerNotify)]
	public sealed class RogueBlackFlowerNotify : IMessage<RogueBlackFlowerNotify>, IMessage, IEquatable<RogueBlackFlowerNotify>, IDeepCloneable<RogueBlackFlowerNotify>, IBufferMessage
	{
		// Token: 0x0601527F RID: 86655 RVA: 0x00311DE0 File Offset: 0x0030FFE0
		[NullableContext(1)]
		public static RogueBlackFlowerNotify Create()
		{
			return new RogueBlackFlowerNotify();
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x06015280 RID: 86656 RVA: 0x00311DE7 File Offset: 0x0030FFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x06015281 RID: 86657 RVA: 0x00311DEA File Offset: 0x0030FFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerNotify.Descriptor;
			}
		}

		// Token: 0x06015282 RID: 86658 RVA: 0x00311DF1 File Offset: 0x0030FFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify()
		{
		}

		// Token: 0x06015283 RID: 86659 RVA: 0x00311DF9 File Offset: 0x0030FFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify(RogueBlackFlowerNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015284 RID: 86660 RVA: 0x00311E1E File Offset: 0x0031001E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify Clone()
		{
			return new RogueBlackFlowerNotify(this);
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x06015285 RID: 86661 RVA: 0x00311E26 File Offset: 0x00310026
		// (set) Token: 0x06015286 RID: 86662 RVA: 0x00311E2E File Offset: 0x0031002E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x06015287 RID: 86663 RVA: 0x00311E37 File Offset: 0x00310037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerNotify);
		}

		// Token: 0x06015288 RID: 86664 RVA: 0x00311E45 File Offset: 0x00310045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015289 RID: 86665 RVA: 0x00311E74 File Offset: 0x00310074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601528A RID: 86666 RVA: 0x00311EB3 File Offset: 0x003100B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601528B RID: 86667 RVA: 0x00311EC0 File Offset: 0x003100C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601528C RID: 86668 RVA: 0x00311EC9 File Offset: 0x003100C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x00311EFC File Offset: 0x003100FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x00311F3A File Offset: 0x0031013A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBlackFlowerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601528F RID: 86671 RVA: 0x00311F6B File Offset: 0x0031016B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015290 RID: 86672 RVA: 0x00311F74 File Offset: 0x00310174
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
					this.EntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007FB3 RID: 32691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FB4 RID: 32692
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x04007FB5 RID: 32693
		private int entityConfigId_;
	}
}
