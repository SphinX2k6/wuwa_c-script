using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AC RID: 4524
	[NetMessage(EMessageId.SceneItemSequenceFrameStartResponse)]
	public sealed class SceneItemSequenceFrameStartResponse : IMessage<SceneItemSequenceFrameStartResponse>, IMessage, IEquatable<SceneItemSequenceFrameStartResponse>, IDeepCloneable<SceneItemSequenceFrameStartResponse>, IBufferMessage
	{
		// Token: 0x06018294 RID: 98964 RVA: 0x00384A3D File Offset: 0x00382C3D
		[NullableContext(1)]
		public static SceneItemSequenceFrameStartResponse Create()
		{
			return new SceneItemSequenceFrameStartResponse();
		}

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x06018295 RID: 98965 RVA: 0x00384A44 File Offset: 0x00382C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x06018296 RID: 98966 RVA: 0x00384A47 File Offset: 0x00382C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameStartResponse.Descriptor;
			}
		}

		// Token: 0x06018297 RID: 98967 RVA: 0x00384A4E File Offset: 0x00382C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse()
		{
		}

		// Token: 0x06018298 RID: 98968 RVA: 0x00384A56 File Offset: 0x00382C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse(SceneItemSequenceFrameStartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018299 RID: 98969 RVA: 0x00384A7B File Offset: 0x00382C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse Clone()
		{
			return new SceneItemSequenceFrameStartResponse(this);
		}

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x0601829A RID: 98970 RVA: 0x00384A83 File Offset: 0x00382C83
		// (set) Token: 0x0601829B RID: 98971 RVA: 0x00384A8B File Offset: 0x00382C8B
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

		// Token: 0x0601829C RID: 98972 RVA: 0x00384A94 File Offset: 0x00382C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameStartResponse);
		}

		// Token: 0x0601829D RID: 98973 RVA: 0x00384AA2 File Offset: 0x00382CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601829E RID: 98974 RVA: 0x00384AD0 File Offset: 0x00382CD0
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

		// Token: 0x0601829F RID: 98975 RVA: 0x00384B15 File Offset: 0x00382D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182A0 RID: 98976 RVA: 0x00384B22 File Offset: 0x00382D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182A1 RID: 98977 RVA: 0x00384B2B File Offset: 0x00382D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182A2 RID: 98978 RVA: 0x00384B5C File Offset: 0x00382D5C
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

		// Token: 0x060182A3 RID: 98979 RVA: 0x00384B9A File Offset: 0x00382D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameStartResponse other)
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

		// Token: 0x060182A4 RID: 98980 RVA: 0x00384BCB File Offset: 0x00382DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182A5 RID: 98981 RVA: 0x00384BD4 File Offset: 0x00382DD4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FCA RID: 36810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FCB RID: 36811
		public const int CodeFieldNumber = 1;

		// Token: 0x04008FCC RID: 36812
		private ErrorCode code_;
	}
}
