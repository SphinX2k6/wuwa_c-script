using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C7 RID: 4295
	[NetMessage(EMessageId.RoleTrainResponse)]
	public sealed class RoleTrainResponse : IMessage<RoleTrainResponse>, IMessage, IEquatable<RoleTrainResponse>, IDeepCloneable<RoleTrainResponse>, IBufferMessage
	{
		// Token: 0x06016EB3 RID: 93875 RVA: 0x00353CAC File Offset: 0x00351EAC
		[NullableContext(1)]
		public static RoleTrainResponse Create()
		{
			return new RoleTrainResponse();
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x06016EB4 RID: 93876 RVA: 0x00353CB3 File Offset: 0x00351EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x06016EB5 RID: 93877 RVA: 0x00353CB6 File Offset: 0x00351EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrainResponse.Descriptor;
			}
		}

		// Token: 0x06016EB6 RID: 93878 RVA: 0x00353CBD File Offset: 0x00351EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse()
		{
		}

		// Token: 0x06016EB7 RID: 93879 RVA: 0x00353CC5 File Offset: 0x00351EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse(RoleTrainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.greatSucc_ = other.greatSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EB8 RID: 93880 RVA: 0x00353CF6 File Offset: 0x00351EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse Clone()
		{
			return new RoleTrainResponse(this);
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x06016EB9 RID: 93881 RVA: 0x00353CFE File Offset: 0x00351EFE
		// (set) Token: 0x06016EBA RID: 93882 RVA: 0x00353D06 File Offset: 0x00351F06
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

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x06016EBB RID: 93883 RVA: 0x00353D0F File Offset: 0x00351F0F
		// (set) Token: 0x06016EBC RID: 93884 RVA: 0x00353D17 File Offset: 0x00351F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GreatSucc
		{
			get
			{
				return this.greatSucc_;
			}
			set
			{
				this.greatSucc_ = value;
			}
		}

		// Token: 0x06016EBD RID: 93885 RVA: 0x00353D20 File Offset: 0x00351F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrainResponse);
		}

		// Token: 0x06016EBE RID: 93886 RVA: 0x00353D2E File Offset: 0x00351F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.GreatSucc == other.GreatSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EBF RID: 93887 RVA: 0x00353D6C File Offset: 0x00351F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.GreatSucc)
			{
				num ^= this.GreatSucc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EC0 RID: 93888 RVA: 0x00353DCA File Offset: 0x00351FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EC1 RID: 93889 RVA: 0x00353DD7 File Offset: 0x00351FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EC2 RID: 93890 RVA: 0x00353DE0 File Offset: 0x00351FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.GreatSucc)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.GreatSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EC3 RID: 93891 RVA: 0x00353E3C File Offset: 0x0035203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.GreatSucc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EC4 RID: 93892 RVA: 0x00353E88 File Offset: 0x00352088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.GreatSucc)
			{
				this.GreatSucc = other.GreatSucc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EC5 RID: 93893 RVA: 0x00353ED8 File Offset: 0x003520D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EC6 RID: 93894 RVA: 0x00353EE4 File Offset: 0x003520E4
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
				if (num != 64U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GreatSucc = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008890 RID: 34960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008891 RID: 34961
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008892 RID: 34962
		private ErrorCode errorCode_;

		// Token: 0x04008893 RID: 34963
		public const int GreatSuccFieldNumber = 15;

		// Token: 0x04008894 RID: 34964
		private bool greatSucc_;
	}
}
