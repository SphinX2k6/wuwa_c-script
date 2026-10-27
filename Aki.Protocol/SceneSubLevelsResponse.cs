using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001191 RID: 4497
	[NetMessage(EMessageId.SceneSubLevelsResponse)]
	public sealed class SceneSubLevelsResponse : IMessage<SceneSubLevelsResponse>, IMessage, IEquatable<SceneSubLevelsResponse>, IDeepCloneable<SceneSubLevelsResponse>, IBufferMessage
	{
		// Token: 0x06017F7C RID: 98172 RVA: 0x0037B210 File Offset: 0x00379410
		[NullableContext(1)]
		public static SceneSubLevelsResponse Create()
		{
			return new SceneSubLevelsResponse();
		}

		// Token: 0x1700508B RID: 20619
		// (get) Token: 0x06017F7D RID: 98173 RVA: 0x0037B217 File Offset: 0x00379417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700508C RID: 20620
		// (get) Token: 0x06017F7E RID: 98174 RVA: 0x0037B21A File Offset: 0x0037941A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsResponse.Descriptor;
			}
		}

		// Token: 0x06017F7F RID: 98175 RVA: 0x0037B221 File Offset: 0x00379421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse()
		{
		}

		// Token: 0x06017F80 RID: 98176 RVA: 0x0037B229 File Offset: 0x00379429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse(SceneSubLevelsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F81 RID: 98177 RVA: 0x0037B24E File Offset: 0x0037944E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsResponse Clone()
		{
			return new SceneSubLevelsResponse(this);
		}

		// Token: 0x1700508D RID: 20621
		// (get) Token: 0x06017F82 RID: 98178 RVA: 0x0037B256 File Offset: 0x00379456
		// (set) Token: 0x06017F83 RID: 98179 RVA: 0x0037B25E File Offset: 0x0037945E
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

		// Token: 0x06017F84 RID: 98180 RVA: 0x0037B267 File Offset: 0x00379467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsResponse);
		}

		// Token: 0x06017F85 RID: 98181 RVA: 0x0037B275 File Offset: 0x00379475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F86 RID: 98182 RVA: 0x0037B2A4 File Offset: 0x003794A4
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

		// Token: 0x06017F87 RID: 98183 RVA: 0x0037B2E9 File Offset: 0x003794E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F88 RID: 98184 RVA: 0x0037B2F6 File Offset: 0x003794F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F89 RID: 98185 RVA: 0x0037B2FF File Offset: 0x003794FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F8A RID: 98186 RVA: 0x0037B334 File Offset: 0x00379534
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

		// Token: 0x06017F8B RID: 98187 RVA: 0x0037B372 File Offset: 0x00379572
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

		// Token: 0x06017F8C RID: 98188 RVA: 0x0037B3A3 File Offset: 0x003795A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F8D RID: 98189 RVA: 0x0037B3AC File Offset: 0x003795AC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008DFF RID: 36351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E00 RID: 36352
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008E01 RID: 36353
		private ErrorCode errorCode_;
	}
}
