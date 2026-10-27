using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001178 RID: 4472
	[NetMessage(EMessageId.SceneItemStateResponse)]
	public sealed class SceneItemStateResponse : IMessage<SceneItemStateResponse>, IMessage, IEquatable<SceneItemStateResponse>, IDeepCloneable<SceneItemStateResponse>, IBufferMessage
	{
		// Token: 0x06017D6B RID: 97643 RVA: 0x0037668C File Offset: 0x0037488C
		[NullableContext(1)]
		public static SceneItemStateResponse Create()
		{
			return new SceneItemStateResponse();
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x06017D6C RID: 97644 RVA: 0x00376693 File Offset: 0x00374893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x06017D6D RID: 97645 RVA: 0x00376696 File Offset: 0x00374896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStateResponse.Descriptor;
			}
		}

		// Token: 0x06017D6E RID: 97646 RVA: 0x0037669D File Offset: 0x0037489D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse()
		{
		}

		// Token: 0x06017D6F RID: 97647 RVA: 0x003766A5 File Offset: 0x003748A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse(SceneItemStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D70 RID: 97648 RVA: 0x003766CA File Offset: 0x003748CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateResponse Clone()
		{
			return new SceneItemStateResponse(this);
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x06017D71 RID: 97649 RVA: 0x003766D2 File Offset: 0x003748D2
		// (set) Token: 0x06017D72 RID: 97650 RVA: 0x003766DA File Offset: 0x003748DA
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

		// Token: 0x06017D73 RID: 97651 RVA: 0x003766E3 File Offset: 0x003748E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStateResponse);
		}

		// Token: 0x06017D74 RID: 97652 RVA: 0x003766F1 File Offset: 0x003748F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D75 RID: 97653 RVA: 0x00376720 File Offset: 0x00374920
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

		// Token: 0x06017D76 RID: 97654 RVA: 0x00376765 File Offset: 0x00374965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D77 RID: 97655 RVA: 0x00376772 File Offset: 0x00374972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D78 RID: 97656 RVA: 0x0037677B File Offset: 0x0037497B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D79 RID: 97657 RVA: 0x003767B0 File Offset: 0x003749B0
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

		// Token: 0x06017D7A RID: 97658 RVA: 0x003767EE File Offset: 0x003749EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStateResponse other)
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

		// Token: 0x06017D7B RID: 97659 RVA: 0x0037681F File Offset: 0x00374A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D7C RID: 97660 RVA: 0x00376828 File Offset: 0x00374A28
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D55 RID: 36181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D56 RID: 36182
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008D57 RID: 36183
		private ErrorCode errorCode_;
	}
}
