using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000205 RID: 517
	[NetMessage(EMessageId.BuffEffectResponse)]
	public sealed class BuffEffectResponse : IMessage<BuffEffectResponse>, IMessage, IEquatable<BuffEffectResponse>, IDeepCloneable<BuffEffectResponse>, IBufferMessage
	{
		// Token: 0x0600395B RID: 14683 RVA: 0x0008F5AC File Offset: 0x0008D7AC
		[NullableContext(1)]
		public static BuffEffectResponse Create()
		{
			return new BuffEffectResponse();
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x0008F5B3 File Offset: 0x0008D7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0008F5B6 File Offset: 0x0008D7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectResponse.Descriptor;
			}
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x0008F5BD File Offset: 0x0008D7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse()
		{
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0008F5C5 File Offset: 0x0008D7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse(BuffEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0008F5EA File Offset: 0x0008D7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectResponse Clone()
		{
			return new BuffEffectResponse(this);
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0008F5F2 File Offset: 0x0008D7F2
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x0008F5FA File Offset: 0x0008D7FA
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

		// Token: 0x06003963 RID: 14691 RVA: 0x0008F603 File Offset: 0x0008D803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectResponse);
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x0008F611 File Offset: 0x0008D811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0008F640 File Offset: 0x0008D840
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

		// Token: 0x06003966 RID: 14694 RVA: 0x0008F685 File Offset: 0x0008D885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0008F692 File Offset: 0x0008D892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0008F69B File Offset: 0x0008D89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x0008F6D0 File Offset: 0x0008D8D0
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

		// Token: 0x0600396A RID: 14698 RVA: 0x0008F70E File Offset: 0x0008D90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectResponse other)
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

		// Token: 0x0600396B RID: 14699 RVA: 0x0008F73F File Offset: 0x0008D93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0008F748 File Offset: 0x0008D948
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002BC9 RID: 11209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BCA RID: 11210
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x04002BCB RID: 11211
		private ErrorCode errCode_;
	}
}
