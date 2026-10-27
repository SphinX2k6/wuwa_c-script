using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128D RID: 4749
	[NetMessage(EMessageId.StartMatchResponse)]
	public sealed class StartMatchResponse : IMessage<StartMatchResponse>, IMessage, IEquatable<StartMatchResponse>, IDeepCloneable<StartMatchResponse>, IBufferMessage
	{
		// Token: 0x0601949A RID: 103578 RVA: 0x003AD6F7 File Offset: 0x003AB8F7
		[NullableContext(1)]
		public static StartMatchResponse Create()
		{
			return new StartMatchResponse();
		}

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x0601949B RID: 103579 RVA: 0x003AD6FE File Offset: 0x003AB8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x0601949C RID: 103580 RVA: 0x003AD701 File Offset: 0x003AB901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchResponse.Descriptor;
			}
		}

		// Token: 0x0601949D RID: 103581 RVA: 0x003AD708 File Offset: 0x003AB908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse()
		{
		}

		// Token: 0x0601949E RID: 103582 RVA: 0x003AD710 File Offset: 0x003AB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse(StartMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601949F RID: 103583 RVA: 0x003AD735 File Offset: 0x003AB935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchResponse Clone()
		{
			return new StartMatchResponse(this);
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x060194A0 RID: 103584 RVA: 0x003AD73D File Offset: 0x003AB93D
		// (set) Token: 0x060194A1 RID: 103585 RVA: 0x003AD745 File Offset: 0x003AB945
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

		// Token: 0x060194A2 RID: 103586 RVA: 0x003AD74E File Offset: 0x003AB94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchResponse);
		}

		// Token: 0x060194A3 RID: 103587 RVA: 0x003AD75C File Offset: 0x003AB95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194A4 RID: 103588 RVA: 0x003AD78C File Offset: 0x003AB98C
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

		// Token: 0x060194A5 RID: 103589 RVA: 0x003AD7D1 File Offset: 0x003AB9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194A6 RID: 103590 RVA: 0x003AD7DE File Offset: 0x003AB9DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194A7 RID: 103591 RVA: 0x003AD7E7 File Offset: 0x003AB9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194A8 RID: 103592 RVA: 0x003AD81C File Offset: 0x003ABA1C
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

		// Token: 0x060194A9 RID: 103593 RVA: 0x003AD85A File Offset: 0x003ABA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchResponse other)
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

		// Token: 0x060194AA RID: 103594 RVA: 0x003AD88B File Offset: 0x003ABA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194AB RID: 103595 RVA: 0x003AD894 File Offset: 0x003ABA94
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094B0 RID: 38064
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094B1 RID: 38065
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040094B2 RID: 38066
		private ErrorCode errorCode_;
	}
}
