using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4A RID: 3146
	[NetMessage(EMessageId.PhantomBattleCardRewardResponse)]
	public sealed class PhantomBattleCardRewardResponse : IMessage<PhantomBattleCardRewardResponse>, IMessage, IEquatable<PhantomBattleCardRewardResponse>, IDeepCloneable<PhantomBattleCardRewardResponse>, IBufferMessage
	{
		// Token: 0x0601114A RID: 69962 RVA: 0x00280AF0 File Offset: 0x0027ECF0
		[NullableContext(1)]
		public static PhantomBattleCardRewardResponse Create()
		{
			return new PhantomBattleCardRewardResponse();
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0601114B RID: 69963 RVA: 0x00280AF7 File Offset: 0x0027ECF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0601114C RID: 69964 RVA: 0x00280AFA File Offset: 0x0027ECFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601114D RID: 69965 RVA: 0x00280B01 File Offset: 0x0027ED01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse()
		{
		}

		// Token: 0x0601114E RID: 69966 RVA: 0x00280B09 File Offset: 0x0027ED09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse(PhantomBattleCardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601114F RID: 69967 RVA: 0x00280B2E File Offset: 0x0027ED2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse Clone()
		{
			return new PhantomBattleCardRewardResponse(this);
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x06011150 RID: 69968 RVA: 0x00280B36 File Offset: 0x0027ED36
		// (set) Token: 0x06011151 RID: 69969 RVA: 0x00280B3E File Offset: 0x0027ED3E
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

		// Token: 0x06011152 RID: 69970 RVA: 0x00280B47 File Offset: 0x0027ED47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardResponse);
		}

		// Token: 0x06011153 RID: 69971 RVA: 0x00280B55 File Offset: 0x0027ED55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011154 RID: 69972 RVA: 0x00280B84 File Offset: 0x0027ED84
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

		// Token: 0x06011155 RID: 69973 RVA: 0x00280BC9 File Offset: 0x0027EDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011156 RID: 69974 RVA: 0x00280BD6 File Offset: 0x0027EDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011157 RID: 69975 RVA: 0x00280BDF File Offset: 0x0027EDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011158 RID: 69976 RVA: 0x00280C14 File Offset: 0x0027EE14
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

		// Token: 0x06011159 RID: 69977 RVA: 0x00280C52 File Offset: 0x0027EE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardResponse other)
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

		// Token: 0x0601115A RID: 69978 RVA: 0x00280C83 File Offset: 0x0027EE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601115B RID: 69979 RVA: 0x00280C8C File Offset: 0x0027EE8C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C97 RID: 27799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C98 RID: 27800
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006C99 RID: 27801
		private ErrorCode errorCode_;
	}
}
