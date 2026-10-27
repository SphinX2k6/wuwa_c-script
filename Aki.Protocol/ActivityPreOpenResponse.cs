using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008D RID: 141
	[NetMessage(EMessageId.ActivityPreOpenResponse)]
	public sealed class ActivityPreOpenResponse : IMessage<ActivityPreOpenResponse>, IMessage, IEquatable<ActivityPreOpenResponse>, IDeepCloneable<ActivityPreOpenResponse>, IBufferMessage
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x0004B66C File Offset: 0x0004986C
		[NullableContext(1)]
		public static ActivityPreOpenResponse Create()
		{
			return new ActivityPreOpenResponse();
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0004B673 File Offset: 0x00049873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0004B676 File Offset: 0x00049876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPreOpenResponse.Descriptor;
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004B67D File Offset: 0x0004987D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse()
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0004B685 File Offset: 0x00049885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse(ActivityPreOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0004B6AA File Offset: 0x000498AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse Clone()
		{
			return new ActivityPreOpenResponse(this);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0004B6B2 File Offset: 0x000498B2
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x0004B6BA File Offset: 0x000498BA
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

		// Token: 0x06001ACC RID: 6860 RVA: 0x0004B6C3 File Offset: 0x000498C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPreOpenResponse);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0004B6D1 File Offset: 0x000498D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPreOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0004B700 File Offset: 0x00049900
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

		// Token: 0x06001ACF RID: 6863 RVA: 0x0004B745 File Offset: 0x00049945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0004B752 File Offset: 0x00049952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0004B75B File Offset: 0x0004995B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0004B790 File Offset: 0x00049990
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

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0004B7CE File Offset: 0x000499CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityPreOpenResponse other)
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

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0004B7FF File Offset: 0x000499FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0004B808 File Offset: 0x00049A08
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400226B RID: 8811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400226C RID: 8812
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400226D RID: 8813
		private ErrorCode errorCode_;
	}
}
