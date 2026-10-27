using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DD RID: 5341
	[NetMessage(EMessageId.VfxNpcPatrolFinishResponse)]
	public sealed class VfxNpcPatrolFinishResponse : IMessage<VfxNpcPatrolFinishResponse>, IMessage, IEquatable<VfxNpcPatrolFinishResponse>, IDeepCloneable<VfxNpcPatrolFinishResponse>, IBufferMessage
	{
		// Token: 0x0601C3E5 RID: 115685 RVA: 0x00414F79 File Offset: 0x00413179
		[NullableContext(1)]
		public static VfxNpcPatrolFinishResponse Create()
		{
			return new VfxNpcPatrolFinishResponse();
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x0601C3E6 RID: 115686 RVA: 0x00414F80 File Offset: 0x00413180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x0601C3E7 RID: 115687 RVA: 0x00414F83 File Offset: 0x00413183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VfxNpcPatrolFinishResponse.Descriptor;
			}
		}

		// Token: 0x0601C3E8 RID: 115688 RVA: 0x00414F8A File Offset: 0x0041318A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse()
		{
		}

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x00414F92 File Offset: 0x00413192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse(VfxNpcPatrolFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3EA RID: 115690 RVA: 0x00414FB7 File Offset: 0x004131B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VfxNpcPatrolFinishResponse Clone()
		{
			return new VfxNpcPatrolFinishResponse(this);
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x0601C3EB RID: 115691 RVA: 0x00414FBF File Offset: 0x004131BF
		// (set) Token: 0x0601C3EC RID: 115692 RVA: 0x00414FC7 File Offset: 0x004131C7
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

		// Token: 0x0601C3ED RID: 115693 RVA: 0x00414FD0 File Offset: 0x004131D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VfxNpcPatrolFinishResponse);
		}

		// Token: 0x0601C3EE RID: 115694 RVA: 0x00414FDE File Offset: 0x004131DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VfxNpcPatrolFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3EF RID: 115695 RVA: 0x0041500C File Offset: 0x0041320C
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

		// Token: 0x0601C3F0 RID: 115696 RVA: 0x00415051 File Offset: 0x00413251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3F1 RID: 115697 RVA: 0x0041505E File Offset: 0x0041325E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3F2 RID: 115698 RVA: 0x00415067 File Offset: 0x00413267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3F3 RID: 115699 RVA: 0x0041509C File Offset: 0x0041329C
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

		// Token: 0x0601C3F4 RID: 115700 RVA: 0x004150DA File Offset: 0x004132DA
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

		// Token: 0x0601C3F5 RID: 115701 RVA: 0x0041510B File Offset: 0x0041330B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3F6 RID: 115702 RVA: 0x00415114 File Offset: 0x00413314
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1F0 RID: 41456
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1F1 RID: 41457
		public const int CodeFieldNumber = 15;

		// Token: 0x0400A1F2 RID: 41458
		private ErrorCode code_;
	}
}
