using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000958 RID: 2392
	[NetMessage(EMessageId.LongShanTaskRewardResponse)]
	public sealed class LongShanTaskRewardResponse : IMessage<LongShanTaskRewardResponse>, IMessage, IEquatable<LongShanTaskRewardResponse>, IDeepCloneable<LongShanTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D2D7 RID: 53975 RVA: 0x001F1425 File Offset: 0x001EF625
		[NullableContext(1)]
		public static LongShanTaskRewardResponse Create()
		{
			return new LongShanTaskRewardResponse();
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600D2D8 RID: 53976 RVA: 0x001F142C File Offset: 0x001EF62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600D2D9 RID: 53977 RVA: 0x001F142F File Offset: 0x001EF62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x001F1436 File Offset: 0x001EF636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse()
		{
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x001F143E File Offset: 0x001EF63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse(LongShanTaskRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x001F1463 File Offset: 0x001EF663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanTaskRewardResponse Clone()
		{
			return new LongShanTaskRewardResponse(this);
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600D2DD RID: 53981 RVA: 0x001F146B File Offset: 0x001EF66B
		// (set) Token: 0x0600D2DE RID: 53982 RVA: 0x001F1473 File Offset: 0x001EF673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x001F147C File Offset: 0x001EF67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanTaskRewardResponse);
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x001F148A File Offset: 0x001EF68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanTaskRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x001F14B8 File Offset: 0x001EF6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x001F14FD File Offset: 0x001EF6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x001F150A File Offset: 0x001EF70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x001F1513 File Offset: 0x001EF713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x001F1548 File Offset: 0x001EF748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x001F1586 File Offset: 0x001EF786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2E7 RID: 53991 RVA: 0x001F15B7 File Offset: 0x001EF7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x001F15C0 File Offset: 0x001EF7C0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058B3 RID: 22707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058B4 RID: 22708
		public const int ErrorFieldNumber = 5;

		// Token: 0x040058B5 RID: 22709
		private ErrorCode error_;
	}
}
