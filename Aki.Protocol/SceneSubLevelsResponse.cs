using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CB RID: 4555
	[NetMessage(EMessageId.SceneSubLevelsResponse)]
	public sealed class SceneSubLevelsResponse : IMessage<SceneSubLevelsResponse>, IMessage, IEquatable<SceneSubLevelsResponse>, IDeepCloneable<SceneSubLevelsResponse>, IBufferMessage
	{
		// Token: 0x0601851D RID: 99613 RVA: 0x0038A550 File Offset: 0x00388750
		[NullableContext(1)]
		public static SceneSubLevelsResponse Create()
		{
			return new SceneSubLevelsResponse();
		}

		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x0601851E RID: 99614 RVA: 0x0038A557 File Offset: 0x00388757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x0601851F RID: 99615 RVA: 0x0038A55A File Offset: 0x0038875A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsResponse.Descriptor;
			}
		}

		// Token: 0x06018520 RID: 99616 RVA: 0x0038A561 File Offset: 0x00388761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse()
		{
		}

		// Token: 0x06018521 RID: 99617 RVA: 0x0038A569 File Offset: 0x00388769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse(SceneSubLevelsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018522 RID: 99618 RVA: 0x0038A58E File Offset: 0x0038878E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse Clone()
		{
			return new SceneSubLevelsResponse(this);
		}

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x06018523 RID: 99619 RVA: 0x0038A596 File Offset: 0x00388796
		// (set) Token: 0x06018524 RID: 99620 RVA: 0x0038A59E File Offset: 0x0038879E
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

		// Token: 0x06018525 RID: 99621 RVA: 0x0038A5A7 File Offset: 0x003887A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsResponse);
		}

		// Token: 0x06018526 RID: 99622 RVA: 0x0038A5B5 File Offset: 0x003887B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018527 RID: 99623 RVA: 0x0038A5E4 File Offset: 0x003887E4
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

		// Token: 0x06018528 RID: 99624 RVA: 0x0038A629 File Offset: 0x00388829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018529 RID: 99625 RVA: 0x0038A636 File Offset: 0x00388836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601852A RID: 99626 RVA: 0x0038A63F File Offset: 0x0038883F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601852B RID: 99627 RVA: 0x0038A674 File Offset: 0x00388874
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

		// Token: 0x0601852C RID: 99628 RVA: 0x0038A6B2 File Offset: 0x003888B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSubLevelsResponse other)
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

		// Token: 0x0601852D RID: 99629 RVA: 0x0038A6E3 File Offset: 0x003888E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601852E RID: 99630 RVA: 0x0038A6EC File Offset: 0x003888EC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009092 RID: 37010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009093 RID: 37011
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009094 RID: 37012
		private ErrorCode errorCode_;
	}
}
