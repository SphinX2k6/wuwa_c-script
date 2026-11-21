using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001242 RID: 4674
	[NetMessage(EMessageId.ShortMessageReadResponse)]
	public sealed class ShortMessageReadResponse : IMessage<ShortMessageReadResponse>, IMessage, IEquatable<ShortMessageReadResponse>, IDeepCloneable<ShortMessageReadResponse>, IBufferMessage
	{
		// Token: 0x06018F66 RID: 102246 RVA: 0x003A3CAD File Offset: 0x003A1EAD
		[NullableContext(1)]
		public static ShortMessageReadResponse Create()
		{
			return new ShortMessageReadResponse();
		}

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x06018F67 RID: 102247 RVA: 0x003A3CB4 File Offset: 0x003A1EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x06018F68 RID: 102248 RVA: 0x003A3CB7 File Offset: 0x003A1EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReadResponse.Descriptor;
			}
		}

		// Token: 0x06018F69 RID: 102249 RVA: 0x003A3CBE File Offset: 0x003A1EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse()
		{
		}

		// Token: 0x06018F6A RID: 102250 RVA: 0x003A3CC6 File Offset: 0x003A1EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse(ShortMessageReadResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F6B RID: 102251 RVA: 0x003A3CEB File Offset: 0x003A1EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReadResponse Clone()
		{
			return new ShortMessageReadResponse(this);
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x06018F6C RID: 102252 RVA: 0x003A3CF3 File Offset: 0x003A1EF3
		// (set) Token: 0x06018F6D RID: 102253 RVA: 0x003A3CFB File Offset: 0x003A1EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018F6E RID: 102254 RVA: 0x003A3D04 File Offset: 0x003A1F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReadResponse);
		}

		// Token: 0x06018F6F RID: 102255 RVA: 0x003A3D12 File Offset: 0x003A1F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReadResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x003A3D40 File Offset: 0x003A1F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F71 RID: 102257 RVA: 0x003A3D85 File Offset: 0x003A1F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F72 RID: 102258 RVA: 0x003A3D92 File Offset: 0x003A1F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F73 RID: 102259 RVA: 0x003A3D9B File Offset: 0x003A1F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F74 RID: 102260 RVA: 0x003A3DD0 File Offset: 0x003A1FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F75 RID: 102261 RVA: 0x003A3E0E File Offset: 0x003A200E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F76 RID: 102262 RVA: 0x003A3E3F File Offset: 0x003A203F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F77 RID: 102263 RVA: 0x003A3E48 File Offset: 0x003A2048
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009416 RID: 37910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009417 RID: 37911
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04009418 RID: 37912
		private ErrorCode errCode_;
	}
}
