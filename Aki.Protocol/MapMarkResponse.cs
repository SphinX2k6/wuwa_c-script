using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097C RID: 2428
	[NetMessage(EMessageId.MapMarkResponse)]
	public sealed class MapMarkResponse : IMessage<MapMarkResponse>, IMessage, IEquatable<MapMarkResponse>, IDeepCloneable<MapMarkResponse>, IBufferMessage
	{
		// Token: 0x0600D5D0 RID: 54736 RVA: 0x001F79B6 File Offset: 0x001F5BB6
		[NullableContext(1)]
		public static MapMarkResponse Create()
		{
			return new MapMarkResponse();
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x001F79BD File Offset: 0x001F5BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x001F79C0 File Offset: 0x001F5BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkResponse.Descriptor;
			}
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x001F79C7 File Offset: 0x001F5BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse()
		{
		}

		// Token: 0x0600D5D4 RID: 54740 RVA: 0x001F79D0 File Offset: 0x001F5BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse(MapMarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5D5 RID: 54741 RVA: 0x001F7A1C File Offset: 0x001F5C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkResponse Clone()
		{
			return new MapMarkResponse(this);
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x001F7A24 File Offset: 0x001F5C24
		// (set) Token: 0x0600D5D7 RID: 54743 RVA: 0x001F7A2C File Offset: 0x001F5C2C
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

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x001F7A35 File Offset: 0x001F5C35
		// (set) Token: 0x0600D5D9 RID: 54745 RVA: 0x001F7A3D File Offset: 0x001F5C3D
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

		// Token: 0x0600D5DA RID: 54746 RVA: 0x001F7A46 File Offset: 0x001F5C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkResponse);
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x001F7A54 File Offset: 0x001F5C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x001F7AA4 File Offset: 0x001F5CA4
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

		// Token: 0x0600D5DD RID: 54749 RVA: 0x001F7AFF File Offset: 0x001F5CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x001F7B0C File Offset: 0x001F5D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x001F7B18 File Offset: 0x001F5D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Info);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x001F7B74 File Offset: 0x001F5D74
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

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x001F7BCC File Offset: 0x001F5DCC
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

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x001F7C34 File Offset: 0x001F5E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x001F7C40 File Offset: 0x001F5E40
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
				if (num != 66U)
				{
					if (num != 120U)
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

		// Token: 0x040059D1 RID: 22993
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059D2 RID: 22994
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040059D3 RID: 22995
		private ErrorCode errorCode_;

		// Token: 0x040059D4 RID: 22996
		public const int InfoFieldNumber = 8;

		// Token: 0x040059D5 RID: 22997
		private MarkPointInfo info_;
	}
}
