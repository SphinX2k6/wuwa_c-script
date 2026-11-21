using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AF RID: 4527
	[NetMessage(EMessageId.SceneItemSetPosSenderResponse)]
	public sealed class SceneItemSetPosSenderResponse : IMessage<SceneItemSetPosSenderResponse>, IMessage, IEquatable<SceneItemSetPosSenderResponse>, IDeepCloneable<SceneItemSetPosSenderResponse>, IBufferMessage
	{
		// Token: 0x060182CE RID: 99022 RVA: 0x0038513C File Offset: 0x0038333C
		[NullableContext(1)]
		public static SceneItemSetPosSenderResponse Create()
		{
			return new SceneItemSetPosSenderResponse();
		}

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x060182CF RID: 99023 RVA: 0x00385143 File Offset: 0x00383343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x060182D0 RID: 99024 RVA: 0x00385146 File Offset: 0x00383346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderResponse.Descriptor;
			}
		}

		// Token: 0x060182D1 RID: 99025 RVA: 0x0038514D File Offset: 0x0038334D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse()
		{
		}

		// Token: 0x060182D2 RID: 99026 RVA: 0x00385155 File Offset: 0x00383355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse(SceneItemSetPosSenderResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182D3 RID: 99027 RVA: 0x0038517A File Offset: 0x0038337A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderResponse Clone()
		{
			return new SceneItemSetPosSenderResponse(this);
		}

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x060182D4 RID: 99028 RVA: 0x00385182 File Offset: 0x00383382
		// (set) Token: 0x060182D5 RID: 99029 RVA: 0x0038518A File Offset: 0x0038338A
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

		// Token: 0x060182D6 RID: 99030 RVA: 0x00385193 File Offset: 0x00383393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderResponse);
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x003851A1 File Offset: 0x003833A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x003851D0 File Offset: 0x003833D0
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

		// Token: 0x060182D9 RID: 99033 RVA: 0x00385215 File Offset: 0x00383415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182DA RID: 99034 RVA: 0x00385222 File Offset: 0x00383422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182DB RID: 99035 RVA: 0x0038522B File Offset: 0x0038342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182DC RID: 99036 RVA: 0x00385260 File Offset: 0x00383460
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

		// Token: 0x060182DD RID: 99037 RVA: 0x0038529E File Offset: 0x0038349E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderResponse other)
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

		// Token: 0x060182DE RID: 99038 RVA: 0x003852CF File Offset: 0x003834CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x003852D8 File Offset: 0x003834D8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FD7 RID: 36823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FD8 RID: 36824
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008FD9 RID: 36825
		private ErrorCode errorCode_;
	}
}
