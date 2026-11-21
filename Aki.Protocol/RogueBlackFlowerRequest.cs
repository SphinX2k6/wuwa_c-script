using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F71 RID: 3953
	[NetMessage(EMessageId.RogueBlackFlowerRequest)]
	public sealed class RogueBlackFlowerRequest : IMessage<RogueBlackFlowerRequest>, IMessage, IEquatable<RogueBlackFlowerRequest>, IDeepCloneable<RogueBlackFlowerRequest>, IBufferMessage
	{
		// Token: 0x06015291 RID: 86673 RVA: 0x00311FB8 File Offset: 0x003101B8
		[NullableContext(1)]
		public static RogueBlackFlowerRequest Create()
		{
			return new RogueBlackFlowerRequest();
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x06015292 RID: 86674 RVA: 0x00311FBF File Offset: 0x003101BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x06015293 RID: 86675 RVA: 0x00311FC2 File Offset: 0x003101C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerRequest.Descriptor;
			}
		}

		// Token: 0x06015294 RID: 86676 RVA: 0x00311FC9 File Offset: 0x003101C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest()
		{
		}

		// Token: 0x06015295 RID: 86677 RVA: 0x00311FD1 File Offset: 0x003101D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest(RogueBlackFlowerRequest other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_;
			this.ret_ = other.ret_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015296 RID: 86678 RVA: 0x00312002 File Offset: 0x00310202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerRequest Clone()
		{
			return new RogueBlackFlowerRequest(this);
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x06015297 RID: 86679 RVA: 0x0031200A File Offset: 0x0031020A
		// (set) Token: 0x06015298 RID: 86680 RVA: 0x00312012 File Offset: 0x00310212
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

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x06015299 RID: 86681 RVA: 0x0031201B File Offset: 0x0031021B
		// (set) Token: 0x0601529A RID: 86682 RVA: 0x00312023 File Offset: 0x00310223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ret
		{
			get
			{
				return this.ret_;
			}
			set
			{
				this.ret_ = value;
			}
		}

		// Token: 0x0601529B RID: 86683 RVA: 0x0031202C File Offset: 0x0031022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerRequest);
		}

		// Token: 0x0601529C RID: 86684 RVA: 0x0031203A File Offset: 0x0031023A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerRequest other)
		{
			return other != null && (other == this || (this.EntityConfigId == other.EntityConfigId && this.Ret == other.Ret && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601529D RID: 86685 RVA: 0x00312078 File Offset: 0x00310278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.Ret)
			{
				num ^= this.Ret.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601529E RID: 86686 RVA: 0x003120D0 File Offset: 0x003102D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601529F RID: 86687 RVA: 0x003120DD File Offset: 0x003102DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152A0 RID: 86688 RVA: 0x003120E8 File Offset: 0x003102E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Ret)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Ret);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152A1 RID: 86689 RVA: 0x00312144 File Offset: 0x00310344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.Ret)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060152A2 RID: 86690 RVA: 0x00312190 File Offset: 0x00310390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBlackFlowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.Ret)
			{
				this.Ret = other.Ret;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060152A3 RID: 86691 RVA: 0x003121E0 File Offset: 0x003103E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152A4 RID: 86692 RVA: 0x003121EC File Offset: 0x003103EC
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.Ret = input.ReadBool();
				}
			}
		}

		// Token: 0x04007FB6 RID: 32694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FB7 RID: 32695
		public const int EntityConfigIdFieldNumber = 14;

		// Token: 0x04007FB8 RID: 32696
		private int entityConfigId_;

		// Token: 0x04007FB9 RID: 32697
		public const int RetFieldNumber = 9;

		// Token: 0x04007FBA RID: 32698
		private bool ret_;
	}
}
