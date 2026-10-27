using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F80 RID: 3968
	[NetMessage(EMessageId.RogueBlackFlowerNotify)]
	public sealed class RogueBlackFlowerNotify : IMessage<RogueBlackFlowerNotify>, IMessage, IEquatable<RogueBlackFlowerNotify>, IDeepCloneable<RogueBlackFlowerNotify>, IBufferMessage
	{
		// Token: 0x06015364 RID: 86884 RVA: 0x0031348C File Offset: 0x0031168C
		[NullableContext(1)]
		public static RogueBlackFlowerNotify Create()
		{
			return new RogueBlackFlowerNotify();
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x06015365 RID: 86885 RVA: 0x00313493 File Offset: 0x00311693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x06015366 RID: 86886 RVA: 0x00313496 File Offset: 0x00311696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerNotify.Descriptor;
			}
		}

		// Token: 0x06015367 RID: 86887 RVA: 0x0031349D File Offset: 0x0031169D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify()
		{
		}

		// Token: 0x06015368 RID: 86888 RVA: 0x003134A5 File Offset: 0x003116A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify(RogueBlackFlowerNotify other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015369 RID: 86889 RVA: 0x003134CA File Offset: 0x003116CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerNotify Clone()
		{
			return new RogueBlackFlowerNotify(this);
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x0601536A RID: 86890 RVA: 0x003134D2 File Offset: 0x003116D2
		// (set) Token: 0x0601536B RID: 86891 RVA: 0x003134DA File Offset: 0x003116DA
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

		// Token: 0x0601536C RID: 86892 RVA: 0x003134E3 File Offset: 0x003116E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerNotify);
		}

		// Token: 0x0601536D RID: 86893 RVA: 0x003134F1 File Offset: 0x003116F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerNotify other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601536E RID: 86894 RVA: 0x00313520 File Offset: 0x00311720
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

		// Token: 0x0601536F RID: 86895 RVA: 0x0031355F File Offset: 0x0031175F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015370 RID: 86896 RVA: 0x0031356C File Offset: 0x0031176C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015371 RID: 86897 RVA: 0x00313575 File Offset: 0x00311775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015372 RID: 86898 RVA: 0x003135A8 File Offset: 0x003117A8
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

		// Token: 0x06015373 RID: 86899 RVA: 0x003135E6 File Offset: 0x003117E6
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

		// Token: 0x06015374 RID: 86900 RVA: 0x00313617 File Offset: 0x00311817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015375 RID: 86901 RVA: 0x00313620 File Offset: 0x00311820
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007F89 RID: 32649
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F8A RID: 32650
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04007F8B RID: 32651
		private int entityConfigId_;
	}
}
