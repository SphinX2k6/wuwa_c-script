using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117E RID: 4478
	[NetMessage(EMessageId.SceneLoadingFinishResponse)]
	public sealed class SceneLoadingFinishResponse : IMessage<SceneLoadingFinishResponse>, IMessage, IEquatable<SceneLoadingFinishResponse>, IDeepCloneable<SceneLoadingFinishResponse>, IBufferMessage
	{
		// Token: 0x06017DDD RID: 97757 RVA: 0x003773E5 File Offset: 0x003755E5
		[NullableContext(1)]
		public static SceneLoadingFinishResponse Create()
		{
			return new SceneLoadingFinishResponse();
		}

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x06017DDE RID: 97758 RVA: 0x003773EC File Offset: 0x003755EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x06017DDF RID: 97759 RVA: 0x003773EF File Offset: 0x003755EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishResponse.Descriptor;
			}
		}

		// Token: 0x06017DE0 RID: 97760 RVA: 0x003773F6 File Offset: 0x003755F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse()
		{
		}

		// Token: 0x06017DE1 RID: 97761 RVA: 0x003773FE File Offset: 0x003755FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse(SceneLoadingFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DE2 RID: 97762 RVA: 0x00377423 File Offset: 0x00375623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishResponse Clone()
		{
			return new SceneLoadingFinishResponse(this);
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x06017DE3 RID: 97763 RVA: 0x0037742B File Offset: 0x0037562B
		// (set) Token: 0x06017DE4 RID: 97764 RVA: 0x00377433 File Offset: 0x00375633
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

		// Token: 0x06017DE5 RID: 97765 RVA: 0x0037743C File Offset: 0x0037563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishResponse);
		}

		// Token: 0x06017DE6 RID: 97766 RVA: 0x0037744A File Offset: 0x0037564A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DE7 RID: 97767 RVA: 0x00377478 File Offset: 0x00375678
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

		// Token: 0x06017DE8 RID: 97768 RVA: 0x003774BD File Offset: 0x003756BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DE9 RID: 97769 RVA: 0x003774CA File Offset: 0x003756CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DEA RID: 97770 RVA: 0x003774D3 File Offset: 0x003756D3
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

		// Token: 0x06017DEB RID: 97771 RVA: 0x00377508 File Offset: 0x00375708
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

		// Token: 0x06017DEC RID: 97772 RVA: 0x00377546 File Offset: 0x00375746
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

		// Token: 0x06017DED RID: 97773 RVA: 0x00377577 File Offset: 0x00375777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DEE RID: 97774 RVA: 0x00377580 File Offset: 0x00375780
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

		// Token: 0x04008D6D RID: 36205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D6E RID: 36206
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04008D6F RID: 36207
		private ErrorCode errorCode_;
	}
}
