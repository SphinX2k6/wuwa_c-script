using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000159 RID: 345
	[NetMessage(EMessageId.BabelTowerTaskRewardResponse)]
	public sealed class BabelTowerTaskRewardResponse : IMessage<BabelTowerTaskRewardResponse>, IMessage, IEquatable<BabelTowerTaskRewardResponse>, IDeepCloneable<BabelTowerTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06002BBA RID: 11194 RVA: 0x000722D6 File Offset: 0x000704D6
		[NullableContext(1)]
		public static BabelTowerTaskRewardResponse Create()
		{
			return new BabelTowerTaskRewardResponse();
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000722DD File Offset: 0x000704DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000722E0 File Offset: 0x000704E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000722E7 File Offset: 0x000704E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse()
		{
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000722EF File Offset: 0x000704EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse(BabelTowerTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00072314 File Offset: 0x00070514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerTaskRewardResponse Clone()
		{
			return new BabelTowerTaskRewardResponse(this);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0007231C File Offset: 0x0007051C
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x00072324 File Offset: 0x00070524
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

		// Token: 0x06002BC2 RID: 11202 RVA: 0x0007232D File Offset: 0x0007052D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerTaskRewardResponse);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x0007233B File Offset: 0x0007053B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x0007236C File Offset: 0x0007056C
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

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000723B1 File Offset: 0x000705B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000723BE File Offset: 0x000705BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000723C7 File Offset: 0x000705C7
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

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000723FC File Offset: 0x000705FC
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

		// Token: 0x06002BC9 RID: 11209 RVA: 0x0007243A File Offset: 0x0007063A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerTaskRewardResponse other)
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

		// Token: 0x06002BCA RID: 11210 RVA: 0x0007246B File Offset: 0x0007066B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00072474 File Offset: 0x00070674
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

		// Token: 0x04002809 RID: 10249
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400280A RID: 10250
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400280B RID: 10251
		private ErrorCode errorCode_;
	}
}
