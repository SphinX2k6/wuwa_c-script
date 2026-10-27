using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000879 RID: 2169
	[NetMessage(EMessageId.JokerGuessUseSkillRequest)]
	public sealed class JokerGuessUseSkillRequest : IMessage<JokerGuessUseSkillRequest>, IMessage, IEquatable<JokerGuessUseSkillRequest>, IDeepCloneable<JokerGuessUseSkillRequest>, IBufferMessage
	{
		// Token: 0x0600C125 RID: 49445 RVA: 0x001CADE5 File Offset: 0x001C8FE5
		[NullableContext(1)]
		public static JokerGuessUseSkillRequest Create()
		{
			return new JokerGuessUseSkillRequest();
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600C126 RID: 49446 RVA: 0x001CADEC File Offset: 0x001C8FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600C127 RID: 49447 RVA: 0x001CADEF File Offset: 0x001C8FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessUseSkillRequest.Descriptor;
			}
		}

		// Token: 0x0600C128 RID: 49448 RVA: 0x001CADF6 File Offset: 0x001C8FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest()
		{
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x001CADFE File Offset: 0x001C8FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest(JokerGuessUseSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.op_ = other.op_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x001CAE2F File Offset: 0x001C902F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest Clone()
		{
			return new JokerGuessUseSkillRequest(this);
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600C12B RID: 49451 RVA: 0x001CAE37 File Offset: 0x001C9037
		// (set) Token: 0x0600C12C RID: 49452 RVA: 0x001CAE3F File Offset: 0x001C903F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600C12D RID: 49453 RVA: 0x001CAE48 File Offset: 0x001C9048
		// (set) Token: 0x0600C12E RID: 49454 RVA: 0x001CAE50 File Offset: 0x001C9050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillOp Op
		{
			get
			{
				return this.op_;
			}
			set
			{
				this.op_ = value;
			}
		}

		// Token: 0x0600C12F RID: 49455 RVA: 0x001CAE59 File Offset: 0x001C9059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessUseSkillRequest);
		}

		// Token: 0x0600C130 RID: 49456 RVA: 0x001CAE67 File Offset: 0x001C9067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessUseSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Op == other.Op && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C131 RID: 49457 RVA: 0x001CAEA8 File Offset: 0x001C90A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Op != JokerGuessSkillOp.Use)
			{
				num ^= this.Op.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C132 RID: 49458 RVA: 0x001CAF06 File Offset: 0x001C9106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x001CAF13 File Offset: 0x001C9113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C134 RID: 49460 RVA: 0x001CAF1C File Offset: 0x001C911C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Op != JokerGuessSkillOp.Use)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Op);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x001CAF78 File Offset: 0x001C9178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Op != JokerGuessSkillOp.Use)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Op);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C136 RID: 49462 RVA: 0x001CAFD0 File Offset: 0x001C91D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessUseSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Op != JokerGuessSkillOp.Use)
			{
				this.Op = other.Op;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x001CB020 File Offset: 0x001C9220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C138 RID: 49464 RVA: 0x001CB02C File Offset: 0x001C922C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.Op = (JokerGuessSkillOp)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053D1 RID: 21457
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D2 RID: 21458
		public const int SkillIdFieldNumber = 13;

		// Token: 0x040053D3 RID: 21459
		private int skillId_;

		// Token: 0x040053D4 RID: 21460
		public const int OpFieldNumber = 6;

		// Token: 0x040053D5 RID: 21461
		private JokerGuessSkillOp op_;
	}
}
