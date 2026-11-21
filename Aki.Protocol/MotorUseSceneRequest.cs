using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA2 RID: 2722
	[NetMessage(EMessageId.MotorUseSceneRequest)]
	public sealed class MotorUseSceneRequest : IMessage<MotorUseSceneRequest>, IMessage, IEquatable<MotorUseSceneRequest>, IDeepCloneable<MotorUseSceneRequest>, IBufferMessage
	{
		// Token: 0x0600ED3F RID: 60735 RVA: 0x0022A591 File Offset: 0x00228791
		[NullableContext(1)]
		public static MotorUseSceneRequest Create()
		{
			return new MotorUseSceneRequest();
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600ED40 RID: 60736 RVA: 0x0022A598 File Offset: 0x00228798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600ED41 RID: 60737 RVA: 0x0022A59B File Offset: 0x0022879B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSceneRequest.Descriptor;
			}
		}

		// Token: 0x0600ED42 RID: 60738 RVA: 0x0022A5A2 File Offset: 0x002287A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest()
		{
		}

		// Token: 0x0600ED43 RID: 60739 RVA: 0x0022A5AA File Offset: 0x002287AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest(MotorUseSceneRequest other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED44 RID: 60740 RVA: 0x0022A5CF File Offset: 0x002287CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest Clone()
		{
			return new MotorUseSceneRequest(this);
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0600ED45 RID: 60741 RVA: 0x0022A5D7 File Offset: 0x002287D7
		// (set) Token: 0x0600ED46 RID: 60742 RVA: 0x0022A5DF File Offset: 0x002287DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = value;
			}
		}

		// Token: 0x0600ED47 RID: 60743 RVA: 0x0022A5E8 File Offset: 0x002287E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSceneRequest);
		}

		// Token: 0x0600ED48 RID: 60744 RVA: 0x0022A5F6 File Offset: 0x002287F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSceneRequest other)
		{
			return other != null && (other == this || (this.SceneId == other.SceneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED49 RID: 60745 RVA: 0x0022A624 File Offset: 0x00228824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneId != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED4A RID: 60746 RVA: 0x0022A663 File Offset: 0x00228863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x0022A670 File Offset: 0x00228870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x0022A679 File Offset: 0x00228879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x0022A6AC File Offset: 0x002288AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x0022A6EA File Offset: 0x002288EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSceneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneId != 0)
			{
				this.SceneId = other.SceneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED4F RID: 60751 RVA: 0x0022A71B File Offset: 0x0022891B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED50 RID: 60752 RVA: 0x0022A724 File Offset: 0x00228924
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
					this.SceneId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006074 RID: 24692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006075 RID: 24693
		public const int SceneIdFieldNumber = 14;

		// Token: 0x04006076 RID: 24694
		private int sceneId_;
	}
}
