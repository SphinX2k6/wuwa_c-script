using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000864 RID: 2148
	[NetMessage(EMessageId.JoinSceneNotifyConfirmRequest)]
	public sealed class JoinSceneNotifyConfirmRequest : IMessage<JoinSceneNotifyConfirmRequest>, IMessage, IEquatable<JoinSceneNotifyConfirmRequest>, IDeepCloneable<JoinSceneNotifyConfirmRequest>, IBufferMessage
	{
		// Token: 0x0600BF69 RID: 49001 RVA: 0x001C6B98 File Offset: 0x001C4D98
		[NullableContext(1)]
		public static JoinSceneNotifyConfirmRequest Create()
		{
			return new JoinSceneNotifyConfirmRequest();
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x001C6B9F File Offset: 0x001C4D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x001C6BA2 File Offset: 0x001C4DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotifyConfirmRequest.Descriptor;
			}
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x001C6BA9 File Offset: 0x001C4DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest()
		{
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x001C6BB1 File Offset: 0x001C4DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest(JoinSceneNotifyConfirmRequest other) : this()
		{
			this.sceneTraceId_ = other.sceneTraceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x001C6BD6 File Offset: 0x001C4DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest Clone()
		{
			return new JoinSceneNotifyConfirmRequest(this);
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x001C6BDE File Offset: 0x001C4DDE
		// (set) Token: 0x0600BF70 RID: 49008 RVA: 0x001C6BE6 File Offset: 0x001C4DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SceneTraceId
		{
			get
			{
				return this.sceneTraceId_;
			}
			set
			{
				this.sceneTraceId_ = value;
			}
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x001C6BEF File Offset: 0x001C4DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotifyConfirmRequest);
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x001C6BFD File Offset: 0x001C4DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotifyConfirmRequest other)
		{
			return other != null && (other == this || (this.SceneTraceId == other.SceneTraceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x001C6C2C File Offset: 0x001C4E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneTraceId != 0L)
			{
				num ^= this.SceneTraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x001C6C6B File Offset: 0x001C4E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF75 RID: 49013 RVA: 0x001C6C78 File Offset: 0x001C4E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF76 RID: 49014 RVA: 0x001C6C81 File Offset: 0x001C4E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneTraceId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SceneTraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF77 RID: 49015 RVA: 0x001C6CB4 File Offset: 0x001C4EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneTraceId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SceneTraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x001C6CF2 File Offset: 0x001C4EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinSceneNotifyConfirmRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneTraceId != 0L)
			{
				this.SceneTraceId = other.SceneTraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x001C6D23 File Offset: 0x001C4F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x001C6D2C File Offset: 0x001C4F2C
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
					this.SceneTraceId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005356 RID: 21334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005357 RID: 21335
		public const int SceneTraceIdFieldNumber = 12;

		// Token: 0x04005358 RID: 21336
		private long sceneTraceId_;
	}
}
