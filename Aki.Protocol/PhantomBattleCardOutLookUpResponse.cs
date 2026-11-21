using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C44 RID: 3140
	[NetMessage(EMessageId.PhantomBattleCardOutLookUpResponse)]
	public sealed class PhantomBattleCardOutLookUpResponse : IMessage<PhantomBattleCardOutLookUpResponse>, IMessage, IEquatable<PhantomBattleCardOutLookUpResponse>, IDeepCloneable<PhantomBattleCardOutLookUpResponse>, IBufferMessage
	{
		// Token: 0x060110D0 RID: 69840 RVA: 0x0027FBC9 File Offset: 0x0027DDC9
		[NullableContext(1)]
		public static PhantomBattleCardOutLookUpResponse Create()
		{
			return new PhantomBattleCardOutLookUpResponse();
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x060110D1 RID: 69841 RVA: 0x0027FBD0 File Offset: 0x0027DDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x060110D2 RID: 69842 RVA: 0x0027FBD3 File Offset: 0x0027DDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardOutLookUpResponse.Descriptor;
			}
		}

		// Token: 0x060110D3 RID: 69843 RVA: 0x0027FBDA File Offset: 0x0027DDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse()
		{
		}

		// Token: 0x060110D4 RID: 69844 RVA: 0x0027FBE2 File Offset: 0x0027DDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse(PhantomBattleCardOutLookUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110D5 RID: 69845 RVA: 0x0027FC07 File Offset: 0x0027DE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse Clone()
		{
			return new PhantomBattleCardOutLookUpResponse(this);
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x060110D6 RID: 69846 RVA: 0x0027FC0F File Offset: 0x0027DE0F
		// (set) Token: 0x060110D7 RID: 69847 RVA: 0x0027FC17 File Offset: 0x0027DE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060110D8 RID: 69848 RVA: 0x0027FC20 File Offset: 0x0027DE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardOutLookUpResponse);
		}

		// Token: 0x060110D9 RID: 69849 RVA: 0x0027FC2E File Offset: 0x0027DE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardOutLookUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110DA RID: 69850 RVA: 0x0027FC5C File Offset: 0x0027DE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110DB RID: 69851 RVA: 0x0027FCA1 File Offset: 0x0027DEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110DC RID: 69852 RVA: 0x0027FCAE File Offset: 0x0027DEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110DD RID: 69853 RVA: 0x0027FCB7 File Offset: 0x0027DEB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110DE RID: 69854 RVA: 0x0027FCEC File Offset: 0x0027DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110DF RID: 69855 RVA: 0x0027FD2A File Offset: 0x0027DF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardOutLookUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110E0 RID: 69856 RVA: 0x0027FD5B File Offset: 0x0027DF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110E1 RID: 69857 RVA: 0x0027FD64 File Offset: 0x0027DF64
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C76 RID: 27766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C77 RID: 27767
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006C78 RID: 27768
		private ErrorCode errorCode_;
	}
}
