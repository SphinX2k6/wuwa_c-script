using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000954 RID: 2388
	[NetMessage(EMessageId.LordGymReadResponse)]
	public sealed class LordGymReadResponse : IMessage<LordGymReadResponse>, IMessage, IEquatable<LordGymReadResponse>, IDeepCloneable<LordGymReadResponse>, IBufferMessage
	{
		// Token: 0x0600D2C6 RID: 53958 RVA: 0x001F15BD File Offset: 0x001EF7BD
		[NullableContext(1)]
		public static LordGymReadResponse Create()
		{
			return new LordGymReadResponse();
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600D2C7 RID: 53959 RVA: 0x001F15C4 File Offset: 0x001EF7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x001F15C7 File Offset: 0x001EF7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymReadResponse.Descriptor;
			}
		}

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x001F15CE File Offset: 0x001EF7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse()
		{
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x001F15D6 File Offset: 0x001EF7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse(LordGymReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x001F15FB File Offset: 0x001EF7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadResponse Clone()
		{
			return new LordGymReadResponse(this);
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x001F1603 File Offset: 0x001EF803
		// (set) Token: 0x0600D2CD RID: 53965 RVA: 0x001F160B File Offset: 0x001EF80B
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

		// Token: 0x0600D2CE RID: 53966 RVA: 0x001F1614 File Offset: 0x001EF814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymReadResponse);
		}

		// Token: 0x0600D2CF RID: 53967 RVA: 0x001F1622 File Offset: 0x001EF822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2D0 RID: 53968 RVA: 0x001F1650 File Offset: 0x001EF850
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

		// Token: 0x0600D2D1 RID: 53969 RVA: 0x001F1695 File Offset: 0x001EF895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2D2 RID: 53970 RVA: 0x001F16A2 File Offset: 0x001EF8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2D3 RID: 53971 RVA: 0x001F16AB File Offset: 0x001EF8AB
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

		// Token: 0x0600D2D4 RID: 53972 RVA: 0x001F16E0 File Offset: 0x001EF8E0
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

		// Token: 0x0600D2D5 RID: 53973 RVA: 0x001F171E File Offset: 0x001EF91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymReadResponse other)
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

		// Token: 0x0600D2D6 RID: 53974 RVA: 0x001F174F File Offset: 0x001EF94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2D7 RID: 53975 RVA: 0x001F1758 File Offset: 0x001EF958
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

		// Token: 0x0400590D RID: 22797
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400590E RID: 22798
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400590F RID: 22799
		private ErrorCode errorCode_;
	}
}
