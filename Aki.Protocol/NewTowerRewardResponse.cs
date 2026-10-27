using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B45 RID: 2885
	[NetMessage(EMessageId.NewTowerRewardResponse)]
	public sealed class NewTowerRewardResponse : IMessage<NewTowerRewardResponse>, IMessage, IEquatable<NewTowerRewardResponse>, IDeepCloneable<NewTowerRewardResponse>, IBufferMessage
	{
		// Token: 0x0600FA53 RID: 64083 RVA: 0x00248199 File Offset: 0x00246399
		[NullableContext(1)]
		public static NewTowerRewardResponse Create()
		{
			return new NewTowerRewardResponse();
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600FA54 RID: 64084 RVA: 0x002481A0 File Offset: 0x002463A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600FA55 RID: 64085 RVA: 0x002481A3 File Offset: 0x002463A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600FA56 RID: 64086 RVA: 0x002481AA File Offset: 0x002463AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse()
		{
		}

		// Token: 0x0600FA57 RID: 64087 RVA: 0x002481B2 File Offset: 0x002463B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse(NewTowerRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA58 RID: 64088 RVA: 0x002481D7 File Offset: 0x002463D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardResponse Clone()
		{
			return new NewTowerRewardResponse(this);
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600FA59 RID: 64089 RVA: 0x002481DF File Offset: 0x002463DF
		// (set) Token: 0x0600FA5A RID: 64090 RVA: 0x002481E7 File Offset: 0x002463E7
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

		// Token: 0x0600FA5B RID: 64091 RVA: 0x002481F0 File Offset: 0x002463F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRewardResponse);
		}

		// Token: 0x0600FA5C RID: 64092 RVA: 0x002481FE File Offset: 0x002463FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA5D RID: 64093 RVA: 0x0024822C File Offset: 0x0024642C
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

		// Token: 0x0600FA5E RID: 64094 RVA: 0x00248271 File Offset: 0x00246471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA5F RID: 64095 RVA: 0x0024827E File Offset: 0x0024647E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA60 RID: 64096 RVA: 0x00248287 File Offset: 0x00246487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA61 RID: 64097 RVA: 0x002482BC File Offset: 0x002464BC
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

		// Token: 0x0600FA62 RID: 64098 RVA: 0x002482FA File Offset: 0x002464FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRewardResponse other)
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

		// Token: 0x0600FA63 RID: 64099 RVA: 0x0024832B File Offset: 0x0024652B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA64 RID: 64100 RVA: 0x00248334 File Offset: 0x00246534
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006440 RID: 25664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006441 RID: 25665
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006442 RID: 25666
		private ErrorCode errorCode_;
	}
}
