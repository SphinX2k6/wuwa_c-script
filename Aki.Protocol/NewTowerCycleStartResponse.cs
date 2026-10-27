using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B34 RID: 2868
	[NetMessage(EMessageId.NewTowerCycleStartResponse)]
	public sealed class NewTowerCycleStartResponse : IMessage<NewTowerCycleStartResponse>, IMessage, IEquatable<NewTowerCycleStartResponse>, IDeepCloneable<NewTowerCycleStartResponse>, IBufferMessage
	{
		// Token: 0x0600F8F3 RID: 63731 RVA: 0x002450FC File Offset: 0x002432FC
		[NullableContext(1)]
		public static NewTowerCycleStartResponse Create()
		{
			return new NewTowerCycleStartResponse();
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x00245103 File Offset: 0x00243303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600F8F5 RID: 63733 RVA: 0x00245106 File Offset: 0x00243306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerCycleStartResponse.Descriptor;
			}
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x0024510D File Offset: 0x0024330D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse()
		{
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x00245115 File Offset: 0x00243315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse(NewTowerCycleStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8F8 RID: 63736 RVA: 0x0024513A File Offset: 0x0024333A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartResponse Clone()
		{
			return new NewTowerCycleStartResponse(this);
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600F8F9 RID: 63737 RVA: 0x00245142 File Offset: 0x00243342
		// (set) Token: 0x0600F8FA RID: 63738 RVA: 0x0024514A File Offset: 0x0024334A
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

		// Token: 0x0600F8FB RID: 63739 RVA: 0x00245153 File Offset: 0x00243353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerCycleStartResponse);
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00245161 File Offset: 0x00243361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerCycleStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x00245190 File Offset: 0x00243390
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

		// Token: 0x0600F8FE RID: 63742 RVA: 0x002451D5 File Offset: 0x002433D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8FF RID: 63743 RVA: 0x002451E2 File Offset: 0x002433E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F900 RID: 63744 RVA: 0x002451EB File Offset: 0x002433EB
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

		// Token: 0x0600F901 RID: 63745 RVA: 0x00245220 File Offset: 0x00243420
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

		// Token: 0x0600F902 RID: 63746 RVA: 0x0024525E File Offset: 0x0024345E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerCycleStartResponse other)
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

		// Token: 0x0600F903 RID: 63747 RVA: 0x0024528F File Offset: 0x0024348F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F904 RID: 63748 RVA: 0x00245298 File Offset: 0x00243498
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

		// Token: 0x040063D3 RID: 25555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063D4 RID: 25556
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040063D5 RID: 25557
		private ErrorCode errorCode_;
	}
}
