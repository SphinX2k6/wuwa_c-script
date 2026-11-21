using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006D RID: 109
	[NetMessage(EMessageId.ActionFinishResponse)]
	public sealed class ActionFinishResponse : IMessage<ActionFinishResponse>, IMessage, IEquatable<ActionFinishResponse>, IDeepCloneable<ActionFinishResponse>, IBufferMessage
	{
		// Token: 0x06001749 RID: 5961 RVA: 0x0003CE2D File Offset: 0x0003B02D
		[NullableContext(1)]
		public static ActionFinishResponse Create()
		{
			return new ActionFinishResponse();
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0003CE34 File Offset: 0x0003B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x0003CE37 File Offset: 0x0003B037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0003CE3E File Offset: 0x0003B03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse()
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0003CE46 File Offset: 0x0003B046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse(ActionFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0003CE6B File Offset: 0x0003B06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishResponse Clone()
		{
			return new ActionFinishResponse(this);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0003CE73 File Offset: 0x0003B073
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x0003CE7B File Offset: 0x0003B07B
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

		// Token: 0x06001751 RID: 5969 RVA: 0x0003CE84 File Offset: 0x0003B084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishResponse);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0003CE92 File Offset: 0x0003B092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
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

		// Token: 0x06001754 RID: 5972 RVA: 0x0003CF05 File Offset: 0x0003B105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0003CF12 File Offset: 0x0003B112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0003CF1B File Offset: 0x0003B11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0003CF50 File Offset: 0x0003B150
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

		// Token: 0x06001758 RID: 5976 RVA: 0x0003CF8E File Offset: 0x0003B18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishResponse other)
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

		// Token: 0x06001759 RID: 5977 RVA: 0x0003CFBF File Offset: 0x0003B1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400216C RID: 8556
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400216D RID: 8557
		public const int CodeFieldNumber = 3;

		// Token: 0x0400216E RID: 8558
		private ErrorCode code_;
	}
}
