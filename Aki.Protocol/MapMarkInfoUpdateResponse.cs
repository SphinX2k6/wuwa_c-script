using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098B RID: 2443
	[NetMessage(EMessageId.MapMarkInfoUpdateResponse)]
	public sealed class MapMarkInfoUpdateResponse : IMessage<MapMarkInfoUpdateResponse>, IMessage, IEquatable<MapMarkInfoUpdateResponse>, IDeepCloneable<MapMarkInfoUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600D6C0 RID: 54976 RVA: 0x001F952F File Offset: 0x001F772F
		[NullableContext(1)]
		public static MapMarkInfoUpdateResponse Create()
		{
			return new MapMarkInfoUpdateResponse();
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x001F9536 File Offset: 0x001F7736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x001F9539 File Offset: 0x001F7739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x001F9540 File Offset: 0x001F7740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse()
		{
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x001F9548 File Offset: 0x001F7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse(MapMarkInfoUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x001F956D File Offset: 0x001F776D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse Clone()
		{
			return new MapMarkInfoUpdateResponse(this);
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x001F9575 File Offset: 0x001F7775
		// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x001F957D File Offset: 0x001F777D
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

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x001F9586 File Offset: 0x001F7786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoUpdateResponse);
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x001F9594 File Offset: 0x001F7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x001F95C4 File Offset: 0x001F77C4
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

		// Token: 0x0600D6CB RID: 54987 RVA: 0x001F9609 File Offset: 0x001F7809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x001F9616 File Offset: 0x001F7816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x001F961F File Offset: 0x001F781F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x001F9650 File Offset: 0x001F7850
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

		// Token: 0x0600D6CF RID: 54991 RVA: 0x001F968E File Offset: 0x001F788E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoUpdateResponse other)
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

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x001F96BF File Offset: 0x001F78BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x001F96C8 File Offset: 0x001F78C8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059BE RID: 22974
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059BF RID: 22975
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040059C0 RID: 22976
		private ErrorCode errorCode_;
	}
}
