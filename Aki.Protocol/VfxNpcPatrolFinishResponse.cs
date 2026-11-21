using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001553 RID: 5459
	[NetMessage(EMessageId.VfxNpcPatrolFinishResponse)]
	public sealed class VfxNpcPatrolFinishResponse : IMessage<VfxNpcPatrolFinishResponse>, IMessage, IEquatable<VfxNpcPatrolFinishResponse>, IDeepCloneable<VfxNpcPatrolFinishResponse>, IBufferMessage
	{
		// Token: 0x0601CEAC RID: 118444 RVA: 0x00430A35 File Offset: 0x0042EC35
		[NullableContext(1)]
		public static VfxNpcPatrolFinishResponse Create()
		{
			return new VfxNpcPatrolFinishResponse();
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x0601CEAD RID: 118445 RVA: 0x00430A3C File Offset: 0x0042EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x0601CEAE RID: 118446 RVA: 0x00430A3F File Offset: 0x0042EC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VfxNpcPatrolFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601CEAF RID: 118447 RVA: 0x00430A46 File Offset: 0x0042EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse()
		{
		}

		// Token: 0x0601CEB0 RID: 118448 RVA: 0x00430A4E File Offset: 0x0042EC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse(VfxNpcPatrolFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEB1 RID: 118449 RVA: 0x00430A73 File Offset: 0x0042EC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse Clone()
		{
			return new VfxNpcPatrolFinishResponse(this);
		}

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x0601CEB2 RID: 118450 RVA: 0x00430A7B File Offset: 0x0042EC7B
		// (set) Token: 0x0601CEB3 RID: 118451 RVA: 0x00430A83 File Offset: 0x0042EC83
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

		// Token: 0x0601CEB4 RID: 118452 RVA: 0x00430A8C File Offset: 0x0042EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VfxNpcPatrolFinishResponse);
		}

		// Token: 0x0601CEB5 RID: 118453 RVA: 0x00430A9A File Offset: 0x0042EC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VfxNpcPatrolFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEB6 RID: 118454 RVA: 0x00430AC8 File Offset: 0x0042ECC8
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

		// Token: 0x0601CEB7 RID: 118455 RVA: 0x00430B0D File Offset: 0x0042ED0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEB8 RID: 118456 RVA: 0x00430B1A File Offset: 0x0042ED1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEB9 RID: 118457 RVA: 0x00430B23 File Offset: 0x0042ED23
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

		// Token: 0x0601CEBA RID: 118458 RVA: 0x00430B58 File Offset: 0x0042ED58
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

		// Token: 0x0601CEBB RID: 118459 RVA: 0x00430B96 File Offset: 0x0042ED96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VfxNpcPatrolFinishResponse other)
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

		// Token: 0x0601CEBC RID: 118460 RVA: 0x00430BC7 File Offset: 0x0042EDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEBD RID: 118461 RVA: 0x00430BD0 File Offset: 0x0042EDD0
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

		// Token: 0x0400A649 RID: 42569
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A64A RID: 42570
		public const int CodeFieldNumber = 6;

		// Token: 0x0400A64B RID: 42571
		private ErrorCode code_;
	}
}
