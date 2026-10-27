using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098D RID: 2445
	[NetMessage(EMessageId.MapMarkResponse)]
	public sealed class MapMarkResponse : IMessage<MapMarkResponse>, IMessage, IEquatable<MapMarkResponse>, IDeepCloneable<MapMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D6EA RID: 55018 RVA: 0x001F9BA3 File Offset: 0x001F7DA3
		[NullableContext(1)]
		public static MapMarkResponse Create()
		{
			return new MapMarkResponse();
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x001F9BAA File Offset: 0x001F7DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600D6EC RID: 55020 RVA: 0x001F9BAD File Offset: 0x001F7DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D6ED RID: 55021 RVA: 0x001F9BB4 File Offset: 0x001F7DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse()
		{
		}

		// Token: 0x0600D6EE RID: 55022 RVA: 0x001F9BBC File Offset: 0x001F7DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse(MapMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6EF RID: 55023 RVA: 0x001F9C08 File Offset: 0x001F7E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse Clone()
		{
			return new MapMarkResponse(this);
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600D6F0 RID: 55024 RVA: 0x001F9C10 File Offset: 0x001F7E10
		// (set) Token: 0x0600D6F1 RID: 55025 RVA: 0x001F9C18 File Offset: 0x001F7E18
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

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600D6F2 RID: 55026 RVA: 0x001F9C21 File Offset: 0x001F7E21
		// (set) Token: 0x0600D6F3 RID: 55027 RVA: 0x001F9C29 File Offset: 0x001F7E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x0600D6F4 RID: 55028 RVA: 0x001F9C32 File Offset: 0x001F7E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkResponse);
		}

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x001F9C40 File Offset: 0x001F7E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x001F9C90 File Offset: 0x001F7E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x001F9CEB File Offset: 0x001F7EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6F8 RID: 55032 RVA: 0x001F9CF8 File Offset: 0x001F7EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6F9 RID: 55033 RVA: 0x001F9D04 File Offset: 0x001F7F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Info);
			}
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

		// Token: 0x0600D6FA RID: 55034 RVA: 0x001F9D60 File Offset: 0x001F7F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6FB RID: 55035 RVA: 0x001F9DB8 File Offset: 0x001F7FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new MarkPointInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x001F9E20 File Offset: 0x001F8020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x001F9E2C File Offset: 0x001F802C
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
				if (num != 82U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new MarkPointInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x040059C8 RID: 22984
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C9 RID: 22985
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040059CA RID: 22986
		private ErrorCode errorCode_;

		// Token: 0x040059CB RID: 22987
		public const int InfoFieldNumber = 10;

		// Token: 0x040059CC RID: 22988
		private MarkPointInfo info_;
	}
}
