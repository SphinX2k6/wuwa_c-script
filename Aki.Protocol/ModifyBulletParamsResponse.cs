using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EA RID: 2538
	[NetMessage(EMessageId.ModifyBulletParamsResponse)]
	public sealed class ModifyBulletParamsResponse : IMessage<ModifyBulletParamsResponse>, IMessage, IEquatable<ModifyBulletParamsResponse>, IDeepCloneable<ModifyBulletParamsResponse>, IBufferMessage
	{
		// Token: 0x0600DE57 RID: 56919 RVA: 0x00209C18 File Offset: 0x00207E18
		[NullableContext(1)]
		public static ModifyBulletParamsResponse Create()
		{
			return new ModifyBulletParamsResponse();
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600DE58 RID: 56920 RVA: 0x00209C1F File Offset: 0x00207E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x00209C22 File Offset: 0x00207E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsResponse.Descriptor;
			}
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x00209C29 File Offset: 0x00207E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse()
		{
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x00209C31 File Offset: 0x00207E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse(ModifyBulletParamsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x00209C56 File Offset: 0x00207E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse Clone()
		{
			return new ModifyBulletParamsResponse(this);
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x00209C5E File Offset: 0x00207E5E
		// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x00209C66 File Offset: 0x00207E66
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

		// Token: 0x0600DE5F RID: 56927 RVA: 0x00209C6F File Offset: 0x00207E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsResponse);
		}

		// Token: 0x0600DE60 RID: 56928 RVA: 0x00209C7D File Offset: 0x00207E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE61 RID: 56929 RVA: 0x00209CAC File Offset: 0x00207EAC
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

		// Token: 0x0600DE62 RID: 56930 RVA: 0x00209CF1 File Offset: 0x00207EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE63 RID: 56931 RVA: 0x00209CFE File Offset: 0x00207EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE64 RID: 56932 RVA: 0x00209D07 File Offset: 0x00207F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE65 RID: 56933 RVA: 0x00209D3C File Offset: 0x00207F3C
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

		// Token: 0x0600DE66 RID: 56934 RVA: 0x00209D7A File Offset: 0x00207F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsResponse other)
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

		// Token: 0x0600DE67 RID: 56935 RVA: 0x00209DAB File Offset: 0x00207FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x00209DB4 File Offset: 0x00207FB4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005BD0 RID: 23504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD1 RID: 23505
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005BD2 RID: 23506
		private ErrorCode errorCode_;
	}
}
