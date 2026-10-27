using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C54 RID: 3156
	[NetMessage(EMessageId.PhantomBattleCardOutLookUpResponse)]
	public sealed class PhantomBattleCardOutLookUpResponse : IMessage<PhantomBattleCardOutLookUpResponse>, IMessage, IEquatable<PhantomBattleCardOutLookUpResponse>, IDeepCloneable<PhantomBattleCardOutLookUpResponse>, IBufferMessage
	{
		// Token: 0x060111D0 RID: 70096 RVA: 0x00281939 File Offset: 0x0027FB39
		[NullableContext(1)]
		public static PhantomBattleCardOutLookUpResponse Create()
		{
			return new PhantomBattleCardOutLookUpResponse();
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x060111D1 RID: 70097 RVA: 0x00281940 File Offset: 0x0027FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x060111D2 RID: 70098 RVA: 0x00281943 File Offset: 0x0027FB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardOutLookUpResponse.Descriptor;
			}
		}

		// Token: 0x060111D3 RID: 70099 RVA: 0x0028194A File Offset: 0x0027FB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse()
		{
		}

		// Token: 0x060111D4 RID: 70100 RVA: 0x00281952 File Offset: 0x0027FB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse(PhantomBattleCardOutLookUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111D5 RID: 70101 RVA: 0x00281977 File Offset: 0x0027FB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpResponse Clone()
		{
			return new PhantomBattleCardOutLookUpResponse(this);
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x060111D6 RID: 70102 RVA: 0x0028197F File Offset: 0x0027FB7F
		// (set) Token: 0x060111D7 RID: 70103 RVA: 0x00281987 File Offset: 0x0027FB87
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

		// Token: 0x060111D8 RID: 70104 RVA: 0x00281990 File Offset: 0x0027FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardOutLookUpResponse);
		}

		// Token: 0x060111D9 RID: 70105 RVA: 0x0028199E File Offset: 0x0027FB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardOutLookUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111DA RID: 70106 RVA: 0x002819CC File Offset: 0x0027FBCC
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

		// Token: 0x060111DB RID: 70107 RVA: 0x00281A11 File Offset: 0x0027FC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111DC RID: 70108 RVA: 0x00281A1E File Offset: 0x0027FC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111DD RID: 70109 RVA: 0x00281A27 File Offset: 0x0027FC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111DE RID: 70110 RVA: 0x00281A5C File Offset: 0x0027FC5C
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

		// Token: 0x060111DF RID: 70111 RVA: 0x00281A9A File Offset: 0x0027FC9A
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

		// Token: 0x060111E0 RID: 70112 RVA: 0x00281ACB File Offset: 0x0027FCCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111E1 RID: 70113 RVA: 0x00281AD4 File Offset: 0x0027FCD4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C62 RID: 27746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C63 RID: 27747
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006C64 RID: 27748
		private ErrorCode errorCode_;
	}
}
