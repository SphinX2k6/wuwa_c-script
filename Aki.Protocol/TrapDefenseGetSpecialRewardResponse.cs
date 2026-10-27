using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142A RID: 5162
	[NetMessage(EMessageId.TrapDefenseGetSpecialRewardResponse)]
	public sealed class TrapDefenseGetSpecialRewardResponse : IMessage<TrapDefenseGetSpecialRewardResponse>, IMessage, IEquatable<TrapDefenseGetSpecialRewardResponse>, IDeepCloneable<TrapDefenseGetSpecialRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B5A7 RID: 112039 RVA: 0x003F6588 File Offset: 0x003F4788
		[NullableContext(1)]
		public static TrapDefenseGetSpecialRewardResponse Create()
		{
			return new TrapDefenseGetSpecialRewardResponse();
		}

		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x0601B5A8 RID: 112040 RVA: 0x003F658F File Offset: 0x003F478F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x0601B5A9 RID: 112041 RVA: 0x003F6592 File Offset: 0x003F4792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetSpecialRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x003F6599 File Offset: 0x003F4799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse()
		{
		}

		// Token: 0x0601B5AB RID: 112043 RVA: 0x003F65A1 File Offset: 0x003F47A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse(TrapDefenseGetSpecialRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5AC RID: 112044 RVA: 0x003F65C6 File Offset: 0x003F47C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardResponse Clone()
		{
			return new TrapDefenseGetSpecialRewardResponse(this);
		}

		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x0601B5AD RID: 112045 RVA: 0x003F65CE File Offset: 0x003F47CE
		// (set) Token: 0x0601B5AE RID: 112046 RVA: 0x003F65D6 File Offset: 0x003F47D6
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

		// Token: 0x0601B5AF RID: 112047 RVA: 0x003F65DF File Offset: 0x003F47DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetSpecialRewardResponse);
		}

		// Token: 0x0601B5B0 RID: 112048 RVA: 0x003F65ED File Offset: 0x003F47ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetSpecialRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5B1 RID: 112049 RVA: 0x003F661C File Offset: 0x003F481C
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

		// Token: 0x0601B5B2 RID: 112050 RVA: 0x003F6661 File Offset: 0x003F4861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5B3 RID: 112051 RVA: 0x003F666E File Offset: 0x003F486E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5B4 RID: 112052 RVA: 0x003F6677 File Offset: 0x003F4877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5B5 RID: 112053 RVA: 0x003F66AC File Offset: 0x003F48AC
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

		// Token: 0x0601B5B6 RID: 112054 RVA: 0x003F66EA File Offset: 0x003F48EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetSpecialRewardResponse other)
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

		// Token: 0x0601B5B7 RID: 112055 RVA: 0x003F671B File Offset: 0x003F491B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5B8 RID: 112056 RVA: 0x003F6724 File Offset: 0x003F4924
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E00 RID: 40448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E01 RID: 40449
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009E02 RID: 40450
		private ErrorCode errorCode_;
	}
}
