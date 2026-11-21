using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA4 RID: 3236
	[NetMessage(EMessageId.PhantomBattleSelectTargetResponse)]
	public sealed class PhantomBattleSelectTargetResponse : IMessage<PhantomBattleSelectTargetResponse>, IMessage, IEquatable<PhantomBattleSelectTargetResponse>, IDeepCloneable<PhantomBattleSelectTargetResponse>, IBufferMessage
	{
		// Token: 0x060118D6 RID: 71894 RVA: 0x002927C1 File Offset: 0x002909C1
		[NullableContext(1)]
		public static PhantomBattleSelectTargetResponse Create()
		{
			return new PhantomBattleSelectTargetResponse();
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x060118D7 RID: 71895 RVA: 0x002927C8 File Offset: 0x002909C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x060118D8 RID: 71896 RVA: 0x002927CB File Offset: 0x002909CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetResponse.Descriptor;
			}
		}

		// Token: 0x060118D9 RID: 71897 RVA: 0x002927D2 File Offset: 0x002909D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse()
		{
		}

		// Token: 0x060118DA RID: 71898 RVA: 0x002927DA File Offset: 0x002909DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse(PhantomBattleSelectTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118DB RID: 71899 RVA: 0x002927FF File Offset: 0x002909FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetResponse Clone()
		{
			return new PhantomBattleSelectTargetResponse(this);
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x060118DC RID: 71900 RVA: 0x00292807 File Offset: 0x00290A07
		// (set) Token: 0x060118DD RID: 71901 RVA: 0x0029280F File Offset: 0x00290A0F
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

		// Token: 0x060118DE RID: 71902 RVA: 0x00292818 File Offset: 0x00290A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetResponse);
		}

		// Token: 0x060118DF RID: 71903 RVA: 0x00292826 File Offset: 0x00290A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118E0 RID: 71904 RVA: 0x00292854 File Offset: 0x00290A54
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

		// Token: 0x060118E1 RID: 71905 RVA: 0x00292899 File Offset: 0x00290A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118E2 RID: 71906 RVA: 0x002928A6 File Offset: 0x00290AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118E3 RID: 71907 RVA: 0x002928AF File Offset: 0x00290AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118E4 RID: 71908 RVA: 0x002928E4 File Offset: 0x00290AE4
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

		// Token: 0x060118E5 RID: 71909 RVA: 0x00292922 File Offset: 0x00290B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectTargetResponse other)
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

		// Token: 0x060118E6 RID: 71910 RVA: 0x00292953 File Offset: 0x00290B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118E7 RID: 71911 RVA: 0x0029295C File Offset: 0x00290B5C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F03 RID: 28419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F04 RID: 28420
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006F05 RID: 28421
		private ErrorCode errorCode_;
	}
}
