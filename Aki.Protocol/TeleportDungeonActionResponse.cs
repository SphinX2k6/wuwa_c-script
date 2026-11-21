using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AA RID: 5034
	[NetMessage(EMessageId.TeleportDungeonActionResponse)]
	public sealed class TeleportDungeonActionResponse : IMessage<TeleportDungeonActionResponse>, IMessage, IEquatable<TeleportDungeonActionResponse>, IDeepCloneable<TeleportDungeonActionResponse>, IBufferMessage
	{
		// Token: 0x0601ACB0 RID: 109744 RVA: 0x003E6E72 File Offset: 0x003E5072
		[NullableContext(1)]
		public static TeleportDungeonActionResponse Create()
		{
			return new TeleportDungeonActionResponse();
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x0601ACB1 RID: 109745 RVA: 0x003E6E79 File Offset: 0x003E5079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x0601ACB2 RID: 109746 RVA: 0x003E6E7C File Offset: 0x003E507C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionResponse.Descriptor;
			}
		}

		// Token: 0x0601ACB3 RID: 109747 RVA: 0x003E6E83 File Offset: 0x003E5083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse()
		{
		}

		// Token: 0x0601ACB4 RID: 109748 RVA: 0x003E6E8B File Offset: 0x003E508B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse(TeleportDungeonActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACB5 RID: 109749 RVA: 0x003E6EB0 File Offset: 0x003E50B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionResponse Clone()
		{
			return new TeleportDungeonActionResponse(this);
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x0601ACB6 RID: 109750 RVA: 0x003E6EB8 File Offset: 0x003E50B8
		// (set) Token: 0x0601ACB7 RID: 109751 RVA: 0x003E6EC0 File Offset: 0x003E50C0
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

		// Token: 0x0601ACB8 RID: 109752 RVA: 0x003E6EC9 File Offset: 0x003E50C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionResponse);
		}

		// Token: 0x0601ACB9 RID: 109753 RVA: 0x003E6ED7 File Offset: 0x003E50D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACBA RID: 109754 RVA: 0x003E6F08 File Offset: 0x003E5108
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

		// Token: 0x0601ACBB RID: 109755 RVA: 0x003E6F4D File Offset: 0x003E514D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACBC RID: 109756 RVA: 0x003E6F5A File Offset: 0x003E515A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACBD RID: 109757 RVA: 0x003E6F63 File Offset: 0x003E5163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACBE RID: 109758 RVA: 0x003E6F94 File Offset: 0x003E5194
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

		// Token: 0x0601ACBF RID: 109759 RVA: 0x003E6FD2 File Offset: 0x003E51D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionResponse other)
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

		// Token: 0x0601ACC0 RID: 109760 RVA: 0x003E7003 File Offset: 0x003E5203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACC1 RID: 109761 RVA: 0x003E700C File Offset: 0x003E520C
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009CCC RID: 40140
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CCD RID: 40141
		public const int CodeFieldNumber = 1;

		// Token: 0x04009CCE RID: 40142
		private ErrorCode code_;
	}
}
