using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA3 RID: 2723
	[NetMessage(EMessageId.MotorUseSceneResponse)]
	public sealed class MotorUseSceneResponse : IMessage<MotorUseSceneResponse>, IMessage, IEquatable<MotorUseSceneResponse>, IDeepCloneable<MotorUseSceneResponse>, IBufferMessage
	{
		// Token: 0x0600ED51 RID: 60753 RVA: 0x0022A769 File Offset: 0x00228969
		[NullableContext(1)]
		public static MotorUseSceneResponse Create()
		{
			return new MotorUseSceneResponse();
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x0022A770 File Offset: 0x00228970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600ED53 RID: 60755 RVA: 0x0022A773 File Offset: 0x00228973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSceneResponse.Descriptor;
			}
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x0022A77A File Offset: 0x0022897A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse()
		{
		}

		// Token: 0x0600ED55 RID: 60757 RVA: 0x0022A782 File Offset: 0x00228982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse(MotorUseSceneResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sceneInUse_ = other.sceneInUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED56 RID: 60758 RVA: 0x0022A7B3 File Offset: 0x002289B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse Clone()
		{
			return new MotorUseSceneResponse(this);
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600ED57 RID: 60759 RVA: 0x0022A7BB File Offset: 0x002289BB
		// (set) Token: 0x0600ED58 RID: 60760 RVA: 0x0022A7C3 File Offset: 0x002289C3
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

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600ED59 RID: 60761 RVA: 0x0022A7CC File Offset: 0x002289CC
		// (set) Token: 0x0600ED5A RID: 60762 RVA: 0x0022A7D4 File Offset: 0x002289D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneInUse
		{
			get
			{
				return this.sceneInUse_;
			}
			set
			{
				this.sceneInUse_ = value;
			}
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x0022A7DD File Offset: 0x002289DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSceneResponse);
		}

		// Token: 0x0600ED5C RID: 60764 RVA: 0x0022A7EB File Offset: 0x002289EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSceneResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SceneInUse == other.SceneInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED5D RID: 60765 RVA: 0x0022A82C File Offset: 0x00228A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SceneInUse != 0)
			{
				num ^= this.SceneInUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED5E RID: 60766 RVA: 0x0022A88A File Offset: 0x00228A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED5F RID: 60767 RVA: 0x0022A897 File Offset: 0x00228A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED60 RID: 60768 RVA: 0x0022A8A0 File Offset: 0x00228AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneInUse != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SceneInUse);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED61 RID: 60769 RVA: 0x0022A8F8 File Offset: 0x00228AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SceneInUse != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneInUse);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED62 RID: 60770 RVA: 0x0022A950 File Offset: 0x00228B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSceneResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SceneInUse != 0)
			{
				this.SceneInUse = other.SceneInUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED63 RID: 60771 RVA: 0x0022A9A0 File Offset: 0x00228BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED64 RID: 60772 RVA: 0x0022A9AC File Offset: 0x00228BAC
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
				if (num != 8U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SceneInUse = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006077 RID: 24695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006078 RID: 24696
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006079 RID: 24697
		private ErrorCode errorCode_;

		// Token: 0x0400607A RID: 24698
		public const int SceneInUseFieldNumber = 1;

		// Token: 0x0400607B RID: 24699
		private int sceneInUse_;
	}
}
