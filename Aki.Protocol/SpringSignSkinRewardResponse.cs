using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001285 RID: 4741
	[NetMessage(EMessageId.SpringSignSkinRewardResponse)]
	public sealed class SpringSignSkinRewardResponse : IMessage<SpringSignSkinRewardResponse>, IMessage, IEquatable<SpringSignSkinRewardResponse>, IDeepCloneable<SpringSignSkinRewardResponse>, IBufferMessage
	{
		// Token: 0x060193F3 RID: 103411 RVA: 0x003AC0F6 File Offset: 0x003AA2F6
		[NullableContext(1)]
		public static SpringSignSkinRewardResponse Create()
		{
			return new SpringSignSkinRewardResponse();
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x060193F4 RID: 103412 RVA: 0x003AC0FD File Offset: 0x003AA2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700552A RID: 21802
		// (get) Token: 0x060193F5 RID: 103413 RVA: 0x003AC100 File Offset: 0x003AA300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignSkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x060193F6 RID: 103414 RVA: 0x003AC107 File Offset: 0x003AA307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse()
		{
		}

		// Token: 0x060193F7 RID: 103415 RVA: 0x003AC10F File Offset: 0x003AA30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse(SpringSignSkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193F8 RID: 103416 RVA: 0x003AC134 File Offset: 0x003AA334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse Clone()
		{
			return new SpringSignSkinRewardResponse(this);
		}

		// Token: 0x1700552B RID: 21803
		// (get) Token: 0x060193F9 RID: 103417 RVA: 0x003AC13C File Offset: 0x003AA33C
		// (set) Token: 0x060193FA RID: 103418 RVA: 0x003AC144 File Offset: 0x003AA344
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

		// Token: 0x060193FB RID: 103419 RVA: 0x003AC14D File Offset: 0x003AA34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignSkinRewardResponse);
		}

		// Token: 0x060193FC RID: 103420 RVA: 0x003AC15B File Offset: 0x003AA35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignSkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193FD RID: 103421 RVA: 0x003AC18C File Offset: 0x003AA38C
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

		// Token: 0x060193FE RID: 103422 RVA: 0x003AC1D1 File Offset: 0x003AA3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193FF RID: 103423 RVA: 0x003AC1DE File Offset: 0x003AA3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019400 RID: 103424 RVA: 0x003AC1E7 File Offset: 0x003AA3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019401 RID: 103425 RVA: 0x003AC21C File Offset: 0x003AA41C
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

		// Token: 0x06019402 RID: 103426 RVA: 0x003AC25A File Offset: 0x003AA45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignSkinRewardResponse other)
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

		// Token: 0x06019403 RID: 103427 RVA: 0x003AC28B File Offset: 0x003AA48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019404 RID: 103428 RVA: 0x003AC294 File Offset: 0x003AA494
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400947E RID: 38014
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400947F RID: 38015
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009480 RID: 38016
		private ErrorCode errorCode_;
	}
}
