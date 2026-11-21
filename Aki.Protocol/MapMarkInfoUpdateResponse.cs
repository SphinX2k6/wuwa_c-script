using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097A RID: 2426
	[NetMessage(EMessageId.MapMarkInfoUpdateResponse)]
	public sealed class MapMarkInfoUpdateResponse : IMessage<MapMarkInfoUpdateResponse>, IMessage, IEquatable<MapMarkInfoUpdateResponse>, IDeepCloneable<MapMarkInfoUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600D5A6 RID: 54694 RVA: 0x001F7346 File Offset: 0x001F5546
		[NullableContext(1)]
		public static MapMarkInfoUpdateResponse Create()
		{
			return new MapMarkInfoUpdateResponse();
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x001F734D File Offset: 0x001F554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600D5A8 RID: 54696 RVA: 0x001F7350 File Offset: 0x001F5550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x001F7357 File Offset: 0x001F5557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse()
		{
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x001F735F File Offset: 0x001F555F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse(MapMarkInfoUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x001F7384 File Offset: 0x001F5584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoUpdateResponse Clone()
		{
			return new MapMarkInfoUpdateResponse(this);
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x001F738C File Offset: 0x001F558C
		// (set) Token: 0x0600D5AD RID: 54701 RVA: 0x001F7394 File Offset: 0x001F5594
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

		// Token: 0x0600D5AE RID: 54702 RVA: 0x001F739D File Offset: 0x001F559D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoUpdateResponse);
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x001F73AB File Offset: 0x001F55AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x001F73DC File Offset: 0x001F55DC
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

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x001F7421 File Offset: 0x001F5621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x001F742E File Offset: 0x001F562E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x001F7437 File Offset: 0x001F5637
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

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x001F746C File Offset: 0x001F566C
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

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x001F74AA File Offset: 0x001F56AA
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

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x001F74DB File Offset: 0x001F56DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x001F74E4 File Offset: 0x001F56E4
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

		// Token: 0x040059C7 RID: 22983
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C8 RID: 22984
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040059C9 RID: 22985
		private ErrorCode errorCode_;
	}
}
