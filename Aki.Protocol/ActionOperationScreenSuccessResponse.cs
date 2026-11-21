using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000076 RID: 118
	[NetMessage(EMessageId.ActionOperationScreenSuccessResponse)]
	public sealed class ActionOperationScreenSuccessResponse : IMessage<ActionOperationScreenSuccessResponse>, IMessage, IEquatable<ActionOperationScreenSuccessResponse>, IDeepCloneable<ActionOperationScreenSuccessResponse>, IBufferMessage
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x0003F547 File Offset: 0x0003D747
		[NullableContext(1)]
		public static ActionOperationScreenSuccessResponse Create()
		{
			return new ActionOperationScreenSuccessResponse();
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0003F54E File Offset: 0x0003D74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x0003F551 File Offset: 0x0003D751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOperationScreenSuccessResponse.Descriptor;
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0003F558 File Offset: 0x0003D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse()
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0003F560 File Offset: 0x0003D760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse(ActionOperationScreenSuccessResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0003F585 File Offset: 0x0003D785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOperationScreenSuccessResponse Clone()
		{
			return new ActionOperationScreenSuccessResponse(this);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x0003F58D File Offset: 0x0003D78D
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0003F595 File Offset: 0x0003D795
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

		// Token: 0x06001827 RID: 6183 RVA: 0x0003F59E File Offset: 0x0003D79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOperationScreenSuccessResponse);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0003F5AC File Offset: 0x0003D7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOperationScreenSuccessResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0003F5DC File Offset: 0x0003D7DC
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

		// Token: 0x0600182A RID: 6186 RVA: 0x0003F621 File Offset: 0x0003D821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0003F62E File Offset: 0x0003D82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0003F637 File Offset: 0x0003D837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0003F66C File Offset: 0x0003D86C
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

		// Token: 0x0600182E RID: 6190 RVA: 0x0003F6AA File Offset: 0x0003D8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOperationScreenSuccessResponse other)
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

		// Token: 0x0600182F RID: 6191 RVA: 0x0003F6DB File Offset: 0x0003D8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0003F6E4 File Offset: 0x0003D8E4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040021B3 RID: 8627
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B4 RID: 8628
		public const int CodeFieldNumber = 12;

		// Token: 0x040021B5 RID: 8629
		private ErrorCode code_;
	}
}
