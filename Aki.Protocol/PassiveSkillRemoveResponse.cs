using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC6 RID: 3014
	[NetMessage(EMessageId.PassiveSkillRemoveResponse)]
	public sealed class PassiveSkillRemoveResponse : IMessage<PassiveSkillRemoveResponse>, IMessage, IEquatable<PassiveSkillRemoveResponse>, IDeepCloneable<PassiveSkillRemoveResponse>, IBufferMessage
	{
		// Token: 0x06010583 RID: 66947 RVA: 0x0026277C File Offset: 0x0026097C
		[NullableContext(1)]
		public static PassiveSkillRemoveResponse Create()
		{
			return new PassiveSkillRemoveResponse();
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x06010584 RID: 66948 RVA: 0x00262783 File Offset: 0x00260983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x06010585 RID: 66949 RVA: 0x00262786 File Offset: 0x00260986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemoveResponse.Descriptor;
			}
		}

		// Token: 0x06010586 RID: 66950 RVA: 0x0026278D File Offset: 0x0026098D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse()
		{
		}

		// Token: 0x06010587 RID: 66951 RVA: 0x00262795 File Offset: 0x00260995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse(PassiveSkillRemoveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010588 RID: 66952 RVA: 0x002627BA File Offset: 0x002609BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemoveResponse Clone()
		{
			return new PassiveSkillRemoveResponse(this);
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x06010589 RID: 66953 RVA: 0x002627C2 File Offset: 0x002609C2
		// (set) Token: 0x0601058A RID: 66954 RVA: 0x002627CA File Offset: 0x002609CA
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

		// Token: 0x0601058B RID: 66955 RVA: 0x002627D3 File Offset: 0x002609D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemoveResponse);
		}

		// Token: 0x0601058C RID: 66956 RVA: 0x002627E1 File Offset: 0x002609E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemoveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601058D RID: 66957 RVA: 0x00262810 File Offset: 0x00260A10
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

		// Token: 0x0601058E RID: 66958 RVA: 0x00262855 File Offset: 0x00260A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601058F RID: 66959 RVA: 0x00262862 File Offset: 0x00260A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010590 RID: 66960 RVA: 0x0026286B File Offset: 0x00260A6B
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

		// Token: 0x06010591 RID: 66961 RVA: 0x002628A0 File Offset: 0x00260AA0
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

		// Token: 0x06010592 RID: 66962 RVA: 0x002628DE File Offset: 0x00260ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemoveResponse other)
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

		// Token: 0x06010593 RID: 66963 RVA: 0x0026290F File Offset: 0x00260B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010594 RID: 66964 RVA: 0x00262918 File Offset: 0x00260B18
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

		// Token: 0x04006825 RID: 26661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006826 RID: 26662
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006827 RID: 26663
		private ErrorCode errorCode_;
	}
}
