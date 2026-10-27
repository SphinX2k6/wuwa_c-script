using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133C RID: 4924
	[NetMessage(EMessageId.TeleportFlowEndResponse)]
	public sealed class TeleportFlowEndResponse : IMessage<TeleportFlowEndResponse>, IMessage, IEquatable<TeleportFlowEndResponse>, IDeepCloneable<TeleportFlowEndResponse>, IBufferMessage
	{
		// Token: 0x0601A281 RID: 107137 RVA: 0x003CC619 File Offset: 0x003CA819
		[NullableContext(1)]
		public static TeleportFlowEndResponse Create()
		{
			return new TeleportFlowEndResponse();
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0601A282 RID: 107138 RVA: 0x003CC620 File Offset: 0x003CA820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x0601A283 RID: 107139 RVA: 0x003CC623 File Offset: 0x003CA823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowEndResponse.Descriptor;
			}
		}

		// Token: 0x0601A284 RID: 107140 RVA: 0x003CC62A File Offset: 0x003CA82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse()
		{
		}

		// Token: 0x0601A285 RID: 107141 RVA: 0x003CC632 File Offset: 0x003CA832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse(TeleportFlowEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A286 RID: 107142 RVA: 0x003CC657 File Offset: 0x003CA857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndResponse Clone()
		{
			return new TeleportFlowEndResponse(this);
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x0601A287 RID: 107143 RVA: 0x003CC65F File Offset: 0x003CA85F
		// (set) Token: 0x0601A288 RID: 107144 RVA: 0x003CC667 File Offset: 0x003CA867
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

		// Token: 0x0601A289 RID: 107145 RVA: 0x003CC670 File Offset: 0x003CA870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowEndResponse);
		}

		// Token: 0x0601A28A RID: 107146 RVA: 0x003CC67E File Offset: 0x003CA87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A28B RID: 107147 RVA: 0x003CC6AC File Offset: 0x003CA8AC
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

		// Token: 0x0601A28C RID: 107148 RVA: 0x003CC6F1 File Offset: 0x003CA8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A28D RID: 107149 RVA: 0x003CC6FE File Offset: 0x003CA8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A28E RID: 107150 RVA: 0x003CC707 File Offset: 0x003CA907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A28F RID: 107151 RVA: 0x003CC73C File Offset: 0x003CA93C
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

		// Token: 0x0601A290 RID: 107152 RVA: 0x003CC77A File Offset: 0x003CA97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowEndResponse other)
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

		// Token: 0x0601A291 RID: 107153 RVA: 0x003CC7AB File Offset: 0x003CA9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A292 RID: 107154 RVA: 0x003CC7B4 File Offset: 0x003CA9B4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009897 RID: 39063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009898 RID: 39064
		public const int CodeFieldNumber = 6;

		// Token: 0x04009899 RID: 39065
		private ErrorCode code_;
	}
}
