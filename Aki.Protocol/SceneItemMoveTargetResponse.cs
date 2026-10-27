using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116D RID: 4461
	[NetMessage(EMessageId.SceneItemMoveTargetResponse)]
	public sealed class SceneItemMoveTargetResponse : IMessage<SceneItemMoveTargetResponse>, IMessage, IEquatable<SceneItemMoveTargetResponse>, IDeepCloneable<SceneItemMoveTargetResponse>, IBufferMessage
	{
		// Token: 0x06017C8D RID: 97421 RVA: 0x003748C7 File Offset: 0x00372AC7
		[NullableContext(1)]
		public static SceneItemMoveTargetResponse Create()
		{
			return new SceneItemMoveTargetResponse();
		}

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06017C8E RID: 97422 RVA: 0x003748CE File Offset: 0x00372ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06017C8F RID: 97423 RVA: 0x003748D1 File Offset: 0x00372AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetResponse.Descriptor;
			}
		}

		// Token: 0x06017C90 RID: 97424 RVA: 0x003748D8 File Offset: 0x00372AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse()
		{
		}

		// Token: 0x06017C91 RID: 97425 RVA: 0x003748E0 File Offset: 0x00372AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse(SceneItemMoveTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C92 RID: 97426 RVA: 0x00374905 File Offset: 0x00372B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse Clone()
		{
			return new SceneItemMoveTargetResponse(this);
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06017C93 RID: 97427 RVA: 0x0037490D File Offset: 0x00372B0D
		// (set) Token: 0x06017C94 RID: 97428 RVA: 0x00374915 File Offset: 0x00372B15
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

		// Token: 0x06017C95 RID: 97429 RVA: 0x0037491E File Offset: 0x00372B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetResponse);
		}

		// Token: 0x06017C96 RID: 97430 RVA: 0x0037492C File Offset: 0x00372B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x0037495C File Offset: 0x00372B5C
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

		// Token: 0x06017C98 RID: 97432 RVA: 0x003749A1 File Offset: 0x00372BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C99 RID: 97433 RVA: 0x003749AE File Offset: 0x00372BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C9A RID: 97434 RVA: 0x003749B7 File Offset: 0x00372BB7
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

		// Token: 0x06017C9B RID: 97435 RVA: 0x003749EC File Offset: 0x00372BEC
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

		// Token: 0x06017C9C RID: 97436 RVA: 0x00374A2A File Offset: 0x00372C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetResponse other)
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

		// Token: 0x06017C9D RID: 97437 RVA: 0x00374A5B File Offset: 0x00372C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x00374A64 File Offset: 0x00372C64
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

		// Token: 0x04008D1C RID: 36124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D1D RID: 36125
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008D1E RID: 36126
		private ErrorCode errorCode_;
	}
}
