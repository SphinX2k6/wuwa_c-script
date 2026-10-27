using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001519 RID: 5401
	[NetMessage(EMessageId.WorldEnterPermissionsResponse)]
	public sealed class WorldEnterPermissionsResponse : IMessage<WorldEnterPermissionsResponse>, IMessage, IEquatable<WorldEnterPermissionsResponse>, IDeepCloneable<WorldEnterPermissionsResponse>, IBufferMessage
	{
		// Token: 0x0601C89F RID: 116895 RVA: 0x0041EDDD File Offset: 0x0041CFDD
		[NullableContext(1)]
		public static WorldEnterPermissionsResponse Create()
		{
			return new WorldEnterPermissionsResponse();
		}

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x0601C8A0 RID: 116896 RVA: 0x0041EDE4 File Offset: 0x0041CFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x0601C8A1 RID: 116897 RVA: 0x0041EDE7 File Offset: 0x0041CFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldEnterPermissionsResponse.Descriptor;
			}
		}

		// Token: 0x0601C8A2 RID: 116898 RVA: 0x0041EDEE File Offset: 0x0041CFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse()
		{
		}

		// Token: 0x0601C8A3 RID: 116899 RVA: 0x0041EDF6 File Offset: 0x0041CFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse(WorldEnterPermissionsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8A4 RID: 116900 RVA: 0x0041EE27 File Offset: 0x0041D027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsResponse Clone()
		{
			return new WorldEnterPermissionsResponse(this);
		}

		// Token: 0x17006032 RID: 24626
		// (get) Token: 0x0601C8A5 RID: 116901 RVA: 0x0041EE2F File Offset: 0x0041D02F
		// (set) Token: 0x0601C8A6 RID: 116902 RVA: 0x0041EE37 File Offset: 0x0041D037
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

		// Token: 0x17006033 RID: 24627
		// (get) Token: 0x0601C8A7 RID: 116903 RVA: 0x0041EE40 File Offset: 0x0041D040
		// (set) Token: 0x0601C8A8 RID: 116904 RVA: 0x0041EE48 File Offset: 0x0041D048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermission Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0601C8A9 RID: 116905 RVA: 0x0041EE51 File Offset: 0x0041D051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldEnterPermissionsResponse);
		}

		// Token: 0x0601C8AA RID: 116906 RVA: 0x0041EE5F File Offset: 0x0041D05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldEnterPermissionsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8AB RID: 116907 RVA: 0x0041EEA0 File Offset: 0x0041D0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C8AC RID: 116908 RVA: 0x0041EF04 File Offset: 0x0041D104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8AD RID: 116909 RVA: 0x0041EF11 File Offset: 0x0041D111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8AE RID: 116910 RVA: 0x0041EF1C File Offset: 0x0041D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8AF RID: 116911 RVA: 0x0041EF78 File Offset: 0x0041D178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C8B0 RID: 116912 RVA: 0x0041EFD0 File Offset: 0x0041D1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldEnterPermissionsResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Type != WorldEnterPermission.ConfirmJoin)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8B1 RID: 116913 RVA: 0x0041F020 File Offset: 0x0041D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8B2 RID: 116914 RVA: 0x0041F02C File Offset: 0x0041D22C
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
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (WorldEnterPermission)input.ReadEnum();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A338 RID: 41784
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A339 RID: 41785
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A33A RID: 41786
		private ErrorCode errorCode_;

		// Token: 0x0400A33B RID: 41787
		public const int TypeFieldNumber = 15;

		// Token: 0x0400A33C RID: 41788
		private WorldEnterPermission type_;
	}
}
