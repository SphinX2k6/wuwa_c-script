using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB3 RID: 2739
	[NetMessage(EMessageId.MotorUseSceneRequest)]
	public sealed class MotorUseSceneRequest : IMessage<MotorUseSceneRequest>, IMessage, IEquatable<MotorUseSceneRequest>, IDeepCloneable<MotorUseSceneRequest>, IBufferMessage
	{
		// Token: 0x0600EE59 RID: 61017 RVA: 0x0022C791 File Offset: 0x0022A991
		[NullableContext(1)]
		public static MotorUseSceneRequest Create()
		{
			return new MotorUseSceneRequest();
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600EE5A RID: 61018 RVA: 0x0022C798 File Offset: 0x0022A998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600EE5B RID: 61019 RVA: 0x0022C79B File Offset: 0x0022A99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSceneRequest.Descriptor;
			}
		}

		// Token: 0x0600EE5C RID: 61020 RVA: 0x0022C7A2 File Offset: 0x0022A9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest()
		{
		}

		// Token: 0x0600EE5D RID: 61021 RVA: 0x0022C7AA File Offset: 0x0022A9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest(MotorUseSceneRequest other) : this()
		{
			this.sceneId_ = other.sceneId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE5E RID: 61022 RVA: 0x0022C7CF File Offset: 0x0022A9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSceneRequest Clone()
		{
			return new MotorUseSceneRequest(this);
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x0022C7D7 File Offset: 0x0022A9D7
		// (set) Token: 0x0600EE60 RID: 61024 RVA: 0x0022C7DF File Offset: 0x0022A9DF
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

		// Token: 0x0600EE61 RID: 61025 RVA: 0x0022C7E8 File Offset: 0x0022A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSceneRequest);
		}

		// Token: 0x0600EE62 RID: 61026 RVA: 0x0022C7F6 File Offset: 0x0022A9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSceneRequest other)
		{
			return other != null && (other == this || (this.SceneId == other.SceneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE63 RID: 61027 RVA: 0x0022C824 File Offset: 0x0022AA24
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

		// Token: 0x0600EE64 RID: 61028 RVA: 0x0022C863 File Offset: 0x0022AA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE65 RID: 61029 RVA: 0x0022C870 File Offset: 0x0022AA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE66 RID: 61030 RVA: 0x0022C879 File Offset: 0x0022AA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SceneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE67 RID: 61031 RVA: 0x0022C8AC File Offset: 0x0022AAAC
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

		// Token: 0x0600EE68 RID: 61032 RVA: 0x0022C8EA File Offset: 0x0022AAEA
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

		// Token: 0x0600EE69 RID: 61033 RVA: 0x0022C91B File Offset: 0x0022AB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE6A RID: 61034 RVA: 0x0022C924 File Offset: 0x0022AB24
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SceneId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400606B RID: 24683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400606C RID: 24684
		public const int SceneIdFieldNumber = 1;

		// Token: 0x0400606D RID: 24685
		private int sceneId_;
	}
}
