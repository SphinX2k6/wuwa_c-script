using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000287 RID: 647
	[NetMessage(EMessageId.CheckUseSoundBoxSkillResponse)]
	public sealed class CheckUseSoundBoxSkillResponse : IMessage<CheckUseSoundBoxSkillResponse>, IMessage, IEquatable<CheckUseSoundBoxSkillResponse>, IDeepCloneable<CheckUseSoundBoxSkillResponse>, IBufferMessage
	{
		// Token: 0x0600439E RID: 17310 RVA: 0x000A5A4A File Offset: 0x000A3C4A
		[NullableContext(1)]
		public static CheckUseSoundBoxSkillResponse Create()
		{
			return new CheckUseSoundBoxSkillResponse();
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x000A5A51 File Offset: 0x000A3C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x000A5A54 File Offset: 0x000A3C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckUseSoundBoxSkillResponse.Descriptor;
			}
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000A5A5B File Offset: 0x000A3C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse()
		{
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000A5A63 File Offset: 0x000A3C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse(CheckUseSoundBoxSkillResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x000A5A88 File Offset: 0x000A3C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckUseSoundBoxSkillResponse Clone()
		{
			return new CheckUseSoundBoxSkillResponse(this);
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x000A5A90 File Offset: 0x000A3C90
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x000A5A98 File Offset: 0x000A3C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000A5AA1 File Offset: 0x000A3CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckUseSoundBoxSkillResponse);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000A5AAF File Offset: 0x000A3CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckUseSoundBoxSkillResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000A5AE0 File Offset: 0x000A3CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000A5B25 File Offset: 0x000A3D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x000A5B32 File Offset: 0x000A3D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x000A5B3B File Offset: 0x000A3D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x000A5B70 File Offset: 0x000A3D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000A5BAE File Offset: 0x000A3DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckUseSoundBoxSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000A5BDF File Offset: 0x000A3DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x000A5BE8 File Offset: 0x000A3DE8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E5C RID: 11868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E5D RID: 11869
		public const int CodeFieldNumber = 3;

		// Token: 0x04002E5E RID: 11870
		private ErrorCode code_;
	}
}
