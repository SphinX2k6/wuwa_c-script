using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001518 RID: 5400
	[NetMessage(EMessageId.UpdatePlayerPassiveSkillResponse)]
	public sealed class UpdatePlayerPassiveSkillResponse : IMessage<UpdatePlayerPassiveSkillResponse>, IMessage, IEquatable<UpdatePlayerPassiveSkillResponse>, IDeepCloneable<UpdatePlayerPassiveSkillResponse>, IBufferMessage
	{
		// Token: 0x0601C9C6 RID: 117190 RVA: 0x0042578E File Offset: 0x0042398E
		[NullableContext(1)]
		public static UpdatePlayerPassiveSkillResponse Create()
		{
			return new UpdatePlayerPassiveSkillResponse();
		}

		// Token: 0x170060C8 RID: 24776
		// (get) Token: 0x0601C9C7 RID: 117191 RVA: 0x00425795 File Offset: 0x00423995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060C9 RID: 24777
		// (get) Token: 0x0601C9C8 RID: 117192 RVA: 0x00425798 File Offset: 0x00423998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerPassiveSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x0042579F File Offset: 0x0042399F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse()
		{
		}

		// Token: 0x0601C9CA RID: 117194 RVA: 0x004257A7 File Offset: 0x004239A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse(UpdatePlayerPassiveSkillResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9CB RID: 117195 RVA: 0x004257CC File Offset: 0x004239CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse Clone()
		{
			return new UpdatePlayerPassiveSkillResponse(this);
		}

		// Token: 0x170060CA RID: 24778
		// (get) Token: 0x0601C9CC RID: 117196 RVA: 0x004257D4 File Offset: 0x004239D4
		// (set) Token: 0x0601C9CD RID: 117197 RVA: 0x004257DC File Offset: 0x004239DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601C9CE RID: 117198 RVA: 0x004257E5 File Offset: 0x004239E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerPassiveSkillResponse);
		}

		// Token: 0x0601C9CF RID: 117199 RVA: 0x004257F3 File Offset: 0x004239F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerPassiveSkillResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9D0 RID: 117200 RVA: 0x00425824 File Offset: 0x00423A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9D1 RID: 117201 RVA: 0x00425869 File Offset: 0x00423A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9D2 RID: 117202 RVA: 0x00425876 File Offset: 0x00423A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9D3 RID: 117203 RVA: 0x0042587F File Offset: 0x00423A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9D4 RID: 117204 RVA: 0x004258B4 File Offset: 0x00423AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9D5 RID: 117205 RVA: 0x004258F2 File Offset: 0x00423AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerPassiveSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9D6 RID: 117206 RVA: 0x00425923 File Offset: 0x00423B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9D7 RID: 117207 RVA: 0x0042592C File Offset: 0x00423B2C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A4E1 RID: 42209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4E2 RID: 42210
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x0400A4E3 RID: 42211
		private ErrorCode errCode_;
	}
}
