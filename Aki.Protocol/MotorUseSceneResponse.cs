using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB4 RID: 2740
	[NetMessage(EMessageId.MotorUseSceneResponse)]
	public sealed class MotorUseSceneResponse : IMessage<MotorUseSceneResponse>, IMessage, IEquatable<MotorUseSceneResponse>, IDeepCloneable<MotorUseSceneResponse>, IBufferMessage
	{
		// Token: 0x0600EE6B RID: 61035 RVA: 0x0022C968 File Offset: 0x0022AB68
		[NullableContext(1)]
		public static MotorUseSceneResponse Create()
		{
			return new MotorUseSceneResponse();
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600EE6C RID: 61036 RVA: 0x0022C96F File Offset: 0x0022AB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x0022C972 File Offset: 0x0022AB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSceneResponse.Descriptor;
			}
		}

		// Token: 0x0600EE6E RID: 61038 RVA: 0x0022C979 File Offset: 0x0022AB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse()
		{
		}

		// Token: 0x0600EE6F RID: 61039 RVA: 0x0022C981 File Offset: 0x0022AB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse(MotorUseSceneResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sceneInUse_ = other.sceneInUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE70 RID: 61040 RVA: 0x0022C9B2 File Offset: 0x0022ABB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneResponse Clone()
		{
			return new MotorUseSceneResponse(this);
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600EE71 RID: 61041 RVA: 0x0022C9BA File Offset: 0x0022ABBA
		// (set) Token: 0x0600EE72 RID: 61042 RVA: 0x0022C9C2 File Offset: 0x0022ABC2
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

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600EE73 RID: 61043 RVA: 0x0022C9CB File Offset: 0x0022ABCB
		// (set) Token: 0x0600EE74 RID: 61044 RVA: 0x0022C9D3 File Offset: 0x0022ABD3
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

		// Token: 0x0600EE75 RID: 61045 RVA: 0x0022C9DC File Offset: 0x0022ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSceneResponse);
		}

		// Token: 0x0600EE76 RID: 61046 RVA: 0x0022C9EA File Offset: 0x0022ABEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSceneResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SceneInUse == other.SceneInUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE77 RID: 61047 RVA: 0x0022CA28 File Offset: 0x0022AC28
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

		// Token: 0x0600EE78 RID: 61048 RVA: 0x0022CA86 File Offset: 0x0022AC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE79 RID: 61049 RVA: 0x0022CA93 File Offset: 0x0022AC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE7A RID: 61050 RVA: 0x0022CA9C File Offset: 0x0022AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneInUse != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SceneInUse);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE7B RID: 61051 RVA: 0x0022CAF8 File Offset: 0x0022ACF8
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

		// Token: 0x0600EE7C RID: 61052 RVA: 0x0022CB50 File Offset: 0x0022AD50
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

		// Token: 0x0600EE7D RID: 61053 RVA: 0x0022CBA0 File Offset: 0x0022ADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE7E RID: 61054 RVA: 0x0022CBAC File Offset: 0x0022ADAC
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
				if (num != 48U)
				{
					if (num != 72U)
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

		// Token: 0x0400606E RID: 24686
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400606F RID: 24687
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006070 RID: 24688
		private ErrorCode errorCode_;

		// Token: 0x04006071 RID: 24689
		public const int SceneInUseFieldNumber = 6;

		// Token: 0x04006072 RID: 24690
		private int sceneInUse_;
	}
}
