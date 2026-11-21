using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000868 RID: 2152
	[NetMessage(EMessageId.JokerGuessUseSkillRequest)]
	public sealed class JokerGuessUseSkillRequest : IMessage<JokerGuessUseSkillRequest>, IMessage, IEquatable<JokerGuessUseSkillRequest>, IDeepCloneable<JokerGuessUseSkillRequest>, IBufferMessage
	{
		// Token: 0x0600C009 RID: 49161 RVA: 0x001C8AFE File Offset: 0x001C6CFE
		[NullableContext(1)]
		public static JokerGuessUseSkillRequest Create()
		{
			return new JokerGuessUseSkillRequest();
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x0600C00A RID: 49162 RVA: 0x001C8B05 File Offset: 0x001C6D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x0600C00B RID: 49163 RVA: 0x001C8B08 File Offset: 0x001C6D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessUseSkillRequest.Descriptor;
			}
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x001C8B0F File Offset: 0x001C6D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest()
		{
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x001C8B17 File Offset: 0x001C6D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest(JokerGuessUseSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.op_ = other.op_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x001C8B48 File Offset: 0x001C6D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillRequest Clone()
		{
			return new JokerGuessUseSkillRequest(this);
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600C00F RID: 49167 RVA: 0x001C8B50 File Offset: 0x001C6D50
		// (set) Token: 0x0600C010 RID: 49168 RVA: 0x001C8B58 File Offset: 0x001C6D58
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

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x0600C011 RID: 49169 RVA: 0x001C8B61 File Offset: 0x001C6D61
		// (set) Token: 0x0600C012 RID: 49170 RVA: 0x001C8B69 File Offset: 0x001C6D69
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

		// Token: 0x0600C013 RID: 49171 RVA: 0x001C8B72 File Offset: 0x001C6D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessUseSkillRequest);
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x001C8B80 File Offset: 0x001C6D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessUseSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Op == other.Op && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C015 RID: 49173 RVA: 0x001C8BC0 File Offset: 0x001C6DC0
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

		// Token: 0x0600C016 RID: 49174 RVA: 0x001C8C1E File Offset: 0x001C6E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C017 RID: 49175 RVA: 0x001C8C2B File Offset: 0x001C6E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x001C8C34 File Offset: 0x001C6E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillId);
			}
			if (this.Op != JokerGuessSkillOp.Use)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Op);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x001C8C90 File Offset: 0x001C6E90
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

		// Token: 0x0600C01A RID: 49178 RVA: 0x001C8CE8 File Offset: 0x001C6EE8
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

		// Token: 0x0600C01B RID: 49179 RVA: 0x001C8D38 File Offset: 0x001C6F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x001C8D44 File Offset: 0x001C6F44
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Op = (JokerGuessSkillOp)input.ReadEnum();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053D8 RID: 21464
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D9 RID: 21465
		public const int SkillIdFieldNumber = 4;

		// Token: 0x040053DA RID: 21466
		private int skillId_;

		// Token: 0x040053DB RID: 21467
		public const int OpFieldNumber = 6;

		// Token: 0x040053DC RID: 21468
		private JokerGuessSkillOp op_;
	}
}
