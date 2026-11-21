using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B8 RID: 4536
	[NetMessage(EMessageId.SceneLoadingFinishResponse)]
	public sealed class SceneLoadingFinishResponse : IMessage<SceneLoadingFinishResponse>, IMessage, IEquatable<SceneLoadingFinishResponse>, IDeepCloneable<SceneLoadingFinishResponse>, IBufferMessage
	{
		// Token: 0x0601837E RID: 99198 RVA: 0x00386729 File Offset: 0x00384929
		[NullableContext(1)]
		public static SceneLoadingFinishResponse Create()
		{
			return new SceneLoadingFinishResponse();
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x0601837F RID: 99199 RVA: 0x00386730 File Offset: 0x00384930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x06018380 RID: 99200 RVA: 0x00386733 File Offset: 0x00384933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishResponse.Descriptor;
			}
		}

		// Token: 0x06018381 RID: 99201 RVA: 0x0038673A File Offset: 0x0038493A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse()
		{
		}

		// Token: 0x06018382 RID: 99202 RVA: 0x00386742 File Offset: 0x00384942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse(SceneLoadingFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x00386767 File Offset: 0x00384967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse Clone()
		{
			return new SceneLoadingFinishResponse(this);
		}

		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x06018384 RID: 99204 RVA: 0x0038676F File Offset: 0x0038496F
		// (set) Token: 0x06018385 RID: 99205 RVA: 0x00386777 File Offset: 0x00384977
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

		// Token: 0x06018386 RID: 99206 RVA: 0x00386780 File Offset: 0x00384980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishResponse);
		}

		// Token: 0x06018387 RID: 99207 RVA: 0x0038678E File Offset: 0x0038498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018388 RID: 99208 RVA: 0x003867BC File Offset: 0x003849BC
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

		// Token: 0x06018389 RID: 99209 RVA: 0x00386801 File Offset: 0x00384A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601838A RID: 99210 RVA: 0x0038680E File Offset: 0x00384A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601838B RID: 99211 RVA: 0x00386817 File Offset: 0x00384A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601838C RID: 99212 RVA: 0x0038684C File Offset: 0x00384A4C
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

		// Token: 0x0601838D RID: 99213 RVA: 0x0038688A File Offset: 0x00384A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingFinishResponse other)
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

		// Token: 0x0601838E RID: 99214 RVA: 0x003868BB File Offset: 0x00384ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601838F RID: 99215 RVA: 0x003868C4 File Offset: 0x00384AC4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009000 RID: 36864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009001 RID: 36865
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009002 RID: 36866
		private ErrorCode errorCode_;
	}
}
