using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000853 RID: 2131
	[NetMessage(EMessageId.JoinSceneNotifyConfirmRequest)]
	public sealed class JoinSceneNotifyConfirmRequest : IMessage<JoinSceneNotifyConfirmRequest>, IMessage, IEquatable<JoinSceneNotifyConfirmRequest>, IDeepCloneable<JoinSceneNotifyConfirmRequest>, IBufferMessage
	{
		// Token: 0x0600BE4D RID: 48717 RVA: 0x001C48B0 File Offset: 0x001C2AB0
		[NullableContext(1)]
		public static JoinSceneNotifyConfirmRequest Create()
		{
			return new JoinSceneNotifyConfirmRequest();
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x0600BE4E RID: 48718 RVA: 0x001C48B7 File Offset: 0x001C2AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600BE4F RID: 48719 RVA: 0x001C48BA File Offset: 0x001C2ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotifyConfirmRequest.Descriptor;
			}
		}

		// Token: 0x0600BE50 RID: 48720 RVA: 0x001C48C1 File Offset: 0x001C2AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest()
		{
		}

		// Token: 0x0600BE51 RID: 48721 RVA: 0x001C48C9 File Offset: 0x001C2AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest(JoinSceneNotifyConfirmRequest other) : this()
		{
			this.sceneTraceId_ = other.sceneTraceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE52 RID: 48722 RVA: 0x001C48EE File Offset: 0x001C2AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotifyConfirmRequest Clone()
		{
			return new JoinSceneNotifyConfirmRequest(this);
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x0600BE53 RID: 48723 RVA: 0x001C48F6 File Offset: 0x001C2AF6
		// (set) Token: 0x0600BE54 RID: 48724 RVA: 0x001C48FE File Offset: 0x001C2AFE
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

		// Token: 0x0600BE55 RID: 48725 RVA: 0x001C4907 File Offset: 0x001C2B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotifyConfirmRequest);
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x001C4915 File Offset: 0x001C2B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotifyConfirmRequest other)
		{
			return other != null && (other == this || (this.SceneTraceId == other.SceneTraceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x001C4944 File Offset: 0x001C2B44
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

		// Token: 0x0600BE58 RID: 48728 RVA: 0x001C4983 File Offset: 0x001C2B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x001C4990 File Offset: 0x001C2B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x001C4999 File Offset: 0x001C2B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneTraceId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SceneTraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x001C49CC File Offset: 0x001C2BCC
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

		// Token: 0x0600BE5C RID: 48732 RVA: 0x001C4A0A File Offset: 0x001C2C0A
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

		// Token: 0x0600BE5D RID: 48733 RVA: 0x001C4A3B File Offset: 0x001C2C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x001C4A44 File Offset: 0x001C2C44
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SceneTraceId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400535D RID: 21341
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400535E RID: 21342
		public const int SceneTraceIdFieldNumber = 10;

		// Token: 0x0400535F RID: 21343
		private long sceneTraceId_;
	}
}
